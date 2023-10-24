namespace ExcelCopy
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
            this.Nuo_sav_textbox = new System.Windows.Forms.TextBox();
            this.Iki_sav_textbox = new System.Windows.Forms.TextBox();
            this.Nuo_sav_label = new System.Windows.Forms.Label();
            this.Iki_sav_label = new System.Windows.Forms.Label();
            this.Pasirink_file_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Copy_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Listbox1_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nuo_sav_textbox
            // 
            this.Nuo_sav_textbox.Location = new System.Drawing.Point(168, 19);
            this.Nuo_sav_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nuo_sav_textbox.Name = "Nuo_sav_textbox";
            this.Nuo_sav_textbox.Size = new System.Drawing.Size(161, 26);
            this.Nuo_sav_textbox.TabIndex = 1;
            this.Nuo_sav_textbox.TextChanged += new System.EventHandler(this.Nuo_sav_textbox_TextChanged);
            this.Nuo_sav_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nuo_sav_textbox_KeyPress);
            // 
            // Iki_sav_textbox
            // 
            this.Iki_sav_textbox.Location = new System.Drawing.Point(168, 55);
            this.Iki_sav_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Iki_sav_textbox.Name = "Iki_sav_textbox";
            this.Iki_sav_textbox.Size = new System.Drawing.Size(161, 26);
            this.Iki_sav_textbox.TabIndex = 2;
            this.Iki_sav_textbox.TextChanged += new System.EventHandler(this.Iki_sav_textbox_TextChanged);
            this.Iki_sav_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Iki_sav_textbox_KeyPress);
            // 
            // Nuo_sav_label
            // 
            this.Nuo_sav_label.AutoSize = true;
            this.Nuo_sav_label.Location = new System.Drawing.Point(36, 22);
            this.Nuo_sav_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nuo_sav_label.Name = "Nuo_sav_label";
            this.Nuo_sav_label.Size = new System.Drawing.Size(124, 20);
            this.Nuo_sav_label.TabIndex = 0;
            this.Nuo_sav_label.Text = "Pradzios savaite";
            // 
            // Iki_sav_label
            // 
            this.Iki_sav_label.AutoSize = true;
            this.Iki_sav_label.Location = new System.Drawing.Point(36, 58);
            this.Iki_sav_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Iki_sav_label.Name = "Iki_sav_label";
            this.Iki_sav_label.Size = new System.Drawing.Size(129, 20);
            this.Iki_sav_label.TabIndex = 0;
            this.Iki_sav_label.Text = "Pabaigos savaite";
            // 
            // Pasirink_file_button
            // 
            this.Pasirink_file_button.Location = new System.Drawing.Point(166, 91);
            this.Pasirink_file_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pasirink_file_button.Name = "Pasirink_file_button";
            this.Pasirink_file_button.Size = new System.Drawing.Size(112, 35);
            this.Pasirink_file_button.TabIndex = 3;
            this.Pasirink_file_button.Text = "Pasirink faila";
            this.Pasirink_file_button.UseVisualStyleBackColor = true;
            this.Pasirink_file_button.Click += new System.EventHandler(this.Pasirink_file_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 754);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 783);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 596);
            this.listBox1.TabIndex = 7;
            // 
            // Copy_button
            // 
            this.Copy_button.Location = new System.Drawing.Point(145, 805);
            this.Copy_button.Name = "Copy_button";
            this.Copy_button.Size = new System.Drawing.Size(133, 54);
            this.Copy_button.TabIndex = 8;
            this.Copy_button.Text = "Kopijuoti!";
            this.Copy_button.UseVisualStyleBackColor = true;
            this.Copy_button.Click += new System.EventHandler(this.Copy_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 822);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // Listbox1_clear
            // 
            this.Listbox1_clear.Location = new System.Drawing.Point(291, 735);
            this.Listbox1_clear.Name = "Listbox1_clear";
            this.Listbox1_clear.Size = new System.Drawing.Size(135, 29);
            this.Listbox1_clear.TabIndex = 10;
            this.Listbox1_clear.Text = "Išvalyti sąrašą";
            this.Listbox1_clear.UseVisualStyleBackColor = true;
            this.Listbox1_clear.Click += new System.EventHandler(this.Listbox1_clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 888);
            this.Controls.Add(this.Listbox1_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Copy_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pasirink_file_button);
            this.Controls.Add(this.Iki_sav_label);
            this.Controls.Add(this.Nuo_sav_label);
            this.Controls.Add(this.Iki_sav_textbox);
            this.Controls.Add(this.Nuo_sav_textbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Failu kopijuoklis";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nuo_sav_textbox;
        private System.Windows.Forms.TextBox Iki_sav_textbox;
        private System.Windows.Forms.Label Nuo_sav_label;
        private System.Windows.Forms.Label Iki_sav_label;
        private System.Windows.Forms.Button Pasirink_file_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Copy_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Listbox1_clear;
    }
}