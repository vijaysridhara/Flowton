'********************************************************************************
'Copyright(C) 2011-2022  Vijay Sridhara

'This program Is free software; you can redistribute it And/Or
'modify it under the terms Of the GNU General Public License
'as published by the Free Software Foundation; either version 2
'of the License, Or (at your option) any later version.

'This program Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

' https://www.gnu.org/licenses/old-licenses/gpl-2.0.html

'You should have received a copy Of the GNU General Public License
'along with this program; if Not, write to the Free Software
'Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

'********************************************************************************

Namespace My


    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 3000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

        ''' <summary>
        ''' If any file is opened with Flowton, check if it has ftn extension and then load it
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            If e.CommandLine.Count = 0 Then Exit Sub

            If IO.File.Exists(e.CommandLine(0)) Then

                If IO.Path.GetExtension(e.CommandLine(0)).ToLower <> ".ftn" Then
                    MsgBox("This file is not a valid Flowton diagram", MsgBoxStyle.Critical)
                    e.Cancel = True
                    End
                Else
                    FlowtonMain.Openthisfile(e.CommandLine(0).Trim)
                End If
            End If
        End Sub
    End Class


End Namespace

