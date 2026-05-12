Algoritmo Actividad1_11_inc1
	Escribir "========================================"
    Escribir "   LECCION 11 - ACTIVIDAD 1 - INCISO 1"
    Escribir "       ESTACIONAMIENTO - REPETIR"
    Escribir "========================================"
    Escribir "El estacionamiento tiene cupo para 20 autos."
    Definir autos, espacios Como Entero
    autos <- 0
    espacios <- 20
    Repetir
        Escribir "Progreso del ciclo: auto ", autos + 1, " de 20"
        Escribir "Presione una tecla para registrar el ingreso del auto..."
        Esperar Tecla
		
        autos <- autos + 1
        espacios <- 20 - autos
        Escribir "Autos dentro: ", autos
        Escribir "Espacios vacios: ", espacios
        Escribir "----------------------------------------"
    Hasta Que autos = 20
    Escribir "El estacionamiento esta lleno."
    Esperar Tecla
FinAlgoritmo
