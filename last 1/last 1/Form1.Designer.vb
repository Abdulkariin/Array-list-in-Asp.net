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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Names = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Removed = New System.Windows.Forms.Button()
        Me.RemovAt = New System.Windows.Forms.Button()
        Me.Noofproducts = New System.Windows.Forms.Label()
        Me.Inser = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 90)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(185, 196)
        Me.ListBox1.TabIndex = 3
        '
        'Names
        '
        Me.Names.Location = New System.Drawing.Point(223, 110)
        Me.Names.Name = "Names"
        Me.Names.Size = New System.Drawing.Size(104, 23)
        Me.Names.TabIndex = 4
        Me.Names.Text = "Insert Names"
        Me.Names.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Removed
        '
        Me.Removed.Location = New System.Drawing.Point(223, 211)
        Me.Removed.Name = "Removed"
        Me.Removed.Size = New System.Drawing.Size(104, 23)
        Me.Removed.TabIndex = 6
        Me.Removed.Text = "Remove"
        Me.Removed.UseVisualStyleBackColor = True
        '
        'RemovAt
        '
        Me.RemovAt.Location = New System.Drawing.Point(223, 263)
        Me.RemovAt.Name = "RemovAt"
        Me.RemovAt.Size = New System.Drawing.Size(104, 23)
        Me.RemovAt.TabIndex = 7
        Me.RemovAt.Text = "RemoveAt"
        Me.RemovAt.UseVisualStyleBackColor = True
        '
        'Noofproducts
        '
        Me.Noofproducts.AutoSize = True
        Me.Noofproducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Noofproducts.Location = New System.Drawing.Point(174, 289)
        Me.Noofproducts.Name = "Noofproducts"
        Me.Noofproducts.Size = New System.Drawing.Size(18, 20)
        Me.Noofproducts.TabIndex = 8
        Me.Noofproducts.Text = "0"
        '
        'Inser
        '
        Me.Inser.Location = New System.Drawing.Point(223, 62)
        Me.Inser.Name = "Inser"
        Me.Inser.Size = New System.Drawing.Size(104, 23)
        Me.Inser.TabIndex = 9
        Me.Inser.Text = "Add Names"
        Me.Inser.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Find names"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(102, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ArrayList "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 314)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Inser)
        Me.Controls.Add(Me.Noofproducts)
        Me.Controls.Add(Me.RemovAt)
        Me.Controls.Add(Me.Removed)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Names)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Names As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Removed As System.Windows.Forms.Button
    Friend WithEvents RemovAt As System.Windows.Forms.Button
    Friend WithEvents Noofproducts As System.Windows.Forms.Label
    Friend WithEvents Inser As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
