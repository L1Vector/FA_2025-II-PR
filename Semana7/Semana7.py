def ejer1():

    p=i=0

    while True:
        num = int(input("Ingrese número entero(negativo para salir): "))

        if num < 0:
            break
        if num%2 == 0: p+1
        else: i+=1

    print("\nCantidad pares: ", p)
    print("\nCantidad impares: ", i)
   
def ejer2():
    while True:
        num = int(input("Ingrese un número positivo: "))
        suma = 0

        for i in range(1,num+1):
            suma += i
            print(i, end=" ")

        print("\nSuma: ",suma)
        opc = input("\n¿Deseas continuar? (S/N): ")

        if(opc == "N"): break

ejer2()