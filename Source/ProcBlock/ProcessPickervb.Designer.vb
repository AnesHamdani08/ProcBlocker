<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessPickervb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessPickervb))
        Me.ListPrcssPicker = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DBAddpicker = New System.Windows.Forms.Button()
        Me.DB_Add_Browse = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListPrcssPicker
        '
        Me.ListPrcssPicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPrcssPicker.FormattingEnabled = True
        Me.ListPrcssPicker.Location = New System.Drawing.Point(0, 0)
        Me.ListPrcssPicker.Name = "ListPrcssPicker"
        Me.ListPrcssPicker.Size = New System.Drawing.Size(375, 386)
        Me.ListPrcssPicker.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DB_Add_Browse)
        Me.Panel1.Controls.Add(Me.DBAddpicker)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 50)
        Me.Panel1.TabIndex = 1
        '
        'DBAddpicker
        '
        Me.DBAddpicker.BackgroundImage = Global.ProcBlock.My.Resources.Resources.add_to_database_icon
        Me.DBAddpicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DBAddpicker.FlatAppearance.BorderSize = 0
        Me.DBAddpicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DBAddpicker.Location = New System.Drawing.Point(132, 0)
        Me.DBAddpicker.Name = "DBAddpicker"
        Me.DBAddpicker.Size = New System.Drawing.Size(50, 50)
        Me.DBAddpicker.TabIndex = 2
        Me.DBAddpicker.UseVisualStyleBackColor = True
        '
        'DB_Add_Browse
        '
        Me.DB_Add_Browse.BackgroundImage = Global.ProcBlock.My.Resources.Resources.browse_icon
        Me.DB_Add_Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DB_Add_Browse.FlatAppearance.BorderSize = 0
        Me.DB_Add_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DB_Add_Browse.Location = New System.Drawing.Point(192, 0)
        Me.DB_Add_Browse.Name = "DB_Add_Browse"
        Me.DB_Add_Browse.Size = New System.Drawing.Size(50, 50)
        Me.DB_Add_Browse.TabIndex = 3
        Me.DB_Add_Browse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Executables|*.exe"
        '
        'ProcessPickervb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 386)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListPrcssPicker)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProcessPickervb"
        Me.Text = "Process Picker"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListPrcssPicker As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DBAddpicker As Button
    Friend WithEvents DB_Add_Browse As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
