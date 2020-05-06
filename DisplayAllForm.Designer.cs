namespace Payroll
{
    partial class DisplayAllForm
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
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.Location = new System.Drawing.Point(79, 63);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(560, 212);
            this.lbDisplay.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(150, 315);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(473, 314);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "&Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // DisplayAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 375);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lbDisplay);
            this.Name = "DisplayAllForm";
            this.Text = "DisplayAllForm";
            this.Load += new System.EventHandler(this.DisplayAllForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}