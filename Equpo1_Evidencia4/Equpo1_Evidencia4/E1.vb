Public Class E1

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()      'Cierra la interfaz del Ejercicio 1
        Portada.Show()  'Abre la interfaz de la Portada (Pantalla de Inicio)
    End Sub

    Private Sub btn_Limpiar_Click_1(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        tb_num.Clear()      'Limpia el campo donde se ingresa el número
        tb_answer.Clear()   'Limpia el campo de la respuesta
        tb_num.Focus()      'El cursor se posiciona sobre el campo para ingresar el número
    End Sub

    Private Sub E1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_num.Focus()      'El cursor se posiciona sobre el campo para ingresar el número
    End Sub

    Private Sub IntBox_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_num.KeyDown

        If e.KeyCode = Keys.Enter Then  'Instrucciones que se ejecutarán al presionar la tecla ENTER

            'Se ejecuta en caso de que el campo donde se ingresa el número posea alguna de estas condiciones
            If (tb_num.Text = String.Empty) Or (Not IsNumeric(tb_num.Text)) Or (Val(tb_num.Text) < 0) Then
                MsgBox("Por favor ingrese un número entero positivo")
                btn_Limpiar_Click_1(sender, e)  'Se utiliza el procedimiento del botón Limpiar
                Exit Sub
            End If

            Dim i, x As Integer     'Se declaran las variables i, x como enteros
            x = Val(tb_num.Text)    'Se le asigna a la variable x el valor del campo donde se ingresa el número
            Dim count = 0           'Se declara la variable count y se iguala a cero
            'La variable count indicará la cantidad de veces que se puede dividir el número

            For i = 1 To x Step 1       'Estructura Repetitiva For que se repite desde i = 1 hasta el valor de x 
                If x Mod i = 0 Then     'Si el residuo de x / i es igual a cero entonces...
                    count = count + 1   'La variable count se incrementa en 1 
                End If
            Next

            If count > 2 Then 'Si la variable count es mayor a 2 se ejecutará la siguiente instrucción...
                tb_answer.Text = "El número " & x & " NO es primo" 'El número que se ingreso no es primo
            ElseIf (x = 1) Or (x = 0) Then 'En caso de que el número ingresado sea 0 o 1...
                tb_answer.Text = "El número " & x & " NO se considera primo ni compuesto"
            Else 'Si la variable count es igual a 2 se ejecutará la siguiente instrucción...
                tb_answer.Text = "El número " & x & " SI es primo" 'El número que se ingreso si es primo
            End If
        End If
    End Sub
End Class