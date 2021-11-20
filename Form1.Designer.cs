namespace DiscordCacheViewer
{
    partial class frm_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvw_thumbnails = new System.Windows.Forms.ListView();
            this.btn_restore = new System.Windows.Forms.Button();
            this.txt_cachePath = new System.Windows.Forms.TextBox();
            this.lbl_cachePath = new System.Windows.Forms.Label();
            this.lbl_savePath = new System.Windows.Forms.Label();
            this.pnl_cachePath = new System.Windows.Forms.Panel();
            this.pnl_savePath = new System.Windows.Forms.Panel();
            this.txt_savePath = new System.Windows.Forms.TextBox();
            this.btn_browseCachePath = new System.Windows.Forms.Button();
            this.btn_browseSavePath = new System.Windows.Forms.Button();
            this.lbl_noImagesFound = new System.Windows.Forms.Label();
            this.pnl_cachePath.SuspendLayout();
            this.pnl_savePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvw_thumbnails
            // 
            this.lvw_thumbnails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.lvw_thumbnails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvw_thumbnails.Location = new System.Drawing.Point(12, 11);
            this.lvw_thumbnails.Name = "lvw_thumbnails";
            this.lvw_thumbnails.Size = new System.Drawing.Size(541, 438);
            this.lvw_thumbnails.TabIndex = 1;
            this.lvw_thumbnails.UseCompatibleStateImageBehavior = false;
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_restore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btn_restore.FlatAppearance.BorderSize = 0;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_restore.ForeColor = System.Drawing.Color.White;
            this.btn_restore.Location = new System.Drawing.Point(559, 354);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(105, 95);
            this.btn_restore.TabIndex = 2;
            this.btn_restore.Text = "Restore selected images";
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // txt_cachePath
            // 
            this.txt_cachePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txt_cachePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cachePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_cachePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.txt_cachePath.Location = new System.Drawing.Point(0, 3);
            this.txt_cachePath.Name = "txt_cachePath";
            this.txt_cachePath.Size = new System.Drawing.Size(395, 18);
            this.txt_cachePath.TabIndex = 4;
            this.txt_cachePath.Text = "If this is empty something is wrong";
            // 
            // lbl_cachePath
            // 
            this.lbl_cachePath.AutoSize = true;
            this.lbl_cachePath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cachePath.ForeColor = System.Drawing.Color.White;
            this.lbl_cachePath.Location = new System.Drawing.Point(12, 457);
            this.lbl_cachePath.Name = "lbl_cachePath";
            this.lbl_cachePath.Size = new System.Drawing.Size(140, 19);
            this.lbl_cachePath.TabIndex = 5;
            this.lbl_cachePath.Text = "Discord Cache Path";
            // 
            // lbl_savePath
            // 
            this.lbl_savePath.AutoSize = true;
            this.lbl_savePath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_savePath.ForeColor = System.Drawing.Color.White;
            this.lbl_savePath.Location = new System.Drawing.Point(12, 486);
            this.lbl_savePath.Name = "lbl_savePath";
            this.lbl_savePath.Size = new System.Drawing.Size(129, 19);
            this.lbl_savePath.TabIndex = 6;
            this.lbl_savePath.Text = "Path to Save Files";
            // 
            // pnl_cachePath
            // 
            this.pnl_cachePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.pnl_cachePath.Controls.Add(this.txt_cachePath);
            this.pnl_cachePath.Location = new System.Drawing.Point(158, 455);
            this.pnl_cachePath.Name = "pnl_cachePath";
            this.pnl_cachePath.Size = new System.Drawing.Size(395, 24);
            this.pnl_cachePath.TabIndex = 7;
            // 
            // pnl_savePath
            // 
            this.pnl_savePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.pnl_savePath.Controls.Add(this.txt_savePath);
            this.pnl_savePath.Location = new System.Drawing.Point(158, 483);
            this.pnl_savePath.Name = "pnl_savePath";
            this.pnl_savePath.Size = new System.Drawing.Size(395, 24);
            this.pnl_savePath.TabIndex = 8;
            // 
            // txt_savePath
            // 
            this.txt_savePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txt_savePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_savePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_savePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.txt_savePath.Location = new System.Drawing.Point(0, 3);
            this.txt_savePath.Name = "txt_savePath";
            this.txt_savePath.Size = new System.Drawing.Size(395, 18);
            this.txt_savePath.TabIndex = 4;
            this.txt_savePath.Text = "If this is empty something is wrong";
            // 
            // btn_browseCachePath
            // 
            this.btn_browseCachePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btn_browseCachePath.FlatAppearance.BorderSize = 0;
            this.btn_browseCachePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browseCachePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_browseCachePath.Location = new System.Drawing.Point(559, 455);
            this.btn_browseCachePath.Name = "btn_browseCachePath";
            this.btn_browseCachePath.Size = new System.Drawing.Size(105, 24);
            this.btn_browseCachePath.TabIndex = 9;
            this.btn_browseCachePath.Text = "Browse";
            this.btn_browseCachePath.UseVisualStyleBackColor = false;
            this.btn_browseCachePath.Click += new System.EventHandler(this.btn_browseCachePath_Click);
            // 
            // btn_browseSavePath
            // 
            this.btn_browseSavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.btn_browseSavePath.FlatAppearance.BorderSize = 0;
            this.btn_browseSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browseSavePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_browseSavePath.Location = new System.Drawing.Point(559, 483);
            this.btn_browseSavePath.Name = "btn_browseSavePath";
            this.btn_browseSavePath.Size = new System.Drawing.Size(105, 24);
            this.btn_browseSavePath.TabIndex = 10;
            this.btn_browseSavePath.Text = "Browse";
            this.btn_browseSavePath.UseVisualStyleBackColor = false;
            this.btn_browseSavePath.Click += new System.EventHandler(this.btn_browseSavePath_Click);
            // 
            // lbl_noImagesFound
            // 
            this.lbl_noImagesFound.AutoSize = true;
            this.lbl_noImagesFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.lbl_noImagesFound.Font = new System.Drawing.Font("Segoe UI Semibold", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_noImagesFound.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_noImagesFound.Location = new System.Drawing.Point(163, 209);
            this.lbl_noImagesFound.Name = "lbl_noImagesFound";
            this.lbl_noImagesFound.Size = new System.Drawing.Size(228, 37);
            this.lbl_noImagesFound.TabIndex = 11;
            this.lbl_noImagesFound.Text = "No images found";
            this.lbl_noImagesFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_noImagesFound.Visible = false;
            // 
            // frm_main
            // 
            this.AcceptButton = this.btn_restore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(671, 518);
            this.Controls.Add(this.lbl_noImagesFound);
            this.Controls.Add(this.btn_browseSavePath);
            this.Controls.Add(this.btn_browseCachePath);
            this.Controls.Add(this.pnl_savePath);
            this.Controls.Add(this.pnl_cachePath);
            this.Controls.Add(this.lbl_savePath);
            this.Controls.Add(this.lbl_cachePath);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.lvw_thumbnails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Cache Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_cachePath.ResumeLayout(false);
            this.pnl_cachePath.PerformLayout();
            this.pnl_savePath.ResumeLayout(false);
            this.pnl_savePath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvw_thumbnails;
        private Button btn_restore;
        private TextBox txt_cachePath;
        private Label lbl_cachePath;
        private Label lbl_savePath;
        private Panel pnl_cachePath;
        private Panel pnl_savePath;
        private TextBox txt_savePath;
        private Button btn_browseCachePath;
        private Button btn_browseSavePath;
        private Label lbl_noImagesFound;
    }
}