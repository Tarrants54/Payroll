namespace Payroll
{
    partial class AddEmpForm
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
            this.gbAddDetails = new System.Windows.Forms.GroupBox();
            this.empPayTxtBox = new System.Windows.Forms.TextBox();
            this.empNameTxtBox = new System.Windows.Forms.TextBox();
            this.empIdTxtBox = new System.Windows.Forms.TextBox();
            this.payRateLabel = new System.Windows.Forms.Label();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.empIdLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.gbAddDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddDetails
            // 
            this.gbAddDetails.Controls.Add(this.empPayTxtBox);
            this.gbAddDetails.Controls.Add(this.empNameTxtBox);
            this.gbAddDetails.Controls.Add(this.empIdTxtBox);
            this.gbAddDetails.Controls.Add(this.payRateLabel);
            this.gbAddDetails.Controls.Add(this.empNameLabel);
            this.gbAddDetails.Controls.Add(this.empIdLabel);
            this.gbAddDetails.Location = new System.Drawing.Point(59, 49);
            this.gbAddDetails.Name = "gbAddDetails";
            this.gbAddDetails.Size = new System.Drawing.Size(372, 210);
            this.gbAddDetails.TabIndex = 0;
            this.gbAddDetails.TabStop = false;
            this.gbAddDetails.Text = "New Employee";
            // 
            // empPayTxtBox
            // 
            this.empPayTxtBox.Location = new System.Drawing.Point(199, 142);
            this.empPayTxtBox.Name = "empPayTxtBox";
            this.empPayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.empPayTxtBox.TabIndex = 5;
            // 
            // empNameTxtBox
            // 
            this.empNameTxtBox.Location = new System.Drawing.Point(199, 88);
            this.empNameTxtBox.Name = "empNameTxtBox";
            this.empNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.empNameTxtBox.TabIndex = 4;
            // 
            // empIdTxtBox
            // 
            this.empIdTxtBox.Location = new System.Drawing.Point(199, 32);
            this.empIdTxtBox.Name = "empIdTxtBox";
            this.empIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.empIdTxtBox.TabIndex = 3;
            // 
            // payRateLabel
            // 
            this.payRateLabel.AutoSize = true;
            this.payRateLabel.Location = new System.Drawing.Point(31, 149);
            this.payRateLabel.Name = "payRateLabel";
            this.payRateLabel.Size = new System.Drawing.Size(54, 13);
            this.payRateLabel.TabIndex = 2;
            this.payRateLabel.Text = "Pay Rate:";
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(31, 96);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(87, 13);
            this.empNameLabel.TabIndex = 1;
            this.empNameLabel.Text = "Employee Name:";
            // 
            // empIdLabel
            // 
            this.empIdLabel.AutoSize = true;
            this.empIdLabel.Location = new System.Drawing.Point(31, 39);
            this.empIdLabel.Name = "empIdLabel";
            this.empIdLabel.Size = new System.Drawing.Size(70, 13);
            this.empIdLabel.TabIndex = 0;
            this.empIdLabel.Text = "Employee ID:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(59, 298);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(209, 298);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(356, 298);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Clos&e";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AddEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 365);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.gbAddDetails);
            this.Name = "AddEmpForm";
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.AddEmpForm_Load);
            this.gbAddDetails.ResumeLayout(false);
            this.gbAddDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddDetails;
        private System.Windows.Forms.TextBox empPayTxtBox;
        private System.Windows.Forms.TextBox empNameTxtBox;
        private System.Windows.Forms.TextBox empIdTxtBox;
        private System.Windows.Forms.Label payRateLabel;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label empIdLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}