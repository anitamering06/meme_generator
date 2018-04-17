namespace MemeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bottomText = new System.Windows.Forms.TextBox();
            this.topText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(515, 500);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(142, 500);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 1;
            this.open.Text = "Otworz";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bottomText);
            this.groupBox1.Controls.Add(this.topText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 422);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "edytor";
            // 
            // bottomText
            // 
            this.bottomText.Location = new System.Drawing.Point(27, 247);
            this.bottomText.MaxLength = 45;
            this.bottomText.Multiline = true;
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(216, 125);
            this.bottomText.TabIndex = 3;
            this.bottomText.TextChanged += new System.EventHandler(this.bottomText_TextChanged);
            // 
            // topText
            // 
            this.topText.Location = new System.Drawing.Point(27, 73);
            this.topText.MaxLength = 45;
            this.topText.Multiline = true;
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(216, 111);
            this.topText.TabIndex = 2;
            this.topText.TextChanged += new System.EventHandler(this.topText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "dolny text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "gorny text";
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(333, 23);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(384, 422);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preview.TabIndex = 3;
            this.preview.TabStop = false;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLabel.Location = new System.Drawing.Point(352, 57);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(0, 26);
            this.topLabel.TabIndex = 4;
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bottomLabel
            // 
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bottomLabel.Location = new System.Drawing.Point(352, 347);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(0, 26);
            this.bottomLabel.TabIndex = 5;
            this.bottomLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 630);
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bottomText;
        private System.Windows.Forms.TextBox topText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label bottomLabel;
    }
}

