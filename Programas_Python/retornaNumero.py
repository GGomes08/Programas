def listaNumeral():
 test_list = ['Rs 24', 'Rs 18', 'Rs 8', 'Rs 21', ' 24 ']
  
 # printing original list
 print("A lista Original : " + str(test_list))
  
 # using list comprehension + split()
 # Extracting numbers from list of strings
 res = [int(sub.split(' ')[1]) for sub in test_list]
  
 # print result
 print("Lista Numerada : " + str(res))

print(listaNumeral())    