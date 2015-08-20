<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainView))
        Me.tbTextToSend = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConvoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConversationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbTextIn = New System.Windows.Forms.ListBox()
        Me.tbQuit = New System.Windows.Forms.Button()
        Me.PanelForMainText = New System.Windows.Forms.Panel()
        Me.tbDestIPAddress = New System.Windows.Forms.TextBox()
        Me.lblDestintionIPAddress = New System.Windows.Forms.Label()
        Me.tbContactName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnClearConvo = New System.Windows.Forms.Button()
        Me.tbUserName = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelForMainText.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTextToSend
        '
        Me.tbTextToSend.Location = New System.Drawing.Point(13, 33)
        Me.tbTextToSend.MinimumSize = New System.Drawing.Size(4, 50)
        Me.tbTextToSend.Name = "tbTextToSend"
        Me.tbTextToSend.Size = New System.Drawing.Size(368, 20)
        Me.tbTextToSend.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSend.Location = New System.Drawing.Point(404, 33)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 50)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.SaveConvoToolStripMenuItem, Me.OpenConversationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SaveConvoToolStripMenuItem
        '
        Me.SaveConvoToolStripMenuItem.Name = "SaveConvoToolStripMenuItem"
        Me.SaveConvoToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.SaveConvoToolStripMenuItem.Text = "Save conversation"
        '
        'OpenConversationToolStripMenuItem
        '
        Me.OpenConversationToolStripMenuItem.Name = "OpenConversationToolStripMenuItem"
        Me.OpenConversationToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.OpenConversationToolStripMenuItem.Text = "Open Conversation"
        '
        'lbTextIn
        '
        Me.lbTextIn.FormattingEnabled = True
        Me.lbTextIn.HorizontalScrollbar = True
        Me.lbTextIn.Location = New System.Drawing.Point(22, 72)
        Me.lbTextIn.Name = "lbTextIn"
        Me.lbTextIn.Size = New System.Drawing.Size(279, 329)
        Me.lbTextIn.TabIndex = 5
        '
        'tbQuit
        '
        Me.tbQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuit.ForeColor = System.Drawing.SystemColors.Highlight
        Me.tbQuit.Location = New System.Drawing.Point(460, 46)
        Me.tbQuit.Name = "tbQuit"
        Me.tbQuit.Size = New System.Drawing.Size(60, 33)
        Me.tbQuit.TabIndex = 6
        Me.tbQuit.Text = "Quit"
        Me.tbQuit.UseVisualStyleBackColor = True
        '
        'PanelForMainText
        '
        Me.PanelForMainText.Controls.Add(Me.btnSend)
        Me.PanelForMainText.Controls.Add(Me.tbTextToSend)
        Me.PanelForMainText.Location = New System.Drawing.Point(12, 433)
        Me.PanelForMainText.Name = "PanelForMainText"
        Me.PanelForMainText.Size = New System.Drawing.Size(495, 107)
        Me.PanelForMainText.TabIndex = 7
        '
        'tbDestIPAddress
        '
        Me.tbDestIPAddress.Location = New System.Drawing.Point(326, 176)
        Me.tbDestIPAddress.Name = "tbDestIPAddress"
        Me.tbDestIPAddress.Size = New System.Drawing.Size(181, 20)
        Me.tbDestIPAddress.TabIndex = 8
        '
        'lblDestintionIPAddress
        '
        Me.lblDestintionIPAddress.AutoSize = True
        Me.lblDestintionIPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestintionIPAddress.Location = New System.Drawing.Point(323, 133)
        Me.lblDestintionIPAddress.MaximumSize = New System.Drawing.Size(240, 40)
        Me.lblDestintionIPAddress.MinimumSize = New System.Drawing.Size(130, 30)
        Me.lblDestintionIPAddress.Name = "lblDestintionIPAddress"
        Me.lblDestintionIPAddress.Size = New System.Drawing.Size(179, 30)
        Me.lblDestintionIPAddress.TabIndex = 9
        Me.lblDestintionIPAddress.Text = "Destination IP Address"
        '
        'tbContactName
        '
        Me.tbContactName.Location = New System.Drawing.Point(326, 242)
        Me.tbContactName.Name = "tbContactName"
        Me.tbContactName.Size = New System.Drawing.Size(181, 20)
        Me.tbContactName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 219)
        Me.Label1.MaximumSize = New System.Drawing.Size(240, 40)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Contact Name"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnClearConvo
        '
        Me.btnClearConvo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClearConvo.Location = New System.Drawing.Point(416, 299)
        Me.btnClearConvo.Name = "btnClearConvo"
        Me.btnClearConvo.Size = New System.Drawing.Size(87, 47)
        Me.btnClearConvo.TabIndex = 10
        Me.btnClearConvo.Text = "Clear Conversation"
        Me.btnClearConvo.UseVisualStyleBackColor = False
        '
        'tbUserName
        '
        Me.tbUserName.Location = New System.Drawing.Point(22, 46)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(100, 20)
        Me.tbUserName.TabIndex = 11
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(22, 28)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(79, 15)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "User Name"
        '
        'frmMainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(532, 543)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.tbUserName)
        Me.Controls.Add(Me.btnClearConvo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbContactName)
        Me.Controls.Add(Me.lblDestintionIPAddress)
        Me.Controls.Add(Me.tbDestIPAddress)
        Me.Controls.Add(Me.PanelForMainText)
        Me.Controls.Add(Me.tbQuit)
        Me.Controls.Add(Me.lbTextIn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainView"
        Me.Text = "Qwik Reply"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelForMainText.ResumeLayout(False)
        Me.PanelForMainText.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTextToSend As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ContactsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbTextIn As System.Windows.Forms.ListBox
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbQuit As System.Windows.Forms.Button
    Friend WithEvents PanelForMainText As System.Windows.Forms.Panel
    Friend WithEvents tbDestIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblDestintionIPAddress As System.Windows.Forms.Label
    Friend WithEvents SaveConvoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbContactName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenConversationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClearConvo As System.Windows.Forms.Button
    Friend WithEvents tbUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label

End Class
