Console.WriteLine("Adjon meg egy természetes számot!");
string str=Console.ReadLine();

int number = int.Parse(str);

int summa = 0;

for (int i = 1; i <= number; i++)
    summa += i;

Console.WriteLine("Az első " + number + " természetes szám összege: " + summa);