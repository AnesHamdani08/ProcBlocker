<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TurnOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendToTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusPrcsRnng = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDatabaseCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusBlocked = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusAllowedprcs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusWorkMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UiManager = New System.Windows.Forms.Timer(Me.components)
        Me.ProcessWatcher = New System.Windows.Forms.Timer(Me.components)
        Me.PerformanceCounter = New System.Diagnostics.PerformanceCounter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_startminimizeatrun = New System.Windows.Forms.CheckBox()
        Me.cb_enableatrun = New System.Windows.Forms.CheckBox()
        Me.cb_runatstartup = New System.Windows.Forms.CheckBox()
        Me.LinkChangepsw = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainMenu.SuspendLayout()
        Me.MainStatus.SuspendLayout()
        CType(Me.PerformanceCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.NotifyMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.SendToTrayToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(645, 24)
        Me.MainMenu.TabIndex = 0
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProccessToolStripMenuItem, Me.ToolStripSeparator1, Me.TurnOnToolStripMenuItem, Me.TurnOffToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.GeneralToolStripMenuItem.Image = Global.ProcBlock.My.Resources.Resources.Settings_icon
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'AddProccessToolStripMenuItem
        '
        Me.AddProccessToolStripMenuItem.Image = Global.ProcBlock.My.Resources.Resources.process_info_icon
        Me.AddProccessToolStripMenuItem.Name = "AddProccessToolStripMenuItem"
        Me.AddProccessToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AddProccessToolStripMenuItem.Text = "Process Manager"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'TurnOnToolStripMenuItem
        '
        Me.TurnOnToolStripMenuItem.Image = Global.ProcBlock.My.Resources.Resources.switch_on_icon
        Me.TurnOnToolStripMenuItem.Name = "TurnOnToolStripMenuItem"
        Me.TurnOnToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TurnOnToolStripMenuItem.Text = "Turn On"
        '
        'TurnOffToolStripMenuItem
        '
        Me.TurnOffToolStripMenuItem.Image = Global.ProcBlock.My.Resources.Resources.switch_off_icon
        Me.TurnOffToolStripMenuItem.Name = "TurnOffToolStripMenuItem"
        Me.TurnOffToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TurnOffToolStripMenuItem.Text = "Turn Off"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.ProcBlock.My.Resources.Resources.Alarm_Error_icon
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SendToTrayToolStripMenuItem
        '
        Me.SendToTrayToolStripMenuItem.Name = "SendToTrayToolStripMenuItem"
        Me.SendToTrayToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.SendToTrayToolStripMenuItem.Text = "Minimize To Tray"
        '
        'MainStatus
        '
        Me.MainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusPrcsRnng, Me.ToolStripStatusDatabaseCount, Me.ToolStripStatusBlocked, Me.ToolStripStatusAllowedprcs, Me.ToolStripStatusWorkMode})
        Me.MainStatus.Location = New System.Drawing.Point(0, 347)
        Me.MainStatus.Name = "MainStatus"
        Me.MainStatus.Size = New System.Drawing.Size(645, 22)
        Me.MainStatus.TabIndex = 1
        '
        'ToolStripStatusPrcsRnng
        '
        Me.ToolStripStatusPrcsRnng.Image = Global.ProcBlock.My.Resources.Resources.process_info_icon
        Me.ToolStripStatusPrcsRnng.Name = "ToolStripStatusPrcsRnng"
        Me.ToolStripStatusPrcsRnng.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusPrcsRnng.Text = "Running: 00"
        '
        'ToolStripStatusDatabaseCount
        '
        Me.ToolStripStatusDatabaseCount.Image = Global.ProcBlock.My.Resources.Resources.Data_icon
        Me.ToolStripStatusDatabaseCount.Name = "ToolStripStatusDatabaseCount"
        Me.ToolStripStatusDatabaseCount.Size = New System.Drawing.Size(89, 17)
        Me.ToolStripStatusDatabaseCount.Text = "Database: 00"
        '
        'ToolStripStatusBlocked
        '
        Me.ToolStripStatusBlocked.Image = Global.ProcBlock.My.Resources.Resources.process_warning_icon
        Me.ToolStripStatusBlocked.Name = "ToolStripStatusBlocked"
        Me.ToolStripStatusBlocked.Size = New System.Drawing.Size(83, 17)
        Me.ToolStripStatusBlocked.Text = "Blocked: 00"
        '
        'ToolStripStatusAllowedprcs
        '
        Me.ToolStripStatusAllowedprcs.Image = Global.ProcBlock.My.Resources.Resources.process_accept_icon__1_
        Me.ToolStripStatusAllowedprcs.Name = "ToolStripStatusAllowedprcs"
        Me.ToolStripStatusAllowedprcs.Size = New System.Drawing.Size(84, 17)
        Me.ToolStripStatusAllowedprcs.Text = "Allowed: 00"
        '
        'ToolStripStatusWorkMode
        '
        Me.ToolStripStatusWorkMode.Image = Global.ProcBlock.My.Resources.Resources.switch_on_icon
        Me.ToolStripStatusWorkMode.Name = "ToolStripStatusWorkMode"
        Me.ToolStripStatusWorkMode.Size = New System.Drawing.Size(93, 17)
        Me.ToolStripStatusWorkMode.Text = "Mode: Active"
        '
        'UiManager
        '
        '
        'ProcessWatcher
        '
        '
        'PerformanceCounter
        '
        Me.PerformanceCounter.CategoryName = "Processor"
        Me.PerformanceCounter.CounterName = "% Processor Time"
        Me.PerformanceCounter.InstanceName = "_Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_startminimizeatrun)
        Me.GroupBox1.Controls.Add(Me.cb_enableatrun)
        Me.GroupBox1.Controls.Add(Me.cb_runatstartup)
        Me.GroupBox1.Controls.Add(Me.LinkChangepsw)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 158)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'cb_startminimizeatrun
        '
        Me.cb_startminimizeatrun.AutoSize = True
        Me.cb_startminimizeatrun.Location = New System.Drawing.Point(18, 116)
        Me.cb_startminimizeatrun.Name = "cb_startminimizeatrun"
        Me.cb_startminimizeatrun.Size = New System.Drawing.Size(335, 24)
        Me.cb_startminimizeatrun.TabIndex = 4
        Me.cb_startminimizeatrun.Text = "Start service and minimize at application run"
        Me.cb_startminimizeatrun.UseVisualStyleBackColor = True
        '
        'cb_enableatrun
        '
        Me.cb_enableatrun.AutoSize = True
        Me.cb_enableatrun.Location = New System.Drawing.Point(18, 86)
        Me.cb_enableatrun.Name = "cb_enableatrun"
        Me.cb_enableatrun.Size = New System.Drawing.Size(237, 24)
        Me.cb_enableatrun.TabIndex = 3
        Me.cb_enableatrun.Text = "Start service at application run"
        Me.cb_enableatrun.UseVisualStyleBackColor = True
        '
        'cb_runatstartup
        '
        Me.cb_runatstartup.AutoSize = True
        Me.cb_runatstartup.Location = New System.Drawing.Point(18, 56)
        Me.cb_runatstartup.Name = "cb_runatstartup"
        Me.cb_runatstartup.Size = New System.Drawing.Size(125, 24)
        Me.cb_runatstartup.TabIndex = 2
        Me.cb_runatstartup.Text = "Run at startup"
        Me.cb_runatstartup.UseVisualStyleBackColor = True
        '
        'LinkChangepsw
        '
        Me.LinkChangepsw.AutoSize = True
        Me.LinkChangepsw.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkChangepsw.Location = New System.Drawing.Point(87, 25)
        Me.LinkChangepsw.Name = "LinkChangepsw"
        Me.LinkChangepsw.Size = New System.Drawing.Size(51, 17)
        Me.LinkChangepsw.TabIndex = 1
        Me.LinkChangepsw.TabStop = True
        Me.LinkChangepsw.Text = "Change"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.NotifyMenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "ProcBlock"
        Me.NotifyIcon.Visible = True
        '
        'NotifyMenu
        '
        Me.NotifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.NotifyMenu.Name = "NotifyMenu"
        Me.NotifyMenu.Size = New System.Drawing.Size(114, 48)
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 323)
        Me.Panel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 369)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MainStatus)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "Form1"
        Me.Text = "ProcBlock"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.MainStatus.ResumeLayout(False)
        Me.MainStatus.PerformLayout()
        CType(Me.PerformanceCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.NotifyMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TurnOffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainStatus As StatusStrip
    Friend WithEvents ToolStripStatusPrcsRnng As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDatabaseCount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusBlocked As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusWorkMode As ToolStripStatusLabel
    Friend WithEvents UiManager As Timer
    Friend WithEvents ProcessWatcher As Timer
    Friend WithEvents PerformanceCounter As PerformanceCounter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkChangepsw As LinkLabel
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents TurnOnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripStatusAllowedprcs As ToolStripStatusLabel
    Friend WithEvents cb_enableatrun As CheckBox
    Friend WithEvents cb_runatstartup As CheckBox
    Friend WithEvents SendToTrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyMenu As ContextMenuStrip
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cb_startminimizeatrun As CheckBox
    Friend WithEvents Panel1 As Panel
End Class
