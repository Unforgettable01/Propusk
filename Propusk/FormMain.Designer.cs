
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
            this.buttonStartProg = new System.Windows.Forms.Button();
            this.comboBoxCountClientsStart = new System.Windows.Forms.ComboBox();
            this.labelWorkers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCountWorkers = new System.Windows.Forms.ComboBox();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посетителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.comboBoxCountClientsFinish = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartProg
            // 
            this.buttonStartProg.Location = new System.Drawing.Point(15, 91);
            this.buttonStartProg.Name = "buttonStartProg";
            this.buttonStartProg.Size = new System.Drawing.Size(150, 21);
            this.buttonStartProg.TabIndex = 3;
            this.buttonStartProg.Text = "Начать смену";
            this.buttonStartProg.UseVisualStyleBackColor = true;
            this.buttonStartProg.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxCountClientsStart
            // 
            this.comboBoxCountClientsStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCountClientsStart.FormattingEnabled = true;
            this.comboBoxCountClientsStart.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboBoxCountClientsStart.Location = new System.Drawing.Point(244, 61);
            this.comboBoxCountClientsStart.Name = "comboBoxCountClientsStart";
            this.comboBoxCountClientsStart.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountClientsStart.TabIndex = 4;
            // 
            // labelWorkers
            // 
            this.labelWorkers.AutoSize = true;
            this.labelWorkers.Location = new System.Drawing.Point(12, 31);
            this.labelWorkers.Name = "labelWorkers";
            this.labelWorkers.Size = new System.Drawing.Size(199, 13);
            this.labelWorkers.TabIndex = 5;
            this.labelWorkers.Text = "Укажите кол-во сотрудников в смене";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Укажите кол-во посетителей в смене";
            // 
            // comboBoxCountWorkers
            // 
            this.comboBoxCountWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCountWorkers.FormattingEnabled = true;
            this.comboBoxCountWorkers.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.comboBoxCountWorkers.Location = new System.Drawing.Point(223, 28);
            this.comboBoxCountWorkers.Name = "comboBoxCountWorkers";
            this.comboBoxCountWorkers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountWorkers.TabIndex = 7;
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(207, 91);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(150, 21);
            this.buttonSaveReport.TabIndex = 8;
            this.buttonSaveReport.Text = "Сохранить информаацию в файл";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1283, 24);
            this.menuStripMain.TabIndex = 10;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.посетителиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // посетителиToolStripMenuItem
            // 
            this.посетителиToolStripMenuItem.Name = "посетителиToolStripMenuItem";
            this.посетителиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.посетителиToolStripMenuItem.Text = "Посетители";
            this.посетителиToolStripMenuItem.Click += new System.EventHandler(this.посетителиToolStripMenuItem_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(14, 118);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(1259, 433);
            this.richTextBoxInfo.TabIndex = 11;
            this.richTextBoxInfo.Text = "";
            // 
            // comboBoxCountClientsFinish
            // 
            this.comboBoxCountClientsFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCountClientsFinish.FormattingEnabled = true;
            this.comboBoxCountClientsFinish.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110"});
            this.comboBoxCountClientsFinish.Location = new System.Drawing.Point(399, 61);
            this.comboBoxCountClientsFinish.Name = "comboBoxCountClientsFinish";
            this.comboBoxCountClientsFinish.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountClientsFinish.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "до";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCountClientsFinish);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.comboBoxCountWorkers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWorkers);
            this.Controls.Add(this.comboBoxCountClientsStart);
            this.Controls.Add(this.buttonStartProg);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1299, 604);
            this.Name = "FormMain";
            this.Text = "Пункт пропуска";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStartProg;
        private System.Windows.Forms.ComboBox comboBoxCountClientsStart;
        private System.Windows.Forms.Label labelWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCountWorkers;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посетителиToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.ComboBox comboBoxCountClientsFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

