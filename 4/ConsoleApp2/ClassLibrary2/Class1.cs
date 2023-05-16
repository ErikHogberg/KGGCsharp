namespace ClassLibrary1
{
	public class Position2D: test
	{
		public float x;
		public float y;

		public Position2D(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public void TryAddX(float xAdd)
		{
			x += xAdd;
		}
		public void TryAddY(float yAdd)
		{
		}
	}

	interface test
	{
		public void TryAddX(float xAdd);
		public void TryAddY(float yAdd);
	}

	interface test2
	{

	}

	public class Position3D: Position2D, test2
	{
		public float z;

		public Position3D(float x, float y, float z): base(x, y) 
		{
			this.z = z;
		}

		
	}


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

		public abstract class Person
		{
			public string Name;

			public abstract string Arbeta();
		}

		public class Matematiker : Person
		{
			public float MittNummer = 1;
			public override string Arbeta()
			{
				MittNummer = NewMethod("1+" + MittNummer.ToString());
				return "Jag räknar 1+1 till " + MittNummer.ToString();
			}
		}

		public class Svetsare : Person
		{
			float progress = 0;

			public override string Arbeta()
			{
				progress += 0.5f;
				if (progress > 3)
				{
					return "Jag är färdig med att svetsa";
				}
				else
				{
					return "Jag svetsar fortfarande";
				}
			}
		}


		public static void Two()
		{
	 
			var pos = new Position3D(0f, 0f,0f);
			var pos2 = new Position2D(0f, 0f);
			pos.x= 1f;
			pos.TryAddX(1);
			float x2 = pos.x;

			AddTo(pos);
			AddTo(pos2);

			Position2D result = AddPosítions(pos, pos2);

			Console.WriteLine("Hello, World!");
		}

		public static Position2D AddPosítions(Position2D one, Position2D two)
		{
			return new Position2D(
				one.x + two.x,
				one.y + two.y
				);
		}

		static void AddTo(test addable)
		{
			addable.TryAddX(1);
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