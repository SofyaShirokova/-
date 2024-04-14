using System;
using System.Windows.Forms;

namespace ИС.Аукцион_марок.Forms
{
	public partial class NewClass : Form
	{
		string[,] BD = new string[20, 20];
		
		public NewClass(string[,] BD_)
		{
			InitializeComponent();
			BD = BD_;
		}
	
		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//-------Вызов справки
			MessageBox.Show("СПРАВКА\n\n" +
			"Добавление нового класса\n\n" +
			"Существует следующий функционал:\n\n" +
			"1 Добавить класс. Добавление нового класса в базу знаний\n\n", "Помощь", MessageBoxButtons.OK);
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//-----------Переход в редактор классов
			this.Hide(); 
			var Form = new Change_class(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//-----------Переход к галвной странице
			this.Hide();
			var Form = new Main(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				//----------Добавление нового класса
				bool Flag = true;
				int lenClass = 0;
				//--------Проверка на совпадение названий класса
				for (int i = 4; BD[i, 0] != null; i++) // Классы
				{
					lenClass = i;
					if (BD[i, 0] == textBox1.Text)
						Flag = false;
				}
				if (Flag == true)
				{
					BD[lenClass+1, 0] = textBox1.Text;
					MessageBox.Show(String.Format("Класс <" + textBox1.Text + "> успешно добавлен."), "Добавление класса");
					//-----Переход к редактору классов
					this.Hide();
					var Form = new Change_class(BD);
					Form.Closed += (s, args) => this.Close();
					Form.Show();
				}
				else MessageBox.Show(String.Format("Класс <" + textBox1.Text + "> уже существует."), "Добавление класса");
			}
			else MessageBox.Show(String.Format("Вы не ввели название класса."), "Добавление класса");
		}
	}
}
