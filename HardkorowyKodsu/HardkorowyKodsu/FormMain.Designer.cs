
namespace HardkorowyKodsu
{
    partial class FormMain
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
            this.btnProccess = new DevExpress.XtraEditors.SimpleButton();
            this.rtxData = new System.Windows.Forms.RichTextBox();
            this.btnProcess1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnProcess2 = new DevExpress.XtraEditors.SimpleButton();
            this.rtxTableName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnProccess
            // 
            this.btnProccess.Location = new System.Drawing.Point(56, 468);
            this.btnProccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProccess.Name = "btnProccess";
            this.btnProccess.Size = new System.Drawing.Size(196, 58);
            this.btnProccess.TabIndex = 0;
            this.btnProccess.Text = "Process";
            this.btnProccess.Click += new System.EventHandler(this.btnProccess_ClickAsync);
            // 
            // rtxData
            // 
            this.rtxData.Location = new System.Drawing.Point(56, 46);
            this.rtxData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxData.Name = "rtxData";
            this.rtxData.Size = new System.Drawing.Size(975, 397);
            this.rtxData.TabIndex = 1;
            this.rtxData.Text = "";
            // 
            // btnProcess1
            // 
            this.btnProcess1.Location = new System.Drawing.Point(260, 468);
            this.btnProcess1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(196, 58);
            this.btnProcess1.TabIndex = 2;
            this.btnProcess1.Text = "Get tables";
            this.btnProcess1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // btnProcess2
            // 
            this.btnProcess2.Location = new System.Drawing.Point(464, 468);
            this.btnProcess2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcess2.Name = "btnProcess2";
            this.btnProcess2.Size = new System.Drawing.Size(196, 58);
            this.btnProcess2.TabIndex = 3;
            this.btnProcess2.Text = "Get columns";
            this.btnProcess2.Click += new System.EventHandler(this.btnProcess2_Click);
            // 
            // rtxTableName
            // 
            this.rtxTableName.Location = new System.Drawing.Point(691, 468);
            this.rtxTableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxTableName.Name = "rtxTableName";
            this.rtxTableName.Size = new System.Drawing.Size(295, 57);
            this.rtxTableName.TabIndex = 4;
            this.rtxTableName.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rtxTableName);
            this.Controls.Add(this.btnProcess2);
            this.Controls.Add(this.btnProcess1);
            this.Controls.Add(this.rtxData);
            this.Controls.Add(this.btnProccess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnProccess;
        private System.Windows.Forms.RichTextBox rtxData;
        private DevExpress.XtraEditors.SimpleButton btnProcess1;
        private DevExpress.XtraEditors.SimpleButton btnProcess2;
        private System.Windows.Forms.RichTextBox rtxTableName;
    }
}

