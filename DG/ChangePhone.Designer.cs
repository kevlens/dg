namespace DG
{
    partial class ChangePhone
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
            this.lblSectionId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPointNo = new System.Windows.Forms.TextBox();
            this.lblOldPointNo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "区间ID";
            // 
            // lblSectionId
            // 
            this.lblSectionId.AutoSize = true;
            this.lblSectionId.Location = new System.Drawing.Point(79, 35);
            this.lblSectionId.Name = "lblSectionId";
            this.lblSectionId.Size = new System.Drawing.Size(0, 12);
            this.lblSectionId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "原手机号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "新手机号";
            // 
            // txtNewPointNo
            // 
            this.txtNewPointNo.Location = new System.Drawing.Point(92, 94);
            this.txtNewPointNo.Name = "txtNewPointNo";
            this.txtNewPointNo.Size = new System.Drawing.Size(100, 21);
            this.txtNewPointNo.TabIndex = 4;
            // 
            // lblOldPointNo
            // 
            this.lblOldPointNo.AutoSize = true;
            this.lblOldPointNo.Location = new System.Drawing.Point(91, 64);
            this.lblOldPointNo.Name = "lblOldPointNo";
            this.lblOldPointNo.Size = new System.Drawing.Size(0, 12);
            this.lblOldPointNo.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(117, 148);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "生成SQL";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ChangePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 185);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblOldPointNo);
            this.Controls.Add(this.txtNewPointNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSectionId);
            this.Controls.Add(this.label1);
            this.Name = "ChangePhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "手机号变更";
            this.Load += new System.EventHandler(this.ChangePhone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSectionId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPointNo;
        private System.Windows.Forms.Label lblOldPointNo;
        private System.Windows.Forms.Button btnOK;
    }
}