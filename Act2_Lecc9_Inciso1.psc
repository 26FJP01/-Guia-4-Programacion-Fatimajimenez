Algoritmo Act2_Lecc9_Inciso1
	Escribir "========================================"
    Escribir "   LECCION 09 - ACTIVIDAD 2 - INCISO 1"
    Escribir "       NIVEL BLOQUEADO - MIENTRAS"
    Escribir "========================================"
    Escribir "El nivel 5 se desbloquea al llegar a 350 monedas."
    Definir monedas, ronda, ganadas Como Entero
    Escribir "Ingrese cuantas monedas tiene actualmente: " Sin Saltar
    Leer monedas
    ronda <- 1
    Mientras monedas < 350 Hacer
        Escribir "Progreso del ciclo: intento ", ronda
        Escribir "Monedas actuales: ", monedas, " de 350."
        Escribir "Cuantas monedas gano en esta ronda: " Sin Saltar
        Leer ganadas
        Si ganadas > 0 Entonces
            monedas <- monedas + ganadas
            ronda <- ronda + 1
        Sino
            Escribir "Debe ingresar una cantidad mayor que cero."
        FinSi
        Escribir "----------------------------------------"
    FinMientras
    Escribir "Felicidades, ya puede ingresar al nivel 5."
    Escribir "Total de monedas: ", monedas
    Esperar Tecla
FinAlgoritmo
