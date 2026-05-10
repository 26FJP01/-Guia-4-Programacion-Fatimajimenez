Algoritmo Act3_Lecc10_Inciso1
    Escribir "========================================"
    Escribir "   LECCION 10 - ACTIVIDAD 3 - INCISO 1"
    Escribir "    PRIMO ENTRE 1 Y 22 - PARA"
    Escribir "========================================"
    Definir numero, divisor, divisores Como Entero
    Escribir "Ingrese un numero entre 1 y 22: " Sin Saltar
    Leer numero
    divisores <- 0
    Si numero >= 1 Y numero <= 22 Entonces
        Para divisor <- 1 Hasta numero Con Paso 1 Hacer
            Escribir "Progreso del ciclo: probando divisor ", divisor
			
            Si numero MOD divisor = 0 Entonces
                divisores <- divisores + 1
            FinSi
        FinPara
        Si numero > 1 Y divisores = 2 Entonces
            Escribir numero, " es primo."
        Sino
            Escribir numero, " no es primo."
        FinSi
    Sino
        Escribir "El numero no esta entre 1 y 22."
    FinSi
	
    Esperar Tecla
FinAlgoritmo