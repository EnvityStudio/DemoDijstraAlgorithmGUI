using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDijkstra
{
	class MyDijkstra
	{
		private int length;
		private int point;
		private bool isCheck;
		public MyDijkstra() {

			length = -1;
			isCheck = false;
		}

		
		public int Length { get => length; set => length = value; }
		public int Point { get => point; set => point = value; }
		public bool IsCheck { get => isCheck; set => isCheck = value; }
	}
}