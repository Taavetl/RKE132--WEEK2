// See https://aka.ms/new-console-template for more information

Console.WriteLine("Sisestage oma vanus:");

int userage =Int32.Parse(Console.ReadLine());

if (userage < 13)
{
    Console.WriteLine("Sa oled liiga noor!");
}
else if (userage > 13)
{
    Console.WriteLine("Welcome!");
}

