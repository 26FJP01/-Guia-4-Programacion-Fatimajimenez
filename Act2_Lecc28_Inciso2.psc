Algoritmo Act2_Lecc28_Inciso2
    Escribir "========================================"
    Escribir "   LECCION 28 - ACTIVIDAD 2 - INCISO 2"
    Escribir "     PRUEBA DE BOLETOS EN LA FERIA"
    Escribir "========================================"
    Escribir "Adulto: $15 | Nino: $10"
    Escribir "Use este programa para que un companero lo pruebe."
    Escribir "Digite 1 para adulto, 2 para nino y 0 para terminar."
    Definir opcion, contadorAdultos, contadorNinos, contadorBoletos, acumuladorDinero, paso Como Entero
    opcion <- 1
    contadorAdultos <- 0
    contadorNinos <- 0
    contadorBoletos <- 0
    acumuladorDinero <- 0
    paso <- 1
    Mientras opcion <> 0 Hacer
        Escribir "Progreso del ciclo: venta ", paso
        Escribir "Ingrese tipo de boleto: " Sin Saltar
        Leer opcion
        Si opcion = 1 Entonces
            contadorAdultos <- contadorAdultos + 1
            contadorBoletos <- contadorBoletos + 1
            acumuladorDinero <- acumuladorDinero + 15
            Escribir "Boleto de adulto vendido."
        Sino
            Si opcion = 2 Entonces
                contadorNinos <- contadorNinos + 1
                contadorBoletos <- contadorBoletos + 1
                acumuladorDinero <- acumuladorDinero + 10
                Escribir "Boleto de nino vendido."
            Sino
                Si opcion <> 0 Entonces
                    Escribir "Opcion incorrecta."
                FinSi
            FinSi
        FinSi
        Escribir "Total de boletos vendidos: ", contadorBoletos
        Escribir "Total de dinero cobrado: $", acumuladorDinero
        Escribir "----------------------------------------"
        paso <- paso + 1
    FinMientras
    Escribir "Resultado para comparar con el companero:"
    Escribir "Adultos: ", contadorAdultos
    Escribir "Ninos: ", contadorNinos
    Escribir "Boletos vendidos: ", contadorBoletos
    Escribir "Dinero cobrado: $", acumuladorDinero
    Esperar Tecla
FinAlgoritmo
