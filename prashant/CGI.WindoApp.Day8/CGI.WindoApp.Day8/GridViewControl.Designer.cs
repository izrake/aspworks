namespace CGI.WindoApp.Day8
{
    partial class GridViewControl
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
            this.gvPeopleDetails = new System.Windows.Forms.DataGridView();
            this.cbnCountrySDetail = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvPeopleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPeopleDetails
            // 
            this.gvPeopleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPeopleDetails.Location = new System.Drawing.Point(43, 80);
            this.gvPeopleDetails.Name = "gvPeopleDetails";
            this.gvPeopleDetails.Size = new System.Drawing.Size(855, 150);
            this.gvPeopleDetails.TabIndex = 0;
            // 
            // cbnCountrySDetail
            // 
            this.cbnCountrySDetail.FormattingEnabled = true;
            this.cbnCountrySDetail.Location = new System.Drawing.Point(389, 12);
            this.cbnCountrySDetail.Name = "cbnCountrySDetail";
            this.cbnCountrySDetail.Size = new System.Drawing.Size(121, 21);
            this.cbnCountrySDetail.TabIndex = 1;
            this.cbnCountrySDetail.SelectedIndexChanged += new System.EventHandler(this.cbnCountrySDetail_SelectedIndexChanged);
            // 
            // GridViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 262);
            this.Controls.Add(this.cbnCountrySDetail);
            this.Controls.Add(this.gvPeopleDetails);
            this.Name = "GridViewControl";
            this.Text = "GridViewControl";
            this.Load += new System.EventHandler(this.GridViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPeopleDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPeopleDetails;
        private System.Windows.Forms.ComboBox cbnCountrySDetail;
    }
}