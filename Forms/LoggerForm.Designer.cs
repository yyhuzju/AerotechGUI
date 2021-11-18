namespace GUI
{
    partial class LoggerForm
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
            this.txtFileContents = new System.Windows.Forms.TextBox();
            this.logWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.logWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileContents
            // 
            this.txtFileContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileContents.Location = new System.Drawing.Point(11, 11);
            this.txtFileContents.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileContents.Multiline = true;
            this.txtFileContents.Name = "txtFileContents";
            this.txtFileContents.ReadOnly = true;
            this.txtFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFileContents.Size = new System.Drawing.Size(290, 428);
            this.txtFileContents.TabIndex = 5;
            // 
            // logWatcher
            // 
            this.logWatcher.EnableRaisingEvents = true;
            this.logWatcher.SynchronizingObject = this;
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.txtFileContents);
            this.Name = "LoggerForm";
            this.Text = "LoggerForm";
            this.Load += new System.EventHandler(this.LoggerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileContents;
        private System.IO.FileSystemWatcher logWatcher;
    }
}