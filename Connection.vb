Imports System.Data.OleDb
Imports MessagingToolkit.QRCode.Codec
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Imports System.IO

Module Connection

    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public Edata As Boolean = False
    Public fname, uname, pword, role, uname1, connum, email, result As String
    Public rinsert, rupdate, rdel, rview As Boolean
    Public ofd As New OpenFileDialog
    Public imgpath As String
    Public pic As Byte()
    Public pict As Image
    Public success As Boolean = False

    Sub opencon()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Elaine Regonia\source\repos\BellissimaSalon.accdb;"
    End Sub

    Function empty(text As GunaTextBox, ep As ErrorProvider) As Boolean

        If text.Text = String.Empty Then
            ep.SetError(text, "You can't leave this empty.")
            text.BorderColor = Color.Red
            Return True
        Else
            ep.SetError(text, "")
            text.BorderColor = Color.Gainsboro
            Return False
        End If

    End Function

    Function emptyline(text As GunaLineTextBox, ep As ErrorProvider) As Boolean

        If text.Text = String.Empty Then
            ep.SetError(text, "You can't leave this empty.")
            text.LineColor = Color.Red
            Return True
        Else
            ep.SetError(text, "")
            text.LineColor = Color.Gainsboro
            Return False
        End If

    End Function

    Function emptycbx(text As GunaComboBox, ep As ErrorProvider) As Boolean

        If text.Text = String.Empty Then
            ep.SetError(text, "You can't leave this empty.")
            text.BorderColor = Color.Red
            Return True
        Else
            ep.SetError(text, "")
            text.BorderColor = Color.Gainsboro
            Return False
        End If

    End Function

    Function empty2(text As Guna2TextBox, ep As ErrorProvider) As Boolean

        If text.Text = String.Empty Then
            ep.SetError(text, "You can't leave this empty.")
            text.BorderColor = Color.Red
            Return True
        Else
            ep.SetError(text, "")
            text.BorderColor = Color.Gainsboro
            Return False
        End If

    End Function

    Function QRCodee(pic As PictureBox, id As String) As Image

        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            'qrCode.QRCodeForegroundColor = color
            pic.Image = qrCode.Encode(id, System.Text.Encoding.UTF8)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Return pic.Image
    End Function

    Function permission(ByVal str As Boolean) As Boolean
        If str = False Then
            MsgBox("You don't have permission.", vbExclamation)
            permission = True
        Else
            permission = False
        End If
        Return permission
    End Function

    Public Sub reloadtxt(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            dt = New DataTable
            da = New OleDbDataAdapter(sql, con)
            da.Fill(dt)
        Catch ex As Exception
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Function getPrice(sql As String) As Double
        Try
            con.Open()
            cmd = New OleDbCommand(sql, con)
            getPrice = CDbl(cmd.ExecuteScalar)
            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        Return getPrice
    End Function
End Module
