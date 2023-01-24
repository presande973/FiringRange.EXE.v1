namespace FiringRange.EXE.v1
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
            this.components = new System.ComponentModel.Container();
            this.target1 = new System.Windows.Forms.Button();
            this.target2 = new System.Windows.Forms.Button();
            this.target3 = new System.Windows.Forms.Button();
            this.target4 = new System.Windows.Forms.Button();
            this.target5 = new System.Windows.Forms.Button();
            this.target6 = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // target1
            // 
            this.target1.BackColor = System.Drawing.Color.DodgerBlue;
            this.target1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.target1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.target1.Location = new System.Drawing.Point(124, 207);
            this.target1.Name = "target1";
            this.target1.Size = new System.Drawing.Size(62, 63);
            this.target1.TabIndex = 0;
            this.target1.Text = "+";
            this.target1.UseVisualStyleBackColor = false;
            this.target1.Click += new System.EventHandler(this.target1_Click);
            // 
            // target2
            // 
            this.target2.BackColor = System.Drawing.Color.DodgerBlue;
            this.target2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.target2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.target2.Location = new System.Drawing.Point(294, 153);
            this.target2.Name = "target2";
            this.target2.Size = new System.Drawing.Size(62, 63);
            this.target2.TabIndex = 1;
            this.target2.Text = "+";
            this.target2.UseVisualStyleBackColor = false;
            this.target2.Click += new System.EventHandler(this.target2_Click);
            // 
            // target3
            // 
            this.target3.BackColor = System.Drawing.Color.DodgerBlue;
            this.target3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.target3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.target3.Location = new System.Drawing.Point(448, 153);
            this.target3.Name = "target3";
            this.target3.Size = new System.Drawing.Size(62, 63);
            this.target3.TabIndex = 2;
            this.target3.Text = "+";
            this.target3.UseVisualStyleBackColor = false;
            this.target3.Click += new System.EventHandler(this.target3_Click);
            // 
            // target4
            // 
            this.target4.BackColor = System.Drawing.Color.DodgerBlue;
            this.target4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.target4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.target4.Location = new System.Drawing.Point(610, 207);
            this.target4.Name = "target4";
            this.target4.Size = new System.Drawing.Size(62, 63);
            this.target4.TabIndex = 3;
            this.target4.Text = "+";
            this.target4.UseVisualStyleBackColor = false;
            this.target4.Click += new System.EventHandler(this.target4_Click);
            // 
            // target5
            // 
            this.target5.BackColor = System.Drawing.Color.DodgerBlue;
            this.target5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.target5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.target5.Location = new System.Drawing.Point(250, 293);
            this.target5.Name = "target5";
            this.target5.Size = new System.Drawing.Size(62, 63);
            this.target5.TabIndex = 4;
            this.target5.Text = "+";
            this.target5.UseVisualStyleBackColor = false;
            this.target5.Click += new System.EventHandler(this.target5_Click);
            // 
            // target6
            // 
            this.target6.BackColor = System.Drawing.Color.DodgerBlue;
            this.target6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.target6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.target6.Location = new System.Drawing.Point(486, 293);
            this.target6.Name = "target6";
            this.target6.Size = new System.Drawing.Size(62, 63);
            this.target6.TabIndex = 5;
            this.target6.Text = "+";
            this.target6.UseVisualStyleBackColor = false;
            this.target6.Click += new System.EventHandler(this.target6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FiringRange.EXE.v1.Properties.Resources.FiringRange_EXE_Design_drawio__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.target6);
            this.Controls.Add(this.target5);
            this.Controls.Add(this.target4);
            this.Controls.Add(this.target3);
            this.Controls.Add(this.target2);
            this.Controls.Add(this.target1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button target1;
        private System.Windows.Forms.Button target2;
        private System.Windows.Forms.Button target3;
        private System.Windows.Forms.Button target4;
        private System.Windows.Forms.Button target5;
        private System.Windows.Forms.Button target6;
        private System.Windows.Forms.Timer gameTimer;
    }
}

