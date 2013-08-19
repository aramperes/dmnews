'Aram Peres, le 18 août 2013
'Ne pas utiliser le concepteur.
'Information sur cette classe: Execution principale du programme, manipulations interdites sauf sous autorisation.
Public Class main

    Private Sub start() Handles MyBase.Load
        'On lance le Sub verifyDirs() de la classe FileUtils.vb
        FileUtils.verifyDirs()
        'On crée le GUI en lanceant le Sub init() de la classe GuiMain.vb
        GuiMain.init()
    End Sub

End Class
