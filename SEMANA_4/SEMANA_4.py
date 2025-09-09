def ejer1():
    edad = int(input("Ingresar una edad: "))

    if edad < 18:
        print("Menor de edad")
    else:
        if edad >=18 and edad <=64:
            print("Adulto")
        else:
           print("Adulto mayor")
ejer1()

