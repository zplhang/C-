using System;
namespace OperatorsApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			//sizeof
			Console.WriteLine("int�Ĵ�С�ǣ�{0}", sizeof(int));
			Console.WriteLine("short�Ĵ�С�ǣ�{0}", sizeof(short));
			Console.WriteLine("double�Ĵ�С�ǣ�{0}", sizeof(double));
			
			//?:
			int a, b;
			a = 10;
			b = (a == 1) ? 20 : 30;
			Console.WriteLine("b��ֵ�ǣ�{0}", b);
			b = (a == 10) ? 20 : 30;
			Console.WriteLine("b��ֵ�ǣ�{0}", b);
			Console.ReadLine();
		}
	}
}