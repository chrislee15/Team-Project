<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmT13SysAdmin
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblCName = New System.Windows.Forms.Label()
        Me.lblCDistanceFromDistribution = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblEDistanceFromDistribution = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lblEName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRemoveLoc = New System.Windows.Forms.Label()
        Me.lblAddEventLoc = New System.Windows.Forms.Label()
        Me.lblAddCookingLoc = New System.Windows.Forms.Label()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCEName = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnGetHelp = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(312, 29)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 31)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox2.Location = New System.Drawing.Point(385, 29)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 31)
        Me.TextBox2.TabIndex = 1
        '
        'lblCName
        '
        Me.lblCName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCName.AutoSize = True
        Me.lblCName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCName.Location = New System.Drawing.Point(6, 8)
        Me.lblCName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(287, 74)
        Me.lblCName.TabIndex = 2
        Me.lblCName.Text = "What is the name of the location?"
        '
        'lblCDistanceFromDistribution
        '
        Me.lblCDistanceFromDistribution.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCDistanceFromDistribution.AutoSize = True
        Me.lblCDistanceFromDistribution.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCDistanceFromDistribution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCDistanceFromDistribution.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCDistanceFromDistribution.Location = New System.Drawing.Point(6, 8)
        Me.lblCDistanceFromDistribution.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCDistanceFromDistribution.Name = "lblCDistanceFromDistribution"
        Me.lblCDistanceFromDistribution.Size = New System.Drawing.Size(295, 74)
        Me.lblCDistanceFromDistribution.TabIndex = 3
        Me.lblCDistanceFromDistribution.Text = "How far is it from the closest distribution"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCName, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(612, 90)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(406, 6)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1556, 102)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCDistanceFromDistribution, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(784, 6)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 90)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel9, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(406, 349)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1486, 102)
        Me.TableLayoutPanel7.TabIndex = 9
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox5, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lblEDistanceFromDistribution, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(749, 6)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(634, 90)
        Me.TableLayoutPanel8.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox5.Location = New System.Drawing.Point(323, 29)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 31)
        Me.TextBox5.TabIndex = 1
        '
        'lblEDistanceFromDistribution
        '
        Me.lblEDistanceFromDistribution.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEDistanceFromDistribution.AutoSize = True
        Me.lblEDistanceFromDistribution.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblEDistanceFromDistribution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEDistanceFromDistribution.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEDistanceFromDistribution.Location = New System.Drawing.Point(6, 0)
        Me.lblEDistanceFromDistribution.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblEDistanceFromDistribution.Name = "lblEDistanceFromDistribution"
        Me.lblEDistanceFromDistribution.Size = New System.Drawing.Size(295, 90)
        Me.lblEDistanceFromDistribution.TabIndex = 3
        Me.lblEDistanceFromDistribution.Text = "How far is it from the closest distribution location?"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.TextBox6, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.lblEName, 0, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(730, 90)
        Me.TableLayoutPanel9.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox6.Location = New System.Drawing.Point(371, 29)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(174, 31)
        Me.TextBox6.TabIndex = 0
        '
        'lblEName
        '
        Me.lblEName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEName.AutoSize = True
        Me.lblEName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblEName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEName.Location = New System.Drawing.Point(6, 8)
        Me.lblEName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblEName.Name = "lblEName"
        Me.lblEName.Size = New System.Drawing.Size(336, 74)
        Me.lblEName.TabIndex = 2
        Me.lblEName.Text = "What is the name of the location?"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel7, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.lblRemoveLoc, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.lblAddEventLoc, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.lblAddCookingLoc, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel13, 1, 2)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(0, 6)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 3
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(1968, 1031)
        Me.TableLayoutPanel10.TabIndex = 10
        '
        'lblRemoveLoc
        '
        Me.lblRemoveLoc.AutoSize = True
        Me.lblRemoveLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRemoveLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRemoveLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemoveLoc.Location = New System.Drawing.Point(6, 686)
        Me.lblRemoveLoc.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblRemoveLoc.Name = "lblRemoveLoc"
        Me.lblRemoveLoc.Size = New System.Drawing.Size(272, 38)
        Me.lblRemoveLoc.TabIndex = 12
        Me.lblRemoveLoc.Text = "Remove a Location"
        '
        'lblAddEventLoc
        '
        Me.lblAddEventLoc.AutoSize = True
        Me.lblAddEventLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAddEventLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddEventLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEventLoc.Location = New System.Drawing.Point(6, 343)
        Me.lblAddEventLoc.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAddEventLoc.Name = "lblAddEventLoc"
        Me.lblAddEventLoc.Size = New System.Drawing.Size(346, 38)
        Me.lblAddEventLoc.TabIndex = 13
        Me.lblAddEventLoc.Text = "Add New Event Location"
        '
        'lblAddCookingLoc
        '
        Me.lblAddCookingLoc.AutoSize = True
        Me.lblAddCookingLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAddCookingLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddCookingLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddCookingLoc.Location = New System.Drawing.Point(6, 0)
        Me.lblAddCookingLoc.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAddCookingLoc.Name = "lblAddCookingLoc"
        Me.lblAddCookingLoc.Size = New System.Drawing.Size(337, 38)
        Me.lblAddCookingLoc.TabIndex = 14
        Me.lblAddCookingLoc.Text = "Add a Cooking Location"
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.lblCEName, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.TextBox4, 1, 0)
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(406, 692)
        Me.TableLayoutPanel13.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(618, 90)
        Me.TableLayoutPanel13.TabIndex = 5
        '
        'lblCEName
        '
        Me.lblCEName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCEName.AutoSize = True
        Me.lblCEName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCEName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCEName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEName.Location = New System.Drawing.Point(6, 26)
        Me.lblCEName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCEName.Name = "lblCEName"
        Me.lblCEName.Size = New System.Drawing.Size(399, 38)
        Me.lblCEName.TabIndex = 2
        Me.lblCEName.Text = "Select a location to remove - "
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(1798, 1048)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 44)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnGetHelp
        '
        Me.btnGetHelp.Location = New System.Drawing.Point(1574, 1048)
        Me.btnGetHelp.Margin = New System.Windows.Forms.Padding(6)
        Me.btnGetHelp.Name = "btnGetHelp"
        Me.btnGetHelp.Size = New System.Drawing.Size(150, 44)
        Me.btnGetHelp.TabIndex = 12
        Me.btnGetHelp.Text = "Need Help?"
        Me.btnGetHelp.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox4.Location = New System.Drawing.Point(417, 29)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(174, 31)
        Me.TextBox4.TabIndex = 3
        '
        'frmT13SysAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2008, 1094)
        Me.Controls.Add(Me.btnGetHelp)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.TableLayoutPanel10)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmT13SysAdmin"
        Me.Text = "System Admin"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblCName As Label
    Friend WithEvents lblCDistanceFromDistribution As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lblEDistanceFromDistribution As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lblEName As Label
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents lblCEName As Label
    Friend WithEvents lblRemoveLoc As Label
    Friend WithEvents lblAddEventLoc As Label
    Friend WithEvents lblAddCookingLoc As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnGetHelp As Button
    Friend WithEvents TextBox4 As TextBox
End Class
