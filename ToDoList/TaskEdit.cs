using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_manager_v2
{
    public partial class TaskEdit : Form
    {
        private string _username;
        private string _status;
        private string _name;
        private string _artist;
        private string _description;
        private bool _isEditMode;
        private string _originalTaskName;


        public TaskEdit(string username, string status, string name, string artist, string description, string originalTaskName)
        {
            InitializeComponent();
            _username = username;
            _status = status;
            _name = name;
            _artist = artist;
            _description = description;
            textBox1.Text = _name;
            textBox2.Text = _artist;
            textBox3.Text = _description;
            _originalTaskName = originalTaskName;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string taskName = textBox1.Text;
            string taskArtist = textBox2.Text;
            string taskDescription = textBox3.Text;
            if (taskName.Length == 0 || taskArtist.Length == 0 || taskDescription.Length == 0)
            {
                MessageBox.Show("Не все поля запонены");
                return;
            }
            string filePath = _username + "_tasks.txt";
            File.AppendAllText(filePath, "to_do" + ";" + taskName + ";" + taskArtist + ";" + taskDescription + Environment.NewLine);
            MessageBox.Show("Задача успешно создана");
            Close();

        }

        public bool IsEditMode
        {
            get { return _isEditMode; }
            set
            {
                _isEditMode = value;
                button1.Visible = !_isEditMode;
                button2.Visible = _isEditMode;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(_originalTaskName);
            string filePath = _username + "_tasks.txt";
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(';');
                if (parts.Length != 4)
                {
                    continue;
                }

                if (parts[1] == _originalTaskName)
                {
                    string status = parts[0];
                    string name = textBox1.Text;
                    string artist = textBox2.Text;
                    string description = textBox3.Text;

                    string updatedLine = status + ";" + name + ";" + artist + ";" + description;
                    lines[i] = updatedLine;
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);
            Close();

        }
    }

}
