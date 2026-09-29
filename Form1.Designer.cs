namespace DataMerger
{
    partial class FrmMerger
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
            txtSrcA = new TextBox();
            txtSrcB = new TextBox();
            numBx1 = new NumericUpDown();
            numBx2 = new NumericUpDown();
            lblSrcA = new Label();
            lblSrcB = new Label();
            lblDest = new Label();
            lblDestLabel = new Label();
            txtDestImg = new TextBox();
            txtDestLabel = new TextBox();
            btnCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)numBx1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBx2).BeginInit();
            SuspendLayout();
            // 
            // txtSrcA
            // 
            txtSrcA.Location = new Point(12, 43);
            txtSrcA.Name = "txtSrcA";
            txtSrcA.Size = new Size(719, 31);
            txtSrcA.TabIndex = 0;
            // 
            // txtSrcB
            // 
            txtSrcB.Location = new Point(12, 130);
            txtSrcB.Name = "txtSrcB";
            txtSrcB.Size = new Size(719, 31);
            txtSrcB.TabIndex = 1;
            // 
            // numBx1
            // 
            numBx1.Location = new Point(806, 43);
            numBx1.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numBx1.Name = "numBx1";
            numBx1.Size = new Size(180, 31);
            numBx1.TabIndex = 2;
            // 
            // numBx2
            // 
            numBx2.Location = new Point(806, 118);
            numBx2.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numBx2.Name = "numBx2";
            numBx2.Size = new Size(180, 31);
            numBx2.TabIndex = 3;
            // 
            // lblSrcA
            // 
            lblSrcA.AutoSize = true;
            lblSrcA.Location = new Point(12, 9);
            lblSrcA.Name = "lblSrcA";
            lblSrcA.Size = new Size(138, 25);
            lblSrcA.TabIndex = 4;
            lblSrcA.Text = "Source Folder A";
            // 
            // lblSrcB
            // 
            lblSrcB.AutoSize = true;
            lblSrcB.Location = new Point(12, 86);
            lblSrcB.Name = "lblSrcB";
            lblSrcB.Size = new Size(136, 25);
            lblSrcB.TabIndex = 5;
            lblSrcB.Text = "Source Folder B";
            // 
            // lblDest
            // 
            lblDest.AutoSize = true;
            lblDest.Location = new Point(12, 182);
            lblDest.Name = "lblDest";
            lblDest.Size = new Size(220, 25);
            lblDest.TabIndex = 6;
            lblDest.Text = "Destination Folder Images";
            // 
            // lblDestLabel
            // 
            lblDestLabel.AutoSize = true;
            lblDestLabel.Location = new Point(12, 269);
            lblDestLabel.Name = "lblDestLabel";
            lblDestLabel.Size = new Size(211, 25);
            lblDestLabel.TabIndex = 7;
            lblDestLabel.Text = "Destination Folder Labels";
            // 
            // txtDestImg
            // 
            txtDestImg.Location = new Point(12, 219);
            txtDestImg.Name = "txtDestImg";
            txtDestImg.Size = new Size(719, 31);
            txtDestImg.TabIndex = 8;
            // 
            // txtDestLabel
            // 
            txtDestLabel.Location = new Point(12, 318);
            txtDestLabel.Name = "txtDestLabel";
            txtDestLabel.Size = new Size(719, 31);
            txtDestLabel.TabIndex = 9;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(23, 378);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(112, 34);
            btnCopy.TabIndex = 10;
            btnCopy.Text = "Copy Files";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // FrmMerger
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 732);
            Controls.Add(btnCopy);
            Controls.Add(txtDestLabel);
            Controls.Add(txtDestImg);
            Controls.Add(lblDestLabel);
            Controls.Add(lblDest);
            Controls.Add(lblSrcB);
            Controls.Add(lblSrcA);
            Controls.Add(numBx2);
            Controls.Add(numBx1);
            Controls.Add(txtSrcB);
            Controls.Add(txtSrcA);
            Name = "FrmMerger";
            Text = "Data Merger";
            Load += FrmMerger_Load;
            ((System.ComponentModel.ISupportInitialize)numBx1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBx2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSrcA;
        private TextBox txtSrcB;
        private NumericUpDown numBx1;
        private NumericUpDown numBx2;
        private Label lblSrcA;
        private Label lblSrcB;
        private Label lblDest;
        private Label lblDestLabel;
        private TextBox txtDestImg;
        private TextBox txtDestLabel;
        private Button btnCopy;
    }
}
