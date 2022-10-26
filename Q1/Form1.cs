using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	//btn click時 用Label顯示目前系統時間和問候語(用二行表示)
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			timeAndHilbl.Text=string.Empty;
		}

		private void resultbtn_Click(object sender, EventArgs e)
		{
			timeAndHilbl.Text=$"現在時間是{DateTime.Today}\r\n哈囉";
		}
	}
}
