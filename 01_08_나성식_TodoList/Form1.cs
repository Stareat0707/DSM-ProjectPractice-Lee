using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트 파일|*.txt";
            openFileDialog.Title = "To Do List 열기";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                FileStream fs = (FileStream)openFileDialog.OpenFile();
                StreamReader streamReader = new StreamReader(fs);
                Work.Text = streamReader.ReadLine();
                Date.Text = streamReader.ReadLine();
                Important.Text = streamReader.ReadLine();
                Description.Text = streamReader.ReadLine();
                streamReader.Close();
                fs.Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "텍스트 파일|*.txt";
            saveFileDialog.Title = "To Do List 저장";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                StreamWriter streamWriter = new StreamWriter(fs);
                streamWriter.WriteLine(Work.Text);
                streamWriter.WriteLine(Date.Text);
                streamWriter.WriteLine(Important.Text);
                streamWriter.WriteLine(Description.Text);
                streamWriter.Close();
                fs.Close();

                Work.Text = "";
                Date.Text = "";
                Important.Text = "";
                Description.Text = "";
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}