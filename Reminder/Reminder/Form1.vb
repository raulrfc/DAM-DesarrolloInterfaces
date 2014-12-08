Public Class Reminder
    Dim descripcion As String
    Dim fecha As Date
    Dim anyos, dias As Integer
    Dim pos As Integer = 1

    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EventosDataSet.Eventos' Puede moverla o quitarla según sea necesario.
        Me.EventosTableAdapter.Fill(Me.EventosDataSet.Eventos)
        lblHoy.Text = Date.Now.ToString("dddd, ") & Date.Now.Day.ToString & " de " & getMes(Date.Now.Month) & " de " & Date.Now.Year.ToString
        Panel7.SendToBack()
        manejarDatos()

    End Sub

    Private Sub MostrarDatos(e As EventosDataSet.EventosRow, ByVal dias As Integer, ByVal anyos As Integer, ByRef image As Image)
        Select Case pos
            Case 1
                Panel1.Visible = True
                Panel1.BackgroundImage = image
                If dias > 0 Then
                    lbl1Info.Text = e.Descripcion & " cumplirá años en " & dias & " días"
                    lbl1Nac.Text = "Nació el " & e.Fecha
                    lbl1Anyos.Text = "Cumple " & anyos & " años"
                Else
                    lbl1Info.Text = e.Descripcion & " cumplió años hace " & (dias * -1) & " días"
                    lbl1Nac.Text = "Nació el " & e.Fecha
                    lbl1Anyos.Text = "Cumple " & anyos & " años"
                End If
                
            Case 2
                Panel2.Visible = True
                Panel2.BackgroundImage = image
                If dias > 0 Then
                    lbl2Info.Text = e.Descripcion & " cumplirá años en " & dias & " días"
                    lbl2Nac.Text = "Nació el " & e.Fecha
                    lbl2Anyos.Text = "Cumple " & anyos & " años"
                Else
                    lbl2Info.Text = e.Descripcion & " cumplió años hace " & (dias * -1) & " días"
                    lbl2Nac.Text = "Nació el " & e.Fecha
                    lbl2Anyos.Text = "Cumple " & anyos & " años"
                End If
            Case 3
                Panel3.Visible = True
                Panel3.BackgroundImage = image
                If dias > 0 Then
                    lbl3Info.Text = e.Descripcion & " cumplirá años en " & dias & " días"
                    lbl3Nac.Text = "Nació el " & e.Fecha
                    lbl3Anyos.Text = "Cumple " & anyos & " años"
                Else
                    lbl3Info.Text = e.Descripcion & " cumplió años hace " & (dias * -1) & " días"
                    lbl3Nac.Text = "Nació el " & e.Fecha
                    lbl3Anyos.Text = "Cumple " & anyos & " años"
                End If
            Case 4
                Panel4.Visible = True
                Panel4.BackgroundImage = image
                If dias > 0 Then
                    lbl4Info.Text = e.Descripcion & " cumplirá años en " & dias & " días"
                    lbl4Nac.Text = "Nació el " & e.Fecha
                    lbl4Anyos.Text = "Cumple " & anyos & " años"
                Else
                    lbl4Info.Text = e.Descripcion & " cumplió años hace " & (dias * -1) & " días"
                    lbl4Nac.Text = "Nació el " & e.Fecha
                    lbl4Anyos.Text = "Cumple " & anyos & " años"
                End If
            Case 5
                Panel5.Visible = True
                Panel5.BackgroundImage = image
                If dias > 0 Then
                    lbl5Info.Text = e.Descripcion & " cumplirá años en " & dias & " días"
                    lbl5Nac.Text = "Nació el " & e.Fecha
                    lbl5Anyos.Text = "Cumple " & anyos & " años"
                Else
                    lbl5Info.Text = e.Descripcion & " cumplió años hace " & (dias * -1) & " días"
                    lbl5Nac.Text = "Nació el " & e.Fecha
                    lbl5Anyos.Text = "Cumple " & anyos & " años"
                End If
            Case 6
                Panel6.Visible = True
                Panel6.BackgroundImage = image
                If dias > 0 Then
                    lbl6Info.Text = e.Descripcion & " cumplirá años en " & dias & " días"
                    lbl6Nac.Text = "Nació el " & e.Fecha
                    lbl6Anyos.Text = "Cumple " & anyos & " años"
                Else
                    lbl6Info.Text = e.Descripcion & " cumplió años hace " & (dias * -1) & " días"
                    lbl6Nac.Text = "Nació el " & e.Fecha
                    lbl6Anyos.Text = "Cumple " & anyos & " años"
                End If
        End Select
        pos += 1
    End Sub

    Private Sub controlDias(e As EventosDataSet.EventosRow, ByVal dias As Integer, ByVal anyos As Integer)
        If dias < -7 Then
            MostrarDatos(e, dias + 365, anyos, My.Resources.postitRosa)
        End If
        If dias < 0 And dias > -7 Then
            MostrarDatos(e, dias, anyos, My.Resources.postitRosa)
        End If
        If dias >= 0 And dias < 8 Then
            MostrarDatos(e, dias, anyos, My.Resources.postitVerde)
        End If
        If dias > 8 And dias < 30 Then
            MostrarDatos(e, dias, anyos, My.Resources.PostitAmarillo)
        End If
        If dias > 30 Then
            MostrarDatos(e, dias, anyos, My.Resources.postitRosa)
        End If
    End Sub

    Private Sub manejarDatos()
        For i = 0 To EventosDataSet.Eventos.Count - 1
            descripcion = EventosDataSet.Eventos(i).Descripcion
            fecha = EventosDataSet.Eventos(i).Fecha
            anyos = DateDiff("yyyy", fecha, Date.Now)
            dias = fecha.DayOfYear - Date.Now.DayOfYear
            controlDias(EventosDataSet.Eventos(i), dias, anyos)
        Next
    End Sub

    Public Function getMes(ByVal MesNum As Integer)
        Dim meses() As String = {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"}
        Return meses(MesNum - 1)
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub EventosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EventosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EventosDataSet)

    End Sub

    Dim newPoint As New System.Drawing.Point()
    Dim a As Integer
    Dim b As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        a = Control.MousePosition.X - Me.Location.X
        b = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (a)
            newPoint.Y = newPoint.Y - (b)
            Me.Location = newPoint
        End If
    End Sub
End Class
