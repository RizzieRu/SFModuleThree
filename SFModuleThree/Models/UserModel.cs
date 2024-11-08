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

		public bool IsHaveAPet { get; set; }

		public float SizeOfFeet { get; set; }

		public UserModel(string name, int age, bool isHaveAPet, float sizeOfFeet)
		{
			Name = name;

			Age = age;

			IsHaveAPet = isHaveAPet;

			SizeOfFeet = sizeOfFeet;
		}
	}
}
