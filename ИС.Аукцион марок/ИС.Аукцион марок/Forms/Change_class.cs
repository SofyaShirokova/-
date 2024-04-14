using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace ИС.Аукцион_марок
{
	public partial class Change_class : Form
	{
		//string[,] BD = new string[20, 20];
		string[,] BD = new string[100, 100];

		public Change_class(string[,] BD_)
		{
			InitializeComponent();
			BD = BD_;
			//----Заполнение таблицы
			int j = 0;
			int k = 0;
	
			for (int i = 0; BD[i, 0] != null; i++){// Обход классов (Столбцы)
				if (i != 3)
				{
					j = 1;
					TableClass.Columns.Add(BD[i, 0], BD[i, 0]);
					while (BD[0, j] != null)
					{
						if (k == 0) TableClass.Rows.Add();
						TableClass.Rows[j - 1].Cells[k].Value = BD[i, j];
						j++;
					}
					k++;
				}
			}
			//--------Блокировка редактирвания
			for (int i = 0; i < 3; i++)//классы
				for (j = 0; j < TableClass.Rows.Count; j++){//признаки
					TableClass.Rows[j].Cells[i].ReadOnly = true;
					
				}
			for (int i = 0; i<TableClass.ColumnCount; i++)//Размер
				TableClass.Columns[i].Width = 150;
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//---------вывод справки
			MessageBox.Show("СПРАВКА\n\n" +
			"Классы вина\n\n" +
			"Существует следующий функционал:\n\n" +
			"1 Подробное описание. Открывает окно с подробным описанием классов.\n\n" +
			"2 Изменить. Открывает окно с подробным описанием классов для их редактирования.\n\n" +
			"3 Добавить. Открывает окно добавления нового класса.\n\n" +
			"4 Удаление. Выделите в окне класс для удаления и после нажатия правой кнопки мыши нажмите 'удалить'. \n\n", "Помощь", MessageBoxButtons.OK);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//------------Переход к выбору редактора
			this.Hide(); 
			var Form = new Redactor(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//------------Переход в основное меню
			this.Hide();
			var Form = new Main(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//------------Переход редактору признаков
			this.Hide();
			var Form = new Change_singnes(BD);
			Form.Closed += (s, args) => this.Close(); 
			Form.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//------------Переход к удалению класса
			this.Hide();
			var Form = new Forms.DelClass(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();

		}
		private void button3_Click_1(object sender, EventArgs e)
		{
			//------------Переход к созданию нового класса
			this.Hide(); 
			var Form = new Forms.NewClass(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			//-----------Проверка попадания в интервалы значений
			string strInterval = "";
			bool Flag = false;
			bool SenterFlag = true;
			bool doNotWrite = false;
			for (int j = 0; j < TableClass.Rows.Count; j++)//Признаки
				for (int i = 3; i < TableClass.Columns.Count; i++)//класс
				{//------------Проверка перечислений
					if (Convert.ToString(TableClass.Rows[j].Cells[i].Value).IndexOf(',') > -1)
					{
						string[] intervalClass = Convert.ToString(TableClass.Rows[j].Cells[i].Value).Split(new char[] { ',' });
						for (int k = 0; k < intervalClass.Length; k++)
						{
							Flag = Convert.ToString(TableClass.Rows[j].Cells[2].Value).IndexOf(intervalClass[k]) == -1;
							if (Flag == true)
							{
								strInterval = strInterval + "Класс<" + TableClass.Columns[i].HeaderText + ">. Признак <"
							   + Convert.ToString(TableClass.Rows[j].Cells[0].Value) + "> = " + Convert.ToString(TableClass.Rows[j].Cells[i].Value)
							   + " ∉ [" + Convert.ToString(TableClass.Rows[j].Cells[2].Value) + "] (область допустимых значений)" + '\r' + '\n';
								SenterFlag = false;
							}
						}
					}
					//--------------Проверка интервалов
					else if (Convert.ToString(TableClass.Rows[j].Cells[i].Value).IndexOf('-') > -1)
					{
						string[] interval = Convert.ToString(TableClass.Rows[j].Cells[2].Value).Split(new char[] { '-' });
						string[] intervalClass = Convert.ToString(TableClass.Rows[j].Cells[i].Value).Split(new char[] { '-' });
						Flag = (!((Convert.ToDouble(interval[0]) <= Convert.ToDouble(intervalClass[0])) && (Convert.ToDouble(interval[1]) >= Convert.ToDouble(intervalClass[1]))));
						if (Flag == true) {

							strInterval = strInterval + "Класс<" + TableClass.Columns[i].HeaderText + ">. Признак <"
							+ Convert.ToString(TableClass.Rows[j].Cells[0].Value) + "> = " + Convert.ToString(TableClass.Rows[j].Cells[i].Value)
							 + " ∉ [" + Convert.ToString(TableClass.Rows[j].Cells[2].Value) + "] (область допустимых значений)" + '\r' + '\n';
							SenterFlag = false;
						}
					} else 
					{
						string intervalClass = Convert.ToString(TableClass.Rows[j].Cells[i].Value);
						Flag = Convert.ToString(TableClass.Rows[j].Cells[2].Value).IndexOf(intervalClass) == -1;
						if (Flag == true)
						{
							strInterval = strInterval + "Класс<" + TableClass.Columns[i].HeaderText + ">. Признак <"
							   + Convert.ToString(TableClass.Rows[j].Cells[0].Value) + "> = " + Convert.ToString(TableClass.Rows[j].Cells[i].Value)
							   + " ∉ [" + Convert.ToString(TableClass.Rows[j].Cells[2].Value) + "] (область допустимых значений)" + '\r' + '\n';
								SenterFlag = false;
						}
						
					}
					
			
				}
			//--------------Классификация, если все значения входят в интервалы значений
			if (SenterFlag == true)
			{
				//------------Проверка полноты
				try
				{
					for (int i = 0; BD[i, 0] != null; i++)
						for (int j = 0; BD[0, j] != null; j++)
							if (BD[i, j] == "")
								doNotWrite = true;
					if (doNotWrite == false) MessageBox.Show(String.Format("База зананий заполнена верно." + '\r' + '\n' + "База знаний заполнена полностью."), "Полнота базы знаний");
					else MessageBox.Show(String.Format("В базе знаний отсутствуют значения."), "Полнота базы знаний");
				}
				catch { MessageBox.Show(String.Format("База знаний заполнена неверно."), "Полнота базы знаний"); }
			}
			else
			{ MessageBox.Show(String.Format(strInterval), "Корректность базы знаний"); }
		}

		private void button4_Click(object sender, EventArgs e)
		{

			for (int i = 4; i < TableClass.ColumnCount+1; i++)
				for (int j = 0; BD[i, j] != null; j++)
					BD[i, j] = null;
			//------Заполнение заголовков

			//for (int i = 0; i < 3; i++) BD[i, 0] = TableClass.Columns[i].HeaderText;
			//BD[3, 0] = "Значение";
			for (int i = 4; i < TableClass.ColumnCount+1; i++) BD[i, 0] = TableClass.Columns[i-1].HeaderText;

			//----Заполнение таблицы
			for (int i = 4; i < TableClass.ColumnCount+1; i++)//классы
				for (int j = 1; j < TableClass.Rows.Count+1 ; j++)//признаки
					BD[i, j] = Convert.ToString(TableClass.Rows[j-1].Cells[i-1].Value);

			//----------ЗАПИСЬ В ФАЙЛ

			string path = @"./БЗ.txt";
			string text = "";
			for (int j = 0; BD[0, j] != null; j++)
			{
				for (int i = 0; BD[i, 0] != null; i++)
					text = text + Convert.ToString(BD[i, j]) + ":";
				text = text.Remove(text.Length - 1) + '\r' + '\n';
			}
			try
			{
				using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
					sw.WriteLine(text.Remove(text.Length - 1));
			}
			catch
			{
				MessageBox.Show(String.Format("База знаний не сохранена."), "Файл");
			}

		}
	}
}
