﻿namespace CashierApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 29);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 1;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(329, 9);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 2;
            label2.Text = "Discount (%):";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(329, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 29);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(329, 76);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 5;
            label4.Text = "Quantity:";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(79, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 29);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(426, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(78, 29);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(226, 108);
            button1.Name = "button1";
            button1.Size = new Size(97, 31);
            button1.TabIndex = 8;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(288, 151);
            label5.Name = "label5";
            label5.Size = new Size(35, 21);
            label5.TabIndex = 9;
            label5.Text = "0.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(131, 151);
            label6.Name = "label6";
            label6.Size = new Size(132, 21);
            label6.TabIndex = 9;
            label6.Text = "Total amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 204);
            label7.Name = "label7";
            label7.Size = new Size(166, 21);
            label7.TabIndex = 10;
            label7.Text = "Payment recieved:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(184, 201);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(183, 29);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.Beige;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(386, 200);
            button2.Name = "button2";
            button2.Size = new Size(103, 31);
            button2.TabIndex = 12;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(131, 255);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 13;
            label8.Text = "Change:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(288, 255);
            label9.Name = "label9";
            label9.Size = new Size(35, 21);
            label9.TabIndex = 14;
            label9.Text = "0.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 292);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Purchase Discounted Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Button button2;
        private Label label8;
        private Label label9;
    }
}