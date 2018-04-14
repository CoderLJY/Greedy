using System;
using System.Collections.Generic;
using System.Text;

namespace TreasureModel
{
	public partial class Treasure : IComparable<Treasure>
	{
		public int CompareTo(Treasure other)
		{
			if (other == null)
				return 1;
			return _price.CompareTo(other.Price);
		}
		public static bool operator >(Treasure operand1, Treasure operand2)
		{
			return operand1.CompareTo(operand2) == 1;
		}
		public static bool operator <(Treasure operand1, Treasure operand2)
		{
			return operand1.CompareTo(operand2) == -1;
		}
		public static bool operator >=(Treasure operand1, Treasure operand2)
		{
			return operand1.CompareTo(operand2) >= 0;
		}
		public static bool operator <=(Treasure operand1, Treasure operand2)
		{
			return operand1.CompareTo(operand2) <= 0;
		}
	}
}
