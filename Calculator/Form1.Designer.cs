﻿namespace Calculator
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
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
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
            this.deleteAll.Location = new System.Drawing.Point(339, 33);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(55, 32);
            this.deleteAll.TabIndex = 8;
            this.deleteAll.Text = "C";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click_1);
            // 
            // deleteOne
            // 
            this.deleteOne.Location = new System.Drawing.Point(185, 33);
            this.deleteOne.Name = "deleteOne";
            this.deleteOne.Size = new System.Drawing.Size(113, 32);
            this.deleteOne.TabIndex = 7;
            this.deleteOne.Text = "Backspace";
            this.deleteOne.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(265, 265);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(55, 32);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click_1);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(204, 265);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(55, 32);
            this.three.TabIndex = 7;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click_1);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(143, 265);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(55, 32);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click_1);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(82, 265);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(55, 32);
            this.one.TabIndex = 9;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click_1);
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
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(265, 303);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 32);
            this.button11.TabIndex = 12;
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.multiplication_Click_1);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(204, 303);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 32);
            this.button12.TabIndex = 13;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.six_Click_1);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(143, 303);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 32);
            this.button13.TabIndex = 14;
            this.button13.Text = "5";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.five_Click_1);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(82, 303);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 32);
            this.button14.TabIndex = 15;
            this.button14.Text = "4";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.four_Click_1);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(401, 393);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 39);
            this.button15.TabIndex = 16;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Result_Click_1);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(265, 341);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 32);
            this.button16.TabIndex = 17;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.minus_Click_1);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(204, 341);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(55, 32);
            this.button17.TabIndex = 18;
            this.button17.Text = "9";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.nine_Click_1);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(143, 340);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(55, 32);
            this.button18.TabIndex = 19;
            this.button18.Text = "8";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.eight_Click_1);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(82, 340);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 32);
            this.button19.TabIndex = 20;
            this.button19.Text = "7";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.seven_Click_1);
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
            this.plus.Location = new System.Drawing.Point(265, 379);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(55, 32);
            this.plus.TabIndex = 22;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click_1);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(204, 380);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(55, 31);
            this.button22.TabIndex = 23;
            this.button22.Text = "mod";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(143, 379);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(55, 32);
            this.zero.TabIndex = 24;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click_1);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(82, 379);
            this.button24.Margin = new System.Windows.Forms.Padding(4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(55, 32);
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
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
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
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button24;
    }
}

