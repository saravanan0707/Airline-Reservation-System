<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent2))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualificationDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignationDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceNamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlightCompanyDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlightDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookedTicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelledTicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1346, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntriesToolStripMenuItem, Me.EmpDetailsToolStripMenuItem, Me.CustomerDetailsToolStripMenuItem, Me.FlightDetailsToolStripMenuItem, Me.TicketBookingToolStripMenuItem, Me.CancelTicketToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1346, 33)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterEntriesToolStripMenuItem
        '
        Me.MasterEntriesToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.MasterEntriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QualificationDetailsToolStripMenuItem, Me.DesignationDetailsToolStripMenuItem, Me.PlaceNamesToolStripMenuItem, Me.FlightCompanyDetailsToolStripMenuItem})
        Me.MasterEntriesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterEntriesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.MasterEntriesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.MasterEntriesToolStripMenuItem.Name = "MasterEntriesToolStripMenuItem"
        Me.MasterEntriesToolStripMenuItem.Size = New System.Drawing.Size(186, 29)
        Me.MasterEntriesToolStripMenuItem.Text = "Master Entries"
        '
        'QualificationDetailsToolStripMenuItem
        '
        Me.QualificationDetailsToolStripMenuItem.Name = "QualificationDetailsToolStripMenuItem"
        Me.QualificationDetailsToolStripMenuItem.Size = New System.Drawing.Size(343, 30)
        Me.QualificationDetailsToolStripMenuItem.Text = "Qualification Details"
        '
        'DesignationDetailsToolStripMenuItem
        '
        Me.DesignationDetailsToolStripMenuItem.Name = "DesignationDetailsToolStripMenuItem"
        Me.DesignationDetailsToolStripMenuItem.Size = New System.Drawing.Size(343, 30)
        Me.DesignationDetailsToolStripMenuItem.Text = "Designation Details"
        '
        'PlaceNamesToolStripMenuItem
        '
        Me.PlaceNamesToolStripMenuItem.Name = "PlaceNamesToolStripMenuItem"
        Me.PlaceNamesToolStripMenuItem.Size = New System.Drawing.Size(343, 30)
        Me.PlaceNamesToolStripMenuItem.Text = "Place Names"
        '
        'FlightCompanyDetailsToolStripMenuItem
        '
        Me.FlightCompanyDetailsToolStripMenuItem.Name = "FlightCompanyDetailsToolStripMenuItem"
        Me.FlightCompanyDetailsToolStripMenuItem.Size = New System.Drawing.Size(343, 30)
        Me.FlightCompanyDetailsToolStripMenuItem.Text = "Flight Company Details"
        '
        'EmpDetailsToolStripMenuItem
        '
        Me.EmpDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.EmpDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpDetailsToolStripMenuItem1})
        Me.EmpDetailsToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpDetailsToolStripMenuItem.Name = "EmpDetailsToolStripMenuItem"
        Me.EmpDetailsToolStripMenuItem.Size = New System.Drawing.Size(133, 29)
        Me.EmpDetailsToolStripMenuItem.Text = "Employee"
        '
        'EmpDetailsToolStripMenuItem1
        '
        Me.EmpDetailsToolStripMenuItem1.Name = "EmpDetailsToolStripMenuItem1"
        Me.EmpDetailsToolStripMenuItem1.Size = New System.Drawing.Size(218, 30)
        Me.EmpDetailsToolStripMenuItem1.Text = "Emp Details"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.CustomerDetailsToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(216, 29)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer Details"
        '
        'FlightDetailsToolStripMenuItem
        '
        Me.FlightDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.FlightDetailsToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlightDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlightDetailsToolStripMenuItem.Name = "FlightDetailsToolStripMenuItem"
        Me.FlightDetailsToolStripMenuItem.Size = New System.Drawing.Size(173, 29)
        Me.FlightDetailsToolStripMenuItem.Text = "Flight Details"
        '
        'TicketBookingToolStripMenuItem
        '
        Me.TicketBookingToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.TicketBookingToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketBookingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TicketBookingToolStripMenuItem.Name = "TicketBookingToolStripMenuItem"
        Me.TicketBookingToolStripMenuItem.Size = New System.Drawing.Size(190, 29)
        Me.TicketBookingToolStripMenuItem.Text = "Ticket Booking"
        '
        'CancelTicketToolStripMenuItem
        '
        Me.CancelTicketToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.CancelTicketToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelTicketToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelTicketToolStripMenuItem.Name = "CancelTicketToolStripMenuItem"
        Me.CancelTicketToolStripMenuItem.Size = New System.Drawing.Size(172, 29)
        Me.CancelTicketToolStripMenuItem.Text = "Cancel Ticket"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookedTicketsToolStripMenuItem, Me.CancelledTicketsToolStripMenuItem, Me.ContactUsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'BookedTicketsToolStripMenuItem
        '
        Me.BookedTicketsToolStripMenuItem.Name = "BookedTicketsToolStripMenuItem"
        Me.BookedTicketsToolStripMenuItem.Size = New System.Drawing.Size(278, 30)
        Me.BookedTicketsToolStripMenuItem.Text = "Booked Tickets"
        '
        'CancelledTicketsToolStripMenuItem
        '
        Me.CancelledTicketsToolStripMenuItem.Name = "CancelledTicketsToolStripMenuItem"
        Me.CancelledTicketsToolStripMenuItem.Size = New System.Drawing.Size(278, 30)
        Me.CancelledTicketsToolStripMenuItem.Text = "Cancelled Tickets"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(278, 30)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MDIParent2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1346, 558)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent2"
        Me.Text = "main menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterEntriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QualificationDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignationDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaceNamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlightCompanyDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlightDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookedTicketsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelledTicketsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
