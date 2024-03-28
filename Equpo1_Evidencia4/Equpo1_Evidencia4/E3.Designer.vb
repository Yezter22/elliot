<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E3))
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.panel_1 = New System.Windows.Forms.Panel()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.tb_long = New System.Windows.Forms.TextBox()
        Me.tb_inc = New System.Windows.Forms.TextBox()
        Me.lbl_4 = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.tb_ini = New System.Windows.Forms.TextBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.tb_answer = New System.Windows.Forms.TextBox()
        Me.panel_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_1
        '
        Me.lbl_1.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_1.Location = New System.Drawing.Point(0, 0)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(806, 100)
        Me.lbl_1.TabIndex = 3
        Me.lbl_1.Text = "Programa que obtiene una serie numérica al ingresar el número inicial, el increme" &
    "nto que tendrá la serie, así como la cantidad de números de la serie"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_1
        '
        Me.panel_1.BackColor = System.Drawing.Color.Beige
        Me.panel_1.Controls.Add(Me.btn_Limpiar)
        Me.panel_1.Controls.Add(Me.tb_long)
        Me.panel_1.Controls.Add(Me.tb_inc)
        Me.panel_1.Controls.Add(Me.lbl_4)
        Me.panel_1.Controls.Add(Me.lbl_3)
        Me.panel_1.Controls.Add(Me.btn_Calcular)
        Me.panel_1.Controls.Add(Me.lbl_2)
        Me.panel_1.Controls.Add(Me.tb_ini)
        Me.panel_1.Controls.Add(Me.btn_Back)
        Me.panel_1.Controls.Add(Me.tb_answer)
        Me.panel_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_1.Location = New System.Drawing.Point(0, 100)
        Me.panel_1.Name = "panel_1"
        Me.panel_1.Size = New System.Drawing.Size(806, 221)
        Me.panel_1.TabIndex = 6
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Limpiar.FlatAppearance.BorderSize = 10
        Me.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Limpiar.Location = New System.Drawing.Point(497, 150)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(150, 40)
        Me.btn_Limpiar.TabIndex = 6
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'tb_long
        '
        Me.tb_long.AcceptsReturn = True
        Me.tb_long.BackColor = System.Drawing.SystemColors.Info
        Me.tb_long.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_long.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_long.Location = New System.Drawing.Point(379, 94)
        Me.tb_long.MaxLength = 3
        Me.tb_long.Name = "tb_long"
        Me.tb_long.Size = New System.Drawing.Size(72, 26)
        Me.tb_long.TabIndex = 4
        '
        'tb_inc
        '
        Me.tb_inc.AcceptsReturn = True
        Me.tb_inc.BackColor = System.Drawing.SystemColors.Info
        Me.tb_inc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_inc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_inc.Location = New System.Drawing.Point(379, 57)
        Me.tb_inc.MaxLength = 5
        Me.tb_inc.Name = "tb_inc"
        Me.tb_inc.Size = New System.Drawing.Size(72, 26)
        Me.tb_inc.TabIndex = 3
        '
        'lbl_4
        '
        Me.lbl_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_4.Location = New System.Drawing.Point(30, 89)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(347, 37)
        Me.lbl_4.TabIndex = 8
        Me.lbl_4.Text = "Ingrese la cantidad máxima de números de la serie:"
        Me.lbl_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_3
        '
        Me.lbl_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_3.Location = New System.Drawing.Point(30, 52)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(280, 37)
        Me.lbl_3.TabIndex = 7
        Me.lbl_3.Text = "Ingrese el incremento que tendrá la serie: "
        Me.lbl_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Calcular
        '
        Me.btn_Calcular.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_Calcular.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Calcular.FlatAppearance.BorderSize = 10
        Me.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calcular.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Calcular.Location = New System.Drawing.Point(331, 150)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(150, 40)
        Me.btn_Calcular.TabIndex = 5
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.UseVisualStyleBackColor = False
        '
        'lbl_2
        '
        Me.lbl_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.Location = New System.Drawing.Point(30, 15)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(280, 37)
        Me.lbl_2.TabIndex = 0
        Me.lbl_2.Text = "Ingrese un número inicial de la serie: "
        Me.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_ini
        '
        Me.tb_ini.AcceptsReturn = True
        Me.tb_ini.BackColor = System.Drawing.SystemColors.Info
        Me.tb_ini.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_ini.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ini.Location = New System.Drawing.Point(379, 20)
        Me.tb_ini.MaxLength = 5
        Me.tb_ini.Name = "tb_ini"
        Me.tb_ini.Size = New System.Drawing.Size(72, 26)
        Me.tb_ini.TabIndex = 2
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Back.FlatAppearance.BorderSize = 10
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Back.Location = New System.Drawing.Point(165, 150)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(150, 40)
        Me.btn_Back.TabIndex = 7
        Me.btn_Back.Text = "Regresar al Inicio"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'tb_answer
        '
        Me.tb_answer.BackColor = System.Drawing.SystemColors.Info
        Me.tb_answer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_answer.Location = New System.Drawing.Point(470, 20)
        Me.tb_answer.Multiline = True
        Me.tb_answer.Name = "tb_answer"
        Me.tb_answer.ReadOnly = True
        Me.tb_answer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_answer.Size = New System.Drawing.Size(308, 100)
        Me.tb_answer.TabIndex = 9
        Me.tb_answer.TabStop = False
        '
        'E3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 321)
        Me.Controls.Add(Me.panel_1)
        Me.Controls.Add(Me.lbl_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "E3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 3"
        Me.panel_1.ResumeLayout(False)
        Me.panel_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_1 As Label
    Friend WithEvents panel_1 As Panel
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents lbl_2 As Label
    Friend WithEvents tb_ini As TextBox
    Friend WithEvents btn_Back As Button
    Friend WithEvents tb_answer As TextBox
    Friend WithEvents lbl_3 As Label
    Friend WithEvents tb_long As TextBox
    Friend WithEvents tb_inc As TextBox
    Friend WithEvents lbl_4 As Label
    Friend WithEvents btn_Limpiar As Button
End Class
