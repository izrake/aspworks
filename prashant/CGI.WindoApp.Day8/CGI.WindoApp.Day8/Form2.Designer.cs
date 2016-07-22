namespace CGI.WindoApp.Day8
{
    partial class SearchPass
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.lblbPass = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.cbnUsername = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(12, 12);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(100, 20);
            this.txtSearchId.TabIndex = 1;
            // 
            // lblbPass
            // 
            this.lblbPass.AutoSize = true;
            this.lblbPass.Location = new System.Drawing.Point(182, 54);
            this.lblbPass.Name = "lblbPass";
            this.lblbPass.Size = new System.Drawing.Size(53, 13);
            this.lblbPass.TabIndex = 2;
            this.lblbPass.Text = "Password";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(182, 19);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(38, 13);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "UserId";
            // 
            // cbnUsername
            // 
            this.cbnUsername.FormattingEnabled = true;
            this.cbnUsername.Location = new System.Drawing.Point(12, 93);
            this.cbnUsername.Name = "cbnUsername";
            this.cbnUsername.Size = new System.Drawing.Size(100, 21);
            this.cbnUsername.TabIndex = 4;
            this.cbnUsername.SelectedIndexChanged += new System.EventHandler(this.cbnUsername_SelectedIndexChanged);
            // 
            // SearchPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbnUsername);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblbPass);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.btnSearch);
            this.Name = "SearchPass";
            this.Text = "SearchPass";
            this.Load += new System.EventHandler(this.SearchPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Label lblbPass;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox cbnUsername;
    }
}