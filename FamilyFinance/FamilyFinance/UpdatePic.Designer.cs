namespace FamilyFinance
{
    partial class UpdatePic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePic));
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(65, 61);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(300, 200);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 11;
            this.picbox.TabStop = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Image = global::FamilyFinance.Properties.Resources.删除_小_1;
            this.btnCancle.Location = new System.Drawing.Point(244, 277);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 10;
            this.btnCancle.Text = "关闭";
            this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.Image = global::FamilyFinance.Properties.Resources.添加_小_1;
            this.btnUpdatePic.Location = new System.Drawing.Point(89, 277);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePic.TabIndex = 9;
            this.btnUpdatePic.Text = "更新";
            this.btnUpdatePic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click_1);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(335, 19);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 8;
            this.btnPic.Text = "选择封面";
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click_1);
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(89, 21);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(230, 21);
            this.txtPic.TabIndex = 7;
            // 
            // lblPic
            // 
            this.lblPic.Location = new System.Drawing.Point(23, 24);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(60, 20);
            this.lblPic.TabIndex = 6;
            this.lblPic.Text = "封面路径";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // UpdatePic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 312);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnUpdatePic);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.lblPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "封面管理";
            this.Load += new System.EventHandler(this.UpdatePic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}