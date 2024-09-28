<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(257, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(275, 181)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.DarkGray
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"C:\Users\Ces\Downloads\Example\IMG_20200113_000356.jpg", "C:\Users\Ces\Downloads\Example\IMG_20200119_182548.jpg", "C:\Users\Ces\Downloads\Example\IMG_20200212_192655.jpg", "C:\Users\Ces\Downloads\Example\IMG_20200212_194842.jpg", "C:\Users\Ces\Downloads\Example\IMG_20200318_095142.jpg"})
        ListBox1.Location = New Point(167, 253)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(461, 94)
        ListBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(167, 375)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Form1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(553, 375)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "Form3"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
