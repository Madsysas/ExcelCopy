using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExcelCopy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label2.MaximumSize = new Size(400, 0);
            label2.AutoSize = true;
            label3.AutoSize = true;
        }

        private void Pasirink_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false; openFileDialog1.Filter = "All Files (*.*)|*.*";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var File_name = System.IO.Path.GetFileName(openFileDialog1.FileName);
                var DirectoryPath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                string NewFileName = "W"+Nuo_sav_textbox.Text + " " + File_name;
                label1.Text = File_name;
                label2.Text = DirectoryPath;
           
                //konvertuojam textboxu inputis i int
                var x = int.Parse(Nuo_sav_textbox.Text);
                var y = int.Parse(Iki_sav_textbox.Text);
            
                while (x < y+1)
                {
                    listBox1.Items.Add("W "+x+ " "+ File_name);
                    x++;
                }
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Nuo_sav_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Leidzia tik skaicius
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Iki_sav_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Leidzia tik skaicius
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Copy_button_Click(object sender, EventArgs e)
        {
            var a = label2.Text + @"\" + label1.Text;
            label3.Text = a;
            foreach (var item in listBox1.Items)
            {
               //System.IO.File.Copy(label2.Text + @"\" + label1.Text, label2.Text + item.ToString());
               label3.Text += item.ToString();
            }
        }
    }
}
