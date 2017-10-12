using System;

namespace PolymorphismApplication
{
	class Box
	{
		private double length;
		private double breadth;
		private double height;
		
		public double getVolume()
		{
			return length * breadth * height;
		}
		
		public void setLength(double len)
		{
			length = len;
		}
		
		public void setBreadth(double bre)
		{
			breadth = bre;
		}
		
		public void setHeight(double hei)
		{
			height = hei;
		}
		
		//����+�������ʵ������Box���
		public static Box operator+(Box b, Box c)
		{
			Box box = new Box();
			box.length = b.length + c.length;
			box.breadth = b.breadth + c.breadth;
			box.height = b.height + c.height;
			return box;
		}
		
		//���رȽ������==
		public static bool operator==(Box b, Box c)
		{
			bool status = false;
			if(b.length == c.length && b.height == c.height && b.breadth == c.breadth)
			{
				status = true;
			}
			return status;
		}
		
		//���رȽ������!=
		public static bool operator!=(Box lhs, Box rhs)
		{
			bool status = false;
			if(lhs.length != rhs.length || lhs.height != rhs.height || lhs.breadth != rhs.breadth)
			{
				status = true;
			}
			return status;
		}
		
		//���رȽ������<
		public static bool operator<(Box lhs, Box rhs)
		{
			bool status = false;
			if(lhs.length < rhs.length && lhs.height < rhs.height && lhs.breadth < rhs.breadth)
			{
				status = true;
			}
			return status;
		}
		
		public static bool operator>(Box lhs, Box rhs)
		{
			bool status = false;
			if(lhs.length > rhs.length && lhs.height > rhs.height && lhs.breadth > rhs.breadth)
			{
				status = true;
			}
			return status;
		}
		
		public static bool operator<=(Box lhs, Box rhs)
		{
			bool status = false;
			if(lhs.length <= rhs.length && lhs.height <= rhs.height && lhs.breadth <= rhs.breadth)
			{
				status = true;
			}
			return status;
		}
		
		public static bool operator>=(Box lhs, Box rhs)
		{
			bool status = false;
			if(lhs.length >= rhs.length && lhs.height >= rhs.length && lhs.breadth >= rhs.breadth)
			{
				status = true;
			}
			return status;
		}
		
		public override string ToString()
		{
			return String.Format("({0}, {1}, {2})", length, breadth, height);
		}
	}
	
	class Tester
	{
		static void Main(string[] args)
		{
			Box box1 = new Box();
			Box box2 = new Box();
			Box box3 = new Box();
			Box box4 = new Box();
			double volume = 0.0;
			
			box1.setLength(6.0);
			box1.setBreadth(7.0);
			box1.setHeight(5.0);
			
			box2.setLength(12.0);
			box2.setBreadth(13.0);
			box2.setHeight(10.0);
			
			Console.WriteLine("box1: {0}", box1.ToString());
			Console.WriteLine("box2: {0}", box2.ToString());
			
			volume = box1.getVolume();
			Console.WriteLine("box1�������{0}", volume);
			
			volume = box2.getVolume();
			Console.WriteLine("box2�������{0}", volume);
			
			//�����������
			box3 = box2 + box1;
			Console.WriteLine("box3: {0}", box3.ToString());
			volume = box3.getVolume();
			Console.WriteLine("box3�������{0}", volume);
			
			//�Ƚ�����box
			if(box1 > box2)
			{
				Console.WriteLine("box1 ���� box2");
			}
			else
			{
				Console.WriteLine("box1 ������ box2");
			}
			
			if(box1 < box2)
			{
				Console.WriteLine("box1 С�� box2");
			}
			else
			{
				Console.WriteLine("box1 ��С�� box2");
			}
			
			if(box1 >= box2)
			{
				Console.WriteLine("box1 ���ڵ��� box2");
			}
			else
			{
				Console.WriteLine("box1 �����ڵ��� box2");
			}
			
			if(box1 <= box2)
			{
				Console.WriteLine("box1 С�ڵ��� box2");
			}
			else
			{
				Console.WriteLine("box1 ��С�ڵ��� box2");
			}
			
			if(box1 != box2)
			{
				Console.WriteLine("box1 ������ box2");
			}
			else
			{
				Console.WriteLine("box1 ���� box2");
			}
			
			box4 = box3;
			if(box3 == box4)
			{
				Console.WriteLine("box3 ���� box4");
			}
			else
			{
				Console.WriteLine("box3 ������ box4");
			}
			
			Console.ReadKey();
		}
	}
	
}