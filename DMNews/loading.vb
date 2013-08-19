Public Class loading

    Public Shared startConnexion = False
    Public Shared WithEvents page1 As New WebBrowser
    Public Shared WithEvents page2 As New WebBrowser
    Public Shared WithEvents page3 As New WebBrowser
    Public Shared WithEvents page4 As New WebBrowser
    Public Shared WithEvents page5 As New WebBrowser
    Public Shared WithEvents page6 As New WebBrowser
    Public Shared WithEvents page7 As New WebBrowser
    Public Shared WithEvents page8 As New WebBrowser
    Public Shared WithEvents page9 As New WebBrowser
    Public Shared WithEvents page10 As New WebBrowser
    Public Shared var1 = 535
    Public Shared var2 = 550
    Shared Sub load()

        setuppages()
        
        main.BackColor = Color.CornflowerBlue
        GuiMain.status.Text = "Connexion en cours..."

        isConnected()
        If InternetConnection() = False Then
            GuiMain.loadingpic.Size = New Point(298, 193)
            GuiMain.loadingpic.Location = New Point(255, 200)
            GuiMain.loadingpic.Image = Image.FromFile(Gfx.err408)
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
    Shared Sub isConnected()
start:
        If InternetConnection() = True Then
            startloading()
        Else

        End If
    End Sub

    Shared Sub setuppages()

        page1.Visible = False
        page1.Size = New Point(var1, var2)
        page1.Location = New Point(115, 5)
        page1.IsWebBrowserContextMenuEnabled = False
        page1.ScrollBarsEnabled = False
        main.Controls.Add(page1)

        page2.Visible = False
        page2.Size = New Point(var1, var2)
        page2.Location = New Point(115, 5)
        page2.IsWebBrowserContextMenuEnabled = False
        page2.ScrollBarsEnabled = False
        main.Controls.Add(page2)

        page3.Visible = False
        page3.Size = New Point(var1, var2)
        page3.Location = New Point(115, 5)
        page3.IsWebBrowserContextMenuEnabled = False
        page3.ScrollBarsEnabled = False
        main.Controls.Add(page3)

        page4.Visible = False
        page4.Size = New Point(var1, var2)
        page4.Location = New Point(115, 5)
        page4.IsWebBrowserContextMenuEnabled = False
        page4.ScrollBarsEnabled = False
        main.Controls.Add(page4)

        page5.Visible = False
        page5.Size = New Point(var1, var2)
        page5.Location = New Point(115, 5)
        page5.IsWebBrowserContextMenuEnabled = False
        page5.ScrollBarsEnabled = False
        main.Controls.Add(page5)

        page6.Visible = False
        page6.Size = New Point(var1, var2)
        page6.Location = New Point(115, 5)
        page6.IsWebBrowserContextMenuEnabled = False
        page6.ScrollBarsEnabled = False
        main.Controls.Add(page6)

        page7.Visible = False
        page7.Size = New Point(var1, var2)
        page7.Location = New Point(115, 5)
        page7.IsWebBrowserContextMenuEnabled = False
        page7.ScrollBarsEnabled = False
        main.Controls.Add(page7)

        page8.Visible = False
        page8.Size = New Point(var1, var2)
        page8.Location = New Point(115, 5)
        page8.IsWebBrowserContextMenuEnabled = False
        page8.ScrollBarsEnabled = False
        main.Controls.Add(page8)

        page9.Visible = False
        page9.Size = New Point(var1, var2)
        page9.Location = New Point(115, 5)
        page9.IsWebBrowserContextMenuEnabled = False
        page9.ScrollBarsEnabled = False
        main.Controls.Add(page9)

        page10.Visible = False
        page10.Size = New Point(var1, var2)
        page10.Location = New Point(115, 5)
        page10.IsWebBrowserContextMenuEnabled = False
        page10.ScrollBarsEnabled = False
        main.Controls.Add(page10)

    End Sub

    Shared Sub startloading()
        page1.Navigate(servers.p1)
    End Sub

    Public Shared Sub p1nav() Handles page1.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "10%"
        page2.Navigate(servers.p2)
    End Sub
    Public Shared Sub p2nav() Handles page2.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "20%"
        page3.Navigate(servers.p3)
    End Sub
    Public Shared Sub p3nav() Handles page3.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "30%"
        page4.Navigate(servers.p4)
    End Sub
    Public Shared Sub p4nav() Handles page4.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "40%"
        page5.Navigate(servers.p5)
    End Sub
    Public Shared Sub p5nav() Handles page5.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "50%"
        page6.Navigate(servers.p6)
    End Sub
    Public Shared Sub p6nav() Handles page6.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "60%"
        page7.Navigate(servers.p7)
    End Sub
    Public Shared Sub p7nav() Handles page7.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "70%"
        page8.Navigate(servers.p8)
    End Sub
    Public Shared Sub p8nav() Handles page8.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "80%"
        page9.Navigate(servers.p9)
    End Sub
    Public Shared Sub p9nav() Handles page9.DocumentCompleted
        GuiMain.status.Text = strings.connexionprog & "90%"
        page10.Navigate(servers.p10)
    End Sub
    Public Shared Sub p10nav() Handles page10.DocumentCompleted
        GuiMain.status.Text = "Connexion réussite!"
        page1.Visible = True
        page2.Visible = True
        page3.Visible = True
        page4.Visible = True
        page5.Visible = True
        page6.Visible = True
        page7.Visible = True
        page8.Visible = True
        page9.Visible = True
        page10.Visible = True
        page1.BringToFront()
    End Sub

End Class
