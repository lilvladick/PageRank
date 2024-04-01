namespace PageRankForm
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            richTextBox5 = new RichTextBox();
            label5 = new Label();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            richTextBox6 = new RichTextBox();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(48, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(209, 130);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 196);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Генерация веб-графа";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(48, 24);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите матрицу смежности";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(richTextBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(richTextBox4);
            groupBox2.Controls.Add(richTextBox3);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(366, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 196);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Настройки алгоритма";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(282, 147);
            button2.Name = "button2";
            button2.Size = new Size(34, 31);
            button2.TabIndex = 9;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(115, 139);
            button1.Name = "button1";
            button1.Size = new Size(134, 51);
            button1.TabIndex = 8;
            button1.Text = "Получить page rank";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(240, 104);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(76, 20);
            richTextBox5.TabIndex = 7;
            richTextBox5.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(50, 103);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 6;
            label5.Text = "Размерность матрицы";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(240, 78);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(76, 20);
            richTextBox4.TabIndex = 5;
            richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(240, 52);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(76, 20);
            richTextBox3.TabIndex = 4;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(240, 25);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(76, 21);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(50, 77);
            label4.Name = "label4";
            label4.Size = new Size(159, 21);
            label4.TabIndex = 2;
            label4.Text = "Количесво итераций";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(50, 51);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 1;
            label3.Text = "Точность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(50, 24);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 0;
            label2.Text = "Коэффициент затухания";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(173, 9);
            label6.Name = "label6";
            label6.Size = new Size(414, 32);
            label6.TabIndex = 3;
            label6.Text = "Алгоритм ранжирования PageRank";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(212, 255);
            label7.Name = "label7";
            label7.Size = new Size(335, 32);
            label7.TabIndex = 4;
            label7.Text = "Результат работы алгоритма";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(173, 290);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.ReadOnly = true;
            richTextBox6.Size = new Size(414, 228);
            richTextBox6.TabIndex = 5;
            richTextBox6.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 530);
            Controls.Add(richTextBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private Button button1;
        private RichTextBox richTextBox5;
        private Label label5;
        private Button button2;
        private Label label6;
        private Label label7;
        private RichTextBox richTextBox6;
        private ToolTip toolTip1;
    }
}
