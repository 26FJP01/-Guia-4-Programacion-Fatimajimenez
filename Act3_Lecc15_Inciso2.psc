Algoritmo  Act3_Lecc15_Inciso2
	Escribir "========================================"
    Escribir "   LECCION 15 - ACTIVIDAD 3 - INCISO 2"
    Escribir "    REGRESIVA 300 A 1 - PRIMOS Y PARES"
    Escribir "========================================"
    Definir numero, cantidadPrimos, sumaPares, divisor, divisores Como Entero
    numero <- 300
    cantidadPrimos <- 0
    sumaPares <- 0
    Mientras numero >= 1 Hacer
        Escribir "Progreso del ciclo: revisando ", numero
        Si numero MOD 2 = 0 Entonces
            sumaPares <- sumaPares + numero
        FinSi
        divisor <- 1
        divisores <- 0
        Mientras divisor <= numero Hacer
            Si numero MOD divisor = 0 Entonces
                divisores <- divisores + 1
            FinSi
            divisor <- divisor + 1
        FinMientras
        Si numero > 1 Y divisores = 2 Entonces
            cantidadPrimos <- cantidadPrimos + 1
        FinSi
        numero <- numero - 1
    FinMientras
    Escribir "Cantidad de numeros primos entre 300 y 1: ", cantidadPrimos
    Escribir "Suma de numeros pares entre 300 y 1: ", sumaPares
    Esperar Tecla
FinAlgoritmo
