
namespace Propusk
{
    partial class ClientsForm
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.labelFindWorker = new System.Windows.Forms.Label();
            this.textBoxFinfWorker = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(376, 425);
            this.dataGridViewClients.TabIndex = 1;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(449, 234);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(240, 84);
            this.dataGridViewClient.TabIndex = 8;
            // 
            // labelFindWorker
            // 
            this.labelFindWorker.AutoSize = true;
            this.labelFindWorker.Location = new System.Drawing.Point(477, 162);
            this.labelFindWorker.Name = "labelFindWorker";
            this.labelFindWorker.Size = new System.Drawing.Size(55, 13);
            this.labelFindWorker.TabIndex = 7;
            this.labelFindWorker.Text = "Значение";
            // 
            // textBoxFinfWorker
            // 
            this.textBoxFinfWorker.Location = new System.Drawing.Point(538, 159);
            this.textBoxFinfWorker.Name = "textBoxFinfWorker";
            this.textBoxFinfWorker.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinfWorker.TabIndex = 6;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(480, 185);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(158, 23);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Найти человека";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.labelFindWorker);
            this.Controls.Add(this.textBoxFinfWorker);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Label labelFindWorker;
        private System.Windows.Forms.TextBox textBoxFinfWorker;
        private System.Windows.Forms.Button buttonFind;
    }
}