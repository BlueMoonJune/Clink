from PIL import Image
from sys import argv

temp = Image.open(argv[2])
source = Image.open(argv[1])

(width, height) = temp.size

for y in range(height):
    for x in range(width):
            (r, g, b, a) = temp.getpixel((x,y))
            if b != 0 or a != 255:
                    continue
            temp.putpixel((x,y), source.getpixel((r, g)))
temp.save(argv[3] + "/" + argv[1])
