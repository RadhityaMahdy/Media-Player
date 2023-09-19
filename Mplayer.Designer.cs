namespace Media_Player
{
    partial class Mplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mplayer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlaylist = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.indicator = new Bunifu.UI.WinForms.BunifuShapes();
            this.btnPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuShapes2 = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.bunifuPages2 = new System.Windows.Forms.TabPage();
            this.btnAddPlaylist = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddVideo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnMute = new Bunifu.UI.WinForms.BunifuImageButton();
            this.volume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnFastforward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPause = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBackward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.bunifuPages2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.bunifuPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.pictureBox2);
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Controls.Add(this.btnPlaylist);
            this.bunifuPanel1.Controls.Add(this.indicator);
            this.bunifuPanel1.Controls.Add(this.btnPlaying);
            this.bunifuPanel1.Controls.Add(this.bunifuShapes2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(193, 461);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Media_Player.Properties.Resources.Ndugal_Player_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(41, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Media_Player.Properties.Resources.logo_nd;
            this.pictureBox1.Location = new System.Drawing.Point(70, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.AllowAnimations = true;
            this.btnPlaylist.AllowMouseEffects = true;
            this.btnPlaylist.AllowToggling = true;
            this.btnPlaylist.AnimationSpeed = 200;
            this.btnPlaylist.AutoGenerateColors = false;
            this.btnPlaylist.AutoRoundBorders = false;
            this.btnPlaylist.AutoSizeLeftIcon = true;
            this.btnPlaylist.AutoSizeRightIcon = true;
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.BackColor1 = System.Drawing.Color.Transparent;
            this.btnPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.BackgroundImage")));
            this.btnPlaylist.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.ButtonText = "On Play";
            this.btnPlaylist.ButtonTextMarginLeft = 0;
            this.btnPlaylist.ColorContrastOnClick = 45;
            this.btnPlaylist.ColorContrastOnHover = 45;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPlaylist.CustomizableEdges = borderEdges1;
            this.btnPlaylist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaylist.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaylist.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaylist.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaylist.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnPlaylist.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaylist.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlaylist.IconMarginLeft = 11;
            this.btnPlaylist.IconPadding = 10;
            this.btnPlaylist.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaylist.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaylist.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlaylist.IconSize = 25;
            this.btnPlaylist.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.IdleBorderRadius = 1;
            this.btnPlaylist.IdleBorderThickness = 1;
            this.btnPlaylist.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.IdleIconLeftImage = null;
            this.btnPlaylist.IdleIconRightImage = null;
            this.btnPlaylist.IndicateFocus = true;
            this.btnPlaylist.Location = new System.Drawing.Point(59, 210);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaylist.OnDisabledState.BorderRadius = 1;
            this.btnPlaylist.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.OnDisabledState.BorderThickness = 1;
            this.btnPlaylist.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaylist.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaylist.OnDisabledState.IconLeftImage = null;
            this.btnPlaylist.OnDisabledState.IconRightImage = null;
            this.btnPlaylist.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.onHoverState.BorderRadius = 1;
            this.btnPlaylist.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.onHoverState.BorderThickness = 1;
            this.btnPlaylist.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.onHoverState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnPlaylist.onHoverState.IconLeftImage = null;
            this.btnPlaylist.onHoverState.IconRightImage = null;
            this.btnPlaylist.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnIdleState.BorderRadius = 1;
            this.btnPlaylist.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.OnIdleState.BorderThickness = 1;
            this.btnPlaylist.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnPlaylist.OnIdleState.IconLeftImage = null;
            this.btnPlaylist.OnIdleState.IconRightImage = null;
            this.btnPlaylist.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnPressedState.BorderRadius = 1;
            this.btnPlaylist.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.OnPressedState.BorderThickness = 1;
            this.btnPlaylist.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnPressedState.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnPlaylist.OnPressedState.IconLeftImage = null;
            this.btnPlaylist.OnPressedState.IconRightImage = null;
            this.btnPlaylist.Size = new System.Drawing.Size(56, 23);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaylist.TextMarginLeft = 0;
            this.btnPlaylist.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPlaylist.UseDefaultRadiusAndThickness = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // indicator
            // 
            this.indicator.Angle = 0F;
            this.indicator.BackColor = System.Drawing.Color.Transparent;
            this.indicator.BorderColor = System.Drawing.Color.MediumPurple;
            this.indicator.BorderThickness = 2;
            this.indicator.FillColor = System.Drawing.Color.Transparent;
            this.indicator.FillShape = true;
            this.indicator.Location = new System.Drawing.Point(44, 174);
            this.indicator.Name = "indicator";
            this.indicator.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.indicator.Sides = 5;
            this.indicator.Size = new System.Drawing.Size(13, 13);
            this.indicator.TabIndex = 0;
            this.indicator.Text = "bunifuShapes1";
            // 
            // btnPlaying
            // 
            this.btnPlaying.AllowAnimations = true;
            this.btnPlaying.AllowMouseEffects = true;
            this.btnPlaying.AllowToggling = true;
            this.btnPlaying.AnimationSpeed = 200;
            this.btnPlaying.AutoGenerateColors = false;
            this.btnPlaying.AutoRoundBorders = false;
            this.btnPlaying.AutoSizeLeftIcon = true;
            this.btnPlaying.AutoSizeRightIcon = true;
            this.btnPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaying.BackColor1 = System.Drawing.Color.Transparent;
            this.btnPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaying.BackgroundImage")));
            this.btnPlaying.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.ButtonText = "Playlist";
            this.btnPlaying.ButtonTextMarginLeft = 0;
            this.btnPlaying.ColorContrastOnClick = 45;
            this.btnPlaying.ColorContrastOnHover = 45;
            this.btnPlaying.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPlaying.CustomizableEdges = borderEdges2;
            this.btnPlaying.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaying.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaying.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaying.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaying.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlaying.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnPlaying.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaying.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaying.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlaying.IconMarginLeft = 11;
            this.btnPlaying.IconPadding = 10;
            this.btnPlaying.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaying.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaying.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlaying.IconSize = 25;
            this.btnPlaying.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPlaying.IdleBorderRadius = 1;
            this.btnPlaying.IdleBorderThickness = 1;
            this.btnPlaying.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPlaying.IdleIconLeftImage = null;
            this.btnPlaying.IdleIconRightImage = null;
            this.btnPlaying.IndicateFocus = true;
            this.btnPlaying.Location = new System.Drawing.Point(61, 171);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaying.OnDisabledState.BorderRadius = 1;
            this.btnPlaying.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnDisabledState.BorderThickness = 1;
            this.btnPlaying.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaying.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaying.OnDisabledState.IconLeftImage = null;
            this.btnPlaying.OnDisabledState.IconRightImage = null;
            this.btnPlaying.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaying.onHoverState.BorderRadius = 1;
            this.btnPlaying.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.onHoverState.BorderThickness = 1;
            this.btnPlaying.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaying.onHoverState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnPlaying.onHoverState.IconLeftImage = null;
            this.btnPlaying.onHoverState.IconRightImage = null;
            this.btnPlaying.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaying.OnIdleState.BorderRadius = 1;
            this.btnPlaying.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnIdleState.BorderThickness = 1;
            this.btnPlaying.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaying.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnPlaying.OnIdleState.IconLeftImage = null;
            this.btnPlaying.OnIdleState.IconRightImage = null;
            this.btnPlaying.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaying.OnPressedState.BorderRadius = 1;
            this.btnPlaying.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnPressedState.BorderThickness = 1;
            this.btnPlaying.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaying.OnPressedState.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnPlaying.OnPressedState.IconLeftImage = null;
            this.btnPlaying.OnPressedState.IconRightImage = null;
            this.btnPlaying.Size = new System.Drawing.Size(56, 23);
            this.btnPlaying.TabIndex = 3;
            this.btnPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaying.TextMarginLeft = 0;
            this.btnPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPlaying.UseDefaultRadiusAndThickness = true;
            this.btnPlaying.Click += new System.EventHandler(this.btnPlaying_Click);
            // 
            // bunifuShapes2
            // 
            this.bunifuShapes2.Angle = 90F;
            this.bunifuShapes2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.bunifuShapes2.BorderThickness = 1;
            this.bunifuShapes2.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.FillShape = true;
            this.bunifuShapes2.Location = new System.Drawing.Point(37, 177);
            this.bunifuShapes2.Name = "bunifuShapes2";
            this.bunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes2.Sides = 5;
            this.bunifuShapes2.Size = new System.Drawing.Size(27, 49);
            this.bunifuShapes2.TabIndex = 0;
            this.bunifuShapes2.Text = "bunifuShapes2";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel2.Controls.Add(this.btnClose);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(193, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(476, 43);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.MediumPurple;
            this.bunifuLabel1.Location = new System.Drawing.Point(15, 14);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(117, 15);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Sound Title - Playing";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 0;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(440, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 0;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.bunifuPages1);
            this.bunifuPanel3.Controls.Add(this.bunifuPanel4);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel3.Location = new System.Drawing.Point(193, 43);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(476, 418);
            this.bunifuPanel3.TabIndex = 2;
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = false;
            this.bunifuPages1.Controls.Add(this.bunifuPages2);
            this.bunifuPages1.Controls.Add(this.tabPage1);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabPage1;
            this.bunifuPages1.PageIndex = 1;
            this.bunifuPages1.PageName = "tabPage1";
            this.bunifuPages1.PageTitle = "ON Playing";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(476, 375);
            this.bunifuPages1.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // bunifuPages2
            // 
            this.bunifuPages2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bunifuPages2.Controls.Add(this.btnAddPlaylist);
            this.bunifuPages2.Controls.Add(this.listBox1);
            this.bunifuPages2.Location = new System.Drawing.Point(4, 4);
            this.bunifuPages2.Name = "bunifuPages2";
            this.bunifuPages2.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuPages2.Size = new System.Drawing.Size(468, 349);
            this.bunifuPages2.TabIndex = 1;
            this.bunifuPages2.Text = "Playlist";
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.AllowAnimations = true;
            this.btnAddPlaylist.AllowMouseEffects = true;
            this.btnAddPlaylist.AllowToggling = false;
            this.btnAddPlaylist.AnimationSpeed = 200;
            this.btnAddPlaylist.AutoGenerateColors = false;
            this.btnAddPlaylist.AutoRoundBorders = false;
            this.btnAddPlaylist.AutoSizeLeftIcon = true;
            this.btnAddPlaylist.AutoSizeRightIcon = true;
            this.btnAddPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.BackColor1 = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPlaylist.BackgroundImage")));
            this.btnAddPlaylist.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPlaylist.ButtonText = "Add Playlist";
            this.btnAddPlaylist.ButtonTextMarginLeft = 0;
            this.btnAddPlaylist.ColorContrastOnClick = 45;
            this.btnAddPlaylist.ColorContrastOnHover = 45;
            this.btnAddPlaylist.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAddPlaylist.CustomizableEdges = borderEdges3;
            this.btnAddPlaylist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPlaylist.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddPlaylist.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddPlaylist.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlaylist.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddPlaylist.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPlaylist.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddPlaylist.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddPlaylist.IconMarginLeft = 11;
            this.btnAddPlaylist.IconPadding = 10;
            this.btnAddPlaylist.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPlaylist.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddPlaylist.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddPlaylist.IconSize = 25;
            this.btnAddPlaylist.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.IdleBorderRadius = 1;
            this.btnAddPlaylist.IdleBorderThickness = 1;
            this.btnAddPlaylist.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.IdleIconLeftImage = null;
            this.btnAddPlaylist.IdleIconRightImage = null;
            this.btnAddPlaylist.IndicateFocus = false;
            this.btnAddPlaylist.Location = new System.Drawing.Point(3, 5);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.OnDisabledState.BorderRadius = 1;
            this.btnAddPlaylist.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPlaylist.OnDisabledState.BorderThickness = 1;
            this.btnAddPlaylist.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddPlaylist.OnDisabledState.IconLeftImage = null;
            this.btnAddPlaylist.OnDisabledState.IconRightImage = null;
            this.btnAddPlaylist.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.onHoverState.BorderRadius = 1;
            this.btnAddPlaylist.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPlaylist.onHoverState.BorderThickness = 1;
            this.btnAddPlaylist.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.onHoverState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnAddPlaylist.onHoverState.IconLeftImage = null;
            this.btnAddPlaylist.onHoverState.IconRightImage = null;
            this.btnAddPlaylist.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.OnIdleState.BorderRadius = 1;
            this.btnAddPlaylist.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPlaylist.OnIdleState.BorderThickness = 1;
            this.btnAddPlaylist.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.OnIdleState.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddPlaylist.OnIdleState.IconLeftImage = null;
            this.btnAddPlaylist.OnIdleState.IconRightImage = null;
            this.btnAddPlaylist.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.OnPressedState.BorderRadius = 1;
            this.btnAddPlaylist.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPlaylist.OnPressedState.BorderThickness = 1;
            this.btnAddPlaylist.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.OnPressedState.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddPlaylist.OnPressedState.IconLeftImage = null;
            this.btnAddPlaylist.OnPressedState.IconRightImage = null;
            this.btnAddPlaylist.Size = new System.Drawing.Size(108, 22);
            this.btnAddPlaylist.TabIndex = 1;
            this.btnAddPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPlaylist.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddPlaylist.TextMarginLeft = 0;
            this.btnAddPlaylist.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddPlaylist.UseDefaultRadiusAndThickness = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.listBox1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(2, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(463, 304);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabPage1.Controls.Add(this.btnAddVideo);
            this.tabPage1.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ON Playing";
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.AllowAnimations = true;
            this.btnAddVideo.AllowMouseEffects = true;
            this.btnAddVideo.AllowToggling = false;
            this.btnAddVideo.AnimationSpeed = 200;
            this.btnAddVideo.AutoGenerateColors = false;
            this.btnAddVideo.AutoRoundBorders = false;
            this.btnAddVideo.AutoSizeLeftIcon = true;
            this.btnAddVideo.AutoSizeRightIcon = true;
            this.btnAddVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVideo.BackColor1 = System.Drawing.Color.Transparent;
            this.btnAddVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVideo.BackgroundImage")));
            this.btnAddVideo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVideo.ButtonText = "Add Video";
            this.btnAddVideo.ButtonTextMarginLeft = 0;
            this.btnAddVideo.ColorContrastOnClick = 45;
            this.btnAddVideo.ColorContrastOnHover = 45;
            this.btnAddVideo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnAddVideo.CustomizableEdges = borderEdges4;
            this.btnAddVideo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddVideo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddVideo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddVideo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddVideo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddVideo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVideo.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddVideo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVideo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddVideo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddVideo.IconMarginLeft = 11;
            this.btnAddVideo.IconPadding = 10;
            this.btnAddVideo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddVideo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddVideo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddVideo.IconSize = 25;
            this.btnAddVideo.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAddVideo.IdleBorderRadius = 1;
            this.btnAddVideo.IdleBorderThickness = 1;
            this.btnAddVideo.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAddVideo.IdleIconLeftImage = null;
            this.btnAddVideo.IdleIconRightImage = null;
            this.btnAddVideo.IndicateFocus = false;
            this.btnAddVideo.Location = new System.Drawing.Point(8, 6);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddVideo.OnDisabledState.BorderRadius = 1;
            this.btnAddVideo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVideo.OnDisabledState.BorderThickness = 1;
            this.btnAddVideo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddVideo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddVideo.OnDisabledState.IconLeftImage = null;
            this.btnAddVideo.OnDisabledState.IconRightImage = null;
            this.btnAddVideo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddVideo.onHoverState.BorderRadius = 1;
            this.btnAddVideo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVideo.onHoverState.BorderThickness = 1;
            this.btnAddVideo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddVideo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddVideo.onHoverState.IconLeftImage = null;
            this.btnAddVideo.onHoverState.IconRightImage = null;
            this.btnAddVideo.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddVideo.OnIdleState.BorderRadius = 1;
            this.btnAddVideo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVideo.OnIdleState.BorderThickness = 1;
            this.btnAddVideo.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddVideo.OnIdleState.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddVideo.OnIdleState.IconLeftImage = null;
            this.btnAddVideo.OnIdleState.IconRightImage = null;
            this.btnAddVideo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddVideo.OnPressedState.BorderRadius = 1;
            this.btnAddVideo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddVideo.OnPressedState.BorderThickness = 1;
            this.btnAddVideo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddVideo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddVideo.OnPressedState.IconLeftImage = null;
            this.btnAddVideo.OnPressedState.IconRightImage = null;
            this.btnAddVideo.Size = new System.Drawing.Size(80, 21);
            this.btnAddVideo.TabIndex = 1;
            this.btnAddVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVideo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddVideo.TextMarginLeft = 0;
            this.btnAddVideo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddVideo.UseDefaultRadiusAndThickness = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 33);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(459, 310);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.label1);
            this.bunifuPanel4.Controls.Add(this.lblTimer);
            this.bunifuPanel4.Controls.Add(this.btnMute);
            this.bunifuPanel4.Controls.Add(this.volume);
            this.bunifuPanel4.Controls.Add(this.btnFastforward);
            this.bunifuPanel4.Controls.Add(this.btnPause);
            this.bunifuPanel4.Controls.Add(this.btnPlay);
            this.bunifuPanel4.Controls.Add(this.btnBackward);
            this.bunifuPanel4.Controls.Add(this.bunifuHSlider1);
            this.bunifuPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel4.Location = new System.Drawing.Point(0, 375);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(476, 43);
            this.bunifuPanel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "100";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(296, 16);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(34, 13);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "00.00";
            // 
            // btnMute
            // 
            this.btnMute.ActiveImage = null;
            this.btnMute.AllowAnimations = true;
            this.btnMute.AllowBuffering = false;
            this.btnMute.AllowToggling = false;
            this.btnMute.AllowZooming = true;
            this.btnMute.AllowZoomingOnFocus = false;
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMute.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMute.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMute.ErrorImage")));
            this.btnMute.FadeWhenInactive = false;
            this.btnMute.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.ImageActive = null;
            this.btnMute.ImageLocation = null;
            this.btnMute.ImageMargin = 0;
            this.btnMute.ImageSize = new System.Drawing.Size(18, 18);
            this.btnMute.ImageZoomSize = new System.Drawing.Size(19, 19);
            this.btnMute.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMute.InitialImage")));
            this.btnMute.Location = new System.Drawing.Point(340, 13);
            this.btnMute.Name = "btnMute";
            this.btnMute.Rotation = 0;
            this.btnMute.ShowActiveImage = true;
            this.btnMute.ShowCursorChanges = true;
            this.btnMute.ShowImageBorders = true;
            this.btnMute.ShowSizeMarkers = false;
            this.btnMute.Size = new System.Drawing.Size(19, 19);
            this.btnMute.TabIndex = 10;
            this.btnMute.ToolTipText = "";
            this.btnMute.WaitOnLoad = false;
            this.btnMute.Zoom = 0;
            this.btnMute.ZoomSpeed = 10;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // volume
            // 
            this.volume.AllowCursorChanges = true;
            this.volume.AllowHomeEndKeysDetection = false;
            this.volume.AllowIncrementalClickMoves = true;
            this.volume.AllowMouseDownEffects = false;
            this.volume.AllowMouseHoverEffects = false;
            this.volume.AllowScrollingAnimations = true;
            this.volume.AllowScrollKeysDetection = true;
            this.volume.AllowScrollOptionsMenu = true;
            this.volume.AllowShrinkingOnFocusLost = false;
            this.volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume.BackgroundImage")));
            this.volume.BindingContainer = null;
            this.volume.BorderRadius = 2;
            this.volume.BorderThickness = 1;
            this.volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume.DrawThickBorder = false;
            this.volume.DurationBeforeShrink = 2000;
            this.volume.ElapsedColor = System.Drawing.Color.BlueViolet;
            this.volume.LargeChange = 10;
            this.volume.Location = new System.Drawing.Point(365, 8);
            this.volume.Maximum = 100;
            this.volume.Minimum = 0;
            this.volume.MinimumSize = new System.Drawing.Size(0, 31);
            this.volume.MinimumThumbLength = 18;
            this.volume.Name = "volume";
            this.volume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.volume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.volume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.volume.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.volume.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.volume.ShrinkSizeLimit = 3;
            this.volume.Size = new System.Drawing.Size(68, 31);
            this.volume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.volume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.volume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.volume.SmallChange = 1;
            this.volume.TabIndex = 5;
            this.volume.ThumbColor = System.Drawing.Color.MediumPurple;
            this.volume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.volume.ThumbLength = 18;
            this.volume.ThumbMargin = 1;
            this.volume.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Small;
            this.volume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.volume.Value = 50;
            this.volume.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.volume_Scroll);
            // 
            // btnFastforward
            // 
            this.btnFastforward.ActiveImage = null;
            this.btnFastforward.AllowAnimations = true;
            this.btnFastforward.AllowBuffering = false;
            this.btnFastforward.AllowToggling = false;
            this.btnFastforward.AllowZooming = true;
            this.btnFastforward.AllowZoomingOnFocus = false;
            this.btnFastforward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFastforward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFastforward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFastforward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFastforward.ErrorImage")));
            this.btnFastforward.FadeWhenInactive = false;
            this.btnFastforward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFastforward.Image = ((System.Drawing.Image)(resources.GetObject("btnFastforward.Image")));
            this.btnFastforward.ImageActive = null;
            this.btnFastforward.ImageLocation = null;
            this.btnFastforward.ImageMargin = 0;
            this.btnFastforward.ImageSize = new System.Drawing.Size(24, 24);
            this.btnFastforward.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnFastforward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFastforward.InitialImage")));
            this.btnFastforward.Location = new System.Drawing.Point(90, 10);
            this.btnFastforward.Name = "btnFastforward";
            this.btnFastforward.Rotation = 0;
            this.btnFastforward.ShowActiveImage = true;
            this.btnFastforward.ShowCursorChanges = true;
            this.btnFastforward.ShowImageBorders = true;
            this.btnFastforward.ShowSizeMarkers = false;
            this.btnFastforward.Size = new System.Drawing.Size(25, 25);
            this.btnFastforward.TabIndex = 4;
            this.btnFastforward.ToolTipText = "";
            this.btnFastforward.WaitOnLoad = false;
            this.btnFastforward.Zoom = 0;
            this.btnFastforward.ZoomSpeed = 10;
            this.btnFastforward.Click += new System.EventHandler(this.btnFastforward_Click);
            // 
            // btnPause
            // 
            this.btnPause.ActiveImage = null;
            this.btnPause.AllowAnimations = true;
            this.btnPause.AllowBuffering = false;
            this.btnPause.AllowToggling = false;
            this.btnPause.AllowZooming = true;
            this.btnPause.AllowZoomingOnFocus = false;
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPause.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPause.ErrorImage")));
            this.btnPause.FadeWhenInactive = false;
            this.btnPause.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageActive = null;
            this.btnPause.ImageLocation = null;
            this.btnPause.ImageMargin = 0;
            this.btnPause.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPause.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnPause.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPause.InitialImage")));
            this.btnPause.Location = new System.Drawing.Point(62, 10);
            this.btnPause.Name = "btnPause";
            this.btnPause.Rotation = 0;
            this.btnPause.ShowActiveImage = true;
            this.btnPause.ShowCursorChanges = true;
            this.btnPause.ShowImageBorders = true;
            this.btnPause.ShowSizeMarkers = false;
            this.btnPause.Size = new System.Drawing.Size(25, 25);
            this.btnPause.TabIndex = 3;
            this.btnPause.ToolTipText = "";
            this.btnPause.WaitOnLoad = false;
            this.btnPause.Zoom = 0;
            this.btnPause.ZoomSpeed = 10;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.ActiveImage = null;
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowBuffering = false;
            this.btnPlay.AllowToggling = false;
            this.btnPlay.AllowZooming = true;
            this.btnPlay.AllowZoomingOnFocus = false;
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ErrorImage")));
            this.btnPlay.FadeWhenInactive = false;
            this.btnPlay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.ImageLocation = null;
            this.btnPlay.ImageMargin = 0;
            this.btnPlay.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(31, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(25, 25);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.ToolTipText = "";
            this.btnPlay.WaitOnLoad = false;
            this.btnPlay.Zoom = 0;
            this.btnPlay.ZoomSpeed = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.ActiveImage = null;
            this.btnBackward.AllowAnimations = true;
            this.btnBackward.AllowBuffering = false;
            this.btnBackward.AllowToggling = false;
            this.btnBackward.AllowZooming = true;
            this.btnBackward.AllowZoomingOnFocus = false;
            this.btnBackward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBackward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.ErrorImage")));
            this.btnBackward.FadeWhenInactive = false;
            this.btnBackward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.ImageActive = null;
            this.btnBackward.ImageLocation = null;
            this.btnBackward.ImageMargin = 0;
            this.btnBackward.ImageSize = new System.Drawing.Size(24, 24);
            this.btnBackward.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.btnBackward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.InitialImage")));
            this.btnBackward.Location = new System.Drawing.Point(3, 10);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Rotation = 0;
            this.btnBackward.ShowActiveImage = true;
            this.btnBackward.ShowCursorChanges = true;
            this.btnBackward.ShowImageBorders = true;
            this.btnBackward.ShowSizeMarkers = false;
            this.btnBackward.Size = new System.Drawing.Size(25, 25);
            this.btnBackward.TabIndex = 1;
            this.btnBackward.ToolTipText = "";
            this.btnBackward.WaitOnLoad = false;
            this.btnBackward.Zoom = 0;
            this.btnBackward.ZoomSpeed = 10;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.BlueViolet;
            this.bunifuHSlider1.LargeChange = 10;
            this.bunifuHSlider1.Location = new System.Drawing.Point(121, 8);
            this.bunifuHSlider1.Maximum = 100;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(173, 31);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 0;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.MediumPurple;
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 18;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Small;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 50;
            this.bunifuHSlider1.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(669, 461);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPages1.ResumeLayout(false);
            this.bunifuPages2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlaying;
        private Bunifu.UI.WinForms.BunifuShapes indicator;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlaylist;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage bunifuPages2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnMute;
        private Bunifu.UI.WinForms.BunifuHSlider volume;
        private Bunifu.UI.WinForms.BunifuImageButton btnFastforward;
        private Bunifu.UI.WinForms.BunifuImageButton btnPause;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnBackward;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddVideo;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddPlaylist;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label1;
    }
}