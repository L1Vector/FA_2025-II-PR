def ejer1():
    #Declaracion y escritura
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido a Fa de {carrera}") 
def ejer2():
    print("\"\"Luis\"\"") #Así puedes ingresar comillas dobles)
def ejer3():
    x = int(input("Ingrese el valor de x: "))
    y = int(input("Ingrese el valor de y: "))

    print("Suma: ", (x+y))
    print("Resta: ", (x-y))
    print("Multiplicación: ", (x*y))
    print("División: ", (x/y))

import math #importando librería de math

def ejer4():
    num = float(input("Ingrese un número decimal: "))

    print("Raíz cuadrada: ", math.sqrt(num))
    print("Redondeo: ", round(num))
    print("Al cubo: ", math.pow(num, 3))
    print("Raiz3: ", math.pow(num, 1/3)) #Tambien su puede escribir num ** (1/3) para dar potencia a num de 1/3
def ejer5():
    num = input("Ingresar número: ")
    deci = float(num)
    entero = round(deci)

    print("Resto de división con 2: ", entero%2)
    print("Cociente de división con 3: ", deci//3)

ejer5()