
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	internal class Program
	{
		/// <summary>
		/// Exec_RemoveCollectionItems
		/// 在集合中移除多個項目
		/// </summary>
		/// 
		static void Main(string[] args)
		{
			List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			//除去所有偶數
			for (int i = 1; i < list.Count; i++)
			{
				if (i % 2 == 0)
					list.Remove(i);
			}

			foreach (int item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
}
