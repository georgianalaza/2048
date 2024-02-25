namespace _2048
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
            this.Scor = new System.Windows.Forms.Button();
            this.Highscore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Scor
            // 
            this.Scor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Scor.BackColor = System.Drawing.Color.PeachPuff;
            this.Scor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scor.Location = new System.Drawing.Point(257, 64);
            this.Scor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Scor.Name = "Scor";
            this.Scor.Size = new System.Drawing.Size(190, 53);
            this.Scor.TabIndex = 0;
            this.Scor.Text = "0";
            this.Scor.UseVisualStyleBackColor = false;
            // 
            // Highscore
            // 
            this.Highscore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Highscore.BackColor = System.Drawing.Color.PeachPuff;
            this.Highscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Highscore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscore.Location = new System.Drawing.Point(59, 64);
            this.Highscore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(190, 53);
            this.Highscore.TabIndex = 2;
            this.Highscore.Text = "0";
            this.Highscore.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 174);
            this.button1.TabIndex = 3;
            this.button1.Text = "Începe joc!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gata
            // 
            this.gata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gata.BackColor = System.Drawing.Color.Coral;
            this.gata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gata.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gata.Location = new System.Drawing.Point(-1, -5);
            this.gata.Name = "gata";
            this.gata.Size = new System.Drawing.Size(518, 58);
            this.gata.TabIndex = 4;
            this.gata.Text = "oops. ai pierdut...";
            this.gata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(59, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hi-score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(257, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scor curent";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.Scor);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Scor;
        private System.Windows.Forms.Button Highscore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label gata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

