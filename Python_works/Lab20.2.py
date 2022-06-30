from urllib.parse import urlparse
url = urlparse("{scheme}//www.youtube.com{path}?v=JWuamfPm18Q".format(
    path = '/watch', 
    scheme = 'http'))
print(url)