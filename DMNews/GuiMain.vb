﻿'Aram Peres, le 18 août 2013
'Information sur cette classe: Éléments du Gui de la forme principale, main.vb.
Public Class GuiMain
    Public Shared WithEvents loadingpic As New PictureBox
    Public Shared WithEvents status As New Label

    'Gui lors de l'initialisation du programme.
    Shared Sub init()
        main.Text = strings.Title & strings.Version
        main.Size = New Point(780, 600)
        main.StartPosition = FormStartPosition.Manual
        main.Location = New Point(50, 50)
        main.MaximizeBox = False
        main.FormBorderStyle = FormBorderStyle.FixedSingle
        main.BackgroundImageLayout = ImageLayout.Stretch
        loading.load()
        main.Controls.Add(loadingpic)
        loadingpic.Visible = True
        loadingpic.Image = Image.FromFile(Gfx.loading)
        loadingpic.Size = New Point(100, 100)
        loadingpic.SizeMode = PictureBoxSizeMode.StretchImage
        loadingpic.Location = New Point(340, 200)
        status.Visible = True
        status.Location = New Point(10, 540)
        status.ForeColor = Color.White
        status.Size = New Point(900, 900)
        status.BringToFront()
        main.Controls.Add(status)
    End Sub



End Class
