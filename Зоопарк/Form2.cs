using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зоопарк
{
	public partial class Form2 : Form
	{
		public string n;
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			n = textBox1.Text;
			DialogResult = DialogResult.OK;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
		}
	}
}
