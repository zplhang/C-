using System;
namespace CalculatorApplication
{
	class NullableAtShow
	{
		static void Main(string[] args)
		{
			//����ֲ�����
			int? num1 = null;
			int? num2 = 45;
			double? num3 = new double?();
			double? num4 = 3.14157;
			
			bool? boolval = new bool?();
			
			Console.WriteLine("��ʾ�ɿ����͵�ֵΪ��{0}, {1}, {2}, {3}", num1, num2, num3, num4);
			Console.WriteLine("һ���ɿյĲ���ֵ��{0}", boolval);
			Console.ReadLine();
		}
		
	}
}