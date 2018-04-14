using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TreasureModel
{
	public partial class Treasure : IEnumerable<Treasure>
	{
		private Treasure[] _treasures;
		public Treasure(Treasure[] tArray)
		{
			_treasures = new Treasure[tArray.Length];

			for (int i = 0; i < tArray.Length; i++)
			{
				_treasures[i] = tArray[i];
			}
		}

		public IEnumerator<Treasure> GetEnumerator()
		{
			foreach(Treasure t in _treasures)
			{
				if (t == null)
				{
					break;
				}
				yield return t;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
