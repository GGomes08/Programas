def desconto(preco, desconto):
    precoDesconto = preco*(desconto/100)
    precoPos = preco - precoDesconto
    precoPos = round(precoPos,2)
    return precoPos

precoOri = int(input("Digite o preço original: "))
DescPorc = int(input("Digite a porcentagem do desconto: "))
print(desconto(precoOri,DescPorc))