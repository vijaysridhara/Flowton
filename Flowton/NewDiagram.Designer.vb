<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDiagram
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
        Me.chkLibs = New System.Windows.Forms.CheckedListBox()
        Me.lblLibs = New System.Windows.Forms.Label()
        Me.butOK = New System.Windows.Forms.Button()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.optPortrait = New System.Windows.Forms.RadioButton()
        Me.optLandscape = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'chkLibs
        '
        Me.chkLibs.CheckOnClick = True
        Me.chkLibs.FormattingEnabled = True
        Me.chkLibs.Location = New System.Drawing.Point(12, 25)
        Me.chkLibs.Name = "chkLibs"
        Me.chkLibs.Size = New System.Drawing.Size(466, 214)
        Me.chkLibs.TabIndex = 1
        '
        'lblLibs
        '
        Me.lblLibs.AutoSize = True
        Me.lblLibs.Location = New System.Drawing.Point(9, 9)
        Me.lblLibs.Name = "lblLibs"
        Me.lblLibs.Size = New System.Drawing.Size(118, 13)
        Me.lblLibs.TabIndex = 0
        Me.lblLibs.Text = "&Select the diagram type"
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(332, 260)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(75, 23)
        Me.butOK.TabIndex = 4
        Me.butOK.Text = "O&K"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(413, 260)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(75, 23)
        Me.butCancel.TabIndex = 5
        Me.butCancel.Text = "&Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'optPortrait
        '
        Me.optPortrait.AutoSize = True
        Me.optPortrait.Location = New System.Drawing.Point(96, 260)
        Me.optPortrait.Name = "optPortrait"
        Me.optPortrait.Size = New System.Drawing.Size(58, 17)
        Me.optPortrait.TabIndex = 3
        Me.optPortrait.Text = "&Portrait"
        Me.optPortrait.UseVisualStyleBackColor = True
        '
        'optLandscape
        '
        Me.optLandscape.AutoSize = True
        Me.optLandscape.Checked = True
        Me.optLandscape.Location = New System.Drawing.Point(12, 260)
        Me.optLandscape.Name = "optLandscape"
        Me.optLandscape.Size = New System.Drawing.Size(78, 17)
        Me.optLandscape.TabIndex = 2
        Me.optLandscape.TabStop = True
        Me.optLandscape.Text = "&Landscape"
        Me.optLandscape.UseVisualStyleBackColor = True
        '
        'NewDiagram
        '
        Me.AcceptButton = Me.butOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancel
        Me.ClientSize = New System.Drawing.Size(500, 295)
        Me.Controls.Add(Me.optLandscape)
        Me.Controls.Add(Me.optPortrait)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.lblLibs)
        Me.Controls.Add(Me.chkLibs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NewDiagram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Diagram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkLibs As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblLibs As System.Windows.Forms.Label
    Friend WithEvents butOK As System.Windows.Forms.Button
    Friend WithEvents butCancel As System.Windows.Forms.Button
    Friend WithEvents optPortrait As System.Windows.Forms.RadioButton
    Friend WithEvents optLandscape As System.Windows.Forms.RadioButton
End Class
