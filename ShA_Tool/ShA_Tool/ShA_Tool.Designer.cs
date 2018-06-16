namespace ShA_Tool
{
    partial class ShA_Tool
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShA_Tool));
            this.ConnectBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.DisconnectBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.IpAdressTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NotifMsgTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SendNotificationBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveIPCheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.AttachBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.UnlimitedPrimaryAmmoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectBtn.Depth = 0;
            this.ConnectBtn.Icon = null;
            this.ConnectBtn.Location = new System.Drawing.Point(17, 175);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConnectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Primary = false;
            this.ConnectBtn.Size = new System.Drawing.Size(90, 34);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisconnectBtn.Depth = 0;
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Icon = null;
            this.DisconnectBtn.Location = new System.Drawing.Point(122, 175);
            this.DisconnectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DisconnectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Primary = false;
            this.DisconnectBtn.Size = new System.Drawing.Size(109, 34);
            this.DisconnectBtn.TabIndex = 1;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // IpAdressTxt
            // 
            this.IpAdressTxt.Depth = 0;
            this.IpAdressTxt.Hint = "IP Address..";
            this.IpAdressTxt.Location = new System.Drawing.Point(23, 77);
            this.IpAdressTxt.MaxLength = 32767;
            this.IpAdressTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.IpAdressTxt.Name = "IpAdressTxt";
            this.IpAdressTxt.PasswordChar = '\0';
            this.IpAdressTxt.ReadOnly = false;
            this.IpAdressTxt.SelectedText = "";
            this.IpAdressTxt.SelectionLength = 0;
            this.IpAdressTxt.SelectionStart = 0;
            this.IpAdressTxt.Size = new System.Drawing.Size(347, 23);
            this.IpAdressTxt.TabIndex = 2;
            this.IpAdressTxt.TabStop = false;
            this.IpAdressTxt.UseSystemPasswordChar = false;
            // 
            // NotifMsgTxt
            // 
            this.NotifMsgTxt.Depth = 0;
            this.NotifMsgTxt.Enabled = false;
            this.NotifMsgTxt.Hint = "Notification message..";
            this.NotifMsgTxt.Location = new System.Drawing.Point(23, 106);
            this.NotifMsgTxt.MaxLength = 32767;
            this.NotifMsgTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotifMsgTxt.Name = "NotifMsgTxt";
            this.NotifMsgTxt.PasswordChar = '\0';
            this.NotifMsgTxt.ReadOnly = false;
            this.NotifMsgTxt.SelectedText = "";
            this.NotifMsgTxt.SelectionLength = 0;
            this.NotifMsgTxt.SelectionStart = 0;
            this.NotifMsgTxt.Size = new System.Drawing.Size(347, 23);
            this.NotifMsgTxt.TabIndex = 3;
            this.NotifMsgTxt.TabStop = false;
            this.NotifMsgTxt.UseSystemPasswordChar = false;
            // 
            // SendNotificationBtn
            // 
            this.SendNotificationBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendNotificationBtn.Depth = 0;
            this.SendNotificationBtn.Enabled = false;
            this.SendNotificationBtn.Icon = null;
            this.SendNotificationBtn.Location = new System.Drawing.Point(240, 175);
            this.SendNotificationBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SendNotificationBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendNotificationBtn.Name = "SendNotificationBtn";
            this.SendNotificationBtn.Primary = false;
            this.SendNotificationBtn.Size = new System.Drawing.Size(155, 34);
            this.SendNotificationBtn.TabIndex = 4;
            this.SendNotificationBtn.Text = "Send notification";
            this.SendNotificationBtn.UseVisualStyleBackColor = true;
            this.SendNotificationBtn.Click += new System.EventHandler(this.SendNotificationBtn_Click);
            // 
            // SaveIPCheckbox
            // 
            this.SaveIPCheckbox.AutoSize = true;
            this.SaveIPCheckbox.Depth = 0;
            this.SaveIPCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.SaveIPCheckbox.Location = new System.Drawing.Point(17, 132);
            this.SaveIPCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.SaveIPCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SaveIPCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveIPCheckbox.Name = "SaveIPCheckbox";
            this.SaveIPCheckbox.Ripple = true;
            this.SaveIPCheckbox.Size = new System.Drawing.Size(130, 30);
            this.SaveIPCheckbox.TabIndex = 5;
            this.SaveIPCheckbox.Text = "Save IP Address";
            this.SaveIPCheckbox.UseVisualStyleBackColor = true;
            // 
            // AttachBtn
            // 
            this.AttachBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AttachBtn.Depth = 0;
            this.AttachBtn.Enabled = false;
            this.AttachBtn.Icon = null;
            this.AttachBtn.Location = new System.Drawing.Point(11, 18);
            this.AttachBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AttachBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Primary = false;
            this.AttachBtn.Size = new System.Drawing.Size(355, 34);
            this.AttachBtn.TabIndex = 6;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.UseVisualStyleBackColor = true;
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // UnlimitedPrimaryAmmoBtn
            // 
            this.UnlimitedPrimaryAmmoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnlimitedPrimaryAmmoBtn.Depth = 0;
            this.UnlimitedPrimaryAmmoBtn.Enabled = false;
            this.UnlimitedPrimaryAmmoBtn.ForeColor = System.Drawing.Color.Yellow;
            this.UnlimitedPrimaryAmmoBtn.Icon = null;
            this.UnlimitedPrimaryAmmoBtn.Location = new System.Drawing.Point(11, 64);
            this.UnlimitedPrimaryAmmoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnlimitedPrimaryAmmoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnlimitedPrimaryAmmoBtn.Name = "UnlimitedPrimaryAmmoBtn";
            this.UnlimitedPrimaryAmmoBtn.Primary = false;
            this.UnlimitedPrimaryAmmoBtn.Size = new System.Drawing.Size(355, 34);
            this.UnlimitedPrimaryAmmoBtn.TabIndex = 7;
            this.UnlimitedPrimaryAmmoBtn.Text = "Unlimited primary ammo";
            this.UnlimitedPrimaryAmmoBtn.UseVisualStyleBackColor = true;
            this.UnlimitedPrimaryAmmoBtn.Click += new System.EventHandler(this.UnlimitedPrimaryAmmoBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(-144, 146);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Status : ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(67, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(112, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Not connected.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(7, 218);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 208);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage5.Controls.Add(this.materialLabel3);
            this.tabPage5.Controls.Add(this.materialLabel2);
            this.tabPage5.Controls.Add(this.AttachBtn);
            this.tabPage5.Controls.Add(this.materialLabel1);
            this.tabPage5.Controls.Add(this.UnlimitedPrimaryAmmoBtn);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(380, 182);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "COD : MWR (1.11)";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(7, 149);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Status :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NEXT ART", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 11);
            this.label1.TabIndex = 10;
            this.label1.Text = "ShA_Dev - RG Release.";
            // 
            // ShA_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveIPCheckbox);
            this.Controls.Add(this.SendNotificationBtn);
            this.Controls.Add(this.NotifMsgTxt);
            this.Controls.Add(this.IpAdressTxt);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShA_Tool";
            this.Resizable = false;
            this.Text = "ShA - ToolBox";
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton ConnectBtn;
        private MaterialSkin.Controls.MaterialFlatButton DisconnectBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField IpAdressTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField NotifMsgTxt;
        private MaterialSkin.Controls.MaterialFlatButton SendNotificationBtn;
        private MaterialSkin.Controls.MaterialCheckBox SaveIPCheckbox;
        private MaterialSkin.Controls.MaterialFlatButton AttachBtn;
        private MaterialSkin.Controls.MaterialFlatButton UnlimitedPrimaryAmmoBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label label1;
    }
}

