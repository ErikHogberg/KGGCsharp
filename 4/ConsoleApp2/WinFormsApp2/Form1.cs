using ClassLibrary1;

namespace WinFormsApp2
{
	public partial class Form1 : Form
	{

		List<Class1.Person> people = new List<Class1.Person>();

		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click_1(object sender, EventArgs e)
		{
			string question = textBox1.Text;
			float answer = ClassLibrary1.Class1.NewMethod(question);
			textBox1.Text = answer.ToString("0");
		}
		private void button2_Click(object sender, EventArgs e)
		{
			people.Add(new Class1.Svetsare());
			UpdateList();
		}
		private void UpdateList()
		{
			string text = "";
			foreach (var person in people)
			{
				text += "\n" + person.Arbeta();
			}
			label4.Text = text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			people.Add(new Class1.Matematiker());
			UpdateList();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			UpdateList();

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}