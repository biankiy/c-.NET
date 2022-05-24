/* 
 * Bianca Gimenez
 * 
     1) Generar un número secreto
    aleatorio con la siguiente instruccion:

    // Genera un numero entero aleatorio de 1 a 20
    int numeroSecreto = new
    Random(DateTime.Now.Millisecond).Next(1, 21);

    2) Pedir al usuario que ingrese un número y que
    intente adivinar el número que eligió la computadora.

    3) Si el numero ingresado por el usuario es mayor
    al número secreto, avisarle que es muy grande y que intente de nuevo y que
    vuelva al paso 2.

    4) Si el numero ingresado es menor al número
    secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

    5) Si el número ingresado coincide con el número
    secreto, sacar el siguiente mensaje:

    "Felicitaciones, has adivinado el número
    secreto que era:  [numeroSecreto]"
    "Lo has logrado en [n] intentos!!"

    Y finalizar el programa.
 */

int numero;
int intentos = 0;
//1) Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
    Random(DateTime.Now.Millisecond).Next(1, 20);


do {
    Console.WriteLine();
    Console.WriteLine("Intente adivinar el numero que eligio la Computadora");
    Console.WriteLine("Entre 1-20");
    Console.WriteLine();

    Console.Write("Ingrese un numero: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
    numero = int.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

    if (numero > numeroSecreto)
    {
        Console.WriteLine();
        Console.WriteLine("-El numero secreto es menor al numero ingresado-");
    }
    else {
        Console.WriteLine();
        Console.WriteLine("-El numero secreto es mayor al numero ingresado-");
    }

    intentos++;
} while (numeroSecreto != numero);
    
    Console.WriteLine();
    Console.WriteLine("Felicitaciones, has adivinado el número");
    Console.WriteLine("secreto que era: "+ numeroSecreto);    
    Console.WriteLine("Lo has logrado en "+ intentos + " intentos!!");


