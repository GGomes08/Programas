def contaXeOs(palavra):
    contaX = 0
    contaO = 0

    for i in palavra:
        if i == 'x' or i == 'X':
            contaX += 1

        elif i == 'o' or i == 'O':
            contaO += 1
    
    if contaX == contaO:
        palavra = True
    else: palavra = False 
    
    return palavra  

print(contaXeOs("ooOXx"))     
print(contaXeOs("oxoOXX"))
print(contaXeOs("sawDF"))          
            

