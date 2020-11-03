namespace Ex10
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
            this.xPathQ_10_a = new System.Windows.Forms.Button();
            this.openXMLFileButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.xPathQ_10_b = new System.Windows.Forms.Button();
            this.xPathQ_10_c = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.xPathQResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xPathQ_10_a
            // 
            this.xPathQ_10_a.Location = new System.Drawing.Point(25, 25);
            this.xPathQ_10_a.Name = "xPathQ_10_a";
            this.xPathQ_10_a.Size = new System.Drawing.Size(260, 23);
            this.xPathQ_10_a.TabIndex = 0;
            this.xPathQ_10_a.Text = "Return the Tiltles of Lessons Taught on Mondays";
            this.xPathQ_10_a.UseVisualStyleBackColor = true;
            this.xPathQ_10_a.Click += new System.EventHandler(this.xPathQ_10_a_Click);
            // 
            // openXMLFileButton
            // 
            this.openXMLFileButton.Location = new System.Drawing.Point(25, 116);
            this.openXMLFileButton.Name = "openXMLFileButton";
            this.openXMLFileButton.Size = new System.Drawing.Size(108, 23);
            this.openXMLFileButton.TabIndex = 1;
            this.openXMLFileButton.Text = "Open XML File";
            this.openXMLFileButton.UseVisualStyleBackColor = true;
            this.openXMLFileButton.Click += new System.EventHandler(this.openXMLFileButton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(25, 303);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(70, 13);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "File Opened: ";
            // 
            // xPathQ_10_b
            // 
            this.xPathQ_10_b.Location = new System.Drawing.Point(25, 54);
            this.xPathQ_10_b.Name = "xPathQ_10_b";
            this.xPathQ_10_b.Size = new System.Drawing.Size(260, 23);
            this.xPathQ_10_b.TabIndex = 3;
            this.xPathQ_10_b.Text = "Return the Titles of Lessons taught at classroom BA";
            this.xPathQ_10_b.UseVisualStyleBackColor = true;
            this.xPathQ_10_b.Click += new System.EventHandler(this.xPathQ_10_b_Click);
            // 
            // xPathQ_10_c
            // 
            this.xPathQ_10_c.Location = new System.Drawing.Point(25, 83);
            this.xPathQ_10_c.Name = "xPathQ_10_c";
            this.xPathQ_10_c.Size = new System.Drawing.Size(304, 23);
            this.xPathQ_10_c.TabIndex = 4;
            this.xPathQ_10_c.Text = "Return the Lecture (nodes) at which Hatzilygeroudis teaches";
            this.xPathQ_10_c.UseVisualStyleBackColor = true;
            this.xPathQ_10_c.Click += new System.EventHandler(this.xPathQ_10_c_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "XPath Query Result";
            // 
            // xPathQResultsLabel
            // 
            this.xPathQResultsLabel.AutoSize = true;
            this.xPathQResultsLabel.Location = new System.Drawing.Point(406, 42);
            this.xPathQResultsLabel.Name = "xPathQResultsLabel";
            this.xPathQResultsLabel.Size = new System.Drawing.Size(35, 13);
            this.xPathQResultsLabel.TabIndex = 6;
            this.xPathQResultsLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xPathQResultsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xPathQ_10_c);
            this.Controls.Add(this.xPathQ_10_b);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.openXMLFileButton);
            this.Controls.Add(this.xPathQ_10_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xPathQ_10_a;
        private System.Windows.Forms.Button openXMLFileButton;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Button xPathQ_10_b;
        private System.Windows.Forms.Button xPathQ_10_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xPathQResultsLabel;
    }
}

