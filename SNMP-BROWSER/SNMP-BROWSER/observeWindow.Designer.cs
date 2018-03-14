namespace SNMP_BROWSER
{
    partial class ObserveWindow
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
            this.oidLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.oidTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oidLabel
            // 
            this.oidLabel.AutoSize = true;
            this.oidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oidLabel.Location = new System.Drawing.Point(12, 9);
            this.oidLabel.Name = "oidLabel";
            this.oidLabel.Size = new System.Drawing.Size(88, 20);
            this.oidLabel.TabIndex = 0;
            this.oidLabel.Text = "Name/OID";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valueLabel.Location = new System.Drawing.Point(12, 43);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(51, 20);
            this.valueLabel.TabIndex = 1;
            this.valueLabel.Text = "Value";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeLabel.Location = new System.Drawing.Point(12, 77);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(45, 20);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Type";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel.Location = new System.Drawing.Point(12, 111);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(60, 20);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "IP:Port";
            // 
            // oidTextBox
            // 
            this.oidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oidTextBox.Location = new System.Drawing.Point(106, 6);
            this.oidTextBox.Name = "oidTextBox";
            this.oidTextBox.ReadOnly = true;
            this.oidTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.oidTextBox.Size = new System.Drawing.Size(336, 27);
            this.oidTextBox.TabIndex = 4;
            this.oidTextBox.WordWrap = false;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valueTextBox.Location = new System.Drawing.Point(106, 41);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.ReadOnly = true;
            this.valueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.valueTextBox.Size = new System.Drawing.Size(336, 27);
            this.valueTextBox.TabIndex = 5;
            this.valueTextBox.WordWrap = false;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeTextBox.Location = new System.Drawing.Point(106, 74);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.typeTextBox.Size = new System.Drawing.Size(336, 27);
            this.typeTextBox.TabIndex = 6;
            this.typeTextBox.WordWrap = false;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipTextBox.Location = new System.Drawing.Point(106, 108);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.ReadOnly = true;
            this.ipTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ipTextBox.Size = new System.Drawing.Size(336, 27);
            this.ipTextBox.TabIndex = 7;
            this.ipTextBox.WordWrap = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(12, 145);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(91, 20);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Last check";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeTextBox.Location = new System.Drawing.Point(106, 142);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.timeTextBox.Size = new System.Drawing.Size(336, 27);
            this.timeTextBox.TabIndex = 9;
            this.timeTextBox.WordWrap = false;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.Location = new System.Drawing.Point(347, 204);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(95, 37);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // observeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 253);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.oidTextBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.oidLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "observeWindow";
            this.Text = "Observing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox oidTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label oidLabel;
    }
}