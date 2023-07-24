namespace TaksiServis.KorisnickiInterfejs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtRegistracija = new TextBox();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            txtFilterBox = new TextBox();
            label5 = new Label();
            cbxFilter = new ComboBox();
            btnFiltriraj = new Button();
            ((System.ComponentModel.ISupportInitialize)TableView).BeginInit();
            SuspendLayout();
            // 
            // TableView
            // 
            TableView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableView.Location = new Point(620, 9);
            TableView.Name = "TableView";
            TableView.RowTemplate.Height = 25;
            TableView.Size = new Size(715, 562);
            TableView.TabIndex = 0;
            TableView.CellContentClick += TableView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 36);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 81);
            label2.Name = "label2";
            label2.Size = new Size(141, 36);
            label2.TabIndex = 2;
            label2.Text = "MARKA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 132);
            label3.Name = "label3";
            label3.Size = new Size(136, 36);
            label3.TabIndex = 3;
            label3.Text = "MODEL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 181);
            label4.Name = "label4";
            label4.Size = new Size(252, 36);
            label4.TabIndex = 4;
            label4.Text = "REGISTRACIJA";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(338, 29);
            txtID.Name = "txtID";
            txtID.Size = new Size(276, 34);
            txtID.TabIndex = 5;
            // 
            // txtMarka
            // 
            txtMarka.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarka.Location = new Point(338, 81);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(276, 34);
            txtMarka.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtModel.Location = new Point(338, 132);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(276, 34);
            txtModel.TabIndex = 7;
            // 
            // txtRegistracija
            // 
            txtRegistracija.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegistracija.Location = new Point(338, 181);
            txtRegistracija.Name = "txtRegistracija";
            txtRegistracija.Size = new Size(276, 34);
            txtRegistracija.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDodaj.Location = new Point(12, 245);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(197, 49);
            btnDodaj.TabIndex = 9;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIzmeni.Location = new Point(215, 245);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(197, 49);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "IZMENI";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnObrisi.Location = new Point(417, 245);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(197, 49);
            btnObrisi.TabIndex = 11;
            btnObrisi.Text = "OBRISI";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // txtFilterBox
            // 
            txtFilterBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilterBox.Location = new Point(338, 405);
            txtFilterBox.Name = "txtFilterBox";
            txtFilterBox.Size = new Size(276, 34);
            txtFilterBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 405);
            label5.Name = "label5";
            label5.Size = new Size(225, 36);
            label5.TabIndex = 13;
            label5.Text = "FILTRIRANJE";
            // 
            // cbxFilter
            // 
            cbxFilter.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbxFilter.FormattingEnabled = true;
            cbxFilter.Items.AddRange(new object[] { "Marka", "Registracija" });
            cbxFilter.Location = new Point(338, 459);
            cbxFilter.Name = "cbxFilter";
            cbxFilter.Size = new Size(273, 32);
            cbxFilter.TabIndex = 14;
            // 
            // btnFiltriraj
            // 
            btnFiltriraj.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltriraj.Location = new Point(417, 509);
            btnFiltriraj.Name = "btnFiltriraj";
            btnFiltriraj.Size = new Size(197, 49);
            btnFiltriraj.TabIndex = 15;
            btnFiltriraj.Text = "FILTRIRAJ";
            btnFiltriraj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 581);
            Controls.Add(btnFiltriraj);
            Controls.Add(cbxFilter);
            Controls.Add(label5);
            Controls.Add(txtFilterBox);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(txtRegistracija);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TableView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TableView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TableView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtRegistracija;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private TextBox txtFilterBox;
        private Label label5;
        private ComboBox cbxFilter;
        private Button btnFiltriraj;
    }
}