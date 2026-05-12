Algoritmo Act3_Lecc11_Inciso1
	Escribir "========================================"
    Escribir "   LECCION 11 - ACTIVIDAD 3 - INCISO 1"
    Escribir "       SUMA ENTRE DOS NUMEROS"
    Escribir "========================================"
    Definir numero1, numero2, menor, mayor, suma, contador Como Entero
    Escribir "Ingrese el primer numero: " Sin Saltar
    Leer numero1
    Escribir "Ingrese el segundo numero: " Sin Saltar
    Leer numero2
    suma <- 0
    Si numero1 <= numero2 Entonces
        menor <- numero1
        mayor <- numero2
    Sino
        menor <- numero2
        mayor <- numero1
    FinSi
    contador <- menor
    Repetir
        suma <- suma + contador
        Escribir "Progreso del ciclo: se sumo ", contador, " | suma actual: ", suma
        contador <- contador + 1
    Hasta Que contador > mayor
FinAlgoritmo
