import urllib.parse
url_parts = ['http', 'www.youtube.com', '/watch', 'v=-ybKsFjHPe4']
youtube_url = urllib.parse.urlunparse((url_parts[0], url_parts[1], url_parts[2], None, url_parts[3], None))
print(youtube_url)