namespace WachtrijApp
{
    partial class FormWachtrij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWachtrij));
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelWachttijd = new System.Windows.Forms.Label();
            this.labelWachttijdMelding = new System.Windows.Forms.Label();
            this.labelKar2 = new System.Windows.Forms.Label();
            this.labelKar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(39, 28);
            this.labelTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(223, 32);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "city of superheros";
            // 
            // labelWachttijd
            // 
            this.labelWachttijd.AutoSize = true;
            this.labelWachttijd.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijd.Location = new System.Drawing.Point(40, 229);
            this.labelWachttijd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWachttijd.Name = "labelWachttijd";
            this.labelWachttijd.Size = new System.Drawing.Size(99, 25);
            this.labelWachttijd.TabIndex = 4;
            this.labelWachttijd.Text = "Wachttijd";
            // 
            // labelWachttijdMelding
            // 
            this.labelWachttijdMelding.AutoSize = true;
            this.labelWachttijdMelding.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijdMelding.Location = new System.Drawing.Point(44, 268);
            this.labelWachttijdMelding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWachttijdMelding.Name = "labelWachttijdMelding";
            this.labelWachttijdMelding.Size = new System.Drawing.Size(71, 18);
            this.labelWachttijdMelding.TabIndex = 5;
            this.labelWachttijdMelding.Text = "0 minuten";
            // 
            // labelKar2
            // 
            this.labelKar2.AutoSize = true;
            this.labelKar2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelKar2.Location = new System.Drawing.Point(44, 134);
            this.labelKar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKar2.Name = "labelKar2";
            this.labelKar2.Size = new System.Drawing.Size(57, 18);
            this.labelKar2.TabIndex = 8;
            this.labelKar2.Text = "Kar 2: ...";
            // 
            // labelKar1
            // 
            this.labelKar1.AutoSize = true;
            this.labelKar1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelKar1.Location = new System.Drawing.Point(44, 105);
            this.labelKar1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKar1.Name = "labelKar1";
            this.labelKar1.Size = new System.Drawing.Size(57, 18);
            this.labelKar1.TabIndex = 9;
            this.labelKar1.Text = "Kar 1: ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label1.Location = new System.Drawing.Point(44, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kar 3: ...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 205);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormWachtrij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(418, 349);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKar1);
            this.Controls.Add(this.labelKar2);
            this.Controls.Add(this.labelWachttijdMelding);
            this.Controls.Add(this.labelWachttijd);
            this.Controls.Add(this.labelTitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormWachtrij";
            this.Text = "Bugs of Horror";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelWachttijd;
        private System.Windows.Forms.Label labelWachttijdMelding;
        private System.Windows.Forms.Label labelKar2;
        private System.Windows.Forms.Label labelKar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

