Public Class E5

    Private Sub btn_Back_Click_1(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()      'Cierra la interfaz del Ejercicio 5
        Portada.Show()  'Abre la interfaz de la Portada (Pantalla de Inicio)
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        tb_d.Clear()        'Limpia el campo donde se ingresa el día
        tb_m.Clear()        'Limpia el campo donde se ingresa el mes
        tb_answer.Clear()   'Limpia el campo donde se muestra el signo zodiacal
        tb_d.Focus()        'El cursor se posiciona sobre el campo para ingresar el día
    End Sub

    Private Sub E5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_d.Focus()    'El cursor se posiciona sobre el campo para ingresar el día
    End Sub

    Private Sub btn_Signo_Click(sender As Object, e As EventArgs) Handles btn_Signo.Click

        'Se ejecuta si el campo del día posee alguna de estas condiciones
        'El campo esta vacío o el dato que se capturó no es un número
        'o el número que se capturo es mayor a 31 o menor a 1
        If (tb_d.Text = String.Empty) Or (Not IsNumeric(tb_d.Text)) Or (Val(tb_d.Text) > 31 Or Val(tb_d.Text) < 1) Then
            MsgBox("Por favor introduzca un día de nacimiento válido")
            btn_Limpiar_Click(sender, e)    'Se utiliza el procedimiento del botón Limpiar
            tb_d.Focus()
            Exit Sub
        End If

        'Se ejecuta si el campo del mes posee alguna de estas condiciones
        'El campo esta vacío o el dato que se capturó no es un número
        'o el número que se capturo es mayor a 12 o menor a 1
        If (tb_m.Text = String.Empty) Or (Not IsNumeric(tb_m.Text)) Or (Val(tb_m.Text) > 12 Or Val(tb_m.Text) < 1) Then
            MsgBox("Por favor introduzca un mes de nacimiento válido")
            btn_Limpiar_Click(sender, e)    'Se utiliza el procedimiento del botón Limpiar
            tb_m.Focus()
            Exit Sub
        End If

        Dim d, m As Integer     'Se declaran las variables d, m como enteros
        d = Val(tb_d.Text)      'A la variable d se le asigna el valor del día
        m = Val(tb_m.Text)      'A la variable m se le asgina el valor del mes

        If (d >= 21 And m = 3) Or (d <= 19 And m = 4) Then          'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: ARIES"          'El signo es ARIES
        ElseIf (d >= 20 And m = 4) Or (d <= 20 And m = 5) Then      'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: TAURO"          'El signo es TAURO
        ElseIf (d >= 21 And m = 5) Or (d <= 20 And m = 6) Then      'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: GEMINIS"        'El signo es GEMINIS
        ElseIf (d >= 21 And m = 6) Or (d <= 22 And m = 7) Then      'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: CANCER"         'El signo es CANCER
        ElseIf (d >= 23 And m = 7) Or (d <= 22 And m = 8) Then      'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: LEO"            'El signo es LEO
        ElseIf (d >= 23 And m = 8) Or (d <= 22 And m = 9) Then      'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: VIRGO"          'El signo es VIRGO
        ElseIf (d >= 23 And m = 9) Or (d <= 22 And m = 10) Then     'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: LIBRA"          'El signo es LIBRA
        ElseIf (d >= 23 And m = 10) Or (d <= 21 And m = 11) Then    'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: ESCORPIO"       'El signo es ESCORPIO
        ElseIf (d >= 22 And m = 11) Or (d <= 21 And m = 12) Then    'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: SAGITARIO"      'El signo es SAGITARIO
        ElseIf (d >= 22 And m = 12) Or (d <= 19 And m = 1) Then     'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: CAPRICORNIO"    'El signo es CAPRICORNIO
        ElseIf (d >= 20 And m = 1) Or (d <= 18 And m = 2) Then      'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: ACUARIO"        'El signo es ACUARIO
        ElseIf (d >= 19 And m = 2) Or (d <= 20 And m = 3) Then      'Si se cumple esta condición...
            tb_answer.Text = "Su signo zodiacal es: PISCIS"         'El signo es PISCIS
        End If

    End Sub
End Class