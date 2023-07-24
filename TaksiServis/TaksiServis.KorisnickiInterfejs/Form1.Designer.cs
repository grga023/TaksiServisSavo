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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 581);
            Controls.Add(TableView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TableView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TableView;
    }
}