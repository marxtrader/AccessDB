<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lab_1_Garden_NaturallyDataSet = New AccessDB.Lab_1_Garden_NaturallyDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New AccessDB.Lab_1_Garden_NaturallyDataSetTableAdapters.CustomerTableAdapter()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGetRecord = New System.Windows.Forms.Button()
        Me.lblAddOne = New System.Windows.Forms.Label()
        Me.lblAddTwo = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.lblBalanceDue = New System.Windows.Forms.Label()
        Me.lblSalesRep = New System.Windows.Forms.Label()
        Me.txtAddyOne = New System.Windows.Forms.TextBox()
        Me.txtAddyTwo = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.txtAmtPaid = New System.Windows.Forms.TextBox()
        Me.txtBalanceDue = New System.Windows.Forms.TextBox()
        Me.txtSalesRep = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboBoxSearchTerm = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lab_1_Garden_NaturallyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.Lab_1_Garden_NaturallyDataSet
        Me.BindingSource1.Position = 0
        '
        'Lab_1_Garden_NaturallyDataSet
        '
        Me.Lab_1_Garden_NaturallyDataSet.DataSetName = "Lab_1_Garden_NaturallyDataSet"
        Me.Lab_1_Garden_NaturallyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.BindingSource1
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(85, 144)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(31, 25)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "ID"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(152, 141)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(308, 30)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = "ID"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(152, 188)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(308, 30)
        Me.txtFullName.TabIndex = 4
        Me.txtFullName.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Full Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnGetRecord
        '
        Me.btnGetRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetRecord.Location = New System.Drawing.Point(729, 55)
        Me.btnGetRecord.Name = "btnGetRecord"
        Me.btnGetRecord.Size = New System.Drawing.Size(108, 36)
        Me.btnGetRecord.TabIndex = 5
        Me.btnGetRecord.Text = "Clear"
        Me.btnGetRecord.UseVisualStyleBackColor = True
        '
        'lblAddOne
        '
        Me.lblAddOne.AutoSize = True
        Me.lblAddOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddOne.Location = New System.Drawing.Point(46, 238)
        Me.lblAddOne.Name = "lblAddOne"
        Me.lblAddOne.Size = New System.Drawing.Size(85, 25)
        Me.lblAddOne.TabIndex = 6
        Me.lblAddOne.Text = "Address"
        Me.lblAddOne.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAddTwo
        '
        Me.lblAddTwo.AutoSize = True
        Me.lblAddTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddTwo.Location = New System.Drawing.Point(46, 285)
        Me.lblAddTwo.Name = "lblAddTwo"
        Me.lblAddTwo.Size = New System.Drawing.Size(85, 25)
        Me.lblAddTwo.TabIndex = 7
        Me.lblAddTwo.Text = "Address"
        Me.lblAddTwo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(554, 141)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(46, 25)
        Me.lblCity.TabIndex = 8
        Me.lblCity.Text = "City"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(544, 188)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(58, 25)
        Me.lblState.TabIndex = 9
        Me.lblState.Text = "State"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(501, 235)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(119, 25)
        Me.lblPostalCode.TabIndex = 10
        Me.lblPostalCode.Text = "Postal Code"
        Me.lblPostalCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.Location = New System.Drawing.Point(11, 351)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(124, 25)
        Me.lblAmountPaid.TabIndex = 11
        Me.lblAmountPaid.Text = "Amount Paid"
        Me.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBalanceDue
        '
        Me.lblBalanceDue.AutoSize = True
        Me.lblBalanceDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceDue.Location = New System.Drawing.Point(22, 402)
        Me.lblBalanceDue.Name = "lblBalanceDue"
        Me.lblBalanceDue.Size = New System.Drawing.Size(113, 25)
        Me.lblBalanceDue.TabIndex = 12
        Me.lblBalanceDue.Text = "Balace Due"
        Me.lblBalanceDue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSalesRep
        '
        Me.lblSalesRep.AutoSize = True
        Me.lblSalesRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesRep.Location = New System.Drawing.Point(495, 287)
        Me.lblSalesRep.Name = "lblSalesRep"
        Me.lblSalesRep.Size = New System.Drawing.Size(107, 25)
        Me.lblSalesRep.TabIndex = 13
        Me.lblSalesRep.Text = "Sales Rep."
        Me.lblSalesRep.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAddyOne
        '
        Me.txtAddyOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddyOne.Location = New System.Drawing.Point(152, 235)
        Me.txtAddyOne.Name = "txtAddyOne"
        Me.txtAddyOne.Size = New System.Drawing.Size(308, 30)
        Me.txtAddyOne.TabIndex = 14
        Me.txtAddyOne.Text = "AddressOne"
        '
        'txtAddyTwo
        '
        Me.txtAddyTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddyTwo.Location = New System.Drawing.Point(152, 282)
        Me.txtAddyTwo.Name = "txtAddyTwo"
        Me.txtAddyTwo.Size = New System.Drawing.Size(308, 30)
        Me.txtAddyTwo.TabIndex = 15
        Me.txtAddyTwo.Text = "Address Two"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(631, 138)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(207, 30)
        Me.txtCity.TabIndex = 16
        Me.txtCity.Text = "City"
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(631, 185)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(207, 30)
        Me.txtState.TabIndex = 17
        Me.txtState.Text = "State"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(631, 232)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(207, 30)
        Me.txtPostalCode.TabIndex = 18
        Me.txtPostalCode.Text = "Postal Code"
        '
        'txtAmtPaid
        '
        Me.txtAmtPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtPaid.Location = New System.Drawing.Point(152, 348)
        Me.txtAmtPaid.Name = "txtAmtPaid"
        Me.txtAmtPaid.Size = New System.Drawing.Size(207, 30)
        Me.txtAmtPaid.TabIndex = 19
        Me.txtAmtPaid.Text = "AmountPaid"
        '
        'txtBalanceDue
        '
        Me.txtBalanceDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceDue.Location = New System.Drawing.Point(149, 399)
        Me.txtBalanceDue.Name = "txtBalanceDue"
        Me.txtBalanceDue.Size = New System.Drawing.Size(207, 30)
        Me.txtBalanceDue.TabIndex = 20
        Me.txtBalanceDue.Text = "BalanceDue"
        '
        'txtSalesRep
        '
        Me.txtSalesRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesRep.Location = New System.Drawing.Point(630, 284)
        Me.txtSalesRep.Name = "txtSalesRep"
        Me.txtSalesRep.Size = New System.Drawing.Size(207, 30)
        Me.txtSalesRep.TabIndex = 21
        Me.txtSalesRep.Text = "SalesRep"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(41, 61)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(75, 25)
        Me.lblSearch.TabIndex = 22
        Me.lblSearch.Text = "Search"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.BindingSource1
        '
        'cboBoxSearchTerm
        '
        Me.cboBoxSearchTerm.DataSource = Me.CustomerBindingSource2
        Me.cboBoxSearchTerm.DisplayMember = "Customer Name"
        Me.cboBoxSearchTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBoxSearchTerm.FormattingEnabled = True
        Me.cboBoxSearchTerm.Location = New System.Drawing.Point(139, 58)
        Me.cboBoxSearchTerm.Name = "cboBoxSearchTerm"
        Me.cboBoxSearchTerm.Size = New System.Drawing.Size(397, 33)
        Me.cboBoxSearchTerm.TabIndex = 24
        '
        'CustomerBindingSource2
        '
        Me.CustomerBindingSource2.DataMember = "Customer"
        Me.CustomerBindingSource2.DataSource = Me.BindingSource1
        '
        'frmAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 506)
        Me.Controls.Add(Me.cboBoxSearchTerm)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSalesRep)
        Me.Controls.Add(Me.txtBalanceDue)
        Me.Controls.Add(Me.txtAmtPaid)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddyTwo)
        Me.Controls.Add(Me.txtAddyOne)
        Me.Controls.Add(Me.lblSalesRep)
        Me.Controls.Add(Me.lblBalanceDue)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.lblPostalCode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddTwo)
        Me.Controls.Add(Me.lblAddOne)
        Me.Controls.Add(Me.btnGetRecord)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmAccess"
        Me.Text = "Access Database Viewer"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lab_1_Garden_NaturallyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Lab_1_Garden_NaturallyDataSet As Lab_1_Garden_NaturallyDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As Lab_1_Garden_NaturallyDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGetRecord As Button
    Friend WithEvents lblAddOne As Label
    Friend WithEvents lblAddTwo As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents lblBalanceDue As Label
    Friend WithEvents lblSalesRep As Label
    Friend WithEvents txtAddyOne As TextBox
    Friend WithEvents txtAddyTwo As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents txtAmtPaid As TextBox
    Friend WithEvents txtBalanceDue As TextBox
    Friend WithEvents txtSalesRep As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents cboBoxSearchTerm As ComboBox
    Friend WithEvents CustomerBindingSource2 As BindingSource
End Class
