Imports Gecko.DOM
Imports Gecko

Module Mod_KK

    Public Sub KK(ByVal GWB As GeckoWebBrowser, ByVal DGV_KK As DataGridView, ByVal frm As Form, ByVal txtfind As ToolStripTextBox, ByVal RowsKK As ToolStripLabel)
start1:
        Try
            With GWB
                Do While .IsBusy : Application.DoEvents() : Loop

                If .Document.GetElementById("sc_SC_btn_0_top").TextContent = "KK Baru" Then
                    Dim KKBaru As GeckoInputElement
                    KKBaru = New GeckoInputElement(GWB.Document.GetElementById("sc_SC_btn_0_top").DomObject)
                    KKBaru.Click()

                    Do While .IsBusy : Application.DoEvents() : Loop
start2:
                    If .DocumentTitle = "(Data Baru) - KEPALA KELUARGA" Then
                        Mod_Select.DataExcel(DGV_KK, ROWsKK)
                        txtfind.Text = Mod_Select.NO_KK

                        .Document.GetElementsByName("kode_keluarga")(0).SetAttribute("value", Mod_Select.NO_KK)
                        .Document.GetElementsByName("namakk")(0).SetAttribute("value", Mod_Select.NAMA_KEP)
                        Dim alamatG As GeckoTextAreaElement
                        alamatG = New GeckoTextAreaElement(.Document.GetElementsByName("alamat")(0).DomObject)
                        alamatG.Value = Mod_Select.ALAMAT
                        .Document.GetElementsByName("rt")(0).SetAttribute("value", Mod_Select.NO_RT)
                        .Document.GetElementsByName("rw")(0).SetAttribute("value", Mod_Select.NO_RW)
                        .Document.GetElementsByName("nama_dusun")(0).SetAttribute("value", "KELURAHAN SIANTAN HILIR")
                        .Document.GetElementsByName("d014")(0).SetAttribute("value", "-")
                        .Document.GetElementsByName("d015")(0).SetAttribute("value", "-")
                        .Document.GetElementsByName("d016")(0).SetAttribute("value", "-")
                        Dim sumberDataG As GeckoTextAreaElement
                        sumberDataG = New GeckoTextAreaElement(.Document.GetElementsByName("d017")(0).DomObject)
                        sumberDataG.Value = "DISDUKCAPIL"

                        Dim submit As GeckoButtonElement
                        submit = New GeckoButtonElement(.Document.GetElementById("sc_b_ins_t").DomObject)
                        submit.Click()

                        Do While .IsBusy : Application.DoEvents() : Loop

                        Dim maxRowIndex As Integer = (DGV_KK.Rows.Count - 1)
                        Dim curDataGridViewRow As DataGridViewRow = DGV_KK.CurrentRow
                        Dim curRowIndex As Integer = curDataGridViewRow.Index

                        If (curRowIndex >= maxRowIndex) Then
                            MsgBox("Tidak ada data lagi")
                            .Navigate("http://prodeskel.binapemdes.kemendagri.go.id/grid_ddk01/")
                            Exit Sub
                        Else
                            Dim nextRow As DataGridViewRow = DGV_KK.Rows(curRowIndex + 1)
                            DGV_KK.CurrentCell = nextRow.Cells(0)
                            nextRow.Selected = True

                            Mod_Select.DataExcel(DGV_KK, ROWsKK)
                            txtfind.Text = Mod_Select.NO_KK

                            My.Settings.NO_KK = txtfind.Text
                            My.Settings.Save()

                            If .DocumentTitle = "Pengeditan - KEPALA KELUARGA" Then
                                .Navigate("http://prodeskel.binapemdes.kemendagri.go.id/grid_ddk01/")

                                Do Until .DocumentTitle = "Daftar - KEPALA KELUARGA" : Application.DoEvents() : Loop

                                GoTo start1
                            Else
                                GoTo start2
                            End If
                        End If
                    End If
                Else
                    .Navigate("http://prodeskel.binapemdes.kemendagri.go.id/grid_ddk01/")

                    Do Until .DocumentTitle = "Daftar - KEPALA KELUARGA" : Application.DoEvents() : Loop

                    GoTo start1
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
