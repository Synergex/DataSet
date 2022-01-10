'Project:      xfODBC_V2
'Programmer:   Blair Varley - Synergex (www.synergex.com)
'Date:         February 2004
'Description:  Browse, Add, Delete, and Edit the "customer" table from 
'              xfODBC sample database using DataSet object from ADO.NET.

Option Strict On

Public Class frmMain
    Inherits System.Windows.Forms.Form
    Dim mblnListsInitialized As Boolean = False
    Dim bmcustomers As BindingManagerBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblCUST_KEY As System.Windows.Forms.Label
    Friend WithEvents lblCUST_RTYPE As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCUST_STREET As System.Windows.Forms.Label
    Friend WithEvents lblCUST_CITY As System.Windows.Forms.Label
    Friend WithEvents lblCUST_STATE As System.Windows.Forms.Label
    Friend WithEvents lblCUST_ZIP As System.Windows.Forms.Label
    Friend WithEvents lblCUST_CONTACT As System.Windows.Forms.Label
    Friend WithEvents lblCUST_PHONE As System.Windows.Forms.Label
    Friend WithEvents lblCUST_FAX As System.Windows.Forms.Label
    Friend WithEvents lblCUST_GIFT As System.Windows.Forms.Label
    Friend WithEvents lblCUST_TCODE As System.Windows.Forms.Label
    Friend WithEvents lblCUST_TAXNO As System.Windows.Forms.Label
    Friend WithEvents lblCUST_LIMIT As System.Windows.Forms.Label
    Friend WithEvents sbpRecordPosition As System.Windows.Forms.TextBox
    Friend WithEvents cmdFirstRecord As System.Windows.Forms.Button
    Friend WithEvents cmdNextRecord As System.Windows.Forms.Button
    Friend WithEvents cmdPreviousButton As System.Windows.Forms.Button
    Friend WithEvents cmdLastRecord As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtCUST_KEY As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_RTYPE As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_NAME As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_STREET As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_CITY As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_STATE As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_ZIP As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_CONTACT As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_PHONE As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_FAX As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_GIFT As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_TCODE As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_TAXNO As System.Windows.Forms.TextBox
    Friend WithEvents txtCUST_LIMIT As System.Windows.Forms.TextBox
    Friend WithEvents OdbcDataAdapter1 As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents OdbcInsertCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents OdbcUpdateCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents OdbcDeleteCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Friend WithEvents NewDataSet1 As xfODBC_V2.NewDataSet
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblCUST_KEY = New System.Windows.Forms.Label
        Me.lblCUST_RTYPE = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCUST_STREET = New System.Windows.Forms.Label
        Me.lblCUST_CITY = New System.Windows.Forms.Label
        Me.lblCUST_STATE = New System.Windows.Forms.Label
        Me.lblCUST_ZIP = New System.Windows.Forms.Label
        Me.lblCUST_CONTACT = New System.Windows.Forms.Label
        Me.lblCUST_PHONE = New System.Windows.Forms.Label
        Me.lblCUST_FAX = New System.Windows.Forms.Label
        Me.lblCUST_GIFT = New System.Windows.Forms.Label
        Me.lblCUST_TCODE = New System.Windows.Forms.Label
        Me.lblCUST_TAXNO = New System.Windows.Forms.Label
        Me.lblCUST_LIMIT = New System.Windows.Forms.Label
        Me.sbpRecordPosition = New System.Windows.Forms.TextBox
        Me.cmdFirstRecord = New System.Windows.Forms.Button
        Me.cmdNextRecord = New System.Windows.Forms.Button
        Me.cmdPreviousButton = New System.Windows.Forms.Button
        Me.cmdLastRecord = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtCUST_KEY = New System.Windows.Forms.TextBox
        Me.txtCUST_RTYPE = New System.Windows.Forms.TextBox
        Me.txtCUST_NAME = New System.Windows.Forms.TextBox
        Me.txtCUST_STREET = New System.Windows.Forms.TextBox
        Me.txtCUST_CITY = New System.Windows.Forms.TextBox
        Me.txtCUST_STATE = New System.Windows.Forms.TextBox
        Me.txtCUST_ZIP = New System.Windows.Forms.TextBox
        Me.txtCUST_CONTACT = New System.Windows.Forms.TextBox
        Me.txtCUST_PHONE = New System.Windows.Forms.TextBox
        Me.txtCUST_FAX = New System.Windows.Forms.TextBox
        Me.txtCUST_GIFT = New System.Windows.Forms.TextBox
        Me.txtCUST_TCODE = New System.Windows.Forms.TextBox
        Me.txtCUST_TAXNO = New System.Windows.Forms.TextBox
        Me.txtCUST_LIMIT = New System.Windows.Forms.TextBox
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcInsertCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcUpdateCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcDeleteCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.NewDataSet1 = New xfODBC_V2.NewDataSet
        CType(Me.NewDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCUST_KEY
        '
        Me.lblCUST_KEY.Location = New System.Drawing.Point(8, 16)
        Me.lblCUST_KEY.Name = "lblCUST_KEY"
        Me.lblCUST_KEY.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_KEY.TabIndex = 107
        Me.lblCUST_KEY.Text = "CUST_KEY"
        '
        'lblCUST_RTYPE
        '
        Me.lblCUST_RTYPE.Location = New System.Drawing.Point(8, 40)
        Me.lblCUST_RTYPE.Name = "lblCUST_RTYPE"
        Me.lblCUST_RTYPE.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_RTYPE.TabIndex = 108
        Me.lblCUST_RTYPE.Text = "CUST_RTYPE"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "CUST_NAME"
        '
        'lblCUST_STREET
        '
        Me.lblCUST_STREET.Location = New System.Drawing.Point(8, 88)
        Me.lblCUST_STREET.Name = "lblCUST_STREET"
        Me.lblCUST_STREET.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_STREET.TabIndex = 111
        Me.lblCUST_STREET.Text = "CUST_STREET"
        '
        'lblCUST_CITY
        '
        Me.lblCUST_CITY.Location = New System.Drawing.Point(8, 112)
        Me.lblCUST_CITY.Name = "lblCUST_CITY"
        Me.lblCUST_CITY.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_CITY.TabIndex = 112
        Me.lblCUST_CITY.Text = "CUST_CITY"
        '
        'lblCUST_STATE
        '
        Me.lblCUST_STATE.Location = New System.Drawing.Point(8, 136)
        Me.lblCUST_STATE.Name = "lblCUST_STATE"
        Me.lblCUST_STATE.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_STATE.TabIndex = 113
        Me.lblCUST_STATE.Text = "CUST_STATE"
        '
        'lblCUST_ZIP
        '
        Me.lblCUST_ZIP.Location = New System.Drawing.Point(8, 160)
        Me.lblCUST_ZIP.Name = "lblCUST_ZIP"
        Me.lblCUST_ZIP.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_ZIP.TabIndex = 114
        Me.lblCUST_ZIP.Text = "CUST_ZIP"
        '
        'lblCUST_CONTACT
        '
        Me.lblCUST_CONTACT.Location = New System.Drawing.Point(8, 184)
        Me.lblCUST_CONTACT.Name = "lblCUST_CONTACT"
        Me.lblCUST_CONTACT.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_CONTACT.TabIndex = 115
        Me.lblCUST_CONTACT.Text = "CUST_CONTACT"
        '
        'lblCUST_PHONE
        '
        Me.lblCUST_PHONE.Location = New System.Drawing.Point(8, 208)
        Me.lblCUST_PHONE.Name = "lblCUST_PHONE"
        Me.lblCUST_PHONE.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_PHONE.TabIndex = 116
        Me.lblCUST_PHONE.Text = "CUST_PHONE"
        '
        'lblCUST_FAX
        '
        Me.lblCUST_FAX.Location = New System.Drawing.Point(8, 232)
        Me.lblCUST_FAX.Name = "lblCUST_FAX"
        Me.lblCUST_FAX.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_FAX.TabIndex = 117
        Me.lblCUST_FAX.Text = "CUST_FAX"
        '
        'lblCUST_GIFT
        '
        Me.lblCUST_GIFT.Location = New System.Drawing.Point(8, 256)
        Me.lblCUST_GIFT.Name = "lblCUST_GIFT"
        Me.lblCUST_GIFT.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_GIFT.TabIndex = 118
        Me.lblCUST_GIFT.Text = "CUST_GIFT"
        '
        'lblCUST_TCODE
        '
        Me.lblCUST_TCODE.Location = New System.Drawing.Point(8, 280)
        Me.lblCUST_TCODE.Name = "lblCUST_TCODE"
        Me.lblCUST_TCODE.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_TCODE.TabIndex = 119
        Me.lblCUST_TCODE.Text = "CUST_TCODE"
        '
        'lblCUST_TAXNO
        '
        Me.lblCUST_TAXNO.Location = New System.Drawing.Point(8, 304)
        Me.lblCUST_TAXNO.Name = "lblCUST_TAXNO"
        Me.lblCUST_TAXNO.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_TAXNO.TabIndex = 120
        Me.lblCUST_TAXNO.Text = "CUST_TAXNO"
        '
        'lblCUST_LIMIT
        '
        Me.lblCUST_LIMIT.Location = New System.Drawing.Point(8, 328)
        Me.lblCUST_LIMIT.Name = "lblCUST_LIMIT"
        Me.lblCUST_LIMIT.Size = New System.Drawing.Size(136, 16)
        Me.lblCUST_LIMIT.TabIndex = 121
        Me.lblCUST_LIMIT.Text = "CUST_LIMIT"
        '
        'sbpRecordPosition
        '
        Me.sbpRecordPosition.Location = New System.Drawing.Point(8, 384)
        Me.sbpRecordPosition.Name = "sbpRecordPosition"
        Me.sbpRecordPosition.Size = New System.Drawing.Size(144, 20)
        Me.sbpRecordPosition.TabIndex = 143
        Me.sbpRecordPosition.Text = ""
        '
        'cmdFirstRecord
        '
        Me.cmdFirstRecord.Location = New System.Drawing.Point(544, 16)
        Me.cmdFirstRecord.Name = "cmdFirstRecord"
        Me.cmdFirstRecord.Size = New System.Drawing.Size(104, 24)
        Me.cmdFirstRecord.TabIndex = 144
        Me.cmdFirstRecord.Text = "&First Record"
        '
        'cmdNextRecord
        '
        Me.cmdNextRecord.Location = New System.Drawing.Point(544, 48)
        Me.cmdNextRecord.Name = "cmdNextRecord"
        Me.cmdNextRecord.Size = New System.Drawing.Size(104, 24)
        Me.cmdNextRecord.TabIndex = 145
        Me.cmdNextRecord.Text = "&Next Record"
        '
        'cmdPreviousButton
        '
        Me.cmdPreviousButton.Location = New System.Drawing.Point(544, 80)
        Me.cmdPreviousButton.Name = "cmdPreviousButton"
        Me.cmdPreviousButton.Size = New System.Drawing.Size(104, 24)
        Me.cmdPreviousButton.TabIndex = 146
        Me.cmdPreviousButton.Text = "&Previous Record"
        '
        'cmdLastRecord
        '
        Me.cmdLastRecord.Location = New System.Drawing.Point(544, 112)
        Me.cmdLastRecord.Name = "cmdLastRecord"
        Me.cmdLastRecord.Size = New System.Drawing.Size(104, 24)
        Me.cmdLastRecord.TabIndex = 147
        Me.cmdLastRecord.Text = "&Last Record"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(544, 160)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(104, 24)
        Me.cmdAdd.TabIndex = 148
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(544, 192)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(104, 24)
        Me.cmdDelete.TabIndex = 149
        Me.cmdDelete.Text = "&Delete"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(544, 224)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(104, 24)
        Me.cmdEdit.TabIndex = 150
        Me.cmdEdit.Text = "&Edit"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(544, 256)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(104, 24)
        Me.cmdSave.TabIndex = 151
        Me.cmdSave.Text = "&Save"
        '
        'txtCUST_KEY
        '
        Me.txtCUST_KEY.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_KEY"))
        Me.txtCUST_KEY.Location = New System.Drawing.Point(152, 8)
        Me.txtCUST_KEY.Name = "txtCUST_KEY"
        Me.txtCUST_KEY.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_KEY.TabIndex = 152
        Me.txtCUST_KEY.Text = ""
        '
        'txtCUST_RTYPE
        '
        Me.txtCUST_RTYPE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_RTYPE"))
        Me.txtCUST_RTYPE.Location = New System.Drawing.Point(152, 32)
        Me.txtCUST_RTYPE.Name = "txtCUST_RTYPE"
        Me.txtCUST_RTYPE.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_RTYPE.TabIndex = 153
        Me.txtCUST_RTYPE.Text = ""
        '
        'txtCUST_NAME
        '
        Me.txtCUST_NAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_NAME"))
        Me.txtCUST_NAME.Location = New System.Drawing.Point(152, 56)
        Me.txtCUST_NAME.Name = "txtCUST_NAME"
        Me.txtCUST_NAME.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_NAME.TabIndex = 154
        Me.txtCUST_NAME.Text = ""
        '
        'txtCUST_STREET
        '
        Me.txtCUST_STREET.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_STREET"))
        Me.txtCUST_STREET.Location = New System.Drawing.Point(152, 80)
        Me.txtCUST_STREET.Name = "txtCUST_STREET"
        Me.txtCUST_STREET.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_STREET.TabIndex = 155
        Me.txtCUST_STREET.Text = ""
        '
        'txtCUST_CITY
        '
        Me.txtCUST_CITY.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_CITY"))
        Me.txtCUST_CITY.Location = New System.Drawing.Point(152, 104)
        Me.txtCUST_CITY.Name = "txtCUST_CITY"
        Me.txtCUST_CITY.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_CITY.TabIndex = 156
        Me.txtCUST_CITY.Text = ""
        '
        'txtCUST_STATE
        '
        Me.txtCUST_STATE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_STATE"))
        Me.txtCUST_STATE.Location = New System.Drawing.Point(152, 128)
        Me.txtCUST_STATE.Name = "txtCUST_STATE"
        Me.txtCUST_STATE.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_STATE.TabIndex = 157
        Me.txtCUST_STATE.Text = ""
        '
        'txtCUST_ZIP
        '
        Me.txtCUST_ZIP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_ZIP"))
        Me.txtCUST_ZIP.Location = New System.Drawing.Point(152, 152)
        Me.txtCUST_ZIP.Name = "txtCUST_ZIP"
        Me.txtCUST_ZIP.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_ZIP.TabIndex = 158
        Me.txtCUST_ZIP.Text = ""
        '
        'txtCUST_CONTACT
        '
        Me.txtCUST_CONTACT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_CONTACT"))
        Me.txtCUST_CONTACT.Location = New System.Drawing.Point(152, 176)
        Me.txtCUST_CONTACT.Name = "txtCUST_CONTACT"
        Me.txtCUST_CONTACT.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_CONTACT.TabIndex = 159
        Me.txtCUST_CONTACT.Text = ""
        '
        'txtCUST_PHONE
        '
        Me.txtCUST_PHONE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_PHONE"))
        Me.txtCUST_PHONE.Location = New System.Drawing.Point(152, 200)
        Me.txtCUST_PHONE.Name = "txtCUST_PHONE"
        Me.txtCUST_PHONE.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_PHONE.TabIndex = 160
        Me.txtCUST_PHONE.Text = ""
        '
        'txtCUST_FAX
        '
        Me.txtCUST_FAX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_FAX"))
        Me.txtCUST_FAX.Location = New System.Drawing.Point(152, 224)
        Me.txtCUST_FAX.Name = "txtCUST_FAX"
        Me.txtCUST_FAX.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_FAX.TabIndex = 161
        Me.txtCUST_FAX.Text = ""
        '
        'txtCUST_GIFT
        '
        Me.txtCUST_GIFT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_GIFT"))
        Me.txtCUST_GIFT.Location = New System.Drawing.Point(152, 248)
        Me.txtCUST_GIFT.Name = "txtCUST_GIFT"
        Me.txtCUST_GIFT.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_GIFT.TabIndex = 162
        Me.txtCUST_GIFT.Text = ""
        '
        'txtCUST_TCODE
        '
        Me.txtCUST_TCODE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_TCODE"))
        Me.txtCUST_TCODE.Location = New System.Drawing.Point(152, 272)
        Me.txtCUST_TCODE.Name = "txtCUST_TCODE"
        Me.txtCUST_TCODE.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_TCODE.TabIndex = 163
        Me.txtCUST_TCODE.Text = ""
        '
        'txtCUST_TAXNO
        '
        Me.txtCUST_TAXNO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_TAXNO"))
        Me.txtCUST_TAXNO.Location = New System.Drawing.Point(152, 296)
        Me.txtCUST_TAXNO.Name = "txtCUST_TAXNO"
        Me.txtCUST_TAXNO.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_TAXNO.TabIndex = 164
        Me.txtCUST_TAXNO.Text = ""
        '
        'txtCUST_LIMIT
        '
        Me.txtCUST_LIMIT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NewDataSet1, "CUSTOMERS.CUST_LIMIT"))
        Me.txtCUST_LIMIT.Location = New System.Drawing.Point(152, 320)
        Me.txtCUST_LIMIT.Name = "txtCUST_LIMIT"
        Me.txtCUST_LIMIT.Size = New System.Drawing.Size(376, 20)
        Me.txtCUST_LIMIT.TabIndex = 165
        Me.txtCUST_LIMIT.Text = ""
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.DeleteCommand = Me.OdbcDeleteCommand1
        Me.OdbcDataAdapter1.InsertCommand = Me.OdbcInsertCommand1
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CUSTOMERS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CUST_KEY", "CUST_KEY"), New System.Data.Common.DataColumnMapping("CUST_RTYPE", "CUST_RTYPE"), New System.Data.Common.DataColumnMapping("CUST_NAME", "CUST_NAME"), New System.Data.Common.DataColumnMapping("CUST_STREET", "CUST_STREET"), New System.Data.Common.DataColumnMapping("CUST_CITY", "CUST_CITY"), New System.Data.Common.DataColumnMapping("CUST_STATE", "CUST_STATE"), New System.Data.Common.DataColumnMapping("CUST_ZIP", "CUST_ZIP"), New System.Data.Common.DataColumnMapping("CUST_CONTACT", "CUST_CONTACT"), New System.Data.Common.DataColumnMapping("CUST_PHONE", "CUST_PHONE"), New System.Data.Common.DataColumnMapping("CUST_FAX", "CUST_FAX"), New System.Data.Common.DataColumnMapping("CUST_GIFT", "CUST_GIFT"), New System.Data.Common.DataColumnMapping("CUST_TCODE", "CUST_TCODE"), New System.Data.Common.DataColumnMapping("CUST_TAXNO", "CUST_TAXNO"), New System.Data.Common.DataColumnMapping("CUST_LIMIT", "CUST_LIMIT")})})
        Me.OdbcDataAdapter1.UpdateCommand = Me.OdbcUpdateCommand1
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT CUST_KEY, CUST_RTYPE, CUST_NAME, CUST_STREET, CUST_CITY, CUST_STATE, CUST_" & _
        "ZIP, CUST_CONTACT, CUST_PHONE, CUST_FAX, CUST_GIFT, CUST_TCODE, CUST_TAXNO, CUST" & _
        "_LIMIT FROM ""PUBLIC"".CUSTOMERS"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcInsertCommand1
        '
        Me.OdbcInsertCommand1.CommandText = "INSERT INTO ""PUBLIC"".CUSTOMERS(CUST_KEY, CUST_RTYPE, CUST_NAME, CUST_STREET, CUST" & _
        "_CITY, CUST_STATE, CUST_ZIP, CUST_CONTACT, CUST_PHONE, CUST_FAX, CUST_GIFT, CUST" & _
        "_TCODE, CUST_TAXNO, CUST_LIMIT) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ")"
        Me.OdbcInsertCommand1.Connection = Me.OdbcConnection1
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_KEY", System.Data.Odbc.OdbcType.Int, 0, "CUST_KEY"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_RTYPE", System.Data.Odbc.OdbcType.SmallInt, 0, "CUST_RTYPE"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_NAME", System.Data.Odbc.OdbcType.VarChar, 30, "CUST_NAME"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_STREET", System.Data.Odbc.OdbcType.VarChar, 25, "CUST_STREET"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_CITY", System.Data.Odbc.OdbcType.VarChar, 20, "CUST_CITY"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_STATE", System.Data.Odbc.OdbcType.VarChar, 2, "CUST_STATE"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_ZIP", System.Data.Odbc.OdbcType.Int, 0, "CUST_ZIP"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_CONTACT", System.Data.Odbc.OdbcType.VarChar, 25, "CUST_CONTACT"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_PHONE", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_PHONE", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_FAX", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_FAX", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_GIFT", System.Data.Odbc.OdbcType.Int, 0, "CUST_GIFT"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_TCODE", System.Data.Odbc.OdbcType.VarChar, 2, "CUST_TCODE"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_TAXNO", System.Data.Odbc.OdbcType.Int, 0, "CUST_TAXNO"))
        Me.OdbcInsertCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_LIMIT", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(2, Byte), "CUST_LIMIT", System.Data.DataRowVersion.Current, Nothing))
        '
        'OdbcUpdateCommand1
        '
        Me.OdbcUpdateCommand1.CommandText = "UPDATE ""PUBLIC"".CUSTOMERS SET CUST_KEY = ?, CUST_RTYPE = ?, CUST_NAME = ?, CUST_S" & _
        "TREET = ?, CUST_CITY = ?, CUST_STATE = ?, CUST_ZIP = ?, CUST_CONTACT = ?, CUST_P" & _
        "HONE = ?, CUST_FAX = ?, CUST_GIFT = ?, CUST_TCODE = ?, CUST_TAXNO = ?, CUST_LIMI" & _
        "T = ? WHERE (CUST_KEY = ?) AND (CUST_CITY = ? OR ? IS NULL AND CUST_CITY IS NULL" & _
        ") AND (CUST_CONTACT = ? OR ? IS NULL AND CUST_CONTACT IS NULL) AND (CUST_FAX = ?" & _
        " OR ? IS NULL AND CUST_FAX IS NULL) AND (CUST_GIFT = ? OR ? IS NULL AND CUST_GIF" & _
        "T IS NULL) AND (CUST_LIMIT = ? OR ? IS NULL AND CUST_LIMIT IS NULL) AND (CUST_NA" & _
        "ME = ? OR ? IS NULL AND CUST_NAME IS NULL) AND (CUST_PHONE = ? OR ? IS NULL AND " & _
        "CUST_PHONE IS NULL) AND (CUST_RTYPE = ? OR ? IS NULL AND CUST_RTYPE IS NULL) AND" & _
        " (CUST_STATE = ? OR ? IS NULL AND CUST_STATE IS NULL) AND (CUST_STREET = ? OR ? " & _
        "IS NULL AND CUST_STREET IS NULL) AND (CUST_TAXNO = ? OR ? IS NULL AND CUST_TAXNO" & _
        " IS NULL) AND (CUST_TCODE = ? OR ? IS NULL AND CUST_TCODE IS NULL) AND (CUST_ZIP" & _
        " = ? OR ? IS NULL AND CUST_ZIP IS NULL)"
        Me.OdbcUpdateCommand1.Connection = Me.OdbcConnection1
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_KEY", System.Data.Odbc.OdbcType.Int, 0, "CUST_KEY"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_RTYPE", System.Data.Odbc.OdbcType.SmallInt, 0, "CUST_RTYPE"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_NAME", System.Data.Odbc.OdbcType.VarChar, 30, "CUST_NAME"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_STREET", System.Data.Odbc.OdbcType.VarChar, 25, "CUST_STREET"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_CITY", System.Data.Odbc.OdbcType.VarChar, 20, "CUST_CITY"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_STATE", System.Data.Odbc.OdbcType.VarChar, 2, "CUST_STATE"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_ZIP", System.Data.Odbc.OdbcType.Int, 0, "CUST_ZIP"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_CONTACT", System.Data.Odbc.OdbcType.VarChar, 25, "CUST_CONTACT"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_PHONE", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_PHONE", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_FAX", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_FAX", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_GIFT", System.Data.Odbc.OdbcType.Int, 0, "CUST_GIFT"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_TCODE", System.Data.Odbc.OdbcType.VarChar, 2, "CUST_TCODE"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_TAXNO", System.Data.Odbc.OdbcType.Int, 0, "CUST_TAXNO"))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("CUST_LIMIT", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(2, Byte), "CUST_LIMIT", System.Data.DataRowVersion.Current, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_KEY", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_KEY", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_CITY", System.Data.Odbc.OdbcType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_CITY", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_CITY1", System.Data.Odbc.OdbcType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_CITY", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_CONTACT", System.Data.Odbc.OdbcType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_CONTACT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_CONTACT1", System.Data.Odbc.OdbcType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_CONTACT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_FAX", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_FAX", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_FAX1", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_FAX", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_GIFT", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_GIFT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_GIFT1", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_GIFT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_LIMIT", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(2, Byte), "CUST_LIMIT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_LIMIT1", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(2, Byte), "CUST_LIMIT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_NAME", System.Data.Odbc.OdbcType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_NAME", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_NAME1", System.Data.Odbc.OdbcType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_NAME", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_PHONE", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_PHONE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_PHONE1", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_PHONE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_RTYPE", System.Data.Odbc.OdbcType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_RTYPE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_RTYPE1", System.Data.Odbc.OdbcType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_RTYPE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_STATE", System.Data.Odbc.OdbcType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_STATE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_STATE1", System.Data.Odbc.OdbcType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_STATE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_STREET", System.Data.Odbc.OdbcType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_STREET", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_STREET1", System.Data.Odbc.OdbcType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_STREET", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_TAXNO", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_TAXNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_TAXNO1", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_TAXNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_TCODE", System.Data.Odbc.OdbcType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_TCODE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_TCODE1", System.Data.Odbc.OdbcType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_TCODE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_ZIP", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_ZIP", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcUpdateCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_ZIP1", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_ZIP", System.Data.DataRowVersion.Original, Nothing))
        '
        'OdbcDeleteCommand1
        '
        Me.OdbcDeleteCommand1.CommandText = "DELETE FROM ""PUBLIC"".CUSTOMERS WHERE (CUST_KEY = ?) AND (CUST_CITY = ? OR ? IS NU" & _
        "LL AND CUST_CITY IS NULL) AND (CUST_CONTACT = ? OR ? IS NULL AND CUST_CONTACT IS" & _
        " NULL) AND (CUST_FAX = ? OR ? IS NULL AND CUST_FAX IS NULL) AND (CUST_GIFT = ? O" & _
        "R ? IS NULL AND CUST_GIFT IS NULL) AND (CUST_LIMIT = ? OR ? IS NULL AND CUST_LIM" & _
        "IT IS NULL) AND (CUST_NAME = ? OR ? IS NULL AND CUST_NAME IS NULL) AND (CUST_PHO" & _
        "NE = ? OR ? IS NULL AND CUST_PHONE IS NULL) AND (CUST_RTYPE = ? OR ? IS NULL AND" & _
        " CUST_RTYPE IS NULL) AND (CUST_STATE = ? OR ? IS NULL AND CUST_STATE IS NULL) AN" & _
        "D (CUST_STREET = ? OR ? IS NULL AND CUST_STREET IS NULL) AND (CUST_TAXNO = ? OR " & _
        "? IS NULL AND CUST_TAXNO IS NULL) AND (CUST_TCODE = ? OR ? IS NULL AND CUST_TCOD" & _
        "E IS NULL) AND (CUST_ZIP = ? OR ? IS NULL AND CUST_ZIP IS NULL)"
        Me.OdbcDeleteCommand1.Connection = Me.OdbcConnection1
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_KEY", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_KEY", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_CITY", System.Data.Odbc.OdbcType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_CITY", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_CITY1", System.Data.Odbc.OdbcType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_CITY", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_CONTACT", System.Data.Odbc.OdbcType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_CONTACT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_CONTACT1", System.Data.Odbc.OdbcType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_CONTACT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_FAX", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_FAX", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_FAX1", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_FAX", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_GIFT", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_GIFT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_GIFT1", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_GIFT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_LIMIT", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(2, Byte), "CUST_LIMIT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_LIMIT1", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(2, Byte), "CUST_LIMIT", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_NAME", System.Data.Odbc.OdbcType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_NAME", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_NAME1", System.Data.Odbc.OdbcType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_NAME", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_PHONE", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_PHONE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_PHONE1", System.Data.Odbc.OdbcType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CUST_PHONE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_RTYPE", System.Data.Odbc.OdbcType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_RTYPE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_RTYPE1", System.Data.Odbc.OdbcType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_RTYPE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_STATE", System.Data.Odbc.OdbcType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_STATE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_STATE1", System.Data.Odbc.OdbcType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_STATE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_STREET", System.Data.Odbc.OdbcType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_STREET", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_STREET1", System.Data.Odbc.OdbcType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_STREET", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_TAXNO", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_TAXNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_TAXNO1", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_TAXNO", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_TCODE", System.Data.Odbc.OdbcType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_TCODE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_TCODE1", System.Data.Odbc.OdbcType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_TCODE", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_ZIP", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_ZIP", System.Data.DataRowVersion.Original, Nothing))
        Me.OdbcDeleteCommand1.Parameters.Add(New System.Data.Odbc.OdbcParameter("Original_CUST_ZIP1", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CUST_ZIP", System.Data.DataRowVersion.Original, Nothing))
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "DSN=xfODBC;UID=DBADMIN;PWD=MANAGER;DBQ=sodbc_sa"
        '
        'NewDataSet1
        '
        Me.NewDataSet1.DataSetName = "NewDataSet"
        Me.NewDataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 421)
        Me.Controls.Add(Me.txtCUST_LIMIT)
        Me.Controls.Add(Me.txtCUST_TAXNO)
        Me.Controls.Add(Me.txtCUST_TCODE)
        Me.Controls.Add(Me.txtCUST_GIFT)
        Me.Controls.Add(Me.txtCUST_FAX)
        Me.Controls.Add(Me.txtCUST_PHONE)
        Me.Controls.Add(Me.txtCUST_CONTACT)
        Me.Controls.Add(Me.txtCUST_ZIP)
        Me.Controls.Add(Me.txtCUST_STATE)
        Me.Controls.Add(Me.txtCUST_CITY)
        Me.Controls.Add(Me.txtCUST_STREET)
        Me.Controls.Add(Me.txtCUST_NAME)
        Me.Controls.Add(Me.txtCUST_RTYPE)
        Me.Controls.Add(Me.txtCUST_KEY)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdLastRecord)
        Me.Controls.Add(Me.cmdPreviousButton)
        Me.Controls.Add(Me.cmdNextRecord)
        Me.Controls.Add(Me.cmdFirstRecord)
        Me.Controls.Add(Me.sbpRecordPosition)
        Me.Controls.Add(Me.lblCUST_LIMIT)
        Me.Controls.Add(Me.lblCUST_TAXNO)
        Me.Controls.Add(Me.lblCUST_TCODE)
        Me.Controls.Add(Me.lblCUST_GIFT)
        Me.Controls.Add(Me.lblCUST_FAX)
        Me.Controls.Add(Me.lblCUST_PHONE)
        Me.Controls.Add(Me.lblCUST_CONTACT)
        Me.Controls.Add(Me.lblCUST_ZIP)
        Me.Controls.Add(Me.lblCUST_STATE)
        Me.Controls.Add(Me.lblCUST_CITY)
        Me.Controls.Add(Me.lblCUST_STREET)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCUST_RTYPE)
        Me.Controls.Add(Me.lblCUST_KEY)
        Me.Name = "frmMain"
        Me.Text = "Synergy - xfODBC"
        CType(Me.NewDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirstRecord.Click
        'Move to the first record

        bmcustomers.Position = 0
    End Sub

    Private Sub cmdNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextRecord.Click
        'Move to the next record

        With bmcustomers
            If .Position < .Count - 1 Then
                .Position += 1
            Else
                cmdFirstRecord_Click(sender, e)
            End If
        End With
    End Sub

    Private Sub cmdPreviousButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousButton.Click
        'Move to the previous record

        With bmcustomers
            If .Position > 0 Then
                .Position -= 1
            Else
                cmdLastRecord_Click(sender, e)
            End If
        End With
    End Sub

    Private Sub cmdLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLastRecord.Click
        'Move to the last record

        With bmcustomers
            .Position = .Count - 1
        End With
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        'Begin an add operation or cancel the current operation

        If cmdAdd.Text = "&Add" Then
            UnlockTextBoxes()
            DisableNavigation()
            SetButtonsForEdit()

            'Make sure the current record is saved
            bmcustomers.EndCurrentEdit()
            'Clear the fields
            bmcustomers.AddNew()
            txtCUST_KEY.Focus()
        Else 'Cancel button clicked
            LockTextBoxes()
            EnableNavigation()
            ResetButtonsAfterEdit()
            bmcustomers.CancelCurrentEdit()
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'Delete the current record after confirming

        Dim dgrDelete As DialogResult

        Try
            dgrDelete = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo)
            If dgrDelete = DialogResult.Yes Then
                With bmcustomers
                    .RemoveAt(.Position)        'Delete the record from the dataset
                End With
                Me.OdbcDataAdapter1.Update(NewDataSet1, "Customers")  'Update the data source
                NewDataSet1.AcceptChanges()     'Reset the dataset

            End If

        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        'Save edits to current record

        UnlockTextBoxes()
        DisableNavigation()
        SetButtonsForEdit()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'Save updates to the dataset

        Try
            bmcustomers.EndCurrentEdit()                          'Complete the current edit
            OdbcDataAdapter1.Update(NewDataSet1, "Customers")     'Update the data source
            NewDataSet1.AcceptChanges()
            LockTextBoxes()
            EnableNavigation()
            ResetButtonsAfterEdit()
        Catch ex As Exception
            'Check for duplicated records and constraint violations
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DisableNavigation()
        'Disable the navigation buttons

        cmdFirstRecord.Enabled = False
        cmdLastRecord.Enabled = False
        cmdPreviousButton.Enabled = False
        cmdNextRecord.Enabled = False
    End Sub
    Private Sub EnableNavigation()
        'Enable the navigation buttons

        cmdFirstRecord.Enabled = True
        cmdLastRecord.Enabled = True
        cmdPreviousButton.Enabled = True
        cmdNextRecord.Enabled = True
    End Sub
    Private Sub LockTextBoxes()
        'Lock for the Add or Edit

        txtCUST_KEY.ReadOnly = True
        txtCUST_RTYPE.ReadOnly = True
        txtCUST_NAME.ReadOnly = True
        txtCUST_STREET.ReadOnly = True
        txtCUST_CITY.ReadOnly = True
        txtCUST_STATE.ReadOnly = True
        txtCUST_ZIP.ReadOnly = True
        txtCUST_CONTACT.ReadOnly = True
        txtCUST_PHONE.ReadOnly = True
        txtCUST_FAX.ReadOnly = True
        txtCUST_GIFT.ReadOnly = True
        txtCUST_TCODE.ReadOnly = True
        txtCUST_TAXNO.ReadOnly = True
        txtCUST_LIMIT.ReadOnly = True
    End Sub
    Private Sub UnlockTextBoxes()
        'Unlock for Add or Edit

        txtCUST_KEY.ReadOnly = False
        txtCUST_RTYPE.ReadOnly = False
        txtCUST_NAME.ReadOnly = False
        txtCUST_STREET.ReadOnly = False
        txtCUST_CITY.ReadOnly = False
        txtCUST_STATE.ReadOnly = False
        txtCUST_ZIP.ReadOnly = False
        txtCUST_CONTACT.ReadOnly = False
        txtCUST_PHONE.ReadOnly = False
        txtCUST_FAX.ReadOnly = False
        txtCUST_GIFT.ReadOnly = False
        txtCUST_TCODE.ReadOnly = False
        txtCUST_TAXNO.ReadOnly = False
        txtCUST_LIMIT.ReadOnly = False
    End Sub
    Private Sub Position_Changed(ByVal sender As Object, ByVal e As EventArgs)
        'Display the record position

        With bmcustomers
            sbpRecordPosition.Text = "Record " & (.Position + 1).ToString() & " of " & .Count.ToString()
        End With
    End Sub
    Private Sub ResetButtonsAfterEdit()
        'Reset the buttons after an Add and Edit operation

        cmdAdd.Text = "&Add"
        cmdSave.Enabled = False
        cmdDelete.Enabled = True
        cmdEdit.Enabled = True
    End Sub
    Private Sub SetButtonsForEdit()
        'Set up buttons for an Add or Edit operation

        cmdAdd.Text = "&Cancel"
        cmdSave.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Open database connection
            OdbcConnection1.Open()

            'Fill the dataset
            Me.OdbcDataAdapter1.Fill(NewDataSet1, "Customers")
            mblnListsInitialized = True

            'Lock text boxes
            LockTextBoxes()
            sbpRecordPosition.ReadOnly = True

            'Get the Binding ManagerBase for the customer table
            bmcustomers = Me.BindingContext(NewDataSet1, "Customers")

            'Add the delegate for the PositionChanged event
            AddHandler bmcustomers.PositionChanged, AddressOf Position_Changed

            'Display record number for the first record
            Position_Changed(sender, e)
        Catch ex As Exception
            'Check for errors
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
