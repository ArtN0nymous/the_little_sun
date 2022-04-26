<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NdP_1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NdP_1))
        Me.planeta1 = New System.Windows.Forms.PictureBox()
        Me.planeta2 = New System.Windows.Forms.PictureBox()
        Me.planeta3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.planeta_planet = New System.Windows.Forms.PictureBox()
        Me.correcto1 = New System.Windows.Forms.PictureBox()
        Me.incorrecto2 = New System.Windows.Forms.PictureBox()
        Me.incorrecto3 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.incorrecto1 = New System.Windows.Forms.PictureBox()
        Me.correcto2 = New System.Windows.Forms.PictureBox()
        Me.correcto3 = New System.Windows.Forms.PictureBox()
        Me.lbl_lifes = New System.Windows.Forms.Label()
        Me.lbl_correcto = New System.Windows.Forms.Label()
        Me.lbl_pregunta = New System.Windows.Forms.Label()
        CType(Me.planeta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.planeta2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.planeta3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.planeta_planet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.correcto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.incorrecto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.incorrecto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.incorrecto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.correcto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.correcto3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'planeta1
        '
        Me.planeta1.Image = CType(resources.GetObject("planeta1.Image"), System.Drawing.Image)
        Me.planeta1.Location = New System.Drawing.Point(118, 777)
        Me.planeta1.Name = "planeta1"
        Me.planeta1.Size = New System.Drawing.Size(399, 147)
        Me.planeta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.planeta1.TabIndex = 0
        Me.planeta1.TabStop = False
        '
        'planeta2
        '
        Me.planeta2.Image = CType(resources.GetObject("planeta2.Image"), System.Drawing.Image)
        Me.planeta2.Location = New System.Drawing.Point(588, 777)
        Me.planeta2.Name = "planeta2"
        Me.planeta2.Size = New System.Drawing.Size(399, 147)
        Me.planeta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.planeta2.TabIndex = 1
        Me.planeta2.TabStop = False
        '
        'planeta3
        '
        Me.planeta3.Image = CType(resources.GetObject("planeta3.Image"), System.Drawing.Image)
        Me.planeta3.Location = New System.Drawing.Point(1079, 777)
        Me.planeta3.Name = "planeta3"
        Me.planeta3.Size = New System.Drawing.Size(399, 147)
        Me.planeta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.planeta3.TabIndex = 2
        Me.planeta3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(389, 39)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(824, 138)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'planeta_planet
        '
        Me.planeta_planet.BackColor = System.Drawing.Color.Transparent
        Me.planeta_planet.Image = CType(resources.GetObject("planeta_planet.Image"), System.Drawing.Image)
        Me.planeta_planet.Location = New System.Drawing.Point(548, 183)
        Me.planeta_planet.Name = "planeta_planet"
        Me.planeta_planet.Size = New System.Drawing.Size(500, 500)
        Me.planeta_planet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.planeta_planet.TabIndex = 4
        Me.planeta_planet.TabStop = False
        '
        'correcto1
        '
        Me.correcto1.BackColor = System.Drawing.Color.Transparent
        Me.correcto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.correcto1.Image = CType(resources.GetObject("correcto1.Image"), System.Drawing.Image)
        Me.correcto1.Location = New System.Drawing.Point(118, 703)
        Me.correcto1.Name = "correcto1"
        Me.correcto1.Size = New System.Drawing.Size(399, 346)
        Me.correcto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.correcto1.TabIndex = 19
        Me.correcto1.TabStop = False
        Me.correcto1.Visible = False
        '
        'incorrecto2
        '
        Me.incorrecto2.BackColor = System.Drawing.Color.Transparent
        Me.incorrecto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.incorrecto2.Image = CType(resources.GetObject("incorrecto2.Image"), System.Drawing.Image)
        Me.incorrecto2.Location = New System.Drawing.Point(588, 739)
        Me.incorrecto2.Name = "incorrecto2"
        Me.incorrecto2.Size = New System.Drawing.Size(413, 256)
        Me.incorrecto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.incorrecto2.TabIndex = 18
        Me.incorrecto2.TabStop = False
        Me.incorrecto2.Visible = False
        '
        'incorrecto3
        '
        Me.incorrecto3.BackColor = System.Drawing.Color.Transparent
        Me.incorrecto3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.incorrecto3.Image = CType(resources.GetObject("incorrecto3.Image"), System.Drawing.Image)
        Me.incorrecto3.Location = New System.Drawing.Point(1076, 739)
        Me.incorrecto3.Name = "incorrecto3"
        Me.incorrecto3.Size = New System.Drawing.Size(409, 256)
        Me.incorrecto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.incorrecto3.TabIndex = 17
        Me.incorrecto3.TabStop = False
        Me.incorrecto3.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1508, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(66, 61)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 20
        Me.PictureBox6.TabStop = False
        '
        'incorrecto1
        '
        Me.incorrecto1.BackColor = System.Drawing.Color.Transparent
        Me.incorrecto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.incorrecto1.Image = CType(resources.GetObject("incorrecto1.Image"), System.Drawing.Image)
        Me.incorrecto1.Location = New System.Drawing.Point(108, 739)
        Me.incorrecto1.Name = "incorrecto1"
        Me.incorrecto1.Size = New System.Drawing.Size(409, 256)
        Me.incorrecto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.incorrecto1.TabIndex = 21
        Me.incorrecto1.TabStop = False
        Me.incorrecto1.Visible = False
        '
        'correcto2
        '
        Me.correcto2.BackColor = System.Drawing.Color.Transparent
        Me.correcto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.correcto2.Image = CType(resources.GetObject("correcto2.Image"), System.Drawing.Image)
        Me.correcto2.Location = New System.Drawing.Point(588, 703)
        Me.correcto2.Name = "correcto2"
        Me.correcto2.Size = New System.Drawing.Size(413, 346)
        Me.correcto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.correcto2.TabIndex = 22
        Me.correcto2.TabStop = False
        Me.correcto2.Visible = False
        '
        'correcto3
        '
        Me.correcto3.BackColor = System.Drawing.Color.Transparent
        Me.correcto3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.correcto3.Image = CType(resources.GetObject("correcto3.Image"), System.Drawing.Image)
        Me.correcto3.Location = New System.Drawing.Point(1079, 703)
        Me.correcto3.Name = "correcto3"
        Me.correcto3.Size = New System.Drawing.Size(399, 346)
        Me.correcto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.correcto3.TabIndex = 23
        Me.correcto3.TabStop = False
        Me.correcto3.Visible = False
        '
        'lbl_lifes
        '
        Me.lbl_lifes.AutoSize = True
        Me.lbl_lifes.Location = New System.Drawing.Point(35, 84)
        Me.lbl_lifes.Name = "lbl_lifes"
        Me.lbl_lifes.Size = New System.Drawing.Size(51, 13)
        Me.lbl_lifes.TabIndex = 24
        Me.lbl_lifes.Text = "Intentos: "
        '
        'lbl_correcto
        '
        Me.lbl_correcto.AutoSize = True
        Me.lbl_correcto.Location = New System.Drawing.Point(28, 61)
        Me.lbl_correcto.Name = "lbl_correcto"
        Me.lbl_correcto.Size = New System.Drawing.Size(58, 13)
        Me.lbl_correcto.TabIndex = 25
        Me.lbl_correcto.Text = "Correctos: "
        '
        'lbl_pregunta
        '
        Me.lbl_pregunta.AutoSize = True
        Me.lbl_pregunta.Location = New System.Drawing.Point(30, 39)
        Me.lbl_pregunta.Name = "lbl_pregunta"
        Me.lbl_pregunta.Size = New System.Drawing.Size(56, 13)
        Me.lbl_pregunta.TabIndex = 26
        Me.lbl_pregunta.Text = "Pregunta: "
        '
        'NdP_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1577, 1061)
        Me.Controls.Add(Me.planeta_planet)
        Me.Controls.Add(Me.lbl_pregunta)
        Me.Controls.Add(Me.lbl_correcto)
        Me.Controls.Add(Me.lbl_lifes)
        Me.Controls.Add(Me.incorrecto3)
        Me.Controls.Add(Me.correcto3)
        Me.Controls.Add(Me.incorrecto2)
        Me.Controls.Add(Me.correcto2)
        Me.Controls.Add(Me.incorrecto1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.correcto1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.planeta3)
        Me.Controls.Add(Me.planeta2)
        Me.Controls.Add(Me.planeta1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NdP_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Solar"
        CType(Me.planeta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.planeta2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.planeta3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.planeta_planet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.correcto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.incorrecto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.incorrecto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.incorrecto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.correcto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.correcto3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents planeta1 As System.Windows.Forms.PictureBox
    Friend WithEvents planeta2 As System.Windows.Forms.PictureBox
    Friend WithEvents planeta3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents planeta_planet As System.Windows.Forms.PictureBox
    Friend WithEvents correcto1 As PictureBox
    Friend WithEvents incorrecto2 As PictureBox
    Friend WithEvents incorrecto3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents incorrecto1 As PictureBox
    Friend WithEvents correcto2 As PictureBox
    Friend WithEvents correcto3 As PictureBox
    Friend WithEvents lbl_lifes As Label
    Friend WithEvents lbl_correcto As Label
    Friend WithEvents lbl_pregunta As Label
End Class
