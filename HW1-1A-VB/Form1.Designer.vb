<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finestra
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
        Me.bottoneTesto = New System.Windows.Forms.Button()
        Me.bottonePalla = New System.Windows.Forms.Button()
        Me.spazioTesto = New System.Windows.Forms.RichTextBox()
        Me.rettangoloPalla = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'bottoneTesto
        '
        Me.bottoneTesto.Location = New System.Drawing.Point(13, 13)
        Me.bottoneTesto.Name = "bottoneTesto"
        Me.bottoneTesto.Size = New System.Drawing.Size(125, 23)
        Me.bottoneTesto.TabIndex = 0
        Me.bottoneTesto.Text = "Stampa Testo"
        Me.bottoneTesto.UseVisualStyleBackColor = True
        '
        'bottonePalla
        '
        Me.bottonePalla.Location = New System.Drawing.Point(12, 124)
        Me.bottonePalla.Name = "bottonePalla"
        Me.bottonePalla.Size = New System.Drawing.Size(125, 23)
        Me.bottonePalla.TabIndex = 1
        Me.bottonePalla.Text = "Muovi Palla"
        Me.bottonePalla.UseVisualStyleBackColor = True
        '
        'spazioTesto
        '
        Me.spazioTesto.Location = New System.Drawing.Point(13, 42)
        Me.spazioTesto.Name = "spazioTesto"
        Me.spazioTesto.Size = New System.Drawing.Size(125, 76)
        Me.spazioTesto.TabIndex = 2
        Me.spazioTesto.Text = ""
        '
        'rettangoloPalla
        '
        Me.rettangoloPalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rettangoloPalla.Location = New System.Drawing.Point(13, 153)
        Me.rettangoloPalla.Name = "rettangoloPalla"
        Me.rettangoloPalla.Size = New System.Drawing.Size(419, 323)
        Me.rettangoloPalla.TabIndex = 3
        '
        'Finestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 488)
        Me.Controls.Add(Me.rettangoloPalla)
        Me.Controls.Add(Me.spazioTesto)
        Me.Controls.Add(Me.bottonePalla)
        Me.Controls.Add(Me.bottoneTesto)
        Me.Name = "Finestra"
        Me.Text = "Finestra"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bottoneTesto As Button
    Friend WithEvents bottonePalla As Button
    Friend WithEvents spazioTesto As RichTextBox
    Friend WithEvents rettangoloPalla As Panel
End Class
