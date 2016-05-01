Imports System
Imports System.IO

Module Module1
    Public path As String = System.IO.Path.GetDirectoryName( _
           System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\AppDatabase.sdf"
    Public workingDirectory As String = System.IO.Path.GetDirectoryName( _
           System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
    Public orderno As String = Nothing
    Public customer As String = Nothing
    Public address As String = Nothing
    Public location As String = Nothing
    Public batch_line As Integer = Nothing
    Public pk As Integer = Nothing
    Public batch_code As String = Nothing
    Public created As String = Nothing
    Public isEdit As Boolean = Nothing
End Module
