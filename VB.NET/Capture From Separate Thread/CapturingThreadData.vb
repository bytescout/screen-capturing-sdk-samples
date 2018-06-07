'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.Drawing
Imports System.Threading
Imports BytescoutScreenCapturingLib

Public Class CapturingThreadData

    Public CaptureType As CaptureAreaType
    Public TempFile As String
    Public CaptureRectangle As Rectangle = New Rectangle(0, 0, 320, 240)

    Public Success As Boolean
    Public ErrorText As String

    Public StartOrResumeEvent As AutoResetEvent = New AutoResetEvent(False) ' event signalling to start or resume the recodring
    Public PauseEvent As AutoResetEvent = New AutoResetEvent(False) ' event signalling to pause the recodring
    Public StopEvent As AutoResetEvent = New AutoResetEvent(False) ' event signalling to stop the recording 

End Class


