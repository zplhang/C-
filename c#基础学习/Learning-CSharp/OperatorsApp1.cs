using System;
namespace OperatorsApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 21;
			int b = 10;
			int c;
			
			c = a + b;
			Console.WriteLine("a + b = {0}", c);
			c = a - b;
			Console.WriteLine("a - b = {0}", c);
			c = a * b;
			Console.WriteLine("a * b = {0}", c);
			c = a / b;
			Console.WriteLine("a / b = {0}", c);
			c = a % b;
			Console.WriteLine("a % b = {0}", c);
			
			//++a �Ƚ������������ٸ�ֵ��c = a++,�Ƚ�a��ֵ��c���ٶ�a����������
			c = ++a;
			Console.WriteLine("++a = {0}", c);
			//��ʱaΪ22��--a�Ƚ����Լ��ٸ�ֵ
			c = --a;
			Console.WriteLine("--a = {0}", c);
			
			a = 1;
			b = a++;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
			
			a = 1;
			b = ++a;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
			
			a = 1;
			b = a--;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
			
			a = 1;
			b = --a;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
		}
	}
}