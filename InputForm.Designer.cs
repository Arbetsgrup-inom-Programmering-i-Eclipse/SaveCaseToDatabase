
namespace Form
{
    partial class InputForm
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
			this.PatientInfo = new System.Windows.Forms.Label();
			this.comboBox_Course = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox_Plan = new System.Windows.Forms.ComboBox();
			this.textBox_Kommentar = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox_Kategori = new System.Windows.Forms.ComboBox();
			this.button_Export = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox_SubKategori = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// PatientInfo
			// 
			this.PatientInfo.AutoSize = true;
			this.PatientInfo.Location = new System.Drawing.Point(24, 25);
			this.PatientInfo.Name = "PatientInfo";
			this.PatientInfo.Size = new System.Drawing.Size(58, 13);
			this.PatientInfo.TabIndex = 0;
			this.PatientInfo.Text = "PatientInfo";
			// 
			// comboBox_Course
			// 
			this.comboBox_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Course.FormattingEnabled = true;
			this.comboBox_Course.Location = new System.Drawing.Point(27, 83);
			this.comboBox_Course.Name = "comboBox_Course";
			this.comboBox_Course.Size = new System.Drawing.Size(121, 21);
			this.comboBox_Course.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Välj Course";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(201, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Välj Plan";
			// 
			// comboBox_Plan
			// 
			this.comboBox_Plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Plan.FormattingEnabled = true;
			this.comboBox_Plan.Location = new System.Drawing.Point(204, 83);
			this.comboBox_Plan.Name = "comboBox_Plan";
			this.comboBox_Plan.Size = new System.Drawing.Size(236, 21);
			this.comboBox_Plan.TabIndex = 3;
			// 
			// textBox_Kommentar
			// 
			this.textBox_Kommentar.Location = new System.Drawing.Point(27, 216);
			this.textBox_Kommentar.Name = "textBox_Kommentar";
			this.textBox_Kommentar.Size = new System.Drawing.Size(413, 20);
			this.textBox_Kommentar.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Skriv en kommentar om fallet";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Välj Kategori";
			// 
			// comboBox_Kategori
			// 
			this.comboBox_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Kategori.FormattingEnabled = true;
			this.comboBox_Kategori.Location = new System.Drawing.Point(27, 152);
			this.comboBox_Kategori.Name = "comboBox_Kategori";
			this.comboBox_Kategori.Size = new System.Drawing.Size(121, 21);
			this.comboBox_Kategori.TabIndex = 7;
			// 
			// button_Export
			// 
			this.button_Export.Location = new System.Drawing.Point(192, 266);
			this.button_Export.Name = "button_Export";
			this.button_Export.Size = new System.Drawing.Size(75, 23);
			this.button_Export.TabIndex = 9;
			this.button_Export.Text = "Export";
			this.button_Export.UseVisualStyleBackColor = true;
			this.button_Export.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(201, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Välj Sub-Kategori";
			// 
			// comboBox_SubKategori
			// 
			this.comboBox_SubKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_SubKategori.FormattingEnabled = true;
			this.comboBox_SubKategori.Location = new System.Drawing.Point(204, 152);
			this.comboBox_SubKategori.Name = "comboBox_SubKategori";
			this.comboBox_SubKategori.Size = new System.Drawing.Size(121, 21);
			this.comboBox_SubKategori.TabIndex = 10;
			// 
			// InputForm
			// 
			this.AcceptButton = this.button_Export;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 306);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox_SubKategori);
			this.Controls.Add(this.button_Export);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox_Kategori);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_Kommentar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox_Plan);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox_Course);
			this.Controls.Add(this.PatientInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "InputForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Spara fall till databas";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientInfo;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Plan;
        private System.Windows.Forms.TextBox textBox_Kommentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Kategori;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_SubKategori;
    }
}