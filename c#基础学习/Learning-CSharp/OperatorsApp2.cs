using System;
namespace OperatorsApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 21;
			int b = 10;
			
			if(a == b)
			{
				Console.WriteLine("a ���� b ");
			}
			else
			{
				Console.WriteLine("a ������ b ");
			}
			
			if(a < b)
			{
				Console.WriteLine("a С�� b ");
			}
			else
			{
				Console.WriteLine("a ��С�� b ");
			}
			
			if(a > b)
			{
				Console.WriteLine("a ���� b ");
			}
			else
			{
				Console.WriteLine("a ������ b ");
			}
			a = 5;
			b = 20;
			if(a <= b)
			{
				Console.WriteLine("a С�ڻ���� b ");
			}
			if(b >= a)
			{
				Console.WriteLine("b ���ڻ���� a ");
			}
			
			Console.ReadLine();
		}
	}
}