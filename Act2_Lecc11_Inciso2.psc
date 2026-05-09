Algoritmo Act2_Lecc11_Inciso2
	Escribir "========================================"
    Escribir "   LECCION 11 - ACTIVIDAD 2 - INCISO 2"
    Escribir "       NUMEROS DEL 1 AL 100 - REPETIR"
    Escribir "========================================"
	
    Definir numero Como Entero
    numero <- 1
	
    Repetir
        Escribir "Progreso del ciclo: mostrando numero ", numero, " de 100"
        Escribir numero
        numero <- numero + 1
    Hasta Que numero > 100
	
    Escribir "Proceso terminado."
    Esperar Tecla
FinAlgoritmo
