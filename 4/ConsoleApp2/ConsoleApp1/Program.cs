using System;
using ClassLibrary1;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.SceneGraphs;

class Program
{

    class MyClass: Game
    {
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;


        public MyClass()
        {
			graphics = new GraphicsDeviceManager(this);
		}

		protected override void LoadContent()
		{
			spriteBatch = new(GraphicsDevice);


			base.LoadContent();
		}

		protected override void Draw(GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

			spriteBatch.Begin();

			spriteBatch.DrawRectangle(new(10, 10, 100, 100), Color.Wheat);
			spriteBatch.End();

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

