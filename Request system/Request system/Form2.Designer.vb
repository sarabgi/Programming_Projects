<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.picTOP_LEFT_01 = New System.Windows.Forms.PictureBox
        Me.picTOP_LEFT_02 = New System.Windows.Forms.PictureBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtexpiry = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtbatch = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnDelAll = New System.Windows.Forms.Button
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.btnClear = New System.Windows.Forms.Button
        Me.panelBOTTOM = New System.Windows.Forms.Panel
        Me.picBOTTOM_LEFT = New System.Windows.Forms.PictureBox
        Me.panelTOP = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcompany = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.picTOP_LEFT_01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTOP_LEFT_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBOTTOM.SuspendLayout()
        CType(Me.picBOTTOM_LEFT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTOP.SuspendLayout()
        Me.SuspendLayout()
        '
        'picTOP_LEFT_01
        '
        Me.picTOP_LEFT_01.Dock = System.Windows.Forms.DockStyle.Left
        Me.picTOP_LEFT_01.Image = CType(resources.GetObject("picTOP_LEFT_01.Image"), System.Drawing.Image)
        Me.picTOP_LEFT_01.Location = New System.Drawing.Point(0, 0)
        Me.picTOP_LEFT_01.Name = "picTOP_LEFT_01"
        Me.picTOP_LEFT_01.Size = New System.Drawing.Size(96, 78)
        Me.picTOP_LEFT_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTOP_LEFT_01.TabIndex = 0
        Me.picTOP_LEFT_01.TabStop = False
        '
        'picTOP_LEFT_02
        '
        Me.picTOP_LEFT_02.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picTOP_LEFT_02.Image = CType(resources.GetObject("picTOP_LEFT_02.Image"), System.Drawing.Image)
        Me.picTOP_LEFT_02.Location = New System.Drawing.Point(92, 0)
        Me.picTOP_LEFT_02.Name = "picTOP_LEFT_02"
        Me.picTOP_LEFT_02.Size = New System.Drawing.Size(940, 114)
        Me.picTOP_LEFT_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTOP_LEFT_02.TabIndex = 212
        Me.picTOP_LEFT_02.TabStop = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(96, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(832, 34)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Releasing of Credentials"
        '
        'txtexpiry
        '
        Me.txtexpiry.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexpiry.Location = New System.Drawing.Point(145, 213)
        Me.txtexpiry.Name = "txtexpiry"
        Me.txtexpiry.Size = New System.Drawing.Size(245, 25)
        Me.txtexpiry.TabIndex = 248
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(16, 222)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 16)
        Me.Label18.TabIndex = 263
        Me.Label18.Text = "DESCRIPTION:"
        '
        'txtbatch
        '
        Me.txtbatch.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatch.Location = New System.Drawing.Point(145, 141)
        Me.txtbatch.Name = "txtbatch"
        Me.txtbatch.Size = New System.Drawing.Size(131, 25)
        Me.txtbatch.TabIndex = 245
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(68, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 262
        Me.Label17.Text = "BATCH:"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(357, 564)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 42)
        Me.btnClose.TabIndex = 255
        Me.btnClose.Text = " &Back"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelAll
        '
        Me.btnDelAll.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnDelAll.Image = CType(resources.GetObject("btnDelAll.Image"), System.Drawing.Image)
        Me.btnDelAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelAll.Location = New System.Drawing.Point(217, 563)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(115, 43)
        Me.btnDelAll.TabIndex = 254
        Me.btnDelAll.Text = " &Delete All"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'DataGrid2
        '
        Me.DataGrid2.AllowNavigation = False
        Me.DataGrid2.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid2.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid2.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.FlatMode = True
        Me.DataGrid2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.DataGrid2.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid2.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.LinkColor = System.Drawing.Color.Teal
        Me.DataGrid2.Location = New System.Drawing.Point(553, 84)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid2.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid2.PreferredColumnWidth = 125
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.RowHeadersVisible = False
        Me.DataGrid2.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid2.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.Size = New System.Drawing.Size(470, 579)
        Me.DataGrid2.TabIndex = 244
        Me.DataGrid2.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(411, 501)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 40)
        Me.btnClear.TabIndex = 252
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'panelBOTTOM
        '
        Me.panelBOTTOM.Controls.Add(Me.picBOTTOM_LEFT)
        Me.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBOTTOM.Location = New System.Drawing.Point(0, 673)
        Me.panelBOTTOM.Name = "panelBOTTOM"
        Me.panelBOTTOM.Size = New System.Drawing.Size(1029, 47)
        Me.panelBOTTOM.TabIndex = 261
        '
        'picBOTTOM_LEFT
        '
        Me.picBOTTOM_LEFT.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.picBOTTOM_LEFT.Image = CType(resources.GetObject("picBOTTOM_LEFT.Image"), System.Drawing.Image)
        Me.picBOTTOM_LEFT.Location = New System.Drawing.Point(-3, -150)
        Me.picBOTTOM_LEFT.Name = "picBOTTOM_LEFT"
        Me.picBOTTOM_LEFT.Size = New System.Drawing.Size(1035, 196)
        Me.picBOTTOM_LEFT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBOTTOM_LEFT.TabIndex = 214
        Me.picBOTTOM_LEFT.TabStop = False
        '
        'panelTOP
        '
        Me.panelTOP.Controls.Add(Me.Label4)
        Me.panelTOP.Controls.Add(Me.Label16)
        Me.panelTOP.Controls.Add(Me.picTOP_LEFT_01)
        Me.panelTOP.Controls.Add(Me.picTOP_LEFT_02)
        Me.panelTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.panelTOP.Location = New System.Drawing.Point(0, 0)
        Me.panelTOP.Name = "panelTOP"
        Me.panelTOP.Size = New System.Drawing.Size(1029, 78)
        Me.panelTOP.TabIndex = 260
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(639, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(683, 26)
        Me.Label4.TabIndex = 3
        '
        'txtcompany
        '
        Me.txtcompany.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompany.Location = New System.Drawing.Point(145, 177)
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.Size = New System.Drawing.Size(245, 25)
        Me.txtcompany.TabIndex = 247
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(74, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 259
        Me.Label12.Text = "NAME:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(175, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 258
        Me.Label11.Text = "Label11"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(74, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "DATE:"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(77, 563)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 43)
        Me.btnDelete.TabIndex = 253
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(145, 499)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 42)
        Me.btnUpdate.TabIndex = 249
        Me.btnUpdate.Text = "  &Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(277, 499)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(113, 42)
        Me.btnSearch.TabIndex = 250
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(12, 499)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 42)
        Me.btnSave.TabIndex = 251
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1029, 720)
        Me.Controls.Add(Me.txtexpiry)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtbatch)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelAll)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.panelBOTTOM)
        Me.Controls.Add(Me.panelTOP)
        Me.Controls.Add(Me.txtcompany)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.picTOP_LEFT_01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTOP_LEFT_02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBOTTOM.ResumeLayout(False)
        CType(Me.picBOTTOM_LEFT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTOP.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents picTOP_LEFT_01 As System.Windows.Forms.PictureBox
    Private WithEvents picTOP_LEFT_02 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtexpiry As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtbatch As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelAll As System.Windows.Forms.Button
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Private WithEvents panelBOTTOM As System.Windows.Forms.Panel
    Private WithEvents picBOTTOM_LEFT As System.Windows.Forms.PictureBox
    Private WithEvents panelTOP As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcompany As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
