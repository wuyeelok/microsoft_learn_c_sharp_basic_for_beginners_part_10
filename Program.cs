// See https://aka.ms/new-console-template for more information
var part = 10;
Console.WriteLine($"Hello, World! Part {part}");

int counter = 0;

while (counter < 5)
{
    Console.WriteLine($"Counter is {counter}");
    counter++;
}


do
{
    Console.WriteLine($"Counter is {counter}");
    counter--;
} while (counter > 0);