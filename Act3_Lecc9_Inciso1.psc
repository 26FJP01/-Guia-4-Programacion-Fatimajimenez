Algoritmo Act3_Lecc9_Inciso1
	Escribir "========================================"
    Escribir "   LECCION 9 - ACTIVIDAD 3 - INCISO 1"
    Escribir "        ENTEROS IMPARES - MIENTRAS"
    Escribir "========================================"
    Definir numero, inicio, fin, contador, paso Como Entero
    Escribir "Ingrese un numero entero: " Sin Saltar
    Leer numero
    Si numero >= 20 Entonces
        inicio <- 20
	fin <- numero
Sino
	inicio <- numero
fin <- 20
FinSi
contador <- inicio
paso <- 1
Escribir "Impares comprendidos entre ", inicio, " y ", fin, ":"

Mientras contador <= fin Hacer
	Escribir "Progreso del ciclo: revision ", paso, " con el numero ", contador
	Si contador MOD 2 <> 0 Entonces
		Escribir contador, " es impar."
	FinSi
	contador <- contador + 1
	paso <- paso + 1
FinMientras

Escribir "Proceso terminado."
Esperar Tecla
FinAlgoritmo
