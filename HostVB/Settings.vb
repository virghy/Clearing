
Namespace My
    
    'Esta clase le permite controlar eventos específicos en la clase de configuración:
    ' El evento SettingChanging se desencadena antes de cambiar un valor de configuración.
    ' El evento PropertyChanged se desencadena después de cambiar el valor de configuración.
    ' El evento SettingsLoaded se desencadena después de cargar los valores de configuración.
    ' El evento SettingsSaving se desencadena antes de guardar los valores de configuración.
    Partial Friend NotInheritable Class MySettings
        Public Const MontoComision As String = "MONTO_COMISION"
        Public Const MontoComisionIva As String = "MONTO_COMISION_IVA"
        Public Const TransComision As String = "TRANS_COMISION"
        Public Const TransComisionIva As String = "TRANS_COMISION_IVA"
        Public Const CodigoCHERFII As String = "COD_CHERFII"
        Public Const CUENTA_ADM_ITAU As String = "CUENTA_ADM_ITAU"
        Public Const LONGITUD_CUENTA As String = "LONGITUD_CUENTA"

    End Class
End Namespace
