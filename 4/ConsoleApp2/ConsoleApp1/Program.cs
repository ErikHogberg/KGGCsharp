using System;
using ClassLibrary1;
using Microsoft.Xna.Framework;

class Program
{

    class MyClass: Game
    {
		GraphicsDeviceManager graphics;
        public MyClass()
        {
			graphics = new GraphicsDeviceManager(this);
		}

		protected override void Draw(GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

			base.Draw(gameTime);
		}
	}

	static void Main(string[] args)
	{

		new MyClass().Run();


		Class1.Two();


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

			float lastNumber = Class1.NewMethod(svar);

			Console.WriteLine(lastNumber.ToString("0.00"));


		}
	}

	
}

