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
        Me.go = New System.Windows.Forms.Button()
        Me.btnVariabel = New System.Windows.Forms.Button()
        Me.btnDataTypes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'go
        '
        Me.go.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.go.Location = New System.Drawing.Point(92, 41)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(273, 105)
        Me.go.TabIndex = 0
        Me.go.Text = "Go"
        Me.go.UseVisualStyleBackColor = False
        '
        'btnVariabel
        '
        Me.btnVariabel.Location = New System.Drawing.Point(387, 41)
        Me.btnVariabel.Name = "btnVariabel"
        Me.btnVariabel.Size = New System.Drawing.Size(279, 105)
        Me.btnVariabel.TabIndex = 1
        Me.btnVariabel.Text = "Variabel Demonstration"
        Me.btnVariabel.UseVisualStyleBackColor = True
        '
        'btnDataTypes
        '
        Me.btnDataTypes.Location = New System.Drawing.Point(92, 158)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(272, 95)
        Me.btnDataTypes.TabIndex = 2
        Me.btnDataTypes.Text = "Data Types"
        Me.btnDataTypes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(271, 82)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(509, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 83)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.btnVariabel)
        Me.Controls.Add(Me.go)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents go As Button
    Friend WithEvents btnVariabel As Button
    Friend WithEvents btnDataTypes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
