<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnGetMyIPAddress = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kblstateofconnectivity = New System.Windows.Forms.Label()
        Me.lblMyIPaddress = New System.Windows.Forms.Label()
        Me.lblSettingsLbl = New System.Windows.Forms.Label()
        Me.lblMyIP = New System.Windows.Forms.Label()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.btnExitSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGetMyIPAddress
        '
        Me.btnGetMyIPAddress.Location = New System.Drawing.Point(352, 101)
        Me.btnGetMyIPAddress.Name = "btnGetMyIPAddress"
        Me.btnGetMyIPAddress.Size = New System.Drawing.Size(77, 39)
        Me.btnGetMyIPAddress.TabIndex = 0
        Me.btnGetMyIPAddress.Text = "Get My IP Address?"
        Me.btnGetMyIPAddress.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Location = New System.Drawing.Point(335, 223)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(94, 35)
        Me.btnStatus.TabIndex = 2
        Me.btnStatus.Text = "Check Connectivity?"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1094, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "state of connectivity?"
        '
        'kblstateofconnectivity
        '
        Me.kblstateofconnectivity.AutoSize = True
        Me.kblstateofconnectivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kblstateofconnectivity.ForeColor = System.Drawing.SystemColors.Highlight
        Me.kblstateofconnectivity.Location = New System.Drawing.Point(26, 214)
        Me.kblstateofconnectivity.Name = "kblstateofconnectivity"
        Me.kblstateofconnectivity.Size = New System.Drawing.Size(157, 16)
        Me.kblstateofconnectivity.TabIndex = 5
        Me.kblstateofconnectivity.Text = "State of Connectivity?"
        '
        'lblMyIPaddress
        '
        Me.lblMyIPaddress.AutoSize = True
        Me.lblMyIPaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyIPaddress.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblMyIPaddress.Location = New System.Drawing.Point(26, 90)
        Me.lblMyIPaddress.Name = "lblMyIPaddress"
        Me.lblMyIPaddress.Size = New System.Drawing.Size(108, 16)
        Me.lblMyIPaddress.TabIndex = 6
        Me.lblMyIPaddress.Text = "My IP Address"
        '
        'lblSettingsLbl
        '
        Me.lblSettingsLbl.AutoSize = True
        Me.lblSettingsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsLbl.Location = New System.Drawing.Point(150, 14)
        Me.lblSettingsLbl.Name = "lblSettingsLbl"
        Me.lblSettingsLbl.Size = New System.Drawing.Size(108, 29)
        Me.lblSettingsLbl.TabIndex = 7
        Me.lblSettingsLbl.Text = "Settings"
        '
        'lblMyIP
        '
        Me.lblMyIP.AutoSize = True
        Me.lblMyIP.Location = New System.Drawing.Point(26, 120)
        Me.lblMyIP.MinimumSize = New System.Drawing.Size(200, 20)
        Me.lblMyIP.Name = "lblMyIP"
        Me.lblMyIP.Size = New System.Drawing.Size(200, 20)
        Me.lblMyIP.TabIndex = 8
        '
        'lblConnected
        '
        Me.lblConnected.AutoSize = True
        Me.lblConnected.Location = New System.Drawing.Point(26, 238)
        Me.lblConnected.MinimumSize = New System.Drawing.Size(200, 20)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(200, 20)
        Me.lblConnected.TabIndex = 9
        '
        'btnExitSettings
        '
        Me.btnExitSettings.Location = New System.Drawing.Point(354, 403)
        Me.btnExitSettings.Name = "btnExitSettings"
        Me.btnExitSettings.Size = New System.Drawing.Size(75, 23)
        Me.btnExitSettings.TabIndex = 10
        Me.btnExitSettings.Text = "Exit"
        Me.btnExitSettings.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 491)
        Me.Controls.Add(Me.btnExitSettings)
        Me.Controls.Add(Me.lblConnected)
        Me.Controls.Add(Me.lblMyIP)
        Me.Controls.Add(Me.lblSettingsLbl)
        Me.Controls.Add(Me.lblMyIPaddress)
        Me.Controls.Add(Me.kblstateofconnectivity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnGetMyIPAddress)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetMyIPAddress As System.Windows.Forms.Button
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kblstateofconnectivity As System.Windows.Forms.Label
    Friend WithEvents lblMyIPaddress As System.Windows.Forms.Label
    Friend WithEvents lblSettingsLbl As System.Windows.Forms.Label
    Friend WithEvents lblMyIP As System.Windows.Forms.Label
    Friend WithEvents lblConnected As System.Windows.Forms.Label
    Friend WithEvents btnExitSettings As System.Windows.Forms.Button
End Class
