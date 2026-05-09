Algoritmo Act1_Lecc15_Inciso1
    Escribir "========================================"
    Escribir "     BOLETOS RUEDA DE LA FORTUNA"
    Escribir "========================================"
    Escribir "Adulto: $15 | Nino: $10"
    Escribir "Digite 1 para adulto, 2 para nino y 0 para terminar."
	
    Definir opcion, boletosAdulto, boletosNino, totalBoletos, totalDinero, paso Como Entero
    opcion <-  1
    boletosAdulto <- 0
    boletosNino <- 0
    totalBoletos <- 0
    totalDinero <- 0
    paso <- 1
	
    Mientras opcion <> 0 Hacer
        Escribir "Progreso del ciclo: venta ", paso
        Escribir "Tipo de boleto: " Sin Saltar
        Leer opcion
		
        Si opcion = 1 Entonces
            boletosAdulto <- boletosAdulto + 1
            totalBoletos <- totalBoletos + 1
            totalDinero <- totalDinero + 15
            Escribir "Se vendio un boleto de adulto."
        Sino
            Si opcion = 2 Entonces
                boletosNino <- boletosNino + 1
                totalBoletos <- totalBoletos + 1
                totalDinero <- totalDinero + 10
                Escribir "Se vendio un boleto de nino."
            Sino
                Si opcion <> 0 Entonces
                    Escribir "Opcion incorrecta."
                FinSi
            FinSi
        FinSi
		
        Escribir "Boletos vendidos: ", totalBoletos
        Escribir "Dinero cobrado: $", totalDinero
        Escribir "----------------------------------------"
        paso <- paso + 1
    FinMientras
	
    Escribir "Resumen final:"
    Escribir "Adultos: ", boletosAdulto
    Escribir "Ninos: ", boletosNino
    Escribir "Total de boletos: ", totalBoletos
    Escribir "Total cobrado: $", totalDinero
    Esperar Tecla
	
FinAlgoritmo