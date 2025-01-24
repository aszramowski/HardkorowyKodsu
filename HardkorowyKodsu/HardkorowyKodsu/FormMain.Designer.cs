
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
            this.btnVersion = new DevExpress.XtraEditors.SimpleButton();
            this.btnTables = new DevExpress.XtraEditors.SimpleButton();
            this.btnColumns = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.tbcDatabaseInfo = new System.Windows.Forms.TabControl();
            this.tbpTables = new System.Windows.Forms.TabPage();
            this.grvTables = new System.Windows.Forms.DataGridView();
            this.tbpColumns = new System.Windows.Forms.TabPage();
            this.grvColumns = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tbcDatabaseInfo.SuspendLayout();
            this.tbpTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTables)).BeginInit();
            this.tbpColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVersion
            // 
            this.btnVersion.Location = new System.Drawing.Point(0, 50);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(132, 47);
            this.btnVersion.TabIndex = 0;
            this.btnVersion.Text = "Get version";
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // btnTables
            // 
            this.btnTables.Location = new System.Drawing.Point(0, 99);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(132, 47);
            this.btnTables.TabIndex = 2;
            this.btnTables.Text = "Get tables";
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnColumns
            // 
            this.btnColumns.Location = new System.Drawing.Point(0, 147);
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.Size = new System.Drawing.Size(132, 47);
            this.btnColumns.TabIndex = 3;
            this.btnColumns.Text = "Get columns";
            this.btnColumns.Click += new System.EventHandler(this.btnColumns_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxMessage);
            this.panel1.Controls.Add(this.btnVersion);
            this.panel1.Controls.Add(this.btnTables);
            this.panel1.Controls.Add(this.btnColumns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 516);
            this.panel1.TabIndex = 6;
            // 
            // rtxMessage
            // 
            this.rtxMessage.Location = new System.Drawing.Point(0, 3);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(132, 41);
            this.rtxMessage.TabIndex = 4;
            this.rtxMessage.Text = "";
            // 
            // tbcDatabaseInfo
            // 
            this.tbcDatabaseInfo.Controls.Add(this.tbpTables);
            this.tbcDatabaseInfo.Controls.Add(this.tbpColumns);
            this.tbcDatabaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcDatabaseInfo.Location = new System.Drawing.Point(132, 0);
            this.tbcDatabaseInfo.Name = "tbcDatabaseInfo";
            this.tbcDatabaseInfo.SelectedIndex = 0;
            this.tbcDatabaseInfo.Size = new System.Drawing.Size(842, 516);
            this.tbcDatabaseInfo.TabIndex = 7;
            // 
            // tbpTables
            // 
            this.tbpTables.Controls.Add(this.grvTables);
            this.tbpTables.Location = new System.Drawing.Point(4, 22);
            this.tbpTables.Name = "tbpTables";
            this.tbpTables.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTables.Size = new System.Drawing.Size(660, 424);
            this.tbpTables.TabIndex = 0;
            this.tbpTables.Text = "Tables";
            this.tbpTables.UseVisualStyleBackColor = true;
            // 
            // grvTables
            // 
            this.grvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTables.Location = new System.Drawing.Point(3, 3);
            this.grvTables.Name = "grvTables";
            this.grvTables.ReadOnly = true;
            this.grvTables.Size = new System.Drawing.Size(654, 418);
            this.grvTables.TabIndex = 0;
            // 
            // tbpColumns
            // 
            this.tbpColumns.Controls.Add(this.grvColumns);
            this.tbpColumns.Location = new System.Drawing.Point(4, 22);
            this.tbpColumns.Name = "tbpColumns";
            this.tbpColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tbpColumns.Size = new System.Drawing.Size(834, 490);
            this.tbpColumns.TabIndex = 1;
            this.tbpColumns.Text = "Columns";
            this.tbpColumns.UseVisualStyleBackColor = true;
            // 
            // grvColumns
            // 
            this.grvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvColumns.Location = new System.Drawing.Point(3, 3);
            this.grvColumns.Name = "grvColumns";
            this.grvColumns.ReadOnly = true;
            this.grvColumns.Size = new System.Drawing.Size(828, 484);
            this.grvColumns.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 516);
            this.Controls.Add(this.tbcDatabaseInfo);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "HardkorowyKodsu - new module for your drugstore";
            this.panel1.ResumeLayout(false);
            this.tbcDatabaseInfo.ResumeLayout(false);
            this.tbpTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTables)).EndInit();
            this.tbpColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnVersion;
        private DevExpress.XtraEditors.SimpleButton btnTables;
        private DevExpress.XtraEditors.SimpleButton btnColumns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbcDatabaseInfo;
        private System.Windows.Forms.TabPage tbpTables;
        private System.Windows.Forms.TabPage tbpColumns;
        private System.Windows.Forms.DataGridView grvColumns;
        private System.Windows.Forms.DataGridView grvTables;
        private System.Windows.Forms.RichTextBox rtxMessage;
    }
}

