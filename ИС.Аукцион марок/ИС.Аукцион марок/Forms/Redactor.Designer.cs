namespace ИС.Аукцион_марок
{
	partial class Redactor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redactor));
			this.button1 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(392, 50);
			this.button1.TabIndex = 17;
			this.button1.Text = "Редактирование классов";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.button6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.Location = new System.Drawing.Point(12, 146);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(390, 49);
			this.button6.TabIndex = 21;
			this.button6.Text = "Редактирование признаков";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.ExitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(419, 28);
			this.menuStrip1.TabIndex = 24;
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
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 27);
			this.label1.TabIndex = 25;
			this.label1.Text = "\r\n";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(236, 210);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(173, 38);
			this.button3.TabIndex = 34;
			this.button3.Text = "Главное меню";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.button4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(17, 210);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(124, 38);
			this.button4.TabIndex = 33;
			this.button4.Text = "Назад";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(30, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(366, 29);
			this.label2.TabIndex = 35;
			this.label2.Text = "Выберите раздел редактирования";
			// 
			// Redactor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 260);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Redactor";
			this.Text = "Редактор базы знаний";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
	}
}