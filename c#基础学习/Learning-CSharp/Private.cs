using System;
namespace RectangleApplication
{
	class Rectangle
	{
		//��Ա����
		private double length;
		private double width;
		
		public void AcceptDetails()
		{
			Console.WriteLine("�����볤�ȣ�");
			length = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("�������ȣ�");
			width = Convert.ToDouble(Console.ReadLine());
		}
		
		public double GetArea()
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
			//r.length = 5.4;
			//r.width = 3.2;//����
			r.AcceptDetails();
			r.Display();
			Console.ReadLine();
		}
	}
}