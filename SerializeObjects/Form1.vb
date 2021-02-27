Imports Newtonsoft.Json
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myplayer As New lista

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myplayer As New lista
        myplayer.imie = TextBox1.Text
        myplayer.nazwisko = TextBox2.Text

        Dim json As String = JsonConvert.SerializeObject(myplayer)

        Dim location As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        Dim file As IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(location + "\plik.json", True)
        file.WriteLine(json)
        file.Close()


    End Sub
End Class
