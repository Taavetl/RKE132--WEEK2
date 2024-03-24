// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Taavet!");




Console.WriteLine("Please, sellect your gender (F/M)");

char UserGender = char.Parse(Console.ReadLine());


Console.WriteLine("Please, Enter Your Name:");

string username = Console.ReadLine(); 

if(UserGender == 'm')
{
    Console.WriteLine($"Hello, Mr. {username}!");
}
else if (UserGender == 'f')
{
    Console.WriteLine($"Hello, Mrs. {username}!");

}
else Console.WriteLine($"Welcome, {username}!");




 




