<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewUser_Group8_Kiet_13
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
        Me.TBTenKH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TBMaKH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBLoaiKH = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TBNhanKhau = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TBMaSoThue = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TBDiaChiKH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBTenKH
        '
        Me.TBTenKH.BorderColor = System.Drawing.Color.Silver
        Me.TBTenKH.BorderRadius = 10
        Me.TBTenKH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBTenKH.DefaultText = ""
        Me.TBTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBTenKH.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBTenKH.Location = New System.Drawing.Point(245, 159)
        Me.TBTenKH.Name = "TBTenKH"
        Me.TBTenKH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBTenKH.PlaceholderText = ""
        Me.TBTenKH.SelectedText = ""
        Me.TBTenKH.Size = New System.Drawing.Size(210, 35)
        Me.TBTenKH.TabIndex = 4
        '
        'TBMaKH
        '
        Me.TBMaKH.BorderColor = System.Drawing.Color.Silver
        Me.TBMaKH.BorderRadius = 10
        Me.TBMaKH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBMaKH.DefaultText = ""
        Me.TBMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBMaKH.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBMaKH.Location = New System.Drawing.Point(29, 159)
        Me.TBMaKH.Name = "TBMaKH"
        Me.TBMaKH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBMaKH.PlaceholderText = ""
        Me.TBMaKH.SelectedText = ""
        Me.TBMaKH.Size = New System.Drawing.Size(210, 35)
        Me.TBMaKH.TabIndex = 3
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.BtnAdd)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.CBLoaiKH)
        Me.Guna2Panel1.Controls.Add(Me.TBNhanKhau)
        Me.Guna2Panel1.Controls.Add(Me.TBMaSoThue)
        Me.Guna2Panel1.Controls.Add(Me.TBDiaChiKH)
        Me.Guna2Panel1.Controls.Add(Me.TBMaKH)
        Me.Guna2Panel1.Controls.Add(Me.TBTenKH)
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(490, 426)
        Me.Guna2Panel1.TabIndex = 5
        '
        'BtnAdd
        '
        Me.BtnAdd.AutoRoundedCorners = True
        Me.BtnAdd.BorderRadius = 10
        Me.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(337, 349)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(118, 34)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "Xác Nhận"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Loại khách hàng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nhan khau"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mã số thuế"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Địa Chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tên Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Mã khách hàng"
        '
        'CBLoaiKH
        '
        Me.CBLoaiKH.BackColor = System.Drawing.Color.Transparent
        Me.CBLoaiKH.BorderColor = System.Drawing.Color.Silver
        Me.CBLoaiKH.BorderRadius = 10
        Me.CBLoaiKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBLoaiKH.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBLoaiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBLoaiKH.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLoaiKH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBLoaiKH.ItemHeight = 30
        Me.CBLoaiKH.Location = New System.Drawing.Point(245, 283)
        Me.CBLoaiKH.Name = "CBLoaiKH"
        Me.CBLoaiKH.Size = New System.Drawing.Size(210, 36)
        Me.CBLoaiKH.TabIndex = 8
        '
        'TBNhanKhau
        '
        Me.TBNhanKhau.BorderColor = System.Drawing.Color.Silver
        Me.TBNhanKhau.BorderRadius = 10
        Me.TBNhanKhau.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBNhanKhau.DefaultText = ""
        Me.TBNhanKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBNhanKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBNhanKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBNhanKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBNhanKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBNhanKhau.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNhanKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBNhanKhau.Location = New System.Drawing.Point(29, 283)
        Me.TBNhanKhau.Name = "TBNhanKhau"
        Me.TBNhanKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBNhanKhau.PlaceholderText = ""
        Me.TBNhanKhau.SelectedText = ""
        Me.TBNhanKhau.Size = New System.Drawing.Size(210, 35)
        Me.TBNhanKhau.TabIndex = 7
        '
        'TBMaSoThue
        '
        Me.TBMaSoThue.BorderColor = System.Drawing.Color.Silver
        Me.TBMaSoThue.BorderRadius = 10
        Me.TBMaSoThue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBMaSoThue.DefaultText = ""
        Me.TBMaSoThue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBMaSoThue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBMaSoThue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBMaSoThue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBMaSoThue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBMaSoThue.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMaSoThue.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBMaSoThue.Location = New System.Drawing.Point(245, 224)
        Me.TBMaSoThue.Name = "TBMaSoThue"
        Me.TBMaSoThue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBMaSoThue.PlaceholderText = ""
        Me.TBMaSoThue.SelectedText = ""
        Me.TBMaSoThue.Size = New System.Drawing.Size(210, 35)
        Me.TBMaSoThue.TabIndex = 6
        '
        'TBDiaChiKH
        '
        Me.TBDiaChiKH.BorderColor = System.Drawing.Color.Silver
        Me.TBDiaChiKH.BorderRadius = 10
        Me.TBDiaChiKH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBDiaChiKH.DefaultText = ""
        Me.TBDiaChiKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TBDiaChiKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TBDiaChiKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBDiaChiKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TBDiaChiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBDiaChiKH.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDiaChiKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TBDiaChiKH.Location = New System.Drawing.Point(29, 223)
        Me.TBDiaChiKH.Name = "TBDiaChiKH"
        Me.TBDiaChiKH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TBDiaChiKH.PlaceholderText = ""
        Me.TBDiaChiKH.SelectedText = ""
        Me.TBDiaChiKH.Size = New System.Drawing.Size(210, 35)
        Me.TBDiaChiKH.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(79, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(324, 45)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tạo khách hàng mới"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Guna2PictureBox1.Image = Global.WaterBilling2.My.Resources.Resources.animation_640_l4il0qrj
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(490, 1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(525, 426)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 6
        Me.Guna2PictureBox1.TabStop = False
        '
        'AddNewUser_Group8_Kiet_13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 428)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "AddNewUser_Group8_Kiet_13"
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBTenKH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TBMaKH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CBLoaiKH As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TBNhanKhau As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TBMaSoThue As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TBDiaChiKH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label7 As Label
End Class
