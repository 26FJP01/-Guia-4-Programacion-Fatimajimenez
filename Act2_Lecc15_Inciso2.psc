Algoritmo Act2_Lecc15_Inciso2
		Escribir "========================================"
		Escribir "   LECCION 15 - ACTIVIDAD 2 - INCISO 2"
		Escribir "      CAJERO DEL SUPERMERCADO"
		Escribir "========================================"
		Escribir "Ingrese 1000 billetes. Denominaciones validas: 20, 50 y 100."
		Definir contador, billete, billetesDe100, totalDinero Como Entero
		contador <- 1
		billetesDe100 <- 0
		totalDinero <- 0
		Mientras contador <= 1000 Hacer
			Escribir "Progreso del ciclo: billete ", contador, " de 1000"
			Escribir "Ingrese denominacion del billete: " Sin Saltar
			Leer billete
			Si billete = 20 O billete = 50 O billete = 100 Entonces
				totalDinero <- totalDinero + billete
				Si billete = 100 Entonces
					billetesDe100 <- billetesDe100 + 1
				FinSi
				Escribir "Total acumulado: $", totalDinero
				contador <- contador + 1
			Sino
				Escribir "Denominacion incorrecta. No se cuenta este billete."
			FinSi
			Escribir "----------------------------------------"
		FinMientras
		Escribir "Cantidad de billetes de $100: ", billetesDe100
		Escribir "Total de dinero en el fajo: $", totalDinero
		Esperar Tecla
FinAlgoritmo
