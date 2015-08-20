<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContactList))
        Me.listbContactsList = New System.Windows.Forms.ListBox()
        Me.lblContactsLbl = New System.Windows.Forms.Label()
        Me.tbContactName = New System.Windows.Forms.TextBox()
        Me.btnAddContact = New System.Windows.Forms.Button()
        Me.lblEnterContactIpAddress = New System.Windows.Forms.Label()
        Me.tbContactIP = New System.Windows.Forms.TextBox()
        Me.lblEnterContactIP = New System.Windows.Forms.Label()
        Me.btnExitContacts = New System.Windows.Forms.Button()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.btnRemoveContact = New System.Windows.Forms.Button()
        Me.btnClearContacts = New System.Windows.Forms.Button()
        Me.btnSaveContacts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listbContactsList
        '
        Me.listbContactsList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listbContactsList.FormattingEnabled = True
        Me.listbContactsList.Location = New System.Drawing.Point(12, 81)
        Me.listbContactsList.Name = "listbContactsList"
        Me.listbContactsList.Size = New System.Drawing.Size(197, 381)
        Me.listbContactsList.TabIndex = 0
        '
        'lblContactsLbl
        '
        Me.lblContactsLbl.AutoSize = True
        Me.lblContactsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactsLbl.Location = New System.Drawing.Point(12, 18)
        Me.lblContactsLbl.Name = "lblContactsLbl"
        Me.lblContactsLbl.Size = New System.Drawing.Size(123, 31)
        Me.lblContactsLbl.TabIndex = 1
        Me.lblContactsLbl.Text = "Contacts"
        '
        'tbContactName
        '
        Me.tbContactName.Location = New System.Drawing.Point(221, 118)
        Me.tbContactName.Name = "tbContactName"
        Me.tbContactName.Size = New System.Drawing.Size(199, 20)
        Me.tbContactName.TabIndex = 2
        '
        'btnAddContact
        '
        Me.btnAddContact.Location = New System.Drawing.Point(402, 257)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(56, 35)
        Me.btnAddContact.TabIndex = 3
        Me.btnAddContact.Text = "Add Contact"
        Me.btnAddContact.UseVisualStyleBackColor = True
        '
        'lblEnterContactIpAddress
        '
        Me.lblEnterContactIpAddress.AutoSize = True
        Me.lblEnterContactIpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterContactIpAddress.Location = New System.Drawing.Point(215, 99)
        Me.lblEnterContactIpAddress.Name = "lblEnterContactIpAddress"
        Me.lblEnterContactIpAddress.Size = New System.Drawing.Size(170, 16)
        Me.lblEnterContactIpAddress.TabIndex = 4
        Me.lblEnterContactIpAddress.Text = "Enter the Contact Name"
        '
        'tbContactIP
        '
        Me.tbContactIP.Location = New System.Drawing.Point(221, 177)
        Me.tbContactIP.Name = "tbContactIP"
        Me.tbContactIP.Size = New System.Drawing.Size(199, 20)
        Me.tbContactIP.TabIndex = 2
        '
        'lblEnterContactIP
        '
        Me.lblEnterContactIP.AutoSize = True
        Me.lblEnterContactIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterContactIP.Location = New System.Drawing.Point(215, 158)
        Me.lblEnterContactIP.Name = "lblEnterContactIP"
        Me.lblEnterContactIP.Size = New System.Drawing.Size(205, 16)
        Me.lblEnterContactIP.TabIndex = 4
        Me.lblEnterContactIP.Text = "Enter the Contact IP Address"
        '
        'btnExitContacts
        '
        Me.btnExitContacts.Location = New System.Drawing.Point(348, 483)
        Me.btnExitContacts.Name = "btnExitContacts"
        Me.btnExitContacts.Size = New System.Drawing.Size(69, 23)
        Me.btnExitContacts.TabIndex = 11
        Me.btnExitContacts.Text = "Exit"
        Me.btnExitContacts.UseVisualStyleBackColor = True
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Location = New System.Drawing.Point(9, 564)
        Me.lblInformation.MinimumSize = New System.Drawing.Size(10, 20)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(460, 20)
        Me.lblInformation.TabIndex = 12
        Me.lblInformation.Text = "Once you have entered Valid contact details double click on the contact to add to" & _
            " the Chat form"
        '
        'btnRemoveContact
        '
        Me.btnRemoveContact.Location = New System.Drawing.Point(221, 257)
        Me.btnRemoveContact.Name = "btnRemoveContact"
        Me.btnRemoveContact.Size = New System.Drawing.Size(61, 34)
        Me.btnRemoveContact.TabIndex = 13
        Me.btnRemoveContact.Text = "Remove Contact"
        Me.btnRemoveContact.UseVisualStyleBackColor = True
        '
        'btnClearContacts
        '
        Me.btnClearContacts.Location = New System.Drawing.Point(317, 257)
        Me.btnClearContacts.Name = "btnClearContacts"
        Me.btnClearContacts.Size = New System.Drawing.Size(59, 35)
        Me.btnClearContacts.TabIndex = 14
        Me.btnClearContacts.Text = "Clear Contacts"
        Me.btnClearContacts.UseVisualStyleBackColor = True
        '
        'btnSaveContacts
        '
        Me.btnSaveContacts.Location = New System.Drawing.Point(221, 320)
        Me.btnSaveContacts.Name = "btnSaveContacts"
        Me.btnSaveContacts.Size = New System.Drawing.Size(61, 43)
        Me.btnSaveContacts.TabIndex = 15
        Me.btnSaveContacts.Text = "Save Contacts"
        Me.btnSaveContacts.UseVisualStyleBackColor = True
        '
        'frmContactList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(470, 593)
        Me.Controls.Add(Me.btnSaveContacts)
        Me.Controls.Add(Me.btnClearContacts)
        Me.Controls.Add(Me.btnRemoveContact)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.btnExitContacts)
        Me.Controls.Add(Me.lblEnterContactIP)
        Me.Controls.Add(Me.lblEnterContactIpAddress)
        Me.Controls.Add(Me.btnAddContact)
        Me.Controls.Add(Me.tbContactIP)
        Me.Controls.Add(Me.tbContactName)
        Me.Controls.Add(Me.lblContactsLbl)
        Me.Controls.Add(Me.listbContactsList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmContactList"
        Me.Text = "Contacts List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listbContactsList As System.Windows.Forms.ListBox
    Friend WithEvents lblContactsLbl As System.Windows.Forms.Label
    Friend WithEvents tbContactName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddContact As System.Windows.Forms.Button
    Friend WithEvents lblEnterContactIpAddress As System.Windows.Forms.Label
    Friend WithEvents tbContactIP As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterContactIP As System.Windows.Forms.Label
    Friend WithEvents btnExitContacts As System.Windows.Forms.Button
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents btnRemoveContact As System.Windows.Forms.Button
    Friend WithEvents btnClearContacts As System.Windows.Forms.Button
    Friend WithEvents btnSaveContacts As System.Windows.Forms.Button
End Class
