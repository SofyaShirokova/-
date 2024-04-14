using System;
using System.Windows.Forms;

namespace ИС.Аукцион_марок
{
	public partial class Class : Form
	{
		string[,] BD = new string[20, 20];
		
		public Class(string[,] BD_)
		{
			InitializeComponent();
			BD = BD_;
			//----Заполнение таблицы
			int j = 0;
			for (int i = 0; 4>i ; i++)
			{
				j = 1;
				TableClassis.Columns.Add(BD[i, 0], BD[i, 0]);
				while (BD[0, j] != null)
				{
					if (i==0) TableClassis.Rows.Add();
					TableClassis.Rows[j-1].Cells[i].Value = BD[i, j];
					j++;
				}
			}
			//--------Блокировка редактирвания
			for ( int i = 0; i < 3; i++)//классы
				for ( j = 0; j < TableClassis.Rows.Count; j++)//признаки
					TableClassis.Rows[j].Cells[i].ReadOnly = true;


			for (int i = 0; i < TableClassis.ColumnCount; i++)//Размер
				TableClassis.Columns[i].Width = 150;
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//-------выход из программы
			Application.Exit();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//--------Вывод справочной информации
			MessageBox.Show("СПРАВКА\n\n" +
			"Классификация вина\n\n" +
			"Существует следующий функционал:\n\n" +
			"1 Классифицировать. Определяет класс вина на основе введенных данных\n\n", "Помощь", MessageBoxButtons.OK);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			

			//----Внесение заполненых значений
			for (int i = 1; BD[0, i] != null; i++)
				BD[3, i] = Convert.ToString(TableClassis.Rows[i-1].Cells[3].Value);

			bool doNotWrite = false;
			try
			{
				//-----------Проверка попадания в интервалы значений
				string strInterval = "";
				bool Flag = false;
				bool SenterFlag = true;
				doNotWrite = false;
				for (int j = 1; BD[0, j] != null; j++)//признак
					for (int i = 4; BD[i, 0] != null; i++)//класс
					{//------------Проверка перечислений
						if (Convert.ToString(BD[i, j]).IndexOf(',') > -1)//интервал
						{
							string[] intervalClass = Convert.ToString(BD[i, j]).Split(new char[] { ',' });
							for (int k = 0; k < intervalClass.Length; k++)
							{
								Flag = Convert.ToString(BD[2, j]).IndexOf(intervalClass[k]) == -1;
								if (Flag == true)
								{
									strInterval = strInterval + "Класс<" + BD[i, 0] + ">. Признак <"
								   + BD[0, j] + "> = " + BD[i, j] + " ∉ [" + BD[2, j] + "] (область допустимых значений)" + '\r' + '\n';
									SenterFlag = false;
								}
							}
						} else
						//--------------Проверка интервалов
						if (Convert.ToString(BD[i, j]).IndexOf('-') > -1)
						{
							string[] interval = BD[2, j].Split(new char[] { '-' });
							string[] intervalClass = BD[i, j].Split(new char[] { '-' });
							Flag = (!((Convert.ToDouble(interval[0]) <= Convert.ToDouble(intervalClass[0])) && (Convert.ToDouble(interval[1]) >= Convert.ToDouble(intervalClass[1]))));
							if (Flag == true)
							{

								strInterval = strInterval + "Класс<" + BD[i, 0] + ">. Признак <"
								+ BD[0, j] + "> = " + BD[i, j] + " ∉ [" + BD[2, j] + "] (область допустимых значений)" + '\r' + '\n';
								SenterFlag = false;
							}
						}
						else
						{
							string intervalClass = BD[i, j];
							Flag = BD[2, j].IndexOf(intervalClass) == -1;
							if (Flag == true)
							{
								strInterval = strInterval + "Класс<" + BD[i, 0] + ">. Признак <"
								   + BD[0, j] + "> = " + BD[i, j] + " ∉ [" + BD[2, j] + "] (область допустимых значений)" + '\r' + '\n';
								SenterFlag = false;

							}

						}

					}
				//--------------Классификация, если все значения входят в интервалы значений
				if (SenterFlag == true)
				{

					//----------Проверка полноту введенных значений
					for (int j = 0; BD[0, j] != null; j++)
						if (BD[3, j] == "")
							doNotWrite = true;
					if (doNotWrite == false)
					{
						//-------------Проверка на полноту БЗ
						doNotWrite = false;
						for (int j = 0; BD[0, j] != null; j++)
							for (int i = 0; BD[i, 0] != null; i++)
								if (BD[i, j] == "")
									doNotWrite = true;
						if (doNotWrite == false)
						{
							//------ ПРОВЕРКА ПРИНАЖДЕЛНОСТИ ВВЕДЕННЫХ ЗНАЧЕНИЙ  ИНТЕРВАЛАМ ДОПУСТИМЫХ ЗНАЧЕНИЙ-----//
							Flag = false;
							SenterFlag = true;
							string str = "";
							for (int j = 1; BD[0, j] != null; j++)
							{
								//------------Проверка перечислений
								if (BD[2, j].IndexOf(',') > -1)
								{
									string[] interval = BD[2, j].Split(new char[] { ',' });
									try
									{
										Flag = BD[2, j].IndexOf(BD[3, j]) > -1;
									}
									catch
									{
										Flag = false;
									}
									if (Flag == false) { SenterFlag = false; str = str + "Признак <" + BD[0, j] + "> = " + BD[3, j] + " ∉ [" + BD[2, j] + "] (область допустимых значений)" + '\r' + '\n'; }
								}
								//--------------Проверка интервалов
								if (BD[2, j].IndexOf('-') > -1)
								{
									string[] interval = BD[2, j].Split(new char[] { '-' });
									try
									{
										Flag = (!((Convert.ToDouble(interval[1]) >= Convert.ToDouble(BD[3, j])) && (Convert.ToDouble(interval[0]) <= Convert.ToDouble(BD[3, j]))));
									}
									catch
									{
										Flag = true;
									}
									if (Flag == true) { SenterFlag = false; str = str + "Признак <" + BD[0, j] + "> = " + BD[3, j] + " ∉ [" + BD[2, j] + "] (область допустимых значений)" + '\r' + '\n'; }
								}
							}
							//--------------Классификация, если все значения входят в интервалы значений
							if (SenterFlag == true)
							{
								Flag = false;
								SenterFlag = true;
								this.Hide();
								var Form = new Result(BD);
								Form.Closed += (s, args) => this.Close();
								Form.Show();
							}
							else MessageBox.Show(String.Format(str), "Классификация");//Вывод неправильных значений, которые не входят в допустимый интервал
						}
						else MessageBox.Show(String.Format("База знаний заполнена не полность. Заполните базу знаний в разделе <Редактирование базы знаний>"), "Классификация");
					}
					else MessageBox.Show(String.Format("Не все значения признаков для классификации введены"), "Классификация");
				}else MessageBox.Show(String.Format("В базу знаний внесены некорректные данные" + '\r' + '\n'+ strInterval + '\r' + '\n'+ "Измените базу знаний в разделе <Редактирование базы знаний>"), "Классификация");
			}
			catch { MessageBox.Show(String.Format("База знаний заполнена неверно"), "Классификацияй"); }

		}

		private void button7_Click(object sender, EventArgs e)
		{
			//Переход в главное меню
			this.Hide();
			var Form = new Main();
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//-----Переход в главное меню
			this.Hide();
			var Form = new Main();
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

	}
}
