Algoritmo Act2_Lecc10_Inciso2
    Escribir "========================================"
    Escribir "   LECCION 10 - ACTIVIDAD 2 - INCISO 2"
    Escribir "       LISTADO DE NUMEROS PARES"
    Escribir "========================================"
	
    Definir limite, contador Como Entero
    Escribir "Ingrese el numero limite (debe ser mayor a 2): " Sin Saltar
    Leer limite
	
    // Validamos que el limite sea correcto para mostrar pares positivos
    Si limite < 2 Entonces
        Escribir "Error: No hay pares positivos en ese rango."
    Sino
        // Empezamos en 2 y saltamos de 2 en 2
        Para contador <- 2 Hasta limite Con Paso 2 Hacer
            Escribir "Número par encontrado: ", contador
        FinPara
    FinSi
	
    Escribir "========================================"
    Escribir "Proceso terminado."
    Esperar Tecla
FinAlgoritmo