
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmAccess

    Dim con As New OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lab_1_Garden_NaturallyDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Lab_1_Garden_NaturallyDataSet.Customer)

        txtName.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(0)
        txtFullName.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(1)
        txtAddyOne.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(2)
        txtCity.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(3)
        txtState.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(4)
        txtPostalCode.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(5)
        txtAmtPaid.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(6)
        txtBalanceDue.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(7)
        txtSalesRep.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(0).Item(8)
    End Sub

    Private Sub cboBoxSearchTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBoxSearchTerm.SelectedIndexChanged

        Dim count As Integer = 0

        'Me.CustomerTableAdapter.Fill(Me.Lab_1_Garden_NaturallyDataSet.Customer)
        For Each row In Me.Lab_1_Garden_NaturallyDataSet.Customer
            If cboBoxSearchTerm.Text = Me.Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(1) Then

                txtName.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(0)
                txtFullName.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(1)
                txtAddyOne.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(2)
                txtCity.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(3)
                txtState.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(4)
                txtPostalCode.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(5)
                txtAmtPaid.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(6)
                txtBalanceDue.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(7)
                txtSalesRep.Text = Lab_1_Garden_NaturallyDataSet.Customer.Rows(count).Item(8)

            Else
                count += 1
            End If
        Next


    End Sub

    Private Sub btnGetRecord_Click(sender As Object, e As EventArgs) Handles btnGetRecord.Click
        txtName.Text = ""
        txtFullName.Text = ""
        txtAddyOne.Text = ""
        txtAddyTwo.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtPostalCode.Text = ""
        txtAmtPaid.Text = ""
        txtBalanceDue.Text = ""
        txtSalesRep.Text = ""

    End Sub
End Class
