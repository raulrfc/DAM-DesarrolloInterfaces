<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reminder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reminder))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl1Nac = New System.Windows.Forms.Label()
        Me.lbl1Anyos = New System.Windows.Forms.Label()
        Me.lbl1Info = New System.Windows.Forms.Label()
        Me.EventosDataSet = New EventosDataSet()
        Me.EventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventosTableAdapter = New EventosDataSetTableAdapters.EventosTableAdapter()
        Me.TableAdapterManager = New EventosDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl2Nac = New System.Windows.Forms.Label()
        Me.lbl2Anyos = New System.Windows.Forms.Label()
        Me.lbl2Info = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl3Nac = New System.Windows.Forms.Label()
        Me.lbl3Anyos = New System.Windows.Forms.Label()
        Me.lbl3Info = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl4Nac = New System.Windows.Forms.Label()
        Me.lbl4Anyos = New System.Windows.Forms.Label()
        Me.lbl4Info = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl5Nac = New System.Windows.Forms.Label()
        Me.lbl5Anyos = New System.Windows.Forms.Label()
        Me.lbl5Info = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl6Nac = New System.Windows.Forms.Label()
        Me.lbl6Anyos = New System.Windows.Forms.Label()
        Me.lbl6Info = New System.Windows.Forms.Label()
        Me.lblHoy = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.EventosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnCerrar.BackgroundImage = Global.Reminder.My.Resources.Resources.PostitAmarillo
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe Print", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCerrar.Image = Global.Reminder.My.Resources.Resources.PostitAmarillo
        Me.btnCerrar.Location = New System.Drawing.Point(17, 11)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(87, 42)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Reminder.My.Resources.Resources.postitVerde
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lbl1Nac)
        Me.Panel1.Controls.Add(Me.lbl1Anyos)
        Me.Panel1.Controls.Add(Me.lbl1Info)
        Me.Panel1.Location = New System.Drawing.Point(21, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 277)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'lbl1Nac
        '
        Me.lbl1Nac.AutoSize = True
        Me.lbl1Nac.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1Nac.Location = New System.Drawing.Point(35, 110)
        Me.lbl1Nac.Name = "lbl1Nac"
        Me.lbl1Nac.Size = New System.Drawing.Size(50, 21)
        Me.lbl1Nac.TabIndex = 2
        Me.lbl1Nac.Text = "Label1"
        '
        'lbl1Anyos
        '
        Me.lbl1Anyos.AutoSize = True
        Me.lbl1Anyos.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1Anyos.Location = New System.Drawing.Point(35, 165)
        Me.lbl1Anyos.Name = "lbl1Anyos"
        Me.lbl1Anyos.Size = New System.Drawing.Size(50, 21)
        Me.lbl1Anyos.TabIndex = 1
        Me.lbl1Anyos.Text = "Label1"
        '
        'lbl1Info
        '
        Me.lbl1Info.AutoSize = True
        Me.lbl1Info.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1Info.Location = New System.Drawing.Point(35, 59)
        Me.lbl1Info.Name = "lbl1Info"
        Me.lbl1Info.Size = New System.Drawing.Size(50, 21)
        Me.lbl1Info.TabIndex = 0
        Me.lbl1Info.Text = "Label1"
        '
        'EventosDataSet
        '
        Me.EventosDataSet.DataSetName = "EventosDataSet"
        Me.EventosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventosBindingSource
        '
        Me.EventosBindingSource.DataMember = "Eventos"
        Me.EventosBindingSource.DataSource = Me.EventosDataSet
        '
        'EventosTableAdapter
        '
        Me.EventosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventosTableAdapter = Me.EventosTableAdapter
        Me.TableAdapterManager.UpdateOrder = EventosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Reminder.My.Resources.Resources.postitVerde
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lbl2Nac)
        Me.Panel2.Controls.Add(Me.lbl2Anyos)
        Me.Panel2.Controls.Add(Me.lbl2Info)
        Me.Panel2.Location = New System.Drawing.Point(317, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 277)
        Me.Panel2.TabIndex = 11
        Me.Panel2.Visible = False
        '
        'lbl2Nac
        '
        Me.lbl2Nac.AutoSize = True
        Me.lbl2Nac.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2Nac.Location = New System.Drawing.Point(35, 110)
        Me.lbl2Nac.Name = "lbl2Nac"
        Me.lbl2Nac.Size = New System.Drawing.Size(50, 21)
        Me.lbl2Nac.TabIndex = 2
        Me.lbl2Nac.Text = "Label1"
        '
        'lbl2Anyos
        '
        Me.lbl2Anyos.AutoSize = True
        Me.lbl2Anyos.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2Anyos.Location = New System.Drawing.Point(35, 165)
        Me.lbl2Anyos.Name = "lbl2Anyos"
        Me.lbl2Anyos.Size = New System.Drawing.Size(50, 21)
        Me.lbl2Anyos.TabIndex = 1
        Me.lbl2Anyos.Text = "Label1"
        '
        'lbl2Info
        '
        Me.lbl2Info.AutoSize = True
        Me.lbl2Info.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2Info.Location = New System.Drawing.Point(35, 59)
        Me.lbl2Info.Name = "lbl2Info"
        Me.lbl2Info.Size = New System.Drawing.Size(50, 21)
        Me.lbl2Info.TabIndex = 0
        Me.lbl2Info.Text = "Label1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.Reminder.My.Resources.Resources.postitVerde
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.lbl3Nac)
        Me.Panel3.Controls.Add(Me.lbl3Anyos)
        Me.Panel3.Controls.Add(Me.lbl3Info)
        Me.Panel3.Location = New System.Drawing.Point(603, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 277)
        Me.Panel3.TabIndex = 11
        Me.Panel3.Visible = False
        '
        'lbl3Nac
        '
        Me.lbl3Nac.AutoSize = True
        Me.lbl3Nac.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3Nac.Location = New System.Drawing.Point(35, 110)
        Me.lbl3Nac.Name = "lbl3Nac"
        Me.lbl3Nac.Size = New System.Drawing.Size(50, 21)
        Me.lbl3Nac.TabIndex = 2
        Me.lbl3Nac.Text = "Label1"
        '
        'lbl3Anyos
        '
        Me.lbl3Anyos.AutoSize = True
        Me.lbl3Anyos.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3Anyos.Location = New System.Drawing.Point(35, 165)
        Me.lbl3Anyos.Name = "lbl3Anyos"
        Me.lbl3Anyos.Size = New System.Drawing.Size(50, 21)
        Me.lbl3Anyos.TabIndex = 1
        Me.lbl3Anyos.Text = "Label1"
        '
        'lbl3Info
        '
        Me.lbl3Info.AutoSize = True
        Me.lbl3Info.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3Info.Location = New System.Drawing.Point(35, 59)
        Me.lbl3Info.Name = "lbl3Info"
        Me.lbl3Info.Size = New System.Drawing.Size(50, 21)
        Me.lbl3Info.TabIndex = 0
        Me.lbl3Info.Text = "Label1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Global.Reminder.My.Resources.Resources.postitVerde
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.lbl4Nac)
        Me.Panel4.Controls.Add(Me.lbl4Anyos)
        Me.Panel4.Controls.Add(Me.lbl4Info)
        Me.Panel4.Location = New System.Drawing.Point(21, 392)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(290, 284)
        Me.Panel4.TabIndex = 11
        Me.Panel4.Visible = False
        '
        'lbl4Nac
        '
        Me.lbl4Nac.AutoSize = True
        Me.lbl4Nac.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4Nac.Location = New System.Drawing.Point(35, 110)
        Me.lbl4Nac.Name = "lbl4Nac"
        Me.lbl4Nac.Size = New System.Drawing.Size(50, 21)
        Me.lbl4Nac.TabIndex = 2
        Me.lbl4Nac.Text = "Label1"
        '
        'lbl4Anyos
        '
        Me.lbl4Anyos.AutoSize = True
        Me.lbl4Anyos.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4Anyos.Location = New System.Drawing.Point(35, 165)
        Me.lbl4Anyos.Name = "lbl4Anyos"
        Me.lbl4Anyos.Size = New System.Drawing.Size(50, 21)
        Me.lbl4Anyos.TabIndex = 1
        Me.lbl4Anyos.Text = "Label1"
        '
        'lbl4Info
        '
        Me.lbl4Info.AutoSize = True
        Me.lbl4Info.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4Info.Location = New System.Drawing.Point(35, 59)
        Me.lbl4Info.Name = "lbl4Info"
        Me.lbl4Info.Size = New System.Drawing.Size(50, 21)
        Me.lbl4Info.TabIndex = 0
        Me.lbl4Info.Text = "Label1"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.Reminder.My.Resources.Resources.postitVerde
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.lbl5Nac)
        Me.Panel5.Controls.Add(Me.lbl5Anyos)
        Me.Panel5.Controls.Add(Me.lbl5Info)
        Me.Panel5.Location = New System.Drawing.Point(317, 392)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(280, 284)
        Me.Panel5.TabIndex = 12
        Me.Panel5.Visible = False
        '
        'lbl5Nac
        '
        Me.lbl5Nac.AutoSize = True
        Me.lbl5Nac.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5Nac.Location = New System.Drawing.Point(35, 110)
        Me.lbl5Nac.Name = "lbl5Nac"
        Me.lbl5Nac.Size = New System.Drawing.Size(50, 21)
        Me.lbl5Nac.TabIndex = 2
        Me.lbl5Nac.Text = "Label1"
        '
        'lbl5Anyos
        '
        Me.lbl5Anyos.AutoSize = True
        Me.lbl5Anyos.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5Anyos.Location = New System.Drawing.Point(35, 165)
        Me.lbl5Anyos.Name = "lbl5Anyos"
        Me.lbl5Anyos.Size = New System.Drawing.Size(50, 21)
        Me.lbl5Anyos.TabIndex = 1
        Me.lbl5Anyos.Text = "Label1"
        '
        'lbl5Info
        '
        Me.lbl5Info.AutoSize = True
        Me.lbl5Info.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5Info.Location = New System.Drawing.Point(35, 59)
        Me.lbl5Info.Name = "lbl5Info"
        Me.lbl5Info.Size = New System.Drawing.Size(50, 21)
        Me.lbl5Info.TabIndex = 0
        Me.lbl5Info.Text = "Label1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = Global.Reminder.My.Resources.Resources.postitVerde
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.lbl6Nac)
        Me.Panel6.Controls.Add(Me.lbl6Anyos)
        Me.Panel6.Controls.Add(Me.lbl6Info)
        Me.Panel6.Location = New System.Drawing.Point(603, 392)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 284)
        Me.Panel6.TabIndex = 11
        Me.Panel6.Visible = False
        '
        'lbl6Nac
        '
        Me.lbl6Nac.AutoSize = True
        Me.lbl6Nac.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6Nac.Location = New System.Drawing.Point(35, 110)
        Me.lbl6Nac.Name = "lbl6Nac"
        Me.lbl6Nac.Size = New System.Drawing.Size(50, 21)
        Me.lbl6Nac.TabIndex = 2
        Me.lbl6Nac.Text = "Label1"
        '
        'lbl6Anyos
        '
        Me.lbl6Anyos.AutoSize = True
        Me.lbl6Anyos.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6Anyos.Location = New System.Drawing.Point(35, 165)
        Me.lbl6Anyos.Name = "lbl6Anyos"
        Me.lbl6Anyos.Size = New System.Drawing.Size(50, 21)
        Me.lbl6Anyos.TabIndex = 1
        Me.lbl6Anyos.Text = "Label1"
        '
        'lbl6Info
        '
        Me.lbl6Info.AutoSize = True
        Me.lbl6Info.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6Info.Location = New System.Drawing.Point(35, 59)
        Me.lbl6Info.Name = "lbl6Info"
        Me.lbl6Info.Size = New System.Drawing.Size(50, 21)
        Me.lbl6Info.TabIndex = 0
        Me.lbl6Info.Text = "Label1"
        '
        'lblHoy
        '
        Me.lblHoy.AutoSize = True
        Me.lblHoy.BackColor = System.Drawing.Color.Transparent
        Me.lblHoy.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoy.ForeColor = System.Drawing.Color.Black
        Me.lblHoy.Location = New System.Drawing.Point(109, 35)
        Me.lblHoy.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHoy.Name = "lblHoy"
        Me.lblHoy.Size = New System.Drawing.Size(49, 28)
        Me.lblHoy.TabIndex = 0
        Me.lblHoy.Text = "HOY"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = Global.Reminder.My.Resources.Resources.title
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.lblHoy)
        Me.Panel7.Location = New System.Drawing.Point(194, 1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(485, 102)
        Me.Panel7.TabIndex = 13
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BackgroundImage = Global.Reminder.My.Resources.Resources.PostitAmarillo
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.btnCerrar)
        Me.Panel8.Location = New System.Drawing.Point(778, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(125, 63)
        Me.Panel8.TabIndex = 14
        '
        'Reminder
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Reminder.My.Resources.Resources.Corkboard_Wood_Cork_Composite_by_Enchantedgal_Stock
        Me.ClientSize = New System.Drawing.Size(923, 696)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reminder"
        Me.Text = "Reminder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EventosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1Info As System.Windows.Forms.Label
    Friend WithEvents EventosDataSet As Global.Reminder.EventosDataSet
    Friend WithEvents EventosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EventosTableAdapter As Global.Reminder.EventosDataSetTableAdapters.EventosTableAdapter
    Friend WithEvents TableAdapterManager As Global.Reminder.EventosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lbl1Nac As System.Windows.Forms.Label
    Friend WithEvents lbl1Anyos As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl2Nac As System.Windows.Forms.Label
    Friend WithEvents lbl2Anyos As System.Windows.Forms.Label
    Friend WithEvents lbl2Info As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl3Nac As System.Windows.Forms.Label
    Friend WithEvents lbl3Anyos As System.Windows.Forms.Label
    Friend WithEvents lbl3Info As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbl4Nac As System.Windows.Forms.Label
    Friend WithEvents lbl4Anyos As System.Windows.Forms.Label
    Friend WithEvents lbl4Info As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbl5Nac As System.Windows.Forms.Label
    Friend WithEvents lbl5Anyos As System.Windows.Forms.Label
    Friend WithEvents lbl5Info As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lbl6Nac As System.Windows.Forms.Label
    Friend WithEvents lbl6Anyos As System.Windows.Forms.Label
    Friend WithEvents lbl6Info As System.Windows.Forms.Label
    Friend WithEvents lblHoy As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel

End Class
