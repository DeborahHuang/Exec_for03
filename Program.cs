using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_for03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//右側對齊星形三角形
			//     *
			//    **
			//   ***
			//  ****
			// *****

			for (int i = 1; i <=5 ; i++)
			{
				string countOfStar = new string('*', i);
				string countOfEmpty = new string(' ', 6-i);
				Console.WriteLine(countOfEmpty+countOfStar);
			}
			Console.ReadKey();
		}
	}
}
