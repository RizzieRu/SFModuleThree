using SFModuleThree.Models;
using System.Text;

Console.Write("Введите ваше имя: ");
string? name = Console.ReadLine();

if (name == null) 
	name = "Неизвестно";

Console.Write("Введите ваш возраст: ");

int age;

int.TryParse(Console.ReadLine(), out age);

Console.Write("Введите вашу дату рождения: ");

var birthDate = Console.ReadLine();

if (birthDate == null)
	birthDate = "Неизвестно";

UserModel user = new UserModel(name, age, birthDate);

StringBuilder welcomeMessageBuilder = new StringBuilder();

welcomeMessageBuilder.AppendLine($"Привет, {user.Name}! Вот, что мы знаем о вас:");
welcomeMessageBuilder.AppendLine($"Ваш возраст: {user.Age}");
welcomeMessageBuilder.AppendLine($"День рождения: {user.BirthDate}");

string welcomeMessage = welcomeMessageBuilder.ToString();

Console.WriteLine(welcomeMessage);

