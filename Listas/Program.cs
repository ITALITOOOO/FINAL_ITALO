// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        LinkedList<int> list1 = GenerateRandomList(10, 1, 100);
        LinkedList<int> list2 = GenerateRandomList(10, 1, 100);
        LinkedList<int> combina = new LinkedList<int>(list1.Concat(list2));
        LinkedList<int> primNum = new LinkedList<int>();
        LinkedList<int> perfNum = new LinkedList<int>();
        LinkedList<int> otroNum = new LinkedList<int>();
        foreach (int num in combina)
        {
            if (prim(num))
            {
                primNum.AddLast(num);
            }
            else if (perf(num))
            {
                perfNum.AddLast(num);
            }
            else
            {
                otroNum.AddLast(num);
            }
        }
        while (true)
        {
            Console.WriteLine("Seleccione uno:");
            Console.WriteLine("1. Mostrar listas originales");
            Console.WriteLine("2. Mostrar solo numeros primos");
            Console.WriteLine("3. Mostrar solo numeros perfectos");
            Console.WriteLine("4. Mostrar otros números");
            Console.WriteLine("5. Salir");

            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Lista 1:");
                    DisplayList(list1);
                    Console.WriteLine("Lista 2:");
                    DisplayList(list2);
                    break;
                case 2:
                    Console.WriteLine("Numeros primos:");
                    DisplayList(primNum);
                    break;
                case 3:
                    Console.WriteLine("Numeros perfectos:");
                    DisplayList(perfNum);
                    break;
                case 4:
                    Console.WriteLine("Otros numeros:");
                    DisplayList(otroNum);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opcion no valida!! :v  seleccione una opcion del 1 al 5.>:r");
                    break;
            }
        }
    } 
    static LinkedList<int> GenerateRandomList(int size, int minval, int maxval)
    {
        Random random = new Random();
        LinkedList<int> list = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            list.AddLast(random.Next(minval, maxval + 1));
        }
        return list;
    } 
    static bool prim(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    } 
    static bool perf(int num)
    {
        int sum = 1;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                if (i == num / i)
                    sum += i;
                else
                    sum += i + num / i;
            }
        }
        return sum == num && num != 1;
    } 
    static void DisplayList(LinkedList<int> list)
    {
        foreach (int num in list)
        {
            Console.WriteLine(num);
        }
    }
}
