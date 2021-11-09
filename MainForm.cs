/*
 * Created by SharpDevelop.
 * User: LThornley
 * Date: 25/11/2020
 * Time: 10:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermindv2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm(string a, string b, string c, string d)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			textBox6.Text = a;
			textBox7.Text = b;
			textBox8.Text = c;
			textBox9.Text = d;

		}
		
	}
}
