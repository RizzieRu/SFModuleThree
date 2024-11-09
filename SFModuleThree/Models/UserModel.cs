using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModuleThree.Models
{
	internal class UserModel
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string BirthDate { get; set; }

		public UserModel(string name, int age, string birthDate)
		{
			Name = name;

			Age = age;

			BirthDate = birthDate;
		}
	}
}
