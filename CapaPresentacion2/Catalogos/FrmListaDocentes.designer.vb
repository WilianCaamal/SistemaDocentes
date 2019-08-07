<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaDocentes
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
        Me.DgvDocentes = New System.Windows.Forms.DataGridView()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnFormacion = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.DgvDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvDocentes
        '
        Me.DgvDocentes.AllowUserToAddRows = False
        Me.DgvDocentes.AllowUserToDeleteRows = False
        Me.DgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDocentes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDocentes.Location = New System.Drawing.Point(12, 120)
        Me.DgvDocentes.Name = "DgvDocentes"
        Me.DgvDocentes.ReadOnly = True
        Me.DgvDocentes.RowHeadersVisible = False
        Me.DgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDocentes.ShowEditingIcon = False
        Me.DgvDocentes.Size = New System.Drawing.Size(703, 213)
        Me.DgvDocentes.TabIndex = 4
        '
        'BtnReporte
        '
        Me.BtnReporte.Image = Global.CapaPresentacion2.My.Resources.ResourceImages24px.overview_pages_2_24px
        Me.BtnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporte.Location = New System.Drawing.Point(628, 71)
        Me.BtnReporte.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(85, 30)
        Me.BtnReporte.TabIndex = 6
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.CapaPresentacion2.My.Resources.ResourceImages48px.businessman_48px
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 57)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Lista de docentes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.CapaPresentacion2.My.Resources.ResourceImages24px.cancel_24px
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(297, 71)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(85, 30)
        Me.BtnCerrar.TabIndex = 3
        Me.BtnCerrar.Text = "     Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnFormacion
        '
        Me.BtnFormacion.Image = Global.CapaPresentacion2.My.Resources.ResourceImages24px.employee_card_24px
        Me.BtnFormacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFormacion.Location = New System.Drawing.Point(202, 71)
        Me.BtnFormacion.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnFormacion.Name = "BtnFormacion"
        Me.BtnFormacion.Size = New System.Drawing.Size(85, 30)
        Me.BtnFormacion.TabIndex = 2
        Me.BtnFormacion.Text = "     Formación"
        Me.BtnFormacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFormacion.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.CapaPresentacion2.My.Resources.ResourceImages24px.search_24px
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(107, 71)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(85, 30)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "      Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.CapaPresentacion2.My.Resources.ResourceImages24px.add_24px
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 71)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(85, 30)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "       Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Caption = "Espere por favor"
        Me.ProgressPanel1.Description = "Cargando ..."
        Me.ProgressPanel1.Location = New System.Drawing.Point(251, 157)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(246, 66)
        Me.ProgressPanel1.TabIndex = 7
        Me.ProgressPanel1.Text = "ProgressPanel1"
        Me.ProgressPanel1.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'FrmListaDocentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 345)
        Me.Controls.Add(Me.ProgressPanel1)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvDocentes)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnFormacion)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmListaDocentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Docentes"
        CType(Me.DgvDocentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnFormacion As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DgvDocentes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnReporte As Button
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
