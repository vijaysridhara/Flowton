<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlowtonMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlowtonMain))
        Dim RoleBasedSecurityManager1 As Dataweb.NShape.RoleBasedSecurityManager = New Dataweb.NShape.RoleBasedSecurityManager()
        Me.DiagramSetController1 = New Dataweb.NShape.Controllers.DiagramSetController()
        Me.Project1 = New Dataweb.NShape.Project(Me.components)
        Me.CachedRepository1 = New Dataweb.NShape.Advanced.CachedRepository()
        Me.XmlStore1 = New Dataweb.NShape.XmlStore()
        Me.PropertyController1 = New Dataweb.NShape.Controllers.PropertyController()
        Me.ToolSetController1 = New Dataweb.NShape.Controllers.ToolSetController()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ToolSetListViewPresenter1 = New Dataweb.NShape.WinFormsUI.ToolSetListViewPresenter(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PropertyPresenter1 = New Dataweb.NShape.WinFormsUI.PropertyPresenter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tlstpNew = New System.Windows.Forms.ToolStripButton()
        Me.tlstpOpen = New System.Windows.Forms.ToolStripButton()
        Me.tlstpSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlstpPrintPreview = New System.Windows.Forms.ToolStripButton()
        Me.tlstpPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlstpUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlstpRedo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlstpCopy = New System.Windows.Forms.ToolStripButton()
        Me.tlstpCut = New System.Windows.Forms.ToolStripButton()
        Me.tlstpPaste = New System.Windows.Forms.ToolStripButton()
        Me.tlstpGrid = New System.Windows.Forms.ToolStripButton()
        Me.tlstpZoomlevel = New System.Windows.Forms.ToolStripLabel()
        Me.tlstpZoomPct = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlstpAbout = New System.Windows.Forms.ToolStripButton()
        Me.tabManin = New System.Windows.Forms.TabControl()
        Me.ctxTab = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenamePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseDiagramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JPGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAllPagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrientationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortraitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LandscapeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ctxTab.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DiagramSetController1
        '
        Me.DiagramSetController1.ActiveTool = Nothing
        Me.DiagramSetController1.Project = Me.Project1
        '
        'Project1
        '
        Me.Project1.AutoGenerateTemplates = True
        Me.Project1.LibrarySearchPaths = CType(resources.GetObject("Project1.LibrarySearchPaths"), System.Collections.Generic.IList(Of String))
        Me.Project1.Name = Nothing
        Me.Project1.Repository = Me.CachedRepository1
        RoleBasedSecurityManager1.CurrentRole = Dataweb.NShape.StandardRole.Administrator
        RoleBasedSecurityManager1.CurrentRoleName = "Administrator"
        Me.Project1.SecurityManager = RoleBasedSecurityManager1
        '
        'CachedRepository1
        '
        Me.CachedRepository1.ProjectName = Nothing
        Me.CachedRepository1.Store = Me.XmlStore1
        Me.CachedRepository1.Version = 0
        '
        'XmlStore1
        '
        Me.XmlStore1.DesignFileName = ""
        Me.XmlStore1.DirectoryName = ""
        Me.XmlStore1.FileExtension = ".ftn"
        Me.XmlStore1.ProjectName = ""
        '
        'PropertyController1
        '
        Me.PropertyController1.Project = Me.Project1
        '
        'ToolSetController1
        '
        Me.ToolSetController1.DiagramSetController = Me.DiagramSetController1
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(239, 398)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'ToolSetListViewPresenter1
        '
        Me.ToolSetListViewPresenter1.HideDeniedMenuItems = False
        Me.ToolSetListViewPresenter1.ListView = Me.ListView1
        Me.ToolSetListViewPresenter1.ShowDefaultContextMenu = False
        Me.ToolSetListViewPresenter1.ToolSetController = Me.ToolSetController1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Splitter2)
        Me.Panel1.Controls.Add(Me.PropertyGrid1)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 479)
        Me.Panel1.TabIndex = 8
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(0, 398)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(239, 3)
        Me.Splitter2.TabIndex = 16
        Me.Splitter2.TabStop = False
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 398)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(239, 81)
        Me.PropertyGrid1.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(239, 49)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 479)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'PropertyPresenter1
        '
        Me.PropertyPresenter1.PrimaryPropertyGrid = Me.PropertyGrid1
        Me.PropertyPresenter1.PropertyController = Me.PropertyController1
        Me.PropertyPresenter1.SecondaryPropertyGrid = Nothing
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstpNew, Me.tlstpOpen, Me.tlstpSave, Me.ToolStripSeparator1, Me.tlstpPrintPreview, Me.tlstpPrint, Me.ToolStripSeparator5, Me.tlstpUndo, Me.ToolStripSeparator4, Me.tlstpRedo, Me.ToolStripSeparator3, Me.tlstpCopy, Me.tlstpCut, Me.tlstpPaste, Me.tlstpGrid, Me.tlstpZoomlevel, Me.tlstpZoomPct, Me.ToolStripSeparator2, Me.tlstpAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(798, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlstpNew
        '
        Me.tlstpNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpNew.Image = CType(resources.GetObject("tlstpNew.Image"), System.Drawing.Image)
        Me.tlstpNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpNew.Name = "tlstpNew"
        Me.tlstpNew.Size = New System.Drawing.Size(23, 22)
        Me.tlstpNew.Text = "New "
        '
        'tlstpOpen
        '
        Me.tlstpOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpOpen.Image = CType(resources.GetObject("tlstpOpen.Image"), System.Drawing.Image)
        Me.tlstpOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpOpen.Name = "tlstpOpen"
        Me.tlstpOpen.Size = New System.Drawing.Size(23, 22)
        Me.tlstpOpen.Text = "Open"
        '
        'tlstpSave
        '
        Me.tlstpSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpSave.Image = CType(resources.GetObject("tlstpSave.Image"), System.Drawing.Image)
        Me.tlstpSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpSave.Name = "tlstpSave"
        Me.tlstpSave.Size = New System.Drawing.Size(23, 22)
        Me.tlstpSave.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlstpPrintPreview
        '
        Me.tlstpPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpPrintPreview.Image = CType(resources.GetObject("tlstpPrintPreview.Image"), System.Drawing.Image)
        Me.tlstpPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpPrintPreview.Name = "tlstpPrintPreview"
        Me.tlstpPrintPreview.Size = New System.Drawing.Size(23, 22)
        Me.tlstpPrintPreview.Text = "ToolStripButton1"
        Me.tlstpPrintPreview.ToolTipText = "Print preview diagram"
        '
        'tlstpPrint
        '
        Me.tlstpPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpPrint.Image = CType(resources.GetObject("tlstpPrint.Image"), System.Drawing.Image)
        Me.tlstpPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpPrint.Name = "tlstpPrint"
        Me.tlstpPrint.Size = New System.Drawing.Size(23, 22)
        Me.tlstpPrint.Text = "ToolStripButton1"
        Me.tlstpPrint.ToolTipText = "Print diagram"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tlstpUndo
        '
        Me.tlstpUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpUndo.Image = CType(resources.GetObject("tlstpUndo.Image"), System.Drawing.Image)
        Me.tlstpUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpUndo.Name = "tlstpUndo"
        Me.tlstpUndo.Size = New System.Drawing.Size(23, 22)
        Me.tlstpUndo.Text = "ToolStripButton1"
        Me.tlstpUndo.ToolTipText = "Undo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tlstpRedo
        '
        Me.tlstpRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpRedo.Image = CType(resources.GetObject("tlstpRedo.Image"), System.Drawing.Image)
        Me.tlstpRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpRedo.Name = "tlstpRedo"
        Me.tlstpRedo.Size = New System.Drawing.Size(23, 22)
        Me.tlstpRedo.Text = "ToolStripButton1"
        Me.tlstpRedo.ToolTipText = "Redo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tlstpCopy
        '
        Me.tlstpCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpCopy.Image = CType(resources.GetObject("tlstpCopy.Image"), System.Drawing.Image)
        Me.tlstpCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpCopy.Name = "tlstpCopy"
        Me.tlstpCopy.Size = New System.Drawing.Size(23, 22)
        Me.tlstpCopy.Text = "ToolStripButton1"
        Me.tlstpCopy.ToolTipText = "Copy"
        '
        'tlstpCut
        '
        Me.tlstpCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpCut.Image = CType(resources.GetObject("tlstpCut.Image"), System.Drawing.Image)
        Me.tlstpCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpCut.Name = "tlstpCut"
        Me.tlstpCut.Size = New System.Drawing.Size(23, 22)
        Me.tlstpCut.Text = "ToolStripButton2"
        Me.tlstpCut.ToolTipText = "Cut"
        '
        'tlstpPaste
        '
        Me.tlstpPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpPaste.Image = CType(resources.GetObject("tlstpPaste.Image"), System.Drawing.Image)
        Me.tlstpPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpPaste.Name = "tlstpPaste"
        Me.tlstpPaste.Size = New System.Drawing.Size(23, 22)
        Me.tlstpPaste.Text = "ToolStripButton3"
        Me.tlstpPaste.ToolTipText = "Paste"
        '
        'tlstpGrid
        '
        Me.tlstpGrid.Checked = True
        Me.tlstpGrid.CheckOnClick = True
        Me.tlstpGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tlstpGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpGrid.Image = CType(resources.GetObject("tlstpGrid.Image"), System.Drawing.Image)
        Me.tlstpGrid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpGrid.Name = "tlstpGrid"
        Me.tlstpGrid.Size = New System.Drawing.Size(23, 22)
        Me.tlstpGrid.Text = "ToolStripButton1"
        Me.tlstpGrid.ToolTipText = "Show/hide grid"
        '
        'tlstpZoomlevel
        '
        Me.tlstpZoomlevel.Name = "tlstpZoomlevel"
        Me.tlstpZoomlevel.Size = New System.Drawing.Size(47, 22)
        Me.tlstpZoomlevel.Text = "Zoom %"
        '
        'tlstpZoomPct
        '
        Me.tlstpZoomPct.Items.AddRange(New Object() {"100", "80", "60", "40", "20", "10"})
        Me.tlstpZoomPct.Name = "tlstpZoomPct"
        Me.tlstpZoomPct.Size = New System.Drawing.Size(75, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tlstpAbout
        '
        Me.tlstpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlstpAbout.Image = CType(resources.GetObject("tlstpAbout.Image"), System.Drawing.Image)
        Me.tlstpAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstpAbout.Name = "tlstpAbout"
        Me.tlstpAbout.Size = New System.Drawing.Size(23, 22)
        Me.tlstpAbout.Text = "ToolStripButton1"
        Me.tlstpAbout.ToolTipText = "About Flowton"
        '
        'tabManin
        '
        Me.tabManin.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabManin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabManin.Location = New System.Drawing.Point(242, 49)
        Me.tabManin.Name = "tabManin"
        Me.tabManin.SelectedIndex = 0
        Me.tabManin.Size = New System.Drawing.Size(556, 479)
        Me.tabManin.TabIndex = 2
        '
        'ctxTab
        '
        Me.ctxTab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewPageToolStripMenuItem, Me.RemovePageToolStripMenuItem, Me.RenamePageToolStripMenuItem, Me.ToolStripMenuItem1, Me.CloseDiagramToolStripMenuItem})
        Me.ctxTab.Name = "ctxTab"
        Me.ctxTab.Size = New System.Drawing.Size(144, 98)
        '
        'AddNewPageToolStripMenuItem
        '
        Me.AddNewPageToolStripMenuItem.Name = "AddNewPageToolStripMenuItem"
        Me.AddNewPageToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AddNewPageToolStripMenuItem.Text = "&Add new page"
        '
        'RemovePageToolStripMenuItem
        '
        Me.RemovePageToolStripMenuItem.Name = "RemovePageToolStripMenuItem"
        Me.RemovePageToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RemovePageToolStripMenuItem.Text = "&Remove page"
        '
        'RenamePageToolStripMenuItem
        '
        Me.RenamePageToolStripMenuItem.Name = "RenamePageToolStripMenuItem"
        Me.RenamePageToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RenamePageToolStripMenuItem.Text = "Re&name page"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(140, 6)
        '
        'CloseDiagramToolStripMenuItem
        '
        Me.CloseDiagramToolStripMenuItem.Name = "CloseDiagramToolStripMenuItem"
        Me.CloseDiagramToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CloseDiagramToolStripMenuItem.Text = "&Close diagram"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ProjectToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveasToolStripMenuItem, Me.ToolStripMenuItem5, Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExportToToolStripMenuItem, Me.ExportAllPagesToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveasToolStripMenuItem
        '
        Me.SaveasToolStripMenuItem.Name = "SaveasToolStripMenuItem"
        Me.SaveasToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SaveasToolStripMenuItem.Text = "Save &as"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(181, 6)
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print pre&view"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 6)
        '
        'ExportToToolStripMenuItem
        '
        Me.ExportToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JPGToolStripMenuItem, Me.PNGToolStripMenuItem, Me.BMPToolStripMenuItem, Me.EMFToolStripMenuItem})
        Me.ExportToToolStripMenuItem.Name = "ExportToToolStripMenuItem"
        Me.ExportToToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ExportToToolStripMenuItem.Text = "&Export current page to"
        '
        'JPGToolStripMenuItem
        '
        Me.JPGToolStripMenuItem.Name = "JPGToolStripMenuItem"
        Me.JPGToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.JPGToolStripMenuItem.Text = "JPG"
        '
        'PNGToolStripMenuItem
        '
        Me.PNGToolStripMenuItem.Name = "PNGToolStripMenuItem"
        Me.PNGToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.PNGToolStripMenuItem.Text = "PNG"
        '
        'BMPToolStripMenuItem
        '
        Me.BMPToolStripMenuItem.Name = "BMPToolStripMenuItem"
        Me.BMPToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.BMPToolStripMenuItem.Text = "BMP"
        '
        'EMFToolStripMenuItem
        '
        Me.EMFToolStripMenuItem.Name = "EMFToolStripMenuItem"
        Me.EMFToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EMFToolStripMenuItem.Text = "EMF"
        '
        'ExportAllPagesToolStripMenuItem
        '
        Me.ExportAllPagesToolStripMenuItem.Name = "ExportAllPagesToolStripMenuItem"
        Me.ExportAllPagesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ExportAllPagesToolStripMenuItem.Text = "Export all pages"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripMenuItem4, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectallToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(113, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'SelectallToolStripMenuItem
        '
        Me.SelectallToolStripMenuItem.Name = "SelectallToolStripMenuItem"
        Me.SelectallToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SelectallToolStripMenuItem.Text = "Select &all"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrientationToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ProjectToolStripMenuItem.Text = "&Diagram"
        '
        'OrientationToolStripMenuItem
        '
        Me.OrientationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortraitToolStripMenuItem, Me.LandscapeToolStripMenuItem})
        Me.OrientationToolStripMenuItem.Name = "OrientationToolStripMenuItem"
        Me.OrientationToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.OrientationToolStripMenuItem.Text = "Orientation"
        '
        'PortraitToolStripMenuItem
        '
        Me.PortraitToolStripMenuItem.Checked = True
        Me.PortraitToolStripMenuItem.CheckOnClick = True
        Me.PortraitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PortraitToolStripMenuItem.Name = "PortraitToolStripMenuItem"
        Me.PortraitToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PortraitToolStripMenuItem.Text = "&Portrait"
        '
        'LandscapeToolStripMenuItem
        '
        Me.LandscapeToolStripMenuItem.Name = "LandscapeToolStripMenuItem"
        Me.LandscapeToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.LandscapeToolStripMenuItem.Text = "&Landscape"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentToolStripMenuItem
        '
        Me.ContentToolStripMenuItem.Name = "ContentToolStripMenuItem"
        Me.ContentToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ContentToolStripMenuItem.Text = "&Content"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'FlowtonMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 528)
        Me.Controls.Add(Me.tabManin)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FlowtonMain"
        Me.Text = "Flowton"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ctxTab.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiagramSetController1 As Dataweb.NShape.Controllers.DiagramSetController
    Friend WithEvents Project1 As Dataweb.NShape.Project
    Friend WithEvents CachedRepository1 As Dataweb.NShape.Advanced.CachedRepository
    Friend WithEvents XmlStore1 As Dataweb.NShape.XmlStore
    Friend WithEvents ToolSetController1 As Dataweb.NShape.Controllers.ToolSetController
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ToolSetListViewPresenter1 As Dataweb.NShape.WinFormsUI.ToolSetListViewPresenter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents PropertyPresenter1 As Dataweb.NShape.WinFormsUI.PropertyPresenter
    Friend WithEvents PropertyController1 As Dataweb.NShape.Controllers.PropertyController
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlstpNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlstpOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlstpSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlstpAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstpCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlstpCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlstpPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tabManin As System.Windows.Forms.TabControl
    Friend WithEvents ctxTab As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddNewPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenamePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseDiagramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrientationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortraitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LandscapeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlstpUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstpRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstpZoomlevel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlstpZoomPct As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents JPGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BMPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAllPagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlstpGrid As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstpPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlstpPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
