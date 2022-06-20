def getTotalPriceofShoppingBag(ShoppingBag):
    print(ShoppingBag.keys)
################################################
# OrangeJuice = { "price": 1.5, "discount": 10}
gracies = {
    "OrangeJuice": {
        "price": 1.5,
        "discount": 10
    },
    "Chocolate": {
        "price": 2,
        "discount": 10
    }
}

ShoppingBag = [{ "product": "OrangeJuice", "quantity": 3}, {"product": "Choclate", "quantity": 2}]
getTotalPriceofShoppingBag(gracies)