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
        Me.TBcosTela = New System.Windows.Forms.TextBox()
        Me.LBcostoTela = New System.Windows.Forms.Label()
        Me.LBcostomano = New System.Windows.Forms.Label()
        Me.TBcosMano = New System.Windows.Forms.TextBox()
        Me.LBtotal = New System.Windows.Forms.Label()
        Me.TBtotal = New System.Windows.Forms.TextBox()
        Me.LBprecioventa = New System.Windows.Forms.Label()
        Me.TBprecioventa = New System.Windows.Forms.TextBox()
        Me.BTregresar = New System.Windows.Forms.Button()
        Me.GPcotizacion = New System.Windows.Forms.GroupBox()
        Me.GPcotizacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBcosTela
        '
        Me.TBcosTela.Enabled = False
        Me.TBcosTela.Location = New System.Drawing.Point(315, 53)
        Me.TBcosTela.Name = "TBcosTela"
        Me.TBcosTela.Size = New System.Drawing.Size(262, 25)
        Me.TBcosTela.TabIndex = 0
        '
        'LBcostoTela
        '
        Me.LBcostoTela.AutoSize = True
        Me.LBcostoTela.Location = New System.Drawing.Point(96, 61)
        Me.LBcostoTela.Name = "LBcostoTela"
        Me.LBcostoTela.Size = New System.Drawing.Size(216, 17)
        Me.LBcostoTela.TabIndex = 1
        Me.LBcostoTela.Text = "Costo de la Tela por Chumpa"
        '
        'LBcostomano
        '
        Me.LBcostomano.AutoSize = True
        Me.LBcostomano.Location = New System.Drawing.Point(28, 109)
        Me.LBcostomano.Name = "LBcostomano"
        Me.LBcostomano.Size = New System.Drawing.Size(284, 17)
        Me.LBcostomano.TabIndex = 3
        Me.LBcostomano.Text = "Costo de la Mano de Obra por Chumpa"
        '
        'TBcosMano
        '
        Me.TBcosMano.Enabled = False
        Me.TBcosMano.Location = New System.Drawing.Point(315, 101)
        Me.TBcosMano.Name = "TBcosMano"
        Me.TBcosMano.Size = New System.Drawing.Size(262, 25)
        Me.TBcosMano.TabIndex = 2
        '
        'LBtotal
        '
        Me.LBtotal.AutoSize = True
        Me.LBtotal.Location = New System.Drawing.Point(184, 158)
        Me.LBtotal.Name = "LBtotal"
        Me.LBtotal.Size = New System.Drawing.Size(121, 17)
        Me.LBtotal.TabIndex = 5
        Me.LBtotal.Text = "Total de Costos"
        '
        'TBtotal
        '
        Me.TBtotal.Enabled = False
        Me.TBtotal.Location = New System.Drawing.Point(315, 150)
        Me.TBtotal.Name = "TBtotal"
        Me.TBtotal.Size = New System.Drawing.Size(262, 25)
        Me.TBtotal.TabIndex = 4
        '
        'LBprecioventa
        '
        Me.LBprecioventa.AutoSize = True
        Me.LBprecioventa.Location = New System.Drawing.Point(184, 206)
        Me.LBprecioventa.Name = "LBprecioventa"
        Me.LBprecioventa.Size = New System.Drawing.Size(128, 17)
        Me.LBprecioventa.TabIndex = 7
        Me.LBprecioventa.Text = "Precio de Venta "
        '
        'TBprecioventa
        '
        Me.TBprecioventa.Enabled = False
        Me.TBprecioventa.Location = New System.Drawing.Point(315, 198)
        Me.TBprecioventa.Name = "TBprecioventa"
        Me.TBprecioventa.Size = New System.Drawing.Size(262, 25)
        Me.TBprecioventa.TabIndex = 6
        '
        'BTregresar
        '
        Me.BTregresar.Location = New System.Drawing.Point(300, 310)
        Me.BTregresar.Name = "BTregresar"
        Me.BTregresar.Size = New System.Drawing.Size(182, 36)
        Me.BTregresar.TabIndex = 8
        Me.BTregresar.Text = "Regresar al Menu"
        Me.BTregresar.UseVisualStyleBackColor = True
        '
        'GPcotizacion
        '
        Me.GPcotizacion.Controls.Add(Me.LBprecioventa)
        Me.GPcotizacion.Controls.Add(Me.TBprecioventa)
        Me.GPcotizacion.Controls.Add(Me.LBtotal)
        Me.GPcotizacion.Controls.Add(Me.TBtotal)
        Me.GPcotizacion.Controls.Add(Me.LBcostomano)
        Me.GPcotizacion.Controls.Add(Me.TBcosMano)
        Me.GPcotizacion.Controls.Add(Me.LBcostoTela)
        Me.GPcotizacion.Controls.Add(Me.TBcosTela)
        Me.GPcotizacion.Location = New System.Drawing.Point(9, 20)
        Me.GPcotizacion.Name = "GPcotizacion"
        Me.GPcotizacion.Size = New System.Drawing.Size(758, 275)
        Me.GPcotizacion.TabIndex = 9
        Me.GPcotizacion.TabStop = False
        Me.GPcotizacion.Text = "Cotizacion"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(779, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.GPcotizacion)
        Me.Controls.Add(Me.BTregresar)
        Me.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizacion"
        Me.GPcotizacion.ResumeLayout(False)
        Me.GPcotizacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBcosTela As TextBox
    Friend WithEvents LBcostoTela As Label
    Friend WithEvents LBcostomano As Label
    Friend WithEvents TBcosMano As TextBox
    Friend WithEvents LBtotal As Label
    Friend WithEvents TBtotal As TextBox
    Friend WithEvents LBprecioventa As Label
    Friend WithEvents TBprecioventa As TextBox
    Friend WithEvents BTregresar As Button
    Friend WithEvents GPcotizacion As GroupBox
End Class
