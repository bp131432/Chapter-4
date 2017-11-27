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
        Me.listColor = New System.Windows.Forms.ListBox()
        Me.listEst = New System.Windows.Forms.ListBox()
        Me.listNumber = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listBodyPart = New System.Windows.Forms.ListBox()
        Me.listAnimal = New System.Windows.Forms.ListBox()
        Me.listNoun = New System.Windows.Forms.ListBox()
        Me.listPluralNoun = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listColor
        '
        Me.listColor.FormattingEnabled = True
        Me.listColor.Items.AddRange(New Object() {"Blue", "Red ", "Yellow", "Green"})
        Me.listColor.Location = New System.Drawing.Point(51, 44)
        Me.listColor.Name = "listColor"
        Me.listColor.Size = New System.Drawing.Size(120, 95)
        Me.listColor.TabIndex = 0
        '
        'listEst
        '
        Me.listEst.FormattingEnabled = True
        Me.listEst.Items.AddRange(New Object() {"Biggest", "Fastest", "Greatest", "Shortest", "Smallest "})
        Me.listEst.Location = New System.Drawing.Point(224, 44)
        Me.listEst.Name = "listEst"
        Me.listEst.Size = New System.Drawing.Size(120, 95)
        Me.listEst.TabIndex = 1
        '
        'listNumber
        '
        Me.listNumber.FormattingEnabled = True
        Me.listNumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "20", "100"})
        Me.listNumber.Location = New System.Drawing.Point(409, 44)
        Me.listNumber.Name = "listNumber"
        Me.listNumber.Size = New System.Drawing.Size(120, 95)
        Me.listNumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Word ending in Est"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Body Part"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Animal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(412, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Noun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Plural Noun"
        '
        'listBodyPart
        '
        Me.listBodyPart.FormattingEnabled = True
        Me.listBodyPart.Items.AddRange(New Object() {"Arms ", "Legs", "Toes", "Fingers", "Heads"})
        Me.listBodyPart.Location = New System.Drawing.Point(51, 196)
        Me.listBodyPart.Name = "listBodyPart"
        Me.listBodyPart.Size = New System.Drawing.Size(120, 95)
        Me.listBodyPart.TabIndex = 10
        '
        'listAnimal
        '
        Me.listAnimal.FormattingEnabled = True
        Me.listAnimal.Items.AddRange(New Object() {"Dog ", "Cat", "Fish", "Falcon", "Chicken", "Pig "})
        Me.listAnimal.Location = New System.Drawing.Point(224, 196)
        Me.listAnimal.Name = "listAnimal"
        Me.listAnimal.Size = New System.Drawing.Size(120, 95)
        Me.listAnimal.TabIndex = 11
        '
        'listNoun
        '
        Me.listNoun.FormattingEnabled = True
        Me.listNoun.Items.AddRange(New Object() {"Person", "Square", "Circle", "Box"})
        Me.listNoun.Location = New System.Drawing.Point(415, 196)
        Me.listNoun.Name = "listNoun"
        Me.listNoun.Size = New System.Drawing.Size(120, 95)
        Me.listNoun.TabIndex = 12
        '
        'listPluralNoun
        '
        Me.listPluralNoun.FormattingEnabled = True
        Me.listPluralNoun.Items.AddRange(New Object() {"People", "Chicken", "Fish", "Buildings", "Boats"})
        Me.listPluralNoun.Location = New System.Drawing.Point(51, 342)
        Me.listPluralNoun.Name = "listPluralNoun"
        Me.listPluralNoun.Size = New System.Drawing.Size(120, 95)
        Me.listPluralNoun.TabIndex = 13
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(262, 342)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(262, 391)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(385, 341)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 477)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.listPluralNoun)
        Me.Controls.Add(Me.listNoun)
        Me.Controls.Add(Me.listAnimal)
        Me.Controls.Add(Me.listBodyPart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listNumber)
        Me.Controls.Add(Me.listEst)
        Me.Controls.Add(Me.listColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listColor As System.Windows.Forms.ListBox
    Friend WithEvents listEst As System.Windows.Forms.ListBox
    Friend WithEvents listNumber As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents listBodyPart As System.Windows.Forms.ListBox
    Friend WithEvents listAnimal As System.Windows.Forms.ListBox
    Friend WithEvents listNoun As System.Windows.Forms.ListBox
    Friend WithEvents listPluralNoun As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
