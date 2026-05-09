Algoritmo Act2_Lecc11_Inciso1
Escribir "======================================="
Escribir "   LECCION 11 - ACTIVIDAD 2 - INCISO 1"
Escribir "      GENERADOR DE SECUENCIA PAR"
Escribir "======================================="
Definir valor_max, actual, iteracion Como Entero
Escribir "Define el tope del rango (2 a 1000): " Sin Saltar
Leer valor_max
actual <- 2
iteracion <- 1
Si valor_max >= 2 Y valor_max <= 1000 Entonces
Escribir "Iniciando secuencia..."
Escribir "----------------------------------------"
Repetir
Escribir "[Registro ", iteracion, "]: ", actual
actual <- actual + 2
iteracion <- iteracion + 1
Hasta Que actual > valor_max
   Escribir "----------------------------------------"
   Escribir "Se han mostrado todos los pares hasta el ", valor_max
Sino
Escribir "Error: El valor ingresado está fuera del rango permitido."
FinSi
Escribir "Presione una tecla para finalizar..."
Esperar Tecla
FinAlgoritmo
