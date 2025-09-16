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
        case 1:
            print("Dólares: ", round((monto/3.75),0))
        case 2:
            print(f"Euros: {monto/4.05:.2f}")
        case _:
            print("Opción invalida")

import math

def ejer4():
    print("Bienvenido al sistema de cálculos de áreas: ")
    print("\n1. Área de un cuadrado \n2. Área de un rectángulo \n3. Área de un triángulo \n4. Área de un círculo")
    
    opción = int(input("\nIngrese una opción: "))

    match opción: 
        case 1:
            lado = float(input("\nIngresar un lado: "))
            print("\nÁrea de un cuadrado: ", math.pow(lado, 2))
        
        case 2:
            base = float(input("\nIngresar base: "))
            altura = float(input("Ingresar altura: "))

            print("\nÁrea del rectángulo: ", base * altura)
        case 3:
            base = float(input("\nIngresar base: "))
            altura = float(input("Ingresar altura: "))

            print("\nÁrea del Triángulo: ", (base * altura)/2)
        case 4:
            radio = float(input("\nIngresar radio: "))

            print("\nÁrea del círculo: ", (math.pow(radio, 2)*math.pi))
        case _:
            print("\nValor ingresado incorrecto")

ejer4()