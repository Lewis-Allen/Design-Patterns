namespace ObserverPattern
{
    partial class ObserverForm
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
            this.decTextBox = new System.Windows.Forms.TextBox();
            this.Increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.binTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.decimalAttachDetachBtn = new System.Windows.Forms.Button();
            this.binaryAttachDetachBtn = new System.Windows.Forms.Button();
            this.hexAttachDetachBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.decTextBox.Location = new System.Drawing.Point(12, 25);
            this.decTextBox.Name = "textBox1";
            this.decTextBox.Size = new System.Drawing.Size(100, 20);
            this.decTextBox.TabIndex = 0;
            // 
            // Increment
            // 
            this.Increment.Location = new System.Drawing.Point(269, 12);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(75, 23);
            this.Increment.TabIndex = 1;
            this.Increment.Text = "Increment";
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.Click += new System.EventHandler(this.Increment_Click);
            // 
            // Decrement
            // 
            this.Decrement.Location = new System.Drawing.Point(269, 41);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(75, 23);
            this.Decrement.TabIndex = 2;
            this.Decrement.Text = "Decrement";
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.Click += new System.EventHandler(this.Decrement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decimal observer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Binary observer";
            // 
            // textBox2
            // 
            this.binTextBox.Location = new System.Drawing.Point(12, 76);
            this.binTextBox.Name = "textBox2";
            this.binTextBox.Size = new System.Drawing.Size(100, 20);
            this.binTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hex observer";
            // 
            // textBox3
            // 
            this.hexTextBox.Location = new System.Drawing.Point(12, 132);
            this.hexTextBox.Name = "textBox3";
            this.hexTextBox.Size = new System.Drawing.Size(100, 20);
            this.hexTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.decimalAttachDetachBtn.Location = new System.Drawing.Point(118, 23);
            this.decimalAttachDetachBtn.Name = "button1";
            this.decimalAttachDetachBtn.Size = new System.Drawing.Size(75, 23);
            this.decimalAttachDetachBtn.TabIndex = 8;
            this.decimalAttachDetachBtn.Text = "Detach";
            this.decimalAttachDetachBtn.UseVisualStyleBackColor = true;
            this.decimalAttachDetachBtn.Click += new System.EventHandler(this.decimalObserverDetach_Click);
            // 
            // button2
            // 
            this.binaryAttachDetachBtn.Location = new System.Drawing.Point(118, 74);
            this.binaryAttachDetachBtn.Name = "button2";
            this.binaryAttachDetachBtn.Size = new System.Drawing.Size(75, 23);
            this.binaryAttachDetachBtn.TabIndex = 9;
            this.binaryAttachDetachBtn.Text = "Detach";
            this.binaryAttachDetachBtn.UseVisualStyleBackColor = true;
            this.binaryAttachDetachBtn.Click += new System.EventHandler(this.binaryObserverDetach_Click);
            // 
            // button3
            // 
            this.hexAttachDetachBtn.Location = new System.Drawing.Point(118, 130);
            this.hexAttachDetachBtn.Name = "button3";
            this.hexAttachDetachBtn.Size = new System.Drawing.Size(75, 23);
            this.hexAttachDetachBtn.TabIndex = 10;
            this.hexAttachDetachBtn.Text = "Detach";
            this.hexAttachDetachBtn.UseVisualStyleBackColor = true;
            this.hexAttachDetachBtn.Click += new System.EventHandler(this.hexObserverDetach_Click);
            // 
            // ObserverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 170);
            this.Controls.Add(this.hexAttachDetachBtn);
            this.Controls.Add(this.binaryAttachDetachBtn);
            this.Controls.Add(this.decimalAttachDetachBtn);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.binTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.decTextBox);
            this.Name = "ObserverForm";
            this.Text = "Observer Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox decTextBox;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox binTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.Button decimalAttachDetachBtn;
        private System.Windows.Forms.Button binaryAttachDetachBtn;
        private System.Windows.Forms.Button hexAttachDetachBtn;
    }
}

