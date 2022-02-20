
Imports System.Math
Module Module1
    'creamos nuestras constantes de precios de la mano de obra que utilizaremos a lo largo del programa 
    Public Const MAsmall As Double = 65.5
    Public Const MAmediano As Double = 85.99
    Public Const MAlargo As Double = 99.99
    'creamos nuestras constantes de precios que utilizaremos a lo largo del programa 
    Public Const PRalgodon As Double = 15.0
    Public Const PRseda As Double = 23.99
    Public Const PRlona As Double = 30.99
    'creamos nuestras constantes de las yardas necesarias para crear cada tamaño de chumpa
    Public Const YARsmall As Double = 2
    Public Const YARmediano As Double = 2.5
    Public Const YARlargo As Double = 3
    'crearemos unas variables donde se gurdaran ciertas operaciones
    Public Const Ganancia As Double = 0.65
    Dim CosTela As Double
    Dim ManodeObra As Double
    Dim Venta As Double
    Dim TotalCost As Double


    Public Sub Calcular()
        'verificamos cada una de las combinaciones cuanqdo se quiera crear una chumpa pequeña dependiendo del tipo de tela a utilizar en la fabricaion
        If ((Form1.RBpequenio.Checked = True) And (Form1.RBalgodon.Checked = True)) Then
            'calculamos los costos para fabricar una chumpa y valuamos que sean numeros
            CosTela = Val(PRalgodon * YARsmall)
            Form2.TBcosTela.Text = Round(CosTela, 2)
            'calculamos los costos de la mano de obra y lo mandaremos al formulario 2 y de paso validamos que sea valor numerico
            ManodeObra = Val(MAsmall)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)
            'calculamos el total de costos
            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)
            'calculamos el precio de venta 
            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)

        ElseIf (Form1.RBpequenio.Checked = True) And (Form1.RBseda.Checked = True) Then
            CosTela = Val(PRseda * YARsmall)
            Form2.TBcosTela.Text = Round(CosTela, 2)

            ManodeObra = Val(MAsmall)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)

            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)

            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)

        ElseIf (Form1.RBpequenio.Checked = True) And (Form1.RBlona.Checked = True) Then
            CosTela = Val(PRlona * YARsmall)
            Form2.TBcosTela.Text = Round(CosTela, 2)

            ManodeObra = Val(MAsmall)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)

            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)

            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)


        End If

        'verificamos cada una de las combinaciones cuanqdo se quiera crear una chumpa mediana dependiendo del tipo de tela a utilizar en la fabricaion
        If ((Form1.RBmediano.Checked = True) And (Form1.RBalgodon.Checked = True)) Then

            CosTela = Val(PRalgodon * YARmediano)
            Form2.TBcosTela.Text = Round(CosTela, 2)

            ManodeObra = Val(MAmediano)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)

            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)

            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)

        ElseIf (Form1.RBmediano.Checked = True) And (Form1.RBseda.Checked = True) Then
            CosTela = Val(PRseda * YARmediano)
            Form2.TBcosTela.Text = Round(CosTela, 2)

            ManodeObra = Val(MAmediano)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)

            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)

            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)

        ElseIf (Form1.RBmediano.Checked = True) And (Form1.RBlona.Checked = True) Then
            CosTela = Val(PRlona * YARmediano)
            Form2.TBcosTela.Text = Round(CosTela, 2)

            ManodeObra = Val(MAmediano)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)

            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)

            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)


        End If


        'verificamos cada una de las combinaciones cuanqdo se quiera crear una chumpa laarga dependiendo del tipo de tela a utilizar en la fabricaion
        If ((Form1.RBlargo.Checked = True) And (Form1.RBalgodon.Checked = True)) Then

            CosTela = Val(PRalgodon * YARlargo)
            Form2.TBcosTela.Text = Round(CosTela, 2)

            ManodeObra = Val(MAlargo)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)

            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)

            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)

        ElseIf (Form1.RBlargo.Checked = True) And (Form1.RBseda.Checked = True) Then
            CosTela = Val(PRseda * YARlargo)
            Form2.TBcosTela.Text = Round(CosTela, 2)

            ManodeObra = Val(MAlargo)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)

            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)

            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)

        ElseIf (Form1.RBlargo.Checked = True) And (Form1.RBlona.Checked = True) Then
            CosTela = Val(PRlona * YARlargo)
            Form2.TBcosTela.Text = Round(CosTela, 2)

            ManodeObra = Val(MAlargo)
            Form2.TBcosMano.Text = Round(ManodeObra, 2)

            TotalCost = Val((Form1.TBChumpas.Text) * CosTela + (Form1.TBChumpas.Text) * ManodeObra)
            Form2.TBtotal.Text = Round(TotalCost, 2)

            Venta = Val((ManodeObra + CosTela) * Ganancia + (ManodeObra + CosTela))
            Form2.TBprecioventa.Text = Round(Venta, 2)


        End If


    End Sub


    Public Sub Limpieza()
        Form1.TBChumpas.Text = 0
        Form1.RBalgodon.Checked = 0
        Form1.RBlona.Checked = 0
        Form1.RBseda.Checked = 0
        Form1.RBpequenio.Checked = 0
        Form1.RBmediano.Checked = 0
        Form1.RBlargo.Checked = 0
        Form2.TBtotal.Text = 0
        Form2.TBprecioventa.Text = 0
        Form2.TBcosTela.Text = 0
        Form2.TBcosMano.Text = 0
        Form1.TBChumpas.Focus()
    End Sub



End Module
