<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E1))
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.tb_num = New System.Windows.Forms.TextBox()
        Me.tb_answer = New System.Windows.Forms.TextBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.panel_1 = New System.Windows.Forms.Panel()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.panel_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_2
        '
        Me.lbl_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.Location = New System.Drawing.Point(15, 13)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(226, 49)
        Me.lbl_2.TabIndex = 0
        Me.lbl_2.Text = "Ingrese un número entero y después presione la tecla ENTER:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_1
        '
        Me.lbl_1.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_1.Location = New System.Drawing.Point(0, 0)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(384, 83)
        Me.lbl_1.TabIndex = 1
        Me.lbl_1.Text = "Programa que indica si el número ingresado es primo o no"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_num
        '
        Me.tb_num.AcceptsReturn = True
        Me.tb_num.BackColor = System.Drawing.SystemColors.Info
        Me.tb_num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_num.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_num.Location = New System.Drawing.Point(247, 25)
        Me.tb_num.MaxLength = 5
        Me.tb_num.Name = "tb_num"
        Me.tb_num.Size = New System.Drawing.Size(112, 26)
        Me.tb_num.TabIndex = 2
        '
        'tb_answer
        '
        Me.tb_answer.BackColor = System.Drawing.SystemColors.Info
        Me.tb_answer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_answer.Location = New System.Drawing.Point(15, 74)
        Me.tb_answer.Name = "tb_answer"
        Me.tb_answer.ReadOnly = True
        Me.tb_answer.Size = New System.Drawing.Size(357, 26)
        Me.tb_answer.TabIndex = 3
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
        Me.btn_Back.Location = New System.Drawing.Point(15, 116)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(150, 40)
        Me.btn_Back.TabIndex = 4
        Me.btn_Back.Text = "Regresar al Inicio"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'panel_1
        '
        Me.panel_1.BackColor = System.Drawing.Color.Beige
        Me.panel_1.Controls.Add(Me.btn_Limpiar)
        Me.panel_1.Controls.Add(Me.lbl_2)
        Me.panel_1.Controls.Add(Me.tb_num)
        Me.panel_1.Controls.Add(Me.btn_Back)
        Me.panel_1.Controls.Add(Me.tb_answer)
        Me.panel_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_1.Location = New System.Drawing.Point(0, 83)
        Me.panel_1.Name = "panel_1"
        Me.panel_1.Size = New System.Drawing.Size(384, 178)
        Me.panel_1.TabIndex = 5
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Limpiar.FlatAppearance.BorderSize = 10
        Me.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Limpiar.Location = New System.Drawing.Point(222, 116)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(150, 40)
        Me.btn_Limpiar.TabIndex = 6
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'E1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.panel_1)
        Me.Controls.Add(Me.lbl_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "E1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 1"
        Me.panel_1.ResumeLayout(False)
        Me.panel_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_2 As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents tb_num As TextBox
    Friend WithEvents tb_answer As TextBox
    Friend WithEvents btn_Back As Button
    Friend WithEvents panel_1 As Panel
    Friend WithEvents btn_Limpiar As Button
End Class
