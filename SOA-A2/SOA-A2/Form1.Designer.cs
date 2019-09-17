namespace SOA_A2
{
    partial class SOAPForm
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
            this.CB_Services = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Service:";
            // 
            // CB_Services
            // 
            this.CB_Services.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Services.FormattingEnabled = true;
            this.CB_Services.Items.AddRange(new object[] {
            "Calculator",
            "ResolveIP",
            "Phone Verifier",
            "Dictionary"});
            this.CB_Services.Location = new System.Drawing.Point(243, 63);
            this.CB_Services.Margin = new System.Windows.Forms.Padding(0);
            this.CB_Services.Name = "CB_Services";
            this.CB_Services.Size = new System.Drawing.Size(183, 24);
            this.CB_Services.TabIndex = 1;
            this.CB_Services.SelectedIndexChanged += new System.EventHandler(this.CB_Services_SelectedIndexChanged);
            // 
            // SOAPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_Services);
            this.Controls.Add(this.label1);
            this.Name = "SOAPForm";
            this.Text = "SOAP Web Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Services;
    }
}

