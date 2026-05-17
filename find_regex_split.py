import os
import re

for root, _, files in os.walk("src"):
    for f in files:
        if not f.endswith(".cs"): continue
        path = os.path.join(root, f)
        with open(path, "r", encoding="utf-8") as file:
            content = file.read()
            if "Regex.Replace" in content and ".Split(" in content:
                print(f"--- {path} ---")
                lines = content.split('\n')
                for i, line in enumerate(lines):
                    if "Regex.Replace" in line and ".Split(" in line:
                        print(f"{i+1}: {line.strip()}")
