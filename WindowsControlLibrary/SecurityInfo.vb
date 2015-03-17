<Serializable()> _
Public Class SecurityInfo
    Private _AllowAccess As Boolean
    Private _AllowEdits As Boolean
    Private _AllowDelete As Boolean
    Private _AllowNew As Boolean
    Private _AllowQuery As Boolean
    Private _Roles As String
    Public Property AllowAccess() As Boolean
        Get
            Return _AllowAccess
        End Get
        Set(ByVal Value As Boolean)
            _AllowAccess = Value
        End Set
    End Property
    Public Property Roles() As String
        Get
            Return _Roles
        End Get
        Set(ByVal Value As String)
            _Roles = Value
        End Set
    End Property

    Public Property AllowEdits() As Boolean
        Get
            Return _AllowEdits
        End Get
        Set(ByVal Value As Boolean)
            _AllowEdits = Value
        End Set
    End Property
    Public Property AllowDelete() As Boolean
        Get
            Return _AllowDelete
        End Get
        Set(ByVal Value As Boolean)
            _AllowDelete = Value
        End Set
    End Property
    Public Property AllowNew() As Boolean
        Get
            Return _AllowNew
        End Get
        Set(ByVal Value As Boolean)
            _AllowNew = Value
        End Set
    End Property
    Public Property AllowQuery() As Boolean
        Get
            Return _AllowQuery
        End Get
        Set(ByVal Value As Boolean)
            _AllowQuery = Value
        End Set
    End Property

End Class
