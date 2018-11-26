namespace DesignPatterns
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
            this.AdapterPatternBtn = new System.Windows.Forms.Button();
            this.ObserverPatternBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdapterPatternBtn
            // 
            this.AdapterPatternBtn.Location = new System.Drawing.Point(12, 12);
            this.AdapterPatternBtn.Name = "AdapterPatternBtn";
            this.AdapterPatternBtn.Size = new System.Drawing.Size(128, 23);
            this.AdapterPatternBtn.TabIndex = 0;
            this.AdapterPatternBtn.Text = "Adapter Pattern";
            this.AdapterPatternBtn.UseVisualStyleBackColor = true;
            this.AdapterPatternBtn.Click += new System.EventHandler(this.AdapterPatternBtn_Click);
            // 
            // ObserverPatternBtn
            // 
            this.ObserverPatternBtn.Location = new System.Drawing.Point(12, 41);
            this.ObserverPatternBtn.Name = "ObserverPatternBtn";
            this.ObserverPatternBtn.Size = new System.Drawing.Size(128, 23);
            this.ObserverPatternBtn.TabIndex = 1;
            this.ObserverPatternBtn.Text = "Observer Pattern";
            this.ObserverPatternBtn.UseVisualStyleBackColor = true;
            this.ObserverPatternBtn.Click += new System.EventHandler(this.ObserverPatternBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ObserverPatternBtn);
            this.Controls.Add(this.AdapterPatternBtn);
            this.Name = "Form1";
            this.Text = "Design Patterns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdapterPatternBtn;
        private System.Windows.Forms.Button ObserverPatternBtn;
    }
}

