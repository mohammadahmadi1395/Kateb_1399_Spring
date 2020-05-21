namespace Ado.Net_StoredProcedure
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
            this.gvPerson = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPerson
            // 
            this.gvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPerson.Location = new System.Drawing.Point(-1, 45);
            this.gvPerson.Name = "gvPerson";
            this.gvPerson.RowHeadersWidth = 51;
            this.gvPerson.RowTemplate.Height = 24;
            this.gvPerson.Size = new System.Drawing.Size(798, 404);
            this.gvPerson.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(641, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(560, 16);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(722, 16);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 23);
            this.txtDelete.TabIndex = 10;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gvPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPerson;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button txtDelete;
    }
}

