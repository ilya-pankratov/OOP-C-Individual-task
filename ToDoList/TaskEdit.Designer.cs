namespace Task_manager_v2
{
    partial class TaskEdit
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 301);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 189);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 86);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 120);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 284);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 5;
            label2.Text = "Исполнитель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 171);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 6;
            label3.Text = "Описание задачи";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(328, 354);
            button1.Name = "button1";
            button1.Size = new Size(127, 37);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(328, 354);
            button2.Name = "button2";
            button2.Size = new Size(127, 37);
            button2.TabIndex = 9;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(257, 58);
            label4.Name = "label4";
            label4.Size = new Size(269, 39);
            label4.TabIndex = 10;
            label4.Text = "Создание новой задачи";
            // 
            // TaskEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TaskEdit";
            Text = "ToDoList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}