<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PRODESKEL
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_PRODESKEL))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FileToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SettingToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PingToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GWB = New Gecko.GeckoWebBrowser()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGV_KK = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.FindKKToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FindKKToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TotalKKToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.RowsKKToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGV_AK = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.FindAKToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FindAKToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TotalAKToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.RowsAKToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV_KK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_AK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripDropDownButton, Me.OpenToolStripButton, Me.SettingToolStripDropDownButton, Me.PingToolStripLabel, Me.ToolStripLabel2, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripButton1, Me.ToolStripButton5, Me.ToolStripButton2, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FileToolStripDropDownButton
        '
        Me.FileToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripDropDownButton.Image = CType(resources.GetObject("FileToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.FileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileToolStripDropDownButton.Name = "FileToolStripDropDownButton"
        Me.FileToolStripDropDownButton.Size = New System.Drawing.Size(54, 22)
        Me.FileToolStripDropDownButton.Text = "&File"
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Image = CType(resources.GetObject("LogInToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogInToolStripMenuItem.Text = "Log &In"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log &Out"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(56, 22)
        Me.OpenToolStripButton.Text = "O&pen"
        '
        'SettingToolStripDropDownButton
        '
        Me.SettingToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ToolStripMenuItem2, Me.TabControlToolStripMenuItem})
        Me.SettingToolStripDropDownButton.Image = CType(resources.GetObject("SettingToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.SettingToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SettingToolStripDropDownButton.Name = "SettingToolStripDropDownButton"
        Me.SettingToolStripDropDownButton.Size = New System.Drawing.Size(73, 22)
        Me.SettingToolStripDropDownButton.Text = "&Setting"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Image = CType(resources.GetObject("UserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(134, 6)
        '
        'TabControlToolStripMenuItem
        '
        Me.TabControlToolStripMenuItem.Image = CType(resources.GetObject("TabControlToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TabControlToolStripMenuItem.Name = "TabControlToolStripMenuItem"
        Me.TabControlToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.TabControlToolStripMenuItem.Text = "Tab Control"
        '
        'PingToolStripLabel
        '
        Me.PingToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PingToolStripLabel.AutoSize = False
        Me.PingToolStripLabel.Name = "PingToolStripLabel"
        Me.PingToolStripLabel.Size = New System.Drawing.Size(50, 22)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel2.Text = "Ping : "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Go Back"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Home"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Enabled = False
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "KK dan Kartu Keluarga"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Refresh"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Go Forward"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GWB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProgressBar1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 537)
        Me.SplitContainer1.SplitterDistance = 317
        Me.SplitContainer1.TabIndex = 1
        '
        'GWB
        '
        Me.GWB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GWB.Location = New System.Drawing.Point(0, 5)
        Me.GWB.Name = "GWB"
        Me.GWB.Size = New System.Drawing.Size(784, 312)
        Me.GWB.TabIndex = 0
        Me.GWB.UseHttpActivityObserver = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(784, 5)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 216)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGV_KK)
        Me.TabPage1.Controls.Add(Me.ToolStrip2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ImageIndex = 1
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 173)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Input KK"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGV_KK
        '
        Me.DGV_KK.AllowUserToAddRows = False
        Me.DGV_KK.AllowUserToDeleteRows = False
        Me.DGV_KK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_KK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_KK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_KK.Location = New System.Drawing.Point(3, 28)
        Me.DGV_KK.MultiSelect = False
        Me.DGV_KK.Name = "DGV_KK"
        Me.DGV_KK.ReadOnly = True
        Me.DGV_KK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_KK.Size = New System.Drawing.Size(770, 142)
        Me.DGV_KK.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.FindKKToolStripTextBox, Me.FindKKToolStripButton, Me.TotalKKToolStripLabel, Me.ToolStripLabel3, Me.RowsKKToolStripLabel, Me.ToolStripLabel4})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(770, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(30, 22)
        Me.ToolStripLabel1.Text = "Find"
        '
        'FindKKToolStripTextBox
        '
        Me.FindKKToolStripTextBox.AutoSize = False
        Me.FindKKToolStripTextBox.Name = "FindKKToolStripTextBox"
        Me.FindKKToolStripTextBox.Size = New System.Drawing.Size(150, 25)
        '
        'FindKKToolStripButton
        '
        Me.FindKKToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindKKToolStripButton.Image = CType(resources.GetObject("FindKKToolStripButton.Image"), System.Drawing.Image)
        Me.FindKKToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FindKKToolStripButton.Name = "FindKKToolStripButton"
        Me.FindKKToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.FindKKToolStripButton.Text = "Find"
        '
        'TotalKKToolStripLabel
        '
        Me.TotalKKToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TotalKKToolStripLabel.AutoSize = False
        Me.TotalKKToolStripLabel.Name = "TotalKKToolStripLabel"
        Me.TotalKKToolStripLabel.Size = New System.Drawing.Size(45, 22)
        Me.TotalKKToolStripLabel.Text = "0"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel3.Text = "Total :"
        '
        'RowsKKToolStripLabel
        '
        Me.RowsKKToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RowsKKToolStripLabel.AutoSize = False
        Me.RowsKKToolStripLabel.Margin = New System.Windows.Forms.Padding(0, 1, 10, 2)
        Me.RowsKKToolStripLabel.Name = "RowsKKToolStripLabel"
        Me.RowsKKToolStripLabel.Size = New System.Drawing.Size(45, 22)
        Me.RowsKKToolStripLabel.Text = "0"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel4.Text = "Row(s) : "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGV_AK)
        Me.TabPage2.Controls.Add(Me.ToolStrip3)
        Me.TabPage2.ImageIndex = 0
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 173)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Input AK"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGV_AK
        '
        Me.DGV_AK.AllowUserToAddRows = False
        Me.DGV_AK.AllowUserToDeleteRows = False
        Me.DGV_AK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_AK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_AK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_AK.Location = New System.Drawing.Point(3, 28)
        Me.DGV_AK.MultiSelect = False
        Me.DGV_AK.Name = "DGV_AK"
        Me.DGV_AK.ReadOnly = True
        Me.DGV_AK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_AK.Size = New System.Drawing.Size(770, 142)
        Me.DGV_AK.TabIndex = 1
        '
        'ToolStrip3
        '
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5, Me.FindAKToolStripTextBox, Me.FindAKToolStripButton, Me.TotalAKToolStripLabel, Me.ToolStripLabel7, Me.RowsAKToolStripLabel, Me.ToolStripLabel9})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.ToolStrip3.Size = New System.Drawing.Size(770, 25)
        Me.ToolStrip3.TabIndex = 3
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(30, 22)
        Me.ToolStripLabel5.Text = "Find"
        '
        'FindAKToolStripTextBox
        '
        Me.FindAKToolStripTextBox.AutoSize = False
        Me.FindAKToolStripTextBox.Name = "FindAKToolStripTextBox"
        Me.FindAKToolStripTextBox.Size = New System.Drawing.Size(150, 25)
        '
        'FindAKToolStripButton
        '
        Me.FindAKToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindAKToolStripButton.Image = CType(resources.GetObject("FindAKToolStripButton.Image"), System.Drawing.Image)
        Me.FindAKToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FindAKToolStripButton.Name = "FindAKToolStripButton"
        Me.FindAKToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.FindAKToolStripButton.Text = "Find"
        '
        'TotalAKToolStripLabel
        '
        Me.TotalAKToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TotalAKToolStripLabel.AutoSize = False
        Me.TotalAKToolStripLabel.Name = "TotalAKToolStripLabel"
        Me.TotalAKToolStripLabel.Size = New System.Drawing.Size(45, 22)
        Me.TotalAKToolStripLabel.Text = "0"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel7.Text = "Total :"
        '
        'RowsAKToolStripLabel
        '
        Me.RowsAKToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RowsAKToolStripLabel.AutoSize = False
        Me.RowsAKToolStripLabel.Margin = New System.Windows.Forms.Padding(0, 1, 10, 2)
        Me.RowsAKToolStripLabel.Name = "RowsAKToolStripLabel"
        Me.RowsAKToolStripLabel.Size = New System.Drawing.Size(45, 22)
        Me.RowsAKToolStripLabel.Text = "0"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel9.Text = "Row(s) : "
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "AK.png")
        Me.ImageList1.Images.SetKeyName(1, "KK.png")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form_PRODESKEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form_PRODESKEL"
        Me.Text = "Form_PRODESKEL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGV_KK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGV_AK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GWB As Gecko.GeckoWebBrowser
    Friend WithEvents FileToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LogInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SettingToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DGV_KK As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents DGV_AK As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FindKKToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FindKKToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TotalKKToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RowsKKToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FindAKToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FindAKToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TotalAKToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RowsAKToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel9 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PingToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
