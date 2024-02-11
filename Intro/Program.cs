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

IndividualCustomer customer1 = new();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Ali";
customer1.LastName = "Köse";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new();
customer2.Id = 2;
customer2.NationalIdentity = "12345678822";
customer2.FirstName = "Özlem";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new();
customer3.Id = 3;
customer3.CompanyName = "Kodlama.io";
customer3.CustomerNumber = "123458";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new();
customer4.Id = 4;
customer4.CompanyName = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "1234567898";

//value type and reference type was explained

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}