namespace TaskHarmony.Properties
{
    partial class chatsearch
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
            this.cbsearch5 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // done
            // 
            this.done.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(148, 122);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(103, 41);
            this.done.TabIndex = 22;
            this.done.Text = "done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // Engineerbutton
            // 
            this.Engineerbutton.Location = new System.Drawing.Point(-36, 215);
            this.Engineerbutton.Name = "Engineerbutton";
            this.Engineerbutton.Size = new System.Drawing.Size(477, 59);
            this.Engineerbutton.TabIndex = 21;
            this.Engineerbutton.Text = "Supervisor";
            this.Engineerbutton.UseVisualStyleBackColor = true;
            this.Engineerbutton.Click += new System.EventHandler(this.Engineerbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search";
            // 
            // cbsearch5
            // 
            this.cbsearch5.FormattingEnabled = true;
            this.cbsearch5.Location = new System.Drawing.Point(101, 60);
            this.cbsearch5.Name = "cbsearch5";
            this.cbsearch5.Size = new System.Drawing.Size(248, 28);
            this.cbsearch5.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-29, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(477, 59);
            this.button2.TabIndex = 24;
            this.button2.Text = "Worker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chatsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 701);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.done);
            this.Controls.Add(this.Engineerbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbsearch5);
            this.Name = "chatsearch";
            this.Text = "chatsearch";
            this.Load += new System.EventHandler(this.chatsearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button Engineerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbsearch5;
        private System.Windows.Forms.Button button2;
    }
}