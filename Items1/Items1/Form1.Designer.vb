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
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnTshirt = New System.Windows.Forms.Button()
        Me.btnHat = New System.Windows.Forms.Button()
        Me.btnShoes = New System.Windows.Forms.Button()
        Me.btnShorts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(12, 183)
        Me.lstItems.MultiColumn = True
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(410, 212)
        Me.lstItems.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(347, 12)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnTshirt
        '
        Me.btnTshirt.Location = New System.Drawing.Point(12, 12)
        Me.btnTshirt.Name = "btnTshirt"
        Me.btnTshirt.Size = New System.Drawing.Size(75, 23)
        Me.btnTshirt.TabIndex = 2
        Me.btnTshirt.Text = "T shirt"
        Me.btnTshirt.UseVisualStyleBackColor = True
        '
        'btnHat
        '
        Me.btnHat.Location = New System.Drawing.Point(93, 12)
        Me.btnHat.Name = "btnHat"
        Me.btnHat.Size = New System.Drawing.Size(75, 23)
        Me.btnHat.TabIndex = 3
        Me.btnHat.Text = "Hat"
        Me.btnHat.UseVisualStyleBackColor = True
        '
        'btnShoes
        '
        Me.btnShoes.Location = New System.Drawing.Point(12, 41)
        Me.btnShoes.Name = "btnShoes"
        Me.btnShoes.Size = New System.Drawing.Size(75, 23)
        Me.btnShoes.TabIndex = 4
        Me.btnShoes.Text = "Shoes"
        Me.btnShoes.UseVisualStyleBackColor = True
        '
        'btnShorts
        '
        Me.btnShorts.Location = New System.Drawing.Point(93, 41)
        Me.btnShorts.Name = "btnShorts"
        Me.btnShorts.Size = New System.Drawing.Size(75, 23)
        Me.btnShorts.TabIndex = 5
        Me.btnShorts.Text = "Shorts"
        Me.btnShorts.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 411)
        Me.Controls.Add(Me.btnShorts)
        Me.Controls.Add(Me.btnShoes)
        Me.Controls.Add(Me.btnHat)
        Me.Controls.Add(Me.btnTshirt)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstItems)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnTshirt As System.Windows.Forms.Button
    Friend WithEvents btnHat As System.Windows.Forms.Button
    Friend WithEvents btnShoes As System.Windows.Forms.Button
    Friend WithEvents btnShorts As System.Windows.Forms.Button

End Class
