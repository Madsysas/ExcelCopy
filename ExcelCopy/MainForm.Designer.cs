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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Pasirink_file_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Failu_sarasas_lb = new System.Windows.Forms.ListBox();
            this.Copy_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Delete_selection_btn = new System.Windows.Forms.Button();
            this.Listbox_clear_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Nuo_sav_textbox = new System.Windows.Forms.TextBox();
            this.Iki_sav_textbox = new System.Windows.Forms.TextBox();
            this.Nuo_sav_label = new System.Windows.Forms.Label();
            this.Iki_sav_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pasirink_file_button
            // 
            this.Pasirink_file_button.BackColor = System.Drawing.SystemColors.Info;
            this.Pasirink_file_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pasirink_file_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pasirink_file_button.Image = ((System.Drawing.Image)(resources.GetObject("Pasirink_file_button.Image")));
            this.Pasirink_file_button.Location = new System.Drawing.Point(0, 0);
            this.Pasirink_file_button.Margin = new System.Windows.Forms.Padding(0);
            this.Pasirink_file_button.Name = "Pasirink_file_button";
            this.Pasirink_file_button.Size = new System.Drawing.Size(484, 68);
            this.Pasirink_file_button.TabIndex = 3;
            this.Pasirink_file_button.Text = "Pasirink failą";
            this.Pasirink_file_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pasirink_file_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pasirink_file_button.UseVisualStyleBackColor = false;
            this.Pasirink_file_button.Click += new System.EventHandler(this.Pasirink_file_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Failu_sarasas_lb
            // 
            this.Failu_sarasas_lb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Failu_sarasas_lb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Failu_sarasas_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Failu_sarasas_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failu_sarasas_lb.FormattingEnabled = true;
            this.Failu_sarasas_lb.ItemHeight = 20;
            this.Failu_sarasas_lb.Location = new System.Drawing.Point(0, 0);
            this.Failu_sarasas_lb.Name = "Failu_sarasas_lb";
            this.Failu_sarasas_lb.Size = new System.Drawing.Size(484, 355);
            this.Failu_sarasas_lb.TabIndex = 7;
            this.Failu_sarasas_lb.Sorted = true;
            // 
            // Copy_button
            // 
            this.Copy_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Copy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_button.Image = ((System.Drawing.Image)(resources.GetObject("Copy_button.Image")));
            this.Copy_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Copy_button.Location = new System.Drawing.Point(0, 582);
            this.Copy_button.Name = "Copy_button";
            this.Copy_button.Size = new System.Drawing.Size(484, 79);
            this.Copy_button.TabIndex = 8;
            this.Copy_button.Text = "Kopijuoti!";
            this.Copy_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Copy_button.UseVisualStyleBackColor = true;
            this.Copy_button.Click += new System.EventHandler(this.Copy_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Delete_selection_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Listbox_clear_btn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 513);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.17241F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 69);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Delete_selection_btn
            // 
            this.Delete_selection_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_selection_btn.Enabled = false;
            this.Delete_selection_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_selection_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Delete_selection_btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_selection_btn.Image")));
            this.Delete_selection_btn.Location = new System.Drawing.Point(0, 0);
            this.Delete_selection_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Delete_selection_btn.Name = "Delete_selection_btn";
            this.Delete_selection_btn.Size = new System.Drawing.Size(242, 69);
            this.Delete_selection_btn.TabIndex = 11;
            this.Delete_selection_btn.Text = "Ištrinti pasirinkimą";
            this.Delete_selection_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete_selection_btn.UseVisualStyleBackColor = true;
            this.Delete_selection_btn.Click += new System.EventHandler(this.Delete_selection_btn_Click);
            // 
            // Listbox_clear_btn
            // 
            this.Listbox_clear_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Listbox_clear_btn.Font = new System.Drawing.Font("Luckiest Guy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listbox_clear_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Listbox_clear_btn.Image = ((System.Drawing.Image)(resources.GetObject("Listbox_clear_btn.Image")));
            this.Listbox_clear_btn.Location = new System.Drawing.Point(242, 0);
            this.Listbox_clear_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Listbox_clear_btn.Name = "Listbox_clear_btn";
            this.Listbox_clear_btn.Size = new System.Drawing.Size(242, 69);
            this.Listbox_clear_btn.TabIndex = 10;
            this.Listbox_clear_btn.Text = "Išvalyti sąrašą";
            this.Listbox_clear_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Listbox_clear_btn.UseVisualStyleBackColor = true;
            this.Listbox_clear_btn.Click += new System.EventHandler(this.Listbox_clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Failu_sarasas_lb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 355);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Pasirink_file_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 68);
            this.panel2.TabIndex = 15;
            // 
            // Nuo_sav_textbox
            // 
            this.Nuo_sav_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuo_sav_textbox.Location = new System.Drawing.Point(242, 71);
            this.Nuo_sav_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Nuo_sav_textbox.MaxLength = 2;
            this.Nuo_sav_textbox.Name = "Nuo_sav_textbox";
            this.Nuo_sav_textbox.Size = new System.Drawing.Size(233, 35);
            this.Nuo_sav_textbox.TabIndex = 1;
            this.Nuo_sav_textbox.TextChanged += new System.EventHandler(this.Nuo_sav_textbox_TextChanged);
            this.Nuo_sav_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nuo_sav_textbox_KeyPress);
            // 
            // Iki_sav_textbox
            // 
            this.Iki_sav_textbox.AccessibleName = "";
            this.Iki_sav_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iki_sav_textbox.Location = new System.Drawing.Point(242, 120);
            this.Iki_sav_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Iki_sav_textbox.MaxLength = 2;
            this.Iki_sav_textbox.Name = "Iki_sav_textbox";
            this.Iki_sav_textbox.Size = new System.Drawing.Size(233, 35);
            this.Iki_sav_textbox.TabIndex = 2;
            this.Iki_sav_textbox.TextChanged += new System.EventHandler(this.Iki_sav_textbox_TextChanged);
            this.Iki_sav_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Iki_sav_textbox_KeyPress);
            // 
            // Nuo_sav_label
            // 
            this.Nuo_sav_label.AutoSize = true;
            this.Nuo_sav_label.Location = new System.Drawing.Point(44, 81);
            this.Nuo_sav_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nuo_sav_label.Name = "Nuo_sav_label";
            this.Nuo_sav_label.Size = new System.Drawing.Size(124, 20);
            this.Nuo_sav_label.TabIndex = 0;
            this.Nuo_sav_label.Text = "Pradzios savaite";
            this.Nuo_sav_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Iki_sav_label
            // 
            this.Iki_sav_label.AutoSize = true;
            this.Iki_sav_label.Location = new System.Drawing.Point(39, 130);
            this.Iki_sav_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Iki_sav_label.Name = "Iki_sav_label";
            this.Iki_sav_label.Size = new System.Drawing.Size(129, 20);
            this.Iki_sav_label.TabIndex = 0;
            this.Iki_sav_label.Text = "Pabaigos savaite";
            this.Iki_sav_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.Nuo_sav_textbox);
            this.Controls.Add(this.Iki_sav_textbox);
            this.Controls.Add(this.Iki_sav_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Nuo_sav_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Copy_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "MainForm";
            this.Text = "Failu kopijuoklis";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Pasirink_file_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox Failu_sarasas_lb;
        private System.Windows.Forms.Button Copy_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Delete_selection_btn;
        private System.Windows.Forms.Button Listbox_clear_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Nuo_sav_textbox;
        private System.Windows.Forms.TextBox Iki_sav_textbox;
        private System.Windows.Forms.Label Nuo_sav_label;
        private System.Windows.Forms.Label Iki_sav_label;
    }
}