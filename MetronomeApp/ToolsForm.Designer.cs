namespace MetronomeApp
{
    partial class ToolsForm
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
            this.songsToLearnButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songsToLearnButton
            // 
            this.songsToLearnButton.Location = new System.Drawing.Point(345, 104);
            this.songsToLearnButton.Name = "songsToLearnButton";
            this.songsToLearnButton.Size = new System.Drawing.Size(95, 23);
            this.songsToLearnButton.TabIndex = 0;
            this.songsToLearnButton.Text = "Songs to Learn";
            this.songsToLearnButton.UseVisualStyleBackColor = true;
            this.songsToLearnButton.Click += new System.EventHandler(this.songsToLearnButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(87, 359);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(338, 51);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(102, 39);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Tools";
            // 
            // ToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.songsToLearnButton);
            this.Name = "ToolsForm";
            this.Text = "Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button songsToLearnButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label headerLabel;
    }
}