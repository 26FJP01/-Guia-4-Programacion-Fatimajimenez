Algoritmo  Act2_Lecc11_Inciso3
	Escribir "========================================"
    Escribir "   LECCION 11 - ACTIVIDAD 2 - INCISO 3"
    Escribir "     MULTIPLOS DE 4 ENTRE DOS NUMEROS"
    Escribir "========================================"
    Definir numero1, numero2, menor, mayor, contador, paso Como Entero
    Escribir "Ingrese el primer numero: " Sin Saltar
    Leer numero1
    Escribir "Ingrese el segundo numero: " Sin Saltar
    Leer numero2
    Si numero1 <= numero2 Entonces
        menor <- numero1
        mayor <- numero2
    Sino
        menor <- numero2
        mayor <- numero1
    FinSi
    contador <- menor
    paso <- 1
    Repetir
        Escribir "Progreso del ciclo: revisando ", contador, " | paso ", paso
		
        Si contador MOD 4 = 0 Entonces
            Escribir contador, " es multiplo de 4."
        FinSi
        contador <- contador + 1
        paso <- paso + 1
    Hasta Que contador > mayor
    Escribir "Proceso terminado."
    Esperar Tecla
FinAlgoritmo
