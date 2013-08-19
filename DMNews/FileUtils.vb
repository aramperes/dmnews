'Aram Peres, le 18 août 2013
'Information sur cette classe: Outils de fichiers utiliés pour le programme, manipulations risquées.
Public Class FileUtils

    Public Shared appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Private Shared Sub verifyDMApps()
        If Not System.IO.Directory.Exists(appdata & strings.DMAppsDir) Then
            MsgBox(strings.loadingError, MsgBoxStyle.Critical)
            End
        End If

    End Sub
    Private Shared Sub verifyDMNews()
        If Not System.IO.Directory.Exists(appdata & strings.DMNewsDir) Then
            MsgBox(strings.loadingError, MsgBoxStyle.Critical)
            End
        End If
    End Sub
    Private Shared Sub verifyVersion()
        If Not System.IO.Directory.Exists(appdata & strings.DMNewsDir & strings.Version) Then
            MsgBox(strings.loadingError, MsgBoxStyle.Critical)
            End
        End If
    End Sub
    Shared Sub verifyDirs()
        'Verifie si les dossiers principaux existent. Si non, un message d'erreur est envoyé.
        verifyDMApps()
        verifyDMNews()
        verifyVersion()
    End Sub
End Class
