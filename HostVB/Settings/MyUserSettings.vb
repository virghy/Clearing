Imports System.Configuration
Imports System.ComponentModel

Namespace My
    Partial Class MySettings
        'Inherits ApplicationSettingsBase
        <UserScopedSetting()> _
        <DefaultSettingValue("white")> _
    <Category("Otros"), Description("Color de la mesa")> _
        Public Property BackgroundColor() As Color
            Get
                BackgroundColor = Me("BackgroundColor")
            End Get

            Set(ByVal value As Color)
                Me("BackgroundColor") = value
            End Set
        End Property
        <UserScopedSetting()> _
        <DefaultSettingValue("1")> _
    <Category("Otros"), Description("Scanner asignado")> _
        Public Property Empresa() As TipoScanner
            Get
                Empresa = Me("Empresa")
            End Get
            Set(ByVal value As TipoScanner)
                Me("Empresa") = value
            End Set
        End Property
        <DefaultSettingValue("True")> _
 <ApplicationScopedSetting()> _
 <Browsable(False)> _
    <Category("Otros"), Description("Banco asignado")> _
        Public Property CallUpgrade() As Boolean
            Get
                CallUpgrade = Me("CallUpgrade")
            End Get
            Set(ByVal value As Boolean)
                Me("CallUpgrade") = value
            End Set
        End Property

        <UserScopedSetting()> _
        Public ReadOnly Property Configuracion()
            Get
                Return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath
            End Get
        End Property

    End Class

    Public Class ComboBancos
        Inherits StringConverter
        Public Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
            Return MyBase.ConvertTo(context, culture, value, destinationType)
        End Function

    End Class
End Namespace


