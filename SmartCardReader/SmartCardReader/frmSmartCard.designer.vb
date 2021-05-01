<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSmartCard))
        Me.txtFirstNameThai = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtIDCard = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrefixEng = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrefixThai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtAmphur = New System.Windows.Forms.TextBox()
        Me.txtTambol = New System.Windows.Forms.TextBox()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.txtLane = New System.Windows.Forms.TextBox()
        Me.txtVillageNo = New System.Windows.Forms.TextBox()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtExpireDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIssueDate = New System.Windows.Forms.TextBox()
        Me.txtBirthDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLastnameEng = New System.Windows.Forms.TextBox()
        Me.txtFirstNameEng = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLastnameThai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picData = New System.Windows.Forms.PictureBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstNameThai
        '
        Me.txtFirstNameThai.Location = New System.Drawing.Point(142, 98)
        Me.txtFirstNameThai.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFirstNameThai.MaxLength = 120
        Me.txtFirstNameThai.Name = "txtFirstNameThai"
        Me.txtFirstNameThai.Size = New System.Drawing.Size(350, 26)
        Me.txtFirstNameThai.TabIndex = 3
        Me.txtFirstNameThai.Text = "txtFirstNameThai"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(22, 101)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 18)
        Me.label2.TabIndex = 23
        Me.label2.Text = "ชื่อ (ไทย)"
        '
        'txtIDCard
        '
        Me.txtIDCard.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtIDCard.ForeColor = System.Drawing.Color.Navy
        Me.txtIDCard.Location = New System.Drawing.Point(142, 34)
        Me.txtIDCard.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtIDCard.MaxLength = 25
        Me.txtIDCard.Name = "txtIDCard"
        Me.txtIDCard.Size = New System.Drawing.Size(219, 26)
        Me.txtIDCard.TabIndex = 0
        Me.txtIDCard.Text = "txtIDCard"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(22, 37)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(111, 18)
        Me.label1.TabIndex = 21
        Me.label1.Text = "เลขบัตรประชาชน"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.txtPrefixEng)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPrefixThai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSex)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.txtProvince)
        Me.GroupBox1.Controls.Add(Me.txtAmphur)
        Me.GroupBox1.Controls.Add(Me.txtTambol)
        Me.GroupBox1.Controls.Add(Me.txtRoad)
        Me.GroupBox1.Controls.Add(Me.txtLane)
        Me.GroupBox1.Controls.Add(Me.txtVillageNo)
        Me.GroupBox1.Controls.Add(Me.txtHouseNo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtExpireDate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtIssueDate)
        Me.GroupBox1.Controls.Add(Me.txtBirthDate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLastnameEng)
        Me.GroupBox1.Controls.Add(Me.txtFirstNameEng)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtLastnameThai)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.picData)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.txtIDCard)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.txtFirstNameThai)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(838, 458)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " ข้อมูลจากบัตรประชาชน "
        '
        'txtPrefixEng
        '
        Me.txtPrefixEng.Location = New System.Drawing.Point(378, 65)
        Me.txtPrefixEng.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPrefixEng.MaxLength = 120
        Me.txtPrefixEng.Name = "txtPrefixEng"
        Me.txtPrefixEng.Size = New System.Drawing.Size(114, 26)
        Me.txtPrefixEng.TabIndex = 2
        Me.txtPrefixEng.Text = "txtPrefixEng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(266, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 18)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "คำนำหน้า (Eng)"
        '
        'txtPrefixThai
        '
        Me.txtPrefixThai.Location = New System.Drawing.Point(142, 65)
        Me.txtPrefixThai.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPrefixThai.MaxLength = 120
        Me.txtPrefixThai.Name = "txtPrefixThai"
        Me.txtPrefixThai.Size = New System.Drawing.Size(114, 26)
        Me.txtPrefixThai.TabIndex = 1
        Me.txtPrefixThai.Text = "txtPrefixThai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "คำนำหน้า (ไทย)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(380, 238)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 18)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "เพศ"
        '
        'txtSex
        '
        Me.txtSex.Location = New System.Drawing.Point(423, 235)
        Me.txtSex.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSex.MaxLength = 120
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(69, 26)
        Me.txtSex.TabIndex = 8
        Me.txtSex.Text = "txtSex"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(524, 11)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(305, 23)
        Me.ProgressBar1.TabIndex = 18
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(472, 419)
        Me.txtProvince.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtProvince.MaxLength = 120
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(188, 26)
        Me.txtProvince.TabIndex = 17
        Me.txtProvince.Text = "txtProvince"
        '
        'txtAmphur
        '
        Me.txtAmphur.Location = New System.Drawing.Point(143, 419)
        Me.txtAmphur.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtAmphur.MaxLength = 120
        Me.txtAmphur.Name = "txtAmphur"
        Me.txtAmphur.Size = New System.Drawing.Size(260, 26)
        Me.txtAmphur.TabIndex = 16
        Me.txtAmphur.Text = "txtAmphur"
        '
        'txtTambol
        '
        Me.txtTambol.Location = New System.Drawing.Point(143, 385)
        Me.txtTambol.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTambol.MaxLength = 120
        Me.txtTambol.Name = "txtTambol"
        Me.txtTambol.Size = New System.Drawing.Size(260, 26)
        Me.txtTambol.TabIndex = 15
        Me.txtTambol.Text = "txtTambol"
        '
        'txtRoad
        '
        Me.txtRoad.Location = New System.Drawing.Point(659, 351)
        Me.txtRoad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtRoad.MaxLength = 120
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(171, 26)
        Me.txtRoad.TabIndex = 14
        Me.txtRoad.Text = "txtRoad"
        '
        'txtLane
        '
        Me.txtLane.Location = New System.Drawing.Point(474, 351)
        Me.txtLane.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLane.MaxLength = 120
        Me.txtLane.Name = "txtLane"
        Me.txtLane.Size = New System.Drawing.Size(130, 26)
        Me.txtLane.TabIndex = 13
        Me.txtLane.Text = "txtLane"
        '
        'txtVillageNo
        '
        Me.txtVillageNo.Location = New System.Drawing.Point(334, 351)
        Me.txtVillageNo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtVillageNo.MaxLength = 120
        Me.txtVillageNo.Name = "txtVillageNo"
        Me.txtVillageNo.Size = New System.Drawing.Size(69, 26)
        Me.txtVillageNo.TabIndex = 12
        Me.txtVillageNo.Text = "txtVillageNo"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Location = New System.Drawing.Point(143, 351)
        Me.txtHouseNo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtHouseNo.MaxLength = 120
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(123, 26)
        Me.txtHouseNo.TabIndex = 11
        Me.txtHouseNo.Text = "txtHouseNo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(413, 422)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 18)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "จังหวัด"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 422)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 18)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "อำเภอ/เขต"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 388)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 18)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "ตำบล"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(614, 354)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 18)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "ถนน"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(413, 354)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 18)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "ซอย"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(286, 354)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 18)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "หมู่ที่"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 354)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 18)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "บ้านเลขที่"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 320)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "บัตรหมดอายุ"
        '
        'txtExpireDate
        '
        Me.txtExpireDate.Location = New System.Drawing.Point(142, 317)
        Me.txtExpireDate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtExpireDate.MaxLength = 120
        Me.txtExpireDate.Name = "txtExpireDate"
        Me.txtExpireDate.Size = New System.Drawing.Size(219, 26)
        Me.txtExpireDate.TabIndex = 10
        Me.txtExpireDate.Text = "txtExpireDate"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 286)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "วันออกบัตร"
        '
        'txtIssueDate
        '
        Me.txtIssueDate.Location = New System.Drawing.Point(142, 283)
        Me.txtIssueDate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtIssueDate.MaxLength = 120
        Me.txtIssueDate.Name = "txtIssueDate"
        Me.txtIssueDate.Size = New System.Drawing.Size(219, 26)
        Me.txtIssueDate.TabIndex = 9
        Me.txtIssueDate.Text = "txtIssueDate"
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Location = New System.Drawing.Point(142, 235)
        Me.txtBirthDate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtBirthDate.MaxLength = 120
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(219, 26)
        Me.txtBirthDate.TabIndex = 7
        Me.txtBirthDate.Text = "txtBirthDate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 238)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "วันเดือนปีเกิด"
        '
        'txtLastnameEng
        '
        Me.txtLastnameEng.Location = New System.Drawing.Point(142, 201)
        Me.txtLastnameEng.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLastnameEng.MaxLength = 120
        Me.txtLastnameEng.Name = "txtLastnameEng"
        Me.txtLastnameEng.Size = New System.Drawing.Size(350, 26)
        Me.txtLastnameEng.TabIndex = 6
        Me.txtLastnameEng.Text = "txtLastnameEng"
        '
        'txtFirstNameEng
        '
        Me.txtFirstNameEng.Location = New System.Drawing.Point(142, 167)
        Me.txtFirstNameEng.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFirstNameEng.MaxLength = 120
        Me.txtFirstNameEng.Name = "txtFirstNameEng"
        Me.txtFirstNameEng.Size = New System.Drawing.Size(350, 26)
        Me.txtFirstNameEng.TabIndex = 5
        Me.txtFirstNameEng.Text = "txtFirstNameEng"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 204)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Lastname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 170)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Firstname"
        '
        'txtLastnameThai
        '
        Me.txtLastnameThai.Location = New System.Drawing.Point(142, 133)
        Me.txtLastnameThai.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLastnameThai.MaxLength = 120
        Me.txtLastnameThai.Name = "txtLastnameThai"
        Me.txtLastnameThai.Size = New System.Drawing.Size(350, 26)
        Me.txtLastnameThai.TabIndex = 4
        Me.txtLastnameThai.Text = "txtLastnameThai"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "นามสกุล (ไทย)"
        '
        'picData
        '
        Me.picData.Location = New System.Drawing.Point(524, 34)
        Me.picData.Name = "picData"
        Me.picData.Size = New System.Drawing.Size(305, 264)
        Me.picData.TabIndex = 32
        Me.picData.TabStop = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRead.ForeColor = System.Drawing.Color.White
        Me.btnRead.Location = New System.Drawing.Point(306, 466)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(119, 43)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "อ่านบัตร F7"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(450, 466)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 43)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "จบโปรแกรม F10"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAge.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAge.Location = New System.Drawing.Point(139, 265)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(32, 13)
        Me.lblAge.TabIndex = 64
        Me.lblAge.Text = "อายุ: "
        '
        'frmSmartCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 517)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSmartCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Card Reader with VB.NET - CodE bY: Thongkorn Tumtimkrob"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtFirstNameThai As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtIDCard As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picData As System.Windows.Forms.PictureBox
    Private WithEvents txtLastnameEng As System.Windows.Forms.TextBox
    Private WithEvents txtFirstNameEng As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtLastnameThai As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtIssueDate As System.Windows.Forms.TextBox
    Private WithEvents txtBirthDate As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents txtExpireDate As System.Windows.Forms.TextBox
    Private WithEvents txtProvince As System.Windows.Forms.TextBox
    Private WithEvents txtAmphur As System.Windows.Forms.TextBox
    Private WithEvents txtTambol As System.Windows.Forms.TextBox
    Private WithEvents txtRoad As System.Windows.Forms.TextBox
    Private WithEvents txtLane As System.Windows.Forms.TextBox
    Private WithEvents txtVillageNo As System.Windows.Forms.TextBox
    Private WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtSex As System.Windows.Forms.TextBox
    Private WithEvents txtPrefixEng As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtPrefixThai As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAge As System.Windows.Forms.Label
End Class
