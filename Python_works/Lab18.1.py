from PIL import Image, ImageDraw, ImageFont
im = Image.new('RGB', (700, 500), 'red')
draw = ImageDraw.Draw(im)

draw.ellipse((100, 100, 150, 200), fill='white', outline=(0, 0, 0))
draw.ellipse((0, 0, 90, 90), 'yellow', 'blue')
draw.rectangle((200, 100, 300, 200), fill='blue', outline=(255, 255, 255))
draw.rectangle((350, 240, 450, 100), fill='blue', outline=(255, 255, 255))
draw.line((700, 300, 500, 100), fill='pink', width=10)
draw.polygon(
xy=(
(200, 200),
(300, 100),
(250, 50)
), fill='purple', outline=(0, 0, 0)
)
draw.point(
xy=(
(350, 200),
(450, 100),
(400, 50)
), fill='black'
)
draw.arc(
xy=(25, 50, 175, 200),
start=30, end=270,
fill='white'
)
# Рисуем хорду.
draw.chord(
xy=(225, 50, 375, 200),
start=30, end=270, fill=(255, 255, 0),
outline=(0, 0, 0))

draw.pieslice(
xy=(425, 50, 575, 200),
start=30, end=270, fill='grey',
outline=(0, 0, 0)
)

font = ImageFont.truetype('C:/Users/dorak/Desktop/KURS_WORK/res/timesnewromanpsmt.ttf', size=18)
draw_text = ImageDraw.Draw(im)
draw_text.text(
(100, 400),
'«Привет, меня зовут Кукла Мне 0 лет. Я учусь на программиста.»',
# Добавляем шрифт к изображению
font=font,
fill='#1C0606')
watermark = Image.open('C:/Users/dorak/Desktop/KURS_WORK/res/frame.png')
im.paste(watermark, (25,200), watermark)
im.show()