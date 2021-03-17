
namespace SimpleDoubler
{
    partial class Form1
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
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelActions = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LabelGoal = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(194, 70);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(75, 23);
            this.BtnPlus.TabIndex = 0;
            this.BtnPlus.Text = "button1";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(194, 99);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(75, 23);
            this.BtnMulti.TabIndex = 1;
            this.BtnMulti.Text = "button2";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(194, 128);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "button3";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(117, 104);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(35, 13);
            this.LabelNumber.TabIndex = 3;
            this.LabelNumber.Text = "label1";
            // 
            // LabelActions
            // 
            this.LabelActions.AutoSize = true;
            this.LabelActions.Location = new System.Drawing.Point(117, 128);
            this.LabelActions.Name = "LabelActions";
            this.LabelActions.Size = new System.Drawing.Size(35, 13);
            this.LabelActions.TabIndex = 4;
            this.LabelActions.Text = "label1";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(194, 41);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "button1";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(275, 41);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "button1";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LabelGoal
            // 
            this.LabelGoal.AutoSize = true;
            this.LabelGoal.Location = new System.Drawing.Point(117, 150);
            this.LabelGoal.Name = "LabelGoal";
            this.LabelGoal.Size = new System.Drawing.Size(35, 13);
            this.LabelGoal.TabIndex = 7;
            this.LabelGoal.Text = "label1";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(356, 41);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "button1";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LabelGoal);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LabelActions);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelActions;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LabelGoal;
        private System.Windows.Forms.Button BtnCancel;
    }
}

