/*
 * Created by SharpDevelop.
 * User: LThornley
 * Date: 25/11/2020
 * Time: 16:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Text;

namespace Mastermindv2
{
	partial class Welcome
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MistyRose;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(436, 67);
			this.label1.TabIndex = 9;
			this.label1.Text = "Mastermind";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(12, 90);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(436, 29);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "Welcome to Master Mind 2.1. What is your name?";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.MistyRose;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(12, 120);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(436, 29);
			this.textBox2.TabIndex = 11;
			this.textBox2.Text = "(Insert name here)";
			this.textBox2.Click += new System.EventHandler(this.clear_name);
			this.textBox2.TextChanged += new System.EventHandler(this.Name_Entered);
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(12, 151);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(436, 26);
			this.textBox3.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LimeGreen;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(70, 183);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 33);
			this.button1.TabIndex = 13;
			this.button1.Text = "Yes";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Yes_play);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(318, 183);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(67, 33);
			this.button2.TabIndex = 14;
			this.button2.Text = "No";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.No_play);
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(12, 222);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(436, 167);
			this.textBox4.TabIndex = 15;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LimeGreen;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(172, 395);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 33);
			this.button3.TabIndex = 16;
			this.button3.Text = "Let\'s Play!";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Launch_Game);
			// 
			// Welcome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 440);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Welcome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Welcome";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		
		void Name_Entered(object sender, System.EventArgs e)
		{
			Name = textBox2.Text;
			textBox3.Text = ("Hello, " + Name + ". Would you like to play a game of Mastermind?");
		}
		
		void Yes_play(object sender, System.EventArgs e)
		{
			string[] Colours = new string[]{"Red", "Orange", "Yellow", "Green", "Blue", "Purple", "White", "Black"};
			
			textBox4.Text = ("Great! Here are the rules." +
			                 "To play, simply guess the 4 pin colours in the correct order. The possible colours are: " + 
			                 string.Join(", ", Colours) + 
			                 ". Colours can be repeated. After each turn the game will state how many colours are correct and how many are in the correct position." + 
							 " Click the coloured squares to select your colour choices, then hit 'Go'." +
							 " You can use the clear button to clear your colour choices." + 
							 " If you wish to start over with a new colour challenge, click 'New Challenge'.");
		}
		
		void No_play(object sender, System.EventArgs e)
		{
			textBox4.Text = ("OK. Bye for now!");
		}
		
		void Launch_Game(object sender, System.EventArgs e)
		{
			
			string[] Colours = new string[]{"Red", "Orange", "Yellow", "Green", "Blue", "Purple", "White", "Black"};
					
			Random rand = new Random();    
			int index1 = rand.Next(Colours.Length);
			int index2 = rand.Next(Colours.Length);
			int index3 = rand.Next(Colours.Length);
			int index4 = rand.Next(Colours.Length);
				  
			string[] Answer = new string[]{Colours[index1],Colours[index2],Colours[index3],Colours[index4]};
										
			string Colour1 = Colours[index1];
			string Colour2 = Colours[index2];
			string Colour3 = Colours[index3];
			string Colour4 = Colours[index4];	
						
			this.Hide();
			MainForm mF = new MainForm(Colour1,Colour2,Colour3,Colour4);
			mF.ShowDialog();
			
		}
	}
}
