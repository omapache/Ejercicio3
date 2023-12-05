Console.WriteLine("Numeros Amistosos");

Console.WriteLine("Ingrese el menor rango de busqueda");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el mayor rango de busqueda");
int numero2 = Convert.ToInt32(Console.ReadLine());
int suma1 = 0;
int sumaG1 = 1;
int suma2 = 0;
int sumaG2 = 1;
int mitad = 0;
Console.WriteLine("Los numeros Amistosos son:");
for (int n2 = numero1; n2 < numero2; n2++)
{
    for (int n = numero1; n < numero2; n++)
    {
        mitad = n / 2;
        
        for (int i = 2; i < n; i++)
        {

            if (n % i == 0)
            {
                suma1 = n / i;
                sumaG1 += suma1;
            }
        }
        if (n < mitad)
        {
            break;
        }

        for (int i = 2; i < n2; i++)
        {
            if (n2 % i == 0)
            {
                suma2 = n2 / i;
                sumaG2 += suma2;

            }
        }
        if (sumaG1 == n2 && sumaG2 == n && n != n2 && n2 > n)
        {
            Console.WriteLine(n);
            Console.WriteLine(n2);
            Console.WriteLine("-----------");
        }
        suma1 = 0;
        sumaG1 = 1;
        suma2 = 0;
        sumaG2 = 1;
    }
    
}

