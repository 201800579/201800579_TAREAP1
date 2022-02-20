<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LBChumpas = New System.Windows.Forms.Label()
        Me.TBChumpas = New System.Windows.Forms.TextBox()
        Me.GPtamaños = New System.Windows.Forms.GroupBox()
        Me.RBlargo = New System.Windows.Forms.RadioButton()
        Me.RBmediano = New System.Windows.Forms.RadioButton()
        Me.RBpequenio = New System.Windows.Forms.RadioButton()
        Me.GPtelas = New System.Windows.Forms.GroupBox()
        Me.RBlona = New System.Windows.Forms.RadioButton()
        Me.RBalgodon = New System.Windows.Forms.RadioButton()
        Me.RBseda = New System.Windows.Forms.RadioButton()
        Me.BTcalcular = New System.Windows.Forms.Button()
        Me.BTlimpiar = New System.Windows.Forms.Button()
        Me.BTsalir = New System.Windows.Forms.Button()
        Me.GPtamaños.SuspendLayout()
        Me.GPtelas.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBChumpas
        '
        Me.LBChumpas.AutoSize = True
        Me.LBChumpas.Location = New System.Drawing.Point(164, 65)
        Me.LBChumpas.Name = "LBChumpas"
        Me.LBChumpas.Size = New System.Drawing.Size(170, 17)
        Me.LBChumpas.TabIndex = 0
        Me.LBChumpas.Text = "Cantidad de Chumpas "
        '
        'TBChumpas
        '
        Me.TBChumpas.Location = New System.Drawing.Point(352, 62)
        Me.TBChumpas.Name = "TBChumpas"
        Me.TBChumpas.Size = New System.Drawing.Size(229, 25)
        Me.TBChumpas.TabIndex = 1
        Me.TBChumpas.Text = "0"
        '
        'GPtamaños
        '
        Me.GPtamaños.Controls.Add(Me.RBlargo)
        Me.GPtamaños.Controls.Add(Me.RBmediano)
        Me.GPtamaños.Controls.Add(Me.RBpequenio)
        Me.GPtamaños.Location = New System.Drawing.Point(172, 132)
        Me.GPtamaños.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPtamaños.Name = "GPtamaños"
        Me.GPtamaños.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPtamaños.Size = New System.Drawing.Size(162, 150)
        Me.GPtamaños.TabIndex = 2
        Me.GPtamaños.TabStop = False
        Me.GPtamaños.Text = "Tamaño Chumpas"
        '
        'RBlargo
        '
        Me.RBlargo.AutoSize = True
        Me.RBlargo.Location = New System.Drawing.Point(30, 100)
        Me.RBlargo.Name = "RBlargo"
        Me.RBlargo.Size = New System.Drawing.Size(67, 21)
        Me.RBlargo.TabIndex = 2
        Me.RBlargo.TabStop = True
        Me.RBlargo.Text = "Large"
        Me.RBlargo.UseVisualStyleBackColor = True
        '
        'RBmediano
        '
        Me.RBmediano.AutoSize = True
        Me.RBmediano.Location = New System.Drawing.Point(30, 69)
        Me.RBmediano.Name = "RBmediano"
        Me.RBmediano.Size = New System.Drawing.Size(84, 21)
        Me.RBmediano.TabIndex = 1
        Me.RBmediano.TabStop = True
        Me.RBmediano.Text = "Medium"
        Me.RBmediano.UseVisualStyleBackColor = True
        '
        'RBpequenio
        '
        Me.RBpequenio.AutoSize = True
        Me.RBpequenio.Location = New System.Drawing.Point(30, 42)
        Me.RBpequenio.Name = "RBpequenio"
        Me.RBpequenio.Size = New System.Drawing.Size(68, 21)
        Me.RBpequenio.TabIndex = 0
        Me.RBpequenio.TabStop = True
        Me.RBpequenio.Text = "Small"
        Me.RBpequenio.UseVisualStyleBackColor = True
        '
        'GPtelas
        '
        Me.GPtelas.Controls.Add(Me.RBlona)
        Me.GPtelas.Controls.Add(Me.RBalgodon)
        Me.GPtelas.Controls.Add(Me.RBseda)
        Me.GPtelas.Location = New System.Drawing.Point(419, 132)
        Me.GPtelas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPtelas.Name = "GPtelas"
        Me.GPtelas.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPtelas.Size = New System.Drawing.Size(162, 150)
        Me.GPtelas.TabIndex = 3
        Me.GPtelas.TabStop = False
        Me.GPtelas.Text = "Tipos de Tela"
        '
        'RBlona
        '
        Me.RBlona.AutoSize = True
        Me.RBlona.Location = New System.Drawing.Point(37, 100)
        Me.RBlona.Name = "RBlona"
        Me.RBlona.Size = New System.Drawing.Size(61, 21)
        Me.RBlona.TabIndex = 5
        Me.RBlona.TabStop = True
        Me.RBlona.Text = "Lona"
        Me.RBlona.UseVisualStyleBackColor = True
        '
        'RBalgodon
        '
        Me.RBalgodon.AutoSize = True
        Me.RBalgodon.Location = New System.Drawing.Point(37, 42)
        Me.RBalgodon.Name = "RBalgodon"
        Me.RBalgodon.Size = New System.Drawing.Size(86, 21)
        Me.RBalgodon.TabIndex = 3
        Me.RBalgodon.TabStop = True
        Me.RBalgodon.Text = "Algodon"
        Me.RBalgodon.UseVisualStyleBackColor = True
        '
        'RBseda
        '
        Me.RBseda.AutoSize = True
        Me.RBseda.Location = New System.Drawing.Point(37, 69)
        Me.RBseda.Name = "RBseda"
        Me.RBseda.Size = New System.Drawing.Size(62, 21)
        Me.RBseda.TabIndex = 4
        Me.RBseda.TabStop = True
        Me.RBseda.Text = "Seda"
        Me.RBseda.UseVisualStyleBackColor = True
        '
        'BTcalcular
        '
        Me.BTcalcular.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BTcalcular.Location = New System.Drawing.Point(98, 314)
        Me.BTcalcular.Name = "BTcalcular"
        Me.BTcalcular.Size = New System.Drawing.Size(162, 36)
        Me.BTcalcular.TabIndex = 4
        Me.BTcalcular.Text = "Calcular"
        Me.BTcalcular.UseVisualStyleBackColor = False
        '
        'BTlimpiar
        '
        Me.BTlimpiar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BTlimpiar.Location = New System.Drawing.Point(289, 314)
        Me.BTlimpiar.Name = "BTlimpiar"
        Me.BTlimpiar.Size = New System.Drawing.Size(162, 36)
        Me.BTlimpiar.TabIndex = 5
        Me.BTlimpiar.Text = "Limpiar"
        Me.BTlimpiar.UseVisualStyleBackColor = False
        '
        'BTsalir
        '
        Me.BTsalir.BackColor = System.Drawing.Color.Salmon
        Me.BTsalir.Location = New System.Drawing.Point(481, 314)
        Me.BTsalir.Name = "BTsalir"
        Me.BTsalir.Size = New System.Drawing.Size(162, 36)
        Me.BTsalir.TabIndex = 6
        Me.BTsalir.Text = "Salir"
        Me.BTsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(772, 448)
        Me.Controls.Add(Me.BTsalir)
        Me.Controls.Add(Me.BTlimpiar)
        Me.Controls.Add(Me.BTcalcular)
        Me.Controls.Add(Me.GPtelas)
        Me.Controls.Add(Me.GPtamaños)
        Me.Controls.Add(Me.TBChumpas)
        Me.Controls.Add(Me.LBChumpas)
        Me.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHUMPAS S.A."
        Me.GPtamaños.ResumeLayout(False)
        Me.GPtamaños.PerformLayout()
        Me.GPtelas.ResumeLayout(False)
        Me.GPtelas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LBChumpas As Label
    Friend WithEvents TBChumpas As TextBox
    Friend WithEvents GPtamaños As GroupBox
    Friend WithEvents RBlargo As RadioButton
    Friend WithEvents RBmediano As RadioButton
    Friend WithEvents RBpequenio As RadioButton
    Friend WithEvents GPtelas As GroupBox
    Friend WithEvents RBlona As RadioButton
    Friend WithEvents RBalgodon As RadioButton
    Friend WithEvents RBseda As RadioButton
    Friend WithEvents BTcalcular As Button
    Friend WithEvents BTlimpiar As Button
    Friend WithEvents BTsalir As Button
End Class
