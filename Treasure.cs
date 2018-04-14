using System;
using System.Collections.Generic;

namespace TreasureModel
{
	public partial class Treasure 
	{
		
		private string _name;
		private decimal _price;

		public string Name
		{
			get => _name;
			set => _name = value;
		}

		public decimal Price
		{
			get => _price;
			set => _price = value;
		}

		public Treasure(string name, decimal price)
		{
			this.Name = name;
			this.Price = price;

		}


	}
}