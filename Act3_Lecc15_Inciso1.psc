Algoritmo Act3_Lecc15_Inciso1
	Escribir "========================================"
    Escribir "   LECCION 15 - ACTIVIDAD 3 - INCISO 1"
    Escribir " MULTIPLOS DE 7, SUMA Y PARES - MIENTRAS"
    Escribir "========================================"
    Definir contador, multiplo, suma, pares Como Entero
    contador <- 1
    suma <- 0
    pares <- 0
    Mientras contador <= 20 Hacer
        multiplo <- 7 * contador
        suma <- suma + multiplo
        Escribir "Progreso del ciclo: multiplo ", contador, " de 20"
        Escribir "Multiplo: ", multiplo, " | Suma actual: ", suma
        Si multiplo MOD 2 = 0 Entonces
            pares <- pares + 1
        FinSi
        contador <- contador + 1
    FinMientras
    Escribir "Suma total de los 20 multiplos de 7: ", suma
    Escribir "Cantidad de multiplos pares: ", pares
    Esperar Tecla
FinAlgoritmo
