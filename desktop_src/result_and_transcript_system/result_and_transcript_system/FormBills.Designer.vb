﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBills
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxGuestID = New System.Windows.Forms.TextBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxGuestInfo = New System.Windows.Forms.TextBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDetails = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDebit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCredit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxBalance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxRef = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxImg = New System.Windows.Forms.PictureBox()
        Me.ButtonAddBill = New System.Windows.Forms.Button()
        Me.ButtonPrintBill = New System.Windows.Forms.Button()
        Me.ButtonGenerateBill = New System.Windows.Forms.Button()
        Me.ButtonRoom1 = New System.Windows.Forms.Button()
        Me.ButtonCalc = New System.Windows.Forms.Button()
        Me.ButtonPayBill = New System.Windows.Forms.Button()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Guest ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Detailed Guest Info"
        '
        'TextBoxGuestID
        '
        Me.TextBoxGuestID.Location = New System.Drawing.Point(81, 61)
        Me.TextBoxGuestID.Name = "TextBoxGuestID"
        Me.TextBoxGuestID.Size = New System.Drawing.Size(54, 20)
        Me.TextBoxGuestID.TabIndex = 11
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(279, 246)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(584, 280)
        Me.dgw.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblSet)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(279, 178)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 62)
        Me.Panel2.TabIndex = 42
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Location = New System.Drawing.Point(64, 27)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(23, 13)
        Me.lblSet.TabIndex = 1
        Me.lblSet.Text = "Set"
        Me.lblSet.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(206, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Guest Bill"
        '
        'TextBoxGuestInfo
        '
        Me.TextBoxGuestInfo.Enabled = False
        Me.TextBoxGuestInfo.Location = New System.Drawing.Point(81, 89)
        Me.TextBoxGuestInfo.Name = "TextBoxGuestInfo"
        Me.TextBoxGuestInfo.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxGuestInfo.TabIndex = 43
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(81, 124)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(10, 20)
        Me.TextBoxDate.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Date:"
        '
        'TextBoxDetails
        '
        Me.TextBoxDetails.Location = New System.Drawing.Point(81, 162)
        Me.TextBoxDetails.Name = "TextBoxDetails"
        Me.TextBoxDetails.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxDetails.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Details:"
        '
        'TextBoxDebit
        '
        Me.TextBoxDebit.Location = New System.Drawing.Point(81, 205)
        Me.TextBoxDebit.Name = "TextBoxDebit"
        Me.TextBoxDebit.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxDebit.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Debit:"
        '
        'TextBoxCredit
        '
        Me.TextBoxCredit.Location = New System.Drawing.Point(81, 246)
        Me.TextBoxCredit.Name = "TextBoxCredit"
        Me.TextBoxCredit.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxCredit.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Credit:"
        '
        'TextBoxBalance
        '
        Me.TextBoxBalance.Location = New System.Drawing.Point(81, 287)
        Me.TextBoxBalance.Name = "TextBoxBalance"
        Me.TextBoxBalance.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxBalance.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Balance:"
        '
        'TextBoxRef
        '
        Me.TextBoxRef.Location = New System.Drawing.Point(81, 329)
        Me.TextBoxRef.Name = "TextBoxRef"
        Me.TextBoxRef.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxRef.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Balance:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 125)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(138, 20)
        Me.DateTimePicker1.TabIndex = 58
        '
        'PictureBoxImg
        '
        Me.PictureBoxImg.Image = Global.eAccount.My.Resources.Resources.pool
        Me.PictureBoxImg.Location = New System.Drawing.Point(534, 40)
        Me.PictureBoxImg.Name = "PictureBoxImg"
        Me.PictureBoxImg.Size = New System.Drawing.Size(329, 118)
        Me.PictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImg.TabIndex = 59
        Me.PictureBoxImg.TabStop = False
        '
        'ButtonAddBill
        '
        Me.ButtonAddBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAddBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAddBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonAddBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddBill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAddBill.Image = Global.eAccount.My.Resources.Resources.user16b
        Me.ButtonAddBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAddBill.Location = New System.Drawing.Point(12, 471)
        Me.ButtonAddBill.Name = "ButtonAddBill"
        Me.ButtonAddBill.Size = New System.Drawing.Size(234, 55)
        Me.ButtonAddBill.TabIndex = 45
        Me.ButtonAddBill.Text = "Add Bill"
        Me.ButtonAddBill.UseVisualStyleBackColor = False
        '
        'ButtonPrintBill
        '
        Me.ButtonPrintBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPrintBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPrintBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonPrintBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrintBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintBill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPrintBill.Image = Global.eAccount.My.Resources.Resources.select16
        Me.ButtonPrintBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrintBill.Location = New System.Drawing.Point(285, 101)
        Me.ButtonPrintBill.Name = "ButtonPrintBill"
        Me.ButtonPrintBill.Size = New System.Drawing.Size(234, 57)
        Me.ButtonPrintBill.TabIndex = 44
        Me.ButtonPrintBill.Text = "Print Bill"
        Me.ButtonPrintBill.UseVisualStyleBackColor = False
        '
        'ButtonGenerateBill
        '
        Me.ButtonGenerateBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonGenerateBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonGenerateBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonGenerateBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGenerateBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerateBill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonGenerateBill.Image = Global.eAccount.My.Resources.Resources.select16
        Me.ButtonGenerateBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonGenerateBill.Location = New System.Drawing.Point(285, 40)
        Me.ButtonGenerateBill.Name = "ButtonGenerateBill"
        Me.ButtonGenerateBill.Size = New System.Drawing.Size(234, 55)
        Me.ButtonGenerateBill.TabIndex = 8
        Me.ButtonGenerateBill.Text = "View Bills (Refresh)"
        Me.ButtonGenerateBill.UseVisualStyleBackColor = False
        '
        'ButtonRoom1
        '
        Me.ButtonRoom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonRoom1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonRoom1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonRoom1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRoom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRoom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRoom1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonRoom1.Image = Global.eAccount.My.Resources.Resources.user16b
        Me.ButtonRoom1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRoom1.Location = New System.Drawing.Point(141, 40)
        Me.ButtonRoom1.Name = "ButtonRoom1"
        Me.ButtonRoom1.Size = New System.Drawing.Size(92, 42)
        Me.ButtonRoom1.TabIndex = 7
        Me.ButtonRoom1.Text = "..."
        Me.ButtonRoom1.UseVisualStyleBackColor = False
        '
        'ButtonCalc
        '
        Me.ButtonCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCalc.Image = Global.eAccount.My.Resources.Resources.user16b
        Me.ButtonCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCalc.Location = New System.Drawing.Point(12, 376)
        Me.ButtonCalc.Name = "ButtonCalc"
        Me.ButtonCalc.Size = New System.Drawing.Size(221, 76)
        Me.ButtonCalc.TabIndex = 60
        Me.ButtonCalc.Text = "Calculate Bill for Room"
        Me.ButtonCalc.UseVisualStyleBackColor = False
        '
        'ButtonPayBill
        '
        Me.ButtonPayBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPayBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPayBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.ButtonPayBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPayBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPayBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPayBill.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPayBill.Image = Global.eAccount.My.Resources.Resources.user16b
        Me.ButtonPayBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPayBill.Location = New System.Drawing.Point(279, 532)
        Me.ButtonPayBill.Name = "ButtonPayBill"
        Me.ButtonPayBill.Size = New System.Drawing.Size(221, 35)
        Me.ButtonPayBill.TabIndex = 61
        Me.ButtonPayBill.Text = "Pay Bill"
        Me.ButtonPayBill.UseVisualStyleBackColor = False
        '
        'FormBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 624)
        Me.Controls.Add(Me.ButtonPayBill)
        Me.Controls.Add(Me.ButtonCalc)
        Me.Controls.Add(Me.PictureBoxImg)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxRef)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxBalance)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxCredit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxDebit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxDetails)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonAddBill)
        Me.Controls.Add(Me.ButtonPrintBill)
        Me.Controls.Add(Me.TextBoxGuestInfo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgw)
        Me.Controls.Add(Me.TextBoxGuestID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGenerateBill)
        Me.Controls.Add(Me.ButtonRoom1)
        Me.Name = "FormBills"
        Me.Tag = "Front"
        Me.Text = "Bills"
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRoom1 As Button
    Friend WithEvents ButtonGenerateBill As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxGuestID As TextBox
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSet As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxGuestInfo As TextBox
    Friend WithEvents ButtonPrintBill As Button
    Friend WithEvents ButtonAddBill As Button
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxDetails As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDebit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCredit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxBalance As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxRef As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBoxImg As PictureBox
    Friend WithEvents ButtonCalc As Button
    Friend WithEvents ButtonPayBill As Button
End Class
