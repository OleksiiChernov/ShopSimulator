namespace spz_lab3
{
    partial class MainForm
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
            this.mainLog = new System.Windows.Forms.TextBox();
            this.shopModes = new System.Windows.Forms.GroupBox();
            this.inventoryModeButton = new System.Windows.Forms.Button();
            this.normalModeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentModeLabel = new System.Windows.Forms.Label();
            this.inventoryLogButton = new System.Windows.Forms.Button();
            this.inventoryLastLogButton = new System.Windows.Forms.Button();
            this.normalLastLogButton = new System.Windows.Forms.Button();
            this.normalLogButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cashLabel = new System.Windows.Forms.Label();
            this.shopModes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLog
            // 
            this.mainLog.Location = new System.Drawing.Point(12, 209);
            this.mainLog.Multiline = true;
            this.mainLog.Name = "mainLog";
            this.mainLog.ReadOnly = true;
            this.mainLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainLog.Size = new System.Drawing.Size(534, 155);
            this.mainLog.TabIndex = 0;
            // 
            // shopModes
            // 
            this.shopModes.Controls.Add(this.inventoryModeButton);
            this.shopModes.Controls.Add(this.normalModeButton);
            this.shopModes.Location = new System.Drawing.Point(12, 12);
            this.shopModes.Name = "shopModes";
            this.shopModes.Size = new System.Drawing.Size(200, 66);
            this.shopModes.TabIndex = 1;
            this.shopModes.TabStop = false;
            this.shopModes.Text = "Shop Modes";
            // 
            // inventoryModeButton
            // 
            this.inventoryModeButton.Location = new System.Drawing.Point(106, 29);
            this.inventoryModeButton.Name = "inventoryModeButton";
            this.inventoryModeButton.Size = new System.Drawing.Size(88, 23);
            this.inventoryModeButton.TabIndex = 1;
            this.inventoryModeButton.Text = "Inventory";
            this.inventoryModeButton.UseVisualStyleBackColor = true;
            this.inventoryModeButton.Click += new System.EventHandler(this.inventoryModeButton_Click);
            // 
            // normalModeButton
            // 
            this.normalModeButton.Location = new System.Drawing.Point(7, 29);
            this.normalModeButton.Name = "normalModeButton";
            this.normalModeButton.Size = new System.Drawing.Size(93, 23);
            this.normalModeButton.TabIndex = 0;
            this.normalModeButton.Text = "Normal";
            this.normalModeButton.UseVisualStyleBackColor = true;
            this.normalModeButton.Click += new System.EventHandler(this.normalModeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentModeLabel);
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Mode";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // currentModeLabel
            // 
            this.currentModeLabel.AutoSize = true;
            this.currentModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentModeLabel.Location = new System.Drawing.Point(6, 29);
            this.currentModeLabel.Name = "currentModeLabel";
            this.currentModeLabel.Size = new System.Drawing.Size(102, 20);
            this.currentModeLabel.TabIndex = 0;
            this.currentModeLabel.Text = "CurrentMode";
            // 
            // inventoryLogButton
            // 
            this.inventoryLogButton.Location = new System.Drawing.Point(19, 104);
            this.inventoryLogButton.Name = "inventoryLogButton";
            this.inventoryLogButton.Size = new System.Drawing.Size(174, 23);
            this.inventoryLogButton.TabIndex = 1;
            this.inventoryLogButton.Text = "Generate inventory mode log";
            this.inventoryLogButton.UseVisualStyleBackColor = true;
            // 
            // inventoryLastLogButton
            // 
            this.inventoryLastLogButton.Location = new System.Drawing.Point(19, 133);
            this.inventoryLastLogButton.Name = "inventoryLastLogButton";
            this.inventoryLastLogButton.Size = new System.Drawing.Size(174, 23);
            this.inventoryLastLogButton.TabIndex = 3;
            this.inventoryLastLogButton.Text = "Generate last inventory mode log";
            this.inventoryLastLogButton.UseVisualStyleBackColor = true;
            // 
            // normalLastLogButton
            // 
            this.normalLastLogButton.Location = new System.Drawing.Point(233, 133);
            this.normalLastLogButton.Name = "normalLastLogButton";
            this.normalLastLogButton.Size = new System.Drawing.Size(174, 23);
            this.normalLastLogButton.TabIndex = 4;
            this.normalLastLogButton.Text = "Generate last normal mode log";
            this.normalLastLogButton.UseVisualStyleBackColor = true;
            // 
            // normalLogButton
            // 
            this.normalLogButton.Location = new System.Drawing.Point(233, 104);
            this.normalLogButton.Name = "normalLogButton";
            this.normalLogButton.Size = new System.Drawing.Size(174, 23);
            this.normalLogButton.TabIndex = 5;
            this.normalLogButton.Text = "Generate normal mode log";
            this.normalLogButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cashLabel);
            this.groupBox2.Location = new System.Drawing.Point(428, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cash";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashLabel.Location = new System.Drawing.Point(6, 29);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(36, 20);
            this.cashLabel.TabIndex = 0;
            this.cashLabel.Text = "100";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.normalLogButton);
            this.Controls.Add(this.normalLastLogButton);
            this.Controls.Add(this.inventoryLastLogButton);
            this.Controls.Add(this.inventoryLogButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shopModes);
            this.Controls.Add(this.mainLog);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.shopModes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainLog;
        private System.Windows.Forms.GroupBox shopModes;
        private System.Windows.Forms.Button inventoryModeButton;
        private System.Windows.Forms.Button normalModeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentModeLabel;
        private System.Windows.Forms.Button inventoryLogButton;
        private System.Windows.Forms.Button inventoryLastLogButton;
        private System.Windows.Forms.Button normalLastLogButton;
        private System.Windows.Forms.Button normalLogButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label cashLabel;
    }
}

