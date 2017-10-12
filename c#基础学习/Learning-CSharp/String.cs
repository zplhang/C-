using System;
namespace StringApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			//�ַ�������
			string fname, lname;
			fname = "Rowan";
			lname = "Atkinson";
			
			string fullname = fname + lname;
			Console.WriteLine("Full name: {0}", fullname);
			
			//ͨ��ʹ��string���캯��
			char[] letters = {'H', 'e', 'l', 'l', 'o'};
			string greetings = new string(letters);
			Console.WriteLine("Greeting: {0}", greetings);
			
			
			//���������ַ���
			string[] sarray = {"Hello", "From", "Tutorials", "Point"};
			string message = String.Join(" ", sarray);
			Console.WriteLine("Message: {0}", message);
			
			//����ת��ֵ�ø�ʽ������
			DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
			string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
			Console.WriteLine("Message: {0}", chat);
			
			//�Ƚ��ַ���
			string str1 = "This is test";
			string str2 = "This is text";
			if(String.Compare(str1, str2) == 0)
			{
				Console.WriteLine(str1 + " and " + str2 + " are equal.");
			}
			else
			{
				Console.WriteLine(str1 + " and " + str2 + " are not equal.");
			}
			
			//�ַ��������ַ���
			string str = "This is test";
			if(str.Contains("test"))
			{
				Console.WriteLine("The sequence 'test' was found.");
			}
			
			//��ȡ���ַ���
			str = "Last night I dreamt of San Pedro";
			Console.WriteLine(str);
			string substr = str.Substring(23);
			Console.WriteLine(substr);
			
			//�����ַ���
			string[] strarray = new string[]{"Down the way nights are dark", 
			"And the sun shines daily on the mountain top",
			"I took a trip on a sailing ship", 
			"And when I reached Jamaica", "I made a stop"};
			str = String.Join("\n", strarray);
			Console.WriteLine(str);
			
			Console.ReadLine();
		}
		
	}
}