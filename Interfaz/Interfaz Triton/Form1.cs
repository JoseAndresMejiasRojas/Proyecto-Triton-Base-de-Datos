using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Triton
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Atleta_Text_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void Atleta_Group_Box_Enter(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'tritonDataSet.Atleta' table. You can move, or remove it, as needed.
			this.atletaTableAdapter.Fill(this.tritonDataSet.Atleta);

		}

		private void Atleta_Tab_Page_Click(object sender, EventArgs e)
		{

		}
	}
}
