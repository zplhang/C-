using System;
namespace CalculatorApplication
{
	class NumberManipulator
	{
		public void swap(ref int x, ref int y)
		{
			//�����ֲ�����
			int temp;
			
			temp = x;//����x��ֵ
			x = y;//��y��ֵ��x
			y = temp;//��temp��ֵ��ֵ��y
		}
		
		
		static void Main(string[] args)
		{
			//����ֲ�����
			int a = 100;
			int b = 200;
			
			NumberManipulator n = new NumberManipulator();
			
			Console.WriteLine("����֮ǰa��ֵΪ��{0}", a);
			Console.WriteLine("����֮ǰb��ֵΪ��{0}", b);
			//����swap����������ֵ
			n.swap(ref a, ref b);
			Console.WriteLine("����֮��a��ֵΪ��{0}", a);
			Console.WriteLine("����֮��b��ֵΪ��{0}", b);
			Console.ReadLine();
		}
		
	}
}