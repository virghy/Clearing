'
' DotNetNuke® - http://www.dotnetnuke.com
' Copyright (c) 2002-2005
' by Perpetual Motion Interactive Systems Inc. ( http://www.perpetualmotion.ca )
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'

Imports System
Imports System.Configuration
Imports System.Data
Imports System.XML
Imports System.Web
Imports System.Collections.Generic

Imports DotNetNuke
Imports DotNetNuke.Common
Imports DotNetNuke.Common.Utilities.XmlUtils
Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.Services.Search

Namespace Futura.Modules.ClearingModule

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The Controller class for ClearingModule
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class ClearingModuleController
        Implements Entities.Modules.ISearchable
        Implements Entities.Modules.IPortable

#Region "Public Methods"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' gets an object from the database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="moduleId">The Id of the module</param>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function GetClearingModules(ByVal ModuleId As Integer) As List(Of ClearingModuleInfo)

            Return CBO.FillCollection(Of ClearingModuleInfo)(DataProvider.Instance().GetClearingModules(ModuleId))

        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' gets an object from the database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="ModuleId">The Id of the module</param>
        ''' <param name="ItemId">The Id of the item</param>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function GetClearingModule(ByVal ModuleId As Integer, ByVal ItemId As Integer) As ClearingModuleInfo

            Return CType(CBO.FillObject(DataProvider.Instance().GetClearingModule(ModuleId, ItemId), GetType(ClearingModuleInfo)), ClearingModuleInfo)

        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' adds an object to the database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="objClearingModule">The ClearingModuleInfo object</param>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub AddClearingModule(ByVal objClearingModule As ClearingModuleInfo)

            If objClearingModule.Content.Trim <> "" Then
                DataProvider.Instance().AddClearingModule(objClearingModule.ModuleId, objClearingModule.Content, objClearingModule.CreatedByUser)
            End If

        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' saves an object to the database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="objClearingModule">The ClearingModuleInfo object</param>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub UpdateClearingModule(ByVal objClearingModule As ClearingModuleInfo)

            If objClearingModule.Content.Trim <> "" Then
                DataProvider.Instance().UpdateClearingModule(objClearingModule.ModuleId, objClearingModule.ItemId, objClearingModule.Content, objClearingModule.CreatedByUser)
            End If

        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' deletes an object from the database
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="ModuleId">The Id of the module</param>
        ''' <param name="ItemId">The Id of the item</param>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub DeleteClearingModule(ByVal ModuleId As Integer, ByVal ItemId As Integer)

            DataProvider.Instance().DeleteClearingModule(ModuleId, ItemId)

        End Sub

#End Region

#Region "Optional Interfaces"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' GetSearchItems implements the ISearchable Interface
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function GetSearchItems(ByVal ModInfo As Entities.Modules.ModuleInfo) As DotNetNuke.Services.Search.SearchItemInfoCollection Implements DotNetNuke.Entities.Modules.ISearchable.GetSearchItems

            Dim SearchItemCollection As New SearchItemInfoCollection

            Dim colClearingModules As List(Of ClearingModuleInfo) = GetClearingModules(ModInfo.ModuleID)
            Dim objClearingModule As ClearingModuleInfo
            For Each objClearingModule In colClearingModules
                Dim SearchItem As SearchItemInfo = New SearchItemInfo(ModInfo.ModuleTitle, objClearingModule.Content, objClearingModule.CreatedByUser, objClearingModule.CreatedDate, ModInfo.ModuleID, objClearingModule.ItemId.ToString, objClearingModule.Content, "ItemId=" & objClearingModule.ItemId.ToString)
                SearchItemCollection.Add(SearchItem)
            Next

            Return SearchItemCollection

        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' ExportModule implements the IPortable ExportModule Interface
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="ModuleID">The Id of the module to be exported</param>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function ExportModule(ByVal ModuleID As Integer) As String Implements DotNetNuke.Entities.Modules.IPortable.ExportModule

            Dim strXML As String = ""

            Dim colClearingModules As List(Of ClearingModuleInfo) = GetClearingModules(ModuleID)
            If colClearingModules.Count <> 0 Then
                strXML += "<ClearingModules>"
                Dim objClearingModule As ClearingModuleInfo
                For Each objClearingModule In colClearingModules
                    strXML += "<ClearingModule>"
                    strXML += "<content>" & XMLEncode(objClearingModule.Content) & "</content>"
                    strXML += "</ClearingModule>"
                Next
                strXML += "</ClearingModules>"
            End If

            Return strXML

        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' ImportModule implements the IPortable ImportModule Interface
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <param name="ModuleID">The Id of the module to be imported</param>
        ''' <param name="Content">The content to be imported</param>
        ''' <param name="Version">The version of the module to be imported</param>
        ''' <param name="UserId">The Id of the user performing the import</param>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub ImportModule(ByVal ModuleID As Integer, ByVal Content As String, ByVal Version As String, ByVal UserId As Integer) Implements DotNetNuke.Entities.Modules.IPortable.ImportModule

            Dim xmlClearingModule As XmlNode
            Dim xmlClearingModules As XmlNode = GetContent(Content, "ClearingModules")
            For Each xmlClearingModule In xmlClearingModules.SelectNodes("ClearingModule")
                Dim objClearingModule As New ClearingModuleInfo
                objClearingModule.ModuleId = ModuleID
                objClearingModule.Content = xmlClearingModule.SelectSingleNode("content").InnerText
                objClearingModule.CreatedByUser = UserId
                AddClearingModule(objClearingModule)
            Next

        End Sub

#End Region

    End Class
End Namespace
