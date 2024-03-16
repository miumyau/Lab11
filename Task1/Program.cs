namespace Task1;
//Разработать структуру для решения линейного уравнения 0=kx+b.
//Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
//Для решения уравнения предусмотреть метод Root.
//Создать экземпляр разработанной структуры.
//Осуществить использование экземпляра в программе.



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите k");
        double k = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b = Convert.ToDouble(Console.ReadLine());

        LinEquation eq = new LinEquation(k,b);
        Console.WriteLine(eq.Root());
        Console.ReadKey();
    }
}



