Algoritmo Act3_Lecc9_Inciso2
	Escribir "========================================"
    Escribir "   LECCION 9 - ACTIVIDAD 3 - INCISO 2"
    Escribir "       NUMERO PRIMO - MIENTRAS"
    Escribir "========================================"
    Definir numero, divisor, divisores Como Entero
    Escribir "Ingrese un numero entero: " Sin Saltar
    Leer numero
    divisor <- 1
    divisores <- 0
    Mientras divisor <= numero Hacer
        Escribir "Progreso del ciclo: probando divisor ", divisor
        Si numero MOD divisor = 0 Entonces
            divisores <- divisores + 1
        FinSi
        divisor <- divisor + 1
    FinMientras
    Si numero > 1 Y divisores = 2 Entonces
        Escribir numero, " es un numero primo."
    Sino
        Escribir numero, " no es un numero primo."
    FinSi
    Escribir "Cantidad de divisores encontrados: ", divisores
    Esperar Tecla
FinAlgoritmo
