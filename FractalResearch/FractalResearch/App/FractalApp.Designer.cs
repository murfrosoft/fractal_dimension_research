namespace FractalResearch
{
    partial class FractalApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlControls = new Panel();
            btnUpdateNoise = new Button();
            btnUpdateFilter = new Button();
            rtbOutput = new RichTextBox();
            btnFdGo = new Button();
            nudNoise = new NumericUpDown();
            cbBoxNoiseType = new ComboBox();
            lblNoise = new Label();
            lblStep3 = new Label();
            lblThreshold = new Label();
            nudThreshold = new NumericUpDown();
            lblFilter = new Label();
            lblStep2 = new Label();
            lblStep1 = new Label();
            cbBoxFilter = new ComboBox();
            lblImageName = new Label();
            btnChooseImage = new Button();
            pbImage = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNoise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pnlControls
            // 
            pnlControls.BorderStyle = BorderStyle.FixedSingle;
            pnlControls.Controls.Add(btnUpdateNoise);
            pnlControls.Controls.Add(btnUpdateFilter);
            pnlControls.Controls.Add(rtbOutput);
            pnlControls.Controls.Add(btnFdGo);
            pnlControls.Controls.Add(nudNoise);
            pnlControls.Controls.Add(cbBoxNoiseType);
            pnlControls.Controls.Add(lblNoise);
            pnlControls.Controls.Add(lblStep3);
            pnlControls.Controls.Add(lblThreshold);
            pnlControls.Controls.Add(nudThreshold);
            pnlControls.Controls.Add(lblFilter);
            pnlControls.Controls.Add(lblStep2);
            pnlControls.Controls.Add(lblStep1);
            pnlControls.Controls.Add(cbBoxFilter);
            pnlControls.Controls.Add(lblImageName);
            pnlControls.Controls.Add(btnChooseImage);
            pnlControls.Location = new Point(444, 12);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(344, 426);
            pnlControls.TabIndex = 0;
            // 
            // btnUpdateNoise
            // 
            btnUpdateNoise.Location = new Point(282, 149);
            btnUpdateNoise.Name = "btnUpdateNoise";
            btnUpdateNoise.Size = new Size(54, 23);
            btnUpdateNoise.TabIndex = 15;
            btnUpdateNoise.Text = "Update";
            btnUpdateNoise.UseVisualStyleBackColor = true;
            btnUpdateNoise.Click += btnUpdateNoise_Click;
            // 
            // btnUpdateFilter
            // 
            btnUpdateFilter.Location = new Point(282, 80);
            btnUpdateFilter.Name = "btnUpdateFilter";
            btnUpdateFilter.Size = new Size(54, 23);
            btnUpdateFilter.TabIndex = 14;
            btnUpdateFilter.Text = "Update";
            btnUpdateFilter.UseVisualStyleBackColor = true;
            btnUpdateFilter.Click += btnUpdateFilter_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(3, 239);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(336, 182);
            rtbOutput.TabIndex = 13;
            rtbOutput.Text = "";
            // 
            // btnFdGo
            // 
            btnFdGo.Location = new Point(70, 196);
            btnFdGo.Name = "btnFdGo";
            btnFdGo.Size = new Size(196, 23);
            btnFdGo.TabIndex = 12;
            btnFdGo.Text = "Calculate Fractal Dimension";
            btnFdGo.UseVisualStyleBackColor = true;
            btnFdGo.Click += btnFdGo_Click;
            // 
            // nudNoise
            // 
            nudNoise.Location = new Point(207, 149);
            nudNoise.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudNoise.Name = "nudNoise";
            nudNoise.Size = new Size(59, 23);
            nudNoise.TabIndex = 11;
            // 
            // cbBoxNoiseType
            // 
            cbBoxNoiseType.FormattingEnabled = true;
            cbBoxNoiseType.Items.AddRange(new object[] { "Uniform", "Gaussian" });
            cbBoxNoiseType.Location = new Point(51, 149);
            cbBoxNoiseType.Name = "cbBoxNoiseType";
            cbBoxNoiseType.Size = new Size(121, 23);
            cbBoxNoiseType.TabIndex = 10;
            // 
            // lblNoise
            // 
            lblNoise.AutoSize = true;
            lblNoise.Location = new Point(51, 131);
            lblNoise.Name = "lblNoise";
            lblNoise.Size = new Size(230, 15);
            lblNoise.TabIndex = 9;
            lblNoise.Text = "(optional) Choose Noise Type and amount";
            // 
            // lblStep3
            // 
            lblStep3.AutoSize = true;
            lblStep3.Location = new Point(3, 131);
            lblStep3.Name = "lblStep3";
            lblStep3.Size = new Size(42, 15);
            lblStep3.TabIndex = 8;
            lblStep3.Text = "Step 3:";
            // 
            // lblThreshold
            // 
            lblThreshold.AutoSize = true;
            lblThreshold.Location = new Point(207, 62);
            lblThreshold.Name = "lblThreshold";
            lblThreshold.Size = new Size(82, 15);
            lblThreshold.TabIndex = 7;
            lblThreshold.Text = "and Threshold";
            // 
            // nudThreshold
            // 
            nudThreshold.Location = new Point(207, 80);
            nudThreshold.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudThreshold.Name = "nudThreshold";
            nudThreshold.Size = new Size(59, 23);
            nudThreshold.TabIndex = 6;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(51, 62);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(76, 15);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Choose Filter";
            // 
            // lblStep2
            // 
            lblStep2.AutoSize = true;
            lblStep2.Location = new Point(3, 62);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(42, 15);
            lblStep2.TabIndex = 4;
            lblStep2.Text = "Step 2:";
            // 
            // lblStep1
            // 
            lblStep1.AutoSize = true;
            lblStep1.Location = new Point(3, 22);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(42, 15);
            lblStep1.TabIndex = 3;
            lblStep1.Text = "Step 1:";
            // 
            // cbBoxFilter
            // 
            cbBoxFilter.FormattingEnabled = true;
            cbBoxFilter.Items.AddRange(new object[] { "Threshold", "Edge" });
            cbBoxFilter.Location = new Point(51, 80);
            cbBoxFilter.Name = "cbBoxFilter";
            cbBoxFilter.Size = new Size(121, 23);
            cbBoxFilter.TabIndex = 2;
            cbBoxFilter.SelectedValueChanged += cbBoxFilter_SelectedValueChanged;
            // 
            // lblImageName
            // 
            lblImageName.AutoSize = true;
            lblImageName.Location = new Point(159, 22);
            lblImageName.Name = "lblImageName";
            lblImageName.Size = new Size(38, 15);
            lblImageName.TabIndex = 1;
            lblImageName.Text = "label1";
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(50, 18);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(103, 23);
            btnChooseImage.TabIndex = 0;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(12, 12);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(426, 426);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 1;
            pbImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FractalApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbImage);
            Controls.Add(pnlControls);
            Name = "FractalApp";
            Text = "Form1";
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNoise).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlControls;
        private Label lblImageName;
        private Button btnChooseImage;
        private PictureBox pbImage;
        private OpenFileDialog openFileDialog1;
        private Label lblThreshold;
        private NumericUpDown nudThreshold;
        private Label lblFilter;
        private Label lblStep2;
        private Label lblStep1;
        private ComboBox cbBoxFilter;
        private RichTextBox rtbOutput;
        private Button btnFdGo;
        private NumericUpDown nudNoise;
        private ComboBox cbBoxNoiseType;
        private Label lblNoise;
        private Label lblStep3;
        private Button btnUpdateNoise;
        private Button btnUpdateFilter;
    }
}