namespace ClassLibrary1
{
	public class Class1
	{
		enum Operand
		{
			None,
			Plus,
			Minus,
			Multiply,
			Divide,
		}

		public static void Two()
		{
			Console.WriteLine("Hello, World!");
		}

		public static float NewMethod(string svar)
		{
			float lastNumber = 0;
			Operand lastOperand = Operand.Plus;

			foreach (char bokstav in svar)
			{

				float nummer;
				if (float.TryParse(bokstav.ToString(), out nummer))
				{
					lastNumber = lastOperand switch
					{
						Operand.Plus => lastNumber + nummer,
						Operand.Minus => lastNumber - nummer,
						Operand.Multiply => lastNumber * nummer,
						Operand.Divide => lastNumber / nummer,
						_ => lastNumber,
					};
				}
				else
				{
					lastOperand = bokstav.ToString() switch
					{
						"+" => Operand.Plus,
						"-" => Operand.Minus,
						"*" => Operand.Multiply,
						"/" => Operand.Divide,
						_ => Operand.None,
					};
				}
			}

			return lastNumber;
		}
	}
}