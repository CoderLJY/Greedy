using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TreasureModel
{
	public static class TreasureExtension
	{
		public static Treasure[] TreasureGreedyExtension(this IEnumerable<Treasure> source)
		{

			if (source.Count() == 0)
			{
				throw new InvalidOperationException("Cannot compute median for an empty set.");
			}
			var sortedList = from treasure in source
							 orderby treasure.Price
							 select treasure;
			decimal sum = 0m;
			ArrayList treasures = new ArrayList();
			foreach (var item in sortedList)
			{
				sum += item.Price;
				if (sum < 17m)
				{
					treasures.Add(item);
				}
				else
				{
					break;
				}
			}

			return treasures.Cast<Treasure>().ToArray();
		}

	}
}
