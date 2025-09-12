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
def ejer3():
    monto = float(input("Ingresar monto: "))

    print("Selecciona la moneda a la que desea convertirla:")
    print("[1] Dólares (USD) - 1 USD = 3.75 PEN")
    print("[2] Euros (EUR) - 1 EUR = 4.05 PEN")
    opción = input("Opción: ")

    if opción == "1":
        print("Monto final en Dólares: ", (monto/3.75))
    else: 
        if opción == "2":
            print("Monto final en Euros: ", (monto/4.05))
        else:
            print("Opción invalida")

ejer3()