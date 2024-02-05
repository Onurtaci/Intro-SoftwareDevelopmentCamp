Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = false;
Console.WriteLine(message1);

if (isAuthenticated)
{
    Console.WriteLine("Button -> Hoş Geldin Onur");
}
else
{
    Console.WriteLine("Lütfen Giriş yapınız");
}

string[] loans = { "Konut Kredisi", "Taşıt Kredisi", "İhtiyaç Kredisi" }; //db den gelen veri

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Console.WriteLine("Kod bitti");
