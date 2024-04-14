using System;
using System.Windows.Forms;

namespace ИС.Аукцион_марок.Forms
{
	public partial class DelClass : Form
	{
		string[,] BD = new string[20, 20];
		
		public DelClass(string[,] BD_)
		{
			InitializeComponent();
			BD = BD_;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			//-------переход в галвное меню
			this.Hide();
			var Form = new Main(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//----------переход в редактор классов
			this.Hide();
			var Form = new Change_class(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int classDel = 0;
			int allclass = 0;
			bool Flag = false;
			//--------поиск класса
			if (textBox1.Text != "")
			{
				for (int i = 3; BD[i, 0] != null; i++)// Классы
				{
					allclass = i;
					if (BD[i, 0] == textBox1.Text)
					{
						Flag = true;
						classDel = i;
					}
				}
				if (Flag == true)
				{
					//-----------удаление класса
					for (int j = 0; BD[0, j] != null; j++)//Признаки
					{
						BD[classDel, j] = BD[allclass, j];
						BD[allclass, j] = null;
					}
					MessageBox.Show(String.Format("Класс <" + textBox1.Text + "> успешно удален"), "Удаление класса");
					//-----Переход к редактору классов
					this.Hide();
					var Form = new Change_class(BD);
					Form.Closed += (s, args) => this.Close();
					Form.Show();
				}
				else MessageBox.Show(String.Format("Класса <" + textBox1.Text + "> не существует"), "Удаление класса");
			}else MessageBox.Show(String.Format("Вы не ввели название класса для удаления"), "Удаление класса");
		}
		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//------открыть справку
			MessageBox.Show("СПРАВКА\n\n" +
			"Удаление класса\n\n" +
			"Существует следующий функционал:\n\n" +
			"1 Удаление класс. Удаление класса из базы знаний\n\n", "Помощь", MessageBoxButtons.OK);
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
