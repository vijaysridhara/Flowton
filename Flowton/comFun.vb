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
Friend Module comFun
    ''' <summary>
    ''' Error display module
    ''' </summary>
    ''' <param name="ex">Exception thrown</param>
    ''' <remarks>Call this function in any try catch block to display error</remarks>
    Friend Sub DE(ByVal ex As Exception)
        MsgBox(ex.Message, MsgBoxStyle.Critical)
    End Sub
    ''' <summary>
    ''' What stencils are loaded currently is present here for use throughout the app life.
    ''' </summary>
    ''' <remarks></remarks>
    Friend CurrentStencils As New List(Of Stencil)


End Module
