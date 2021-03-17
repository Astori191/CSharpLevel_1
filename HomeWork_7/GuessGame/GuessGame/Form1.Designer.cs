
namespace GuessGame
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.LabelA = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LabelTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(287, 141);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(156, 20);
            this.UserInput.TabIndex = 0;
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Location = new System.Drawing.Point(284, 125);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(35, 13);
            this.LabelA.TabIndex = 1;
            this.LabelA.Text = "label1";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(287, 168);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "button1";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(368, 168);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(137, 22);
            this.BtnGenerate.TabIndex = 3;
            this.BtnGenerate.Text = "button1";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(368, 168);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(137, 23);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "button1";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LabelTries
            // 
            this.LabelTries.AutoSize = true;
            this.LabelTries.Location = new System.Drawing.Point(449, 144);
            this.LabelTries.Name = "LabelTries";
            this.LabelTries.Size = new System.Drawing.Size(35, 13);
            this.LabelTries.TabIndex = 5;
            this.LabelTries.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelTries);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LabelA);
            this.Controls.Add(this.UserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LabelTries;
    }
}

