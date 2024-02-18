
using DefaultNamespace;

bool running=true;

bool number=false;

MatTypes matTypes = new MatTypes();

Console.WriteLine("-----Calculater----------------------------------- ");
Console.WriteLine("-----Number 1------------------------------------- ");
string value1 = Console.ReadLine();
int val1 = int.Parse(value1);


Console.WriteLine("-----Number 2-------------------------------------- ");
string value2 = Console.ReadLine();
int val2 = int.Parse(value2);

while (running)
{
	if (number)
	{
		Console.WriteLine("-----number or end--------------------------");
		value2 = Console.ReadLine();

		if (value2.Contains("end"))
		{
			running = false;
			Console.WriteLine("-----Bye---------------------------------");
		}
		else
		{
			val2 = int.Parse(value2);
			number = false; 	
		}
		
		 
	}
	else
	{
		
		Console.WriteLine("-----Calculation type: +-*/ or end------------");
		string caltype = Console.ReadLine();
			
		
		
		switch (caltype)
		{
			case "+":
				val1 = matTypes.Add(val1,val2);
				break;

			case "-":
				val1 = matTypes.Sub(val1,val2);
				break;

			case "*":
				val1 = matTypes.Multication(val1,val2);
				break;

			case "/":
				val1 = matTypes.Divide(val1,val2);
				break;
			case "end":
				running = false;
				Console.WriteLine("-----Bye---------------------------");
				break;
		}
		Console.WriteLine(val1);
		number = true;

	}
	
	
	
}
		

