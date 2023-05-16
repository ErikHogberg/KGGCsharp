using System;
//using ClassLib
class Program
{
	enum Operand
	{
		None,
		Plus,
		Minus,
		Multiply,
		Divide,
	}


	static void Main(string[] args)
	{
		//Two();


		while (true)
		{

			Console.WriteLine("Frågar efter nummer");
			var svar = Console.ReadLine();


			if (svar == "exit")
			{
				return;
			}
			if (svar == null)
			{
				continue;
			}

			float lastNumber = 0;
			Operand lastOperand = Operand.Plus;

			foreach (char bokstav in svar)
			{

				float nummer;
				if (float.TryParse(bokstav.ToString(), out nummer))
				{
					switch (lastOperand)
					{

						case Operand.Plus:

							lastNumber = lastNumber + nummer;
							break;
						case Operand.Minus:
							lastNumber = lastNumber - nummer;
							break;
						case Operand.Multiply:
							lastNumber = lastNumber * nummer;
							break;
						case Operand.Divide:
							lastNumber = lastNumber / nummer;
							break;
						case Operand.None:
						default:
							break;
					}

				}
				else
				{
					switch (bokstav.ToString())
					{
						case "+":
							lastOperand = Operand.Plus;
							break;
						case "-":
							lastOperand = Operand.Minus;
							break;
						case "*":
							lastOperand = Operand.Multiply;
							break;
						case "/":
							lastOperand = Operand.Divide;
							break;
						default:
							Console.WriteLine("Inte en operand");
							lastOperand = Operand.None;
							break;
					}
				}
			}

			Console.WriteLine(lastNumber.ToString("0.00"));


		}
	}
	
}

