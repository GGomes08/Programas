decimal = int(input("Apresente um numero decimal:"))
binario = 0
contador = 0
aux = decimal

while(aux > 0):
    binario = ((aux%2)*(10**contador))+binario
    aux = int(aux/2)
    contador +=1
    
print("O Binario de {x} é:  {y}".format(x=decimal, y=binario))