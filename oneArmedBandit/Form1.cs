using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oneArmedBandit
{
	public partial class Form1 : Form
	{
		int cash = 100;
		public Form1()
		{
			InitializeComponent();
			label5.Text = Convert.ToString(cash) +"$";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			d0.Enabled = true;
			d1.Enabled = true;
			d2.Enabled = true;
			stop0.Enabled = true;
			stop1.Enabled = true;
			stop2.Enabled = true;
			if(cash > 0)
			{
				cash -= 10;
				label5.Text = Convert.ToString(cash) + "$";
			}
			if(cash <= 0)
			{
				MessageBox.Show("The rate is impossible!You do not have a cash!");
				
			}
		}

		private void d0_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			int value = random.Next(1,10);
			label1.Text = Convert.ToString(value);
			
		}

		private void d1_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			int value = random.Next(1,10);
			label2.Text = Convert.ToString(value);
		}

		private void d2_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			int value = random.Next(1,10);
			label3.Text = Convert.ToString(value);
		}

		private void stop0_Tick(object sender, EventArgs e)
		{
			d0.Enabled = false;
			stop0.Enabled = false;
		}

		private void stop1_Tick(object sender, EventArgs e)
		{
			d1.Enabled = false;
			stop1.Enabled = false;
		}

		private void stop2_Tick(object sender, EventArgs e)
		{
			
			d2.Enabled = false;
			stop2.Enabled = false;
			int win = 100;
			int twin = 1000;

			for(int i = 0; i<=9; i++)
			{
				if((label1.Text == Convert.ToString(i) && label2.Text == Convert.ToString(i) && label1.Text != label3.Text) || (label2.Text == Convert.ToString(i) && label3.Text == Convert.ToString(i) && label1.Text != label2.Text))
				{
					MessageBox.Show("You win" + win * i + "$");
					cash += win * i;
					label5.Text = Convert.ToString(cash) + "$";
				}
				if( label1.Text == Convert.ToString(i) && label2.Text == Convert.ToString(i) && label3.Text == Convert.ToString(i))
				{
					MessageBox.Show("You win" + twin * i + "$");
					cash += twin * i;
					label5.Text = Convert.ToString(cash) + "$";
				}		
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
