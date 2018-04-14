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
							 where treasure.Price > 12m
							 select treasure;
			return sortedList.ToArray();
		}
		
	}
}
