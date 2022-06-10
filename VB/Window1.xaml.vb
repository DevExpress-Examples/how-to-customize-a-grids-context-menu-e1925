Imports DevExpress.Xpf.Bars
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace WpfApplication8

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim list As ObservableCollection(Of TestData) = New ObservableCollection(Of TestData)()
            For i As Integer = 0 To 100 - 1
                list.Add(New TestData() With {.Number1 = i, .Number2 = i * 10, .Text1 = "row " & i, .Text2 = "ROW " & i})
            Next

            Me.grid.ItemsSource = list
        End Sub

'#Region "#Add"
        Private Sub BarCheckItem_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        ' do something...
        End Sub

        Private Sub BarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        ' do something...
        End Sub
'#End Region  ' #Add
    End Class

    Public Class TestData

        Public Property Number1 As Integer

        Public Property Number2 As Integer

        Public Property Text1 As String

        Public Property Text2 As String
    End Class
End Namespace
