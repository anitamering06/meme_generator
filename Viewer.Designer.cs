namespace MemeGenerator
{
    partial class Viewer
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
            this.preview = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomText = new System.Windows.Forms.TextBox();
            this.topText = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(490, 12);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(519, 542);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(490, 570);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(165, 55);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Poprzedni";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(844, 570);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 55);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Następny";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bottomText);
            this.groupBox1.Controls.Add(this.topText);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 530);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edytor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "dolny tekst";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "gorny tekst";
            // 
            // bottomText
            // 
            this.bottomText.Location = new System.Drawing.Point(76, 304);
            this.bottomText.Multiline = true;
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(210, 127);
            this.bottomText.TabIndex = 1;
            this.bottomText.TextChanged += new System.EventHandler(this.bottomText_TextChanged);
            // 
            // topText
            // 
            this.topText.Location = new System.Drawing.Point(76, 92);
            this.topText.Multiline = true;
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(210, 124);
            this.topText.TabIndex = 0;
            this.topText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLabel.Location = new System.Drawing.Point(490, 64);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(0, 26);
            this.topLabel.TabIndex = 4;
            // 
            // bottomLabel
            // 
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.BackColor = System.Drawing.SystemColors.Control;
            this.bottomLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bottomLabel.Location = new System.Drawing.Point(490, 415);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(0, 26);
            this.bottomLabel.TabIndex = 5;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(113, 570);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(133, 55);
            this.save.TabIndex = 6;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 627);
            this.Controls.Add(this.save);
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.preview);
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.Load += new System.EventHandler(this.Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bottomText;
        private System.Windows.Forms.TextBox topText;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label bottomLabel;
        private System.Windows.Forms.Button save;
    }
}