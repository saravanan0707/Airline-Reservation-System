<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSubject = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMessage = New System.Windows.Forms.RichTextBox()
        Me.BtnSendMail = New System.Windows.Forms.Button()
        Me.TxtTo = New System.Windows.Forms.TextBox()
        Me.TxtFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 36)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "  CONTACT US"
        '
        'TxtSubject
        '
        Me.TxtSubject.Location = New System.Drawing.Point(182, 198)
        Me.TxtSubject.Name = "TxtSubject"
        Me.TxtSubject.Size = New System.Drawing.Size(219, 22)
        Me.TxtSubject.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(45, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 28)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Message"
        '
        'TxtMessage
        '
        Me.TxtMessage.Location = New System.Drawing.Point(182, 289)
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.Size = New System.Drawing.Size(353, 183)
        Me.TxtMessage.TabIndex = 33
        Me.TxtMessage.Text = ""
        '
        'BtnSendMail
        '
        Me.BtnSendMail.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSendMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSendMail.Location = New System.Drawing.Point(123, 512)
        Me.BtnSendMail.Name = "BtnSendMail"
        Me.BtnSendMail.Size = New System.Drawing.Size(185, 62)
        Me.BtnSendMail.TabIndex = 32
        Me.BtnSendMail.Text = "Send mail"
        Me.BtnSendMail.UseVisualStyleBackColor = False
        '
        'TxtTo
        '
        Me.TxtTo.Location = New System.Drawing.Point(182, 238)
        Me.TxtTo.Name = "TxtTo"
        Me.TxtTo.Size = New System.Drawing.Size(219, 22)
        Me.TxtTo.TabIndex = 31
        '
        'TxtFrom
        '
        Me.TxtFrom.Location = New System.Drawing.Point(182, 159)
        Me.TxtFrom.Name = "TxtFrom"
        Me.TxtFrom.ReadOnly = True
        Me.TxtFrom.Size = New System.Drawing.Size(219, 22)
        Me.TxtFrom.TabIndex = 30
        Me.TxtFrom.Text = "deccanairlines2021@gmail.com"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(73, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 26)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(48, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 34)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Subject"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(62, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 39)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "From"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1180, 619)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSubject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.BtnSendMail)
        Me.Controls.Add(Me.TxtTo)
        Me.Controls.Add(Me.TxtFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "contact us"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnSendMail As System.Windows.Forms.Button
    Friend WithEvents TxtTo As System.Windows.Forms.TextBox
    Friend WithEvents TxtFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
