from PIL import Image, ImageFilter

try:
    original = Image.open("D:/GitHub Works/MyLabs/Python works/unnamed.jpg")
    
    
    #Поворот на 30
    original = original.rotate(30)
    original.save("rotated_picture.jpg")
    
    
    #Обрезка
    original = Image.open("D:/GitHub Works/MyLabs/Python works/unnamed.jpg")
    width, height = original.size
    area = (0, 0, width/2, height/2)
    img = original.crop(area)
    img.save("cropped_picture.jpg")


    #Изменение размера
    original = Image.open("D:/GitHub Works/MyLabs/Python works/unnamed.jpg")
    width, height = original.size
    img = original.resize((width//2, height//2))
    img.save("resized_picture.jpg")
    
    
    #Транспонирование
    original = Image.open("D:/GitHub Works/MyLabs/Python works/unnamed.jpg")
    transposed_img = original.transpose(Image.FLIP_LEFT_RIGHT)
    transposed_img.save("transposed.jpg")
    
    
    #Создание миниатюры
    size = (256, 256)
    saved = "Miniature.jpg"
    original = Image.open("D:/GitHub Works/MyLabs/Python works/unnamed.jpg")
    original.thumbnail(size)
    original.save(saved)
    original.show()

    
    # Применить три разных фильтра
    original = Image.open("D:/GitHub Works/MyLabs/Python works/unnamed.jpg")
    img1 = original.filter(ImageFilter.SHARPEN)
    img2 = img1.filter(ImageFilter.BLUR)
    img3 = img2.filter(ImageFilter.SMOOTH)
    img1.save("Filter1" + ".jpg")
    img2.save("Filter2" + ".jpg")
    img3.save("Filter3" + ".jpg")
    img3.show()

except FileNotFoundError:
    print("Файл не найден")