using System;
namespace ArrayApplication
{
	class MyArray
	{
		static void Main(string[] args)
		{
			//������Ĭ�ϳ�ʼ��10������������
			int[] n = new int[10];
			
			//���ÿ������Ԫ�ص�ֵ
			for(int j = 0; j < 10; j++)
			{
				Console.WriteLine("Element[{0}] = {1}", j, n[j]);
			}
			
			//��ʼ������
			for(int i = 0; i < 10; i++)
			{
				n[i] = i + 100;
			}
			
			//���ÿ������Ԫ�ص�ֵ
			/*
			for(j = 0; j < 10; j++)
			{
				Console.WriteLine("Element[{0}] = {1}", j, n[j]);
			}
			*/
			foreach(int j in n)
			{
				int i = j - 100;
				Console.WriteLine("Element[{0}] = {1}", i, j);
			}

			Console.ReadLine();
		}
		
	}
}