using System;
namespace OperatorsApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			bool a = true;
			bool b = true;
			
			if(a && b)
			{
				Console.WriteLine("����Ϊ�档");
			}
			if(a || b)
			{
				Console.WriteLine("����Ϊ�档");
			}
			//�ı�a��b��ֵ
			a = false;
			b = true;
			if(a && b)
			{
				Console.WriteLine("����Ϊ�档");
			}
			else
			{
				Console.WriteLine("����Ϊ�١�");
			}
			
			if(!(a && b))
			{
				Console.WriteLine("����Ϊ�档");
			}
			Console.ReadLine();
		}
	}
}