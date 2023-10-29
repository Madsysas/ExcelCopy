using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace ExcelCopy
{
    public partial class MainForm : Form
    {
        string File_name;
        string DirectoryPath;
        public HashSet<string> Failu_pavadinimai = new HashSet<string>();

        public MainForm()
        {
            InitializeComponent();
        }
        public void Input_check()
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
        private void Nuo_sav_textbox_TextChanged(object sender, EventArgs e) => Input_check();
        private void Iki_sav_textbox_TextChanged(object sender, EventArgs e) => Input_check();
        private void Pasirink_file_button_Click(object sender, EventArgs e) => Surinkimas();
        private void Copy_button_Click(object sender, EventArgs e) => Kopijuoti();


        private void MainForm_Load(object sender, EventArgs e)
        {
            Pasirink_file_button.Enabled = false;
            Copy_button.Enabled = false;
            Savaite();
        }
        private void Isvalyti()
        {
            Failu_sarasas_lb.Items.Clear();
            File_name = "";
            DirectoryPath = "";
            Failu_pavadinimai.Clear();
            Copy_button.Enabled = false;
            Listbox_clear_btn.Enabled = false;
            Delete_selection_btn.Enabled = false;
        }
        private void Listbox_clear_Click(object sender, EventArgs e)
        {
            Failu_sarasas_lb.Items.Clear();
            File_name = "";
            DirectoryPath = "";
            Failu_pavadinimai.Clear();
            Copy_button.Enabled = false;
            Delete_selection_btn.Enabled = false;
        }
        private void Surinkimas()
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter = "All Files (*.*)|*.*";
            opendialog.FilterIndex = 1;
            opendialog.Multiselect = true;

            var x = int.Parse(Nuo_sav_textbox.Text);
            var y = int.Parse(Iki_sav_textbox.Text);
            if (x > y)
            {
                MessageBox.Show("Pražios savaitė didesnė už pabaigos", "Klaida!");
                Nuo_sav_textbox.Text = "";
                Iki_sav_textbox.Text = "";
            }
            else
                if (opendialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryPath = System.IO.Path.GetDirectoryName(opendialog.FileName);

                foreach (String file in opendialog.FileNames)
                {
                    File_name = System.IO.Path.GetFileName(file);
                    Failu_pavadinimai.Add(File_name);
                }
                foreach (string p in Failu_pavadinimai)
                {
                    if (!Failu_sarasas_lb.Items.Contains(p))
                        Failu_sarasas_lb.Items.Add(p);
                }
                Copy_button.Enabled = true;
                Delete_selection_btn.Enabled = true;
            }
            else
            {
                return;
            }
        }
        private void Kopijuoti()
        {
            for (int i = 0; i <= Failu_sarasas_lb.Items.Count - 1; i++)
            {
                var k = int.Parse(Nuo_sav_textbox.Text);
                var l = int.Parse(Iki_sav_textbox.Text);
                do
                {
                    string curItem = Failu_sarasas_lb.Items[i].ToString();
                    var backslash_W = @"\W";
                    string tikslas = $"{DirectoryPath}{backslash_W}{k} {curItem}";
                    System.IO.File.Copy(DirectoryPath + @"\" + curItem, tikslas, true);
                    k++;
                } while (k < l + 1);
            }
            MessageBox.Show("BAIGTA! failai nukopijuoti: " + DirectoryPath, "");
            Isvalyti();
        }

        private void Delete_selection_btn_Click(object sender, EventArgs e)
        {
            Failu_sarasas_lb.Items.RemoveAt(Failu_sarasas_lb.SelectedIndex);
            Failu_pavadinimai.Remove(Failu_sarasas_lb.GetItemText(Failu_sarasas_lb.SelectedItem));
            if (Failu_sarasas_lb.Items.Count == 0)
                Delete_selection_btn.Enabled = false;
        }
        private void Savaite()
        {
            DateTime currentDateTime = DateTime.Now;
            Calendar cal = new CultureInfo("en-EU").Calendar;
            int week = cal.GetWeekOfYear(currentDateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            Nuo_sav_textbox.Text = week.ToString();
            Iki_sav_textbox.Text = (week + 1).ToString();
        }
    }
}