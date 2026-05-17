import sys

def get_lines(filename, lines_str):
    line_nums = [int(x) for x in lines_str.split(',')]
    with open(filename, 'r', encoding='utf-8') as f:
        lines = f.readlines()
        for num in line_nums:
            print(f"{filename}:{num}: {lines[num-1].strip()}")

get_lines(sys.argv[1], sys.argv[2])
