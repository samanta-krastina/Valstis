namespace projekts_1
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.butNakamais = new System.Windows.Forms.Button();
            this.butIesniegt = new System.Windows.Forms.Button();
            this.labCheck = new System.Windows.Forms.Label();
            this.txtValsts = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butNakamais
            // 
            this.butNakamais.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butNakamais.Location = new System.Drawing.Point(363, 321);
            this.butNakamais.Name = "butNakamais";
            this.butNakamais.Size = new System.Drawing.Size(109, 31);
            this.butNakamais.TabIndex = 40;
            this.butNakamais.Text = "Nākamais";
            this.butNakamais.UseVisualStyleBackColor = true;
            this.butNakamais.Click += new System.EventHandler(this.butNakamais_Click);
            // 
            // butIesniegt
            // 
            this.butIesniegt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butIesniegt.Location = new System.Drawing.Point(238, 321);
            this.butIesniegt.Name = "butIesniegt";
            this.butIesniegt.Size = new System.Drawing.Size(109, 31);
            this.butIesniegt.TabIndex = 41;
            this.butIesniegt.Text = "Iesniegt";
            this.butIesniegt.UseVisualStyleBackColor = true;
            this.butIesniegt.Click += new System.EventHandler(this.butIesniegt_Click);
            // 
            // labCheck
            // 
            this.labCheck.AutoSize = true;
            this.labCheck.BackColor = System.Drawing.SystemColors.Control;
            this.labCheck.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCheck.Location = new System.Drawing.Point(37, 310);
            this.labCheck.Name = "labCheck";
            this.labCheck.Size = new System.Drawing.Size(22, 29);
            this.labCheck.TabIndex = 43;
            this.labCheck.Text = "X";
            this.labCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValsts
            // 
            this.txtValsts.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtValsts.Location = new System.Drawing.Point(166, 260);
            this.txtValsts.Name = "txtValsts";
            this.txtValsts.Size = new System.Drawing.Size(155, 30);
            this.txtValsts.TabIndex = 44;
            this.txtValsts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projekts_1.Properties.Resources.chile_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(201, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 245);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "10. Kas šī par valsti?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Līmenis : ļoti grūts";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtValsts);
            this.Controls.Add(this.labCheck);
            this.Controls.Add(this.butIesniegt);
            this.Controls.Add(this.butNakamais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "10 / 10";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNakamais;
        private System.Windows.Forms.Button butIesniegt;
        private System.Windows.Forms.Label labCheck;
        private System.Windows.Forms.TextBox txtValsts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}