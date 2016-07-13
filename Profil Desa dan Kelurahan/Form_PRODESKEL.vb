Imports Gecko.DOM
Imports System.Threading
Imports System.Net.NetworkInformation

Public Class Form_PRODESKEL
    Dim complete As Boolean

    Private Sub Form_PRODESKEL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Exit, " & App_Name & " ?", vbYesNo) = vbNo Then
            e.Cancel = True
        Else
            Application.ExitThread()
            ' End
        End If
    End Sub

    Private Sub Form_PRODESKEL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = App_Name
        TabControlToolStripMenuItem.CheckOnClick = True
        TabControlToolStripMenuItem.Checked = False
        Mod_Other.TabControl(TabControlToolStripMenuItem, SplitContainer1, TabControl1)
        LogOutToolStripMenuItem.Enabled = False
        TabControlToolStripMenuItem.Enabled = False
        FindKKToolStripTextBox.Text = My.Settings.NO_KK
        FindAKToolStripTextBox.Text = My.Settings.NO_KKAK

        GWB.Navigate("http://prodeskel.binapemdes.kemendagri.go.id/app_Login/")
    End Sub

    Private Sub LogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInToolStripMenuItem.Click
        Try
            GWB.Document.GetElementsByName("login")(0).SetAttribute("value", "6171040002")
            GWB.Document.GetElementsByName("pswd")(0).SetAttribute("value", "82925LIR")

            Dim SubmitButton As GeckoInputElement
            SubmitButton = New GeckoInputElement(GWB.Document.GetElementById("sub_form_b").DomObject)
            SubmitButton.Click()

            Do While GWB.IsBusy : Application.DoEvents() : Loop

            GWB.Navigate("http://prodeskel.binapemdes.kemendagri.go.id/grid_ddk01/")

            Do Until GWB.DocumentTitle = "Daftar - KEPALA KELUARGA" : Application.DoEvents() : Loop
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Exit, " & App_Name & " ?", vbYesNo) = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub TabControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlToolStripMenuItem.Click
        Mod_Other.TabControl(TabControlToolStripMenuItem, SplitContainer1, TabControl1)
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Excel Worksheet |*.xlsx; *.xls"
        openFile.Title = "Pilih Data Penduduk"
        If (openFile.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Mod_Other.ImportExcel("Sheet1$", DGV_KK, DGV_AK, openFile)

            TabControlToolStripMenuItem.Checked = True
            Mod_Other.TabControl(TabControlToolStripMenuItem, SplitContainer1, TabControl1)

            TotalKKToolStripLabel.Text = DGV_KK.RowCount
            TotalAKToolStripLabel.Text = DGV_AK.RowCount

            TabControlToolStripMenuItem.Enabled = True
        Else
            'Do Nothing
        End If
    End Sub

    Private Sub DGV_KK_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_KK.DoubleClick
        Mod_KK.KK(GWB, DGV_KK, Me, FindKKToolStripTextBox, RowsKKToolStripLabel)
    End Sub

    Private Sub FindKKToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindKKToolStripButton.Click
        Dim str As String = FindKKToolStripTextBox.Text
        Mod_Other.FindItems(str, DGV_KK)
        RowsKKToolStripLabel.Text = DGV_KK.CurrentRow.Index + 1
    End Sub

    Private Sub DGV_KK_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_KK.MouseClick
        On Error Resume Next
        Mod_Other.DisableSorting(DGV_KK)
        RowsKKToolStripLabel.Text = DGV_KK.CurrentRow.Index + 1
    End Sub

    Private Sub GWB_DocumentCompleted(ByVal sender As Object, ByVal e As Gecko.Events.GeckoDocumentCompletedEventArgs) Handles GWB.DocumentCompleted
        ProgressBar1.Style = ProgressBarStyle.Continuous
        Me.Text = App_Name + " | " + GWB.DocumentTitle
        complete = True

        If GWB.DocumentTitle = "Prodeskel PMD" Then
            LogInToolStripMenuItem.Enabled = True
            LogOutToolStripMenuItem.Enabled = False
            ToolStripButton1.Enabled = False
            ToolStripButton5.Enabled = False
        Else
            LogInToolStripMenuItem.Enabled = False
            LogOutToolStripMenuItem.Enabled = True
            ToolStripButton1.Enabled = True
            ToolStripButton5.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim p As New Ping
        PingToolStripLabel.Text = p.Send("27.112.69.42").RoundtripTime.ToString() + " ms"
    End Sub

    Private Sub GWB_ProgressChanged(ByVal sender As Object, ByVal e As Gecko.GeckoProgressEventArgs) Handles GWB.ProgressChanged
        If complete = False Then
            On Error Resume Next
            ProgressBar1.Style = ProgressBarStyle.Marquee

            ProgressBar1.Maximum = e.MaximumProgress
            ProgressBar1.Value = e.CurrentProgress
        Else
            complete = False
            ProgressBar1.Style = ProgressBarStyle.Continuous
        End If
    End Sub

    Private Sub FindAKToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindAKToolStripButton.Click
        Dim str As String = FindAKToolStripTextBox.Text
        Mod_Other.FindItems(str, DGV_AK)
        RowsAKToolStripLabel.Text = DGV_AK.CurrentRow.Index + 1
    End Sub

    Private Sub DGV_AK_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_AK.MouseClick
        On Error Resume Next
        Mod_Other.DisableSorting(DGV_AK)
        RowsAKToolStripLabel.Text = DGV_AK.CurrentRow.Index + 1
    End Sub

    Private Sub DGV_AK_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGV_AK.MouseDoubleClick
        Mod_AK.AK(GWB, DGV_AK, Me, FindAKToolStripTextBox, RowsAKToolStripLabel)
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        ''  Identify which TabPage is currently selected
        'Dim SelectedTab As TabPage = TabControl1.TabPages(e.Index)

        ''  Get the area of the header of this TabPage
        'Dim HeaderRect As Rectangle = TabControl1.GetTabRect(e.Index)

        ''  Create a Brush to paint the Text
        'Dim TextBrush As New SolidBrush(Color.Black)

        ''  Set the Alignment of the Text
        'Dim sf As New StringFormat()
        'sf.Alignment = StringAlignment.Center
        'sf.LineAlignment = StringAlignment.Center

        ''  Paint the Text using the appropriate Bold setting 
        'If Convert.ToBoolean(e.State And DrawItemState.Selected) Then
        '    Dim BoldFont As New Font(TabControl1.Font.Name, TabControl1.Font.Size, FontStyle.Bold)
        '    e.Graphics.DrawString(SelectedTab.Text, BoldFont, TextBrush, HeaderRect, sf)
        'Else
        '    e.Graphics.DrawString(SelectedTab.Text, e.Font, TextBrush, HeaderRect, sf)
        'End If

        ''  Job done - dispose of the Brush
        'TextBrush.Dispose()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        GWB.GoBack()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        GWB.Navigate("http://prodeskel.binapemdes.kemendagri.go.id/grid_ddk01/")
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        GWB.Reload()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        GWB.GoForward()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        GWB.Navigate("http://prodeskel.binapemdes.kemendagri.go.id/mdesa/mdesa_form_php.php?sc_item_menu=item_268&sc_apl_menu=mpublik&sc_apl_link=%2F&sc_usa_grupo=")
        Do While GWB.IsBusy : Application.DoEvents() : Loop
        GWB.Navigate("http://prodeskel.binapemdes.kemendagri.go.id/app_Login/")
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        GWB.Navigate("http://prodeskel.binapemdes.kemendagri.go.id/grid_agtkeluarga/")
    End Sub
End Class