namespace ИС.Аукцион_марок.Forms
{
	partial class DelClass
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
			this.button5 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.button5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(12, 172);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(343, 52);
			this.button5.TabIndex = 80;
			this.button5.Text = "Удалить класс";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(183, 245);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(173, 38);
			this.button1.TabIndex = 79;
			this.button1.Text = "Главное меню";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.Location = new System.Drawing.Point(12, 245);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(113, 38);
			this.button7.TabIndex = 78;
			this.button7.Text = "Назад";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 116);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(343, 39);
			this.textBox1.TabIndex = 77;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(13, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(342, 58);
			this.label2.TabIndex = 76;
			this.label2.Text = "Введите в поле ввода название \r\nкласса, который хотите удалить";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(368, 28);
			this.menuStrip1.TabIndex = 81;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// DelClass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 297);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.menuStrip1);
			this.Name = "DelClass";
			this.Text = "Удаление класса";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
	}
}