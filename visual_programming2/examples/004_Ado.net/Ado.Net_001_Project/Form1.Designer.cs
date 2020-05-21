namespace Ado.Net_001_Project
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
            this.gvMember = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMember
            // 
            this.gvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMember.Location = new System.Drawing.Point(53, 32);
            this.gvMember.Name = "gvMember";
            this.gvMember.RowHeadersWidth = 51;
            this.gvMember.RowTemplate.Height = 24;
            this.gvMember.Size = new System.Drawing.Size(420, 388);
            this.gvMember.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(552, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Apply";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(552, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(552, 126);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(152, 22);
            this.txtFamily.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(500, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(500, 126);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(48, 17);
            this.lblFamily.TabIndex = 5;
            this.lblFamily.Text = "Family";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(552, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gvMember);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMember;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Button btnUpdate;
    }
}

