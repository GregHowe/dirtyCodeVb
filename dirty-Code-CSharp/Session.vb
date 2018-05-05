Public Class Session

    Public Property Approved As Boolean

    Public Property Title As String

    Public Property Description As String


    Public Sub New(ByVal title As String, ByVal description As String)
        MyBase.New
        Me.Description = description
        Me.Title = title
    End Sub


End Class
