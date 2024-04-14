using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС.Аукцион_марок
{
	public partial class NewSingnes : Form
	{
		string[,] BD = new string[20, 20];
		public NewSingnes(string[,] BD_)
		{
			InitializeComponent();
			BD = BD_;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//-----------Переход к галвной странице
			this.Hide();
			var Form = new Main(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//-----------Переход в редактор классов
			this.Hide();
			var Form = new Change_singnes(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				//----------Добавление нового признака
				bool Flag = true;
				int len = 0;
				//--------Проверка на совпадение названий признака
				for (int i = 0; BD[0, i] != null; i++) // признака
				{
					len = i;
					if (BD[0, i] == textBox1.Text)
						Flag = false;
				}
				if (Flag == true)
				{
					BD[0, len + 1] = textBox1.Text;
					for (int i = 1; BD[i, 0] != null; i++)
						BD[i, len + 1] = "";


					MessageBox.Show(String.Format("Признак <" + textBox1.Text + "> успешно добавлен."), "Добавление признака");
					//-----Переход к редактору признаков
					this.Hide();
					var Form = new Change_singnes(BD);
					Form.Closed += (s, args) => this.Close();
					Form.Show();
				}
				else MessageBox.Show(String.Format("Признак <" + textBox1.Text + "> уже существует."), "Добавление признака");
			}
			else MessageBox.Show(String.Format("Вы не ввели название признака."), "Добавление признака");
		}

		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//-------Вызов справки
			MessageBox.Show("СПРАВКА\n\n" +
			"Добавление нового признака\n\n" +
			"Существует следующий функционал:\n\n" +
			"1 Добавить признак. Добавление нового признака в базу знаний\n\n", "Помощь", MessageBoxButtons.OK);
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
	
}
