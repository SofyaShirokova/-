using System;
using System.Windows.Forms;

namespace ИС.Аукцион_марок
{
	public partial class Result : Form
	{
			public void Split(string[,] BD,ref string[,] AllClass, int i, int j, char str, ref string explanation, int lenSigns)
			{
				bool Flag = false;
				//----------Сверка значения и значений классов
				if (AllClass[i, j] != null)
					if (AllClass[i, j].IndexOf(str) > -1) {
						string[] interval = AllClass[i, j].Split(new char[] { str });
						if (str == '-') Flag = (!(Convert.ToDouble(interval[1]) >= Convert.ToDouble(BD[3,j]) && Convert.ToDouble(interval[0]) <= Convert.ToDouble(BD[3, j])));
							else if (str == ',') Flag = (AllClass[i, j].IndexOf(BD[3, j]) == -1);
								else Flag = false;
					//-------Если класс не походит
					if (Flag)
					{
						//-----------Формирование объяснения
						explanation = explanation + "Класс <" + AllClass[i, 0] + "> исключен, так как значение признака <"
											+ BD[0, j] + "> = " + BD[3, j] + " ∉ [" + AllClass[i, j] + "]"+ '\r' + '\n';
						//-------Удаление неподходящего класса
						for (int k = 0; k < lenSigns ; k++)
							AllClass[i, k] = null;	
					}
				}
			}

			string[,] BD = new string[20, 20];
			public Result(string[,] BD_)
			{
				InitializeComponent();
				BD = BD_;

			try
			{
				string [,] AllClass = new string[20,20];
				string explanation = "";// Строка объяснений
				string AllclassStr = "";// Строка походящих классов
				int lenSigns = 0;
				int lenClass = 0;

				for (int i = 4; BD[i, 0] != null; i++)
					AllClass[i - 4,0] = BD[i,0]; // Названия классов [0,0]  [1,0]  [2,0]...	

				for (int i = 0; BD[i, 0] != null; i++)
				{
					lenClass++;//Количество классов
					for (int j = 0; BD[0, j] != null; j++)
					{
						if (i == 0) lenSigns++;//Количество признаков
						AllClass[i, j + 1] = BD[i + 4, j + 1]; // Все признаки для классов [0,1]  [0,2]... [m,1]  [m,2]...
					}
				}

				for (int j = 1; BD[0, j] != null; j++) // Признаки
					for (int i = 0; BD[i+4, 0] != null; i++) // Классы
					{
						Split( BD, ref AllClass, i,  j, '-', ref explanation, lenSigns); //Интервалы "-"
						Split( BD, ref AllClass, i,  j,',', ref explanation, lenSigns); //Перечисление , (0,1)
					}
				
				//-----------Формирование строки с классами
				for (int i = 0; i < lenClass; i++)
					if (AllClass[i, 0] != null)
						AllclassStr = AllclassStr + AllClass[i, 0] + ", ";
				//--------------Формирование вывода
				if (AllclassStr == "") textBox1.Text = "Обект не принадлежит никакому классу";
					else textBox1.Text = AllclassStr.Remove(AllclassStr.Length - 2);// Список Классов
					textBox2.Text = explanation;
			}
			catch{ MessageBox.Show(String.Format("Ошибка классификации"), "Классификация");}

		}

		private void button7_Click(object sender, EventArgs e)
		{
			//------Переход к классификации
			for (int i = 1; BD[0, i] != null; i++)
				BD[3, i] = "";
			this.Hide();
			var Form = new Class(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//------Вывод справки
			MessageBox.Show("СПРАВКА\n\n" +
			"Класс вина\n\n" +
			"Выводит класс вина\n\n", "Помощь", MessageBoxButtons.OK);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//------Переход к главной странице
			
			for (int i = 1; BD[0, i] != null; i++)
				BD[3, i] = "";
			this.Hide(); 
			var Form = new Main(BD);
			Form.Closed += (s, args) => this.Close();
			Form.Show();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
