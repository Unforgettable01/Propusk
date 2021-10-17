
namespace Propusk
{
    partial class WorkersForm
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
            this.dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFinfWorker = new System.Windows.Forms.TextBox();
            this.labelFindWorker = new System.Windows.Forms.Label();
            this.dataGridViewWorker = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorkers
            // 
            this.dataGridViewWorkers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            this.dataGridViewWorkers.Size = new System.Drawing.Size(373, 425);
            this.dataGridViewWorkers.TabIndex = 0;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(500, 199);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(158, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Найти человека";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxFinfWorker
            // 
            this.textBoxFinfWorker.Location = new System.Drawing.Point(558, 173);
            this.textBoxFinfWorker.Name = "textBoxFinfWorker";
            this.textBoxFinfWorker.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinfWorker.TabIndex = 2;
            // 
            // labelFindWorker
            // 
            this.labelFindWorker.AutoSize = true;
            this.labelFindWorker.Location = new System.Drawing.Point(497, 176);
            this.labelFindWorker.Name = "labelFindWorker";
            this.labelFindWorker.Size = new System.Drawing.Size(55, 13);
            this.labelFindWorker.TabIndex = 3;
            this.labelFindWorker.Text = "Значение";
            // 
            // dataGridViewWorker
            // 
            this.dataGridViewWorker.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorker.Location = new System.Drawing.Point(469, 248);
            this.dataGridViewWorker.Name = "dataGridViewWorker";
            this.dataGridViewWorker.Size = new System.Drawing.Size(240, 84);
            this.dataGridViewWorker.TabIndex = 4;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewWorker);
            this.Controls.Add(this.labelFindWorker);
            this.Controls.Add(this.textBoxFinfWorker);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewWorkers);
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWorkers;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxFinfWorker;
        private System.Windows.Forms.Label labelFindWorker;
        private System.Windows.Forms.DataGridView dataGridViewWorker;
    }
}