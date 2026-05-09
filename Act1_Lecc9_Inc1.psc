Algoritmo sin_titulo
	Escribir "========================================"
    Escribir "   LECCION 09 - ACTIVIDAD 1 - INCISO 1"
    Escribir "        COMPRANDO MANZANAS - MIENTRAS"
    Escribir "========================================"
    Escribir "El objetivo es juntar 1 kilo de manzanas."
    Escribir "Ingrese el peso de cada manzana en gramos."
    Definir pesoTotal, contador, pesoManzana Como Entero
    pesoTotal <- 0
    contador <-1
    Mientras pesoTotal < 1000 Hacer
        Escribir "Peso de la manzana ", contador, " en gramos: " Sin Saltar
        Leer pesoManzana
        Si pesoManzana > 0 Entonces
            pesoTotal <- pesoTotal + pesoManzana
            Escribir "Progreso del ciclo: manzana ", contador, " registrada."
            Escribir "Peso acumulado: ", pesoTotal, " gramos de 1000 gramos."
            contador <- contador + 1
        Sino
            Escribir "El peso debe ser mayor que cero. Intente otra vez."
        FinSi
        Escribir "----------------------------------------"
    FinMientras
    Escribir "Ya tiene por lo menos 1 kilo de manzanas."
    Escribir "Peso final: ", pesoTotal, " gramos."
    Esperar Tecla
FinAlgoritmo
