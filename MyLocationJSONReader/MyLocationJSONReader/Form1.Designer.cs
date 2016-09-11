namespace MyLocationJSONReader
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
            this.JSONrtxt = new System.Windows.Forms.RichTextBox();
            this.Readbtn = new System.Windows.Forms.Button();
            this.FormatWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // JSONrtxt
            // 
            this.JSONrtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JSONrtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSONrtxt.Location = new System.Drawing.Point(12, 12);
            this.JSONrtxt.Name = "JSONrtxt";
            this.JSONrtxt.Size = new System.Drawing.Size(556, 365);
            this.JSONrtxt.TabIndex = 0;
            this.JSONrtxt.Text = "";
            this.JSONrtxt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Readbtn
            // 
            this.Readbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Readbtn.Location = new System.Drawing.Point(12, 383);
            this.Readbtn.Name = "Readbtn";
            this.Readbtn.Size = new System.Drawing.Size(159, 23);
            this.Readbtn.TabIndex = 1;
            this.Readbtn.Text = "Read JSON";
            this.Readbtn.UseVisualStyleBackColor = true;
            this.Readbtn.Click += new System.EventHandler(this.Readbtn_Click);
            // 
            // FormatWorker
            // 
            this.FormatWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FormatWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 416);
            this.Controls.Add(this.Readbtn);
            this.Controls.Add(this.JSONrtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox JSONrtxt;
        private System.Windows.Forms.Button Readbtn;
        private System.ComponentModel.BackgroundWorker FormatWorker;
    }
}

