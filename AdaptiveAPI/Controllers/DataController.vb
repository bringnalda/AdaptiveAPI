﻿Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class DataController
        Inherits ApiController

        ' GET: api/Data
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Data/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Data
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Data/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Data/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class
End Namespace