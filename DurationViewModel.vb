Imports System.ComponentModel

Public Class DurationViewModel
    Implements INotifyPropertyChanged

    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
            DoPropertyChanged("Name")
        End Set
    End Property
    Private _Hourly As Boolean
    Public Property Hourly As Boolean
        Get
            Return _Hourly
        End Get
        Set(value As Boolean)
            _Hourly = value
            DoPropertyChanged("Hourly")
        End Set
    End Property

    Private _Daily As Boolean
    Public Property Daily As Boolean
        Get
            Return _Daily
        End Get
        Set(value As Boolean)
            _Daily = value
            DoPropertyChanged("Daily")
        End Set
    End Property
    Private _Weekly As Boolean
    Public Property Weekly As Boolean
        Get
            Return _Weekly
        End Get
        Set(value As Boolean)
            _Weekly = value
            DoPropertyChanged("Weekly")
        End Set
    End Property
    Private _Monthly As Boolean
    Public Property Monthly As Boolean
        Get
            Return _Monthly
        End Get
        Set(value As Boolean)
            _Monthly = value
            DoPropertyChanged("Monthly")
        End Set
    End Property

    Public Sub New(name As String, frequency As Integer, hourly As Boolean, daily As Boolean, weekly As Boolean, monthly As Boolean)
        Me.Name = name
        Me.Frequency = frequency
        Me.Hourly = hourly
        Me.Daily = daily
        Me.Weekly = weekly
        Me.Monthly = monthly
    End Sub
    Private _Frequency As Integer
    Public Property Frequency As Integer
        Get
            Return _Frequency
        End Get
        Set(value As Integer)
            _Frequency = value
            DoPropertyChanged("Frequency")
        End Set
    End Property
    Public Sub DoPropertyChanged(name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
