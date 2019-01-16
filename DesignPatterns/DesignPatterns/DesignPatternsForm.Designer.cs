﻿namespace DesignPatterns
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdapterPatternBtn
            // 
            this.AdapterPatternBtn.Location = new System.Drawing.Point(146, 25);
            this.AdapterPatternBtn.Name = "AdapterPatternBtn";
            this.AdapterPatternBtn.Size = new System.Drawing.Size(128, 23);
            this.AdapterPatternBtn.TabIndex = 0;
            this.AdapterPatternBtn.Text = "Adapter Pattern";
            this.AdapterPatternBtn.UseVisualStyleBackColor = true;
            this.AdapterPatternBtn.Click += new System.EventHandler(this.AdapterPatternBtn_Click);
            // 
            // ObserverPatternBtn
            // 
            this.ObserverPatternBtn.Location = new System.Drawing.Point(280, 25);
            this.ObserverPatternBtn.Name = "ObserverPatternBtn";
            this.ObserverPatternBtn.Size = new System.Drawing.Size(127, 23);
            this.ObserverPatternBtn.TabIndex = 1;
            this.ObserverPatternBtn.Text = "Observer Pattern";
            this.ObserverPatternBtn.UseVisualStyleBackColor = true;
            this.ObserverPatternBtn.Click += new System.EventHandler(this.ObserverPatternBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Decorator Pattern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DecoratorPatternBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Facade Pattern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FacadePatternBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Proxy Pattern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ProxyPatternBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Composite Pattern";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CompositePatternBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Singleton Pattern";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SingletonPatternBtn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(280, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Iterator Pattern";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.IteratorPatternBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(146, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Flyweight Pattern";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.FlyweightPatternBtn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(146, 141);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Bridge Pattern";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BridgePatternBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(280, 83);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(127, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Strategy Pattern";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.StrategyPatternBtn_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(280, 54);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(127, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Memento Pattern";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.MementoPatternBtn_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(280, 141);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(127, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "Command Pattern";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.CommandPatternBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Creational";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Structural";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Behavioural";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 54);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(128, 23);
            this.button12.TabIndex = 16;
            this.button12.Text = "Abstract Factory Pattern";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.AbstracFactoryPattern_Click);
            // 
            // DesignPatternsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 264);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ObserverPatternBtn);
            this.Controls.Add(this.AdapterPatternBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DesignPatternsForm";
            this.Text = "Design Patterns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdapterPatternBtn;
        private System.Windows.Forms.Button ObserverPatternBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button12;
    }
}

