using System;
namespace CalculatorApplication
{
	class NumberManipulator
	{
		public void getValue(out int x)
		{
			int temp = 5;
			x = temp;
		}
		
		public void getValues(out int x, out int y)
		{
			Console.WriteLine("�������һ��ֵ��");
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("������ڶ���ֵ��");
			y = Convert.ToInt32(Console.ReadLine());
		}
		/*
		public void swap(ref int x, ref int y)
		{
			//�����ֲ�����
			int temp;
			
			temp = x;//����x��ֵ
			x = y;//��y��ֵ��x
			y = temp;//��temp��ֵ��ֵ��y
		}
		*/
		
		static void Main(string[] args)
		{
			//����ֲ�����
			//int a = 100;
			int a, b;

			NumberManipulator n = new NumberManipulator();
			
			//Console.WriteLine("��������֮ǰa��ֵΪ��{0}", a);
			//����swap����������ֵ
			//n.getValue(out a);
			n.getValues(out a, out b);
			Console.WriteLine("��������֮��a��ֵΪ��{0}", a);
			Console.WriteLine("��������֮��b��ֵΪ��{0}", b);
			Console.ReadLine();
		}
		
	}
}