using System;
 delegate void NumberChanger(int n);
 
 namespace DelegateApplication
 {
	 class TestDelegate
	 {
		 static int num = 10;
		 
		 public static void AddNum(int p)
		 {
			 num += p;
			 Console.WriteLine("Named Method: {0}", num);
		 }
		 
		 public static void MultiNum(int q)
		 {
			 num *= q;
			 Console.WriteLine("Named Method: {0}", num);
		 }
		 
		 public static int getNum()
		 {
			 return num;
		 }
		 
		 static void Main(string[] args)
		 {
			 //ʹ��������������ί��ʵ��
			 NumberChanger nc = delegate(int x)
			 {
				 Console.WriteLine("Anonymous Method: {0}", x);
			 };
			 
			 //ʹ��������������ί��
			 nc(10);
			 
			 //ʹ����������ʵ����ί��
			 NumberChanger nc1 = new NumberChanger(AddNum);
			 
			 //ʹ��������������ί��
			 nc1(5);
			 
			 //ʹ����һ����������ʵ����ί��
			 NumberChanger nc2 = new NumberChanger(MultiNum);
			 
			 //ʹ��������������ί��
			 nc2(2);
			 
			 Console.ReadKey();
		 }
	 }
 }