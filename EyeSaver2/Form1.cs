using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;


namespace EyeSaver
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Timer timer2;
		private System.ComponentModel.IContainer components;
		private System.DateTime d;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.NotifyIcon notifyIcon2;
		private System.Windows.Forms.TextBox textBox3;
		private bool WorkTime;
		private int Work_lap;
		private int Rest_lap;
		private System.Resources.ResourceManager resources;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();
			Work_lap=1200;
			Rest_lap=300;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			WorkTime=true;

			timer1.Interval=1000;//
			timer2.Interval=Work_lap*1000;
			timer1.Enabled=true;
			timer1.Start();
			timer2.Enabled=true;
			timer2.Start();
			d = DateTime.Now;
			textBox3.Text="Самое время поработать...";

			notifyIcon1.Visible = true;
			notifyIcon2.Visible = false;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			resources = new System.Resources.ResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(24, 136);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Сброс";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Время:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Осталось:";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(72, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(112, 96);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(72, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Location = new System.Drawing.Point(112, 136);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "Скрыть";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// notifyIcon1
			// 
            this.notifyIcon1.Icon = EyeSaver.Properties.Resources.IconWork;
			this.notifyIcon1.Text = "You may work now...";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// notifyIcon2
			// 
            this.notifyIcon2.Icon = EyeSaver.Properties.Resources.IconRest;
			this.notifyIcon2.Text = "You must have a rest now!";
			this.notifyIcon2.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(24, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(160, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(208, 165);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = EyeSaver.Properties.Resources.IconWork;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowInTaskbar = false;
			this.Text = "EyeSaver 1.0";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
        //[STAThread]
        //static void Main() 
        //{
        //    Application.Run(new Form1());
        //}

		private void button1_Click(object sender, System.EventArgs e)
		{
			/*timer2.Stop();
			timer2.Enabled=false;
			timer2.Enabled=true;
			timer2.Start();
			d = DateTime.Now;
			*/
			WorkTime=false;
			timer2_Tick(sender, e);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Visible= false;
			//WindowState = FormWindowState.Minimized;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			//if(WindowState==FormWindowState.Minimized)return;
			if(!Visible)return;
			DateTime d1 = DateTime.Now;
			string ss=d1.ToString("T");
			textBox1.Text=ss;
			int My_lap;
			if(WorkTime)
				My_lap=Work_lap;
			else
				My_lap=Rest_lap;
			long leftt=My_lap-(long)((TimeSpan)(d1-d)).TotalSeconds;
			if(leftt<0)leftt=0;
			
			int hours=(int)(leftt/3600);
			int min=(int)((leftt-hours*3600)/60);
			int sec=(int)(leftt-hours*3600-60*min);
			DateTime dt=new DateTime(1,1,1,hours,min,sec);
			textBox2.Text=dt.ToString("T");
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			//WindowState = FormWindowState.Normal;
			Visible=true;
			WorkTime=!WorkTime;
			if(WorkTime)
			{
                System.Media.SystemSounds.Beep.Play();
				timer2.Interval=Work_lap*1000;
				timer2.Enabled=true;
				timer2.Start();
				textBox3.Text="Самое время поработать...";

                Icon = EyeSaver.Properties.Resources.IconWork;
				notifyIcon1.Visible = true;
				notifyIcon2.Visible = false;
			}
			else
			{
				timer2.Interval=Rest_lap*1000;
				timer2.Enabled=true;
				timer2.Start();
				textBox3.Text="Нужно срочно отдохнуть...";

                Icon = EyeSaver.Properties.Resources.IconRest;
				notifyIcon1.Visible = false;
				notifyIcon2.Visible = true;
			}
			d = DateTime.Now;
		}

		private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
		{
			Visible=!Visible;
			/*if(WindowState == FormWindowState.Minimized)
				
				WindowState = FormWindowState.Normal;
			else
				WindowState = FormWindowState.Minimized;*/
		}

		private void notifyIcon1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
		}


	}
}
