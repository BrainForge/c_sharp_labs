using System;
using System.IO;

namespace IO
{
	class MainClass
	{	
		public static string name = "";
		public static int yearRead = 0;
		
		public static void Main (string[] args)
		{
			Console.WriteLine("Hi # member of hell \n now: \n " + DateTime.Now.ToString());	
		errorOrReachois:
			switch(Input())
			{
				case 1:
					InputNameAndYear();
					WriteText(name,yearRead);
					ReadText();
					goto errorOrReachois;
				
				case 2:
					InputNameAndYear();
					WriteTextByte(name,yearRead);
					ReadTextByte();
					goto errorOrReachois;
				
				
				case 3:
					InputNameAndYear();
					WriteTextDouble(name,yearRead);
					ReadTextDouble();
					goto errorOrReachois;
				
				case 4:
					Console.WriteLine("okay, bye");
					Environment.Exit(1);
				break;
				
			default:
				Console.WriteLine("okay, crush my program");
				goto errorOrReachois;
			}
		}
		
		private static void InputNameAndYear()
		{
		Error:
			try
			{
				Console.WriteLine("input name");
				name = Console.ReadLine();
				Console.WriteLine("input year");
				yearRead = Int32.Parse(Console.ReadLine());
			}
			catch(FormatException e)
			{
				Console.WriteLine("something went wrong =( \n"+ e);
				goto Error;
			}
		}
		
		private static int Input()
		{
		error:
			Console.WriteLine("1 - text; 2 - binary; 3 - byte; 4 - exit");
			try
			{
				return Int16.Parse(Console.ReadLine());
			}
			catch(FormatException e)
			{
				Console.WriteLine("error input? repeat, error:\n"+e);
				goto error;
			}
		}
		
		private static void WriteText(String name, int year)
		{
			try
			{
				StreamWriter f=new StreamWriter("text.txt");
				f.WriteLine(name+"\n"+year);
				f.Close();
				
				Console.WriteLine("okay");
			}
			catch(IOException e)
			{
				Console.WriteLine("something went wrong =( \n"+ e);
			}
			
		}
		
		private static void ReadText()
		{
			try
			{
				StreamReader f=new StreamReader ("text.txt");
	     		Console.WriteLine("your name: " + f.ReadLine());
				Console.WriteLine("your age " + YearToAge(int.Parse(f.ReadLine())));
				f.Close();
			}
			catch(FileNotFoundException e)
			{
				Console.WriteLine("something went wrong =( \n"+ e);
			}
		}
		
		private static void WriteTextByte(String name, int year)
		{
			try
			{
				FileStream f=new FileStream("est.txt", FileMode.Create, FileAccess.ReadWrite );
				string str = name+"\n"+year;
				char[] ch = str.ToCharArray();
				for(int i = 0; i< str.Length;i++)
				{
					f.WriteByte((byte)ch[i]);
				}
				f.Close();
				
				Console.WriteLine("okay");
			}
			catch(IOException e)
			{
				Console.WriteLine("something went wrong =( \n"+ e);
			}
			
		}
		
		private static void ReadTextByte()
		{
			try
			{
				StreamReader f=new StreamReader ("est.txt");
				Console.WriteLine("your name: " + f.ReadLine());
				Console.WriteLine("your age " + YearToAge(int.Parse(f.ReadLine())));	
				f.Close();
			}
			catch(FileNotFoundException e)
			{
				Console.WriteLine("something went wrong =( \n"+ e);
			}
		}
		
		private static void WriteTextDouble(String name, int year)
		{
			try
			{
				BinaryWriter f = new BinaryWriter(
                     new FileStream("double.txt", FileMode.Create));
				string str = name+"\n"+year;
				
				char[] ch = str.ToCharArray();
				
				for(int i = 0; i< str.Length;i++)
				{
					f.Write((double)ch[i]);
				}
				f.Close();
				
				Console.WriteLine("okay");
			}
			catch(IOException e)
			{
				Console.WriteLine("something went wrong =( \n"+ e);
			}
			
		}
		
		private static void ReadTextDouble()
		{
			try
			{
           		FileStream f = new FileStream("double.txt", FileMode.Open);
           		BinaryReader fin = new BinaryReader(f);
	     
           		long n=f.Length/8;  
           		double[] x=new double[n];
           
           		long i=0;
           		try
           		{
	          		while(true) x[i++]=fin.ReadDouble();
            	}
	     		catch (EndOfStreamException e) 
				{
				}
				
 				string name = "";
				string year = "";
				bool metka = false;
         		foreach (double d in x) 
				{		
					Console.Write(" "+d);
					if(d==10)
						metka = true;
					if(metka)
						year+=(char)d;
					else
						name+=(char)d;
						
				}
         		fin.Close(); Console.ReadKey();
         		f.Close();
				Console.WriteLine("your name: " + name);
				Console.WriteLine("your age " + YearToAge(int.Parse(year)));	
			}
			catch(FileNotFoundException e)
			{
				Console.WriteLine("something went wrong =( \n"+ e);
			}
		}
		
		private static int YearToAge(int year)
		{
			return DateTime.Now.Year - year;
		}
		
	}
}

