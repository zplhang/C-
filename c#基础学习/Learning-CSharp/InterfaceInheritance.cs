using System;
namespace InterfaceApplication
{
	interface IParentInterface
	{
		void ParentInterfaceMethod();
	}
	
	//�ӿڼ̳�
	interface IMyInterface : IParentInterface
	{
		void MethodToImplement();
	}
	
	class InterfaceImplementer : IMyInterface
	{
		static void Main()
		{
			InterfaceImplementer iTmp = new InterfaceImplementer();
			iTmp.MethodToImplement();
			iTmp.ParentInterfaceMethod();
		}
		
		public void MethodToImplement()
		{
			Console.WriteLine("MethodToImplement() is called");
		}
		
		public void ParentInterfaceMethod()
		{
			Console.WriteLine("ParentInterfaceMethod() is called.");
		}
	}
}