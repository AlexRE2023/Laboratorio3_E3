Console.WriteLine("Ingrese la cantidad de adivinanzas acertadas:");
int aciertos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la edad del participante:");
int edad = int.Parse(Console.ReadLine());

switch (aciertos)
{
    case < 3:
        switch (edad)
        {
            case < 18:
                int montofinal = 50 + 5 * edad + 2 * aciertos;
                Console.WriteLine("El premio final es de " + montofinal + " soles");
                break;
            case >= 18:
                montofinal = 30 + 5 * edad + 2 * aciertos;
                Console.WriteLine("El premio final es de " + montofinal + " soles");
                break;
        }
        break;
    case <= 5:
        switch (edad)
        {
            case < 18:
                int montofinal = 80 + 5 * edad + 2 * aciertos;
                Console.WriteLine("El premio final es de " + montofinal + " soles");
                break;
            case >= 18:
                montofinal = 50 + 5 * edad + 2 * aciertos;
                Console.WriteLine("El premio final es de " + montofinal + " soles");
                break;
        }
        break;
}
