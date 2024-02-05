using Intro.Business;
using Intro.Entities;

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

//Course course1 = new();
//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = "C#  .NET 8";
//course1.Price = 0;

//Course course2 = new();
//course2.Id = 2;
//course2.Name = "Java";
//course2.Description = "Java 17..";
//course2.Price = 10;

//Course course3 = new();
//course3.Id = 3;
//course3.Name = "Python";
//course3.Description = "Python 3.12 ..";
//course3.Price = 20;

//Course[] courses = { course1, course2, course3 };

//foreach (var course in courses)
//{
//    Console.WriteLine(course.Name + " / " + course.Price);
//}

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

foreach (var course in courses2)
{
    Console.WriteLine(course.Name + " / " + course.Price);
}

Console.WriteLine("Kod bitti");
