Public Class E4

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()          'Cierra la interfaz del Ejercicio 4
        Portada.Show()      'Abre la interfaz de la Portada (Pantalla de Inicio)
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        tb_compra.Clear()       'Limpia el campo donde se ingresa el valor de la compra
        tb_p.Clear()            'Limpia el campo donde se muestra el porcentaje de descuento
        tb_desc.Clear()         'Limpia el campo donde se muestra el valor del descuento
        tb_sub.Clear()          'Limpia el campo donde se muestra el subtotal de la compra
        tb_IVA.Clear()          'Limpia el campo donde se muestra el valor del IVA
        tb_total.Clear()        'Limpia el campo donde se muestra el total de la compra
        tb_compra.Focus()       'El cursor se posiciona sobre el campo para ingresar el valor de la compra
    End Sub

    Private Sub E4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_compra.Focus()       'El cursor se posiciona sobre el campo para ingresar el valor de la compra
    End Sub

    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click

        'Se ejecuta en caso de que al ingresa el valor de la compra se cumpla alguna de estas condiciones:
        'El campo esta vacío o el campo no es numérica o el valor es menor a cero (negativo)
        If (tb_compra.Text = String.Empty) Or (Not IsNumeric(tb_compra.Text)) Or (Val(tb_compra.Text) < 0) Then
            MsgBox("Por favor ingrese el valor de la compra")
            btn_Limpiar_Click(sender, e)  'Se utiliza el procedimiento del botón Limpiar
            Exit Sub
        End If

        Dim a As Integer                            'Se declara la variable a como entero
        Dim b, desc, subt, IVA, total As Double     'Se declaran las variables como double
        a = tb_compra.Text                          'Se le asigna a la variable a el valor de la compra

        If (a >= 1000 And a <= 999999) Then     'El valor de la compra debe estar entre 1,000 y 999,999
            b = Math.Round(Rnd(), 2)            'Función para asignar un porcentaje de descuento aleatorio
            desc = a * b                        'Se calcula el valor del descuento
            subt = a - desc                     'Se calcula el valor del subtotal
            IVA = (Math.Round(subt * 0.16, 2))  'Se calcula el valor del IVA y se redondea a 2 decimales
            total = (Math.Round(subt + IVA, 2)) 'Se calcula el total de la compra y se redondea a 2 decimales
            tb_p.Text = b * 100 & "%"           'Se coloca el porcentaje de descuento en su campo
            tb_desc.Text = "$" & desc           'Se coloca el valor de descuento en su campo
            tb_sub.Text = "$" & subt            'Se coloca el valor del subtotal en su campo
            tb_IVA.Text = "$" & IVA             'Se coloca el valor del IVA en su campo
            tb_total.Text = "$" & total         'Se coloca el valor del total en su campo

            'Esta instrucción se ejecuta si el valor de la compra...
            'Es menor a 1,000 o mayor a 999,999
        ElseIf (a < 1000 Or a > 999999) Then
            MsgBox("El valor de la compra debe estar entre $1,000 y $999,999")
            btn_Limpiar_Click(sender, e)  'Se utiliza el procedimiento del botón Limpiar
            tb_compra.Focus()
            Exit Sub
        End If

    End Sub
End Class