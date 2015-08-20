Imports System.IO

Public Class frmContactList


    Private Sub btnAddContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddContact.Click

        Dim tempContact As String

        If tbContactName.Text = "" Then 'if no text input then display msgbox 
            MsgBox("Enter a contact name")
        ElseIf tbContactIP.Text = "" Then  ' if no text input in the textbox then dispaly msgbox 
            MsgBox("Enter a contact IP address")
        Else
            tempContact = tbContactName.Text & ":" & tbContactIP.Text
            If listbContactsList.Items.Contains(tempContact) Then 'if the listbContacts list contains the name of the contact then it will dispaly  a msgbox 
                MsgBox("Contact already in list")
            Else
                listbContactsList.Items.Add(tempContact) 'other wise it will add it to the contacts listbox
            End If

            If CheckIp(tbContactIP.Text) = False Then
                MsgBox("Invalid IP Address")  'if ip address is invalid then it will dispaly msgbox 
            End If
        End If
    End Sub

    Private Sub btnExitContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitContacts.Click
        Me.Close() 'closes the current form 
        frmMainView.Show() 'displays the form mainview 
    End Sub

    Private Sub listbContactsList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listbContactsList.DoubleClick
        'if slected index if equal to -1 then create a variable and split it 
        'when selecteing a contact from the contacts list it will split into two parts 
        'then it will reassign the split information into the frmMainview where selcted textboxs have been assigned 
        If listbContactsList.SelectedIndex <> -1 Then

            Dim contactParts As String()
            contactParts = listbContactsList.SelectedItem.ToString.Split(":")
            frmMainView.tbDestIPAddress.Text = contactParts(1)
            frmMainView.tbContactName.Text = contactParts(0)

            Me.Close() 'closes the current form
            frmMainView.Show() 'opens the frmMainview form
        End If
    End Sub

    Private Sub tbContactIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbContactIP.TextChanged

    End Sub
    Private Function CheckIp(ByVal ipaddress As String) As Boolean
        Return System.Net.IPAddress.TryParse(ipaddress, Nothing) 'tryparse contains the string to convert into a Ip address and return it to check ip function 

    End Function

    Private Sub btnRemoveContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveContact.Click


        listbContactsList.Items.Remove(listbContactsList.SelectedItem) ' when button is clicked the selected item from the contactslist will be removed 

    End Sub

    Private Sub btnClearContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearContacts.Click
        listbContactsList.Items.Clear() 'clears all of the data in the contacts list 
    End Sub

    Private Sub frmContactList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'create a if not  statement to look for .txt files if they do not exists within the contacts form then display a msg box or clear the list box 
        If Not File.Exists("..\..\ContactList.txt") Then
            MsgBox("Contacts file not found", MsgBoxStyle.Exclamation, "Error")
        Else
            listbContactsList.Items.Clear() 'clears the items 


            Dim sr As New StreamReader("..\..\ContactList.txt")
            While sr.Peek <> -1 'sr.Peek returns the code for the next character to read from the file, or -1 if there's nothing more to read
                listbContactsList.Items.Add(sr.ReadLine)
            End While
            sr.Close() 'close the sr variables 
        End If
    End Sub

    Private Sub btnSaveContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveContacts.Click
        'create streamwriter vairiable for .txt file this adds each item in the contacts list box 
        'into a the contactslist .txt file and then displays a msgbox saying contact saved 
        Dim sw As New StreamWriter("..\..\ContactList.txt")
        For Each item As String In listbContactsList.Items
            sw.WriteLine(item)
        Next
        MsgBox("Contacts saved", MsgBoxStyle.Information, "Success")
        sw.Close()
    End Sub

    Private Sub listbContactsList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listbContactsList.SelectedIndexChanged

    End Sub
End Class