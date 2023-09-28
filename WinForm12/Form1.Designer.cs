namespace WinForm12
{
    partial class Form1
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
            this.btnGetValue = new System.Windows.Forms.Button();
            this.btnSetValue = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetValue
            // 
            this.btnGetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetValue.Location = new System.Drawing.Point(55, 68);
            this.btnGetValue.Name = "btnGetValue";
            this.btnGetValue.Size = new System.Drawing.Size(131, 56);
            this.btnGetValue.TabIndex = 0;
            this.btnGetValue.Text = "Get Value";
            this.btnGetValue.UseVisualStyleBackColor = true;
            // 
            // btnSetValue
            // 
            this.btnSetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetValue.Location = new System.Drawing.Point(275, 68);
            this.btnSetValue.Name = "btnSetValue";
            this.btnSetValue.Size = new System.Drawing.Size(131, 56);
            this.btnSetValue.TabIndex = 0;
            this.btnSetValue.Text = "Set Value";
            this.btnSetValue.UseVisualStyleBackColor = true;
            this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(132, 208);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(137, 26);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(132, 240);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(132, 272);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(137, 26);
            this.txtAge.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(473, 68);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 56);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSetValue);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnGetValue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetValue;
        private System.Windows.Forms.Button btnSetValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSend;
    }
}

