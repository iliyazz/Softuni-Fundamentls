using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		var input = new Dictionary<string, Dictionary<string, object>>
		{
			["James"] = new Dictionary<string, object>
			{
				["Age"] = 21,
				["Surname"] = "Doe",
				["Temp"] = 80.6
			},
			["Tobi"] = new Dictionary<string, object>
			{
				["Age"] = 26,
				["Surname"] = "Doe",
				["Temp"] = 60.5
			},
			["Jessica"] = new Dictionary<string, object>
			{
				["Age"] = 18,
				["Surname"] = "Doe",
				["Temp"] = 50.67
			}
		};

		var result = input.OrderBy(kv => kv.Value["Temp"]);

		foreach (var item in result)
			Console.WriteLine(item.Key);
	}
}