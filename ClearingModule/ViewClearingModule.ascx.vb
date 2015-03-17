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
Imports System.Web.UI
Imports System.Collections.Generic
Imports System.Reflection

Imports DotNetNuke
Imports DotNetNuke.Services.Exceptions
Imports DotNetNuke.Services.Localization

Namespace Futura.Modules.ClearingModule

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' The ViewClearingModule class displays the content
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Partial Class ViewClearingModule
        Inherits Entities.Modules.PortalModuleBase
        Implements Entities.Modules.IActionable

#Region "Event Handlers"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Page_Load runs when the control is loaded
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                Dim objClearingModules As New ClearingModuleController
                Dim colClearingModules As List(Of ClearingModuleInfo)

                ' get the content from the ClearingModule table
                colClearingModules = objClearingModules.GetClearingModules(ModuleId)

                If colClearingModules.Count = 0 Then
                    ' add the content to the ClearingModule table
                    Dim objClearingModule As ClearingModuleInfo = New ClearingModuleInfo
                    objClearingModule.ModuleId = ModuleId
                    objClearingModule.Content = Localization.GetString("DefaultContent", LocalResourceFile)
                    objClearingModule.CreatedByUser = Me.UserId
                    objClearingModules.AddClearingModule(objClearingModule)
                    ' get the content from the ClearingModule table
                    colClearingModules = objClearingModules.GetClearingModules(ModuleId)
                End If

                ' bind the content to the repeater
                lstContent.DataSource = colClearingModules
                lstContent.DataBind()

            Catch exc As Exception        'Module failed to load
                ProcessModuleLoadException(Me, exc)
            End Try
        End Sub

        Protected Sub lstContent_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles lstContent.ItemDataBound
            Dim strContent As String = ""

            ' add content to template
            If CType(Settings("template"), String) <> "" Then
                strContent = CType(Settings("template"), String)
                Dim objProperties As ArrayList = Common.Utilities.CBO.GetPropertyInfo(GetType(ClearingModuleInfo))
                Dim intProperty As Integer
                Dim objPropertyInfo As PropertyInfo
                For intProperty = 0 To objProperties.Count - 1
                    objPropertyInfo = CType(objProperties(intProperty), PropertyInfo)
                    strContent = strContent.Replace("[" & objPropertyInfo.Name.ToUpper & "]", DataBinder.Eval(e.Item.DataItem, objPropertyInfo.Name).ToString())
                Next intProperty
            Else
                strContent = DataBinder.Eval(e.Item.DataItem, "Content")
            End If

            ' assign the content
            Dim lblContent As Label = CType(e.Item.FindControl("lblContent"), Label)
            lblContent.Text = strContent
        End Sub

#End Region

#Region "Optional Interfaces"

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Registers the module actions required for interfacing with the portal framework
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' <history>
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public ReadOnly Property ModuleActions() As Entities.Modules.Actions.ModuleActionCollection Implements Entities.Modules.IActionable.ModuleActions
            Get
                Dim Actions As New Entities.Modules.Actions.ModuleActionCollection
                Actions.Add(GetNextActionID, Localization.GetString(Entities.Modules.Actions.ModuleActionType.AddContent, LocalResourceFile), Entities.Modules.Actions.ModuleActionType.AddContent, "", "", EditUrl(), False, Security.SecurityAccessLevel.Edit, True, False)
                Return Actions
            End Get
        End Property

#End Region

    End Class

End Namespace
