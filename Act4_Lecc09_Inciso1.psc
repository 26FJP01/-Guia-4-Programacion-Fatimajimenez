Algoritmo Act4_Lecc09_Inciso1
    Escribir "========================================"
    Escribir "   LECCION 09 - ACTIVIDAD 4 - INCISO 1"
    Escribir "       TABLA DE MULTIPLICAR - MIENTRAS"
    Escribir "========================================"
    Definir numero, contador, resultado Como Entero
    Escribir "Ingrese un numero para la tabla: " Sin Saltar
    Leer numero
    contador <- 1
    Mientras contador <= 10 Hacer
        resultado <- numero * contador
        Escribir "Progreso del ciclo: multiplicacion ", contador, " de 10"
        Escribir numero, " x ", contador, " = ", resultado
        contador <- contador + 1
    FinMientras
    Escribir "Tabla terminada."
    Esperar Tecla
FinAlgoritmo