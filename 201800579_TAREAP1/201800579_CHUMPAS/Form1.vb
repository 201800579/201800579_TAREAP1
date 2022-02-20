Public Class Form1

    'llamaremos a nuestro metodo de calcular que se encuentra alojado en nuestro module y algunas validaciones
    Private Sub BTcalcular_Click(sender As Object, e As EventArgs) Handles BTcalcular.Click
        'primero validaremos que se haya ingresado una cantidad mayor que 0 de chumpar para que nos lleve al metodo
        'y si en caso la cantidad no es valida mostraremos un mensaje
        If TBChumpas.Text = "0" Then
            MsgBox("Usted no ha ingresado una cantidad Valida de Chumpas")
            TBChumpas.Focus()
        Else
            'validamos que se seleccione al menos una de las opciones de tamaño disponibles
            If ((RBpequenio.Checked = True) Or (RBmediano.Checked = True) Or (RBlargo.Checked = True)) Then
                'validamos que se seleccion el tipo de material del cual se fabricara la chumpa y si es verdadero iremos al metodo calcular
                If ((RBalgodon.Checked = True) Or (RBseda.Checked = True) Or (RBlona.Checked = True)) Then
                    Calcular()
                    Me.Hide()
                    Form2.Show()
                Else
                    MsgBox("Usted no ha Seleccionado un TIPO de tela para la Chumpa a Fabricar")
                    TBChumpas.Focus()
                End If

            Else
                MsgBox("Usted no ha Seleccionado un TAMAÑO para la Chumpa a Fabricar")
                TBChumpas.Focus()
            End If

        End If
    End Sub

    'llamaremos a nuestro metodo de calcular que se encuentra alojado en nuestro module y verificamos que en verdad el usuario quiera limpiar los datos ingresados
    Private Sub BTlimpiar_Click(sender As Object, e As EventArgs) Handles BTlimpiar.Click
        If MsgBox("¿Desea Limpiar las Casillas?", vbQuestion + vbYesNo, "Limpieza") = vbYes Then
            Limpieza()
        End If
    End Sub

    'mostraremos un mensaje de salida para que el usuario salga de forma segura de la interfaz
    Private Sub BTsalir_Click(sender As Object, e As EventArgs) Handles BTsalir.Click
        If MsgBox("¿Desea Salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Close()
        Else
            Limpieza()
        End If
    End Sub

    'validamos que solo se puedan ingresar cantidades numericas a nuestro text box de cantidad de chumpas 
    Private Sub TBChumpas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBChumpas.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
