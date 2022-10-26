using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	//用mbox顯示目前時間，格式為yyyy/MM/dd HH:mm:ss
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show($"現在時刻{DateTime.Today}","目前時間",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void resultbtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"現在時刻{DateTime.Today}", "目前時間", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
