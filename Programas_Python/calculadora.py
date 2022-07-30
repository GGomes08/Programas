num1=int(input("Digite o primeiro numero: "))
opNum = input("Digite o operador numerico: ") 
num2=int(input("Digite agora o segundo numero: ")) 
def calculadora (x,op,y): 

   
   if op == '+':
    print(x + y)
       
   elif op == '-':
    print(x - y)
    
   elif op == '*':
    print(x * y)
    
   elif op == '/':
    print(x / y)
    
            
calculadora(num1,opNum,num2)            