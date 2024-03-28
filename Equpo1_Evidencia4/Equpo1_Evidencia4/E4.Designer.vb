<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E4))
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.panel_1 = New System.Windows.Forms.Panel()
        Me.tb_sub = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.tb_IVA = New System.Windows.Forms.TextBox()
        Me.tb_desc = New System.Windows.Forms.TextBox()
        Me.lbl_6 = New System.Windows.Forms.Label()
        Me.lbl_5 = New System.Windows.Forms.Label()
        Me.lbl_4 = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.tb_p = New System.Windows.Forms.TextBox()
        Me.tb_compra = New System.Windows.Forms.TextBox()
        Me.lbl_2 = New System.Windows.Forms.Label()
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
        Me.lbl_1.Size = New System.Drawing.Size(802, 109)
        Me.lbl_1.TabIndex = 1
        Me.lbl_1.Text = "Programa que calcula el porcentaje de descuento en base al valor de la compra y m" &
    "uestra el porcentaje obtenido, el valor del descuento, el IVA y el total de la c" &
    "ompra"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_1
        '
        Me.panel_1.BackColor = System.Drawing.Color.Beige
        Me.panel_1.Controls.Add(Me.tb_sub)
        Me.panel_1.Controls.Add(Me.Label1)
        Me.panel_1.Controls.Add(Me.tb_total)
        Me.panel_1.Controls.Add(Me.tb_IVA)
        Me.panel_1.Controls.Add(Me.tb_desc)
        Me.panel_1.Controls.Add(Me.lbl_6)
        Me.panel_1.Controls.Add(Me.lbl_5)
        Me.panel_1.Controls.Add(Me.lbl_4)
        Me.panel_1.Controls.Add(Me.lbl_3)
        Me.panel_1.Controls.Add(Me.btn_Calcular)
        Me.panel_1.Controls.Add(Me.btn_Limpiar)
        Me.panel_1.Controls.Add(Me.btn_Back)
        Me.panel_1.Controls.Add(Me.tb_p)
        Me.panel_1.Controls.Add(Me.tb_compra)
        Me.panel_1.Controls.Add(Me.lbl_2)
        Me.panel_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_1.Location = New System.Drawing.Point(0, 109)
        Me.panel_1.Name = "panel_1"
        Me.panel_1.Size = New System.Drawing.Size(802, 295)
        Me.panel_1.TabIndex = 2
        '
        'tb_sub
        '
        Me.tb_sub.AcceptsReturn = True
        Me.tb_sub.BackColor = System.Drawing.SystemColors.Info
        Me.tb_sub.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_sub.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_sub.Location = New System.Drawing.Point(323, 170)
        Me.tb_sub.MaxLength = 10
        Me.tb_sub.Name = "tb_sub"
        Me.tb_sub.ReadOnly = True
        Me.tb_sub.Size = New System.Drawing.Size(112, 26)
        Me.tb_sub.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 40)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Subtotal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_total
        '
        Me.tb_total.AcceptsReturn = True
        Me.tb_total.BackColor = System.Drawing.SystemColors.Info
        Me.tb_total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_total.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total.Location = New System.Drawing.Point(645, 127)
        Me.tb_total.MaxLength = 10
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(112, 26)
        Me.tb_total.TabIndex = 16
        '
        'tb_IVA
        '
        Me.tb_IVA.AcceptsReturn = True
        Me.tb_IVA.BackColor = System.Drawing.SystemColors.Info
        Me.tb_IVA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_IVA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_IVA.Location = New System.Drawing.Point(645, 85)
        Me.tb_IVA.MaxLength = 10
        Me.tb_IVA.Name = "tb_IVA"
        Me.tb_IVA.ReadOnly = True
        Me.tb_IVA.Size = New System.Drawing.Size(112, 26)
        Me.tb_IVA.TabIndex = 15
        '
        'tb_desc
        '
        Me.tb_desc.AcceptsReturn = True
        Me.tb_desc.BackColor = System.Drawing.SystemColors.Info
        Me.tb_desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_desc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_desc.Location = New System.Drawing.Point(323, 126)
        Me.tb_desc.MaxLength = 10
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.ReadOnly = True
        Me.tb_desc.Size = New System.Drawing.Size(112, 26)
        Me.tb_desc.TabIndex = 14
        '
        'lbl_6
        '
        Me.lbl_6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_6.Location = New System.Drawing.Point(476, 119)
        Me.lbl_6.Name = "lbl_6"
        Me.lbl_6.Size = New System.Drawing.Size(163, 40)
        Me.lbl_6.TabIndex = 13
        Me.lbl_6.Text = "Total de la compra:"
        Me.lbl_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_5
        '
        Me.lbl_5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_5.Location = New System.Drawing.Point(476, 77)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(163, 40)
        Me.lbl_5.TabIndex = 12
        Me.lbl_5.Text = "Valor del IVA:"
        Me.lbl_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_4
        '
        Me.lbl_4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_4.Location = New System.Drawing.Point(144, 118)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(173, 40)
        Me.lbl_4.TabIndex = 11
        Me.lbl_4.Text = "Valor del descuento:"
        Me.lbl_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_3
        '
        Me.lbl_3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_3.Location = New System.Drawing.Point(39, 78)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(278, 40)
        Me.lbl_3.TabIndex = 10
        Me.lbl_3.Text = "Porcentaje de descuento aplicado:"
        Me.lbl_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Calcular
        '
        Me.btn_Calcular.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Calcular.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Calcular.FlatAppearance.BorderSize = 10
        Me.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calcular.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Calcular.Location = New System.Drawing.Point(323, 230)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(150, 40)
        Me.btn_Calcular.TabIndex = 9
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Limpiar.FlatAppearance.BorderSize = 10
        Me.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Limpiar.Location = New System.Drawing.Point(503, 230)
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
        Me.btn_Back.Location = New System.Drawing.Point(134, 230)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(150, 40)
        Me.btn_Back.TabIndex = 7
        Me.btn_Back.Text = "Regresar al Inicio"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'tb_p
        '
        Me.tb_p.AcceptsReturn = True
        Me.tb_p.BackColor = System.Drawing.SystemColors.Info
        Me.tb_p.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_p.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_p.Location = New System.Drawing.Point(323, 85)
        Me.tb_p.MaxLength = 10
        Me.tb_p.Name = "tb_p"
        Me.tb_p.ReadOnly = True
        Me.tb_p.Size = New System.Drawing.Size(112, 26)
        Me.tb_p.TabIndex = 4
        '
        'tb_compra
        '
        Me.tb_compra.AcceptsReturn = True
        Me.tb_compra.BackColor = System.Drawing.SystemColors.Info
        Me.tb_compra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_compra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_compra.Location = New System.Drawing.Point(466, 25)
        Me.tb_compra.MaxLength = 8
        Me.tb_compra.Name = "tb_compra"
        Me.tb_compra.Size = New System.Drawing.Size(112, 26)
        Me.tb_compra.TabIndex = 3
        '
        'lbl_2
        '
        Me.lbl_2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.Location = New System.Drawing.Point(224, 17)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(236, 40)
        Me.lbl_2.TabIndex = 0
        Me.lbl_2.Text = "Ingrese el valor de la compra:"
        Me.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'E4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 404)
        Me.Controls.Add(Me.panel_1)
        Me.Controls.Add(Me.lbl_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "E4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 4"
        Me.panel_1.ResumeLayout(False)
        Me.panel_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_1 As Label
    Friend WithEvents panel_1 As Panel
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_Back As Button
    Friend WithEvents tb_p As TextBox
    Friend WithEvents tb_compra As TextBox
    Friend WithEvents lbl_2 As Label
    Friend WithEvents lbl_3 As Label
    Friend WithEvents lbl_4 As Label
    Friend WithEvents lbl_6 As Label
    Friend WithEvents lbl_5 As Label
    Friend WithEvents tb_total As TextBox
    Friend WithEvents tb_IVA As TextBox
    Friend WithEvents tb_desc As TextBox
    Friend WithEvents tb_sub As TextBox
    Friend WithEvents Label1 As Label
End Class
