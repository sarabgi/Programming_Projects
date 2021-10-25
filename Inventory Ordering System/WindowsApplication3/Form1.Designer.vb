<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkFullSet = New System.Windows.Forms.CheckBox()
        Me.chkShoes = New System.Windows.Forms.CheckBox()
        Me.chkSupp = New System.Windows.Forms.CheckBox()
        Me.chkSocks = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbEight = New System.Windows.Forms.CheckBox()
        Me.rbFour = New System.Windows.Forms.CheckBox()
        Me.rbTwo = New System.Windows.Forms.CheckBox()
        Me.rbOne = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstBrand = New System.Windows.Forms.ListBox()
        Me.lblPrice = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(148, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Price "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(412, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(702, 442)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFullSet)
        Me.GroupBox1.Controls.Add(Me.chkShoes)
        Me.GroupBox1.Controls.Add(Me.chkSupp)
        Me.GroupBox1.Controls.Add(Me.chkSocks)
        Me.GroupBox1.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(342, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 264)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items"
        '
        'chkFullSet
        '
        Me.chkFullSet.AutoSize = True
        Me.chkFullSet.Location = New System.Drawing.Point(21, 199)
        Me.chkFullSet.Name = "chkFullSet"
        Me.chkFullSet.Size = New System.Drawing.Size(120, 36)
        Me.chkFullSet.TabIndex = 9
        Me.chkFullSet.Text = "Full Set"
        Me.chkFullSet.UseVisualStyleBackColor = True
        '
        'chkShoes
        '
        Me.chkShoes.AutoSize = True
        Me.chkShoes.Location = New System.Drawing.Point(21, 155)
        Me.chkShoes.Name = "chkShoes"
        Me.chkShoes.Size = New System.Drawing.Size(97, 36)
        Me.chkShoes.TabIndex = 8
        Me.chkShoes.Text = "Shoes"
        Me.chkShoes.UseVisualStyleBackColor = True
        '
        'chkSupp
        '
        Me.chkSupp.AutoSize = True
        Me.chkSupp.Location = New System.Drawing.Point(21, 108)
        Me.chkSupp.Name = "chkSupp"
        Me.chkSupp.Size = New System.Drawing.Size(142, 36)
        Me.chkSupp.TabIndex = 7
        Me.chkSupp.Text = "Supporter"
        Me.chkSupp.UseVisualStyleBackColor = True
        '
        'chkSocks
        '
        Me.chkSocks.AutoSize = True
        Me.chkSocks.Location = New System.Drawing.Point(21, 56)
        Me.chkSocks.Name = "chkSocks"
        Me.chkSocks.Size = New System.Drawing.Size(97, 36)
        Me.chkSocks.TabIndex = 6
        Me.chkSocks.Text = "Socks"
        Me.chkSocks.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbEight)
        Me.GroupBox2.Controls.Add(Me.rbFour)
        Me.GroupBox2.Controls.Add(Me.rbTwo)
        Me.GroupBox2.Controls.Add(Me.rbOne)
        Me.GroupBox2.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(628, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 264)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quantity"
        '
        'rbEight
        '
        Me.rbEight.AutoSize = True
        Me.rbEight.Location = New System.Drawing.Point(60, 199)
        Me.rbEight.Name = "rbEight"
        Me.rbEight.Size = New System.Drawing.Size(47, 36)
        Me.rbEight.TabIndex = 13
        Me.rbEight.Text = "8"
        Me.rbEight.UseVisualStyleBackColor = True
        '
        'rbFour
        '
        Me.rbFour.AutoSize = True
        Me.rbFour.Location = New System.Drawing.Point(60, 155)
        Me.rbFour.Name = "rbFour"
        Me.rbFour.Size = New System.Drawing.Size(47, 36)
        Me.rbFour.TabIndex = 12
        Me.rbFour.Text = "4"
        Me.rbFour.UseVisualStyleBackColor = True
        '
        'rbTwo
        '
        Me.rbTwo.AutoSize = True
        Me.rbTwo.Location = New System.Drawing.Point(60, 108)
        Me.rbTwo.Name = "rbTwo"
        Me.rbTwo.Size = New System.Drawing.Size(47, 36)
        Me.rbTwo.TabIndex = 11
        Me.rbTwo.Text = "2"
        Me.rbTwo.UseVisualStyleBackColor = True
        '
        'rbOne
        '
        Me.rbOne.AutoSize = True
        Me.rbOne.Location = New System.Drawing.Point(60, 56)
        Me.rbOne.Name = "rbOne"
        Me.rbOne.Size = New System.Drawing.Size(47, 36)
        Me.rbOne.TabIndex = 10
        Me.rbOne.Text = "1"
        Me.rbOne.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brands"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(558, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inventory Ordering System"
        '
        'lstBrand
        '
        Me.lstBrand.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lstBrand.FormattingEnabled = True
        Me.lstBrand.ItemHeight = 32
        Me.lstBrand.Location = New System.Drawing.Point(85, 156)
        Me.lstBrand.Name = "lstBrand"
        Me.lstBrand.Size = New System.Drawing.Size(195, 228)
        Me.lstBrand.TabIndex = 4
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.Location = New System.Drawing.Point(363, 387)
        Me.lblPrice.Multiline = True
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(167, 41)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 513)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lstBrand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Ordering System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFullSet As System.Windows.Forms.CheckBox
    Friend WithEvents chkShoes As System.Windows.Forms.CheckBox
    Friend WithEvents chkSupp As System.Windows.Forms.CheckBox
    Friend WithEvents chkSocks As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEight As System.Windows.Forms.CheckBox
    Friend WithEvents rbFour As System.Windows.Forms.CheckBox
    Friend WithEvents rbTwo As System.Windows.Forms.CheckBox
    Friend WithEvents rbOne As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstBrand As System.Windows.Forms.ListBox
    Friend WithEvents lblPrice As System.Windows.Forms.TextBox

End Class
