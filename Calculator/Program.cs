using DefaultNamespace.MatCalculations;



bool running=true;

bool number=false;

//MatTypes matTypes = new MatTypes();

Console.WriteLine("-----Calculater----------------------------------- ");
Console.WriteLine("-----Number 1------------------------------------- ");
string value1 = Console.ReadLine();
double val1 = int.Parse(value1);


Console.WriteLine("-----Number 2-------------------------------------- ");
string value2 = Console.ReadLine();
double val2 = int.Parse(value2);

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
				MatTypes addition = new MatTypes(new Addition());
				val1 = addition.getValue(val1, val2);
				
				break;

			case "-":
				MatTypes substract = new MatTypes(new Substraction());
				val1 = substract.getValue(val1, val2);
				
				break;

			case "*":
				MatTypes multiplication = new MatTypes(new Multiplication());
				val1 = multiplication.getValue(val1, val2);

				break;

			case "/":
				MatTypes division = new MatTypes(new Division());
				val1 = division.getValue(val1, val2);
				
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
		

