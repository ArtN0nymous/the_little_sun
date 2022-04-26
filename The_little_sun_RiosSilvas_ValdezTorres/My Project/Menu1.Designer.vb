<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Menu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.planetnames = New System.Windows.Forms.PictureBox()
        Me.planetform = New System.Windows.Forms.PictureBox()
        Me.planetorder = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.planetnames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.planetform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.planetorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 636)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(706, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(212, 636)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'planetnames
        '
        Me.planetnames.BackColor = System.Drawing.Color.Transparent
        Me.planetnames.Image = CType(resources.GetObject("planetnames.Image"), System.Drawing.Image)
        Me.planetnames.Location = New System.Drawing.Point(216, 4)
        Me.planetnames.Name = "planetnames"
        Me.planetnames.Size = New System.Drawing.Size(484, 210)
        Me.planetnames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.planetnames.TabIndex = 2
        Me.planetnames.TabStop = False
        '
        'planetform
        '
        Me.planetform.BackColor = System.Drawing.Color.Transparent
        Me.planetform.Image = CType(resources.GetObject("planetform.Image"), System.Drawing.Image)
        Me.planetform.Location = New System.Drawing.Point(216, 214)
        Me.planetform.Name = "planetform"
        Me.planetform.Size = New System.Drawing.Size(484, 210)
        Me.planetform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.planetform.TabIndex = 3
        Me.planetform.TabStop = False
        '
        'planetorder
        '
        Me.planetorder.BackColor = System.Drawing.Color.Transparent
        Me.planetorder.Image = CType(resources.GetObject("planetorder.Image"), System.Drawing.Image)
        Me.planetorder.Location = New System.Drawing.Point(216, 420)
        Me.planetorder.Name = "planetorder"
        Me.planetorder.Size = New System.Drawing.Size(484, 210)
        Me.planetorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.planetorder.TabIndex = 4
        Me.planetorder.TabStop = False
        '
        'Ventana_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(917, 633)
        Me.Controls.Add(Me.planetorder)
        Me.Controls.Add(Me.planetform)
        Me.Controls.Add(Me.planetnames)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Ventana_Menu"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.planetnames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.planetform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.planetorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents planetnames As System.Windows.Forms.PictureBox
    Friend WithEvents planetform As System.Windows.Forms.PictureBox
    Friend WithEvents planetorder As System.Windows.Forms.PictureBox
End Class
