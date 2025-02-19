namespace CalcAppFinal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 70);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMod.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonMod.Location = new System.Drawing.Point(12, 120);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(76, 74);
            this.buttonMod.TabIndex = 1;
            this.buttonMod.Tag = "%";
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPower.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonPower.Location = new System.Drawing.Point(102, 120);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(76, 74);
            this.buttonPower.TabIndex = 2;
            this.buttonPower.Tag = "^";
            this.buttonPower.Text = "xʸ";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClear.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonClear.Location = new System.Drawing.Point(196, 120);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(76, 74);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Tag = "C";
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDivide.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonDivide.Location = new System.Drawing.Point(295, 120);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(76, 74);
            this.buttonDivide.TabIndex = 4;
            this.buttonDivide.Tag = "/";
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMultiply.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonMultiply.Location = new System.Drawing.Point(295, 208);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(76, 74);
            this.buttonMultiply.TabIndex = 8;
            this.buttonMultiply.Tag = "*";
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.OrangeRed;
            this.button9.Location = new System.Drawing.Point(196, 208);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 74);
            this.button9.TabIndex = 7;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Number_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.OrangeRed;
            this.button8.Location = new System.Drawing.Point(102, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 74);
            this.button8.TabIndex = 6;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Number_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.OrangeRed;
            this.button7.Location = new System.Drawing.Point(12, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 74);
            this.button7.TabIndex = 5;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Number_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonAdd.Location = new System.Drawing.Point(295, 385);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(76, 74);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Tag = "+";
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.OrangeRed;
            this.button3.Location = new System.Drawing.Point(196, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 74);
            this.button3.TabIndex = 15;
            this.button3.Tag = "3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Number_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(102, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 74);
            this.button2.TabIndex = 14;
            this.button2.Tag = "2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Number_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 74);
            this.button1.TabIndex = 13;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Number_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSubtract.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonSubtract.Location = new System.Drawing.Point(295, 297);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(76, 74);
            this.buttonSubtract.TabIndex = 12;
            this.buttonSubtract.Tag = "-";
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.OrangeRed;
            this.button6.Location = new System.Drawing.Point(196, 297);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 74);
            this.button6.TabIndex = 11;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Number_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.OrangeRed;
            this.button5.Location = new System.Drawing.Point(102, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 74);
            this.button5.TabIndex = 10;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Number_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.OrangeRed;
            this.button4.Location = new System.Drawing.Point(12, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 74);
            this.button4.TabIndex = 9;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Number_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.White;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEquals.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonEquals.Location = new System.Drawing.Point(295, 475);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(76, 74);
            this.buttonEquals.TabIndex = 20;
            this.buttonEquals.Tag = "=";
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDot.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonDot.Location = new System.Drawing.Point(196, 475);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(76, 74);
            this.buttonDot.TabIndex = 19;
            this.buttonDot.Tag = ".";
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button0.ForeColor = System.Drawing.Color.OrangeRed;
            this.button0.Location = new System.Drawing.Point(102, 475);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 74);
            this.button0.TabIndex = 18;
            this.button0.Tag = "0";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Number_Click);
            // 
            // buttonNegate
            // 
            this.buttonNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNegate.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonNegate.Location = new System.Drawing.Point(12, 475);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(76, 74);
            this.buttonNegate.TabIndex = 17;
            this.buttonNegate.Tag = "±";
            this.buttonNegate.Text = "±";
            this.buttonNegate.UseVisualStyleBackColor = true;
            this.buttonNegate.Click += new System.EventHandler(this.Negate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(382, 603);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonNegate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Operator_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonNegate;
    }
}

