Algoritmo Act4_Lecc23_Inciso1
    Escribir "========================================"
    Escribir "   LECCION 23 - ACTIVIDAD 4 - INCISO 1"
    Escribir "     TABLA DE MULTIPLICAR EN C# - MIENTRAS"
    Escribir "========================================"
    Definir numero, contador, resultado Como Entero
    Escribir "Ingrese un numero: " Sin Saltar
    Leer numero
    contador <- 1
    Mientras contador <= 10 Hacer
        resultado <- numero * contador
        Escribir "Progreso del ciclo: linea ", contador, " de 10"
        Escribir numero, " x ", contador, " = ", resultado
        contador <- contador + 1
    FinMientras
    Escribir "Tabla terminada."
    Esperar Tecla
FinAlgoritmo
