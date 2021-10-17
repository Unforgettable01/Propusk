
namespace Propusk
{
    partial class FormVisualization
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
            this.pictureBoxVisualization = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualization)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVisualization
            // 
            this.pictureBoxVisualization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxVisualization.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxVisualization.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxVisualization.Name = "pictureBoxVisualization";
            this.pictureBoxVisualization.Size = new System.Drawing.Size(775, 425);
            this.pictureBoxVisualization.TabIndex = 0;
            this.pictureBoxVisualization.TabStop = false;
            // 
            // FormVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxVisualization);
            this.Name = "FormVisualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisualization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVisualization;
    }
}