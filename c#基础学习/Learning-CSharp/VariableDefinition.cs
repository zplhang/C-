using System;
namespace VariableDefinition
{
	class Program
	{
		static void Main(string[] args)
		{
			short a;
			int b;
			double c;
			
			//ʵ�ʳ�ʼ��
			a = 10;
			b = 20;
			c = a + b;
			
			Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
			Console.ReadLine();
		}
	}
}