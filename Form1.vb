Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles go.Click
        MsgBox("Hello Word")
        MsgBox("how are you")
        MsgBox("I hope you are well")

        MessageBox.Show("This is another message")
    End Sub

    Private Sub btnVariabel_Click(sender As Object, e As EventArgs) Handles btnVariabel.Click
        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Kevin"
        stLastName = "George"


        MsgBox("hello welcome " & stFirstName & " " & stLastName & " I hope you are well")


    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoor As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoor = 5
        stColour = "red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/2/2024#


    End Sub
End Class
