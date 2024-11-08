using SFModuleThree.Models;
using System.Text;

string myName;

var user = new UserModel("Jane", 27, true, 37.5f);

var stringBuilder = new StringBuilder();

stringBuilder.AppendLine($"My name is {user.Name}");
stringBuilder.AppendLine($"My age is {user.Age}");
stringBuilder.AppendLine($"Do I have a pet? {user.IsHaveAPet}");
stringBuilder.AppendLine($"My shoe size is {user.SizeOfFeet}");

Console.WriteLine(stringBuilder.ToString());

Console.ReadLine();