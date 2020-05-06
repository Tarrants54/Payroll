namespace Payroll
{
    partial class AddNewEmpHours
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
            this.gbHours = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.empHoursTxtBox = new System.Windows.Forms.TextBox();
            this.empHoursLabel = new System.Windows.Forms.Label();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.empIdLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.clsSaveBtn = new System.Windows.Forms.Button();
            this.gbHours.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHours
            // 
            this.gbHours.Controls.Add(this.nameLabel);
            this.gbHours.Controls.Add(this.idLabel);
            this.gbHours.Controls.Add(this.empHoursTxtBox);
            this.gbHours.Controls.Add(this.empHoursLabel);
            this.gbHours.Controls.Add(this.empNameLabel);
            this.gbHours.Controls.Add(this.empIdLabel);
            this.gbHours.Location = new System.Drawing.Point(55, 52);
            this.gbHours.Name = "gbHours";
            this.gbHours.Size = new System.Drawing.Size(376, 194);
            this.gbHours.TabIndex = 0;
            this.gbHours.TabStop = false;
            this.gbHours.Text = "Hours Data";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(231, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 7;
            // 
            // idLabel
            // 
            this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idLabel.Location = new System.Drawing.Point(231, 48);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(100, 23);
            this.idLabel.TabIndex = 6;
            // 
            // empHoursTxtBox
            // 
            this.empHoursTxtBox.Location = new System.Drawing.Point(231, 127);
            this.empHoursTxtBox.Name = "empHoursTxtBox";
            this.empHoursTxtBox.Size = new System.Drawing.Size(100, 20);
            this.empHoursTxtBox.TabIndex = 5;
            // 
            // empHoursLabel
            // 
            this.empHoursLabel.AutoSize = true;
            this.empHoursLabel.Location = new System.Drawing.Point(38, 134);
            this.empHoursLabel.Name = "empHoursLabel";
            this.empHoursLabel.Size = new System.Drawing.Size(79, 13);
            this.empHoursLabel.TabIndex = 2;
            this.empHoursLabel.Text = "Hours Worked:";
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(38, 89);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(87, 13);
            this.empNameLabel.TabIndex = 1;
            this.empNameLabel.Text = "Employee Name:";
            // 
            // empIdLabel
            // 
            this.empIdLabel.AutoSize = true;
            this.empIdLabel.Location = new System.Drawing.Point(39, 48);
            this.empIdLabel.Name = "empIdLabel";
            this.empIdLabel.Size = new System.Drawing.Size(70, 13);
            this.empIdLabel.TabIndex = 0;
            this.empIdLabel.Text = "Employee ID:";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(97, 284);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "&Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(204, 284);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // clsSaveBtn
            // 
            this.clsSaveBtn.Location = new System.Drawing.Point(311, 284);
            this.clsSaveBtn.Name = "clsSaveBtn";
            this.clsSaveBtn.Size = new System.Drawing.Size(85, 23);
            this.clsSaveBtn.TabIndex = 3;
            this.clsSaveBtn.Text = "Close && &Save";
            this.clsSaveBtn.UseVisualStyleBackColor = true;
            this.clsSaveBtn.Click += new System.EventHandler(this.clsSaveBtn_Click);
            // 
            // AddNewEmpHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 352);
            this.Controls.Add(this.clsSaveBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.gbHours);
            this.Name = "AddNewEmpHours";
            this.Text = "Add Employee Hours";
            this.Load += new System.EventHandler(this.AddHoursForm_Load);
            this.gbHours.ResumeLayout(false);
            this.gbHours.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHours;
        private System.Windows.Forms.TextBox empHoursTxtBox;
        private System.Windows.Forms.Label empHoursLabel;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label empIdLabel;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button clsSaveBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
    }
}