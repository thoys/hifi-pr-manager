namespace HiFi_PR_Manager
{
    partial class Form1
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
            this.dgvHifiPRInstallers = new System.Windows.Forms.DataGridView();
            this.btnUninstallSingle = new System.Windows.Forms.Button();
            this.btnUninstallAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHifiPRInstallers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHifiPRInstallers
            // 
            this.dgvHifiPRInstallers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHifiPRInstallers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHifiPRInstallers.Location = new System.Drawing.Point(12, 12);
            this.dgvHifiPRInstallers.Name = "dgvHifiPRInstallers";
            this.dgvHifiPRInstallers.ReadOnly = true;
            this.dgvHifiPRInstallers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHifiPRInstallers.Size = new System.Drawing.Size(900, 417);
            this.dgvHifiPRInstallers.TabIndex = 0;
            this.dgvHifiPRInstallers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHifiPRInstallers_CellContentClick);
            // 
            // btnUninstallSingle
            // 
            this.btnUninstallSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstallSingle.Location = new System.Drawing.Point(618, 448);
            this.btnUninstallSingle.Name = "btnUninstallSingle";
            this.btnUninstallSingle.Size = new System.Drawing.Size(144, 51);
            this.btnUninstallSingle.TabIndex = 1;
            this.btnUninstallSingle.Text = "Uninstall Selected PR Build";
            this.btnUninstallSingle.UseVisualStyleBackColor = true;
            this.btnUninstallSingle.Click += new System.EventHandler(this.btnUninstallSingle_Click);
            // 
            // btnUninstallAll
            // 
            this.btnUninstallAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstallAll.Location = new System.Drawing.Point(768, 448);
            this.btnUninstallAll.Name = "btnUninstallAll";
            this.btnUninstallAll.Size = new System.Drawing.Size(144, 51);
            this.btnUninstallAll.TabIndex = 2;
            this.btnUninstallAll.Text = "Uninstall all PR Builds";
            this.btnUninstallAll.UseVisualStyleBackColor = true;
            this.btnUninstallAll.Click += new System.EventHandler(this.btnUninstallAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 435);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 25);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 511);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUninstallAll);
            this.Controls.Add(this.btnUninstallSingle);
            this.Controls.Add(this.dgvHifiPRInstallers);
            this.Name = "Form1";
            this.Text = "HiFi-PR-Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHifiPRInstallers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHifiPRInstallers;
        private System.Windows.Forms.Button btnUninstallSingle;
        private System.Windows.Forms.Button btnUninstallAll;
        private System.Windows.Forms.Button btnRefresh;
    }
}

