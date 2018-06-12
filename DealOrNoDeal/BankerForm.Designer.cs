namespace DealOrNoDeal
{
    partial class BankerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.acceptContinueButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bankarot ja nudi slednata suma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLabel.Location = new System.Drawing.Point(394, 33);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(81, 29);
            this.sumLabel.TabIndex = 1;
            this.sumLabel.Text = "label2";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(17, 81);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(136, 66);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Prifati";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // acceptContinueButton
            // 
            this.acceptContinueButton.Location = new System.Drawing.Point(176, 81);
            this.acceptContinueButton.Name = "acceptContinueButton";
            this.acceptContinueButton.Size = new System.Drawing.Size(136, 66);
            this.acceptContinueButton.TabIndex = 3;
            this.acceptContinueButton.Text = "Prifati, i doigraj";
            this.acceptContinueButton.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(339, 81);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(136, 66);
            this.continueButton.TabIndex = 4;
            this.continueButton.Text = "Odbij, prodolzi so igrata";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // BankerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 171);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.acceptContinueButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.label1);
            this.Name = "BankerForm";
            this.Text = "BankerForm";
            this.Load += new System.EventHandler(this.BankerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button acceptContinueButton;
        private System.Windows.Forms.Button continueButton;
    }
}