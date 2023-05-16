namespace WinFormsApp2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(294, 51);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(165, 249);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "1+1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(219, 347);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ställ en mattefråga";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(203, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "svar";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(132, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Svar";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(446, 361);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(203, 34);
			this.button2.TabIndex = 5;
			this.button2.Text = "lägg till svetsare";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(524, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "inga arbetar just nu";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(583, 401);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(203, 34);
			this.button3.TabIndex = 7;
			this.button3.Text = "lägg till matematiker";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(366, 444);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(203, 34);
			this.button4.TabIndex = 8;
			this.button4.Text = "Vänta";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 538);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button2;
		private Label label4;
		private Button button3;
		private Button button4;
	}
}