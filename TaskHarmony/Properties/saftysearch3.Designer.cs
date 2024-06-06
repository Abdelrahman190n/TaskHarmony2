namespace TaskHarmony.Properties
{
    partial class saftysearch3
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
            this.button1 = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.Engineerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbsearch4 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // done
            // 
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(153, 126);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(103, 41);
            this.done.TabIndex = 27;
            this.done.Text = "done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // Engineerbutton
            // 
            this.Engineerbutton.Location = new System.Drawing.Point(-31, 219);
            this.Engineerbutton.Name = "Engineerbutton";
            this.Engineerbutton.Size = new System.Drawing.Size(477, 59);
            this.Engineerbutton.TabIndex = 26;
            this.Engineerbutton.Text = "Supervisor";
            this.Engineerbutton.UseVisualStyleBackColor = true;
            this.Engineerbutton.Click += new System.EventHandler(this.Engineerbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search";
            // 
            // cbsearch4
            // 
            this.cbsearch4.FormattingEnabled = true;
            this.cbsearch4.Location = new System.Drawing.Point(106, 64);
            this.cbsearch4.Name = "cbsearch4";
            this.cbsearch4.Size = new System.Drawing.Size(248, 28);
            this.cbsearch4.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-29, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(477, 59);
            this.button2.TabIndex = 29;
            this.button2.Text = "Worker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saftysearch3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 701);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.done);
            this.Controls.Add(this.Engineerbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbsearch4);
            this.Name = "saftysearch3";
            this.Text = "saftysearch3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button Engineerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbsearch4;
        private System.Windows.Forms.Button button2;
    }
}