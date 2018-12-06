Public Class frmPreferences
    Sub SaveRecord()
        btnEdit.Visible = True
        btnSave.Visible = False

        ExecuteSQLStatement("UPDATE tpayrollpref SET " &
                                "Name='" & Trim(t1.Text) & "'," &
                                "Address='" & Trim(t2.Text) & "'," &
                                "Campus='" & Trim(t3.Text) & "'," &
                                "TelephoneNo='" & Trim(t4.Text) & "'," &
                                "CellphoneNo='" & Trim(t5.Text) & "'," &
                                "FaxNo='" & Trim(t6.Text) & "'," &
                                "EmailAddress='" & Trim(t7.Text) & "'," &
                                "CEO='" & Trim(t8.Text) & "'," &
                                "Accountant='" & Trim(t9.Text) & "'," &
                                "Cashier='" & Trim(t10.Text) & "'," &
                                "CertFundsAvailable='" & Trim(t11.Text) & "'," &
                                "CertifiedCorrect='" & Trim(t12.Text) & "'," &
                                "ApprovedForAppro='" & Trim(t13.Text) & "'," &
                                "CertifiedPayment='" & Trim(t14.Text) & "'," &
                                "WitnessedPayment='" & Trim(t15.Text) & "'", dgv)
        mdiMainForm.btnPreferences.Enabled = True
        Me.Dispose()
    End Sub

    Sub LoadPreferences()
        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgv)

        t1.Text = dgv.CurrentRow.Cells(1).Value
        t2.Text = dgv.CurrentRow.Cells(2).Value
        t3.Text = dgv.CurrentRow.Cells(3).Value
        t4.Text = dgv.CurrentRow.Cells(4).Value
        t5.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(5).Value), "", dgv.CurrentRow.Cells(5).Value)
        t6.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(6).Value), "", dgv.CurrentRow.Cells(6).Value)
        t7.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(7).Value), "", dgv.CurrentRow.Cells(7).Value)
        t8.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(8).Value), "", dgv.CurrentRow.Cells(8).Value)
        t9.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(9).Value), "", dgv.CurrentRow.Cells(9).Value)
        t10.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(10).Value), "", dgv.CurrentRow.Cells(10).Value)
        t11.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(11).Value), "", dgv.CurrentRow.Cells(11).Value)
        t12.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(12).Value), "", dgv.CurrentRow.Cells(12).Value)
        t13.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(13).Value), "", dgv.CurrentRow.Cells(13).Value)
        t14.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(14).Value), "", dgv.CurrentRow.Cells(14).Value)
        t15.Text = IIf(IsDBNull(dgv.CurrentRow.Cells(15).Value), "", dgv.CurrentRow.Cells(15).Value)

        btnSave.Visible = False
        btnEdit.Visible = True
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveRecord()
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        mdiMainForm.btnPreferences.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub tSchoolName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
    t1.KeyPress, t3.KeyPress, t8.KeyPress, t9.KeyPress, t10.KeyPress, t11.KeyPress, t12.KeyPress, t13.KeyPress, t14.KeyPress, t15.KeyPress
        e.KeyChar = ChrW(Asc(UCase(Chr(AscW(e.KeyChar)))))
    End Sub

    Private Sub frmPreferences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPreferences()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        panPreferences.Enabled = True
        btnEdit.Visible = False
        btnSave.Visible = True
        t1.SelectAll()
        t1.Focus()
    End Sub

    Private Sub t8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t8.TextChanged

    End Sub
End Class