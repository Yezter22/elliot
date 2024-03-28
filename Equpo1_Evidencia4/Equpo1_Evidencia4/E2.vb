Public Class E2

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()      'Cierra la interfaz del Ejercicio 2
        Portada.Show()  'Abre la interfaz de la Portada (Pantalla de Inicio)
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        tb_num.Clear()              'Limpia el campo donde se ingresa el número
        list_answer.Items.Clear()   'Limpia el campo de la respuesta
        tb_num.Focus()              'El cursor se posiciona sobre el campo para ingresar el número
    End Sub

    Private Sub E2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_num.Focus()  'El cursor se posiciona sobre el campo para ingresar el número
    End Sub

    Private Sub IntBox_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_num.KeyDown

        If e.KeyCode = Keys.Enter Then  'Instrucciones que se ejecutarán al presionar la tecla ENTER

            'Se ejecuta en caso de que el campo donde se ingresa el número posea alguna de estas condiciones
            If (tb_num.Text = String.Empty) Or (Not IsNumeric(tb_num.Text)) Or (Val(tb_num.Text) < 0) Then
                MsgBox("Por favor ingrese un número entero positivo")
                btn_Limpiar_Click(sender, e)  'Se utiliza el procedimiento del botón Limpiar
                Exit Sub
            End If

            Dim i, x As Integer 'Se declaran las variables i, x como enteros
            x = Val(tb_num.Text) 'Se le asigna a la variable x el valor del campo donde se ingresa el número
            list_answer.Items.Clear() 'Se limpia el campo de respuesta si es que estaba lleno

            For i = 1 To 10 'Estructura Repetitiva For que se repite desde i = 1 hasta 10
                'Se agregan valores a la respuesta hasta que termina el ciclo For
                list_answer.Items.Add(x & " x " & i & " = " & x * i)
            Next
        End If
    End Sub
End Class
