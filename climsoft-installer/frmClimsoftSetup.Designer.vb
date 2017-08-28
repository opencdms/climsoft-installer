<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClimsoftSetup
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
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.cmdSetup = New System.Windows.Forms.Button()
        Me.pgbProgress = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblDatabase1 = New System.Windows.Forms.Label()
        Me.lblDatabase2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(119, 105)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(218, 20)
        Me.txtUser.TabIndex = 0
        Me.txtUser.Text = "root"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(119, 131)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(218, 20)
        Me.txtPass.TabIndex = 1
        Me.txtPass.Text = "admin"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(119, 173)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(218, 20)
        Me.txtServer.TabIndex = 2
        Me.txtServer.Text = "127.0.0.1"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(119, 199)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(218, 20)
        Me.txtPort.TabIndex = 4
        Me.txtPort.Text = "3306"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(45, 108)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 13)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "Username"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(45, 134)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 6
        Me.lblPass.Text = "Password"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(45, 176)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(38, 13)
        Me.lblServer.TabIndex = 7
        Me.lblServer.Text = "Server"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(45, 202)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 9
        Me.lblPort.Text = "Port"
        '
        'cmdSetup
        '
        Me.cmdSetup.Location = New System.Drawing.Point(148, 267)
        Me.cmdSetup.Name = "cmdSetup"
        Me.cmdSetup.Size = New System.Drawing.Size(114, 37)
        Me.cmdSetup.TabIndex = 10
        Me.cmdSetup.Text = "Setup Database"
        Me.cmdSetup.UseVisualStyleBackColor = True
        '
        'pgbProgress
        '
        Me.pgbProgress.Location = New System.Drawing.Point(119, 225)
        Me.pgbProgress.Name = "pgbProgress"
        Me.pgbProgress.Size = New System.Drawing.Size(218, 23)
        Me.pgbProgress.TabIndex = 11
        Me.pgbProgress.Visible = False
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(45, 229)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(48, 13)
        Me.lblProgress.TabIndex = 12
        Me.lblProgress.Text = "Progress"
        Me.lblProgress.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(45, 25)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(275, 13)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.Text = "Create the following databases for Climsoft 4.0:"
        '
        'lblDatabase1
        '
        Me.lblDatabase1.AutoSize = True
        Me.lblDatabase1.Location = New System.Drawing.Point(116, 50)
        Me.lblDatabase1.Name = "lblDatabase1"
        Me.lblDatabase1.Size = New System.Drawing.Size(121, 13)
        Me.lblDatabase1.TabIndex = 14
        Me.lblDatabase1.Text = "mariadb_climsoft_db_v4"
        '
        'lblDatabase2
        '
        Me.lblDatabase2.AutoSize = True
        Me.lblDatabase2.Location = New System.Drawing.Point(116, 72)
        Me.lblDatabase2.Name = "lblDatabase2"
        Me.lblDatabase2.Size = New System.Drawing.Size(144, 13)
        Me.lblDatabase2.TabIndex = 15
        Me.lblDatabase2.Text = "mariadb_climsoft_test_db_v4"
        '
        'frmClimsoftSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 325)
        Me.Controls.Add(Me.lblDatabase2)
        Me.Controls.Add(Me.lblDatabase1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.pgbProgress)
        Me.Controls.Add(Me.cmdSetup)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Name = "frmClimsoftSetup"
        Me.Text = "Climsoft Database Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblServer As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents cmdSetup As Button
    Friend WithEvents pgbProgress As ProgressBar
    Friend WithEvents lblProgress As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblDatabase1 As Label
    Friend WithEvents lblDatabase2 As Label
End Class
