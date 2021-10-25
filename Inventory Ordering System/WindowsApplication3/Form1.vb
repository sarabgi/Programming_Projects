Public Class Form1
    Dim Nike_Price As Double = 150
    Dim Drose_Price As Double = 200
    Dim Kyrie_Price As Double = 250
    Dim UnderArmor_Price As Double = 300
    Dim Lebron_Price As Double = 350

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Close application") <> MsgBoxResult.Yes Then
            e.Cancel = True
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBrand.Items.Add("Nike")
        lstBrand.Items.Add("Drose")
        lstBrand.Items.Add("Kyrie")
        lstBrand.Items.Add("UnderArmor")
        lstBrand.Items.Add("Lebron")
        lstBrand.ClearSelected()

        chkSocks.Checked = False
        chkSupp.Checked = False
        chkShoes.Checked = False
        chkFullSet.Checked = False

        rbOne.Checked = False
        rbTwo.Checked = False
        rbFour.Checked = False
        rbEight.Checked = False

        MsgBox("Welcome to Inventory Ordering System", MsgBoxStyle.OkCancel, "Inventory Ordering System")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lstBrand.ClearSelected()

        chkSupp.Checked = False
        chkSocks.Checked = False
        chkShoes.Checked = False
        chkFullSet.Checked = False

        rbOne.Checked = False
        rbTwo.Checked = False
        rbFour.Checked = False
        rbEight.Checked = False
        Me.lblPrice.Text = ""
    End Sub

    Private Sub chkFullSet_CheckedChanged(sender As Object, e As EventArgs) Handles chkFullSet.CheckedChanged
        If chkFullSet.Checked = True Then
            chkSupp.Checked = True
            chkSocks.Checked = True
            chkShoes.Checked = True
        Else
            chkSupp.Checked = False
            chkSocks.Checked = False
            chkShoes.Checked = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim quitsystem As DialogResult
        quitsystem = MessageBox.Show("Do you want to quit", "System off", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If quitsystem = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If lstBrand.Text = "Nike" And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 1)
        ElseIf lstBrand.Text = "Nike" And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 2)
        ElseIf lstBrand.Text = "Nike" And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 4)
        ElseIf lstBrand.Text = "Nike" And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 8)
        End If
        '--------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Nike" And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 11)
        ElseIf lstBrand.Text = "Nike" And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 22)
        ElseIf lstBrand.Text = "Nike" And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 44)
        ElseIf lstBrand.Text = "Nike" And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 88)
        End If
        '------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Nike" And chkSupp.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 3)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 10)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 15)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 20)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Nike" And chkSupp.Checked = True And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 52)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 62)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 62)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 92)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Nike" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 139)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 147)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 166)
        ElseIf lstBrand.Text = "Nike" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Nike_Price * 196)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Drose" And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 1)
        ElseIf lstBrand.Text = "Drose" And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 2)
        ElseIf lstBrand.Text = "Drose" And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 4)
        ElseIf lstBrand.Text = "Drose" And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 8)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Drose" And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 11)
        ElseIf lstBrand.Text = "Drose" And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 21)
        ElseIf lstBrand.Text = "Drose" And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 41)
        ElseIf lstBrand.Text = "Drose" And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 81)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Drose" And chkSupp.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 10)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 20)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 40)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 80)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Drose" And chkSupp.Checked = True And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 52)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 62)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 62)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 92)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Drose" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 139)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 147)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 166)
        ElseIf lstBrand.Text = "Drose" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Drose_Price * 196)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Kyrie" And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 1)
        ElseIf lstBrand.Text = "Kyrie" And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 2)
        ElseIf lstBrand.Text = "Kyrie" And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 4)
        ElseIf lstBrand.Text = "Kyrie" And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 8)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Kyrie" And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 11)
        ElseIf lstBrand.Text = "Kyrie" And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 21)
        ElseIf lstBrand.Text = "Kyrie" And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 41)
        ElseIf lstBrand.Text = "Kyrie" And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 81)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Kyrie" And chkSupp.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 10)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 20)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 40)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 80)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Kyrie" And chkSupp.Checked = True And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 52)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 62)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 62)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 92)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Kyrie" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 139)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 147)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 166)
        ElseIf lstBrand.Text = "Kyrie" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Kyrie_Price * 196)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "UnderArmor" And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 1)
        ElseIf lstBrand.Text = "UnderArmor" And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 2)
        ElseIf lstBrand.Text = "UnderArmor" And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 4)
        ElseIf lstBrand.Text = "UnderArmor" And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 8)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "UnderArmor" And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 11)
        ElseIf lstBrand.Text = "UnderArmor" And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 21)
        ElseIf lstBrand.Text = "UnderArmor" And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 41)
        ElseIf lstBrand.Text = "UnderArmor" And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 81)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 10)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 20)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 40)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 80)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 52)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 62)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 62)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 92)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 139)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 147)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 166)
        ElseIf lstBrand.Text = "UnderArmor" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(UnderArmor_Price * 196)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Lebron" And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 1)
        ElseIf lstBrand.Text = "Lebron" And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 2)
        ElseIf lstBrand.Text = "Lebron" And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 4)
        ElseIf lstBrand.Text = "Lebron" And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 8)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Lebron" And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 11)
        ElseIf lstBrand.Text = "Lebron" And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 21)
        ElseIf lstBrand.Text = "Lebron" And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 41)
        ElseIf lstBrand.Text = "Lebron" And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 81)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Lebron" And chkSupp.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 10)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 20)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 40)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 80)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Lebron" And chkSupp.Checked = True And chkShoes.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 52)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And chkShoes.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 62)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And chkShoes.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 62)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And chkShoes.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 92)
        End If
        '-------------------------------------------------------------------------------------------------------------------------
        If lstBrand.Text = "Lebron" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbOne.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 139)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbTwo.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 147)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbFour.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 166)
        ElseIf lstBrand.Text = "Lebron" And chkSupp.Checked = True And chkShoes.Checked = True And chkSocks.Checked = True And rbEight.Checked = True Then
            lblPrice.Text = Double.Parse(Lebron_Price * 196)
        End If
        '-------------------------------------------------------------------------------------------------------------------------


        If lstBrand.Text = "" Then
            MessageBox.Show("You must select a brand", "Brand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (chkSupp.Checked = False) And (chkSocks.Checked = False) And (chkShoes.Checked = False) Then
            MessageBox.Show("You must select an item", "Item", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        ElseIf (rbOne.Checked = False) And (rbTwo.Checked = False) And (rbFour.Checked = False) And (rbEight.Checked = False) Then
            MessageBox.Show("You must select a quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            lblPrice.Text = FormatCurrency(lblPrice.Text)
        End If
    End Sub
End Class
