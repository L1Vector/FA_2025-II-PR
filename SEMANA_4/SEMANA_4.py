def ejer1():
    edad = int(input("Ingresar una edad: "))

    if edad < 18:
        print("Menor de edad")
    else:
        if edad >=18 and edad <=64:
            print("Adulto")
        else:
           print("Adulto mayor")
def ejer2():
    a�o = int(input("Ingresar un a�o: "))

    if (a�o%4 == 0 and a�o % 100 != 0) or (a�o%400 == 0):
        print("El a�o es Bisiesto.")
    else:
        print("El a�o no es bisiesto")
    if (a�o%2 == 0):
        print("El a�o es par.")
    else:
        print("El a�o es impar.")

ejer2()

