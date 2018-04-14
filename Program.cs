using System;
using TreasureModel;

namespace Greedy
{
	class Program
	{
		static void Main(string[] args)
		{
			Treasure[] treasures = new Treasure[] {
			new Treasure("琉璃瓦", 13.3m),
			new Treasure("景泰蓝", 19.5m),
			new Treasure("青花瓷", 11.2m),
			new Treasure("狗尾草", 0.2m),
			new Treasure("鸡冠花", 0.3m),
			new Treasure("秋草文壺", 20m)
			};
			Treasure treasureList = new Treasure(treasures);
			var query = treasureList.TreasureGreedyExtension();

			foreach (var item in query)
			{
				Console.WriteLine($"{item.Name} --- {item.Price}");
			}


		}
	}
}
