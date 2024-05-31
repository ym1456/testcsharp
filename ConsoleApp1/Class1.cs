using System;
using System.Linq;

class PeopleInfo
{
	public string Name { get; set; } = "";
	public int Height { get; set; }
}
class Class1
{
	static void Main(string[] args)
	{
		//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		//var result = from n in numbers
		//			 where n % 2 == 0
		//			 orderby n ascending
		//			 select n;

		//foreach(var n in result)
		//{
		//	Console.WriteLine(n);
		//}

		PeopleInfo[] infos =
		{
			new PeopleInfo(){Name = "상혁" , Height = 178},
			new PeopleInfo(){Name = "당민" , Height = 166},
			new PeopleInfo(){Name = "시윤" , Height = 198},
			new PeopleInfo(){Name = "권민" , Height = 156},
		};

		var profiles = from n in infos
					   where n.Height > 170
					   select new {Name = n.Name , Height = n.Height * 3 };

		foreach(var n in profiles)
		{
			Console.WriteLine(n.Name + " , " + n.Height);
		}
		int a = 0;
		Console.Write("HI");

		Console.Write("Im Temp ");
		Console.Write("Temp branch");
	}
}
