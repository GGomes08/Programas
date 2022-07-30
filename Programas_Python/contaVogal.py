palavra = input("Digite sua palavra:")
vogal = 0

for i in palavra:
    if(i == 'a' or i == 'e' or i == 'i' or i == 'o' or i == 'u'
      or i == 'A' or i == 'E' or i == 'I' or i == 'O' or i == 'U'):
        vogal = vogal + 1
        

print("O total de vogais da palavra {x} é: {y} vogais".format(x=palavra, y=vogal))