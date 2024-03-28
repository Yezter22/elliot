<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E5))
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.panel_1 = New System.Windows.Forms.Panel()
        Me.btn_Signo = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.tb_answer = New System.Windows.Forms.TextBox()
        Me.tb_m = New System.Windows.Forms.TextBox()
        Me.tb_d = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_1
        '
        Me.lbl_1.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_1.Location = New System.Drawing.Point(0, 0)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(684, 90)
        Me.lbl_1.TabIndex = 0
        Me.lbl_1.Text = "Programa que indica el signo zodiacal al indicar el día y mes de nacimiento"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_1
        '
        Me.panel_1.BackColor = System.Drawing.Color.Beige
        Me.panel_1.Controls.Add(Me.btn_Signo)
        Me.panel_1.Controls.Add(Me.btn_Limpiar)
        Me.panel_1.Controls.Add(Me.btn_Back)
        Me.panel_1.Controls.Add(Me.tb_answer)
        Me.panel_1.Controls.Add(Me.tb_m)
        Me.panel_1.Controls.Add(Me.tb_d)
        Me.panel_1.Controls.Add(Me.Label2)
        Me.panel_1.Controls.Add(Me.Label1)
        Me.panel_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_1.Location = New System.Drawing.Point(0, 90)
        Me.panel_1.Name = "panel_1"
        Me.panel_1.Size = New System.Drawing.Size(684, 193)
        Me.panel_1.TabIndex = 1
        '
        'btn_Signo
        '
        Me.btn_Signo.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Signo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Signo.FlatAppearance.BorderSize = 10
        Me.btn_Signo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Signo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Signo.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Signo.Location = New System.Drawing.Point(267, 125)
        Me.btn_Signo.Name = "btn_Signo"
        Me.btn_Signo.Size = New System.Drawing.Size(150, 40)
        Me.btn_Signo.TabIndex = 9
        Me.btn_Signo.Text = "Mostrar Signo"
        Me.btn_Signo.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Limpiar.FlatAppearance.BorderSize = 10
        Me.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Limpiar.Location = New System.Drawing.Point(482, 125)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(150, 40)
        Me.btn_Limpiar.TabIndex = 8
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Back.FlatAppearance.BorderSize = 10
        Me.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Back.Location = New System.Drawing.Point(52, 125)
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
        Me.tb_answer.Location = New System.Drawing.Point(428, 37)
        Me.tb_answer.Multiline = True
        Me.tb_answer.Name = "tb_answer"
        Me.tb_answer.ReadOnly = True
        Me.tb_answer.Size = New System.Drawing.Size(204, 66)
        Me.tb_answer.TabIndex = 5
        '
        'tb_m
        '
        Me.tb_m.AcceptsReturn = True
        Me.tb_m.BackColor = System.Drawing.SystemColors.Info
        Me.tb_m.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_m.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_m.Location = New System.Drawing.Point(335, 77)
        Me.tb_m.MaxLength = 2
        Me.tb_m.Name = "tb_m"
        Me.tb_m.Size = New System.Drawing.Size(75, 26)
        Me.tb_m.TabIndex = 4
        '
        'tb_d
        '
        Me.tb_d.AcceptsReturn = True
        Me.tb_d.BackColor = System.Drawing.SystemColors.Info
        Me.tb_d.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_d.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_d.Location = New System.Drawing.Point(335, 37)
        Me.tb_d.MaxLength = 2
        Me.tb_d.Name = "tb_d"
        Me.tb_d.Size = New System.Drawing.Size(75, 26)
        Me.tb_d.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese su mes de nacimiento (numérico):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su día de nacimiento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'E5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 283)
        Me.Controls.Add(Me.panel_1)
        Me.Controls.Add(Me.lbl_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "E5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 5"
        Me.panel_1.ResumeLayout(False)
        Me.panel_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_1 As Label
    Friend WithEvents panel_1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_m As TextBox
    Friend WithEvents tb_d As TextBox
    Friend WithEvents tb_answer As TextBox
    Friend WithEvents btn_Signo As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_Back As Button
End Class
