using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace ИС.Аукцион_марок
{
	public partial class Main : Form
	{
		string[,] BD = new string[20, 20];//База знаний
		public Main(string[,] BD_ = null)
		{
			InitializeComponent();

			if (BD_ == null) 
			//-----Загрузка БЗ при первом запуске программы
			{ 
				string path = @"./БЗ.txt";
				StreamReader Fileinput = null;
				try
				{
					//-----Считывание из файла
					Fileinput = new StreamReader(path, Encoding.Default);
					int j = 0;
					while (!Fileinput.EndOfStream)
					{
						string filetline = Fileinput.ReadLine();
						if (filetline == "") { continue; }
						string[] str = filetline.Split(new char[] { ':' });
						for (int i = 0; str.Length > i; i++)
							BD[i, j] = str[i];
						j++;
					}
					Fileinput.Close();

					for (j = 1; BD[0, j] != null; j++) // Признаки
						BD[3, j] = "";

				}
				catch { MessageBox.Show("База знаний не может быть загружена", "База знаний", MessageBoxButtons.OK); }

			} else BD = BD_;
		}
	

		private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			//-----Переход к классификации марок с меню
			this.Hide();
			var Form = new Class(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//-----Вывод справочной информации
			MessageBox.Show("СПРАВКА\n\n" +
			"Классификатор вина  \n\n" +
			"Существует следующий функционал:\n\n" +
			"1 Определение класса вина. Необходимо ввести параметры вина, для ее классификации\n\n" +
			"2 Редактирование базы знаний. Включает в себя проверку целостности, редактирование классов и признаков.\n\n", "Помощь", MessageBoxButtons.OK);
		}
		private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
		{
			//-----Переход к редакторы БЗ через меню
			this.Hide();
			var Form = new Redactor(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//----Выход из программы
			Application.Exit();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			//-----Переход к редактору базы знаний
			this.Hide();
			var Form = new Redactor(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//-----Переход к классификации марок
			this.Hide();
			var Form = new Class(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
			
		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			//----Выход из программы
			Application.Exit();
		}

	}
}
