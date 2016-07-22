namespace CGI.WindoApp.Day8
{
    partial class GridView
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
            this.gvPosition = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPosition
            // 
            this.gvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPosition.Location = new System.Drawing.Point(0, 0);
            this.gvPosition.Name = "gvPosition";
            this.gvPosition.Size = new System.Drawing.Size(610, 289);
            this.gvPosition.TabIndex = 0;
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 301);
            this.Controls.Add(this.gvPosition);
            this.Name = "GridView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GridView";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPosition;
    }
}