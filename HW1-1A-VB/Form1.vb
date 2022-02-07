Imports System
Imports System.Threading

Public Class Finestra
    ' Inizializzo le variabili, le prime due definiscono la dimensione della palla, le successive la sua posizione e le ultime di quanto deve spostarsi
    Dim ballWidth As Integer = 50
    Dim ballHeight As Integer = 50
    Dim ballPosX As Integer = 100
    Dim ballPosY As Integer = 100
    Dim moveStepX As Integer = 1
    Dim moveStepY As Integer = 1

    ' Questo metodo fa apparire il testo nello spazio designato quando viene premuto l'apposito tasto
    Private Sub bottoneTesto_Click(sender As Object, e As EventArgs) Handles bottoneTesto.Click
        spazioTesto.Text = "qwertyuiop" & vbCrLf & "asdfghjkl" & vbCrLf & "zxcvbnm"
    End Sub

    ' Questo metodo fa apparire la palla nel rettangolo e la fa muovere quando viene premuto l'apposito tasto
    ' Per evitare che sia troppo veloce ogni volta che fa un movimento si ferma per 20 millisecondi
    Private Sub bottonePalla_Click(sender As Object, e As EventArgs) Handles bottonePalla.Click
        For i As Integer = 0 To 500
            MoveBall(sender, e)
            Thread.Sleep(20)
        Next
    End Sub

    ' Questo metodo cambia la posizione della palla nel rettangolo
    Private Sub MoveBall(sender As Object, e As EventArgs)
        ballPosX += moveStepX
        If ballPosX < 0 Or ballPosX + ballWidth > rettangoloPalla.Size.Width Then
            moveStepX = -moveStepX
        End If
        ballPosY += moveStepY
        If ballPosY < 0 Or ballPosY + ballHeight > rettangoloPalla.Size.Height Then
            moveStepY = -moveStepY
        End If
        rettangoloPalla.Refresh()
    End Sub

    ' Questo è un metodo che gestisce l'evento rettangoloPalla.Paint
    Private Sub PaintCircle(sender As Object, e As PaintEventArgs) Handles rettangoloPalla.Paint
        e.Graphics.Clear(rettangoloPalla.BackColor)
        e.Graphics.FillEllipse(Brushes.Blue, ballPosX, ballPosY, ballWidth, ballHeight)
    End Sub
End Class
