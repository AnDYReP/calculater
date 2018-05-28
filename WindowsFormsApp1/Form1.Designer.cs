namespace WindowsFormsApp1
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
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(94, 77);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(30, 23);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.calculate);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(94, 106);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(30, 23);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.calculate);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(94, 135);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(30, 23);
            this.Divide.TabIndex = 12;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.calculate);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(94, 164);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(30, 23);
            this.Multiply.TabIndex = 13;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.calculate);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 30);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(242, 77);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 23);
            this.button15.TabIndex = 17;
            this.button15.Text = "С";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(12, 77);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 20;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.caltrig);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(13, 106);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 21;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.caltrig);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(13, 135);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(75, 23);
            this.Tg.TabIndex = 22;
            this.Tg.Text = "tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.caltrig);
            // 
            // Ctg
            // 
            this.Ctg.Location = new System.Drawing.Point(13, 164);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(75, 23);
            this.Ctg.TabIndex = 23;
            this.Ctg.Text = "ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.caltrig);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 20);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Name = "Form1";
            this.Text = "т ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Ctg;
        private System.Windows.Forms.TextBox textBox2;
    }
}

