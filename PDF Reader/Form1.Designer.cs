namespace PDF_Reader
{
    partial class Form1
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
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Btn_ExportFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Location = new System.Drawing.Point(12, 12);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_OpenFile.TabIndex = 0;
            this.Btn_OpenFile.Text = "Open ";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Btn_ExportFile
            // 
            this.Btn_ExportFile.Location = new System.Drawing.Point(93, 12);
            this.Btn_ExportFile.Name = "Btn_ExportFile";
            this.Btn_ExportFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_ExportFile.TabIndex = 1;
            this.Btn_ExportFile.Text = "Export";
            this.Btn_ExportFile.UseVisualStyleBackColor = true;
            this.Btn_ExportFile.Click += new System.EventHandler(this.Btn_ExportFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 397);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_ExportFile);
            this.Controls.Add(this.Btn_OpenFile);
            this.Name = "Form1";
            this.Text = "PDF Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.Button Btn_ExportFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

