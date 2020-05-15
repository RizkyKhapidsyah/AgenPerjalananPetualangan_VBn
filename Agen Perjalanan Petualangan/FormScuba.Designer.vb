<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScuba
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.teksBanyakOrang = New System.Windows.Forms.TextBox()
        Me.labelDiskon = New System.Windows.Forms.Label()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.tombolHitungTotal = New System.Windows.Forms.Button()
        Me.tombolReset = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banyak Orang Dalam Kelompok:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diskon (untuk 5 orang atau lebih):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'teksBanyakOrang
        '
        Me.teksBanyakOrang.Location = New System.Drawing.Point(185, 16)
        Me.teksBanyakOrang.Name = "teksBanyakOrang"
        Me.teksBanyakOrang.Size = New System.Drawing.Size(142, 20)
        Me.teksBanyakOrang.TabIndex = 3
        '
        'labelDiskon
        '
        Me.labelDiskon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelDiskon.Location = New System.Drawing.Point(185, 52)
        Me.labelDiskon.Name = "labelDiskon"
        Me.labelDiskon.Size = New System.Drawing.Size(142, 23)
        Me.labelDiskon.TabIndex = 4
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelTotal.Location = New System.Drawing.Point(185, 87)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(142, 23)
        Me.labelTotal.TabIndex = 5
        '
        'tombolHitungTotal
        '
        Me.tombolHitungTotal.Location = New System.Drawing.Point(15, 146)
        Me.tombolHitungTotal.Name = "tombolHitungTotal"
        Me.tombolHitungTotal.Size = New System.Drawing.Size(90, 38)
        Me.tombolHitungTotal.TabIndex = 6
        Me.tombolHitungTotal.Text = "Hitung Total"
        Me.tombolHitungTotal.UseVisualStyleBackColor = True
        '
        'tombolReset
        '
        Me.tombolReset.Location = New System.Drawing.Point(125, 146)
        Me.tombolReset.Name = "tombolReset"
        Me.tombolReset.Size = New System.Drawing.Size(90, 38)
        Me.tombolReset.TabIndex = 7
        Me.tombolReset.Text = "Reset Form"
        Me.tombolReset.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(237, 146)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(90, 38)
        Me.tombolKeluar.TabIndex = 8
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormScuba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 205)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolReset)
        Me.Controls.Add(Me.tombolHitungTotal)
        Me.Controls.Add(Me.labelTotal)
        Me.Controls.Add(Me.labelDiskon)
        Me.Controls.Add(Me.teksBanyakOrang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormScuba"
        Me.Text = "Petualangan Scuba Diving"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents teksBanyakOrang As System.Windows.Forms.TextBox
    Friend WithEvents labelDiskon As System.Windows.Forms.Label
    Friend WithEvents labelTotal As System.Windows.Forms.Label
    Friend WithEvents tombolHitungTotal As System.Windows.Forms.Button
    Friend WithEvents tombolReset As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button
End Class
