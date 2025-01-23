
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
            this.SuspendLayout();
            // 
            // btnProccess
            // 
            this.btnProccess.Location = new System.Drawing.Point(42, 380);
            this.btnProccess.Name = "btnProccess";
            this.btnProccess.Size = new System.Drawing.Size(147, 47);
            this.btnProccess.TabIndex = 0;
            this.btnProccess.Text = "Process";
            this.btnProccess.Click += new System.EventHandler(this.btnProccess_ClickAsync);
            // 
            // rtxData
            // 
            this.rtxData.Location = new System.Drawing.Point(42, 37);
            this.rtxData.Name = "rtxData";
            this.rtxData.Size = new System.Drawing.Size(732, 323);
            this.rtxData.TabIndex = 1;
            this.rtxData.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxData);
            this.Controls.Add(this.btnProccess);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnProccess;
        private System.Windows.Forms.RichTextBox rtxData;
    }
}

