using System;
using System.IO;

namespace SimpleEventApplication
{
	//��������
	public class EventTest
	{
		private int value;
		
		public delegate void NumManipulationHandler();
		
		public event NumManipulationHandler ChangeNum;
		protected virtual void OnNumChanged()
		{
			if(ChangeNum != null)
			{
				//�����¼�
				ChangeNum();
			}
			else
			{
				Console.WriteLine("event not fire");
				Console.ReadKey();
			}
		}
		
		public EventTest()
		{
			int n = 5;
			SetValue(n);
		}
		
		public void SetValue(int n)
		{
			if(value != n)
			{
				value = n;
				OnNumChanged();
			}
		}
	}
	
	//��������
	public class subscribEvent
	{
		public void printf()
		{
			Console.WriteLine("event fire");
			Console.ReadKey();
		}
	}
	
	//����
	public class MainClass
	{
		/*
		public static void Main(string[] args)
		{
			EventTest e = new EventTest();
			subscribEvent v = new subscribEvent();
			e.ChangeNum += new EventTest.NumManipulationHandler(v.printf);
			e.SetValue(7);
			e.SetValue(11);
		}
		*/
	}
}

namespace BoilerEventApp
{
	//boiler��
	class Boiler
	{
		private int temp;
		private int pressure;
		
		public Boiler(int t, int p)
		{
			temp = t;
			pressure = p;
		}
		
		public int getTemp()
		{
			return temp;
		}
		
		public int getPressure()
		{
			return pressure;
		}
	}
	
	//�¼�������
	class DelegateBoilerEvent
	{
		public delegate void BoilerLogHandler(string status);
		
		//���������ί�ж����¼�
		public event BoilerLogHandler BoilerEventLog;
		
		public void LogProcess()
		{
			string remarks = "O.K.";
			Boiler b = new Boiler(100, 12);
			int t = b.getTemp();
			int p = b.getPressure();
			if(t > 150 || t < 80 || p < 12 || p > 15)
			{
				remarks = "Need Maintenance";
			}
			OnBoilerEventLog("Logging Info:\n");
			OnBoilerEventLog("Temparature: " + t + "\nPressure: " + p);
			OnBoilerEventLog("\nMessage: " + remarks);
		}
		
		protected void OnBoilerEventLog(string message)
		{
			if(BoilerEventLog != null)
			{
				BoilerEventLog(message);
			}
		}
	}
	
	//���ౣ��д����־�ļ�������
	class BoilerInfoLogger
	{
		FileStream fs;
		StreamWriter sw;
		public BoilerInfoLogger(string filename)
		{
			fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
			sw = new StreamWriter(fs);
		}
		
		public void Logger(string info)
		{
			sw.WriteLine(info);
		}
		
		public void Close()
		{
			sw.Close();
			fs.Close();
		}
	}
	
	//�¼�������
	public class RecordBoilerInfo
	{
		static void Logger(string info)
		{
			Console.WriteLine(info);
		}
		
		static void Main(string[] args)
		{
			BoilerInfoLogger filelog = new BoilerInfoLogger("boiler.txt");
			DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
			boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
			boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(filelog.Logger);
			boilerEvent.LogProcess();
			Console.ReadLine();
			filelog.Close();
		}
	}
}