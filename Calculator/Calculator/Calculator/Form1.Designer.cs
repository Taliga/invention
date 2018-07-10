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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Logarithm = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.Squaring = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "first digit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "second digit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "answer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
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
            this.Module.Location = new System.Drawing.Point(204, 112);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(48, 42);
            this.Module.TabIndex = 13;
            this.Module.Text = "mod";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 376);
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
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
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
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Squaring;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Logarithm;
    }
}

