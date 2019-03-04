using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStuff
{
	public class Widget : IComparable
	{
		static Random _rnd = new Random();
		public string Name { get; set; }
		public int Priority { get; set; }
		public Widget()
		{
			string s = "";
			int iNum = _rnd.Next(1, 17);
			for (int i = 0; i < iNum; i++)
				s += (char)_rnd.Next('A', 'Z' + 1);
			Priority = s.Length;
			Name = s;
		}
		public int CompareTo(object obj)
		{
			if (!(obj is Widget)) throw new ArgumentException();
			Widget arg = obj as Widget;
			return Priority.CompareTo(arg.Priority);
		}
	}
}
