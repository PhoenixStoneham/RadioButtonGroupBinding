Imports System.Collections.ObjectModel
Imports System.ComponentModel

Public Class MainWindowViewModel
    Implements INotifyPropertyChanged

    Public ReadOnly Property Durations As ObservableCollection(Of DurationViewModel)
    Public Sub New()
        Durations = New ObservableCollection(Of DurationViewModel)
        Durations.Add(New DurationViewModel("Daily", 1, False, True, False, False))
        Durations.Add(New DurationViewModel("Weekly", 1, False, False, True, False))
        Durations.Add(New DurationViewModel("Fortnightly", 1, False, False, True, False))
        Durations.Add(New DurationViewModel("Monthly", 1, False, False, False, True))
        Durations.Add(New DurationViewModel("1/2 yearly", 6, False, False, False, True))
        Durations.Add(New DurationViewModel("Other Days", 2, False, True, False, False))
        Durations.Add(New DurationViewModel("Take Over", 1, True, False, False, False))
        Durations.Add(New DurationViewModel("1/2 Day Takeover", 12, True, False, False, False))

    End Sub
    Private _SelectedDuration As DurationViewModel
    Public Property SelectedDuration As DurationViewModel
        Get
            Return _SelectedDuration
        End Get
        Set(value As DurationViewModel)
            _SelectedDuration = value
            DoPropertyChanged("SelectedDuration")
        End Set
    End Property

    Public Sub DoPropertyChanged(name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
