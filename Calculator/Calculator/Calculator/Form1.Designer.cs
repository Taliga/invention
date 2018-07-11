namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Logarithm = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.Squaring = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.Cotangent = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.Cosine = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Arctangent = new System.Windows.Forms.Button();
            this.Arccosine = new System.Windows.Forms.Button();
            this.InverseNumber = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Radical = new System.Windows.Forms.Button();
            this.MultiplicationOnFive = new System.Windows.Forms.Button();
            this.ArcSin = new System.Windows.Forms.Button();
            this.Stepen = new System.Windows.Forms.Button();
            this.LogE = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.TanH = new System.Windows.Forms.Button();
            this.SinH = new System.Windows.Forms.Button();
            this.CosH = new System.Windows.Forms.Button();
            this.NumberPow = new System.Windows.Forms.Button();
            this.NumberRoot = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 310);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(12, 61);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(44, 44);
            this.Multiply.TabIndex = 3;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.button1_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(74, 61);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(46, 44);
            this.Division.TabIndex = 4;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(138, 61);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(49, 44);
            this.Add.TabIndex = 5;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(204, 61);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(48, 44);
            this.Substraction.TabIndex = 6;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "first digit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "second digit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "answer";
            // 
            // Logarithm
            // 
            this.Logarithm.Location = new System.Drawing.Point(12, 111);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(44, 43);
            this.Logarithm.TabIndex = 10;
            this.Logarithm.Text = "log";
            this.Logarithm.UseVisualStyleBackColor = true;
            this.Logarithm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(74, 111);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(46, 43);
            this.Sinus.TabIndex = 11;
            this.Sinus.Text = "sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Squaring
            // 
            this.Squaring.Location = new System.Drawing.Point(138, 111);
            this.Squaring.Name = "Squaring";
            this.Squaring.Size = new System.Drawing.Size(49, 43);
            this.Squaring.TabIndex = 12;
            this.Squaring.Text = "x^2";
            this.Squaring.UseVisualStyleBackColor = true;
            this.Squaring.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(315, 114);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(48, 42);
            this.Module.TabIndex = 13;
            this.Module.Text = "mod";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cotangent
            // 
            this.Cotangent.Location = new System.Drawing.Point(138, 160);
            this.Cotangent.Name = "Cotangent";
            this.Cotangent.Size = new System.Drawing.Size(48, 44);
            this.Cotangent.TabIndex = 14;
            this.Cotangent.Text = "ctg";
            this.Cotangent.UseVisualStyleBackColor = true;
            this.Cotangent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Tangent
            // 
            this.Tangent.Location = new System.Drawing.Point(70, 160);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(50, 44);
            this.Tangent.TabIndex = 15;
            this.Tangent.Text = "tg";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cosine
            // 
            this.Cosine.Location = new System.Drawing.Point(12, 159);
            this.Cosine.Name = "Cosine";
            this.Cosine.Size = new System.Drawing.Size(47, 44);
            this.Cosine.TabIndex = 16;
            this.Cosine.Text = "cos";
            this.Cosine.UseVisualStyleBackColor = true;
            this.Cosine.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(369, 161);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(47, 43);
            this.Min.TabIndex = 17;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.button1_Click);
            // 
            // Arctangent
            // 
            this.Arctangent.Location = new System.Drawing.Point(314, 161);
            this.Arctangent.Name = "Arctangent";
            this.Arctangent.Size = new System.Drawing.Size(49, 42);
            this.Arctangent.TabIndex = 18;
            this.Arctangent.Text = "arctg";
            this.Arctangent.UseVisualStyleBackColor = true;
            this.Arctangent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Arccosine
            // 
            this.Arccosine.Location = new System.Drawing.Point(261, 160);
            this.Arccosine.Name = "Arccosine";
            this.Arccosine.Size = new System.Drawing.Size(47, 42);
            this.Arccosine.TabIndex = 19;
            this.Arccosine.Text = "arccos";
            this.Arccosine.UseVisualStyleBackColor = true;
            this.Arccosine.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // InverseNumber
            // 
            this.InverseNumber.Location = new System.Drawing.Point(369, 114);
            this.InverseNumber.Name = "InverseNumber";
            this.InverseNumber.Size = new System.Drawing.Size(48, 42);
            this.InverseNumber.TabIndex = 20;
            this.InverseNumber.Text = "1/x";
            this.InverseNumber.UseVisualStyleBackColor = true;
            this.InverseNumber.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(202, 112);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(50, 42);
            this.Cube.TabIndex = 21;
            this.Cube.Text = "x^3";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Radical
            // 
            this.Radical.Location = new System.Drawing.Point(204, 159);
            this.Radical.Name = "Radical";
            this.Radical.Size = new System.Drawing.Size(47, 42);
            this.Radical.TabIndex = 22;
            this.Radical.Text = "rad";
            this.Radical.UseVisualStyleBackColor = true;
            this.Radical.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MultiplicationOnFive
            // 
            this.MultiplicationOnFive.Location = new System.Drawing.Point(261, 114);
            this.MultiplicationOnFive.Name = "MultiplicationOnFive";
            this.MultiplicationOnFive.Size = new System.Drawing.Size(48, 38);
            this.MultiplicationOnFive.TabIndex = 23;
            this.MultiplicationOnFive.Text = "x*5";
            this.MultiplicationOnFive.UseVisualStyleBackColor = true;
            this.MultiplicationOnFive.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ArcSin
            // 
            this.ArcSin.Location = new System.Drawing.Point(262, 61);
            this.ArcSin.Name = "ArcSin";
            this.ArcSin.Size = new System.Drawing.Size(47, 48);
            this.ArcSin.TabIndex = 24;
            this.ArcSin.Text = "arcsin";
            this.ArcSin.UseVisualStyleBackColor = true;
            this.ArcSin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Stepen
            // 
            this.Stepen.Location = new System.Drawing.Point(314, 61);
            this.Stepen.Name = "Stepen";
            this.Stepen.Size = new System.Drawing.Size(49, 48);
            this.Stepen.TabIndex = 25;
            this.Stepen.Text = "e^x";
            this.Stepen.UseVisualStyleBackColor = true;
            this.Stepen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LogE
            // 
            this.LogE.Location = new System.Drawing.Point(369, 61);
            this.LogE.Name = "LogE";
            this.LogE.Size = new System.Drawing.Size(47, 47);
            this.LogE.TabIndex = 26;
            this.LogE.Text = "LogE";
            this.LogE.UseVisualStyleBackColor = true;
            this.LogE.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(12, 210);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(47, 48);
            this.Log10.TabIndex = 27;
            this.Log10.Text = "log10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TanH
            // 
            this.TanH.Location = new System.Drawing.Point(70, 210);
            this.TanH.Name = "TanH";
            this.TanH.Size = new System.Drawing.Size(50, 48);
            this.TanH.TabIndex = 28;
            this.TanH.Text = "tanh";
            this.TanH.UseVisualStyleBackColor = true;
            this.TanH.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SinH
            // 
            this.SinH.Location = new System.Drawing.Point(138, 210);
            this.SinH.Name = "SinH";
            this.SinH.Size = new System.Drawing.Size(49, 48);
            this.SinH.TabIndex = 29;
            this.SinH.Text = "sh";
            this.SinH.UseVisualStyleBackColor = true;
            this.SinH.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CosH
            // 
            this.CosH.Location = new System.Drawing.Point(204, 210);
            this.CosH.Name = "CosH";
            this.CosH.Size = new System.Drawing.Size(48, 48);
            this.CosH.TabIndex = 30;
            this.CosH.Text = "ch";
            this.CosH.UseVisualStyleBackColor = true;
            this.CosH.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NumberPow
            // 
            this.NumberPow.Location = new System.Drawing.Point(262, 210);
            this.NumberPow.Name = "NumberPow";
            this.NumberPow.Size = new System.Drawing.Size(47, 48);
            this.NumberPow.TabIndex = 31;
            this.NumberPow.Text = "x^y";
            this.NumberPow.UseVisualStyleBackColor = true;
            this.NumberPow.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberRoot
            // 
            this.NumberRoot.Location = new System.Drawing.Point(315, 210);
            this.NumberRoot.Name = "NumberRoot";
            this.NumberRoot.Size = new System.Drawing.Size(48, 48);
            this.NumberRoot.TabIndex = 32;
            this.NumberRoot.Text = "x^(1/y)";
            this.NumberRoot.UseVisualStyleBackColor = true;
            this.NumberRoot.Click += new System.EventHandler(this.button1_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(369, 210);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(48, 48);
            this.Max.TabIndex = 33;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 376);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.NumberRoot);
            this.Controls.Add(this.NumberPow);
            this.Controls.Add(this.CosH);
            this.Controls.Add(this.SinH);
            this.Controls.Add(this.TanH);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.LogE);
            this.Controls.Add(this.Stepen);
            this.Controls.Add(this.ArcSin);
            this.Controls.Add(this.MultiplicationOnFive);
            this.Controls.Add(this.Radical);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.InverseNumber);
            this.Controls.Add(this.Arccosine);
            this.Controls.Add(this.Arctangent);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Cosine);
            this.Controls.Add(this.Tangent);
            this.Controls.Add(this.Cotangent);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Squaring);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.Logarithm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Squaring;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Logarithm;
        private System.Windows.Forms.Button MultiplicationOnFive;
        private System.Windows.Forms.Button Radical;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button InverseNumber;
        private System.Windows.Forms.Button Arccosine;
        private System.Windows.Forms.Button Arctangent;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Cosine;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button Cotangent;
        private System.Windows.Forms.Button ArcSin;
        private System.Windows.Forms.Button Stepen;
        private System.Windows.Forms.Button LogE;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button TanH;
        private System.Windows.Forms.Button SinH;
        private System.Windows.Forms.Button CosH;
        private System.Windows.Forms.Button NumberPow;
        private System.Windows.Forms.Button NumberRoot;
        private System.Windows.Forms.Button Max;
    }
}

