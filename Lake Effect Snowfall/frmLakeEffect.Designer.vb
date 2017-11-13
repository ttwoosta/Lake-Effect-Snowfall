<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLakeEffect
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
        Me.picLakeEffect = New System.Windows.Forms.PictureBox()
        Me.mnuLakeEffect = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnterSnowfallAmounts = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstSnowfall = New System.Windows.Forms.ListBox()
        Me.btnEnterSnowfallAmounts = New System.Windows.Forms.Button()
        Me.lblTotalSnowfallLabel = New System.Windows.Forms.Label()
        Me.lblTotalSnowfall = New System.Windows.Forms.Label()
        CType(Me.picLakeEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuLakeEffect.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLakeEffect
        '
        Me.picLakeEffect.Image = Global.Lake_Effect_Snowfall.My.Resources.Resources.lake_effect
        Me.picLakeEffect.Location = New System.Drawing.Point(0, 291)
        Me.picLakeEffect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLakeEffect.Name = "picLakeEffect"
        Me.picLakeEffect.Size = New System.Drawing.Size(394, 228)
        Me.picLakeEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLakeEffect.TabIndex = 0
        Me.picLakeEffect.TabStop = False
        '
        'mnuLakeEffect
        '
        Me.mnuLakeEffect.BackColor = System.Drawing.Color.PowderBlue
        Me.mnuLakeEffect.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLakeEffect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuLakeEffect.Location = New System.Drawing.Point(0, 0)
        Me.mnuLakeEffect.Name = "mnuLakeEffect"
        Me.mnuLakeEffect.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnuLakeEffect.Size = New System.Drawing.Size(394, 24)
        Me.mnuLakeEffect.TabIndex = 1
        Me.mnuLakeEffect.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.PowderBlue
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEnterSnowfallAmounts, Me.mnuClear, Me.mnuSeparator1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(41, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(214, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuSeparator1
        '
        Me.mnuSeparator1.Name = "mnuSeparator1"
        Me.mnuSeparator1.Size = New System.Drawing.Size(211, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(214, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuEnterSnowfallAmounts
        '
        Me.mnuEnterSnowfallAmounts.Name = "mnuEnterSnowfallAmounts"
        Me.mnuEnterSnowfallAmounts.Size = New System.Drawing.Size(214, 22)
        Me.mnuEnterSnowfallAmounts.Text = "&Enter Snowfall Amounts"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(72, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(250, 30)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Lake Effect Snowfall"
        '
        'lstSnowfall
        '
        Me.lstSnowfall.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSnowfall.FormattingEnabled = True
        Me.lstSnowfall.ItemHeight = 22
        Me.lstSnowfall.Items.AddRange(New Object() {"56.4", "15.8", "72.8", "15.4", "12.5", "16.4", "12.5"})
        Me.lstSnowfall.Location = New System.Drawing.Point(51, 93)
        Me.lstSnowfall.Name = "lstSnowfall"
        Me.lstSnowfall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSnowfall.Size = New System.Drawing.Size(68, 158)
        Me.lstSnowfall.TabIndex = 3
        '
        'btnEnterSnowfallAmounts
        '
        Me.btnEnterSnowfallAmounts.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnEnterSnowfallAmounts.Location = New System.Drawing.Point(164, 110)
        Me.btnEnterSnowfallAmounts.Name = "btnEnterSnowfallAmounts"
        Me.btnEnterSnowfallAmounts.Size = New System.Drawing.Size(168, 31)
        Me.btnEnterSnowfallAmounts.TabIndex = 4
        Me.btnEnterSnowfallAmounts.Text = "Enter Snowfall Amounts"
        Me.btnEnterSnowfallAmounts.UseVisualStyleBackColor = False
        '
        'lblTotalSnowfallLabel
        '
        Me.lblTotalSnowfallLabel.AutoSize = True
        Me.lblTotalSnowfallLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSnowfallLabel.Location = New System.Drawing.Point(151, 175)
        Me.lblTotalSnowfallLabel.Name = "lblTotalSnowfallLabel"
        Me.lblTotalSnowfallLabel.Size = New System.Drawing.Size(194, 18)
        Me.lblTotalSnowfallLabel.TabIndex = 5
        Me.lblTotalSnowfallLabel.Text = "Total snowfall accumulation"
        '
        'lblTotalSnowfall
        '
        Me.lblTotalSnowfall.AutoSize = True
        Me.lblTotalSnowfall.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSnowfall.Location = New System.Drawing.Point(196, 214)
        Me.lblTotalSnowfall.Name = "lblTotalSnowfall"
        Me.lblTotalSnowfall.Size = New System.Drawing.Size(104, 19)
        Me.lblTotalSnowfall.TabIndex = 6
        Me.lblTotalSnowfall.Text = "215.7 inches"
        '
        'frmLakeEffect
        '
        Me.AcceptButton = Me.btnEnterSnowfallAmounts
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(394, 518)
        Me.Controls.Add(Me.lblTotalSnowfall)
        Me.Controls.Add(Me.lblTotalSnowfallLabel)
        Me.Controls.Add(Me.btnEnterSnowfallAmounts)
        Me.Controls.Add(Me.lstSnowfall)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLakeEffect)
        Me.Controls.Add(Me.mnuLakeEffect)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuLakeEffect
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLakeEffect"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lake Effect Snowfall"
        CType(Me.picLakeEffect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuLakeEffect.ResumeLayout(False)
        Me.mnuLakeEffect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLakeEffect As PictureBox
    Friend WithEvents mnuLakeEffect As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuEnterSnowfallAmounts As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuSeparator1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lstSnowfall As ListBox
    Friend WithEvents btnEnterSnowfallAmounts As Button
    Friend WithEvents lblTotalSnowfallLabel As Label
    Friend WithEvents lblTotalSnowfall As Label
End Class
