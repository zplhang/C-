using System;
namespace CalculatorApplication
{
	class NumberManipulator
	{
		public int FindMax(int num_a, int num_b)
		{
			//�����ֲ�����
			int result;
			
			if(num_a > num_b)
			{
				result = num_a;
			}
			else
			{
				result = num_b;
			}
			return result;
		}
		
		/*
		static void Main(string[] args)
		{
			//����ֲ�����
			int a = 100;
			int b = 200;
			int ret;
			NumberManipulator n = new NumberManipulator();
			
			//����FindMax����
			ret = n.FindMax(a, b);
			Console.WriteLine("���ֵ�ǣ�{0}", ret);
			Console.ReadLine();
		}
		*/
	}
	class Test
	{
		static void Main(string[] args)
		{
			//����ֲ�����
			int a = 100;
			int b = 200;
			int ret;
			NumberManipulator n = new NumberManipulator();
			
			//����FindMax����
			ret = n.FindMax(a, b);
			Console.WriteLine("���ֵ�ǣ�{0}", ret);
			Console.ReadLine();
		}
	}
}