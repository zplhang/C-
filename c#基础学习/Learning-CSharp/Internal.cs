using System;
namespace RectangleApplication
{
	class Rectangle
	{
		//��Ա����
		internal double length;
		internal double width;
		
		double GetArea()
		{
			return length * width;
		}
		
		public void Display()
		{
			Console.WriteLine("���ȣ�{0}", length);
			Console.WriteLine("��ȣ�{0}", width);
			Console.WriteLine("�����{0}", GetArea());
		}
	}
	
	class ExecuteRectangle
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			r.length = 5.4;
			r.width = 3.2;
			r.Display();
			Console.ReadLine();
		}
	}
}