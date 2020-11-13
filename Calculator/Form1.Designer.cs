namespace Calculator
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteAll = new System.Windows.Forms.Button();
            this.deleteOne = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteAll);
            this.groupBox1.Controls.Add(this.deleteOne);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(35, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(453, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(367, 23);
            this.deleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(73, 39);
            this.deleteAll.TabIndex = 8;
            this.deleteAll.Text = "C";
            this.deleteAll.UseVisualStyleBackColor = true;
            // 
            // deleteOne
            // 
            this.deleteOne.Location = new System.Drawing.Point(227, 23);
            this.deleteOne.Margin = new System.Windows.Forms.Padding(4);
            this.deleteOne.Name = "deleteOne";
            this.deleteOne.Size = new System.Drawing.Size(112, 39);
            this.deleteOne.TabIndex = 7;
            this.deleteOne.Text = "Backspace";
            this.deleteOne.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(279, 254);
            this.division.Margin = new System.Windows.Forms.Padding(4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(73, 39);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(197, 254);
            this.three.Margin = new System.Windows.Forms.Padding(4);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(73, 39);
            this.three.TabIndex = 7;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(116, 254);
            this.two.Margin = new System.Windows.Forms.Padding(4);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(73, 39);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(35, 254);
            this.one.Margin = new System.Windows.Forms.Padding(4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(73, 39);
            this.one.TabIndex = 9;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(401, 254);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 39);
            this.button9.TabIndex = 10;
            this.button9.Text = "MR";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(401, 300);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 39);
            this.button10.TabIndex = 11;
            this.button10.Text = "M+";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(279, 300);
            this.multiplication.Margin = new System.Windows.Forms.Padding(4);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(73, 39);
            this.multiplication.TabIndex = 12;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(197, 300);
            this.six.Margin = new System.Windows.Forms.Padding(4);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(73, 39);
            this.six.TabIndex = 13;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(116, 300);
            this.five.Margin = new System.Windows.Forms.Padding(4);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(73, 39);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(35, 300);
            this.four.Margin = new System.Windows.Forms.Padding(4);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(73, 39);
            this.four.TabIndex = 15;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(401, 394);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 39);
            this.button15.TabIndex = 16;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(279, 347);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(73, 39);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(197, 347);
            this.nine.Margin = new System.Windows.Forms.Padding(4);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(73, 39);
            this.nine.TabIndex = 18;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(116, 347);
            this.eight.Margin = new System.Windows.Forms.Padding(4);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(73, 39);
            this.eight.TabIndex = 19;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(35, 347);
            this.seven.Margin = new System.Windows.Forms.Padding(4);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(73, 39);
            this.seven.TabIndex = 20;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(401, 347);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(73, 39);
            this.button20.TabIndex = 21;
            this.button20.Text = "MC";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(279, 394);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(73, 39);
            this.plus.TabIndex = 22;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(197, 394);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(73, 39);
            this.button22.TabIndex = 23;
            this.button22.Text = "mod";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(116, 394);
            this.zero.Margin = new System.Windows.Forms.Padding(4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(73, 39);
            this.zero.TabIndex = 24;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(35, 394);
            this.button24.Margin = new System.Windows.Forms.Padding(4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(73, 39);
            this.button24.TabIndex = 25;
            this.button24.Text = "+/-";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 471);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.division);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button deleteOne;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button24;
    }
}

