using System;

namespace LineApplication
{
	class Line
	{
		private double length;
		/*
		public Line()
		{
			Console.WriteLine("�����Ѵ�����");
		}
		*/
		public Line(double len)
		{
			Console.WriteLine("�����Ѵ�����length = {0}", len);
			length = len;
		}
		~Line()
		{
			Console.WriteLine("������ɾ����");
		}
		
		public void setLength(double len)
		{
			length = len;
		}
		
		public double getLength()
		{
			return length;
		}
		
		static void Main(string[] args)
		{
			//Line line = new Line();
			Line line = new Line(6.4);
			Console.WriteLine("�����ĳ��ȣ�{0}", line.getLength());
			line.setLength(4.5);
			Console.WriteLine("�����ĳ��ȣ�{0}", line.getLength());
			Console.ReadKey();
		}
	}
}