from PIL import Image

try:
    original1 = Image.open("cropped_picture.jpg")
    original2 = Image.open("resized_picture.jpg")
    original3 = Image.open("Miniature.jpg")
    original4 = Image.open("Filter3.jpg")
    print("Информация Изображения 1: ")
    print(original1.format, original1.size, original1.mode)


    print("Информация Изображения 2: ")
    print(original2.format, original2.size, original2.mode)


    print("Информация Изображения 3: ")
    print(original3.format, original3.size, original3.mode)


    print("Информация Изображения 4: ")
    print(original4.format, original4.size, original4.mode)

except FileNotFoundError:
    print("Файл не найден")