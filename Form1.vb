
Imports System.Data

Imports System.Collections.Generic
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1
    Dim unDs As DataSet
    Dim dtable As New DataTable
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter



    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click



        Dim sql As String
        Dim heure1 As Date
        Dim heure2 As Date


        If cmbshift.Text = "06-14" Then
            heure1 = "06:00:00"
            heure2 = "14:00:00"
        ElseIf cmbshift.Text = "14-22" Then
            heure1 = "14:00:00"
            heure2 = "22:00:00"
        ElseIf cmbshift.Text = "22-06" Then
            heure1 = "22:00:00"
            heure2 = "22:00:00"
        End If

        sql = "select place_of_action , Data_scan , Time_scan from Statystyka_System_Pack where Place_of_action='" & Cmbaction.Text & "' and data_scan='" & Format(DateTimePicker1.Value, "dd.MM.yyyy") & "' and  Time_scan between '" & heure1 & "' and '" & heure2 & "'"




        GenererDataSet(sql)

        ExporterDataSetVersExcel(unDs, SFDialogEnregistrer)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        remplissage_action()



    End Sub


    Public Function GenererDataSet(ByVal uneRequete As String) As DataSet

        Dim dsgroupe As New DataSet
        If Not unDs Is Nothing Then
            unDs.Clear()
        End If
        Try

            GenererDataSet = New DataSet
            dtable.Clear()
            cmd.Connection = conn
            cmd.CommandText = uneRequete
            da.SelectCommand = cmd
            da.Fill(dsgroupe)
            unDs = dsgroupe
        Catch Sqlex As SqlException
            MessageBox.Show(Sqlex.Message, "Erreur SQL")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur...")
        End Try
        Return dsgroupe
    End Function

  

    Public Sub ExporterDataSetVersExcel(ByVal unDataSet As DataSet, ByVal SFDLogTraitement As SaveFileDialog)
        Dim CheminDuFichier As String
        Dim myTable As DataTable
        Dim myRow As DataRow
        Dim myColumn As DataColumn
        Dim i As Integer
        SFDialogEnregistrer.Title = "Choisir un emplacement pour enregistrer le fichier Excel."
        SFDialogEnregistrer.InitialDirectory = "c:\"
        SFDialogEnregistrer.Filter = "Fichiers Excel (*.xls)|*.xls"
        SFDialogEnregistrer.FilterIndex = 2
        SFDialogEnregistrer.RestoreDirectory = True
        If SFDialogEnregistrer.ShowDialog() = DialogResult.OK Then
            CheminDuFichier = SFDialogEnregistrer.FileName
            Try
                Dim app As New Microsoft.Office.Interop.Excel.Application
                Dim exbook As Microsoft.Office.Interop.Excel.Workbook
                Dim exsheet As Microsoft.Office.Interop.Excel.Worksheet

                exbook = app.Workbooks.Add
                exsheet = exbook.Sheets(1)
                i = 0
                REM DEFINITION DES EN-TETE DE COLONNES
                For Each myTable In unDataSet.Tables
                    For Each myColumn In myTable.Columns
                        exsheet.Cells(1, i + 1) = myTable.Columns(i).ColumnName
                        i = i + 1
                    Next
                Next

                Dim j As Integer
                j = 2
                REM CHARGEMENT DES DONNEES DANS LA FEUILLE EXCEL
                For Each myTable In unDataSet.Tables
                    For Each myRow In myTable.Rows
                        i = 1
                        For Each myColumn In myTable.Columns
                            exsheet.Cells(j, i) = CType(myRow(myColumn) & "", String)
                            i += 1
                        Next myColumn
                        j += 1
                    Next myRow
                Next myTable
                REM ENREGISTREMENT DU FICHIER
                exbook.SaveAs(CheminDuFichier)
                app.Visible = True
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub



    Public Sub remplissage_action()
        Dim reqsql As String
        Dim myadapter As New SqlDataAdapter
        Dim dset As New DataSet
        Dim cmd As New SqlCommand

        reqsql = "SELECT  distinct PLACE_OF_ACTION from Statystyka_System_Pack"

        conn.Open()

        cmd.Connection = conn
        cmd.CommandText = reqsql
        myadapter.SelectCommand = cmd
        myadapter.Fill(dset, "Statystyka_System_Pack")

        Cmbaction.DisplayMember = "Place_of_action"
        Cmbaction.ValueMember = "PLACE_OF_ACTION"
        Cmbaction.DataSource = dset.Tables("Statystyka_System_Pack")

        conn.Close()
    End Sub


    Private Sub Cmbaction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbaction.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbshift.SelectedIndexChanged


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        MsgBox(Cmbaction.Text)
    End Sub


End Class
