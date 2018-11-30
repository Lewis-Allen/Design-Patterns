namespace DesignPatterns
{
    partial class DesignPatternsForm
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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Decorator Pattern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DecoratorPatternBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ObserverPatternBtn);
            this.Controls.Add(this.AdapterPatternBtn);
            this.Name = "Form1";
            this.Text = "Design Patterns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdapterPatternBtn;
        private System.Windows.Forms.Button ObserverPatternBtn;
        private System.Windows.Forms.Button button1;
    }
}

