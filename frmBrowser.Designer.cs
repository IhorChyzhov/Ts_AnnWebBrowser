
namespace Ann_Browser
{
    partial class frmBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnHome = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnDownload = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtSearchOrUrl = new Bunifu.UI.WinForms.BunifuTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuToolTip2 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.imgRefresh = new Bunifu.UI.WinForms.BunifuImageButton();
            this.imgSpinner = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.Controls.Add(this.txtSearchOrUrl);
            this.bunifuCards1.Controls.Add(this.btnDownload);
            this.bunifuCards1.Controls.Add(this.btnSettings);
            this.bunifuCards1.Controls.Add(this.btnRefresh);
            this.bunifuCards1.Controls.Add(this.btnHome);
            this.bunifuCards1.Controls.Add(this.btnForward);
            this.bunifuCards1.Controls.Add(this.btnBack);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(4, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(927, 44);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.bunifuCards1, "");
            this.bunifuToolTip2.SetToolTip(this.bunifuCards1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCards1, null);
            this.bunifuToolTip2.SetToolTipIcon(this.bunifuCards1, null);
            this.bunifuToolTip2.SetToolTipTitle(this.bunifuCards1, "");
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCards1, "");
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = false;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = true;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Horizontal;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 55;
            this.btnBack.ImageSize = new System.Drawing.Size(-22, -22);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(8, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(33, 33);
            this.btnBack.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.btnBack, "back");
            this.bunifuToolTip2.SetToolTip(this.btnBack, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBack, null);
            this.bunifuToolTip2.SetToolTipIcon(this.btnBack, null);
            this.btnBack.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnBack, "");
            this.bunifuToolTip1.SetToolTipTitle(this.btnBack, "");
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 55;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.ActiveImage = null;
            this.btnForward.AllowAnimations = true;
            this.btnForward.AllowBuffering = false;
            this.btnForward.AllowToggling = false;
            this.btnForward.AllowZooming = false;
            this.btnForward.AllowZoomingOnFocus = false;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnForward.ErrorImage")));
            this.btnForward.FadeWhenInactive = true;
            this.btnForward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Horizontal;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageActive = null;
            this.btnForward.ImageLocation = null;
            this.btnForward.ImageMargin = 55;
            this.btnForward.ImageSize = new System.Drawing.Size(-22, -22);
            this.btnForward.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.btnForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnForward.InitialImage")));
            this.btnForward.Location = new System.Drawing.Point(47, 6);
            this.btnForward.Name = "btnForward";
            this.btnForward.Rotation = 0;
            this.btnForward.ShowActiveImage = true;
            this.btnForward.ShowCursorChanges = true;
            this.btnForward.ShowImageBorders = true;
            this.btnForward.ShowSizeMarkers = false;
            this.btnForward.Size = new System.Drawing.Size(33, 33);
            this.btnForward.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "forward");
            this.bunifuToolTip2.SetToolTip(this.btnForward, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnForward, null);
            this.bunifuToolTip2.SetToolTipIcon(this.btnForward, null);
            this.btnForward.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnForward, "");
            this.bunifuToolTip1.SetToolTipTitle(this.btnForward, "");
            this.btnForward.WaitOnLoad = false;
            this.btnForward.Zoom = 55;
            this.btnForward.ZoomSpeed = 10;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnHome
            // 
            this.btnHome.ActiveImage = null;
            this.btnHome.AllowAnimations = true;
            this.btnHome.AllowBuffering = false;
            this.btnHome.AllowToggling = false;
            this.btnHome.AllowZooming = false;
            this.btnHome.AllowZoomingOnFocus = false;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHome.ErrorImage")));
            this.btnHome.FadeWhenInactive = true;
            this.btnHome.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Vertical;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageActive = null;
            this.btnHome.ImageLocation = null;
            this.btnHome.ImageMargin = 55;
            this.btnHome.ImageSize = new System.Drawing.Size(-22, -22);
            this.btnHome.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.btnHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnHome.InitialImage")));
            this.btnHome.Location = new System.Drawing.Point(86, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Rotation = 0;
            this.btnHome.ShowActiveImage = true;
            this.btnHome.ShowCursorChanges = true;
            this.btnHome.ShowImageBorders = true;
            this.btnHome.ShowSizeMarkers = false;
            this.btnHome.Size = new System.Drawing.Size(33, 33);
            this.btnHome.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.btnHome, "home");
            this.bunifuToolTip2.SetToolTip(this.btnHome, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnHome, null);
            this.bunifuToolTip2.SetToolTipIcon(this.btnHome, null);
            this.btnHome.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnHome, "");
            this.bunifuToolTip1.SetToolTipTitle(this.btnHome, "");
            this.btnHome.WaitOnLoad = false;
            this.btnHome.Zoom = 55;
            this.btnHome.ZoomSpeed = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveImage = null;
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowBuffering = false;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.AllowZooming = false;
            this.btnRefresh.AllowZoomingOnFocus = false;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ErrorImage")));
            this.btnRefresh.FadeWhenInactive = true;
            this.btnRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.ImageLocation = null;
            this.btnRefresh.ImageMargin = 55;
            this.btnRefresh.ImageSize = new System.Drawing.Size(-22, -22);
            this.btnRefresh.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.btnRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.InitialImage")));
            this.btnRefresh.Location = new System.Drawing.Point(125, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Rotation = 0;
            this.btnRefresh.ShowActiveImage = true;
            this.btnRefresh.ShowCursorChanges = true;
            this.btnRefresh.ShowImageBorders = true;
            this.btnRefresh.ShowSizeMarkers = false;
            this.btnRefresh.Size = new System.Drawing.Size(33, 33);
            this.btnRefresh.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.btnRefresh, "Refresh");
            this.bunifuToolTip2.SetToolTip(this.btnRefresh, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnRefresh, null);
            this.bunifuToolTip2.SetToolTipIcon(this.btnRefresh, null);
            this.btnRefresh.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnRefresh, "");
            this.bunifuToolTip1.SetToolTipTitle(this.btnRefresh, "");
            this.btnRefresh.WaitOnLoad = false;
            this.btnRefresh.Zoom = 55;
            this.btnRefresh.ZoomSpeed = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ActiveImage = null;
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowBuffering = false;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.AllowZooming = false;
            this.btnSettings.AllowZoomingOnFocus = false;
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.ErrorImage")));
            this.btnSettings.FadeWhenInactive = true;
            this.btnSettings.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageActive = null;
            this.btnSettings.ImageLocation = null;
            this.btnSettings.ImageMargin = 60;
            this.btnSettings.ImageSize = new System.Drawing.Size(-27, -27);
            this.btnSettings.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.btnSettings.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.InitialImage")));
            this.btnSettings.Location = new System.Drawing.Point(885, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Rotation = 0;
            this.btnSettings.ShowActiveImage = true;
            this.btnSettings.ShowCursorChanges = true;
            this.btnSettings.ShowImageBorders = true;
            this.btnSettings.ShowSizeMarkers = false;
            this.btnSettings.Size = new System.Drawing.Size(33, 33);
            this.btnSettings.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.btnSettings, "Settings");
            this.bunifuToolTip2.SetToolTip(this.btnSettings, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSettings, null);
            this.bunifuToolTip2.SetToolTipIcon(this.btnSettings, null);
            this.btnSettings.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnSettings, "");
            this.bunifuToolTip1.SetToolTipTitle(this.btnSettings, "");
            this.btnSettings.WaitOnLoad = false;
            this.btnSettings.Zoom = 60;
            this.btnSettings.ZoomSpeed = 10;
            // 
            // btnDownload
            // 
            this.btnDownload.ActiveImage = null;
            this.btnDownload.AllowAnimations = true;
            this.btnDownload.AllowBuffering = false;
            this.btnDownload.AllowToggling = false;
            this.btnDownload.AllowZooming = false;
            this.btnDownload.AllowZoomingOnFocus = false;
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDownload.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDownload.ErrorImage")));
            this.btnDownload.FadeWhenInactive = true;
            this.btnDownload.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Vertical;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageActive = null;
            this.btnDownload.ImageLocation = null;
            this.btnDownload.ImageMargin = 60;
            this.btnDownload.ImageSize = new System.Drawing.Size(-27, -27);
            this.btnDownload.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.btnDownload.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDownload.InitialImage")));
            this.btnDownload.Location = new System.Drawing.Point(846, 6);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Rotation = 0;
            this.btnDownload.ShowActiveImage = true;
            this.btnDownload.ShowCursorChanges = true;
            this.btnDownload.ShowImageBorders = true;
            this.btnDownload.ShowSizeMarkers = false;
            this.btnDownload.Size = new System.Drawing.Size(33, 33);
            this.btnDownload.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.btnDownload, "Downloads");
            this.bunifuToolTip2.SetToolTip(this.btnDownload, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnDownload, null);
            this.bunifuToolTip2.SetToolTipIcon(this.btnDownload, null);
            this.btnDownload.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnDownload, "");
            this.bunifuToolTip1.SetToolTipTitle(this.btnDownload, "");
            this.btnDownload.WaitOnLoad = false;
            this.btnDownload.Zoom = 60;
            this.btnDownload.ZoomSpeed = 10;
            // 
            // txtSearchOrUrl
            // 
            this.txtSearchOrUrl.AcceptsReturn = false;
            this.txtSearchOrUrl.AcceptsTab = false;
            this.txtSearchOrUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchOrUrl.AnimationSpeed = 200;
            this.txtSearchOrUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchOrUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchOrUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchOrUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchOrUrl.BackgroundImage")));
            this.txtSearchOrUrl.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearchOrUrl.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearchOrUrl.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearchOrUrl.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearchOrUrl.BorderRadius = 20;
            this.txtSearchOrUrl.BorderThickness = 2;
            this.txtSearchOrUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchOrUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchOrUrl.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearchOrUrl.DefaultText = "";
            this.txtSearchOrUrl.FillColor = System.Drawing.Color.White;
            this.txtSearchOrUrl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchOrUrl.HideSelection = true;
            this.txtSearchOrUrl.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchOrUrl.IconLeft")));
            this.txtSearchOrUrl.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchOrUrl.IconPadding = 8;
            this.txtSearchOrUrl.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchOrUrl.IconRight")));
            this.txtSearchOrUrl.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchOrUrl.Lines = new string[0];
            this.txtSearchOrUrl.Location = new System.Drawing.Point(164, 8);
            this.txtSearchOrUrl.MaxLength = 32767;
            this.txtSearchOrUrl.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchOrUrl.Modified = false;
            this.txtSearchOrUrl.Multiline = false;
            this.txtSearchOrUrl.Name = "txtSearchOrUrl";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchOrUrl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchOrUrl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchOrUrl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchOrUrl.OnIdleState = stateProperties4;
            this.txtSearchOrUrl.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearchOrUrl.PasswordChar = '\0';
            this.txtSearchOrUrl.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchOrUrl.PlaceholderText = "Enter URL";
            this.txtSearchOrUrl.ReadOnly = false;
            this.txtSearchOrUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchOrUrl.SelectedText = "";
            this.txtSearchOrUrl.SelectionLength = 0;
            this.txtSearchOrUrl.SelectionStart = 0;
            this.txtSearchOrUrl.ShortcutsEnabled = true;
            this.txtSearchOrUrl.Size = new System.Drawing.Size(676, 29);
            this.txtSearchOrUrl.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearchOrUrl.TabIndex = 1;
            this.txtSearchOrUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchOrUrl.TextMarginBottom = 0;
            this.txtSearchOrUrl.TextMarginLeft = 5;
            this.txtSearchOrUrl.TextMarginTop = 1;
            this.txtSearchOrUrl.TextPlaceholder = "Enter URL";
            this.bunifuToolTip1.SetToolTip(this.txtSearchOrUrl, "");
            this.bunifuToolTip2.SetToolTip(this.txtSearchOrUrl, "");
            this.bunifuToolTip2.SetToolTipIcon(this.txtSearchOrUrl, null);
            this.bunifuToolTip1.SetToolTipIcon(this.txtSearchOrUrl, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtSearchOrUrl, "");
            this.bunifuToolTip2.SetToolTipTitle(this.txtSearchOrUrl, "");
            this.txtSearchOrUrl.UseSystemPasswordChar = false;
            this.txtSearchOrUrl.WordWrap = true;
            this.txtSearchOrUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchOrUrl_KeyUp);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(4, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(927, 433);
            this.webBrowser1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.webBrowser1, "");
            this.bunifuToolTip2.SetToolTip(this.webBrowser1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.webBrowser1, null);
            this.bunifuToolTip2.SetToolTipIcon(this.webBrowser1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.webBrowser1, "");
            this.bunifuToolTip2.SetToolTipTitle(this.webBrowser1, "");
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // bunifuToolTip2
            // 
            this.bunifuToolTip2.Active = true;
            this.bunifuToolTip2.AlignTextWithTitle = false;
            this.bunifuToolTip2.AllowAutoClose = false;
            this.bunifuToolTip2.AllowFading = true;
            this.bunifuToolTip2.AutoCloseDuration = 5000;
            this.bunifuToolTip2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip2.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip2.ClickToShowDisplayControl = false;
            this.bunifuToolTip2.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip2.DisplayControl = null;
            this.bunifuToolTip2.EntryAnimationSpeed = 350;
            this.bunifuToolTip2.ExitAnimationSpeed = 200;
            this.bunifuToolTip2.GenerateAutoCloseDuration = false;
            this.bunifuToolTip2.IconMargin = 6;
            this.bunifuToolTip2.InitialDelay = 0;
            this.bunifuToolTip2.Name = "bunifuToolTip2";
            this.bunifuToolTip2.Opacity = 1D;
            this.bunifuToolTip2.OverrideToolTipTitles = false;
            this.bunifuToolTip2.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip2.ReshowDelay = 100;
            this.bunifuToolTip2.ShowAlways = true;
            this.bunifuToolTip2.ShowBorders = false;
            this.bunifuToolTip2.ShowIcons = true;
            this.bunifuToolTip2.ShowShadows = true;
            this.bunifuToolTip2.Tag = null;
            this.bunifuToolTip2.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip2.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip2.TextMargin = 2;
            this.bunifuToolTip2.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip2.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip2.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip2.ToolTipTitle = null;
            // 
            // imgRefresh
            // 
            this.imgRefresh.ActiveImage = null;
            this.imgRefresh.AllowAnimations = true;
            this.imgRefresh.AllowBuffering = false;
            this.imgRefresh.AllowToggling = false;
            this.imgRefresh.AllowZooming = false;
            this.imgRefresh.AllowZoomingOnFocus = false;
            this.imgRefresh.BackColor = System.Drawing.Color.Transparent;
            this.imgRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imgRefresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgRefresh.ErrorImage")));
            this.imgRefresh.FadeWhenInactive = true;
            this.imgRefresh.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgRefresh.Image")));
            this.imgRefresh.ImageActive = null;
            this.imgRefresh.ImageLocation = null;
            this.imgRefresh.ImageMargin = 55;
            this.imgRefresh.ImageSize = new System.Drawing.Size(-22, -22);
            this.imgRefresh.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.imgRefresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgRefresh.InitialImage")));
            this.imgRefresh.Location = new System.Drawing.Point(31, 425);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Rotation = 0;
            this.imgRefresh.ShowActiveImage = true;
            this.imgRefresh.ShowCursorChanges = true;
            this.imgRefresh.ShowImageBorders = true;
            this.imgRefresh.ShowSizeMarkers = false;
            this.imgRefresh.Size = new System.Drawing.Size(33, 33);
            this.imgRefresh.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.imgRefresh, "Refresh");
            this.bunifuToolTip2.SetToolTip(this.imgRefresh, "");
            this.bunifuToolTip1.SetToolTipIcon(this.imgRefresh, null);
            this.bunifuToolTip2.SetToolTipIcon(this.imgRefresh, null);
            this.imgRefresh.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.imgRefresh, "");
            this.bunifuToolTip1.SetToolTipTitle(this.imgRefresh, "");
            this.imgRefresh.Visible = false;
            this.imgRefresh.WaitOnLoad = false;
            this.imgRefresh.Zoom = 55;
            this.imgRefresh.ZoomSpeed = 10;
            // 
            // imgSpinner
            // 
            this.imgSpinner.ActiveImage = null;
            this.imgSpinner.AllowAnimations = true;
            this.imgSpinner.AllowBuffering = false;
            this.imgSpinner.AllowToggling = false;
            this.imgSpinner.AllowZooming = true;
            this.imgSpinner.AllowZoomingOnFocus = false;
            this.imgSpinner.BackColor = System.Drawing.Color.Transparent;
            this.imgSpinner.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imgSpinner.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgSpinner.ErrorImage")));
            this.imgSpinner.FadeWhenInactive = false;
            this.imgSpinner.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgSpinner.Image = ((System.Drawing.Image)(resources.GetObject("imgSpinner.Image")));
            this.imgSpinner.ImageActive = null;
            this.imgSpinner.ImageLocation = null;
            this.imgSpinner.ImageMargin = 55;
            this.imgSpinner.ImageSize = new System.Drawing.Size(-22, -22);
            this.imgSpinner.ImageZoomSize = new System.Drawing.Size(33, 33);
            this.imgSpinner.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgSpinner.InitialImage")));
            this.imgSpinner.Location = new System.Drawing.Point(70, 425);
            this.imgSpinner.Name = "imgSpinner";
            this.imgSpinner.Rotation = 0;
            this.imgSpinner.ShowActiveImage = true;
            this.imgSpinner.ShowCursorChanges = true;
            this.imgSpinner.ShowImageBorders = true;
            this.imgSpinner.ShowSizeMarkers = false;
            this.imgSpinner.Size = new System.Drawing.Size(33, 33);
            this.imgSpinner.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.imgSpinner, "Refresh");
            this.bunifuToolTip2.SetToolTip(this.imgSpinner, "");
            this.bunifuToolTip1.SetToolTipIcon(this.imgSpinner, null);
            this.bunifuToolTip2.SetToolTipIcon(this.imgSpinner, null);
            this.imgSpinner.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.imgSpinner, "");
            this.bunifuToolTip1.SetToolTipTitle(this.imgSpinner, "");
            this.imgSpinner.Visible = false;
            this.imgSpinner.WaitOnLoad = false;
            this.imgSpinner.Zoom = 55;
            this.imgSpinner.ZoomSpeed = 10;
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(934, 483);
            this.Controls.Add(this.imgSpinner);
            this.Controls.Add(this.imgRefresh);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.Text = "frmBrowser";
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuImageButton btnDownload;
        private Bunifu.UI.WinForms.BunifuImageButton btnSettings;
        private Bunifu.UI.WinForms.BunifuImageButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton btnHome;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchOrUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip2;
        private Bunifu.UI.WinForms.BunifuImageButton imgRefresh;
        private Bunifu.UI.WinForms.BunifuImageButton imgSpinner;
    }
}