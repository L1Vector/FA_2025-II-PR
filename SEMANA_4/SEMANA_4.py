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
    año = int(input("Ingresar un año: "))

    if (año%4 == 0 and año % 100 != 0) or (año%400 == 0):
        print("El año es Bisiesto.")
    else:
        print("El año no es bisiesto")
    if (año%2 == 0):
        print("El año es par.")
    else:
        print("El año es impar.")

ejer2()

