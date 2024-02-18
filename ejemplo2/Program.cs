ushort num1, num2, resultado3;

resultado3 = 0;


try
{

    Console.WriteLine("Ingrese un numero: ");
    num1 = Convert.ToByte(Console.ReadLine());

    Console.WriteLine("Ingrese un numero: ");
    num2 = Convert.ToByte(Console.ReadLine());

    resultado3 = (ushort)(num1 * num2);
    Console.WriteLine($"El resultado es: {resultado3}");

}

catch (Exception ex)
{




}