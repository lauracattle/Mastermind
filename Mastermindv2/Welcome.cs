/*
 * Created by SharpDevelop.
 * User: LThornley
 * Date: 25/11/2020
 * Time: 16:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermindv2
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Welcome : Form
	{
		public Welcome()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			

		}
		
			void WelcomeLoad(object sender, EventArgs e)
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
					}
		
		
		void clear_name(object sender, EventArgs e)
		{
			textBox2.Text="";
		}
	}
}
