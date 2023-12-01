Imports System.Text
Imports DevExpress.Xpf.Core

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Partial Public Class MainWindow
    Inherits ThemedWindow
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub KullaniciButton_Click(sender As Object, e As RoutedEventArgs)
        Dim userTable As New UserTable()
        Grid.SetColumn(userTable, 1)
        mainGrid.Children.Add(userTable)
    End Sub

End Class