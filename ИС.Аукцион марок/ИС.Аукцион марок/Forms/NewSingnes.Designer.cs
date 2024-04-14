namespace ИС.Аукцион_марок
{
	partial class NewSingnes
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
			this.button5.Location = new System.Drawing.Point(17, 174);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(376, 52);
			this.button5.TabIndex = 80;
			this.button5.Text = "Добавить признак";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(220, 252);
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
			this.button7.Location = new System.Drawing.Point(17, 252);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(113, 38);
			this.button7.TabIndex = 78;
			this.button7.Text = "Назад";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(17, 109);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(376, 39);
			this.textBox1.TabIndex = 77;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(381, 58);
			this.label2.TabIndex = 76;
			this.label2.Text = "Введите в поле ввода название \r\nпризнака, который хотите добавить";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(411, 28);
			this.menuStrip1.TabIndex = 81;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.справкаToolStripMenuItem.Text = "Справка";
			this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// NewSingnes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 300);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.menuStrip1);
			this.Name = "NewSingnes";
			this.Text = "Добавление признака";
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