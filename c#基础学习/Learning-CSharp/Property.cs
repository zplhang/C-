using System;
namespace PropertyApplication
{
	public abstract class Person
	{
		public abstract string Name
		{
			get;
			set;
		}
		public abstract int Age
		{
			get;
			set;
		}
	}
	
	class Student : Person
	{
		//��Ա����
		private string code = "N.A";
		private string name = "not known";
		private int age = 0;
		
		//��������Ϊstring��Code����
		public string Code
		{
			get
			{
				return code;
			}
			set
			{
				code = value;
			}
		}
		
		//��������Ϊstring��Name����
		//public string Name
		public override string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		
		//��������Ϊint��Age����
		//public int Age
		public override int Age
		{
			get
			{
				return age;
			}
			set
			{
				age = value;
			}
		}
		
		public override string ToString()
		{
			return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
		}
	}
	
	class ExecuteDemo
	{
		public static void Main(string[] args)
		{
			//����һ���µ�Student����
			Student s = new Student();
			
			//����student��code��name��age
			s.Code = "001";
			s.Name = "Zara";
			s.Age = 9;
			Console.WriteLine("Student Info: {0}", s);
			
			//��������
			s.Age += 1;
			Console.WriteLine("Student Info: {0}", s);
			
			Console.ReadLine();
		}
	}
}