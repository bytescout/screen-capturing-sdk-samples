'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

if capturer.WebCamCount > 0 Then
 for i=0 to capturer.WebCamCount-1
  MsgBox "Webcamera device name = " & CStr(i) & ", Name: " & capturer.GetWebCamName (i)
 next
Else
 MsgBox "no web cam installed or plugged to this computer"
End If



Set Capturer = Nothing
