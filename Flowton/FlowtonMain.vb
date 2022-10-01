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
Imports Dataweb.NShape.WinFormsUI
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.IO
Imports Dataweb.NShape.Advanced
Imports Dataweb.NShape
''' <summary>
''' Main application form which loads the diagram and different tools
''' </summary>
''' <remarks></remarks>
Friend Class FlowtonMain

    Dim tmpDir As String = IO.Path.GetDirectoryName(Application.ExecutablePath)
    Dim roughwork As String = tmpDir & "\roughwork"
    Dim stencilDir As String = tmpDir & "\Stencils"
    ''' <summary>
    ''' Portrait dimensions
    ''' </summary>
    ''' <remarks></remarks>
    Structure Portrait
        Public Const Width = 794
        Public Const Height = 1123
    End Structure
    ''' <summary>
    ''' Landscape dimensions
    ''' </summary>
    ''' <remarks></remarks>
    Structure Landscape
        Public Const Width = 1123
        Public Const Height = 794
    End Structure
    ''' <summary>
    ''' Intialize the Flowton and its components
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        If IO.Directory.Exists(roughwork) = False Then MkDir(roughwork)
        If IO.Directory.Exists(stencilDir) = False Then MkDir(stencilDir)
        XmlStore1.DirectoryName = tmpDir
        CachedRepository1.Store = XmlStore1
        Project1.Repository = CachedRepository1
        DisableControls()
        Dim fls() As String = IO.Directory.GetFiles(stencilDir, "*.dll")
        For Each fl As String In fls
            Dim ass As System.Reflection.Assembly
            Try
                'somehow these modelobjects are not required.
                If fl.Contains("ModelObjects") Then Continue For
                ass = System.Reflection.Assembly.LoadFile(fl)
                Dim ns As New Stencil
                Dim assname As String = System.Reflection.AssemblyName.GetAssemblyName(fl).Name
                ns.StencilName = assname.Substring(InStrRev(assname, "."))
                ns.StencilPath = fl
                CurrentStencils.Add(ns)
            Catch ex As Exception

            End Try
        Next
    End Sub

    ''' <summary>
    ''' New diagram requested
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tlstpNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpNew.Click
        If Project1.Repository.IsModified Then
            Dim res As DialogResult = MsgBox("Do you want to save the changes before you close the current diagram?", vbYesNoCancel Or MsgBoxStyle.Question)
            If res = vbCancel Then Exit Sub
            If res = vbYes Then
                If XmlStore1.Exists Then
                    XmlStore1.Erase()
                End If
                Project1.Repository.SaveChanges()
                Project1.Close()
            End If
        End If
        If Project1.IsOpen Then
            Project1.Close()
        End If
        tabManin.TabPages.Clear()
        Dim nd As New NewDiagram
        If nd.ShowDialog = DialogResult.OK Then
            UID = 0
            Project1.Name = "halleluya"
            Project1.Create()
            For Each it As String In nd.chkLibs.CheckedItems
                For Each ns As Stencil In CurrentStencils
                    If ns.StencilName = it Then
                        Try
                            Project1.AddLibraryByFilePath(ns.StencilPath, True)
                        Catch ex As Exception
                            DE(ex)
                        End Try

                    End If
                Next
            Next
            AddnewPage(nd.optLandscape.Checked)
        End If

    End Sub
    Private UID As Integer

    ''' <summary>
    ''' New page to be added for a new diagram. For an existing diagram Openpae is used instead
    ''' </summary>
    ''' <param name="lscape">If landscape is selected</param>
    ''' <param name="dname">Diagram name</param>
    ''' <remarks></remarks>
    Private Sub AddnewPage(Optional ByVal lscape As Boolean = True, Optional ByVal dname As String = "")
        Try
            Dim dp As New Dataweb.NShape.WinFormsUI.Display
            dp.DiagramSetController = DiagramSetController1
            If String.IsNullOrEmpty(dname) Then
                UID += 1
                dp.CreateDiagram("Page-" & UID)
                tabManin.TabPages.Add("Page-" & UID)

            Else
                tabManin.TabPages.Add(dname)
                dp.CreateDiagram(dname)
            End If
            AddHandler dp.DiagramChanged, AddressOf Display_DiagramChanged
            AddHandler dp.ShapesSelected, AddressOf Display_ShapesSelected
            AddHandler dp.ShapeClick, AddressOf Display_ShapeClick
            AddHandler dp.MouseWheel, AddressOf Display_MouseWheel
            tabManin.TabPages(tabManin.TabCount - 1).Controls.Add(dp)
            dp.ShowGrid = tlstpGrid.Checked
            dp.Dock = DockStyle.Fill
            dp.BringToFront()
            dp.PropertyController = PropertyController1
            dp.ZoomWithMouseWheel = False
            setZoomLevel(dp, 60)
            tabManin.SelectedIndex = tabManin.TabCount - 1
            If lscape Then
                LandscapeToolStripMenuItem_Click(Nothing, Nothing)
            End If
            If tabManin.TabPages.Count = 1 Then enableControls()
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub
    ''' <summary>
    ''' Open a page from existing diagram
    ''' </summary>
    ''' <param name="dname">Diagram name</param>
    ''' <remarks></remarks>
    Private Sub Openpage(Optional ByVal dname As String = "")
        Try
            Dim dp As New Dataweb.NShape.WinFormsUI.Display
            dp.DiagramSetController = DiagramSetController1
            If String.IsNullOrEmpty(dname) Then
                UID += 1
                dp.CreateDiagram("Page-" & UID)
                tabManin.TabPages.Add("Page-" & UID)

            Else
                tabManin.TabPages.Add(dname)
                dp.OpenDiagram(dname)
                If dname.Length > 5 Then
                    If dname.Substring(0, 5) = "Page-" Then
                        If IsNumeric(dname.Substring(5)) Then
                            UID = dname.Substring(5)
                        End If
                    End If
                End If
          
            End If
            AddHandler dp.DiagramChanged, AddressOf Display_DiagramChanged
            AddHandler dp.ShapesSelected, AddressOf Display_ShapesSelected
            AddHandler dp.ShapeClick, AddressOf Display_ShapeClick
            AddHandler dp.MouseWheel, AddressOf Display_MouseWheel
            tabManin.TabPages(tabManin.TabCount - 1).Controls.Add(dp)
            dp.ShowGrid = tlstpGrid.Checked
            dp.Dock = DockStyle.Fill
            dp.BringToFront()
            dp.PropertyController = PropertyController1
            dp.ZoomWithMouseWheel = False
            setZoomLevel(dp, 60)

            If tabManin.TabPages.Count = 1 Then enableControls()
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub
    ''' <summary>
    ''' If Zoomlevel was manually changed. To avoid cyclic settings
    ''' </summary>
    ''' <remarks></remarks>
    Dim ZTRIG As Boolean
    ''' <summary>
    ''' Set the zoom level for a display
    ''' </summary>
    ''' <param name="dp">Display component</param>
    ''' <param name="ZLEVEL">Percentage as integer for zoom</param>
    ''' <remarks></remarks>
    Private Sub setZoomLevel(ByVal dp As Display, ByVal ZLEVEL As Integer)
        dp.ZoomLevel = ZLEVEL
        ZTRIG = True
        tlstpZoomPct.Text = ZLEVEL
        ZTRIG = False
    End Sub
    Private Sub tlstpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpAbout.Click
        AboutBox1.ShowDialog(Me)
    End Sub

    ''' <summary>
    ''' Open the diagram
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tlstpOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpOpen.Click
        Try
            If Project1.Repository.IsModified Then
                Dim res As DialogResult = MsgBox("Do you want to save the changes before you close the current diagram?", vbYesNoCancel Or MsgBoxStyle.Question)
                If res = vbCancel Then Exit Sub
                If res = vbYes Then
                    tlstpSave_Click(Nothing, Nothing)
                End If
            End If
            If Project1.IsOpen Then
                Project1.Close()
            End If
            tabManin.TabPages.Clear()
            Dim fld As New OpenFileDialog
            With fld
                .Filter = "Flowton Files(*.ftn)|*.ftn"
                If .ShowDialog = vbOK Then
                    Openthisfile(.FileName)
                End If

            End With
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Opening a existing file
    ''' </summary>
    ''' <param name="fname"></param>
    ''' <remarks></remarks>
    Friend Sub Openthisfile(ByVal fname As String)
        Try
            XmlStore1.DirectoryName = IO.Path.GetDirectoryName(fname)
            Project1.Name = IO.Path.GetFileNameWithoutExtension(fname)
            Project1.AutoLoadLibraries = True
            Project1.LibrarySearchPaths.Add(stencilDir)
            Project1.Open()
            If Project1.Repository.GetDiagrams.Count > 0 Then
                For Each dg As Dataweb.NShape.Diagram In Project1.Repository.GetDiagrams
                    Openpage(dg.Name)
                Next
            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Save the edited file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tlstpSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpSave.Click
        Try
            If Project1.Name = "halleluya" Then
                Dim sfd As New SaveFileDialog
                With sfd
                    .Filter = "Flowton files(*.ftn)|*.ftn"
                    If .ShowDialog = vbOK Then
                        XmlStore1.DirectoryName = IO.Path.GetDirectoryName(.FileName)
                        Project1.Name = IO.Path.GetFileNameWithoutExtension(.FileName)
                        tabManin.Tag = .FileName
                        If IO.File.Exists(sfd.FileName) Then
                            Kill(sfd.FileName)
                        End If
                        Project1.Repository.SaveChanges()

                    End If
                End With

            Else
                'If IO.File.Exists(tabManin.Tag) Then
                '    Kill(tabManin.Tag)
                'End If
                Project1.Repository.SaveChanges()
            End If

        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

  
 

    Private Sub tlstpPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpPaste.Click
        If tabManin.TabPages.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram Is Nothing Then Exit Sub
        CType(tabManin.SelectedTab.Controls(0), Display).Paste()
    End Sub

    ''' <summary>
    ''' What is the currenttab to enable shapes moving using keyboard
    ''' </summary>
    ''' <remarks></remarks>
    Private CurrentTab As Integer = 0
    Private Sub tabManin_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabManin.MouseClick
        If e.Button = MouseButtons.Right Then
            For tabindex As Integer = 0 To tabManin.TabPages.Count - 1
                If tabManin.GetTabRect(tabindex).Contains(e.Location) Then
                    CurrentTab = tabindex
                    ctxTab.Show(e.Location + tabManin.Location + New Point(0, ToolStrip1.Height))
                End If
            Next
        End If
    End Sub


    Private Sub ctxTab_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ctxTab.Opening
        If tabManin.TabPages.Count = 0 Then
            RemovePageToolStripMenuItem.Enabled = False
            RenamePageToolStripMenuItem.Enabled = False
        Else
            RemovePageToolStripMenuItem.Enabled = True
            RenamePageToolStripMenuItem.Enabled = True
        End If
        If Project1.IsOpen = False Then
            CloseDiagramToolStripMenuItem.Enabled = False
        Else
            CloseDiagramToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub AddNewPageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddNewPageToolStripMenuItem.Click
        AddnewPage(LandscapeToolStripMenuItem.Checked)
    End Sub

    Private Sub RemovePageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemovePageToolStripMenuItem.Click
        If MsgBox("Do you want to really remove this page?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub
        'Project1.Repository.DeleteDiagram(CType(tabManin.TabPages(CurrentTab).Controls(0), Dataweb.NShape.WinFormsUI.Display).Diagram)
        CType(tabManin.TabPages(CurrentTab).Controls(0), Dataweb.NShape.WinFormsUI.Display).Clear()
        tabManin.TabPages.RemoveAt(CurrentTab)
        If tabManin.TabPages.Count = 0 Then
            DisableControls()
        End If
    End Sub

    Private Sub RenamePageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenamePageToolStripMenuItem.Click
        Dim name As String = tabManin.TabPages(CurrentTab).Text
        name = Microsoft.VisualBasic.InputBox("Give a new name for the page", "Rename the page", name)
        If Not String.IsNullOrEmpty(name) Then
            CType(tabManin.TabPages(CurrentTab).Controls(0), Dataweb.NShape.WinFormsUI.Display).Diagram.Name = name
            tabManin.TabPages(CurrentTab).Text = name
        End If
    End Sub

    Private Sub CloseDiagramToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseDiagramToolStripMenuItem.Click

        If Project1.Repository.IsModified Then
            Dim res As DialogResult = MsgBox("Do you want to save the changes before you close the current diagram?", vbYesNoCancel Or MsgBoxStyle.Question)
            If res = vbCancel Then Exit Sub
            If res = vbYes Then
                tlstpSave_Click(Nothing, Nothing)
                Project1.Close()
            End If
        End If
        If Project1.IsOpen Then
            Project1.Close()
        End If
        tabManin.TabPages.Clear()
        DisableControls()
    End Sub



    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        tlstpOpen_Click(Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' Disable all controls if no page is present
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisableControls()

        tlstpCopy.Enabled = False
        tlstpCut.Enabled = False
        tlstpPaste.Enabled = False
        tlstpUndo.Enabled = False
        tlstpRedo.Enabled = False
        CopyToolStripMenuItem.Enabled = False
        CutToolStripMenuItem.Enabled = False
        PasteToolStripMenuItem.Enabled = False
        UndoToolStripMenuItem.Enabled = False
        RedoToolStripMenuItem.Enabled = False
        SaveasToolStripMenuItem.Enabled = False
        ExportToToolStripMenuItem.Enabled = False
        SelectallToolStripMenuItem.Enabled = False
        ExportAllPagesToolStripMenuItem.Enabled = False
        SaveToolStripMenuItem.Enabled = False
        PrintPreviewToolStripMenuItem.Enabled = False
        PrintToolStripMenuItem.Enabled = False
        tlstpPrintPreview.Enabled = False
        tlstpPrint.Enabled = False
        tlstpSave.Enabled = False
        tlstpZoomPct.Enabled = False
        tlstpGrid.Enabled = False
        OrientationToolStripMenuItem.Enabled = False
    End Sub

    ''' <summary>
    ''' Enable all controls if a page is present
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub enableControls()
        tlstpCopy.Enabled = True
        tlstpCut.Enabled = True
        tlstpPaste.Enabled = True
        tlstpUndo.Enabled = True
        tlstpRedo.Enabled = True
        CopyToolStripMenuItem.Enabled = True
        CutToolStripMenuItem.Enabled = True
        PasteToolStripMenuItem.Enabled = True
        UndoToolStripMenuItem.Enabled = True
        RedoToolStripMenuItem.Enabled = True
        SaveasToolStripMenuItem.Enabled = True
        ExportToToolStripMenuItem.Enabled = True
        SelectallToolStripMenuItem.Enabled = True
        ExportAllPagesToolStripMenuItem.Enabled = True
        SaveToolStripMenuItem.Enabled = True
        PrintPreviewToolStripMenuItem.Enabled = True
        PrintToolStripMenuItem.Enabled = True
        tlstpPrintPreview.Enabled = True
        tlstpPrint.Enabled = True
        tlstpSave.Enabled = True
        tlstpZoomPct.Enabled = True
        tlstpGrid.Enabled = True
        OrientationToolStripMenuItem.Enabled = True
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        tlstpNew_Click(Nothing, Nothing)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tlstpSave_Click(Nothing, Nothing)
    End Sub
 

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        tlstpUndo_Click(Nothing, Nothing)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        tlstpCopy_Click(Nothing, Nothing)
    End Sub


    Private Sub tlstpZoomPct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tlstpZoomPct.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If ZTRIG Then Exit Sub
                If tabManin.TabPages.Count = 0 Then Exit Sub
                CType(tabManin.SelectedTab.Controls(0), Display).ZoomLevel = tlstpZoomPct.Text
            Catch ex As Exception
                DE(ex)
            End Try
        End If
    End Sub

    Private Sub tlstpZoomPct_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlstpZoomPct.Leave
        Try
            If ZTRIG Then Exit Sub
            If tabManin.TabPages.Count = 0 Then Exit Sub
            CType(tabManin.SelectedTab.Controls(0), Display).ZoomLevel = tlstpZoomPct.Text
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub tlstpZoomPct_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlstpZoomPct.SelectedIndexChanged
        Try
            If ZTRIG Then Exit Sub
            CType(tabManin.SelectedTab.Controls(0), Display).ZoomLevel = tlstpZoomPct.Text
            Debug.Print(CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Width)
        Catch ex As Exception
            DE(ex)
        End Try

    End Sub

    Private Sub tlstpZoomPct_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlstpZoomPct.TextChanged

    End Sub

    Private Sub tabManin_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabManin.SelectedIndexChanged
        If tabManin.TabPages.Count = 0 Then DisableControls() : Exit Sub
        ZTRIG = True
        tlstpZoomPct.Text = CType(tabManin.SelectedTab.Controls(0), Display).ZoomLevel
        ZTRIG = False
        If tabManin.SelectedTab.Controls.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram Is Nothing Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Width > Portrait.Width Then
            PortraitToolStripMenuItem.Checked = False
            LandscapeToolStripMenuItem.Checked = True
        ElseIf CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Width < Landscape.Width Then
            PortraitToolStripMenuItem.Checked = True
            LandscapeToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub PortraitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortraitToolStripMenuItem.Click
        If tabManin.TabPages.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Width > CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Height Then
            CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Width = Portrait.Width
            CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Height = Portrait.Height
            PortraitToolStripMenuItem.Checked = True
            LandscapeToolStripMenuItem.Checked = False
        End If

    End Sub

   

    Private Sub LandscapeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LandscapeToolStripMenuItem.Click
        If tabManin.TabPages.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Width < CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Height Then
            CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Width = Landscape.Width
            CType(tabManin.SelectedTab.Controls(0), Display).Diagram.Height = Landscape.Height
            PortraitToolStripMenuItem.Checked = False
            LandscapeToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub tlstpCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpCopy.Click
        If tabManin.TabPages.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram Is Nothing Then Exit Sub
        CType(tabManin.SelectedTab.Controls(0), Display).Copy()
    End Sub

    Private Sub tlstpCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpCut.Click
        If tabManin.TabPages.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram Is Nothing Then Exit Sub
        CType(tabManin.SelectedTab.Controls(0), Display).Cut()
    End Sub

    Private Sub tlstpUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpUndo.Click
        If tabManin.TabPages.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram Is Nothing Then Exit Sub
        If Project1.History.UndoCommandCount = 0 Then Exit Sub
        Project1.History.Undo()
    End Sub

    Private Sub tlstpRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpRedo.Click
        If tabManin.TabPages.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram Is Nothing Then Exit Sub
        If Project1.History.RedoCommandCount = 0 Then Exit Sub
        Project1.History.Redo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        tlstpRedo_Click(Nothing, Nothing)
    End Sub


    Private Sub JPGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JPGToolStripMenuItem.Click
        ExporttoImage("jpg")
    End Sub

    ''' <summary>
    ''' Export to a image format. Single page
    ''' </summary>
    ''' <param name="fmt"> Image format selected</param>
    ''' <remarks></remarks>
    Private Sub ExporttoImage(ByVal fmt As String)
        If tabManin.TabPages.Count = 0 Then Exit Sub
        Dim dp As Display = CType(tabManin.SelectedTab.Controls(0), Display)
        Dim sfld As New SaveFileDialog
        With sfld
            Select Case fmt
                Case "jpg"
                    .Filter = "JPG images(*.jpg)|*.jpg"
                    If .ShowDialog = vbOK Then
                        dp.Diagram.CreateImage(Dataweb.NShape.ImageFileFormat.Jpeg).Save(.FileName)
                    End If

                Case "png"
                    .Filter = "Portable network grahics(*.png)|*.png"
                    If .ShowDialog = vbOK Then
                        dp.Diagram.CreateImage(Dataweb.NShape.ImageFileFormat.Png).Save(.FileName)
                    End If

                Case "tiff"
                    .Filter = "Tiff images(*.tiff)|*.tiff"
                    If .ShowDialog = vbOK Then
                        dp.Diagram.CreateImage(Dataweb.NShape.ImageFileFormat.Tiff).Save(.FileName)
                    End If

                Case "emf"
                    .Filter = "Enhanced Meta format (*.emf)|*.emf"
                    If .ShowDialog = vbOK Then
                        dp.Diagram.CreateImage(Dataweb.NShape.ImageFileFormat.EmfPlus).Save(.FileName)
                    End If
                Case "bmp"
                    .Filter = "JPG images(*.jpg)|*.jpg"
                    If .ShowDialog = vbOK Then
                        dp.Diagram.CreateImage(Dataweb.NShape.ImageFileFormat.Jpeg).Save(.FileName)
                    End If

            End Select


        End With
    End Sub

    ''' <summary>
    ''' Export all pages to tiff format
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub ExportAllPagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportAllPagesToolStripMenuItem.Click
        Try
            If tabManin.TabPages.Count = 0 Then Exit Sub
            Dim sfld As New SaveFileDialog
            With sfld
                .Filter = "Tiff images(*.tiff)|*.tiff"
                If .ShowDialog = vbOK Then
                    Dim fl(tabManin.TabPages.Count) As System.Drawing.Image
                    Dim j As Integer = 0
                    For Each tbp As TabPage In tabManin.TabPages
                        Dim dp As Display = CType(tbp.Controls(0), Display)
                        fl(j) = dp.Diagram.CreateImage(Dataweb.NShape.ImageFileFormat.Bmp)

                        j += 1

                    Next
                    Dim thd As New Threading.Thread(AddressOf ExportAll)
                    If IO.File.Exists(.FileName) Then
                        IO.File.Delete(.FileName)
                    End If
                    Dim imgD As New imgDet
                    imgD.filename = .FileName
                    imgD.imgs = fl
                    thd.Start(imgD)
                End If
            End With

        Catch ex As Exception
            DE(ex)
        End Try

    End Sub
    Structure imgDet
        Public filename As String
        Public imgs() As Image
    End Structure

    ''' <summary>
    ''' Export all images to tiff format
    ''' </summary>
    ''' <param name="imgd">Image detail structure</param>
    ''' <remarks></remarks>
    Private Sub ExportAll(ByVal imgd As imgDet)
        Try
            Dim imgCinfo As ImageCodecInfo
            For Each f As ImageCodecInfo In ImageCodecInfo.GetImageEncoders
                If f.MimeType = "image/tiff" Then
                    imgCinfo = f
                    Exit For
                End If
            Next
            Dim fname As String = imgd.filename
            Dim fl() As Image = imgd.imgs
            If fl.Length = 1 Then

                fl(0).Save(fname)
            ElseIf fl.Length > 1 Then

                Dim saveEncoder As Encoder
                Dim compressionEncoder As Encoder
                Dim SaveEncodeParam As EncoderParameter
                'Dim CompressionEncodeParam As EncoderParameter
                Dim EncoderParams As New EncoderParameters(1)

                saveEncoder = Encoder.SaveFlag
                compressionEncoder = Encoder.Compression

                ' Save the first page (frame).
                SaveEncodeParam = New EncoderParameter(saveEncoder, CLng(EncoderValue.MultiFrame))
                ' CompressionEncodeParam = New EncoderParameter(compressionEncoder, CLng(EncoderValue.CompressionCCITT4))
                EncoderParams.Param(0) = SaveEncodeParam
                'EncoderParams.Param(1) = SaveEncodeParam

                File.Delete(fname)
                fl(0).Save(fname, imgCinfo, EncoderParams)
                For i As Integer = 1 To fl.Length - 1
                    If fl(i) Is Nothing Then
                        Exit For
                    End If
                    SaveEncodeParam = New EncoderParameter(saveEncoder, CLng(EncoderValue.FrameDimensionPage))
                    'CompressionEncodeParam = New EncoderParameter(compressionEncoder, CLng(EncoderValue.CompressionCCITT4))
                    EncoderParams.Param(0) = SaveEncodeParam
                    'EncoderParams.Param(1) = SaveEncodeParam
                    fl(0).SaveAdd(fl(i), EncoderParams)
                Next
                SaveEncodeParam = New EncoderParameter(saveEncoder, CLng(EncoderValue.Flush))
                EncoderParams.Param(0) = SaveEncodeParam
                fl(0).SaveAdd(EncoderParams)
            End If





        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub PNGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNGToolStripMenuItem.Click
        ExporttoImage("png")
    End Sub

    Private Sub BMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMPToolStripMenuItem.Click
        ExporttoImage("bmp")
    End Sub

    Private Sub EMFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMFToolStripMenuItem.Click
        ExporttoImage("emf")
    End Sub

    Private Sub SelectallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectallToolStripMenuItem.Click
        If tabManin.TabPages.Count = 0 Then Exit Sub
        If CType(tabManin.SelectedTab.Controls(0), Display).Diagram Is Nothing Then Exit Sub
        CType(tabManin.SelectedTab.Controls(0), Display).SelectAll()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        tlstpCut_Click(Nothing, Nothing)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        tlstpPaste_Click(Nothing, Nothing)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If tabManin.TabPages.Count = 0 Then
            If Project1.IsOpen Then
                Project1.Close()
            End If
            Me.Close()
        ElseIf Project1.IsOpen Then
            If Project1.Repository.IsModified Then
                Dim res As DialogResult = MsgBox("Do you want to save changes before you close", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question)
                If res = DialogResult.No Then
                    Project1.Close()
                    Me.Close()
                ElseIf res = Windows.Forms.DialogResult.Yes Then
                    tlstpSave_Click(Nothing, Nothing)
                    If Project1.Repository.IsModified Then Exit Sub
                    Me.Close()
                Else
                    Exit Sub
                End If

            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        tlstpAbout_Click(Nothing, Nothing)
    End Sub

    Private Sub ContentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentToolStripMenuItem.Click
        MsgBox("I have not written any help yet, will you help me?", MsgBoxStyle.Question)

    End Sub

    Private Sub tlstpGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpGrid.Click

        For Each tbp As TabPage In tabManin.TabPages
            CType(tbp.Controls(0), Display).ShowGrid = tlstpGrid.Checked
            CType(tbp.Controls(0), Display).Invalidate()
        Next
    End Sub


    Private Sub tabManin_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabManin.TabIndexChanged

    End Sub

    Private Sub FlowtonMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If tabManin.TabPages.Count = 0 Then
            If Project1.IsOpen Then
                Project1.Close()
            End If
        ElseIf Project1.IsOpen Then
            If Project1.Repository.IsModified Then
                Dim res As DialogResult = MsgBox("Do you want to save changes before you close", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question)
                If res = DialogResult.No Then
                    Project1.Close()
                ElseIf res = Windows.Forms.DialogResult.Yes Then
                    tlstpSave_Click(Nothing, Nothing)
                    If Project1.Repository.IsModified Then e.Cancel = True : Exit Sub
                Else
                    e.Cancel = True
                End If

            End If
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = (Keys.Right Or Keys.Shift) Or keyData = (Keys.Left Or Keys.Shift) Or keyData = (Keys.Up Or Keys.Shift) Or keyData = (Keys.Down Or Keys.Shift) Then
            OnKeyDown(New KeyEventArgs(keyData))
            Return True
        ElseIf keyData = Keys.Left Or keyData = Keys.Right Or keyData = Keys.Up Or keyData = Keys.Down Then
            OnKeyDown(New KeyEventArgs(keyData))
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If

    End Function
    ''' <summary>
    ''' Control pressed flag, to enable disable zooming using mousewheel
    ''' </summary>
    ''' <remarks></remarks>
    Private ControlPressed As Boolean
    Private Sub FlowtonMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            ControlPressed = True
        End If

        If tabManin.TabCount = 0 Then Exit Sub
        Dim disp As Display = CType(tabManin.SelectedTab.Controls(0), Display)
        If disp.ContainsFocus = False Then Exit Sub
        If disp.SelectedShapes.Count = 0 Then Exit Sub
        If e.Shift Then
            Select Case e.KeyCode
                Case Keys.Down
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(0, 5)

                    Next

                Case Keys.Up
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(0, -5)

                    Next
                Case Keys.Left
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(-5, 0)

                    Next
                Case Keys.Right
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(5, 0)

                    Next
            End Select
            disp.Invalidate()
        ElseIf e.Control Then
            Select Case e.KeyCode
                Case Keys.Down
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(0, 10)

                    Next

                Case Keys.Up
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(0, -10)

                    Next
                Case Keys.Left
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(-10, 0)

                    Next
                Case Keys.Right
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(10, 0)

                    Next
            End Select
            disp.Invalidate()
        Else


            Select Case e.KeyCode
                Case Keys.Down
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(0, 20)

                    Next

                Case Keys.Up
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(0, -20)

                    Next
                Case Keys.Left
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(-20, 0)

                    Next
                Case Keys.Right
                    For Each shp As Shape In disp.SelectedShapes
                        shp.MoveBy(20, 0)

                    Next
            End Select
            disp.Invalidate()
        End If

    End Sub

    ''' <summary>
    ''' This event is necessary as the shapes are leaving traces of their grips around while moving
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Display_DiagramChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        CType(sender, Display).Invalidate()
    End Sub


    ''' <summary>
    ''' This event is necessary as the shapes are leaving traces of their grips around while moving
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Display_ShapeClick(ByVal sender As Object, ByVal e As Dataweb.NShape.Controllers.DiagramPresenterShapeClickEventArgs)
        CType(sender, Display).Invalidate()
    End Sub

    ''' <summary>
    ''' This event is necessary as the shapes are leaving traces of their grips around while moving
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Display_ShapesSelected(ByVal sender As Object, ByVal e As System.EventArgs)
        CType(sender, Display).Invalidate()
    End Sub

    ''' <summary>
    ''' Zooming using mousewheel while control is pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Display_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        On Error GoTo -1
        Dim x As Integer = Int(e.Delta / 120)
        If ControlPressed Then
            If CType(sender, Display).ZoomLevel + x * 5 >= 1000 Then Exit Sub
            If CType(sender, Display).ZoomLevel + (x * 5) <= 10 Then Exit Sub
            CType(sender, Display).ZoomLevel = CType(sender, Display).ZoomLevel + x * 5
            tlstpZoomPct.Text = CType(sender, Display).ZoomLevel
        End If
    End Sub

    Private Sub FlowtonMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If ControlPressed Then
            ControlPressed = False
        End If
    End Sub


    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        tlstpPrintPreview_Click(Nothing, Nothing)

    End Sub
    ''' <summary>
    ''' Printable image array
    ''' </summary>
    ''' <remarks></remarks>
    Dim prtImg() As Image
    ''' <summary>
    ''' Which Image is currently being printed(valid for multiple pages)
    ''' </summary>
    ''' <remarks></remarks>
    Dim CurrPrintImg As Integer = 0
    ''' <summary>
    ''' Prepare the printing structure well before preview/print
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PreparePrint()
        prtImg = Nothing
        CurrPrintImg = 0
        If tabManin.TabCount = 0 Then Exit Sub
        ReDim prtImg(0)
        Dim pageno As Integer = 0
        If LandscapeToolStripMenuItem.Checked Then
            PrintDocument1.DefaultPageSettings.Landscape = True
        Else
            PrintDocument1.DefaultPageSettings.Landscape = False

        End If
        Dim disp As Display
        For Each tb As TabPage In tabManin.TabPages
            ReDim Preserve prtImg(pageno)
            disp = tb.Controls(0)
            If disp.Diagram Is Nothing Then Exit Sub
            prtImg(pageno) = disp.Diagram.CreateImage(ImageFileFormat.Bmp, Nothing, True)
            pageno += 1
            disp = Nothing
        Next
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawImage(prtImg(CurrPrintImg), 0, 0)

        If prtImg.GetUpperBound(0) > 0 And CurrPrintImg < prtImg.GetUpperBound(0) Then
            e.HasMorePages = True
            CurrPrintImg += 1
        Else
            e.HasMorePages = False
        End If

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        tlstpPrint_Click(Nothing, Nothing)
    End Sub

    Private Sub tlstpPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpPrintPreview.Click
        With (PrintPreviewDialog1)
            .WindowState = FormWindowState.Maximized
            PreparePrint()
            .Document = PrintDocument1

            .ShowDialog()
        End With
    End Sub

    Private Sub tlstpPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstpPrint.Click
        If tabManin.TabCount = 0 Then Exit Sub
        PreparePrint()
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub SaveasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveasToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "Flowton files(*.ftn)|*.ftn"
            If .ShowDialog = vbOK Then

                XmlStore1.DirectoryName = IO.Path.GetDirectoryName(.FileName)
                Project1.Name = IO.Path.GetFileNameWithoutExtension(.FileName)
                tabManin.Tag = .FileName
                If IO.File.Exists(sfd.FileName) Then
                    Kill(sfd.FileName)
                End If

                Project1.Repository.SaveChanges()
            End If
        End With
    End Sub
End Class
