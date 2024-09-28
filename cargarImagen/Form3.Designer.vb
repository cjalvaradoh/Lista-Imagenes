<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        ListBox1 = New ListBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.DarkGray
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"C:\Users\Ces\Downloads\Images\Adelaida.jpg", "C:\Users\Ces\Downloads\Images\Londres.jpg", "C:\Users\Ces\Downloads\Images\Ámsterdam.jpg", "C:\Users\Ces\Downloads\Images\Berlin.jpg"})
        ListBox1.Location = New Point(170, 289)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(461, 94)
        ListBox1.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(260, 67)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(275, 181)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(170, 389)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Form2"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(PictureBox1)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
