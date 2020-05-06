namespace Payroll
{
    partial class MainMenu
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
            this.addNewButton = new System.Windows.Forms.Button();
            this.displayAllButton = new System.Windows.Forms.Button();
            this.addHoursWorkButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(72, 114);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(75, 36);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "Add New Employee";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // displayAllButton
            // 
            this.displayAllButton.Location = new System.Drawing.Point(72, 209);
            this.displayAllButton.Name = "displayAllButton";
            this.displayAllButton.Size = new System.Drawing.Size(75, 23);
            this.displayAllButton.TabIndex = 1;
            this.displayAllButton.Text = "Display &All";
            this.displayAllButton.UseVisualStyleBackColor = true;
            this.displayAllButton.Click += new System.EventHandler(this.displayAllButton_Click);
            // 
            // addHoursWorkButton
            // 
            this.addHoursWorkButton.Location = new System.Drawing.Point(239, 114);
            this.addHoursWorkButton.Name = "addHoursWorkButton";
            this.addHoursWorkButton.Size = new System.Drawing.Size(75, 36);
            this.addHoursWorkButton.TabIndex = 2;
            this.addHoursWorkButton.Text = "Add Hours Worked";
            this.addHoursWorkButton.UseVisualStyleBackColor = true;
            this.addHoursWorkButton.Click += new System.EventHandler(this.addHoursWorkButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(239, 209);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(65, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(245, 39);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Employee Payroll";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(154, 263);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 38);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete All Employees";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 324);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addHoursWorkButton);
            this.Controls.Add(this.displayAllButton);
            this.Controls.Add(this.addNewButton);
            this.Name = "MainMenu";
            this.Text = "Employee Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button displayAllButton;
        private System.Windows.Forms.Button addHoursWorkButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button deleteBtn;
    }
}

