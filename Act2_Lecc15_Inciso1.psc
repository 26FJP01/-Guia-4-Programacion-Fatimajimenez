Algoritmo Act2_Lecc15_Inciso1
    Escribir "========================================"
    Escribir "   LECCION 15 - ACTIVIDAD 2 - INCISO 1"
    Escribir "    PRIMOS ENTRE 1 Y 100 Y SU SUMA"
    Escribir "========================================"
    Definir numero, divisor, divisores, cantidadPrimos, sumaPrimos Como Entero
    numero <- 1
    cantidadPrimos <- 0
    sumaPrimos <- 0
    Mientras numero <= 100 Hacer
        divisor <- 1
        divisores <- 0
        Mientras divisor <= numero Hacer
            Si numero MOD divisor = 0 Entonces
                divisores <- divisores + 1
            FinSi
            divisor <- divisor + 1
        FinMientras
        Escribir "Progreso del ciclo: revisando numero ", numero, " de 100"
        Si numero > 1 Y divisores = 2 Entonces
            cantidadPrimos <- cantidadPrimos + 1
            sumaPrimos <- sumaPrimos + numero
            Escribir numero, " es primo."
        FinSi
        numero <- numero + 1
    FinMientras
    Escribir "Cantidad de numeros primos: ", cantidadPrimos
    Escribir "Suma de numeros primos: ", sumaPrimos
    Esperar Tecla
FinAlgoritmo
