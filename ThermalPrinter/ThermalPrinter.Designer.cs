namespace ThermalPrinter
{
    partial class ThermalPrinter
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.btnClearMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "TestPrint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReceipt
            // 
            this.txtReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceipt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceipt.Location = new System.Drawing.Point(236, 12);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(268, 460);
            this.txtReceipt.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 12);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(218, 60);
            this.txtMessage.TabIndex = 2;
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.Location = new System.Drawing.Point(12, 78);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(106, 29);
            this.btnAddMessage.TabIndex = 3;
            this.btnAddMessage.Text = "Add";
            this.btnAddMessage.UseVisualStyleBackColor = true;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Location = new System.Drawing.Point(124, 78);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(106, 29);
            this.btnClearMessage.TabIndex = 4;
            this.btnClearMessage.Text = "Clear";
            this.btnClearMessage.UseVisualStyleBackColor = true;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // ThermalPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 511);
            this.Controls.Add(this.btnClearMessage);
            this.Controls.Add(this.btnAddMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.button1);
            this.Name = "ThermalPrinter";
            this.Text = "Printer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnAddMessage;
        private System.Windows.Forms.Button btnClearMessage;
    }
}

