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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.rdHamburger = New System.Windows.Forms.RadioButton()
        Me.rbCheeseburger = New System.Windows.Forms.RadioButton()
        Me.rbChicken = New System.Windows.Forms.RadioButton()
        Me.rbTurkey = New System.Windows.Forms.RadioButton()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.rbWater = New System.Windows.Forms.RadioButton()
        Me.rbPop = New System.Windows.Forms.RadioButton()
        Me.rbTea = New System.Windows.Forms.RadioButton()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblOrder2 = New System.Windows.Forms.Label()
        Me.lblOrder3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTurkey)
        Me.GroupBox1.Controls.Add(Me.rbChicken)
        Me.GroupBox1.Controls.Add(Me.rbCheeseburger)
        Me.GroupBox1.Controls.Add(Me.rdHamburger)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select your meal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTea)
        Me.GroupBox3.Controls.Add(Me.rbPop)
        Me.GroupBox3.Controls.Add(Me.rbWater)
        Me.GroupBox3.Location = New System.Drawing.Point(356, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Drink"
        '
        'lblOrder
        '
        Me.lblOrder.BackColor = System.Drawing.Color.White
        Me.lblOrder.Location = New System.Drawing.Point(60, 238)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(103, 26)
        Me.lblOrder.TabIndex = 3
        '
        'rdHamburger
        '
        Me.rdHamburger.AutoSize = True
        Me.rdHamburger.Location = New System.Drawing.Point(35, 19)
        Me.rdHamburger.Name = "rdHamburger"
        Me.rdHamburger.Size = New System.Drawing.Size(77, 17)
        Me.rdHamburger.TabIndex = 0
        Me.rdHamburger.TabStop = True
        Me.rdHamburger.Text = "Hamburger"
        Me.rdHamburger.UseVisualStyleBackColor = True
        '
        'rbCheeseburger
        '
        Me.rbCheeseburger.AutoSize = True
        Me.rbCheeseburger.Location = New System.Drawing.Point(35, 56)
        Me.rbCheeseburger.Name = "rbCheeseburger"
        Me.rbCheeseburger.Size = New System.Drawing.Size(91, 17)
        Me.rbCheeseburger.TabIndex = 1
        Me.rbCheeseburger.TabStop = True
        Me.rbCheeseburger.Text = "Cheeseburger"
        Me.rbCheeseburger.UseVisualStyleBackColor = True
        '
        'rbChicken
        '
        Me.rbChicken.AutoSize = True
        Me.rbChicken.Location = New System.Drawing.Point(35, 92)
        Me.rbChicken.Name = "rbChicken"
        Me.rbChicken.Size = New System.Drawing.Size(64, 17)
        Me.rbChicken.TabIndex = 2
        Me.rbChicken.TabStop = True
        Me.rbChicken.Text = "Chicken"
        Me.rbChicken.UseVisualStyleBackColor = True
        '
        'rbTurkey
        '
        Me.rbTurkey.AutoSize = True
        Me.rbTurkey.Location = New System.Drawing.Point(35, 126)
        Me.rbTurkey.Name = "rbTurkey"
        Me.rbTurkey.Size = New System.Drawing.Size(58, 17)
        Me.rbTurkey.TabIndex = 3
        Me.rbTurkey.TabStop = True
        Me.rbTurkey.Text = "Turkey"
        Me.rbTurkey.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(63, 382)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'rbWater
        '
        Me.rbWater.AutoSize = True
        Me.rbWater.Location = New System.Drawing.Point(24, 20)
        Me.rbWater.Name = "rbWater"
        Me.rbWater.Size = New System.Drawing.Size(54, 17)
        Me.rbWater.TabIndex = 0
        Me.rbWater.TabStop = True
        Me.rbWater.Text = "Water"
        Me.rbWater.UseVisualStyleBackColor = True
        '
        'rbPop
        '
        Me.rbPop.AutoSize = True
        Me.rbPop.Location = New System.Drawing.Point(24, 43)
        Me.rbPop.Name = "rbPop"
        Me.rbPop.Size = New System.Drawing.Size(44, 17)
        Me.rbPop.TabIndex = 1
        Me.rbPop.TabStop = True
        Me.rbPop.Text = "Pop"
        Me.rbPop.UseVisualStyleBackColor = True
        '
        'rbTea
        '
        Me.rbTea.AutoSize = True
        Me.rbTea.Location = New System.Drawing.Point(24, 67)
        Me.rbTea.Name = "rbTea"
        Me.rbTea.Size = New System.Drawing.Size(44, 17)
        Me.rbTea.TabIndex = 2
        Me.rbTea.TabStop = True
        Me.rbTea.Text = "Tea"
        Me.rbTea.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(24, 20)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(24, 44)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(24, 68)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(60, 344)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 5
        '
        'lblOrder2
        '
        Me.lblOrder2.BackColor = System.Drawing.Color.White
        Me.lblOrder2.Location = New System.Drawing.Point(60, 273)
        Me.lblOrder2.Name = "lblOrder2"
        Me.lblOrder2.Size = New System.Drawing.Size(100, 23)
        Me.lblOrder2.TabIndex = 6
        '
        'lblOrder3
        '
        Me.lblOrder3.BackColor = System.Drawing.Color.White
        Me.lblOrder3.Location = New System.Drawing.Point(60, 306)
        Me.lblOrder3.Name = "lblOrder3"
        Me.lblOrder3.Size = New System.Drawing.Size(100, 23)
        Me.lblOrder3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 428)
        Me.Controls.Add(Me.lblOrder3)
        Me.Controls.Add(Me.lblOrder2)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Ordering Food"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTurkey As System.Windows.Forms.RadioButton
    Friend WithEvents rbChicken As System.Windows.Forms.RadioButton
    Friend WithEvents rbCheeseburger As System.Windows.Forms.RadioButton
    Friend WithEvents rdHamburger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTea As System.Windows.Forms.RadioButton
    Friend WithEvents rbPop As System.Windows.Forms.RadioButton
    Friend WithEvents rbWater As System.Windows.Forms.RadioButton
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblOrder2 As System.Windows.Forms.Label
    Friend WithEvents lblOrder3 As System.Windows.Forms.Label

End Class
