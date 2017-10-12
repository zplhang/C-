using System;

namespace InheritanceApplication
{
	//����
	class Shape
	{
		protected int height;
		protected int width;
		
		public void setWidth(int wid)
		{
			width = wid;
		}
		
		public void setHeight(int hei)
		{
			height = hei;
		}
	}
	
	//���ӿ�
	public interface PaintCost
	{
		int getCost(int area);
	}
	
	//������
	class Rectangle : Shape, PaintCost
	{
		public int getArea()
		{
			return width * height;
		}
		
		public int getCost(int area)
		{
			return area * 70;
		}
	}

	class RectangelTester
	{
		static void Main(string[] args)
		{
			Rectangle rect = new Rectangle();
			int area;
			rect.setWidth(5);
			rect.setHeight(7);
			area = rect.getArea();
			Console.WriteLine("�������{0}", area);
			Console.WriteLine("�����ܳɱ���${0}", rect.getCost(area));
			Console.ReadKey();
		}
	}
}