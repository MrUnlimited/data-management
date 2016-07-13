Imports System.Data.OleDb
Imports System.IO

Module Mod_Other
    Public Const App_Name As String = "Profil Desa dan Kelurahan"

    Public Sub ImportExcel(ByVal Sheet As String, ByVal DGV_KK As DataGridView, ByVal DGV_AK As DataGridView, ByVal openFile As OpenFileDialog)
        On Error Resume Next
        Dim conn As OleDbConnection
        Dim dta As OleDbDataAdapter
        Dim dts As DataSet
        Dim excel As String
        Dim dv As DataView

        Dim fi As New FileInfo(openFile.FileName)
        Dim FileName As String = openFile.FileName

        excel = fi.FullName
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
        dta = New OleDbDataAdapter("Select * From [" & Sheet & "]", conn)
        dts = New DataSet
        dta.Fill(dts, "[" & Sheet & "]")
        DGV_AK.DataSource = dts
        DGV_AK.DataMember = "[" & Sheet & "]"

        dv = New DataView(dts.Tables(0), "SHDK = 'Kepala Keluarga' ", "SHDK Desc", DataViewRowState.CurrentRows)
        DGV_KK.DataSource = dv
        DGV_KK.DataMember = "[" & Sheet & "]"
        conn.Close()
    End Sub

    Public Function FindItems(ByVal strSearchString As String, ByVal DGV As DataGridView) As Boolean
        Dim intCount As Integer = 0

        For Each Rows As DataGridViewRow In DGV.Rows
            If DGV.Rows(intCount).Cells(0).Value.ToString = strSearchString Then
                DGV.Rows(intCount).Selected = True
                DGV.CurrentCell = DGV.Item(1, intCount)

                Return True
            End If
            intCount += 1
        Next
        Return False
    End Function

    Public Sub DisableSorting(ByVal DGV As DataGridView)
        Dim i As Integer

        For i = 0 To DGV.Columns.Count - 1
            DGV.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Sub

    Public Sub TabControl(ByVal TabControlToolStripMenuItem As ToolStripMenuItem, ByVal SplitContainer1 As SplitContainer, ByVal TabControl1 As TabControl)
        If TabControlToolStripMenuItem.Checked = True Then
            TabControl1.Visible = True
            SplitContainer1.Panel2Collapsed = False
        Else
            TabControl1.Visible = False
            SplitContainer1.Panel2Collapsed = True
        End If
    End Sub
End Module
