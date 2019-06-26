namespace Calculators
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Num1textBox1 = new System.Windows.Forms.TextBox();
            this.resultlabel1 = new System.Windows.Forms.Label();
            this.operationcomboBox1 = new System.Windows.Forms.ComboBox();
            this.num2textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Operation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Num1textBox1
            // 
            this.Num1textBox1.Location = new System.Drawing.Point(69, 62);
            this.Num1textBox1.Name = "Num1textBox1";
            this.Num1textBox1.Size = new System.Drawing.Size(100, 20);
            this.Num1textBox1.TabIndex = 1;
            this.Num1textBox1.TextChanged += new System.EventHandler(this.Num1textBox1_TextChanged);
            // 
            // resultlabel1
            // 
            this.resultlabel1.AutoSize = true;
            this.resultlabel1.Location = new System.Drawing.Point(340, 141);
            this.resultlabel1.Name = "resultlabel1";
            this.resultlabel1.Size = new System.Drawing.Size(0, 13);
            this.resultlabel1.TabIndex = 2;
            this.resultlabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // operationcomboBox1
            // 
            this.operationcomboBox1.FormattingEnabled = true;
            this.operationcomboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationcomboBox1.Location = new System.Drawing.Point(227, 61);
            this.operationcomboBox1.Name = "operationcomboBox1";
            this.operationcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.operationcomboBox1.TabIndex = 3;
            this.operationcomboBox1.SelectedIndexChanged += new System.EventHandler(this.operationcomboBox1_SelectedIndexChanged);
            // 
            // num2textBox2
            // 
            this.num2textBox2.Location = new System.Drawing.Point(404, 61);
            this.num2textBox2.Name = "num2textBox2";
            this.num2textBox2.Size = new System.Drawing.Size(100, 20);
            this.num2textBox2.TabIndex = 4;
            this.num2textBox2.TextChanged += new System.EventHandler(this.num2textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num2textBox2);
            this.Controls.Add(this.operationcomboBox1);
            this.Controls.Add(this.resultlabel1);
            this.Controls.Add(this.Num1textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Num1textBox1;
        private System.Windows.Forms.Label resultlabel1;
        private System.Windows.Forms.ComboBox operationcomboBox1;
        private System.Windows.Forms.TextBox num2textBox2;
    }
}

