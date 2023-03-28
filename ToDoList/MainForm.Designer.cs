namespace Task_manager_v2
{
    partial class MainForm
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
            add_task = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            delete = new Button();
            label4 = new Label();
            change_status = new Button();
            SuspendLayout();
            // 
            // add_task
            // 
            add_task.BackColor = SystemColors.MenuHighlight;
            add_task.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            add_task.Location = new Point(49, 310);
            add_task.Name = "add_task";
            add_task.Size = new Size(134, 48);
            add_task.TabIndex = 0;
            add_task.Text = "Добавить новую задачу";
            add_task.UseVisualStyleBackColor = false;
            add_task.Click += add_task_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.BackColor = Color.FromArgb(255, 192, 192);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 121);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(197, 169);
            listBox1.TabIndex = 1;
            listBox1.DragDrop += listBox1_DragDrop;
            listBox1.DragEnter += listBox1_DragEnter;
            listBox1.MouseDown += listBox1_MouseDown;
            listBox1.MouseMove += listBox1_MouseMove;
            // 
            // listBox2
            // 
            listBox2.AllowDrop = true;
            listBox2.BackColor = Color.FromArgb(255, 224, 192);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(249, 121);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(197, 169);
            listBox2.TabIndex = 2;
            listBox2.DragDrop += listBox2_DragDrop;
            listBox2.DragEnter += listBox2_DragEnter;
            listBox2.MouseDown += listBox2_MouseDown;
            listBox2.MouseMove += listBox2_MouseMove;
            // 
            // listBox3
            // 
            listBox3.AllowDrop = true;
            listBox3.BackColor = Color.FromArgb(192, 255, 192);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(478, 121);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(197, 169);
            listBox3.TabIndex = 3;
            listBox3.DragDrop += listBox3_DragDrop;
            listBox3.DragEnter += listBox3_DragEnter;
            listBox3.MouseDown += listBox3_MouseDown;
            listBox3.MouseMove += listBox3_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 75);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 4;
            label1.Text = "Не начато";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(276, 75);
            label2.Name = "label2";
            label2.Size = new Size(139, 29);
            label2.TabIndex = 5;
            label2.Text = "В процессе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 128);
            label3.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(508, 75);
            label3.Name = "label3";
            label3.Size = new Size(138, 29);
            label3.TabIndex = 6;
            label3.Text = "Выполнено";
            // 
            // delete
            // 
            delete.BackColor = SystemColors.MenuHighlight;
            delete.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(508, 310);
            delete.Name = "delete";
            delete.Size = new Size(134, 48);
            delete.TabIndex = 7;
            delete.Text = "Удалить выполненую задачу";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(230, -1);
            label4.Name = "label4";
            label4.Size = new Size(244, 58);
            label4.TabIndex = 8;
            label4.Text = "Список задач";
            // 
            // change_status
            // 
            change_status.BackColor = SystemColors.MenuHighlight;
            change_status.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            change_status.Location = new Point(281, 310);
            change_status.Name = "change_status";
            change_status.Size = new Size(134, 48);
            change_status.TabIndex = 9;
            change_status.Text = "Изменить статус задачи";
            change_status.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 386);
            Controls.Add(change_status);
            Controls.Add(label4);
            Controls.Add(delete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(add_task);
            Name = "MainForm";
            Text = "ToDoList";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_task;
        public ListBox listBox1;
        public ListBox listBox2;
        public ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button delete;
        private Label label4;
        private Button change_status;
    }
}