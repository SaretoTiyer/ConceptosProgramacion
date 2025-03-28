do
{
    Console.WriteLine("Ingresa un numero: ");
    var num = (Console.ReadLine());


    if (int.TryParse(num , out int numeroInt))
    {
        if (numeroInt % 2 == 0)
        {
            Console.WriteLine($"Este numero {numeroInt}  es par");
        }
        else
        {
            Console.WriteLine($"Este numero {numeroInt} es impar");
        }
    }
    else
    {
        Console.WriteLine("Debes ingresar un numero entero"); 
    }
}
while (true);

