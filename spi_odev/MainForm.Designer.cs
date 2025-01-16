/*
 * Created by SharpDevelop.
 * User: ireme
 * Date: 30.11.2024
 * Time: 20:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace spi_odev
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnac;
		private System.Windows.Forms.Button btnkapat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Boudrate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textcom;
		private System.Windows.Forms.TextBox textbaudrate;
		private System.Windows.Forms.TextBox textdatabit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textGonderilecekVeriler;
		private System.Windows.Forms.TextBox textgelenveriler;
		private System.Windows.Forms.Button btngonder;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBaslangicSaati;
		private System.Windows.Forms.Button btnSaatGonder;
		private System.Windows.Forms.Button btnLCD2cisatirisil;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxMCdengelenSaat;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textADCverisi;
		private System.Windows.Forms.TextBox textBox1;
		
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
			this.components = new System.ComponentModel.Container();
			this.btnac = new System.Windows.Forms.Button();
			this.btnkapat = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Boudrate = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textcom = new System.Windows.Forms.TextBox();
			this.textbaudrate = new System.Windows.Forms.TextBox();
			this.textdatabit = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textGonderilecekVeriler = new System.Windows.Forms.TextBox();
			this.textgelenveriler = new System.Windows.Forms.TextBox();
			this.btngonder = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.textBaslangicSaati = new System.Windows.Forms.TextBox();
			this.btnSaatGonder = new System.Windows.Forms.Button();
			this.btnLCD2cisatirisil = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxMCdengelenSaat = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textADCverisi = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnac
			// 
			this.btnac.Location = new System.Drawing.Point(280, 0);
			this.btnac.Name = "btnac";
			this.btnac.Size = new System.Drawing.Size(87, 55);
			this.btnac.TabIndex = 0;
			this.btnac.Text = "AÇ";
			this.btnac.UseVisualStyleBackColor = true;
			this.btnac.Click += new System.EventHandler(this.BtnacClick);
			// 
			// btnkapat
			// 
			this.btnkapat.Location = new System.Drawing.Point(280, 54);
			this.btnkapat.Name = "btnkapat";
			this.btnkapat.Size = new System.Drawing.Size(87, 52);
			this.btnkapat.TabIndex = 1;
			this.btnkapat.Text = "KAPAT";
			this.btnkapat.UseVisualStyleBackColor = true;
			this.btnkapat.Click += new System.EventHandler(this.BtnkapatClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "com no";
			// 
			// Boudrate
			// 
			this.Boudrate.Location = new System.Drawing.Point(17, 40);
			this.Boudrate.Name = "Boudrate";
			this.Boudrate.Size = new System.Drawing.Size(100, 23);
			this.Boudrate.TabIndex = 3;
			this.Boudrate.Text = "boudrate";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(17, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "databits";
			// 
			// textcom
			// 
			this.textcom.Location = new System.Drawing.Point(137, 9);
			this.textcom.Name = "textcom";
			this.textcom.Size = new System.Drawing.Size(100, 22);
			this.textcom.TabIndex = 5;
			this.textcom.Text = "COM8";
			// 
			// textbaudrate
			// 
			this.textbaudrate.Location = new System.Drawing.Point(137, 37);
			this.textbaudrate.Name = "textbaudrate";
			this.textbaudrate.Size = new System.Drawing.Size(100, 22);
			this.textbaudrate.TabIndex = 6;
			this.textbaudrate.Text = "115200";
			// 
			// textdatabit
			// 
			this.textdatabit.Location = new System.Drawing.Point(137, 65);
			this.textdatabit.Name = "textdatabit";
			this.textdatabit.Size = new System.Drawing.Size(100, 22);
			this.textdatabit.TabIndex = 7;
			this.textdatabit.Text = "8";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 38);
			this.label2.TabIndex = 8;
			this.label2.Text = "gönderilecek veri";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(17, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "gelen veri";
			// 
			// textGonderilecekVeriler
			// 
			this.textGonderilecekVeriler.Location = new System.Drawing.Point(133, 112);
			this.textGonderilecekVeriler.Multiline = true;
			this.textGonderilecekVeriler.Name = "textGonderilecekVeriler";
			this.textGonderilecekVeriler.Size = new System.Drawing.Size(175, 49);
			this.textGonderilecekVeriler.TabIndex = 10;
			this.textGonderilecekVeriler.Text = "LCD nin 2.satırında gözükecek";
			// 
			// textgelenveriler
			// 
			this.textgelenveriler.BackColor = System.Drawing.SystemColors.WindowText;
			this.textgelenveriler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.textgelenveriler.Location = new System.Drawing.Point(133, 174);
			this.textgelenveriler.Multiline = true;
			this.textgelenveriler.Name = "textgelenveriler";
			this.textgelenveriler.Size = new System.Drawing.Size(267, 80);
			this.textgelenveriler.TabIndex = 11;
			// 
			// btngonder
			// 
			this.btngonder.Location = new System.Drawing.Point(314, 114);
			this.btngonder.Name = "btngonder";
			this.btngonder.Size = new System.Drawing.Size(102, 47);
			this.btngonder.TabIndex = 12;
			this.btngonder.Text = "mcYe gönder";
			this.btngonder.UseVisualStyleBackColor = true;
			this.btngonder.Click += new System.EventHandler(this.BtngonderClick);
			// 
			// serialPort1
			// 
			this.serialPort1.BaudRate = 115200;
			this.serialPort1.PortName = "COM8";
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 343);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "başlangıç saati";
			// 
			// textBaslangicSaati
			// 
			this.textBaslangicSaati.Location = new System.Drawing.Point(141, 344);
			this.textBaslangicSaati.Name = "textBaslangicSaati";
			this.textBaslangicSaati.Size = new System.Drawing.Size(135, 22);
			this.textBaslangicSaati.TabIndex = 14;
			this.textBaslangicSaati.Text = "12:34:56";
			// 
			// btnSaatGonder
			// 
			this.btnSaatGonder.Location = new System.Drawing.Point(297, 333);
			this.btnSaatGonder.Name = "btnSaatGonder";
			this.btnSaatGonder.Size = new System.Drawing.Size(85, 44);
			this.btnSaatGonder.TabIndex = 15;
			this.btnSaatGonder.Text = "saat gönder";
			this.btnSaatGonder.UseVisualStyleBackColor = true;
			this.btnSaatGonder.Click += new System.EventHandler(this.BtnSaatGonderClick);
			// 
			// btnLCD2cisatirisil
			// 
			this.btnLCD2cisatirisil.Location = new System.Drawing.Point(297, 412);
			this.btnLCD2cisatirisil.Name = "btnLCD2cisatirisil";
			this.btnLCD2cisatirisil.Size = new System.Drawing.Size(103, 45);
			this.btnLCD2cisatirisil.TabIndex = 16;
			this.btnLCD2cisatirisil.Text = "LCD satır 2 sil";
			this.btnLCD2cisatirisil.UseVisualStyleBackColor = true;
			this.btnLCD2cisatirisil.Click += new System.EventHandler(this.BtnLCD2cisatirisilClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(60, 434);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "LCD";
			// 
			// textBoxMCdengelenSaat
			// 
			this.textBoxMCdengelenSaat.Location = new System.Drawing.Point(137, 431);
			this.textBoxMCdengelenSaat.Name = "textBoxMCdengelenSaat";
			this.textBoxMCdengelenSaat.Size = new System.Drawing.Size(100, 22);
			this.textBoxMCdengelenSaat.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(21, 303);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "adc VERİSİ";
			// 
			// textADCverisi
			// 
			this.textADCverisi.Location = new System.Drawing.Point(141, 304);
			this.textADCverisi.Name = "textADCverisi";
			this.textADCverisi.Size = new System.Drawing.Size(150, 22);
			this.textADCverisi.TabIndex = 20;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(133, 261);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(175, 22);
			this.textBox1.TabIndex = 21;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(445, 574);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textADCverisi);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxMCdengelenSaat);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnLCD2cisatirisil);
			this.Controls.Add(this.btnSaatGonder);
			this.Controls.Add(this.textBaslangicSaati);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btngonder);
			this.Controls.Add(this.textgelenveriler);
			this.Controls.Add(this.textGonderilecekVeriler);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textdatabit);
			this.Controls.Add(this.textbaudrate);
			this.Controls.Add(this.textcom);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Boudrate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnkapat);
			this.Controls.Add(this.btnac);
			this.Name = "MainForm";
			this.Text = "spi_odev";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
