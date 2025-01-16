/*
 * Created by SharpDevelop.
 * User: ireme
 * Date: 30.11.2024
 * Time: 20:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace spi_odev
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string gelenveri=string.Empty;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnacClick(object sender, EventArgs e)
		{
			if(!serialPort1.IsOpen)
			{
				serialPort1.PortName=textcom.Text;
				serialPort1.BaudRate=Convert.ToInt32(textbaudrate.Text);
				serialPort1.DataBits=Convert.ToInt32(textdatabit.Text);
				serialPort1.Open();
			}

		}
		void BtnkapatClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)
			{
				serialPort1.Close();
			}

		}
		void BtngonderClick(object sender, EventArgs e)
		{
			serialPort1.Write(textGonderilecekVeriler.Text);
		}
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			gelenveri=serialPort1.ReadLine();
			this.Invoke(new EventHandler(DisplayText));
		}
		
		private void DisplayText(object sender, EventArgs e)
		{
			textgelenveriler.Text =gelenveri;
			
			if(gelenveri[0]=='[')
		    {
			   	//[12:34:56
			   	textBoxMCdengelenSaat.Text = gelenveri.Substring(1,8);
		    }
		
			else if(gelenveri[0]=='(')
		    {
			   	textADCverisi.Text=gelenveri.Substring(1,4);
		    }
			
			else if(gelenveri[0]=='{')
		    {
			   	textBox1.Text=gelenveri.Substring(1,gelenveri.Length-2);
		    }
		}
		void BtnSaatGonderClick(object sender, EventArgs e)
		{
			serialPort1.Write("%" +textBaslangicSaati.Text+"/");
		}
		void BtnLCD2cisatirisilClick(object sender, EventArgs e)
		{
			
		}

	}
}
