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
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Methods = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.parameter1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parameter2 = new System.Windows.Forms.TextBox();
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
            this.CB_Services.Location = new System.Drawing.Point(243, 63);
            this.CB_Services.Margin = new System.Windows.Forms.Padding(0);
            this.CB_Services.Name = "CB_Services";
            this.CB_Services.Size = new System.Drawing.Size(183, 24);
            this.CB_Services.TabIndex = 1;
            this.CB_Services.SelectedIndexChanged += new System.EventHandler(this.CB_Services_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Method:";
            // 
            // CB_Methods
            // 
            this.CB_Methods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_Methods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Methods.FormattingEnabled = true;
            this.CB_Methods.Location = new System.Drawing.Point(243, 125);
            this.CB_Methods.Margin = new System.Windows.Forms.Padding(0);
            this.CB_Methods.Name = "CB_Methods";
            this.CB_Methods.Size = new System.Drawing.Size(183, 24);
            this.CB_Methods.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(134, 247);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(203, 58);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(486, 88);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(198, 189);
            this.result.TabIndex = 6;
            // 
            // parameter1
            // 
            this.parameter1.Location = new System.Drawing.Point(182, 194);
            this.parameter1.Name = "parameter1";
            this.parameter1.Size = new System.Drawing.Size(100, 20);
            this.parameter1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parameters:";
            // 
            // parameter2
            // 
            this.parameter2.Location = new System.Drawing.Point(326, 194);
            this.parameter2.Name = "parameter2";
            this.parameter2.Size = new System.Drawing.Size(100, 20);
            this.parameter2.TabIndex = 9;
            // 
            // SOAPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parameter2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parameter1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.CB_Methods);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Services);
            this.Controls.Add(this.label1);
            this.Name = "SOAPForm";
            this.Text = "SOAP Web Services";
            this.Load += new System.EventHandler(this.SOAPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Services;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Methods;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox parameter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parameter2;
    }
}

