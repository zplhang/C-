/*
using System;

delegate int NumberChanger(int n);

namespace DelegateApplication
{
	class TestDelegate
	{
		static int num = 10;
		
		public static int AddNum(int p)
		{
			num += p;
			return num;
		}
		
		public static int MultNum(int q)
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
			//����ί��ʵ��
			NumberChanger nc;
			NumberChanger nc1 = new NumberChanger(AddNum);
			NumberChanger nc2 = new NumberChanger(MultNum);
			nc = nc1;
			nc += nc2;
			//ʹ��ί�ж�����÷���
			//nc1(25);
			//Console.WriteLine("Value of Num: {0}", getNum());
			//nc2(5);
			//Console.WriteLine("Value of Num: {0}", getNum());
			
			//���öಥ
			nc(5);
			Console.WriteLine("Value of Num: {0}", getNum());
			Console.ReadLine();
		}
	}
}
*/

using System;
using System.IO;

namespace DelegateApplication
{
	class PrintString
	{
		static FileStream fs;
		static StreamWriter sw;
		//����ί��
		public delegate void printString(string s);
		
		//�÷�����ӡ������̨
		public static void WriteToScreen(string str)
		{
			Console.WriteLine("The String is: {0}", str);
		}
		
		//�÷�����ӡ���ļ�
		public static void WriteToFile(string s)
		{
			fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
			sw = new StreamWriter(fs);
			sw.WriteLine(s);
			sw.Flush();
			sw.Close();
			fs.Close();
		}
		
		//�÷�����ί����Ϊ��������ʹ�������÷���
		public static void sendString(printString ps)
		{
			ps("Hello World");
		}
		
		static void Main(string[] args)
		{
			printString ps1 = new printString(WriteToScreen);
			printString ps2 = new printString(WriteToFile);
			sendString(ps1);
			sendString(ps2);
			Console.ReadKey();
		}
	}
}