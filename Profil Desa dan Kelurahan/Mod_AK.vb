Imports Gecko.DOM
Imports Gecko

Module Mod_AK
    Public Sub AK(ByVal GWB As GeckoWebBrowser, ByVal DGV_AK As DataGridView, ByVal frm As Form, ByVal txtfind As ToolStripTextBox, ByVal RowsAK As ToolStripLabel)
start1:
        Try
            With GWB
                Do While .IsBusy : Application.DoEvents() : Loop
                If .DocumentTitle = "Daftar - KEPALA KELUARGA" Then
                    Dim no_urut As Integer
                    Dim kk As String

                    Mod_Select.DataExcel(DGV_AK, RowsAK)

                    .Navigate("javascript:nm_gp_submit5('/grid_ddk02/', '/grid_ddk01/', 'nmgp_lig_edit_lapis?#?S?@?kodeklg?#?" + Mod_Select.NO_KK + "?@?namakk?#?" + Mod_Select.NAMA_KEP.Replace("'", "@aspass@") + "?@?kddesa?#?6171040002?@?', '_self', 'inicio', '0', '0')")

                    Do Until .DocumentTitle = "Daftar - ANGGOTA KELUARGA" : Application.DoEvents() : Loop

                    Do While .IsBusy : Application.DoEvents() : Loop

                    Dim AKBaru As GeckoInputElement
                    AKBaru = New GeckoInputElement(GWB.Document.GetElementById("sc_SC_btn_0_top").DomObject)
                    AKBaru.Click()

                    Do While .IsBusy : Application.DoEvents() : Loop
start2:
                    kk = Mod_Select.NO_KK

                    If Mod_Select.SHDK = "Kepala Keluarga".ToUpper Then
                        no_urut = 1
                    Else
                        no_urut += 1
                    End If

                    .Document.GetElementsByName("no_urut")(0).SetAttribute("value", no_urut)
                    .Document.GetElementsByName("nik")(0).SetAttribute("value", Mod_Select.NIK)
                    .Document.GetElementsByName("d025")(0).SetAttribute("value", Mod_Select.NAMA_LGKP)
                    .Document.GetElementsByName("d025a")(0).SetAttribute("value", "-")
                    JenisKelamin(GWB)
                    SHDK(GWB)
                    .Document.GetElementsByName("d028")(0).SetAttribute("value", "-")
                    .Document.GetElementsByName("d029")(0).SetAttribute("value", Mod_Select.TGL_LHR)
                    Status(GWB)
                    Agama(GWB)
                    GDR(GWB)
                    PDDK_Akhir(GWB)
                    Pekerjaan(GWB)

                    Dim nama_ortu As String
                    nama_ortu = Mod_Select.NAMA_LGKP_AYAH + " / " + Mod_Select.NAMA_LGKP_IBU
                    .Document.GetElementsByName("d038")(0).SetAttribute("value", nama_ortu)

                    Dim submit As GeckoButtonElement
                    submit = New GeckoButtonElement(.Document.GetElementById("sc_b_ins_t").DomObject)
                    submit.Click()

                    Do While .IsBusy : Application.DoEvents() : Loop

                    Dim maxRowIndex As Integer = (DGV_AK.Rows.Count - 1)
                    Dim curDataGridViewRow As DataGridViewRow = DGV_AK.CurrentRow
                    Dim curRowIndex As Integer = curDataGridViewRow.Index

                    If (curRowIndex >= maxRowIndex) Then
                        MsgBox("Tidak ada data lagi")
                        .Navigate("http://prodeskel.binapemdes.kemendagri.go.id/grid_ddk01/")
                        Exit Sub
                    Else
                        Dim nextRow As DataGridViewRow = DGV_AK.Rows(curRowIndex + 1)
                        DGV_AK.CurrentCell = nextRow.Cells(0)
                        nextRow.Selected = True

                        Mod_Select.DataExcel(DGV_AK, RowsAK)
                        txtfind.Text = Mod_Select.NO_KK

                        My.Settings.NO_KKAK = txtfind.Text
                        My.Settings.Save()

                        If Mod_Select.NO_KK <> kk Then
                            .Navigate("http://prodeskel.binapemdes.kemendagri.go.id/grid_ddk01/")

                            Do Until .DocumentTitle = "Daftar - KEPALA KELUARGA" : Application.DoEvents() : Loop

                            GoTo start1
                        Else
                            GoTo start2
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
            Exit Sub
        End Try
    End Sub

    Private Sub JenisKelamin(ByVal GWB As GeckoWebBrowser)
        Select Case Mod_Select.JK
            Case "LK".ToUpper
                GWB.Document.GetElementsByName("d026")(0).Click()
            Case "PR".ToUpper
                GWB.Document.GetElementsByName("d026")(1).Click()
            Case Else
                Throw New Exception(MsgBox("Jenis Kelamin " + Mod_Select.JK + ", UnListed on Program !", MsgBoxStyle.Exclamation))
        End Select
    End Sub

    Private Sub SHDK(ByVal GWB As GeckoWebBrowser)
        Select Case Mod_Select.SHDK
            Case "Kepala Keluarga".ToUpper
                GWB.Document.GetElementsByName("d027")(11).Click()
            Case "Istri".ToUpper
                GWB.Document.GetElementsByName("d027")(8).Click()
            Case "Anak".ToUpper
                GWB.Document.GetElementsByName("d027")(2).Click()
            Case "Orang Tua".ToUpper
                If Mod_Select.JK = "LK".ToUpper Then
                    GWB.Document.GetElementsByName("d027")(4).Click()
                Else
                    GWB.Document.GetElementsByName("d027")(7).Click()
                End If
            Case "Mertua".ToUpper
                GWB.Document.GetElementsByName("d027")(15).Click()
            Case "Menantu".ToUpper
                GWB.Document.GetElementsByName("d027")(14).Click()
            Case "Cucu".ToUpper
                GWB.Document.GetElementsByName("d027")(5).Click()
            Case "Famili Lain".ToUpper
                GWB.Document.GetElementsByName("d027")(6).Click()
            Case "Lainnya".ToUpper, "Pembantu".ToUpper
                GWB.Document.GetElementsByName("d027")(13).Click()
            Case Else
                Throw New Exception(MsgBox("SHDK " + Mod_Select.SHDK + ", UnListed on Program !", MsgBoxStyle.Exclamation))
        End Select
    End Sub

    Private Sub Status(ByVal GWB As GeckoWebBrowser)
        Select Case Mod_Select.STATUS
            Case "Belum Kawin".ToUpper
                GWB.Document.GetElementsByName("d031")(0).Click()
            Case "Kawin".ToUpper
                GWB.Document.GetElementsByName("d031")(1).Click()
            Case "Cerai".ToUpper, "Cerai Hidup".ToUpper, "Cerai Mati".ToUpper
                GWB.Document.GetElementsByName("d031")(2).Click()
            Case Else
                Throw New Exception(MsgBox("Status " + Mod_Select.STATUS + ", UnListed on Program !", MsgBoxStyle.Exclamation))
        End Select
    End Sub

    Private Sub Agama(ByVal GWB As GeckoWebBrowser)
        Select Case Mod_Select.AGAMA
            Case "Budha".ToUpper
                GWB.Document.GetElementsByName("d032")(0).Click()
            Case "Hindu".ToUpper
                GWB.Document.GetElementsByName("d032")(1).Click()
            Case "Islam".ToUpper
                GWB.Document.GetElementsByName("d032")(2).Click()
            Case "Katholik".ToUpper
                GWB.Document.GetElementsByName("d032")(3).Click()
            Case "Lainnya".ToUpper
                GWB.Document.GetElementsByName("d032")(4).Click()
            Case "Konghucu".ToUpper
                GWB.Document.GetElementsByName("d032")(5).Click()
            Case "Kristen".ToUpper
                GWB.Document.GetElementsByName("d032")(6).Click()
            Case Else
                Throw New Exception(MsgBox("Agama " + Mod_Select.AGAMA + ", UnListed on Program !", MsgBoxStyle.Exclamation))
        End Select
    End Sub

    Private Sub GDR(ByVal GWB As GeckoWebBrowser)
        Select Case Mod_Select.GDR
            Case "O".ToUpper, "O+".ToUpper, "O-".ToUpper
                GWB.Document.GetElementsByName("d033")(0).Click()
            Case "A".ToUpper, "A+".ToUpper, "A-".ToUpper
                GWB.Document.GetElementsByName("d033")(1).Click()
            Case "B".ToUpper, "B+".ToUpper, "B-".ToUpper
                GWB.Document.GetElementsByName("d033")(2).Click()
            Case "AB".ToUpper, "AB+".ToUpper, "AB-".ToUpper
                GWB.Document.GetElementsByName("d033")(3).Click()
            Case "Tidak Tahu".ToUpper
                GWB.Document.GetElementsByName("d033")(4).Click()
            Case Else
                Throw New Exception(MsgBox("GDR " + Mod_Select.GDR + ", UnListed on Program !", MsgBoxStyle.Exclamation))
        End Select
    End Sub

    Private Sub PDDK_Akhir(ByVal GWB As GeckoWebBrowser)
        Select Case Mod_Select.PDDK_AKHIR
            Case "Belum masuk TK/Kelompok Bermain"
                GWB.Document.GetElementsByName("d036")(0).Click()
            Case "Sedang TK/Kelompok Bermain"
                GWB.Document.GetElementsByName("d036")(1).Click()
            Case "Sedang SD / sederajat".ToUpper, "Blm Tamat SD".ToUpper, "Belum Tamat SD/Sederajat".ToUpper
                If Mod_Select.PEKERJAAN = "Pelajar".ToUpper Or Mod_Select.PEKERJAAN = "Pelajar/Mahasiswa".ToUpper Then
                    GWB.Document.GetElementsByName("d036")(2).Click()
                Else
                    GWB.Document.GetElementsByName("d036")(29).Click()
                End If
            Case "Sedang SLTP / Sederajat"
                GWB.Document.GetElementsByName("d036")(3).Click()
            Case "Sedang SLTA / sederajat"
                GWB.Document.GetElementsByName("d036")(4).Click()
            Case "Sedang D-1 / sederajat"
                GWB.Document.GetElementsByName("d036")(5).Click()
            Case "Sedang D-2 / sederajat"
                GWB.Document.GetElementsByName("d036")(6).Click()
            Case "Sedang D-3 / sederajat"
                GWB.Document.GetElementsByName("d036")(7).Click()
            Case "Sedang S-1 / sederajat"
                GWB.Document.GetElementsByName("d036")(8).Click()
            Case "Sedang S-2 / sederajat"
                GWB.Document.GetElementsByName("d036")(9).Click()
            Case "Sedang S-3 / sederajat"
                GWB.Document.GetElementsByName("d036")(10).Click()
            Case "Tamat SD/Sederajat".ToUpper, "Tamat SD".ToUpper
                GWB.Document.GetElementsByName("d036")(11).Click()
            Case "Tamat SLTP/Sederajat", "SLTP"
                GWB.Document.GetElementsByName("d036")(12).Click()
            Case "Tamat SLTA/Sederajat", "SLTA"
                GWB.Document.GetElementsByName("d036")(13).Click()
            Case "Tamat D-1 / sederajat"
                GWB.Document.GetElementsByName("d036")(14).Click()
            Case "Tamat D-2 / sederajat".ToUpper, "D I/II".ToUpper, "Diploma I/II".ToUpper
                GWB.Document.GetElementsByName("d036")(15).Click()
            Case "D III".ToUpper, "Akademi/Diploma III/S.Muda".ToUpper, "Diploma III".ToUpper
                GWB.Document.GetElementsByName("d036")(16).Click()
            Case "Tamat D-4 / sederajat"
                GWB.Document.GetElementsByName("d036")(17).Click()
            Case "D IV/ S I".ToUpper, "Diploma IV/Strata I".ToUpper
                GWB.Document.GetElementsByName("d036")(18).Click()
            Case "S II", "Strata II".ToUpper
                GWB.Document.GetElementsByName("d036")(19).Click()
            Case "S III", "Strata III".ToUpper
                GWB.Document.GetElementsByName("d036")(20).Click()
            Case "Sedang SLB A/sederajat"
                GWB.Document.GetElementsByName("d036")(21).Click()
            Case "Sedang SLB B/sederajat"
                GWB.Document.GetElementsByName("d036")(22).Click()
            Case "Sedang SLB C/sederajat"
                GWB.Document.GetElementsByName("d036")(23).Click()
            Case "Tamat SLB A/sederajat"
                GWB.Document.GetElementsByName("d036")(24).Click()
            Case "Tamat SLB B/sederajat"
                GWB.Document.GetElementsByName("d036")(25).Click()
            Case "Tamat SLB C/sederajat"
                GWB.Document.GetElementsByName("d036")(26).Click()
            Case "Tdk/ Blm Sekolah".ToUpper, "Tidak/Belum Sekolah".ToUpper
                GWB.Document.GetElementsByName("d036")(27).Click()
            Case "Tidak dapat membaca dan menulis huruf Latin/Arab"
                GWB.Document.GetElementsByName("d036")(28).Click()
            Case "Tidak tamat SD/sederajat"
                GWB.Document.GetElementsByName("d036")(29).Click()
            Case Else
                Throw New Exception(MsgBox("PDDK Akhir " + Mod_Select.PDDK_AKHIR + ", UnListed on Program !", MsgBoxStyle.Exclamation))
        End Select
    End Sub

    Private Sub Pekerjaan(ByVal GWB As GeckoWebBrowser)
        Select Case Mod_Select.PEKERJAAN
            Case "Ahli Pengobatan Alternatif"
                GWB.Document.GetElementsByName("d037")(0).Click()
            Case "Akuntan"
                GWB.Document.GetElementsByName("d037")(1).Click()
            Case "Anggota kabinet kementrian"
                GWB.Document.GetElementsByName("d037")(2).Click()
            Case "Anggota Legislatif", "Anggota DPRD Provinsi".ToUpper, "Anggota DPD".ToUpper
                GWB.Document.GetElementsByName("d037")(3).Click()
            Case "Anggota mahkamah konstitusi".ToUpper
                GWB.Document.GetElementsByName("d037")(4).Click()
            Case "Apoteker"
                GWB.Document.GetElementsByName("d037")(5).Click()
            Case "Arsitektur/Desainer".ToUpper, "Arsitek".ToUpper
                GWB.Document.GetElementsByName("d037")(6).Click()
            Case "Belum Bekerja".ToUpper, "Belum/Tidak Bekerja".ToUpper
                GWB.Document.GetElementsByName("d037")(7).Click()
            Case "Bidan swasta".ToUpper, "Bidan".ToUpper
                GWB.Document.GetElementsByName("d037")(8).Click()
            Case "Bupati/walikota"
                GWB.Document.GetElementsByName("d037")(9).Click()
            Case "Buruh Harian Lepas".ToUpper
                GWB.Document.GetElementsByName("d037")(10).Click()
            Case "Buruh jasa perdagangan hasil bumi".ToUpper, "Buruh Nelayan/Perikanan".ToUpper, "Buruh Peternakan".ToUpper
                GWB.Document.GetElementsByName("d037")(11).Click()
            Case "Buruh Migran"
                GWB.Document.GetElementsByName("d037")(12).Click()
            Case "Buruh Tani".ToUpper, "Buruh Tani/Perkebunan".ToUpper
                GWB.Document.GetElementsByName("d037")(13).Click()
            Case "Buruh usaha hotel dan penginapan lainnya"
                GWB.Document.GetElementsByName("d037")(14).Click()
            Case "Buruh usaha jasa hiburan dan pariwisata"
                GWB.Document.GetElementsByName("d037")(15).Click()
            Case "Buruh usaha jasa informasi dan komunikasi"
                GWB.Document.GetElementsByName("d037")(16).Click()
            Case "Buruh usaha jasa transportasi dan perhubungan"
                GWB.Document.GetElementsByName("d037")(17).Click()
            Case "Dokter swasta".ToUpper, "Dokter".ToUpper
                GWB.Document.GetElementsByName("d037")(18).Click()
            Case "Dosen swasta".ToUpper, "Dosen".ToUpper
                GWB.Document.GetElementsByName("d037")(19).Click()
            Case "Dukun Tradisional"
                GWB.Document.GetElementsByName("d037")(20).Click()
            Case "Dukun/paranormal/supranatural"
                GWB.Document.GetElementsByName("d037")(21).Click()
            Case "Duta besar"
                GWB.Document.GetElementsByName("d037")(22).Click()
            Case "Gubernur"
                GWB.Document.GetElementsByName("d037")(23).Click()
            Case "Guru swasta".ToUpper, "Guru".ToUpper
                GWB.Document.GetElementsByName("d037")(24).Click()
            Case "Ibu Rumah Tangga".ToUpper, "Mengurus Rumah Tangga".ToUpper
                GWB.Document.GetElementsByName("d037")(25).Click()
            Case "Jasa Konsultansi Manajemen dan Teknis"
                GWB.Document.GetElementsByName("d037")(26).Click()
            Case "Jasa pengobatan alternatif"
                GWB.Document.GetElementsByName("d037")(27).Click()
            Case "Jasa penyewaan peralatan pesta"
                GWB.Document.GetElementsByName("d037")(28).Click()
            Case "Juru Masak".ToUpper
                GWB.Document.GetElementsByName("d037")(29).Click()
            Case "Karyawan Honorer".ToUpper
                GWB.Document.GetElementsByName("d037")(30).Click()
            Case "Karyawan Perusahaan Pemerintah".ToUpper, "Karyawan BUMD".ToUpper, "Karyawan BUMN".ToUpper
                GWB.Document.GetElementsByName("d037")(31).Click()
            Case "Karyawan Perusahaan Swasta".ToUpper, "Industri".ToUpper, "Karyawan Swasta".ToUpper, "Konstruksi".ToUpper
                GWB.Document.GetElementsByName("d037")(32).Click()
            Case "Kepala Daerah"
                GWB.Document.GetElementsByName("d037")(33).Click()
            Case "Konsultan Manajemen dan Teknis".ToUpper, "Konsultan".ToUpper
                GWB.Document.GetElementsByName("d037")(34).Click()
            Case "Kontraktor"
                GWB.Document.GetElementsByName("d037")(35).Click()
            Case "Montir".ToUpper, "Mekanik".ToUpper
                GWB.Document.GetElementsByName("d037")(36).Click()
            Case "Nelayan".ToUpper, "Nelayan/Perikanan".ToUpper
                GWB.Document.GetElementsByName("d037")(37).Click()
            Case "Notaris".ToUpper
                GWB.Document.GetElementsByName("d037")(38).Click()
            Case "Pedagang barang kelontong".ToUpper, "Pedagang".ToUpper
                GWB.Document.GetElementsByName("d037")(39).Click()
            Case "Pedagang Keliling"
                GWB.Document.GetElementsByName("d037")(40).Click()
            Case "Pegawai Negeri Sipil".ToUpper
                GWB.Document.GetElementsByName("d037")(41).Click()
            Case "Pelajar".ToUpper, "Pelajar/Mahasiswa".ToUpper
                GWB.Document.GetElementsByName("d037")(42).Click()
            Case "Pelaut".ToUpper
                GWB.Document.GetElementsByName("d037")(43).Click()
            Case "Pembantu Rumah Tangga".ToUpper
                GWB.Document.GetElementsByName("d037")(44).Click()
            Case "Pemilik perusahaan"
                GWB.Document.GetElementsByName("d037")(45).Click()
            Case "Pemilik usaha hotel dan penginapan lainnya"
                GWB.Document.GetElementsByName("d037")(46).Click()
            Case "Pemilik usaha informasi dan komunikasi"
                GWB.Document.GetElementsByName("d037")(47).Click()
            Case "Pemilik usaha jasa hiburan dan pariwisata"
                GWB.Document.GetElementsByName("d037")(48).Click()
            Case "Pemilik usaha jasa transportasi dan perhubungan".ToUpper, "Transportasi".ToUpper
                GWB.Document.GetElementsByName("d037")(49).Click()
            Case "Pemilik usaha warung, rumah makan dan restoran"
                GWB.Document.GetElementsByName("d037")(50).Click()
            Case "Pemuka agama".ToUpper, "Imam Mesjid".ToUpper, "Pendeta".ToUpper, "Tabib".ToUpper, "Ustadz/Mubaligh".ToUpper, "Biarawati".ToUpper, "Pastor".ToUpper
                GWB.Document.GetElementsByName("d037")(51).Click()
            Case "Pemulung"
                GWB.Document.GetElementsByName("d037")(52).Click()
            Case "Penambang"
                GWB.Document.GetElementsByName("d037")(53).Click()
            Case "Peneliti"
                GWB.Document.GetElementsByName("d037")(54).Click()
            Case "Pengacara".ToUpper
                GWB.Document.GetElementsByName("d037")(55).Click()
            Case "Pengrajin".ToUpper, "Tukang Sol Sepatu".ToUpper
                GWB.Document.GetElementsByName("d037")(56).Click()
            Case "Pengrajin industri rumah tangga lainnya"
                GWB.Document.GetElementsByName("d037")(57).Click()
            Case "Pengusaha kecil, menengah dan besar"
                GWB.Document.GetElementsByName("d037")(58).Click()
            Case "Pengusaha perdagangan hasil bumi".ToUpper, "Perdagangan".ToUpper
                GWB.Document.GetElementsByName("d037")(59).Click()
            Case "Penyiar radio".ToUpper
                GWB.Document.GetElementsByName("d037")(60).Click()
            Case "Perangkat Desa"
                GWB.Document.GetElementsByName("d037")(61).Click()
            Case "Perawat swasta".ToUpper, "Perawat".ToUpper
                GWB.Document.GetElementsByName("d037")(62).Click()
            Case "Petani".ToUpper, "Petani/Pekebun".ToUpper
                GWB.Document.GetElementsByName("d037")(63).Click()
            Case "Peternak".ToUpper
                GWB.Document.GetElementsByName("d037")(64).Click()
            Case "Pialang".ToUpper
                GWB.Document.GetElementsByName("d037")(65).Click()
            Case "Pilot"
                GWB.Document.GetElementsByName("d037")(66).Click()
            Case "POLRI".ToUpper, "Kepolisian RI".ToUpper
                GWB.Document.GetElementsByName("d037")(67).Click()
            Case "Presiden"
                GWB.Document.GetElementsByName("d037")(68).Click()
            Case "Pskiater/Psikolog".ToUpper
                GWB.Document.GetElementsByName("d037")(69).Click()
            Case "Purnawirawan/Pensiunan".ToUpper, "Pensiunan".ToUpper
                GWB.Document.GetElementsByName("d037")(70).Click()
            Case "Satpam/Security"
                GWB.Document.GetElementsByName("d037")(71).Click()
            Case "Seniman/artis".ToUpper, "Seniman".ToUpper
                GWB.Document.GetElementsByName("d037")(72).Click()
            Case "Sopir".ToUpper
                GWB.Document.GetElementsByName("d037")(73).Click()
            Case "Tidak Mempunyai Pekerjaan Tetap".ToUpper, "Lainnya".ToUpper
                GWB.Document.GetElementsByName("d037")(74).Click()
            Case "TNI".ToUpper, "Tentara Nasional Indonesia".ToUpper
                GWB.Document.GetElementsByName("d037")(75).Click()
            Case "Tukang Anyaman"
                GWB.Document.GetElementsByName("d037")(76).Click()
            Case "Tukang Batu".ToUpper
                GWB.Document.GetElementsByName("d037")(77).Click()
            Case "Tukang Cuci"
                GWB.Document.GetElementsByName("d037")(78).Click()
            Case "Tukang Cukur".ToUpper, "Penata Rambut".ToUpper
                GWB.Document.GetElementsByName("d037")(79).Click()
            Case "Tukang Gigi".ToUpper
                GWB.Document.GetElementsByName("d037")(80).Click()
            Case "Tukang Jahit".ToUpper
                GWB.Document.GetElementsByName("d037")(81).Click()
            Case "Tukang Kayu".ToUpper
                GWB.Document.GetElementsByName("d037")(82).Click()
            Case "Tukang Kue"
                GWB.Document.GetElementsByName("d037")(83).Click()
            Case "Tukang Las/Pandai Besi".ToUpper
                GWB.Document.GetElementsByName("d037")(84).Click()
            Case "Tukang Listrik".ToUpper
                GWB.Document.GetElementsByName("d037")(85).Click()
            Case "Tukang Rias".ToUpper, "Penata Rias".ToUpper
                GWB.Document.GetElementsByName("d037")(86).Click()
            Case "Tukang Sumur"
                GWB.Document.GetElementsByName("d037")(87).Click()
            Case "Usaha jasa pengerah tenaga kerja"
                GWB.Document.GetElementsByName("d037")(88).Click()
            Case "Wakil bupati"
                GWB.Document.GetElementsByName("d037")(89).Click()
            Case "Wakil Gubernur"
                GWB.Document.GetElementsByName("d037")(90).Click()
            Case "Wakil presiden"
                GWB.Document.GetElementsByName("d037")(91).Click()
            Case "Wartawan".ToUpper
                GWB.Document.GetElementsByName("d037")(92).Click()
            Case "Wiraswasta".ToUpper
                GWB.Document.GetElementsByName("d037")(93).Click()
            Case Else
                Throw New Exception(MsgBox("Pekerjaan " + Mod_Select.PEKERJAAN + ", UnListed on Program !", MsgBoxStyle.Exclamation))
        End Select
    End Sub
End Module
