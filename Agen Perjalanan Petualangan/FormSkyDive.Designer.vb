<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSkyDive
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
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.tombolReset = New System.Windows.Forms.Button()
        Me.tombolHitungTotal = New System.Windows.Forms.Button()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.labelDiskon = New System.Windows.Forms.Label()
        Me.teksBanyakOrang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(241, 139)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(90, 38)
        Me.tombolKeluar.TabIndex = 17
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'tombolReset
        '
        Me.tombolReset.Location = New System.Drawing.Point(129, 139)
        Me.tombolReset.Name = "tombolReset"
        Me.tombolReset.Size = New System.Drawing.Size(90, 38)
        Me.tombolReset.TabIndex = 16
        Me.tombolReset.Text = "Reset Form"
        Me.tombolReset.UseVisualStyleBackColor = True
        '
        'tombolHitungTotal
        '
        Me.tombolHitungTotal.Location = New System.Drawing.Point(19, 139)
        Me.tombolHitungTotal.Name = "tombolHitungTotal"
        Me.tombolHitungTotal.Size = New System.Drawing.Size(90, 38)
        Me.tombolHitungTotal.TabIndex = 15
        Me.tombolHitungTotal.Text = "Hitung Total"
        Me.tombolHitungTotal.UseVisualStyleBackColor = True
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelTotal.Location = New System.Drawing.Point(189, 80)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(142, 23)
        Me.labelTotal.TabIndex = 14
        '
        'labelDiskon
        '
        Me.labelDiskon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelDiskon.Location = New System.Drawing.Point(189, 45)
        Me.labelDiskon.Name = "labelDiskon"
        Me.labelDiskon.Size = New System.Drawing.Size(142, 23)
        Me.labelDiskon.TabIndex = 13
        '
        'teksBanyakOrang
        '
        Me.teksBanyakOrang.Location = New System.Drawing.Point(189, 9)
        Me.teksBanyakOrang.Name = "teksBanyakOrang"
        Me.teksBanyakOrang.Size = New System.Drawing.Size(142, 20)
        Me.teksBanyakOrang.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Diskon (untuk 5 orang atau lebih):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Banyak Orang Dalam Kelompok:"
        '
        'FormSkyDive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 186)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolReset)
        Me.Controls.Add(Me.tombolHitungTotal)
        Me.Controls.Add(Me.labelTotal)
        Me.Controls.Add(Me.labelDiskon)
        Me.Controls.Add(Me.teksBanyakOrang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSkyDive"
        Me.Text = "Petualangan Sky Diving"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button
    Friend WithEvents tombolReset As System.Windows.Forms.Button
    Friend WithEvents tombolHitungTotal As System.Windows.Forms.Button
    Friend WithEvents labelTotal As System.Windows.Forms.Label
    Friend WithEvents labelDiskon As System.Windows.Forms.Label
    Friend WithEvents teksBanyakOrang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
