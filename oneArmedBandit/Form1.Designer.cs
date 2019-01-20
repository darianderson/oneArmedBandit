namespace oneArmedBandit
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.d0 = new System.Windows.Forms.Timer(this.components);
			this.d1 = new System.Windows.Forms.Timer(this.components);
			this.d2 = new System.Windows.Forms.Timer(this.components);
			this.stop0 = new System.Windows.Forms.Timer(this.components);
			this.stop1 = new System.Windows.Forms.Timer(this.components);
			this.stop2 = new System.Windows.Forms.Timer(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(97, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(35, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 73);
			this.label1.TabIndex = 1;
			this.label1.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(107, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 73);
			this.label2.TabIndex = 2;
			this.label2.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(181, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 73);
			this.label3.TabIndex = 3;
			this.label3.Text = "0";
			// 
			// d0
			// 
			this.d0.Interval = 10;
			this.d0.Tick += new System.EventHandler(this.d0_Tick);
			// 
			// d1
			// 
			this.d1.Interval = 10;
			this.d1.Tick += new System.EventHandler(this.d1_Tick);
			// 
			// d2
			// 
			this.d2.Interval = 10;
			this.d2.Tick += new System.EventHandler(this.d2_Tick);
			// 
			// stop0
			// 
			this.stop0.Interval = 1500;
			this.stop0.Tick += new System.EventHandler(this.stop0_Tick);
			// 
			// stop1
			// 
			this.stop1.Interval = 2000;
			this.stop1.Tick += new System.EventHandler(this.stop1_Tick);
			// 
			// stop2
			// 
			this.stop2.Interval = 3000;
			this.stop2.Tick += new System.EventHandler(this.stop2_Tick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(62, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Your cash :           ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(165, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 20);
			this.label5.TabIndex = 5;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer d0;
		private System.Windows.Forms.Timer d1;
		private System.Windows.Forms.Timer d2;
		private System.Windows.Forms.Timer stop0;
		private System.Windows.Forms.Timer stop1;
		private System.Windows.Forms.Timer stop2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

