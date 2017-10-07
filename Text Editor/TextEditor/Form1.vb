' Written by Michael Kellar
' 11/19/2015
Option Strict On
Option Explicit On
' I made some changes based on my own preference.
' I changed the mnuFileOpen_Click so that it doesn't clear the document, it will only replace.
' The Save As procedure is duplicated code so it has it's own Sub procedure "SaveAsDocument" now as well.
' Added a vertical scroll bar to the text editor.
' Added a Status Label to show if the text has changed.
' Added title of document to Form Text.

Imports System.IO

Public Class Form1
    ' Class-level variables
    Private strFilename As String = String.Empty        ' Document filename
    Dim blnIsChanged As Boolean = False                 ' File change flag

    Sub ClearDocument()
        ' Clear the documents of the text box.
        txtDocument.Clear()

        ' Clear the document name.
        strFilename = String.Empty

        ' Set isChanged to False.
        blnIsChanged = False

        ' Update Status Label
        stsLabel.Text = "Your document text has not changed since cleared."

    End Sub

    ' The OpenDocument procedure opens a file and loads it
    ' into the TextBox for editing.
    ' Added a section to check if txtDocument.Text is empty since it should be anyways before opening a new document.
    Sub OpenDocument()
        Dim inputFile As StreamReader   ' Object variable

        If txtDocument.Text = String.Empty Then
            If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Retrieve the selected filename.
                strFilename = ofdOpenFile.FileName

                Try
                    ' Open the file
                    inputFile = File.OpenText(strFilename)

                    ' Read the file's contents into the TextBox.
                    txtDocument.Text = inputFile.ReadToEnd

                    ' Close te file.
                    inputFile.Close()

                    ' Update the isChanged variable.
                    blnIsChanged = False

                    ' Update Status Label
                    stsLabel.Text = "Your document text has not changed since opened."

                Catch
                    ' Error message for file open error.
                    MessageBox.Show("Error opening the file.")
                End Try
            End If
        End If
    End Sub

    ' The SaveDocument procedure saves the current document.

    Sub SaveDocument()
        Dim outputFile As StreamWriter  ' Object variable

        Try
            ' Create the file.
            outputFile = File.CreateText(strFilename)

            ' Write the TextBox to the file.
            outputFile.Write(txtDocument.Text)

            ' Close the file.
            outputFile.Close()

            ' Update the isChanged variable.
            blnIsChanged = False

            ' Update Status Label
            stsLabel.Text = "Your document text has not changed since last save."

        Catch
            ' Error message for file creation error.
            MessageBox.Show("Error creating the file.")
        End Try
    End Sub

    ' The SaveAsDocument Saves the current document under a new name.
    ' Used in mnuFileSave_Click and mnuFileSaveAs_Click events.
    Sub SaveAsDocument()
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFilename = sfdSaveFile.FileName
            SaveDocument()
        End If
    End Sub

    Sub UpdateFormText()

        ' Constant for default name
        Const strDefaultName As String = "Michael Kellar Simple Text Editor"

        If strFilename = String.Empty Then
            Me.Text = strDefaultName & " | New Document"
        Else
            Me.Text = strDefaultName & " | " & strFilename
        End If
    End Sub


    Private Sub txtDocument_TextChanged(sender As Object, e As EventArgs) Handles txtDocument.TextChanged
        ' Indicate the text has changed.
        blnIsChanged = True

        ' Update Status Label
        stsLabel.Text = "Your document text has changed and may need to be saved."
    End Sub


    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        ' Has the current document changed?
        If blnIsChanged = True Then
            ' Confirm before clearing the document.
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                ClearDocument()
            End If
        Else
            ' Document has not changed, so clear it.
            ClearDocument()
        End If
        UpdateFormText()
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        ' Has the current document changed?
        If blnIsChanged = True Then
            ' Confirm before clearing the document.
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                OpenDocument()
            End If
        Else
            ' Document has not changed, so replace it.
            OpenDocument()
        End If
        UpdateFormText()
    End Sub


    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        ' Does the current document have a filename?
        If strFilename = String.Empty Then
            ' The document has not been saved, so
            ' use Save As dialog box.
            SaveAsDocument()
        Else
            ' Save the document with the current filename.
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        ' Save the current document under a new filename.
        SaveAsDocument()
        UpdateFormText()
    End Sub


    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close the form.
        Me.Close()
    End Sub


    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Display an about box.
        MessageBox.Show("Simple Text Editor version 1.0")
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' If the document has been modified, confirm
        ' before exiting.
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " &
                               "Do you wish to discard your changes?",
                               "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateFormText()
    End Sub
End Class
