Console.WriteLine("Hej och välkommen till denna frågesport");
Console.WriteLine("Vad är störst, a en elefant, b en giraff, c ett lejon?");
string svar1 = Console.ReadLine();

int poäng = 0;

if (svar1.ToLower() == "a")
{
    Console.WriteLine("Korrekt!");
    poäng += 100;
    Console.ReadLine();
}
else
{
    Console.WriteLine("Nej, det var elefant!");
    Console.ReadLine();
}


Console.WriteLine("Okej nästa fråga, är ett äpple en, a ett bär, b en elefant eller c en frukt?");
string svar2 = Console.ReadLine();


if (svar2.ToLower() == "c")
{
    Console.WriteLine("Det är sant!");
    poäng = poäng + 100;
    Console.ReadLine();
}
else
{
    Console.WriteLine("Nej, det var en frukt!");
    Console.ReadLine();
}

Console.WriteLine("Okej sista frågan, består jorden av, a 60% vatten, b 75% vatten eller c 70% vattem?");
string svar3 = Console.ReadLine();


if (svar3.ToLower() == "c")
{
    Console.WriteLine("Bra jobbat!");
    poäng += 100;
    Console.ReadLine();
}
else
{
    Console.WriteLine("Nej, det är 70%!");
    Console.ReadLine();
}

Console.WriteLine($"Du fick {poäng} poäng");


Console.ReadLine();
