namespace ИС.Аукцион_марок
{
	partial class Change_singnes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_singnes));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.TableSignes = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TableSignes)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.ExitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(826, 28);
			this.menuStrip1.TabIndex = 52;
			this.menuStrip1.Text = "Задача";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.helpToolStripMenuItem.Text = "Справка";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.ExitToolStripMenuItem.Text = "Выход";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(7, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 27);
			this.label1.TabIndex = 57;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(641, 363);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(173, 38);
			this.button2.TabIndex = 56;
			this.button2.Text = "Главное меню";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(18, 363);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(173, 38);
			this.button4.TabIndex = 55;
			this.button4.Text = "Назад";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(13, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(309, 29);
			this.label6.TabIndex = 71;
			this.label6.Text = "Значения признаков классов";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(559, 196);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(255, 52);
			this.button3.TabIndex = 74;
			this.button3.Text = "Удалить признак";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// TableSignes
			// 
			this.TableSignes.AllowUserToAddRows = false;
			this.TableSignes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableSignes.Location = new System.Drawing.Point(18, 80);
			this.TableSignes.Name = "TableSignes";
			this.TableSignes.RowHeadersWidth = 51;
			this.TableSignes.RowTemplate.Height = 24;
			this.TableSignes.Size = new System.Drawing.Size(535, 268);
			this.TableSignes.TabIndex = 75;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(559, 278);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(255, 70);
			this.button1.TabIndex = 76;
			this.button1.Text = "Проверка введенных данных";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.button5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(559, 80);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(255, 52);
			this.button5.TabIndex = 77;
			this.button5.Text = "Сохранить изменения";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.button6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.Location = new System.Drawing.Point(559, 138);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(255, 52);
			this.button6.TabIndex = 78;
			this.button6.Text = "Добавить признак";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click_1);
			// 
			// Change_singnes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 413);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TableSignes);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Change_singnes";
			this.Text = "Изменение признаков";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TableSignes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView TableSignes;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
	}
}