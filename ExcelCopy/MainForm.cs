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
        }

        private void Pasirink_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true; openFileDialog1.Filter = "All Files (*.*)|*.*";
  
            //konvertuojam textboxu inputis i int
            var x = int.Parse(Nuo_sav_textbox.Text);
            var y = int.Parse(Iki_sav_textbox.Text);
            if (x > y)
            {
                MessageBox.Show("Pražios savaitė didesnė už pabaigos", "Klaida!");
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in openFileDialog1.FileNames)
                    {
                        var File_name = System.IO.Path.GetFileName(file);
                        var DirectoryPath = System.IO.Path.GetDirectoryName(file);
                        var DirectoryPathAndFileName = System.IO.Path.Combine(DirectoryPath, File_name);
                        label1.Text = File_name;
                        label2.Text = DirectoryPath;
                        label3.Text = DirectoryPathAndFileName;

                        while (x < y + 1)
                        {
                            listBox1.Items.Add(@"\W" + x + " " + File_name);
                            x++;
                        }
                    }
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
        private void Nuo_sav_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Iki_sav_textbox.Text.Trim() != "" && Nuo_sav_textbox.Text.Trim() != "")
            {
                Pasirink_file_button.Enabled = true;
            }
            else
            {
                Pasirink_file_button.Enabled = false;
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
        private void Iki_sav_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Iki_sav_textbox.Text.Trim()!="" && Nuo_sav_textbox.Text.Trim()!="")
            { 
                Pasirink_file_button.Enabled = true;
            }
            else
            {
                Pasirink_file_button.Enabled = false;
            }
        }

        private void Copy_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                object item = listBox1.Items[i];
                System.IO.File.Copy(label3.Text, label2.Text + item.ToString(), true);
            }
            listBox1.Items.Clear();
            MessageBox.Show("Failai nukopijuoti: " + label2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Pasirink_file_button.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void Listbox1_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
