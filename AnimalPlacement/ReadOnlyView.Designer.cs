namespace AnimalPlacement
{
    partial class ReadOnlyView
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
            this.pnlXaxis = new System.Windows.Forms.Panel();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.pnlYaxis = new System.Windows.Forms.Panel();
            this.cmbShowFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlXaxis
            // 
            this.pnlXaxis.BackColor = System.Drawing.SystemColors.Control;
            this.pnlXaxis.Location = new System.Drawing.Point(25, 1);
            this.pnlXaxis.Name = "pnlXaxis";
            this.pnlXaxis.Size = new System.Drawing.Size(460, 20);
            this.pnlXaxis.TabIndex = 43;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.Location = new System.Drawing.Point(25, 23);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(460, 460);
            this.pnlDraw.TabIndex = 42;
            // 
            // pnlYaxis
            // 
            this.pnlYaxis.BackColor = System.Drawing.SystemColors.Control;
            this.pnlYaxis.Location = new System.Drawing.Point(3, 23);
            this.pnlYaxis.Name = "pnlYaxis";
            this.pnlYaxis.Size = new System.Drawing.Size(20, 460);
            this.pnlYaxis.TabIndex = 44;
            // 
            // cmbShowFilter
            // 
            this.cmbShowFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbShowFilter.FormattingEnabled = true;
            this.cmbShowFilter.Location = new System.Drawing.Point(189, 489);
            this.cmbShowFilter.Name = "cmbShowFilter";
            this.cmbShowFilter.Size = new System.Drawing.Size(125, 28);
            this.cmbShowFilter.TabIndex = 45;
            this.cmbShowFilter.SelectedIndexChanged += new System.EventHandler(this.cmbShowFilter_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterBy.Location = new System.Drawing.Point(132, 492);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(49, 20);
            this.lblFilterBy.TabIndex = 46;
            this.lblFilterBy.Text = "Show";
            // 
            // ViewForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 525);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.cmbShowFilter);
            this.Controls.Add(this.pnlXaxis);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.pnlYaxis);
            this.Name = "ViewForm3";
            this.Text = "View form";
            this.Load += new System.EventHandler(this.ViewForm3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewForm3_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlXaxis;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Panel pnlYaxis;
        private System.Windows.Forms.ComboBox cmbShowFilter;
        private System.Windows.Forms.Label lblFilterBy;
    }
}