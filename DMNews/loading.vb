Public Class loading
    Public Shared WithEvents loadingpic As New PictureBox
    
    Shared Sub load()
        main.Controls.Add(loadingpic)
        loadingpic.Visible = True
        loadingpic.Image = Image.FromFile(Gfx.loading)
        loadingpic.Size = New Point(100, 100)
        loadingpic.SizeMode = PictureBoxSizeMode.StretchImage
        loadingpic.Location = New Point(340, 200)
        main.BackColor = Color.CornflowerBlue
        GuiMain.status.Text = "Connexion en cours..."
        If InternetConnection() = False Then
            loadingpic.Size = New Point(298, 193)
            loadingpic.Location = New Point(255, 200)
            loadingpic.Image = Image.FromFile(Gfx.err408)
            GuiMain.status.Text = "Erreur 408: Connexion impossible!"
        End If
    End Sub
    Shared Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://www.google.com/")
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function
End Class
