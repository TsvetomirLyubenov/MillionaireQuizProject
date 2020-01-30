using System.Threading;
using System.Threading.Tasks;

namespace Millionaire_Client
{
    partial class Login
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
            this.linkLabelLoginRegister = new System.Windows.Forms.LinkLabel();
            this.linkLabelLoginPasswordRecovery = new System.Windows.Forms.LinkLabel();
            this.labelLoginUserName = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.maskedTextBoxLoginPassword = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLoginUserName = new System.Windows.Forms.TextBox();
            this.panelPasswordRecovery = new System.Windows.Forms.Panel();
            this.maskedTextBoxPasswordRecoveryOldPassword = new System.Windows.Forms.MaskedTextBox();
            this.labelPasswordRecoveryErrorMessage = new System.Windows.Forms.Label();
            this.textBoxPasswordRecoveryEmail = new System.Windows.Forms.TextBox();
            this.labelPasswordRecoveryEmail = new System.Windows.Forms.Label();
            this.maskedTextBoxPasswordRecoveryNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxPasswordRecoveryBackButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxPasswordRecoverySaveButton = new System.Windows.Forms.PictureBox();
            this.labelPasswordRecoveryNewPassword = new System.Windows.Forms.Label();
            this.labelPasswordRecoveryOldPassword = new System.Windows.Forms.Label();
            this.labelPasswordRecoveryTitle = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.labelRegisterRepeatedPassword = new System.Windows.Forms.Label();
            this.labelRegisterErrorMessage = new System.Windows.Forms.Label();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.labelRegisterEmail = new System.Windows.Forms.Label();
            this.labelRegisterUserName = new System.Windows.Forms.Label();
            this.pictureBoxRegisterBackButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegisterButton = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxRegisterPassword = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRegisterRepeatedPassword = new System.Windows.Forms.MaskedTextBox();
            this.textBoxRegisterEmail = new System.Windows.Forms.TextBox();
            this.textBoxRegisterUserName = new System.Windows.Forms.TextBox();
            this.labelRegisterTitle = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelRankings = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.labelMessageCreditsWonNumber = new System.Windows.Forms.Label();
            this.pictureBoxMessageHomeButon = new System.Windows.Forms.PictureBox();
            this.labelMessageTtitle = new System.Windows.Forms.Label();
            this.labelGameHintBox = new System.Windows.Forms.Label();
            this.labelGameAnswerD = new System.Windows.Forms.Label();
            this.labelGameAnswerC = new System.Windows.Forms.Label();
            this.labelGameAnswerB = new System.Windows.Forms.Label();
            this.labelGameAnswerA = new System.Windows.Forms.Label();
            this.labelGameQuestion = new System.Windows.Forms.Label();
            this.pictureBoxGameGiveUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxGameSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxGameFriend = new System.Windows.Forms.PictureBox();
            this.pictureBoxGame5050 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGameLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxGameSumTree = new System.Windows.Forms.PictureBox();
            this.pictureBoxGameQuestionForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxRankingsNextButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxRankingsPreviousButton = new System.Windows.Forms.PictureBox();
            this.textBoxRankingsThird3 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFirst2 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFifth = new System.Windows.Forms.TextBox();
            this.textBoxRankingsEighth3 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSecond = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSecond3 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFirst3 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFourth2 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsEighth2 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSecond2 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSixth2 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFourth = new System.Windows.Forms.TextBox();
            this.textBoxRankingsThird = new System.Windows.Forms.TextBox();
            this.textBoxRankingsThird2 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFourth3 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSixth = new System.Windows.Forms.TextBox();
            this.textBoxRankingsEighth = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSeventh = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSeventh2 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFifth2 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFifth3 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsFirst = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSixth3 = new System.Windows.Forms.TextBox();
            this.textBoxRankingsSeventh3 = new System.Windows.Forms.TextBox();
            this.pictureBoxRankingsHomeButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxRankingsTable = new System.Windows.Forms.PictureBox();
            this.labelRankingsTitle = new System.Windows.Forms.Label();
            this.labelHomeCreditsNumber = new System.Windows.Forms.Label();
            this.labelHomeUserName = new System.Windows.Forms.Label();
            this.labelHomeYellowDot = new System.Windows.Forms.Label();
            this.labelHomeCreditsMessage = new System.Windows.Forms.Label();
            this.pictureBoxHomeLogoutButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxHomeNewGameButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxHomeRankingsButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxHomeLogo = new System.Windows.Forms.PictureBox();
            this.labelLoginErrorMessage = new System.Windows.Forms.Label();
            this.pictureBoxLoginButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoginLogo = new System.Windows.Forms.PictureBox();
            this.panelPasswordRecovery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordRecoveryBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordRecoverySaveButton)).BeginInit();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegisterBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegisterButton)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelRankings.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessageHomeButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameGiveUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame5050)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameSumTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameQuestionForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRankingsNextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRankingsPreviousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRankingsHomeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRankingsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeLogoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeNewGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeRankingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelLoginRegister
            // 
            this.linkLabelLoginRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLoginRegister.AutoSize = true;
            this.linkLabelLoginRegister.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLoginRegister.LinkColor = System.Drawing.Color.White;
            this.linkLabelLoginRegister.Location = new System.Drawing.Point(296, 676);
            this.linkLabelLoginRegister.Name = "linkLabelLoginRegister";
            this.linkLabelLoginRegister.Size = new System.Drawing.Size(140, 22);
            this.linkLabelLoginRegister.TabIndex = 6;
            this.linkLabelLoginRegister.TabStop = true;
            this.linkLabelLoginRegister.Text = "Нямате акаунт?";
            this.linkLabelLoginRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginRegister_LinkClicked);
            // 
            // linkLabelLoginPasswordRecovery
            // 
            this.linkLabelLoginPasswordRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLoginPasswordRecovery.AutoSize = true;
            this.linkLabelLoginPasswordRecovery.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLoginPasswordRecovery.LinkColor = System.Drawing.Color.White;
            this.linkLabelLoginPasswordRecovery.Location = new System.Drawing.Point(652, 673);
            this.linkLabelLoginPasswordRecovery.Name = "linkLabelLoginPasswordRecovery";
            this.linkLabelLoginPasswordRecovery.Size = new System.Drawing.Size(165, 22);
            this.linkLabelLoginPasswordRecovery.TabIndex = 7;
            this.linkLabelLoginPasswordRecovery.TabStop = true;
            this.linkLabelLoginPasswordRecovery.Text = "Забравена парола?";
            this.linkLabelLoginPasswordRecovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginPasswordRecovery_LinkClicked);
            // 
            // labelLoginUserName
            // 
            this.labelLoginUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoginUserName.AutoSize = true;
            this.labelLoginUserName.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginUserName.ForeColor = System.Drawing.Color.White;
            this.labelLoginUserName.Location = new System.Drawing.Point(296, 377);
            this.labelLoginUserName.Name = "labelLoginUserName";
            this.labelLoginUserName.Size = new System.Drawing.Size(168, 22);
            this.labelLoginUserName.TabIndex = 8;
            this.labelLoginUserName.Text = "Потребителско име:";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginPassword.ForeColor = System.Drawing.Color.White;
            this.labelLoginPassword.Location = new System.Drawing.Point(296, 473);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(72, 22);
            this.labelLoginPassword.TabIndex = 9;
            this.labelLoginPassword.Text = "Парола:";
            // 
            // maskedTextBoxLoginPassword
            // 
            this.maskedTextBoxLoginPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxLoginPassword.Location = new System.Drawing.Point(300, 507);
            this.maskedTextBoxLoginPassword.Name = "maskedTextBoxLoginPassword";
            this.maskedTextBoxLoginPassword.PasswordChar = '●';
            this.maskedTextBoxLoginPassword.Size = new System.Drawing.Size(517, 47);
            this.maskedTextBoxLoginPassword.TabIndex = 10;
            // 
            // textBoxLoginUserName
            // 
            this.textBoxLoginUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.textBoxLoginUserName.Location = new System.Drawing.Point(300, 411);
            this.textBoxLoginUserName.Name = "textBoxLoginUserName";
            this.textBoxLoginUserName.Size = new System.Drawing.Size(517, 47);
            this.textBoxLoginUserName.TabIndex = 11;
            // 
            // panelPasswordRecovery
            // 
            this.panelPasswordRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPasswordRecovery.Controls.Add(this.panelRegister);
            this.panelPasswordRecovery.Controls.Add(this.maskedTextBoxPasswordRecoveryOldPassword);
            this.panelPasswordRecovery.Controls.Add(this.labelPasswordRecoveryErrorMessage);
            this.panelPasswordRecovery.Controls.Add(this.textBoxPasswordRecoveryEmail);
            this.panelPasswordRecovery.Controls.Add(this.labelPasswordRecoveryEmail);
            this.panelPasswordRecovery.Controls.Add(this.maskedTextBoxPasswordRecoveryNewPassword);
            this.panelPasswordRecovery.Controls.Add(this.pictureBoxPasswordRecoveryBackButton);
            this.panelPasswordRecovery.Controls.Add(this.pictureBoxPasswordRecoverySaveButton);
            this.panelPasswordRecovery.Controls.Add(this.labelPasswordRecoveryNewPassword);
            this.panelPasswordRecovery.Controls.Add(this.labelPasswordRecoveryOldPassword);
            this.panelPasswordRecovery.Controls.Add(this.labelPasswordRecoveryTitle);
            this.panelPasswordRecovery.Location = new System.Drawing.Point(0, 1);
            this.panelPasswordRecovery.Name = "panelPasswordRecovery";
            this.panelPasswordRecovery.Size = new System.Drawing.Size(1144, 722);
            this.panelPasswordRecovery.TabIndex = 12;
            // 
            // maskedTextBoxPasswordRecoveryOldPassword
            // 
            this.maskedTextBoxPasswordRecoveryOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBoxPasswordRecoveryOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPasswordRecoveryOldPassword.Location = new System.Drawing.Point(302, 313);
            this.maskedTextBoxPasswordRecoveryOldPassword.Name = "maskedTextBoxPasswordRecoveryOldPassword";
            this.maskedTextBoxPasswordRecoveryOldPassword.PasswordChar = '●';
            this.maskedTextBoxPasswordRecoveryOldPassword.Size = new System.Drawing.Size(517, 47);
            this.maskedTextBoxPasswordRecoveryOldPassword.TabIndex = 29;
            // 
            // labelPasswordRecoveryErrorMessage
            // 
            this.labelPasswordRecoveryErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPasswordRecoveryErrorMessage.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordRecoveryErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordRecoveryErrorMessage.Location = new System.Drawing.Point(296, 109);
            this.labelPasswordRecoveryErrorMessage.Name = "labelPasswordRecoveryErrorMessage";
            this.labelPasswordRecoveryErrorMessage.Size = new System.Drawing.Size(523, 61);
            this.labelPasswordRecoveryErrorMessage.TabIndex = 34;
            this.labelPasswordRecoveryErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPasswordRecoveryEmail
            // 
            this.textBoxPasswordRecoveryEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPasswordRecoveryEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.textBoxPasswordRecoveryEmail.Location = new System.Drawing.Point(302, 211);
            this.textBoxPasswordRecoveryEmail.Name = "textBoxPasswordRecoveryEmail";
            this.textBoxPasswordRecoveryEmail.Size = new System.Drawing.Size(517, 47);
            this.textBoxPasswordRecoveryEmail.TabIndex = 39;
            // 
            // labelPasswordRecoveryEmail
            // 
            this.labelPasswordRecoveryEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPasswordRecoveryEmail.AutoSize = true;
            this.labelPasswordRecoveryEmail.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordRecoveryEmail.ForeColor = System.Drawing.Color.White;
            this.labelPasswordRecoveryEmail.Location = new System.Drawing.Point(298, 170);
            this.labelPasswordRecoveryEmail.Name = "labelPasswordRecoveryEmail";
            this.labelPasswordRecoveryEmail.Size = new System.Drawing.Size(68, 22);
            this.labelPasswordRecoveryEmail.TabIndex = 40;
            this.labelPasswordRecoveryEmail.Text = "E-mail:";
            // 
            // maskedTextBoxPasswordRecoveryNewPassword
            // 
            this.maskedTextBoxPasswordRecoveryNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBoxPasswordRecoveryNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPasswordRecoveryNewPassword.Location = new System.Drawing.Point(302, 418);
            this.maskedTextBoxPasswordRecoveryNewPassword.Name = "maskedTextBoxPasswordRecoveryNewPassword";
            this.maskedTextBoxPasswordRecoveryNewPassword.PasswordChar = '●';
            this.maskedTextBoxPasswordRecoveryNewPassword.Size = new System.Drawing.Size(517, 47);
            this.maskedTextBoxPasswordRecoveryNewPassword.TabIndex = 32;
            // 
            // pictureBoxPasswordRecoveryBackButton
            // 
            this.pictureBoxPasswordRecoveryBackButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPasswordRecoveryBackButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPasswordRecoveryBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPasswordRecoveryBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPasswordRecoveryBackButton.Image = global::Millionaire_Client.Properties.Resources.previous;
            this.pictureBoxPasswordRecoveryBackButton.Location = new System.Drawing.Point(598, 541);
            this.pictureBoxPasswordRecoveryBackButton.Name = "pictureBoxPasswordRecoveryBackButton";
            this.pictureBoxPasswordRecoveryBackButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxPasswordRecoveryBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPasswordRecoveryBackButton.TabIndex = 27;
            this.pictureBoxPasswordRecoveryBackButton.TabStop = false;
            this.pictureBoxPasswordRecoveryBackButton.Click += new System.EventHandler(this.pictureBoxPasswordRecoveryBackButton_Click);
            // 
            // pictureBoxPasswordRecoverySaveButton
            // 
            this.pictureBoxPasswordRecoverySaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPasswordRecoverySaveButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPasswordRecoverySaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPasswordRecoverySaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPasswordRecoverySaveButton.Image = global::Millionaire_Client.Properties.Resources.save;
            this.pictureBoxPasswordRecoverySaveButton.Location = new System.Drawing.Point(302, 541);
            this.pictureBoxPasswordRecoverySaveButton.Name = "pictureBoxPasswordRecoverySaveButton";
            this.pictureBoxPasswordRecoverySaveButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxPasswordRecoverySaveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPasswordRecoverySaveButton.TabIndex = 26;
            this.pictureBoxPasswordRecoverySaveButton.TabStop = false;
            this.pictureBoxPasswordRecoverySaveButton.Click += new System.EventHandler(this.pictureBoxPasswordRecoverySaveButton_Click);
            // 
            // labelPasswordRecoveryNewPassword
            // 
            this.labelPasswordRecoveryNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPasswordRecoveryNewPassword.AutoSize = true;
            this.labelPasswordRecoveryNewPassword.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordRecoveryNewPassword.ForeColor = System.Drawing.Color.White;
            this.labelPasswordRecoveryNewPassword.Location = new System.Drawing.Point(298, 384);
            this.labelPasswordRecoveryNewPassword.Name = "labelPasswordRecoveryNewPassword";
            this.labelPasswordRecoveryNewPassword.Size = new System.Drawing.Size(115, 22);
            this.labelPasswordRecoveryNewPassword.TabIndex = 24;
            this.labelPasswordRecoveryNewPassword.Text = "Нова парола:";
            // 
            // labelPasswordRecoveryOldPassword
            // 
            this.labelPasswordRecoveryOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPasswordRecoveryOldPassword.AutoSize = true;
            this.labelPasswordRecoveryOldPassword.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordRecoveryOldPassword.ForeColor = System.Drawing.Color.White;
            this.labelPasswordRecoveryOldPassword.Location = new System.Drawing.Point(298, 276);
            this.labelPasswordRecoveryOldPassword.Name = "labelPasswordRecoveryOldPassword";
            this.labelPasswordRecoveryOldPassword.Size = new System.Drawing.Size(123, 22);
            this.labelPasswordRecoveryOldPassword.TabIndex = 22;
            this.labelPasswordRecoveryOldPassword.Text = "Стара парола:";
            // 
            // labelPasswordRecoveryTitle
            // 
            this.labelPasswordRecoveryTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPasswordRecoveryTitle.AutoSize = true;
            this.labelPasswordRecoveryTitle.Font = new System.Drawing.Font("Kelly Slab", 38.25F);
            this.labelPasswordRecoveryTitle.ForeColor = System.Drawing.Color.White;
            this.labelPasswordRecoveryTitle.Location = new System.Drawing.Point(302, 38);
            this.labelPasswordRecoveryTitle.Name = "labelPasswordRecoveryTitle";
            this.labelPasswordRecoveryTitle.Size = new System.Drawing.Size(515, 62);
            this.labelPasswordRecoveryTitle.TabIndex = 11;
            this.labelPasswordRecoveryTitle.Text = "ЗАБРАВЕНА ПАРОЛА";
            // 
            // panelRegister
            // 
            this.panelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRegister.Controls.Add(this.panelHome);
            this.panelRegister.Controls.Add(this.labelRegisterRepeatedPassword);
            this.panelRegister.Controls.Add(this.labelRegisterErrorMessage);
            this.panelRegister.Controls.Add(this.labelRegisterPassword);
            this.panelRegister.Controls.Add(this.labelRegisterEmail);
            this.panelRegister.Controls.Add(this.labelRegisterUserName);
            this.panelRegister.Controls.Add(this.pictureBoxRegisterBackButton);
            this.panelRegister.Controls.Add(this.pictureBoxRegisterButton);
            this.panelRegister.Controls.Add(this.maskedTextBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.maskedTextBoxRegisterRepeatedPassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterEmail);
            this.panelRegister.Controls.Add(this.textBoxRegisterUserName);
            this.panelRegister.Controls.Add(this.labelRegisterTitle);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(1151, 832);
            this.panelRegister.TabIndex = 28;
            // 
            // labelRegisterRepeatedPassword
            // 
            this.labelRegisterRepeatedPassword.AutoSize = true;
            this.labelRegisterRepeatedPassword.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegisterRepeatedPassword.ForeColor = System.Drawing.Color.White;
            this.labelRegisterRepeatedPassword.Location = new System.Drawing.Point(312, 481);
            this.labelRegisterRepeatedPassword.Name = "labelRegisterRepeatedPassword";
            this.labelRegisterRepeatedPassword.Size = new System.Drawing.Size(160, 22);
            this.labelRegisterRepeatedPassword.TabIndex = 32;
            this.labelRegisterRepeatedPassword.Text = "Повтори паролата:";
            // 
            // labelRegisterErrorMessage
            // 
            this.labelRegisterErrorMessage.AutoSize = true;
            this.labelRegisterErrorMessage.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegisterErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelRegisterErrorMessage.Location = new System.Drawing.Point(312, 111);
            this.labelRegisterErrorMessage.Name = "labelRegisterErrorMessage";
            this.labelRegisterErrorMessage.Size = new System.Drawing.Size(0, 22);
            this.labelRegisterErrorMessage.TabIndex = 40;
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegisterPassword.ForeColor = System.Drawing.Color.White;
            this.labelRegisterPassword.Location = new System.Drawing.Point(312, 370);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(72, 22);
            this.labelRegisterPassword.TabIndex = 31;
            this.labelRegisterPassword.Text = "Парола:";
            // 
            // labelRegisterEmail
            // 
            this.labelRegisterEmail.AutoSize = true;
            this.labelRegisterEmail.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegisterEmail.ForeColor = System.Drawing.Color.White;
            this.labelRegisterEmail.Location = new System.Drawing.Point(312, 258);
            this.labelRegisterEmail.Name = "labelRegisterEmail";
            this.labelRegisterEmail.Size = new System.Drawing.Size(68, 22);
            this.labelRegisterEmail.TabIndex = 30;
            this.labelRegisterEmail.Text = "E-mail:";
            // 
            // labelRegisterUserName
            // 
            this.labelRegisterUserName.AutoSize = true;
            this.labelRegisterUserName.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegisterUserName.ForeColor = System.Drawing.Color.White;
            this.labelRegisterUserName.Location = new System.Drawing.Point(312, 145);
            this.labelRegisterUserName.Name = "labelRegisterUserName";
            this.labelRegisterUserName.Size = new System.Drawing.Size(168, 22);
            this.labelRegisterUserName.TabIndex = 29;
            this.labelRegisterUserName.Text = "Потребителско име:";
            // 
            // pictureBoxRegisterBackButton
            // 
            this.pictureBoxRegisterBackButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRegisterBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxRegisterBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRegisterBackButton.Image = global::Millionaire_Client.Properties.Resources.previous;
            this.pictureBoxRegisterBackButton.Location = new System.Drawing.Point(612, 630);
            this.pictureBoxRegisterBackButton.Name = "pictureBoxRegisterBackButton";
            this.pictureBoxRegisterBackButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxRegisterBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegisterBackButton.TabIndex = 28;
            this.pictureBoxRegisterBackButton.TabStop = false;
            this.pictureBoxRegisterBackButton.Click += new System.EventHandler(this.pictureBoxRegisterBackButton_Click);
            // 
            // pictureBoxRegisterButton
            // 
            this.pictureBoxRegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRegisterButton.Image = global::Millionaire_Client.Properties.Resources.register;
            this.pictureBoxRegisterButton.Location = new System.Drawing.Point(316, 630);
            this.pictureBoxRegisterButton.Name = "pictureBoxRegisterButton";
            this.pictureBoxRegisterButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxRegisterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegisterButton.TabIndex = 27;
            this.pictureBoxRegisterButton.TabStop = false;
            this.pictureBoxRegisterButton.Click += new System.EventHandler(this.pictureBoxRegisterButton_Click);
            // 
            // maskedTextBoxRegisterPassword
            // 
            this.maskedTextBoxRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxRegisterPassword.Location = new System.Drawing.Point(316, 411);
            this.maskedTextBoxRegisterPassword.Name = "maskedTextBoxRegisterPassword";
            this.maskedTextBoxRegisterPassword.PasswordChar = '●';
            this.maskedTextBoxRegisterPassword.Size = new System.Drawing.Size(517, 47);
            this.maskedTextBoxRegisterPassword.TabIndex = 38;
            // 
            // maskedTextBoxRegisterRepeatedPassword
            // 
            this.maskedTextBoxRegisterRepeatedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxRegisterRepeatedPassword.Location = new System.Drawing.Point(316, 522);
            this.maskedTextBoxRegisterRepeatedPassword.Name = "maskedTextBoxRegisterRepeatedPassword";
            this.maskedTextBoxRegisterRepeatedPassword.PasswordChar = '●';
            this.maskedTextBoxRegisterRepeatedPassword.Size = new System.Drawing.Size(517, 47);
            this.maskedTextBoxRegisterRepeatedPassword.TabIndex = 37;
            // 
            // textBoxRegisterEmail
            // 
            this.textBoxRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.textBoxRegisterEmail.Location = new System.Drawing.Point(316, 294);
            this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            this.textBoxRegisterEmail.Size = new System.Drawing.Size(517, 47);
            this.textBoxRegisterEmail.TabIndex = 25;
            // 
            // textBoxRegisterUserName
            // 
            this.textBoxRegisterUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.textBoxRegisterUserName.Location = new System.Drawing.Point(316, 179);
            this.textBoxRegisterUserName.Name = "textBoxRegisterUserName";
            this.textBoxRegisterUserName.Size = new System.Drawing.Size(517, 47);
            this.textBoxRegisterUserName.TabIndex = 23;
            // 
            // labelRegisterTitle
            // 
            this.labelRegisterTitle.AutoSize = true;
            this.labelRegisterTitle.Font = new System.Drawing.Font("Kelly Slab", 38.25F);
            this.labelRegisterTitle.ForeColor = System.Drawing.Color.White;
            this.labelRegisterTitle.Location = new System.Drawing.Point(376, 28);
            this.labelRegisterTitle.Name = "labelRegisterTitle";
            this.labelRegisterTitle.Size = new System.Drawing.Size(365, 62);
            this.labelRegisterTitle.TabIndex = 22;
            this.labelRegisterTitle.Text = "РЕГИСТРАЦИЯ";
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.Controls.Add(this.panelRankings);
            this.panelHome.Controls.Add(this.labelHomeCreditsNumber);
            this.panelHome.Controls.Add(this.labelHomeUserName);
            this.panelHome.Controls.Add(this.labelHomeYellowDot);
            this.panelHome.Controls.Add(this.labelHomeCreditsMessage);
            this.panelHome.Controls.Add(this.pictureBoxHomeLogoutButton);
            this.panelHome.Controls.Add(this.pictureBoxHomeNewGameButton);
            this.panelHome.Controls.Add(this.pictureBoxHomeRankingsButton);
            this.panelHome.Controls.Add(this.pictureBoxHomeLogo);
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1145, 832);
            this.panelHome.TabIndex = 33;
            // 
            // panelRankings
            // 
            this.panelRankings.Controls.Add(this.panelGame);
            this.panelRankings.Controls.Add(this.pictureBoxRankingsNextButton);
            this.panelRankings.Controls.Add(this.pictureBoxRankingsPreviousButton);
            this.panelRankings.Controls.Add(this.textBoxRankingsThird3);
            this.panelRankings.Controls.Add(this.textBoxRankingsFirst2);
            this.panelRankings.Controls.Add(this.textBoxRankingsFifth);
            this.panelRankings.Controls.Add(this.textBoxRankingsEighth3);
            this.panelRankings.Controls.Add(this.textBoxRankingsSecond);
            this.panelRankings.Controls.Add(this.textBoxRankingsSecond3);
            this.panelRankings.Controls.Add(this.textBoxRankingsFirst3);
            this.panelRankings.Controls.Add(this.textBoxRankingsFourth2);
            this.panelRankings.Controls.Add(this.textBoxRankingsEighth2);
            this.panelRankings.Controls.Add(this.textBoxRankingsSecond2);
            this.panelRankings.Controls.Add(this.textBoxRankingsSixth2);
            this.panelRankings.Controls.Add(this.textBoxRankingsFourth);
            this.panelRankings.Controls.Add(this.textBoxRankingsThird);
            this.panelRankings.Controls.Add(this.textBoxRankingsThird2);
            this.panelRankings.Controls.Add(this.textBoxRankingsFourth3);
            this.panelRankings.Controls.Add(this.textBoxRankingsSixth);
            this.panelRankings.Controls.Add(this.textBoxRankingsEighth);
            this.panelRankings.Controls.Add(this.textBoxRankingsSeventh);
            this.panelRankings.Controls.Add(this.textBoxRankingsSeventh2);
            this.panelRankings.Controls.Add(this.textBoxRankingsFifth2);
            this.panelRankings.Controls.Add(this.textBoxRankingsFifth3);
            this.panelRankings.Controls.Add(this.textBoxRankingsFirst);
            this.panelRankings.Controls.Add(this.textBoxRankingsSixth3);
            this.panelRankings.Controls.Add(this.textBoxRankingsSeventh3);
            this.panelRankings.Controls.Add(this.pictureBoxRankingsHomeButton);
            this.panelRankings.Controls.Add(this.pictureBoxRankingsTable);
            this.panelRankings.Controls.Add(this.labelRankingsTitle);
            this.panelRankings.Location = new System.Drawing.Point(0, 0);
            this.panelRankings.Name = "panelRankings";
            this.panelRankings.Size = new System.Drawing.Size(1142, 830);
            this.panelRankings.TabIndex = 32;
            // 
            // panelGame
            // 
            this.panelGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGame.Controls.Add(this.panelMessage);
            this.panelGame.Controls.Add(this.labelGameHintBox);
            this.panelGame.Controls.Add(this.labelGameAnswerD);
            this.panelGame.Controls.Add(this.labelGameAnswerC);
            this.panelGame.Controls.Add(this.labelGameAnswerB);
            this.panelGame.Controls.Add(this.labelGameAnswerA);
            this.panelGame.Controls.Add(this.labelGameQuestion);
            this.panelGame.Controls.Add(this.pictureBoxGameGiveUp);
            this.panelGame.Controls.Add(this.pictureBoxGameSearch);
            this.panelGame.Controls.Add(this.pictureBoxGameFriend);
            this.panelGame.Controls.Add(this.pictureBoxGame5050);
            this.panelGame.Controls.Add(this.pictureBoxGameLogo);
            this.panelGame.Controls.Add(this.pictureBoxGameSumTree);
            this.panelGame.Controls.Add(this.pictureBoxGameQuestionForm);
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1142, 827);
            this.panelGame.TabIndex = 42;
            // 
            // panelMessage
            // 
            this.panelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.panelMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMessage.Controls.Add(this.labelMessageCreditsWonNumber);
            this.panelMessage.Controls.Add(this.pictureBoxMessageHomeButon);
            this.panelMessage.Controls.Add(this.labelMessageTtitle);
            this.panelMessage.Location = new System.Drawing.Point(251, 219);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(668, 354);
            this.panelMessage.TabIndex = 31;
            // 
            // labelMessageCreditsWonNumber
            // 
            this.labelMessageCreditsWonNumber.Font = new System.Drawing.Font("Kelly Slab", 43.25F);
            this.labelMessageCreditsWonNumber.ForeColor = System.Drawing.Color.Yellow;
            this.labelMessageCreditsWonNumber.Location = new System.Drawing.Point(184, 135);
            this.labelMessageCreditsWonNumber.Name = "labelMessageCreditsWonNumber";
            this.labelMessageCreditsWonNumber.Size = new System.Drawing.Size(313, 70);
            this.labelMessageCreditsWonNumber.TabIndex = 33;
            this.labelMessageCreditsWonNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMessageHomeButon
            // 
            this.pictureBoxMessageHomeButon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMessageHomeButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxMessageHomeButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMessageHomeButon.Image = global::Millionaire_Client.Properties.Resources.back;
            this.pictureBoxMessageHomeButon.Location = new System.Drawing.Point(225, 245);
            this.pictureBoxMessageHomeButon.Name = "pictureBoxMessageHomeButon";
            this.pictureBoxMessageHomeButon.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxMessageHomeButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMessageHomeButon.TabIndex = 32;
            this.pictureBoxMessageHomeButon.TabStop = false;
            this.pictureBoxMessageHomeButon.Click += new System.EventHandler(this.pictureBoxMessageHomeButton_Click);
            // 
            // labelMessageTtitle
            // 
            this.labelMessageTtitle.AutoSize = true;
            this.labelMessageTtitle.Font = new System.Drawing.Font("Kelly Slab", 43.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessageTtitle.ForeColor = System.Drawing.Color.White;
            this.labelMessageTtitle.Location = new System.Drawing.Point(129, 38);
            this.labelMessageTtitle.Name = "labelMessageTtitle";
            this.labelMessageTtitle.Size = new System.Drawing.Size(437, 70);
            this.labelMessageTtitle.TabIndex = 30;
            this.labelMessageTtitle.Text = "Вие спечелихте";
            // 
            // labelGameHintBox
            // 
            this.labelGameHintBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameHintBox.BackColor = System.Drawing.Color.Transparent;
            this.labelGameHintBox.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameHintBox.ForeColor = System.Drawing.Color.Yellow;
            this.labelGameHintBox.Location = new System.Drawing.Point(167, 410);
            this.labelGameHintBox.Name = "labelGameHintBox";
            this.labelGameHintBox.Size = new System.Drawing.Size(818, 80);
            this.labelGameHintBox.TabIndex = 30;
            this.labelGameHintBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGameAnswerD
            // 
            this.labelGameAnswerD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameAnswerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.labelGameAnswerD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGameAnswerD.Font = new System.Drawing.Font("Kelly Slab", 11.25F);
            this.labelGameAnswerD.ForeColor = System.Drawing.Color.Black;
            this.labelGameAnswerD.Location = new System.Drawing.Point(643, 666);
            this.labelGameAnswerD.Name = "labelGameAnswerD";
            this.labelGameAnswerD.Size = new System.Drawing.Size(391, 41);
            this.labelGameAnswerD.TabIndex = 29;
            this.labelGameAnswerD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameAnswerD.Click += new System.EventHandler(this.labelGameAnswerD_Click);
            // 
            // labelGameAnswerC
            // 
            this.labelGameAnswerC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameAnswerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.labelGameAnswerC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGameAnswerC.Font = new System.Drawing.Font("Kelly Slab", 11.25F);
            this.labelGameAnswerC.ForeColor = System.Drawing.Color.Black;
            this.labelGameAnswerC.Location = new System.Drawing.Point(118, 666);
            this.labelGameAnswerC.Name = "labelGameAnswerC";
            this.labelGameAnswerC.Size = new System.Drawing.Size(391, 41);
            this.labelGameAnswerC.TabIndex = 28;
            this.labelGameAnswerC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameAnswerC.Click += new System.EventHandler(this.labelGameAnswerC_Click);
            // 
            // labelGameAnswerB
            // 
            this.labelGameAnswerB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameAnswerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.labelGameAnswerB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGameAnswerB.Font = new System.Drawing.Font("Kelly Slab", 11.25F);
            this.labelGameAnswerB.ForeColor = System.Drawing.Color.Black;
            this.labelGameAnswerB.Location = new System.Drawing.Point(643, 602);
            this.labelGameAnswerB.Name = "labelGameAnswerB";
            this.labelGameAnswerB.Size = new System.Drawing.Size(391, 41);
            this.labelGameAnswerB.TabIndex = 27;
            this.labelGameAnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameAnswerB.Click += new System.EventHandler(this.labelGameAnswerB_Click);
            // 
            // labelGameAnswerA
            // 
            this.labelGameAnswerA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameAnswerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.labelGameAnswerA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGameAnswerA.Font = new System.Drawing.Font("Kelly Slab", 11.25F);
            this.labelGameAnswerA.ForeColor = System.Drawing.Color.Black;
            this.labelGameAnswerA.Location = new System.Drawing.Point(118, 602);
            this.labelGameAnswerA.Name = "labelGameAnswerA";
            this.labelGameAnswerA.Size = new System.Drawing.Size(391, 41);
            this.labelGameAnswerA.TabIndex = 26;
            this.labelGameAnswerA.Text = " ";
            this.labelGameAnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameAnswerA.Click += new System.EventHandler(this.labelGameAnswerA_Click);
            // 
            // labelGameQuestion
            // 
            this.labelGameQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(159)))));
            this.labelGameQuestion.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameQuestion.ForeColor = System.Drawing.Color.White;
            this.labelGameQuestion.Location = new System.Drawing.Point(164, 499);
            this.labelGameQuestion.Name = "labelGameQuestion";
            this.labelGameQuestion.Size = new System.Drawing.Size(818, 80);
            this.labelGameQuestion.TabIndex = 25;
            this.labelGameQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxGameGiveUp
            // 
            this.pictureBoxGameGiveUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxGameGiveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGameGiveUp.Image = global::Millionaire_Client.Properties.Resources.giveup;
            this.pictureBoxGameGiveUp.Location = new System.Drawing.Point(9, 313);
            this.pictureBoxGameGiveUp.Name = "pictureBoxGameGiveUp";
            this.pictureBoxGameGiveUp.Size = new System.Drawing.Size(93, 93);
            this.pictureBoxGameGiveUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGameGiveUp.TabIndex = 24;
            this.pictureBoxGameGiveUp.TabStop = false;
            this.pictureBoxGameGiveUp.Click += new System.EventHandler(this.pictureBoxGameGiveUp_Click);
            // 
            // pictureBoxGameSearch
            // 
            this.pictureBoxGameSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxGameSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGameSearch.Image = global::Millionaire_Client.Properties.Resources.search100x100ac;
            this.pictureBoxGameSearch.Location = new System.Drawing.Point(9, 205);
            this.pictureBoxGameSearch.Name = "pictureBoxGameSearch";
            this.pictureBoxGameSearch.Size = new System.Drawing.Size(93, 84);
            this.pictureBoxGameSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGameSearch.TabIndex = 23;
            this.pictureBoxGameSearch.TabStop = false;
            this.pictureBoxGameSearch.Click += new System.EventHandler(this.pictureBoxGameSearch_Click);
            // 
            // pictureBoxGameFriend
            // 
            this.pictureBoxGameFriend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxGameFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGameFriend.Image = global::Millionaire_Client.Properties.Resources.help100x100;
            this.pictureBoxGameFriend.Location = new System.Drawing.Point(9, 111);
            this.pictureBoxGameFriend.Name = "pictureBoxGameFriend";
            this.pictureBoxGameFriend.Size = new System.Drawing.Size(93, 81);
            this.pictureBoxGameFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGameFriend.TabIndex = 22;
            this.pictureBoxGameFriend.TabStop = false;
            this.pictureBoxGameFriend.Click += new System.EventHandler(this.pictureBoxGameFriend_Click);
            // 
            // pictureBoxGame5050
            // 
            this.pictureBoxGame5050.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxGame5050.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGame5050.Image = global::Millionaire_Client.Properties.Resources._5050Active100x100;
            this.pictureBoxGame5050.Location = new System.Drawing.Point(9, 16);
            this.pictureBoxGame5050.Name = "pictureBoxGame5050";
            this.pictureBoxGame5050.Size = new System.Drawing.Size(93, 81);
            this.pictureBoxGame5050.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGame5050.TabIndex = 21;
            this.pictureBoxGame5050.TabStop = false;
            this.pictureBoxGame5050.Click += new System.EventHandler(this.pictureBoxGame5050_Click);
            // 
            // pictureBoxGameLogo
            // 
            this.pictureBoxGameLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBoxGameLogo.Image = global::Millionaire_Client.Properties.Resources.logofinal;
            this.pictureBoxGameLogo.Location = new System.Drawing.Point(369, 1);
            this.pictureBoxGameLogo.Name = "pictureBoxGameLogo";
            this.pictureBoxGameLogo.Size = new System.Drawing.Size(430, 430);
            this.pictureBoxGameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGameLogo.TabIndex = 20;
            this.pictureBoxGameLogo.TabStop = false;
            // 
            // pictureBoxGameSumTree
            // 
            this.pictureBoxGameSumTree.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxGameSumTree.Image = global::Millionaire_Client.Properties.Resources.table1;
            this.pictureBoxGameSumTree.Location = new System.Drawing.Point(935, 16);
            this.pictureBoxGameSumTree.Name = "pictureBoxGameSumTree";
            this.pictureBoxGameSumTree.Size = new System.Drawing.Size(177, 384);
            this.pictureBoxGameSumTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGameSumTree.TabIndex = 19;
            this.pictureBoxGameSumTree.TabStop = false;
            // 
            // pictureBoxGameQuestionForm
            // 
            this.pictureBoxGameQuestionForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGameQuestionForm.Image = global::Millionaire_Client.Properties.Resources.template;
            this.pictureBoxGameQuestionForm.Location = new System.Drawing.Point(-8, 450);
            this.pictureBoxGameQuestionForm.Name = "pictureBoxGameQuestionForm";
            this.pictureBoxGameQuestionForm.Size = new System.Drawing.Size(1169, 303);
            this.pictureBoxGameQuestionForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGameQuestionForm.TabIndex = 18;
            this.pictureBoxGameQuestionForm.TabStop = false;
            // 
            // pictureBoxRankingsNextButton
            // 
            this.pictureBoxRankingsNextButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRankingsNextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxRankingsNextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRankingsNextButton.Image = global::Millionaire_Client.Properties.Resources.next;
            this.pictureBoxRankingsNextButton.Location = new System.Drawing.Point(874, 290);
            this.pictureBoxRankingsNextButton.Name = "pictureBoxRankingsNextButton";
            this.pictureBoxRankingsNextButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxRankingsNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRankingsNextButton.TabIndex = 41;
            this.pictureBoxRankingsNextButton.TabStop = false;
            this.pictureBoxRankingsNextButton.Click += new System.EventHandler(this.pictureBoxRankingsNextButton_Click);
            // 
            // pictureBoxRankingsPreviousButton
            // 
            this.pictureBoxRankingsPreviousButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRankingsPreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxRankingsPreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRankingsPreviousButton.Image = global::Millionaire_Client.Properties.Resources.previous;
            this.pictureBoxRankingsPreviousButton.Location = new System.Drawing.Point(874, 431);
            this.pictureBoxRankingsPreviousButton.Name = "pictureBoxRankingsPreviousButton";
            this.pictureBoxRankingsPreviousButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxRankingsPreviousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRankingsPreviousButton.TabIndex = 40;
            this.pictureBoxRankingsPreviousButton.TabStop = false;
            this.pictureBoxRankingsPreviousButton.Click += new System.EventHandler(this.pictureBoxRankingsPreviousButton_Click);
            // 
            // textBoxRankingsThird3
            // 
            this.textBoxRankingsThird3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsThird3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsThird3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsThird3.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsThird3.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsThird3.Location = new System.Drawing.Point(656, 323);
            this.textBoxRankingsThird3.Name = "textBoxRankingsThird3";
            this.textBoxRankingsThird3.ReadOnly = true;
            this.textBoxRankingsThird3.Size = new System.Drawing.Size(155, 43);
            this.textBoxRankingsThird3.TabIndex = 65;
            this.textBoxRankingsThird3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsThird3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFirst2
            // 
            this.textBoxRankingsFirst2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFirst2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFirst2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFirst2.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFirst2.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFirst2.Location = new System.Drawing.Point(397, 192);
            this.textBoxRankingsFirst2.Name = "textBoxRankingsFirst2";
            this.textBoxRankingsFirst2.ReadOnly = true;
            this.textBoxRankingsFirst2.Size = new System.Drawing.Size(257, 43);
            this.textBoxRankingsFirst2.TabIndex = 32;
            this.textBoxRankingsFirst2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFirst2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFifth
            // 
            this.textBoxRankingsFifth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFifth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFifth.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFifth.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFifth.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFifth.Location = new System.Drawing.Point(329, 453);
            this.textBoxRankingsFifth.Name = "textBoxRankingsFifth";
            this.textBoxRankingsFifth.ReadOnly = true;
            this.textBoxRankingsFifth.Size = new System.Drawing.Size(55, 43);
            this.textBoxRankingsFifth.TabIndex = 54;
            this.textBoxRankingsFifth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFifth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsEighth3
            // 
            this.textBoxRankingsEighth3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsEighth3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsEighth3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsEighth3.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsEighth3.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsEighth3.Location = new System.Drawing.Point(656, 648);
            this.textBoxRankingsEighth3.Name = "textBoxRankingsEighth3";
            this.textBoxRankingsEighth3.ReadOnly = true;
            this.textBoxRankingsEighth3.Size = new System.Drawing.Size(155, 43);
            this.textBoxRankingsEighth3.TabIndex = 62;
            this.textBoxRankingsEighth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsEighth3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSecond
            // 
            this.textBoxRankingsSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSecond.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSecond.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSecond.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSecond.Location = new System.Drawing.Point(329, 260);
            this.textBoxRankingsSecond.Name = "textBoxRankingsSecond";
            this.textBoxRankingsSecond.ReadOnly = true;
            this.textBoxRankingsSecond.Size = new System.Drawing.Size(55, 43);
            this.textBoxRankingsSecond.TabIndex = 56;
            this.textBoxRankingsSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSecond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSecond3
            // 
            this.textBoxRankingsSecond3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSecond3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSecond3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSecond3.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSecond3.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSecond3.Location = new System.Drawing.Point(656, 260);
            this.textBoxRankingsSecond3.Name = "textBoxRankingsSecond3";
            this.textBoxRankingsSecond3.ReadOnly = true;
            this.textBoxRankingsSecond3.Size = new System.Drawing.Size(155, 43);
            this.textBoxRankingsSecond3.TabIndex = 59;
            this.textBoxRankingsSecond3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSecond3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFirst3
            // 
            this.textBoxRankingsFirst3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFirst3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFirst3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFirst3.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFirst3.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFirst3.Location = new System.Drawing.Point(656, 192);
            this.textBoxRankingsFirst3.Name = "textBoxRankingsFirst3";
            this.textBoxRankingsFirst3.ReadOnly = true;
            this.textBoxRankingsFirst3.Size = new System.Drawing.Size(155, 43);
            this.textBoxRankingsFirst3.TabIndex = 58;
            this.textBoxRankingsFirst3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFirst3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFourth2
            // 
            this.textBoxRankingsFourth2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFourth2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFourth2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFourth2.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFourth2.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFourth2.Location = new System.Drawing.Point(397, 388);
            this.textBoxRankingsFourth2.Name = "textBoxRankingsFourth2";
            this.textBoxRankingsFourth2.ReadOnly = true;
            this.textBoxRankingsFourth2.Size = new System.Drawing.Size(256, 43);
            this.textBoxRankingsFourth2.TabIndex = 43;
            this.textBoxRankingsFourth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFourth2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsEighth2
            // 
            this.textBoxRankingsEighth2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsEighth2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsEighth2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsEighth2.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsEighth2.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsEighth2.Location = new System.Drawing.Point(397, 648);
            this.textBoxRankingsEighth2.Name = "textBoxRankingsEighth2";
            this.textBoxRankingsEighth2.ReadOnly = true;
            this.textBoxRankingsEighth2.Size = new System.Drawing.Size(256, 43);
            this.textBoxRankingsEighth2.TabIndex = 44;
            this.textBoxRankingsEighth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsEighth2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSecond2
            // 
            this.textBoxRankingsSecond2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSecond2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSecond2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSecond2.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSecond2.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSecond2.Location = new System.Drawing.Point(397, 260);
            this.textBoxRankingsSecond2.Name = "textBoxRankingsSecond2";
            this.textBoxRankingsSecond2.ReadOnly = true;
            this.textBoxRankingsSecond2.Size = new System.Drawing.Size(256, 43);
            this.textBoxRankingsSecond2.TabIndex = 45;
            this.textBoxRankingsSecond2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSecond2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSixth2
            // 
            this.textBoxRankingsSixth2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSixth2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSixth2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSixth2.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSixth2.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSixth2.Location = new System.Drawing.Point(397, 517);
            this.textBoxRankingsSixth2.Name = "textBoxRankingsSixth2";
            this.textBoxRankingsSixth2.ReadOnly = true;
            this.textBoxRankingsSixth2.Size = new System.Drawing.Size(256, 43);
            this.textBoxRankingsSixth2.TabIndex = 46;
            this.textBoxRankingsSixth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSixth2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFourth
            // 
            this.textBoxRankingsFourth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFourth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFourth.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFourth.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFourth.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFourth.Location = new System.Drawing.Point(329, 388);
            this.textBoxRankingsFourth.Name = "textBoxRankingsFourth";
            this.textBoxRankingsFourth.ReadOnly = true;
            this.textBoxRankingsFourth.Size = new System.Drawing.Size(55, 43);
            this.textBoxRankingsFourth.TabIndex = 52;
            this.textBoxRankingsFourth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFourth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsThird
            // 
            this.textBoxRankingsThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsThird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsThird.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsThird.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsThird.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsThird.Location = new System.Drawing.Point(329, 323);
            this.textBoxRankingsThird.Name = "textBoxRankingsThird";
            this.textBoxRankingsThird.ReadOnly = true;
            this.textBoxRankingsThird.Size = new System.Drawing.Size(55, 43);
            this.textBoxRankingsThird.TabIndex = 57;
            this.textBoxRankingsThird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsThird.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsThird2
            // 
            this.textBoxRankingsThird2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsThird2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsThird2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsThird2.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsThird2.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsThird2.Location = new System.Drawing.Point(396, 323);
            this.textBoxRankingsThird2.Name = "textBoxRankingsThird2";
            this.textBoxRankingsThird2.ReadOnly = true;
            this.textBoxRankingsThird2.Size = new System.Drawing.Size(256, 43);
            this.textBoxRankingsThird2.TabIndex = 47;
            this.textBoxRankingsThird2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsThird2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFourth3
            // 
            this.textBoxRankingsFourth3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFourth3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFourth3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFourth3.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFourth3.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFourth3.Location = new System.Drawing.Point(656, 388);
            this.textBoxRankingsFourth3.Name = "textBoxRankingsFourth3";
            this.textBoxRankingsFourth3.ReadOnly = true;
            this.textBoxRankingsFourth3.Size = new System.Drawing.Size(155, 43);
            this.textBoxRankingsFourth3.TabIndex = 60;
            this.textBoxRankingsFourth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFourth3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSixth
            // 
            this.textBoxRankingsSixth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSixth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSixth.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSixth.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSixth.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSixth.Location = new System.Drawing.Point(329, 517);
            this.textBoxRankingsSixth.Name = "textBoxRankingsSixth";
            this.textBoxRankingsSixth.ReadOnly = true;
            this.textBoxRankingsSixth.Size = new System.Drawing.Size(55, 43);
            this.textBoxRankingsSixth.TabIndex = 53;
            this.textBoxRankingsSixth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSixth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsEighth
            // 
            this.textBoxRankingsEighth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsEighth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsEighth.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsEighth.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsEighth.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsEighth.Location = new System.Drawing.Point(329, 648);
            this.textBoxRankingsEighth.Name = "textBoxRankingsEighth";
            this.textBoxRankingsEighth.ReadOnly = true;
            this.textBoxRankingsEighth.Size = new System.Drawing.Size(55, 43);
            this.textBoxRankingsEighth.TabIndex = 55;
            this.textBoxRankingsEighth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsEighth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSeventh
            // 
            this.textBoxRankingsSeventh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSeventh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSeventh.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSeventh.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSeventh.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSeventh.Location = new System.Drawing.Point(329, 584);
            this.textBoxRankingsSeventh.Name = "textBoxRankingsSeventh";
            this.textBoxRankingsSeventh.ReadOnly = true;
            this.textBoxRankingsSeventh.Size = new System.Drawing.Size(55, 43);
            this.textBoxRankingsSeventh.TabIndex = 51;
            this.textBoxRankingsSeventh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSeventh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSeventh2
            // 
            this.textBoxRankingsSeventh2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSeventh2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSeventh2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSeventh2.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSeventh2.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSeventh2.Location = new System.Drawing.Point(397, 584);
            this.textBoxRankingsSeventh2.Name = "textBoxRankingsSeventh2";
            this.textBoxRankingsSeventh2.ReadOnly = true;
            this.textBoxRankingsSeventh2.Size = new System.Drawing.Size(256, 43);
            this.textBoxRankingsSeventh2.TabIndex = 48;
            this.textBoxRankingsSeventh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSeventh2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFifth2
            // 
            this.textBoxRankingsFifth2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFifth2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFifth2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFifth2.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFifth2.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFifth2.Location = new System.Drawing.Point(397, 453);
            this.textBoxRankingsFifth2.Name = "textBoxRankingsFifth2";
            this.textBoxRankingsFifth2.ReadOnly = true;
            this.textBoxRankingsFifth2.Size = new System.Drawing.Size(256, 43);
            this.textBoxRankingsFifth2.TabIndex = 49;
            this.textBoxRankingsFifth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFifth2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFifth3
            // 
            this.textBoxRankingsFifth3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFifth3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFifth3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFifth3.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFifth3.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFifth3.Location = new System.Drawing.Point(656, 453);
            this.textBoxRankingsFifth3.Name = "textBoxRankingsFifth3";
            this.textBoxRankingsFifth3.ReadOnly = true;
            this.textBoxRankingsFifth3.Size = new System.Drawing.Size(155, 43);
            this.textBoxRankingsFifth3.TabIndex = 61;
            this.textBoxRankingsFifth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFifth3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsFirst
            // 
            this.textBoxRankingsFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsFirst.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsFirst.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsFirst.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsFirst.Location = new System.Drawing.Point(329, 192);
            this.textBoxRankingsFirst.Name = "textBoxRankingsFirst";
            this.textBoxRankingsFirst.ReadOnly = true;
            this.textBoxRankingsFirst.Size = new System.Drawing.Size(55, 43);
            this.textBoxRankingsFirst.TabIndex = 50;
            this.textBoxRankingsFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsFirst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSixth3
            // 
            this.textBoxRankingsSixth3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSixth3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSixth3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSixth3.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSixth3.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSixth3.Location = new System.Drawing.Point(656, 517);
            this.textBoxRankingsSixth3.Name = "textBoxRankingsSixth3";
            this.textBoxRankingsSixth3.ReadOnly = true;
            this.textBoxRankingsSixth3.Size = new System.Drawing.Size(155, 43);
            this.textBoxRankingsSixth3.TabIndex = 63;
            this.textBoxRankingsSixth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSixth3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // textBoxRankingsSeventh3
            // 
            this.textBoxRankingsSeventh3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.textBoxRankingsSeventh3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRankingsSeventh3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRankingsSeventh3.Font = new System.Drawing.Font("Kelly Slab", 26.25F);
            this.textBoxRankingsSeventh3.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRankingsSeventh3.Location = new System.Drawing.Point(656, 584);
            this.textBoxRankingsSeventh3.Name = "textBoxRankingsSeventh3";
            this.textBoxRankingsSeventh3.ReadOnly = true;
            this.textBoxRankingsSeventh3.Size = new System.Drawing.Size(155, 43);
            this.textBoxRankingsSeventh3.TabIndex = 64;
            this.textBoxRankingsSeventh3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRankingsSeventh3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxesRankings_MouseDown);
            // 
            // pictureBoxRankingsHomeButton
            // 
            this.pictureBoxRankingsHomeButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRankingsHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxRankingsHomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRankingsHomeButton.Image = global::Millionaire_Client.Properties.Resources.back;
            this.pictureBoxRankingsHomeButton.Location = new System.Drawing.Point(40, 349);
            this.pictureBoxRankingsHomeButton.Name = "pictureBoxRankingsHomeButton";
            this.pictureBoxRankingsHomeButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxRankingsHomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRankingsHomeButton.TabIndex = 31;
            this.pictureBoxRankingsHomeButton.TabStop = false;
            this.pictureBoxRankingsHomeButton.Click += new System.EventHandler(this.pictureBoxRankingsHomeButton_Click);
            // 
            // pictureBoxRankingsTable
            // 
            this.pictureBoxRankingsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRankingsTable.Image = global::Millionaire_Client.Properties.Resources.morelines;
            this.pictureBoxRankingsTable.Location = new System.Drawing.Point(316, 86);
            this.pictureBoxRankingsTable.Name = "pictureBoxRankingsTable";
            this.pictureBoxRankingsTable.Size = new System.Drawing.Size(504, 619);
            this.pictureBoxRankingsTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRankingsTable.TabIndex = 30;
            this.pictureBoxRankingsTable.TabStop = false;
            // 
            // labelRankingsTitle
            // 
            this.labelRankingsTitle.AutoSize = true;
            this.labelRankingsTitle.Font = new System.Drawing.Font("Kelly Slab", 38.25F);
            this.labelRankingsTitle.ForeColor = System.Drawing.Color.White;
            this.labelRankingsTitle.Location = new System.Drawing.Point(408, 8);
            this.labelRankingsTitle.Name = "labelRankingsTitle";
            this.labelRankingsTitle.Size = new System.Drawing.Size(283, 62);
            this.labelRankingsTitle.TabIndex = 29;
            this.labelRankingsTitle.Text = "КЛАСАЦИЯ";
            // 
            // labelHomeCreditsNumber
            // 
            this.labelHomeCreditsNumber.Font = new System.Drawing.Font("Kelly Slab", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHomeCreditsNumber.ForeColor = System.Drawing.Color.Yellow;
            this.labelHomeCreditsNumber.Location = new System.Drawing.Point(690, 268);
            this.labelHomeCreditsNumber.Name = "labelHomeCreditsNumber";
            this.labelHomeCreditsNumber.Size = new System.Drawing.Size(310, 38);
            this.labelHomeCreditsNumber.TabIndex = 31;
            this.labelHomeCreditsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHomeUserName
            // 
            this.labelHomeUserName.AutoSize = true;
            this.labelHomeUserName.Font = new System.Drawing.Font("Kelly Slab", 17.25F);
            this.labelHomeUserName.ForeColor = System.Drawing.Color.White;
            this.labelHomeUserName.Location = new System.Drawing.Point(933, 38);
            this.labelHomeUserName.Name = "labelHomeUserName";
            this.labelHomeUserName.Size = new System.Drawing.Size(0, 28);
            this.labelHomeUserName.TabIndex = 30;
            // 
            // labelHomeYellowDot
            // 
            this.labelHomeYellowDot.AutoSize = true;
            this.labelHomeYellowDot.Font = new System.Drawing.Font("Kelly Slab", 43.25F);
            this.labelHomeYellowDot.ForeColor = System.Drawing.Color.Yellow;
            this.labelHomeYellowDot.Location = new System.Drawing.Point(873, 14);
            this.labelHomeYellowDot.Name = "labelHomeYellowDot";
            this.labelHomeYellowDot.Size = new System.Drawing.Size(73, 70);
            this.labelHomeYellowDot.TabIndex = 29;
            this.labelHomeYellowDot.Text = "●";
            // 
            // labelHomeCreditsMessage
            // 
            this.labelHomeCreditsMessage.AutoSize = true;
            this.labelHomeCreditsMessage.Font = new System.Drawing.Font("Kelly Slab", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHomeCreditsMessage.ForeColor = System.Drawing.Color.White;
            this.labelHomeCreditsMessage.Location = new System.Drawing.Point(690, 198);
            this.labelHomeCreditsMessage.Name = "labelHomeCreditsMessage";
            this.labelHomeCreditsMessage.Size = new System.Drawing.Size(310, 38);
            this.labelHomeCreditsMessage.TabIndex = 28;
            this.labelHomeCreditsMessage.Text = "Текущ брой кредити:";
            // 
            // pictureBoxHomeLogoutButton
            // 
            this.pictureBoxHomeLogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHomeLogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxHomeLogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHomeLogoutButton.Image = global::Millionaire_Client.Properties.Resources.logout;
            this.pictureBoxHomeLogoutButton.Location = new System.Drawing.Point(734, 619);
            this.pictureBoxHomeLogoutButton.Name = "pictureBoxHomeLogoutButton";
            this.pictureBoxHomeLogoutButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxHomeLogoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomeLogoutButton.TabIndex = 27;
            this.pictureBoxHomeLogoutButton.TabStop = false;
            this.pictureBoxHomeLogoutButton.Click += new System.EventHandler(this.pictureBoxHomeLogoutButton_Click);
            // 
            // pictureBoxHomeNewGameButton
            // 
            this.pictureBoxHomeNewGameButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHomeNewGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxHomeNewGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHomeNewGameButton.Image = global::Millionaire_Client.Properties.Resources.newgame;
            this.pictureBoxHomeNewGameButton.Location = new System.Drawing.Point(734, 391);
            this.pictureBoxHomeNewGameButton.Name = "pictureBoxHomeNewGameButton";
            this.pictureBoxHomeNewGameButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxHomeNewGameButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomeNewGameButton.TabIndex = 26;
            this.pictureBoxHomeNewGameButton.TabStop = false;
            this.pictureBoxHomeNewGameButton.Click += new System.EventHandler(this.pictureBoxHomeNewGameButton_Click);
            // 
            // pictureBoxHomeRankingsButton
            // 
            this.pictureBoxHomeRankingsButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHomeRankingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxHomeRankingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHomeRankingsButton.Image = global::Millionaire_Client.Properties.Resources.klasaciq;
            this.pictureBoxHomeRankingsButton.Location = new System.Drawing.Point(734, 505);
            this.pictureBoxHomeRankingsButton.Name = "pictureBoxHomeRankingsButton";
            this.pictureBoxHomeRankingsButton.Size = new System.Drawing.Size(221, 68);
            this.pictureBoxHomeRankingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomeRankingsButton.TabIndex = 25;
            this.pictureBoxHomeRankingsButton.TabStop = false;
            this.pictureBoxHomeRankingsButton.Click += new System.EventHandler(this.pictureBoxHomeRankingsButton_Click);
            // 
            // pictureBoxHomeLogo
            // 
            this.pictureBoxHomeLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHomeLogo.Image = global::Millionaire_Client.Properties.Resources.logofinal;
            this.pictureBoxHomeLogo.Location = new System.Drawing.Point(0, 103);
            this.pictureBoxHomeLogo.Name = "pictureBoxHomeLogo";
            this.pictureBoxHomeLogo.Size = new System.Drawing.Size(507, 453);
            this.pictureBoxHomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomeLogo.TabIndex = 24;
            this.pictureBoxHomeLogo.TabStop = false;
            // 
            // labelLoginErrorMessage
            // 
            this.labelLoginErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoginErrorMessage.AutoSize = true;
            this.labelLoginErrorMessage.Font = new System.Drawing.Font("Kelly Slab", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelLoginErrorMessage.Location = new System.Drawing.Point(296, 341);
            this.labelLoginErrorMessage.Name = "labelLoginErrorMessage";
            this.labelLoginErrorMessage.Size = new System.Drawing.Size(0, 22);
            this.labelLoginErrorMessage.TabIndex = 35;
            // 
            // pictureBoxLoginButton
            // 
            this.pictureBoxLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLoginButton.Image = global::Millionaire_Client.Properties.Resources.login;
            this.pictureBoxLoginButton.Location = new System.Drawing.Point(448, 593);
            this.pictureBoxLoginButton.Name = "pictureBoxLoginButton";
            this.pictureBoxLoginButton.Size = new System.Drawing.Size(201, 61);
            this.pictureBoxLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoginButton.TabIndex = 4;
            this.pictureBoxLoginButton.TabStop = false;
            this.pictureBoxLoginButton.Click += new System.EventHandler(this.pictureBoxLoginButton_Click);
            // 
            // pictureBoxLoginLogo
            // 
            this.pictureBoxLoginLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLoginLogo.Image = global::Millionaire_Client.Properties.Resources.logofinal;
            this.pictureBoxLoginLogo.Location = new System.Drawing.Point(300, -22);
            this.pictureBoxLoginLogo.Name = "pictureBoxLoginLogo";
            this.pictureBoxLoginLogo.Size = new System.Drawing.Size(517, 396);
            this.pictureBoxLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoginLogo.TabIndex = 0;
            this.pictureBoxLoginLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1144, 721);
            this.Controls.Add(this.panelPasswordRecovery);
            this.Controls.Add(this.textBoxLoginUserName);
            this.Controls.Add(this.labelLoginErrorMessage);
            this.Controls.Add(this.maskedTextBoxLoginPassword);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.labelLoginUserName);
            this.Controls.Add(this.linkLabelLoginPasswordRecovery);
            this.Controls.Add(this.linkLabelLoginRegister);
            this.Controls.Add(this.pictureBoxLoginButton);
            this.Controls.Add(this.pictureBoxLoginLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Стани магнат";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Login_Closing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelPasswordRecovery.ResumeLayout(false);
            this.panelPasswordRecovery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordRecoveryBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordRecoverySaveButton)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegisterBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegisterButton)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelRankings.ResumeLayout(false);
            this.panelRankings.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessageHomeButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameGiveUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame5050)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameSumTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameQuestionForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRankingsNextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRankingsPreviousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRankingsHomeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRankingsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeLogoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeNewGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeRankingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoginLogo;
        private System.Windows.Forms.PictureBox pictureBoxLoginButton;
        private System.Windows.Forms.LinkLabel linkLabelLoginRegister;
        private System.Windows.Forms.LinkLabel linkLabelLoginPasswordRecovery;
        private System.Windows.Forms.Label labelLoginUserName;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Label labelLoginErrorMessage;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginUserName;

        private System.Windows.Forms.Panel panelPasswordRecovery;
        private System.Windows.Forms.Label labelPasswordRecoveryTitle;
        private System.Windows.Forms.Label labelPasswordRecoveryOldPassword;
        private System.Windows.Forms.Label labelPasswordRecoveryNewPassword;
        private System.Windows.Forms.Label labelPasswordRecoveryErrorMessage;
        private System.Windows.Forms.Label labelPasswordRecoveryEmail;
        private System.Windows.Forms.TextBox textBoxPasswordRecoveryEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPasswordRecoveryNewPassword;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPasswordRecoveryOldPassword;
        private System.Windows.Forms.PictureBox pictureBoxPasswordRecoverySaveButton;
        private System.Windows.Forms.PictureBox pictureBoxPasswordRecoveryBackButton;

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelRegisterRepeatedPassword;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.Label labelRegisterEmail;
        private System.Windows.Forms.Label labelRegisterUserName;
        private System.Windows.Forms.Label labelRegisterTitle;
        private System.Windows.Forms.Label labelRegisterErrorMessage;
        private System.Windows.Forms.PictureBox pictureBoxRegisterBackButton;
        private System.Windows.Forms.PictureBox pictureBoxRegisterButton;
        private System.Windows.Forms.TextBox textBoxRegisterEmail;
        private System.Windows.Forms.TextBox textBoxRegisterUserName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegisterPassword;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegisterRepeatedPassword;

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label labelHomeCreditsNumber;
        private System.Windows.Forms.Label labelHomeUserName;
        private System.Windows.Forms.Label labelHomeYellowDot;
        private System.Windows.Forms.Label labelHomeCreditsMessage;
        private System.Windows.Forms.PictureBox pictureBoxHomeLogoutButton;
        private System.Windows.Forms.PictureBox pictureBoxHomeNewGameButton;
        private System.Windows.Forms.PictureBox pictureBoxHomeRankingsButton;
        private System.Windows.Forms.PictureBox pictureBoxHomeLogo;

        private System.Windows.Forms.Panel panelRankings;
        private System.Windows.Forms.TextBox textBoxRankingsFirst2;
        private System.Windows.Forms.TextBox textBoxRankingsFirst;
        private System.Windows.Forms.TextBox textBoxRankingsFifth2;
        private System.Windows.Forms.TextBox textBoxRankingsSeventh2;
        private System.Windows.Forms.TextBox textBoxRankingsThird2;
        private System.Windows.Forms.TextBox textBoxRankingsSixth2;
        private System.Windows.Forms.TextBox textBoxRankingsSecond2;
        private System.Windows.Forms.TextBox textBoxRankingsEighth2;
        private System.Windows.Forms.TextBox textBoxRankingsFourth2;
        private System.Windows.Forms.TextBox textBoxRankingsThird3;
        private System.Windows.Forms.TextBox textBoxRankingsFifth;
        private System.Windows.Forms.TextBox textBoxRankingsEighth3;
        private System.Windows.Forms.TextBox textBoxRankingsSecond;
        private System.Windows.Forms.TextBox textBoxRankingsSecond3;
        private System.Windows.Forms.TextBox textBoxRankingsFirst3;
        private System.Windows.Forms.TextBox textBoxRankingsFourth;
        private System.Windows.Forms.TextBox textBoxRankingsThird;
        private System.Windows.Forms.TextBox textBoxRankingsFourth3;
        private System.Windows.Forms.TextBox textBoxRankingsSixth;
        private System.Windows.Forms.TextBox textBoxRankingsEighth;
        private System.Windows.Forms.TextBox textBoxRankingsSeventh;
        private System.Windows.Forms.TextBox textBoxRankingsFifth3;
        private System.Windows.Forms.TextBox textBoxRankingsSixth3;
        private System.Windows.Forms.TextBox textBoxRankingsSeventh3;
        private System.Windows.Forms.PictureBox pictureBoxRankingsHomeButton;
        private System.Windows.Forms.PictureBox pictureBoxRankingsTable;
        private System.Windows.Forms.PictureBox pictureBoxRankingsNextButton;
        private System.Windows.Forms.PictureBox pictureBoxRankingsPreviousButton;
        private System.Windows.Forms.Label labelRankingsTitle;

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label labelGameHintBox;
        private System.Windows.Forms.Label labelGameAnswerD;
        private System.Windows.Forms.Label labelGameAnswerC;
        private System.Windows.Forms.Label labelGameAnswerB;
        private System.Windows.Forms.Label labelGameAnswerA;
        private System.Windows.Forms.Label labelGameQuestion;
        private System.Windows.Forms.PictureBox pictureBoxGameGiveUp;
        private System.Windows.Forms.PictureBox pictureBoxGameSearch;
        private System.Windows.Forms.PictureBox pictureBoxGameFriend;
        private System.Windows.Forms.PictureBox pictureBoxGame5050;
        private System.Windows.Forms.PictureBox pictureBoxGameLogo;
        private System.Windows.Forms.PictureBox pictureBoxGameSumTree;
        private System.Windows.Forms.PictureBox pictureBoxGameQuestionForm;

        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Label labelMessageTtitle;
        private System.Windows.Forms.Label labelMessageCreditsWonNumber;
        private System.Windows.Forms.PictureBox pictureBoxMessageHomeButon;

        private System.Net.Sockets.Socket socket;
        private System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer;
        private Thread clientRunnable;
        private System.Collections.Generic.List<string> responses;
        private System.Collections.Generic.HashSet<string> previousQuestions;
        private UserScore userScore;
        private Question currentQuestion;
        private int questionNumber;
        private System.Random random;
        private System.Collections.Generic.List<bool> usedLifelines;
        private int playerScoreIndex;
        private int firstScoreIndex;
    }
}

