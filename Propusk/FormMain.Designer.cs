
namespace Propusk
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxCountWorkers = new System.Windows.Forms.ComboBox();
            this.labelWorkers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCountVisitors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(12, 12);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.Size = new System.Drawing.Size(711, 541);
            this.textBoxReport.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(814, 530);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(150, 21);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxCountWorkers
            // 
            this.comboBoxCountWorkers.FormattingEnabled = true;
            this.comboBoxCountWorkers.Location = new System.Drawing.Point(994, 13);
            this.comboBoxCountWorkers.Name = "comboBoxCountWorkers";
            this.comboBoxCountWorkers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountWorkers.TabIndex = 4;
            // 
            // labelWorkers
            // 
            this.labelWorkers.AutoSize = true;
            this.labelWorkers.Location = new System.Drawing.Point(789, 18);
            this.labelWorkers.Name = "labelWorkers";
            this.labelWorkers.Size = new System.Drawing.Size(199, 13);
            this.labelWorkers.TabIndex = 5;
            this.labelWorkers.Text = "Укажите кол-во сотрудников в смене";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Укажите кол-во посетителей в смене";
            // 
            // comboBoxCountVisitors
            // 
            this.comboBoxCountVisitors.FormattingEnabled = true;
            this.comboBoxCountVisitors.Location = new System.Drawing.Point(994, 48);
            this.comboBoxCountVisitors.Name = "comboBoxCountVisitors";
            this.comboBoxCountVisitors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountVisitors.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 565);
            this.Controls.Add(this.comboBoxCountVisitors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWorkers);
            this.Controls.Add(this.comboBoxCountWorkers);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReport;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxCountWorkers;
        private System.Windows.Forms.Label labelWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCountVisitors;
    }
}

