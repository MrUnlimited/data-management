Module Mod_Select
    Public NO_KK As String
    Public NAMA_KEP As String
    Public ALAMAT As String
    Public NO_RT As String
    Public NO_RW As String
    Public NIK As String
    Public NAMA_LGKP As String
    Public JK As String = "pr".ToUpper
    Public TGL_LHR As String
    Public UMUR As String
    Public SHDK As String
    Public STATUS As String
    Public AGAMA As String
    Public GDR As String
    Public PDDK_AKHIR As String
    Public PEKERJAAN As String
    Public STAT_KTP As String
    Public AKTA_LHR As String
    Public AKTA_KWN As String
    Public CACAT As String
    Public NAMA_LGKP_IBU As String
    Public NAMA_LGKP_AYAH As String
    Public KECAMATAN As String
    Public KELURAHAN As String

    Public Sub DataExcel(ByVal DGV As DataGridView, ByVal ROWs As ToolStripLabel)
        Dim i As Integer

        i = DGV.CurrentRow.Index

        NO_KK = (DGV.Item(0, i).Value.ToString()).ToUpper
        NAMA_KEP = (DGV.Item(1, i).Value.ToString()).ToUpper
        ALAMAT = (DGV.Item(2, i).Value.ToString()).ToUpper
        NO_RT = (DGV.Item(3, i).Value.ToString()).ToUpper
        NO_RW = (DGV.Item(4, i).Value.ToString()).ToUpper
        NIK = (DGV.Item(5, i).Value.ToString()).ToUpper
        NAMA_LGKP = (DGV.Item(6, i).Value.ToString()).ToUpper
        JK = (DGV.Item(7, i).Value.ToString()).ToUpper
        TGL_LHR = Format(DGV.Item(8, i).Value, "dd/MM/yyy").ToString.ToUpper
        UMUR = (DGV.Item(9, i).Value.ToString()).ToUpper
        SHDK = (DGV.Item(10, i).Value.ToString()).ToUpper
        STATUS = (DGV.Item(11, i).Value.ToString()).ToUpper
        AGAMA = (DGV.Item(12, i).Value.ToString()).ToUpper
        GDR = (DGV.Item(13, i).Value.ToString()).ToUpper
        PDDK_AKHIR = (DGV.Item(14, i).Value.ToString()).ToUpper
        PEKERJAAN = (DGV.Item(15, i).Value.ToString()).ToUpper
        STAT_KTP = (DGV.Item(16, i).Value.ToString()).ToUpper
        AKTA_LHR = (DGV.Item(17, i).Value.ToString()).ToUpper
        AKTA_KWN = (DGV.Item(18, i).Value.ToString()).ToUpper
        CACAT = (DGV.Item(19, i).Value.ToString()).ToUpper
        NAMA_LGKP_IBU = (DGV.Item(20, i).Value.ToString()).ToUpper
        NAMA_LGKP_AYAH = (DGV.Item(21, i).Value.ToString()).ToUpper
        KECAMATAN = (DGV.Item(22, i).Value.ToString()).ToUpper
        KELURAHAN = (DGV.Item(23, i).Value.ToString()).ToUpper

        ROWs.Text = DGV.CurrentRow.Index + 1
    End Sub
End Module
