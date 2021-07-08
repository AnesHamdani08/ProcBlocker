<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrcsManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrcsManager))
        Me.ListPrcs = New System.Windows.Forms.ListBox()
        Me.DBDownload = New System.Windows.Forms.Button()
        Me.DBUpload = New System.Windows.Forms.Button()
        Me.DBClear = New System.Windows.Forms.Button()
        Me.DBRemove = New System.Windows.Forms.Button()
        Me.DBAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListPrcs
        '
        Me.ListPrcs.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListPrcs.FormattingEnabled = True
        Me.ListPrcs.Location = New System.Drawing.Point(0, 0)
        Me.ListPrcs.Name = "ListPrcs"
        Me.ListPrcs.Size = New System.Drawing.Size(378, 238)
        Me.ListPrcs.TabIndex = 0
        '
        'DBDownload
        '
        Me.DBDownload.BackgroundImage = Global.ProcBlock.My.Resources.Resources.download_database_icon
        Me.DBDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DBDownload.FlatAppearance.BorderSize = 0
        Me.DBDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DBDownload.Location = New System.Drawing.Point(292, 256)
        Me.DBDownload.Name = "DBDownload"
        Me.DBDownload.Size = New System.Drawing.Size(64, 64)
        Me.DBDownload.TabIndex = 5
        Me.DBDownload.UseVisualStyleBackColor = True
        '
        'DBUpload
        '
        Me.DBUpload.BackgroundImage = Global.ProcBlock.My.Resources.Resources.Database_Upload_icon
        Me.DBUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DBUpload.FlatAppearance.BorderSize = 0
        Me.DBUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DBUpload.Location = New System.Drawing.Point(222, 256)
        Me.DBUpload.Name = "DBUpload"
        Me.DBUpload.Size = New System.Drawing.Size(64, 64)
        Me.DBUpload.TabIndex = 4
        Me.DBUpload.UseVisualStyleBackColor = True
        '
        'DBClear
        '
        Me.DBClear.BackgroundImage = Global.ProcBlock.My.Resources.Resources.Misc_Delete_Database_icon
        Me.DBClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DBClear.FlatAppearance.BorderSize = 0
        Me.DBClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DBClear.Location = New System.Drawing.Point(152, 256)
        Me.DBClear.Name = "DBClear"
        Me.DBClear.Size = New System.Drawing.Size(64, 64)
        Me.DBClear.TabIndex = 3
        Me.DBClear.UseVisualStyleBackColor = True
        '
        'DBRemove
        '
        Me.DBRemove.BackgroundImage = Global.ProcBlock.My.Resources.Resources.remove_from_database_icon
        Me.DBRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DBRemove.FlatAppearance.BorderSize = 0
        Me.DBRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DBRemove.Location = New System.Drawing.Point(82, 256)
        Me.DBRemove.Name = "DBRemove"
        Me.DBRemove.Size = New System.Drawing.Size(64, 64)
        Me.DBRemove.TabIndex = 2
        Me.DBRemove.UseVisualStyleBackColor = True
        '
        'DBAdd
        '
        Me.DBAdd.BackgroundImage = Global.ProcBlock.My.Resources.Resources.add_to_database_icon
        Me.DBAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DBAdd.FlatAppearance.BorderSize = 0
        Me.DBAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DBAdd.Location = New System.Drawing.Point(12, 256)
        Me.DBAdd.Name = "DBAdd"
        Me.DBAdd.Size = New System.Drawing.Size(64, 64)
        Me.DBAdd.TabIndex = 1
        Me.DBAdd.UseVisualStyleBackColor = True
        '
        'PrcsManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 332)
        Me.Controls.Add(Me.ListPrcs)
        Me.Controls.Add(Me.DBDownload)
        Me.Controls.Add(Me.DBUpload)
        Me.Controls.Add(Me.DBClear)
        Me.Controls.Add(Me.DBRemove)
        Me.Controls.Add(Me.DBAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrcsManager"
        Me.Text = "Procces Manager"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListPrcs As ListBox
    Friend WithEvents DBAdd As Button
    Friend WithEvents DBRemove As Button
    Friend WithEvents DBClear As Button
    Friend WithEvents DBUpload As Button
    Friend WithEvents DBDownload As Button
End Class
