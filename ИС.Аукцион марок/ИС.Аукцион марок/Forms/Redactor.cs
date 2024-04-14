using System;
using System.Windows.Forms;

namespace ИС.Аукцион_марок
{
	public partial class Redactor : Form
	{
		string[,] BD = new string[20, 20];
	
		public Redactor(string[,] BD_)
		{
			InitializeComponent();
			BD = BD_;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//--------------Переход к редактору классов
			this.Hide();
			var Form = new Change_class(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//--------------Вызов справки
			MessageBox.Show("СПРАВКА\n\n" +
			"Редактор базы знаний\n\n" +
			"Существует следующий функционал:\n\n" +
			"1 Редактирование классов. Включает в себя изменение признаков классов.\n\n" +
			"2 Проверка целостности базы знаний. Включает в себя проверку признаков в классе.\n\n", "Помощь", MessageBoxButtons.OK);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			//--------------Переход к редактору признаков
			this.Hide();
			var Form = new Change_singnes(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();

		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			//--------------Переход к начальной странице
			this.Hide();
			var Form = new Main(BD);
			Form.Closed += (s, args) => this.Close(); Form.Show();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			//--------------Переход к начальной странице
			this.Hide(); var Form = new Main(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

	}
}
