using System;

class Dog
{
    public string Name;
    public string FunColor;
    public double BodyWeight;
    public bool isSleeping = false;

    public Dog(string name, string funColor, double bodyWeight)
    {
        Name = name;
        FunColor = funColor;
        BodyWeight = bodyWeight;
    }
    public void WakeUp()
    {
        if (!isSleeping)
        {
            Console.WriteLine("Собака {0} прокинулась", Name);
        }
        else
        {
            Console.WriteLine("Собака {0} не може прокинутися, вона спить", Name);
        }
    }
    public void Sleep()
    {
        Console.WriteLine("Собака {0} спить", Name);
        isSleeping = true;
    }
    public void Bark()
    {
        if (!isSleeping)
        {
            if (BodyWeight > 20)
            {
                Console.WriteLine("Велика собака {0} голосно гавкає", Name);
            }
            else
            {
                Console.WriteLine("Маленька собака {0} гавкає повільно", Name);
            }
        }
        else
        {
            Console.WriteLine("Собака {0} спить і не може гавкати", Name);
        }
    }
    public void Run()
    {
        if (!isSleeping)
        {
            if (BodyWeight > 20)
            {
                Console.WriteLine("Велика собака {0} повільно бігає", Name);
            }
            else
            {
                Console.WriteLine("Маленька собака {0} швидко бігає", Name);
            }
        }
        else
        {
            Console.WriteLine("Собака {0} спить і не може бігати", Name);
        }
    }
}
class Program
{
    static void Main()
    {
        Dog bigDog = new Dog("Барон", "Рудий", 25);
        Dog smallDog = new Dog("Рекс", "Чорний", 10);

        bigDog.WakeUp();
        bigDog.Bark();
        bigDog.Sleep();
        bigDog.Bark();

        smallDog.WakeUp();
        smallDog.Run();
        smallDog.Sleep();
        smallDog.Run();
    }
}