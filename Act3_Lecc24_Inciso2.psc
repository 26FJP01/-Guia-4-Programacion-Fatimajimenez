Algoritmo Act3_Lecc24_Inciso2
    Escribir "========================================"
    Escribir "   LECCION 24 - ACTIVIDAD 3 - INCISO 2"
    Escribir "      CUENTA REGRESIVA Y SUMA - PARA"
    Escribir "========================================"
    Definir numero, contador, suma Como Entero
    Escribir "Ingrese un numero entero positivo: " Sin Saltar
    Leer numero
    suma <- 0
    Si numero >= 1 Entonces
        Para contador <- numero Hasta 1 Con Paso -1 Hacer
            suma <- suma + contador
            Escribir "Progreso del ciclo: numero ", contador, " | suma actual: ", suma
        FinPara
        Escribir "La suma total es: ", suma
    Sino
        Escribir "Debe ingresar un numero mayor o igual a 1."
    FinSi
    Esperar Tecla
FinAlgoritmo
