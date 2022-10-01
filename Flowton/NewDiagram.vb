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
''' <summary>
''' New diagram options
''' </summary>
''' <remarks></remarks>
Friend Class NewDiagram

    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub NewDiagram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To CurrentStencils.Count - 1
            Dim ns As Stencil = CurrentStencils(i)

            chkLibs.Items.Add(ns.StencilName, True)
        Next
    End Sub

    Private Sub butCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



End Class