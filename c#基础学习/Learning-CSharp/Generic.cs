using System;
using System.Collections.Generic;

delegate T NumberChanger<T>(T n);

namespace GenericApplication
{
	public class MyGenericArray<T>
	{
		private T[] array;
		
		public MyGenericArray(int size)
		{
			array = new T[size + 1];
		}
		
		public T getItem(int index)
		{
			return array[index];
		}
		
		public void setItem(int index, T value)
		{
			array[index] = value;
		}
	}
	
	class Tester
	{
		//���ͷ���
		static void swap<T>(ref T lhs, ref T rhs)
		{
			T temp;
			temp = lhs;
			lhs = rhs;
			rhs = temp;
		}
		
		//����ί��
		static int num = 10;
		public static int AddNum(int p)
		{
			num += p;
			return num;
		}
		
		public static int MultiNum(int q)
		{
			num *= q;
			return num;
		}
		
		public static int getNum()
		{
			return num;
		}
		
		static void Main(string[] args)
		{
			//����һ����������
			MyGenericArray<int> intArray = new MyGenericArray<int>(5);
			
			//����ֵ
			for(int i = 0; i < 5; i++)
			{
				intArray.setItem(i, i * 5);
			}
			
			//��ȡֵ
			for(int i = 0; i < 5; i++)
			{
				Console.Write(intArray.getItem(i) + " ");
			}
			
			Console.WriteLine();
			
			MyGenericArray<char> charArray = new MyGenericArray<char>(5);
			for(int i = 0; i < 5; i++)
			{
				charArray.setItem(i, (char)(i + 97));
			}
			for(int i = 0; i < 5; i++)
			{
				Console.Write(charArray.getItem(i) + " ");
			}
			Console.WriteLine();
			
			int a, b;
			char c, d;
			a = 10;
			b = 20;
			c = 'I';
			d = 'V';
			
			//����֮ǰ
			Console.WriteLine("Int values before calling swap: ");
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine("Char values before calling swap: ");
			Console.WriteLine("c = {0}, d = {1}", c, d);
			//����
			swap<int>(ref a, ref b);
			swap<char>(ref c, ref d);
			
			//����֮��
			Console.WriteLine("Int values after calling swap: ");
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine("Char values after calling swap: ");
			Console.WriteLine("c = {0}, d = {1}", c, d);
			
			//����ί��ʵ��
			NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
			NumberChanger<int> nc2 = new NumberChanger<int>(MultiNum);
			//ʹ��ί�ж�����÷���
			nc1(35);
			Console.WriteLine("Value of Num: {0}", getNum());
			nc2(5);
			Console.WriteLine("Value of Num: {0}", getNum());
			Console.ReadKey();
		}
	}
}