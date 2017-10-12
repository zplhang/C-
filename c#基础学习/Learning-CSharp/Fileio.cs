using System;
using System.IO;

namespace FileIOApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			
			for(int i = 1; i <= 20; i++)
			{
				f.WriteByte((byte)i);
			}
			f.Position = 0;
			for(int i = 0; i <= 20; i++)
			{
				Console.Write(f.ReadByte() + " ");
			}
			f.Close();
			
			/*
			* ͨ��File�������ļ�����
			Console.WriteLine(File.GetAttributes("test.dat"));
			File.SetAttributes("test.dat", FileAttributes.Hidden | FileAttributes.ReadOnly);
			Console.WriteLine(File.GetAttributes("test.dat"));
			*/
			
			/*
			* ͨ��FileInfo�������ļ�����
			FileInfo fi = new FileInfo("test.dat");
			Console.WriteLine(fi.Attributes.ToString());
			fi.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
			Console.WriteLine(fi.Attributes.ToString());
			*/
			
			//�ļ�·����ز���
			string dirPath = @"D:\TestDir";
			string filePath = @"D:\TestDir\TestFile.txt";
			Console.WriteLine("<<<<<<<<<<<<<<<{0}>>>>>>>>>>>>>>>", "�ļ�·��");
			
			//��ȡ��ǰ·��
			Console.WriteLine(Environment.CurrentDirectory);
			//�ļ����ļ�������Ŀ¼
			Console.WriteLine(Path.GetDirectoryName(filePath));
			Console.WriteLine(Path.GetDirectoryName(dirPath));
			//�ļ���չ��
			Console.WriteLine(Path.GetExtension(filePath));
			//�ļ���
			Console.WriteLine(Path.GetFileName(filePath));
			Console.WriteLine(Path.GetFileName(dirPath));
			Console.WriteLine(Path.GetFileNameWithoutExtension(filePath));
			
			//����·��
			Console.WriteLine(Path.GetFullPath(filePath));
			Console.WriteLine(Path.GetFullPath(dirPath));
			
			//������չ��
			Console.WriteLine(Path.ChangeExtension(filePath, ".jpg"));
			//��Ŀ¼
			Console.WriteLine(Path.GetPathRoot(dirPath));
			
			
			Console.ReadLine();
		}
	}
}
