/*
 * Created by SharpDevelop.
 * User: LThornley
 * Date: 25/11/2020
 * Time: 10:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;
using System.Text;
using System;
using System.Text.RegularExpressions;
//using Mastermindv2.Program;

namespace Mastermindv2
{
	partial class MainForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(54, 129);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 105);
			this.button1.TabIndex = 0;
			this.button1.Text = "Red";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button_click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(191, 129);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 105);
			this.button2.TabIndex = 1;
			this.button2.Text = "Orange";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button_click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Yellow;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(326, 129);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 105);
			this.button3.TabIndex = 2;
			this.button3.Text = "Yellow";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button_click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(460, 129);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 105);
			this.button4.TabIndex = 3;
			this.button4.Text = "Green";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button_click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Blue;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(54, 250);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(120, 101);
			this.button5.TabIndex = 4;
			this.button5.Text = "Blue";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button_click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(191, 250);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(113, 101);
			this.button6.TabIndex = 5;
			this.button6.Text = "Purple";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button_click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.White;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(326, 250);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(115, 101);
			this.button7.TabIndex = 6;
			this.button7.Text = "White";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button_click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Black;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Location = new System.Drawing.Point(460, 250);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(113, 101);
			this.button8.TabIndex = 7;
			this.button8.Text = "Black";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button_click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MistyRose;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label1.Location = new System.Drawing.Point(54, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(519, 73);
			this.label1.TabIndex = 8;
			this.label1.Text = "Mastermind";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(54, 370);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 22);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "Your Choice is: ";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(191, 370);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(113, 22);
			this.textBox2.TabIndex = 10;
			this.textBox2.Text = "Your Choice is: ";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(326, 370);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(113, 22);
			this.textBox3.TabIndex = 11;
			this.textBox3.Text = "Your Choice is: ";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(460, 370);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(113, 22);
			this.textBox4.TabIndex = 12;
			this.textBox4.Text = "Your Choice is: ";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(54, 443);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(517, 77);
			this.textBox5.TabIndex = 13;
			this.textBox5.Text = "Result: ";
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(54, 398);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(120, 39);
			this.button9.TabIndex = 14;
			this.button9.Text = "Go";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Test_Solution);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(453, 398);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(120, 39);
			this.button10.TabIndex = 15;
			this.button10.Text = "Clear";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.button_click_clear);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button11.Location = new System.Drawing.Point(253, 398);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(120, 39);
			this.button11.TabIndex = 16;
			this.button11.Text = "New Challenge";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.run_mastermind);
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.SystemColors.Control;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.ForeColor = System.Drawing.SystemColors.Control;
			this.textBox6.Location = new System.Drawing.Point(54, 111);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(120, 13);
			this.textBox6.TabIndex = 17;
			this.textBox6.Text = "Result: ";
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.SystemColors.Control;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.ForeColor = System.Drawing.SystemColors.Control;
			this.textBox7.Location = new System.Drawing.Point(191, 111);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(120, 13);
			this.textBox7.TabIndex = 18;
			this.textBox7.Text = "Result: ";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.SystemColors.Control;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox8.ForeColor = System.Drawing.SystemColors.Control;
			this.textBox8.Location = new System.Drawing.Point(326, 111);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(120, 13);
			this.textBox8.TabIndex = 19;
			this.textBox8.Text = "Result: ";
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.SystemColors.Control;
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox9.ForeColor = System.Drawing.SystemColors.Control;
			this.textBox9.Location = new System.Drawing.Point(460, 111);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(120, 13);
			this.textBox9.TabIndex = 20;
			this.textBox9.Text = "Result: ";
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.SystemColors.Control;
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox10.Location = new System.Drawing.Point(54, 521);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(80, 15);
			this.textBox10.TabIndex = 21;
			this.textBox10.Text = "No. Guesses = ";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.SystemColors.Control;
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox11.Location = new System.Drawing.Point(135, 521);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(80, 15);
			this.textBox11.TabIndex = 22;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 564);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mastermindv2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
			
		
		string Guess1 = "";
		string Guess2 = "";
		string Guess3 = "";
		string Guess4 = "";

		
		void button_click(object sender, System.EventArgs e)
		{
			if(Guess1 == ""){
				Button button = (Button)sender;
				Guess1 = button.Text;
				textBox1.Text = Guess1 + " ";}
			else { 
				if(Guess2 == ""){
					Button button = (Button)sender;
					Guess2 = button.Text;
					textBox2.Text = Guess2 + " ";}
				else {
					if(Guess3 == ""){
						Button button = (Button)sender;
						Guess3 = button.Text;
						textBox3.Text = Guess3 + " ";}
					else{
						if(Guess4 == ""){
							Button button = (Button)sender;
							Guess4 = button.Text;
							textBox4.Text = Guess4 + " ";}
					}
				}
			}
		}
		
		void button_click_clear(object sender, EventArgs e)
		{
			Guess1 = "";
			textBox1.Text = "Your Choice is: ";
			Guess2 = "";
			textBox2.Text = "Your Choice is: ";
			Guess3 = "";
			textBox3.Text = "Your Choice is: ";
			Guess4 = "";
			textBox4.Text = "Your Choice is: ";
			
		}
		
		void run_mastermind(object sender, EventArgs e)
		{
			
			string[] Colours = new string[]{"Red", "Orange", "Yellow", "Green", "Blue", "Purple", "White", "Black"};
		
			Random rand = new Random();    
			int index1 = rand.Next(Colours.Length);
			int index2 = rand.Next(Colours.Length);
			int index3 = rand.Next(Colours.Length);
			int index4 = rand.Next(Colours.Length);
	  
			string[] Answer = new string[]{Colours[index1],Colours[index2],Colours[index3],Colours[index4]};
							
			textBox6.Text = Colours[index1];
			textBox7.Text = Colours[index2];
			textBox8.Text = Colours[index3];
			textBox9.Text = Colours[index4];
			
			textBox5.Text = "Result:";
			
		}
		
		void Test_Solution(object sender, EventArgs e)
		{
			string[] Guess = new string[]{Guess1,Guess2,Guess3, Guess4};
			
			string[] Answer = new string[]{textBox6.Text , textBox7.Text, textBox8.Text, textBox9.Text};
			int[] Exact = new int[]{0,0,0,0};
			
			
				// Reads guess and compares to answer for exact match.
					
				for (int i = 0; i < Guess.Length; i++){
						
					if(Guess[i] == Answer[i]) {Exact[i] = 1;
					} else {Exact[i] = 0;}
				}
					
					int sumExact = 0;
					for (int j = 0; j < Exact.Length; j++)
					{
					    sumExact += Exact[j];
					}
					
					// Sets up vector to multiply for non-exact colours.
					
					string[] RemainingAns = new string[]{"0","0","0","0"};
					string[] RemainingGuess = new string[]{"0","0","0","0"};
					for (int k = 0; k < Exact.Length; k++){
						
						if(Exact[k] == 1) {RemainingAns[k] = "0"; RemainingGuess[k] = "0";
						} else {RemainingAns[k] = Answer[k]; RemainingGuess[k] = Answer[k];}
					}
					
					
					// Checks non-exact colours
					
					int[] RightColour = new int[]{0,0,0,0};
					
					for (int i = 0; i < Guess.Length; i++){
						
						if(RemainingGuess[i] != "0" && Array.Exists(RemainingAns, element => element == Guess[i])){RightColour[i] = 1;
						} else {RightColour[i] = 0;}
					}
					
					int sumColour = 0;
					for (int j = 0; j < RightColour.Length; j++)
					{
					    sumColour += RightColour[j];
					}
					
					if(sumExact == 4){textBox5.Text = ("Correct! You win! Thanks for playing!");
					} else {
					
					textBox5.Text = "You guessed " + string.Join(", ", Guess) +
						(". You have " + sumExact + " colours in the correct position and " + sumColour + " colours correct.") +
						(" What is your next guess?");
					
					Guess1 = "";
					textBox1.Text = "Your Choice is: ";
					Guess2 = "";
					textBox2.Text = "Your Choice is: ";
					Guess3 = "";
					textBox3.Text = "Your Choice is: ";
					Guess4 = "";
					textBox4.Text = "Your Choice is: ";
				
					double result = 0;
					if(textBox11.Text==""){result = 1;
					} else {result = double.Parse(textBox11.Text) + 1;}
					
					textBox11.Text = result.ToString();
					
					}
		}
	}
}
