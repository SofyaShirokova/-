using System;
using System.Windows.Forms;
using System.IO;

namespace ИС.Аукцион_марок
{
	public partial class Change_singnes : Form
	{
		//string[,] BD = new string[100, 100];
		string[,] BD = new string[20, 20];
		
		public Change_singnes(string[,] BD_)
		{
			InitializeComponent();
			BD = BD_;

			//----Заполнение таблицы
			int j = 0;
			for (int i = 0; 3 > i; i++)
			{
				j = 1;
				TableSignes.Columns.Add(BD[i, 0], BD[i, 0]);
				while (BD[0, j] != null)
				{
					if (i == 0) TableSignes.Rows.Add();
					TableSignes.Rows[j - 1].Cells[i].Value = BD[i, j];
					j++;
				}
			}

			for (int i = 0; i < TableSignes.ColumnCount; i++)//классы
				TableSignes.Columns[i].Width = 150;
		}
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//-------Открыть спарвку
			MessageBox.Show("СПРАВКА\n\n" +
			"Изменение классов\n\n" +
			"Существует следующий функционал:\n\n" +
			"1 Изменить признак. Открывает окно изменения признака.\n\n" +
			"2 Добавить признак. Открывает окно добавления нового признака.\n\n" +
			"3 Удаление признак. Выделите в окне признак для удаления и после нажатия правой кнопки мыши нажмите 'удалить'. \n\n", "Помощь", MessageBoxButtons.OK);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			//-------Переход к выбору редактора
			this.Hide();
			var Form = new Redactor(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//-------Переход к галвному окну
			this.Hide();
			var Form = new Main(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int k = 0;
			//----Удаление признака из таблицы
			int delet = TableSignes.SelectedCells[0].RowIndex;
			TableSignes.Rows.RemoveAt(delet);
			string name = BD[0, delet + 1];
			//----Удаление признака из БЗ
			for (int j = 0; BD[j, 0] != null; j++)
				BD[j,delet+1] = null;

			k = delet + 2;
			for (int i = delet + 2; BD[0, i] != null; i++)
			{
				k = i;
				for (int j = 0; BD[j, 0] != null; j++)
				{
					BD[j, i - 1] = BD[j, i];

				}
			}

			for (int j = 0; BD[j, 0] != null; j++)
				BD[j, k] = null;

			MessageBox.Show(String.Format("Признак <"+ name + "> удален успешно"), "Удаление признака");
		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			//-------------Проверка типа признака и значения
			bool flag = true;
			string strType = "";
			string strInterval = "";

			for (int i = 0; i < TableSignes.Rows.Count; i++)
				switch (TableSignes.Rows[i].Cells[1].Value)
				{
					case "Логический":
						if (Convert.ToString(TableSignes.Rows[i].Cells[2].Value)!="0,1") 
						{
							strInterval= strInterval + "Значение для признака <" + TableSignes.Rows[i].Cells[0].Value + ">, не является Логическим типом данных." + '\r' + '\n';
							flag = false;
						}
						break;

					case "Количественный":
						if (Convert.ToString(TableSignes.Rows[i].Cells[2].Value).IndexOf('-') == -1)
						{
							strInterval = strInterval + "Интервал, введенный для признака <" + TableSignes.Rows[i].Cells[0].Value + ">, не является Количественным типом данных." + '\r' + '\n';
							flag = false;
						}
						break;
					case "Качественный":
						if (Convert.ToString(TableSignes.Rows[i].Cells[2].Value).IndexOf(',') == -1)
						{
							strInterval = strInterval + "Интервал, введенный для признака <" + TableSignes.Rows[i].Cells[0].Value + ">, не является Качественным типом данных." + '\r' + '\n';
							flag = false;
						}
						break;
					default:
						strType = strType + "Тип данных для признака <" + TableSignes.Rows[i].Cells[0].Value + "> указан неверно" + '\r' + '\n';
						flag = false;
						break;
				}

			if (flag == false)
			{
				MessageBox.Show(String.Format(strType + strInterval), "Тип данных");
			}else
				{
					//--------Проверка полноты
					bool doNotWrite = false;
					try
					{
						for (int j = 0; j < TableSignes.Rows.Count; j++)
							for (int i = 0; i < TableSignes.Rows[j].Cells.Count; i++)
								if (TableSignes.Rows[j].Cells[i].Value == null || TableSignes.Rows[j].Cells[i].Value=="")
									doNotWrite = true;
						if (doNotWrite == false) MessageBox.Show(String.Format("База зананий заполнена верно."+ '\r' + '\n'+"База знаний заполнена полностью."), "Полнота базы знаний");
						else MessageBox.Show(String.Format("В базе знаний отсутствуют значения."), "Полнота базы знаний");
					}
					catch
					{
						MessageBox.Show(String.Format("База знаний заполнена неверно."), "Полнота базы знаний");
					}
				}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//----ДОБАВИТЬ СОХРАНЕНИЕ

			for (int i = 0; i < 3; i++)
				for (int j = 0; BD[i, j] != null; j++)
					BD[i, j] = null;

			//------Заполнение заголовков
			for (int i = 0; i < 3; i++) BD[i, 0] = TableSignes.Columns[i].HeaderText;
				//BD[3, 0] = "Значение";
			//----Заполнение таблицы
			for (int i = 0; 3 > i; i++)
				for (int j = 1; TableSignes.Rows.Count+1 > j; j++)
				{
					BD[i, j] = Convert.ToString(TableSignes.Rows[j - 1].Cells[i].Value);
					
				}
			if ((BD[2, TableSignes.Rows.Count-1] != null) && (BD[3, TableSignes.Rows.Count-1] == null))
			{
				for (int j = 3; BD[j, 0] != null; j++)
					BD[j, TableSignes.Rows.Count-1] = "";
			}


			//----------ЗАПИСЬ В ФАЙЛ
			string path = @"./БЗ.txt";
			string text="";

			for (int j = 0; BD[0, j] != null; j++)
			{
				for (int i = 0; BD[i, 0] != null; i++)
				{
					text = text + Convert.ToString(BD[i, j]) + ":";
				}
				text=text.Remove(text.Length - 1)+ '\r' + '\n';
			}
			try
			{
				using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
				{
					sw.WriteLine(text.Remove(text.Length - 1));
				}
			}
			catch
			{
				MessageBox.Show(String.Format("База знаний не сохранена."), "Файл");
			}
		

		}

		private void button6_Click(object sender, EventArgs e)
		{

			//------Заполнение заголовков
			for (int i = 0; i < 3; i++) BD[i, 0] = TableSignes.Columns[i].HeaderText;
			BD[4, 0] = "Значение";
			for (int i = 4; i < TableSignes.ColumnCount; i++) BD[i, 0] = TableSignes.Columns[i].HeaderText;
			//----Заполнение таблицы
			for (int i = 0; 3 > i; i++)
				for (int j = 1; TableSignes.Rows.Count  > j; j++)
					BD[i, j] = Convert.ToString(TableSignes.Rows[j-1].Cells[i].Value);
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			//-------Переход к добавлению признака
			this.Hide();
			var Form = new NewSingnes(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}
	}
}
