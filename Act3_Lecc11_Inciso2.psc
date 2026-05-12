Algoritmo Act3_Lecc11_Inciso2
	Escribir "========================================"
    Escribir "   LECCION 11 - ACTIVIDAD 3 - INCISO 2"
    Escribir "       SUMAR HASTA INGRESAR 0"
    Escribir "========================================"
    Escribir "Ingrese numeros para sumarlos. Para terminar ingrese 0."
    Definir numero, suma, contador Como Entero
    suma <- 0
    contador <- 1
    Repetir
        Escribir "Progreso del ciclo: lectura ", contador
        Escribir "Ingrese un numero: " Sin Saltar
        Leer numero
        suma <- suma + numero
        Escribir "Suma actual: ", suma
        contador <- contador + 1
        Escribir "----------------------------------------"
    Hasta Que numero = 0
	
    Escribir "El usuario ingreso 0, por eso termino el ciclo."
    Escribir "La suma final es: ", suma
    Esperar Tecla
FinAlgoritmo
