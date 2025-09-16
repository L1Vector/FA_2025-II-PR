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
    anio = int(input("Ingresar un año: "))

    if (anio%4 == 0 and anio % 100 != 0) or (anio%400 == 0):
        print("El año es Bisiesto.")
    else:
        print("El año no es bisiesto")
    if (anio%2 == 0):
        print("El año es par.")
    else:
        print("El año es impar.")

def ejer3():
    monto = float(input("Ingresar monto en soles: "))

    print("Selecciona la moneda a la que desea convertirla:")
    print("\n1. Dólares \n2. Euros")
    opción = int(input("Opción: "))

    match opción: 
        case "1":
            print("Monto final en Dólares: ", (monto/3.75))
        case "2":
            print("Monto final en Euros: ", (monto/4.05))
        case _:
            print("Opción invalida")

import math

def ejer4():
    print("Seleccione el área de la figura que desee calcular: ")
    print("[1] Área de un cuadrado")
    print("[2] Área de un rectángulo")
    print("[3] Área de un triángulo")
    print("[4] Área de un círculo")
    opción = input("Opción: ")

    if opción == "1":
        lado = float(input("Ingresar un lado: "))
        
        print("Área de un cuadrado: ", math.pow(lado, 2))
    elif opción == "2":
        base = float(input("Ingresar base: "))
        altura = float(input("Ingresar altura: "))

        print("Área del rectángulo: ", base * altura)
    elif opción == "3":
        base = float(input("Ingresar base: "))
        altura = float(input("Ingresar altura: "))

        print("Área del Triángulo: ", (base * altura)/2)
    elif opción == "4":
        radio = float(input("Ingresar radio: "))

        print("Área del círculo: ", (math.pow(radio, 2)*math.pi))
    else:
        print("Valor ingresado incorrecto")

ejer4()