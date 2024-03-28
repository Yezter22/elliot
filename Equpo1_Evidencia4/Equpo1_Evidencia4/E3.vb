Public Class E3

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()      'Cierra la interfaz del Ejercicio 3
        Portada.Show()  'Abre la interfaz de la Portada (Pantalla de Inicio)
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        tb_ini.Clear()      'Limpia el campo donde se ingresa el número inicial
        tb_inc.Clear()      'Limpia el campo donde se ingresa el incremento de la serie
        tb_long.Clear()     'Limpia el campo donde se ingresa la cantidad de elementos de la serie
        tb_answer.Clear()   'Limpia el campo donde se muestra la serie numérica
        tb_ini.Focus()      'El cursor se posiciona sobre el campo para ingresar el número inicial
    End Sub

    Private Sub E3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_ini.Focus()      'El cursor se posiciona sobre el campo para ingresar el número inicial
    End Sub

    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click

        'Se ejecuta si el campo del número inicial posee alguna de estas condiciones
        'El campo esta vacío o el dato que se capturó no es un número
        If (tb_ini.Text = String.Empty) Or (Not IsNumeric(tb_ini.Text)) Then
            MsgBox("Por favor ingrese el número inicial de la serie")
            tb_ini.Clear()
            tb_answer.Clear()
            tb_ini.Focus()
            Exit Sub
        End If

        'Se ejecuta si el campo del incremento de la serie posee alguna de estas condiciones
        'El campo esta vacío o el dato que se capturó no es un número
        If (tb_inc.Text = String.Empty) Or (Not IsNumeric(tb_inc.Text)) Then
            MsgBox("Por favor introduzca el incremento que tendrá la serie")
            tb_inc.Clear()
            tb_answer.Clear()
            tb_inc.Focus()
            Exit Sub
        End If

        'Se ejecuta si el campo de la longitud de la serie posee alguna de estas condiciones
        'El campo esta vacío o el dato que se capturó no es un número o el número que se capturo es menor a 1
        If (tb_long.Text = String.Empty) Or (Not IsNumeric(tb_long.Text)) Or (Val(tb_long.Text) < 1) Then
            MsgBox("Por favor introduzca la cantidad de elementos que tendrá la serie")
            tb_long.Clear()
            tb_answer.Clear()
            tb_long.Focus()
            Exit Sub
        End If

        Dim i, x, y, z As Integer   'Se declaran las variables, i, x, y, z como enteros
        Dim serie = 0               'Se declara la variable serie y se le asigna el valor de cero
        x = tb_ini.Text             'Se le asigna a la variable x el valor del número inicial de la serie
        y = tb_inc.Text             'Se le asgina a la variable y el valor del incremento de la serie
        z = tb_long.Text            'Se le asigna a la variable z el valor de la longitud de la serie
        tb_answer.Clear()           'Se limpia el campo de la respuesta, si es que estaba lleno

        For i = 1 To z Step 1       'Estructura Repetitiva For que se repite desde i=1 hasta el valor de z
            If i = z Then           'Si el valor de i es igual al valor de z entonces...
                tb_answer.Text = tb_answer.Text & x & ". "  'Se agrega el último elemento de la serie
            Else                                            'De lo contrario...
                tb_answer.Text = tb_answer.Text & x & ", "  'Se agrega un elemento más a la serie
            End If
            serie = x + y   'La variable serie sera igual a la suma de x + y
            x = serie       'La variable x tomará el valor de la variable serie
        Next
    End Sub
End Class
