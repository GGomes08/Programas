
def lista_ord(listaNumeros,metodoLista=None):
    if 'asc' in metodoLista:
        list.sort(listaNumeros)
    elif 'desc' in metodoLista:
        list.sort(listaNumeros,reverse=True)

    return listaNumeros

lista = [3,-7,9,-45,0,15,-5,5,14,13,-27,75]
metodoOrdena = input("Digite o metodo que deseja seja ele 'asc' ou 'desc': ")
print(lista_ord(lista,metodoOrdena))