namespace WinFormsApp5Calculate
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(59, 19);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 0;
            label1.Text = "Number1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(59, 264);
            label2.Name = "label2";
            label2.Size = new Size(141, 38);
            label2.TabIndex = 1;
            label2.Text = "Number2";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            textBox1.Location = new Point(59, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 43);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            textBox2.Location = new Point(59, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 43);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button1.Location = new Point(124, 441);
            button1.Name = "button1";
            button1.Size = new Size(228, 59);
            button1.TabIndex = 4;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(196, 375);
            label3.Name = "label3";
            label3.Size = new Size(97, 38);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button2.Location = new Point(69, 126);
            button2.Name = "button2";
            button2.Size = new Size(64, 63);
            button2.TabIndex = 6;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button3.Location = new Point(140, 126);
            button3.Name = "button3";
            button3.Size = new Size(60, 63);
            button3.TabIndex = 7;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button4.Location = new Point(203, 126);
            button4.Name = "button4";
            button4.Size = new Size(66, 63);
            button4.TabIndex = 8;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button5.Location = new Point(275, 126);
            button5.Name = "button5";
            button5.Size = new Size(67, 63);
            button5.TabIndex = 9;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            textBox3.Location = new Point(144, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 43);
            textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 551);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox3;
    }
}
