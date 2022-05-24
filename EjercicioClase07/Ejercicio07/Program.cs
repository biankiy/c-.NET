/* Bianca Gimenez
 
 Escribe un programa que:

    -1) Pida 10 números al usuario.
    -2) Obtener la suma de todos los números ingresados.
    -3) Obtener cual es el mayor de todos los números.
    -4) Obtener cual es el menor de todos los números.
    -5) Obtener el promedio de todos los números.
    -6) Mostrar todos los números ingresados por pantalla.
    -7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
 */

int[] numeros = new int[10];
float contador = 0;
int acumulador = 0;
float promedio = 0;
int maximo = 0;
int minimo = 0;


    for (int i = 0; i < numeros.Length; i++) { 
          Console.Write($"Ingrese un numero para la posicion {i+1}: ");

    numeros[i] = int.Parse(Console.ReadLine());
    acumulador += numeros[i];
    contador++;


    if (i == 0 || numeros[i] > maximo)
    {
        maximo = numeros[i];
        minimo = numeros[i];
    }
    else if (numeros[i] < minimo){
        minimo = numeros[i];
    }

    }
promedio = acumulador / contador;

    Console.WriteLine();
    Console.WriteLine($"  La suma de los valores ingresados es: {acumulador}");
    Console.WriteLine();
    Console.WriteLine($"  El promedio es los valores ingresados es: {promedio}");
    Console.WriteLine();
    for (int i = 0; i < numeros.Length; i++) {
        Console.Write($"{numeros[i]} - ");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"  El mayor numero ingresado es : {maximo}");
    Console.WriteLine();
    Console.WriteLine($"  El menor numero ingresados es: {minimo}");