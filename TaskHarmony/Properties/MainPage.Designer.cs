namespace TaskHarmony.Properties
{
    partial class MainPage
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
            this.Engineerbutton = new System.Windows.Forms.Button();
            this.superbutton = new System.Windows.Forms.Button();
            this.workerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Engineerbutton
            // 
            this.Engineerbutton.Location = new System.Drawing.Point(12, 512);
            this.Engineerbutton.Name = "Engineerbutton";
            this.Engineerbutton.Size = new System.Drawing.Size(477, 59);
            this.Engineerbutton.TabIndex = 7;
            this.Engineerbutton.Text = "Engineer";
            this.Engineerbutton.UseVisualStyleBackColor = true;
            this.Engineerbutton.Click += new System.EventHandler(this.Engineerbutton_Click);
            // 
            // superbutton
            // 
            this.superbutton.Location = new System.Drawing.Point(12, 406);
            this.superbutton.Name = "superbutton";
            this.superbutton.Size = new System.Drawing.Size(477, 59);
            this.superbutton.TabIndex = 6;
            this.superbutton.Text = "Supervisor";
            this.superbutton.UseVisualStyleBackColor = true;
            this.superbutton.Click += new System.EventHandler(this.superbutton_Click);
            // 
            // workerbutton
            // 
            this.workerbutton.Location = new System.Drawing.Point(12, 295);
            this.workerbutton.Name = "workerbutton";
            this.workerbutton.Size = new System.Drawing.Size(477, 59);
            this.workerbutton.TabIndex = 5;
            this.workerbutton.Text = "Worker";
            this.workerbutton.UseVisualStyleBackColor = true;
            this.workerbutton.Click += new System.EventHandler(this.workerbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose your profession in the factory";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 701);
            this.Controls.Add(this.Engineerbutton);
            this.Controls.Add(this.superbutton);
            this.Controls.Add(this.workerbutton);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Engineerbutton;
        private System.Windows.Forms.Button superbutton;
        private System.Windows.Forms.Button workerbutton;
        private System.Windows.Forms.Label label1;
    }
}