int createNumber(int MinValue, int MaxValue)
{
    int number = new Random().Next(MinValue, MaxValue);
    return number;
}


int Secretnumber = createNumber(1, 100);
System.Console.WriteLine("Загаданное число:");
System.Console.WriteLine(Secretnumber);

System.Console.WriteLine("Введите кол-во попыток:");
int count = Convert.ToInt32(Console.ReadLine());


void MakeMove(int count,int SecretsNumbers)
{
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine("Введите число от 1 до 100");
        int PlayNumbers = Convert.ToInt32(Console.ReadLine());
        if (PlayNumbers == SecretsNumbers)
        {
            System.Console.WriteLine("Ура, вы угадали число!");
            break;
        } 
        if (PlayNumbers < SecretsNumbers) System.Console.WriteLine("Введеное число меньше загадоного");
        if (PlayNumbers > SecretsNumbers) System.Console.WriteLine("Введеное число больше загадоного");
    }
    System.Console.WriteLine("Игра окончена!");
}

MakeMove(count,Secretnumber);





