﻿Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraScheduler


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.schedulerSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
        Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
        Me.dateNavigator = New DevExpress.XtraScheduler.DateNavigator()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.popupControlContainer2 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.buttonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.someLabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.someLabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.ddbiSkins = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.rgbiPalettes = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.SchedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
        Me.ActionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
        Me.AppointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
        Me.CalendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
        Me.EditOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
        Me.EditSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
        Me.EditAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
        Me.DeleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
        Me.DeleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
        Me.DeleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
        Me.SplitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
        Me.OptionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
        Me.ChangeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
        Me.ChangeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
        Me.ToggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
        Me.ChangeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
        Me.RepositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
        Me.ActiveViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
        Me.ViewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
        Me.SwitchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
        Me.SwitchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
        Me.SwitchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
        Me.TimeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
        Me.SwitchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
        Me.ChangeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
        Me.SwitchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.LayoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
        Me.SwitchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
        Me.SwitchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
        Me.SwitchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
        Me.ChangeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
        Me.AppointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
        Me.HomeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
        Me.NewAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
        Me.NewRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
        Me.NavigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
        Me.NavigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
        Me.NavigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
        Me.GotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
        Me.ViewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
        Me.ViewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
        Me.GroupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
        Me.GroupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
        Me.GroupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
        Me.GroupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
        Me.FileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
        Me.OpenScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
        Me.SaveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
        Me.PrintPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
        Me.PrintItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
        Me.PrintPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerControl.SuspendLayout()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.schedulerSplitContainerControl.SuspendLayout()
        CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNavigator.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer2.SuspendLayout()
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer1.SuspendLayout()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainerControl
        '
        Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerControl.Location = New System.Drawing.Point(0, 158)
        Me.splitContainerControl.Name = "splitContainerControl"
        Me.splitContainerControl.Padding = New System.Windows.Forms.Padding(6)
        Me.splitContainerControl.Panel1.Text = "Panel1"
        Me.splitContainerControl.Panel2.Controls.Add(Me.schedulerSplitContainerControl)
        Me.splitContainerControl.Panel2.Text = "Panel2"
        Me.splitContainerControl.Size = New System.Drawing.Size(1100, 518)
        Me.splitContainerControl.SplitterPosition = 0
        Me.splitContainerControl.TabIndex = 1
        Me.splitContainerControl.Text = "splitContainerControl1"
        '
        'navbarImageCollectionLarge
        '
        Me.navbarImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.navbarImageCollectionLarge.ImageStream = CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_32x32.png")
        Me.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_32x32.png")
        '
        'navbarImageCollection
        '
        Me.navbarImageCollection.ImageStream = CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png")
        '
        'schedulerSplitContainerControl
        '
        Me.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.schedulerSplitContainerControl.Location = New System.Drawing.Point(0, 0)
        Me.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl"
        Me.schedulerSplitContainerControl.Panel1.Controls.Add(Me.schedulerControl)
        Me.schedulerSplitContainerControl.Panel1.Text = "Panel1"
        Me.schedulerSplitContainerControl.Panel2.Controls.Add(Me.dateNavigator)
        Me.schedulerSplitContainerControl.Panel2.Text = "Panel2"
        Me.schedulerSplitContainerControl.Size = New System.Drawing.Size(1078, 506)
        Me.schedulerSplitContainerControl.SplitterPosition = 225
        Me.schedulerSplitContainerControl.TabIndex = 3
        Me.schedulerSplitContainerControl.Text = "splitContainerControl1"
        '
        'schedulerControl
        '
        Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek
        Me.schedulerControl.DataStorage = Me.schedulerStorage
        Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
        Me.schedulerControl.Name = "schedulerControl"
        Me.schedulerControl.Size = New System.Drawing.Size(843, 506)
        Me.schedulerControl.Start = New Date(2020, 4, 19, 0, 0, 0, 0)
        Me.schedulerControl.TabIndex = 0
        Me.schedulerControl.Text = "schedulerControl1"
        Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.schedulerControl.Views.FullWeekView.Enabled = True
        Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.schedulerControl.Views.GanttView.Enabled = False
        Me.schedulerControl.Views.MonthView.Enabled = False
        Me.schedulerControl.Views.TimelineView.Enabled = False
        Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'dateNavigator
        '
        Me.dateNavigator.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateNavigator.DateTime = New Date(2020, 4, 19, 0, 0, 0, 0)
        Me.dateNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dateNavigator.EditValue = New Date(2020, 4, 19, 0, 0, 0, 0)
        Me.dateNavigator.FirstDayOfWeek = System.DayOfWeek.Sunday
        Me.dateNavigator.Location = New System.Drawing.Point(0, 0)
        Me.dateNavigator.Name = "dateNavigator"
        Me.dateNavigator.SchedulerControl = Me.schedulerControl
        Me.dateNavigator.Size = New System.Drawing.Size(225, 506)
        Me.dateNavigator.TabIndex = 1
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.SearchEditItem, Me.ribbonControl.ExpandCollapseItem, Me.iExit, Me.iHelp, Me.iAbout, Me.siStatus, Me.siInfo, Me.ddbiSkins, Me.rgbiPalettes, Me.EditAppointmentQueryItem1, Me.EditOccurrenceUICommandItem1, Me.EditSeriesUICommandItem1, Me.DeleteAppointmentsItem1, Me.DeleteOccurrenceItem1, Me.DeleteSeriesItem1, Me.SplitAppointmentItem1, Me.ChangeAppointmentStatusItem1, Me.ChangeAppointmentLabelItem1, Me.ToggleRecurrenceItem1, Me.ChangeAppointmentReminderItem1, Me.SwitchToWeekViewItem1, Me.SwitchToFullWeekViewItem1, Me.SwitchToAgendaViewItem1, Me.SwitchTimeScalesItem1, Me.ChangeScaleWidthItem1, Me.SwitchTimeScalesCaptionItem1, Me.SwitchCompressWeekendItem1, Me.SwitchShowWorkTimeOnlyItem1, Me.SwitchCellsAutoHeightItem1, Me.ChangeSnapToCellsUIItem1, Me.NewAppointmentItem1, Me.NewRecurringAppointmentItem1, Me.NavigateViewBackwardItem1, Me.NavigateViewForwardItem1, Me.GotoTodayItem1, Me.ViewZoomInItem1, Me.ViewZoomOutItem1, Me.GroupByNoneItem1, Me.GroupByDateItem1, Me.GroupByResourceItem1, Me.OpenScheduleItem1, Me.SaveScheduleItem1, Me.PrintPreviewItem1, Me.PrintItem1, Me.PrintPageSetupItem1})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 103
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.CalendarToolsRibbonPageCategory1})
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.iAbout)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.HomeRibbonPage1, Me.ViewRibbonPage1})
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.iHelp)
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDuration1, Me.RepositoryItemSpinEdit1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.Size = New System.Drawing.Size(1100, 158)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        '
        'appMenu
        '
        Me.appMenu.BottomPaneControlContainer = Me.popupControlContainer2
        Me.appMenu.ItemLinks.Add(Me.iExit)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.RightPaneControlContainer = Me.popupControlContainer1
        Me.appMenu.ShowRightPane = True
        '
        'popupControlContainer2
        '
        Me.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer2.Appearance.Options.UseBackColor = True
        Me.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer2.Controls.Add(Me.buttonEdit)
        Me.popupControlContainer2.Location = New System.Drawing.Point(238, 289)
        Me.popupControlContainer2.Name = "popupControlContainer2"
        Me.popupControlContainer2.Ribbon = Me.ribbonControl
        Me.popupControlContainer2.Size = New System.Drawing.Size(118, 28)
        Me.popupControlContainer2.TabIndex = 7
        Me.popupControlContainer2.Visible = False
        '
        'buttonEdit
        '
        Me.buttonEdit.EditValue = "Some Text"
        Me.buttonEdit.Location = New System.Drawing.Point(3, 5)
        Me.buttonEdit.MenuManager = Me.ribbonControl
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.buttonEdit.Size = New System.Drawing.Size(100, 20)
        Me.buttonEdit.TabIndex = 0
        '
        'iExit
        '
        Me.iExit.Caption = "Exit"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageOptions.ImageIndex = 6
        Me.iExit.ImageOptions.LargeImageIndex = 6
        Me.iExit.Name = "iExit"
        '
        'popupControlContainer1
        '
        Me.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer1.Appearance.Options.UseBackColor = True
        Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer1.Controls.Add(Me.someLabelControl2)
        Me.popupControlContainer1.Controls.Add(Me.someLabelControl1)
        Me.popupControlContainer1.Location = New System.Drawing.Point(111, 197)
        Me.popupControlContainer1.Name = "popupControlContainer1"
        Me.popupControlContainer1.Ribbon = Me.ribbonControl
        Me.popupControlContainer1.Size = New System.Drawing.Size(76, 70)
        Me.popupControlContainer1.TabIndex = 6
        Me.popupControlContainer1.Visible = False
        '
        'someLabelControl2
        '
        Me.someLabelControl2.Location = New System.Drawing.Point(3, 57)
        Me.someLabelControl2.Name = "someLabelControl2"
        Me.someLabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.someLabelControl2.TabIndex = 0
        Me.someLabelControl2.Text = "Some Info"
        '
        'someLabelControl1
        '
        Me.someLabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.someLabelControl1.Name = "someLabelControl1"
        Me.someLabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.someLabelControl1.TabIndex = 0
        Me.someLabelControl1.Text = "Some Info"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'iHelp
        '
        Me.iHelp.Caption = "Help"
        Me.iHelp.Description = "Start the program help system."
        Me.iHelp.Hint = "Start the program help system"
        Me.iHelp.Id = 22
        Me.iHelp.ImageOptions.ImageIndex = 7
        Me.iHelp.ImageOptions.LargeImageIndex = 7
        Me.iHelp.Name = "iHelp"
        '
        'iAbout
        '
        Me.iAbout.Caption = "About"
        Me.iAbout.Description = "Displays general program information."
        Me.iAbout.Hint = "Displays general program information"
        Me.iAbout.Id = 24
        Me.iAbout.ImageOptions.ImageIndex = 8
        Me.iAbout.ImageOptions.LargeImageIndex = 8
        Me.iAbout.Name = "iAbout"
        '
        'siStatus
        '
        Me.siStatus.Caption = "Some Status Info"
        Me.siStatus.Id = 31
        Me.siStatus.Name = "siStatus"
        '
        'siInfo
        '
        Me.siInfo.Caption = "Some Info"
        Me.siInfo.Id = 32
        Me.siInfo.Name = "siInfo"
        '
        'ddbiSkins
        '
        Me.ddbiSkins.Id = 60
        Me.ddbiSkins.Name = "ddbiSkins"
        '
        'rgbiPalettes
        '
        Me.rgbiPalettes.Id = 61
        Me.rgbiPalettes.Name = "rgbiPalettes"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
        Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 676)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1100, 24)
        '
        'SchedulerBarController1
        '
        Me.SchedulerBarController1.BarItems.Add(Me.EditOccurrenceUICommandItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditSeriesUICommandItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditAppointmentQueryItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteOccurrenceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteSeriesItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteAppointmentsItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SplitAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentStatusItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentLabelItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ToggleRecurrenceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentReminderItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToFullWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToAgendaViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchTimeScalesItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeScaleWidthItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchTimeScalesCaptionItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchCompressWeekendItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchShowWorkTimeOnlyItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchCellsAutoHeightItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeSnapToCellsUIItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewRecurringAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewBackwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewForwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GotoTodayItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomInItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomOutItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByNoneItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByDateItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByResourceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.OpenScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SaveScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPreviewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPageSetupItem1)
        Me.SchedulerBarController1.Control = Me.schedulerControl
        '
        'ActionsRibbonPageGroup1
        '
        Me.ActionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.EditAppointmentQueryItem1)
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.DeleteAppointmentsItem1)
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.SplitAppointmentItem1)
        Me.ActionsRibbonPageGroup1.Name = "ActionsRibbonPageGroup1"
        '
        'AppointmentRibbonPage1
        '
        Me.AppointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActionsRibbonPageGroup1, Me.OptionsRibbonPageGroup1})
        Me.AppointmentRibbonPage1.Name = "AppointmentRibbonPage1"
        Me.AppointmentRibbonPage1.Visible = False
        '
        'CalendarToolsRibbonPageCategory1
        '
        Me.CalendarToolsRibbonPageCategory1.Control = Me.schedulerControl
        Me.CalendarToolsRibbonPageCategory1.Name = "CalendarToolsRibbonPageCategory1"
        Me.CalendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.AppointmentRibbonPage1})
        Me.CalendarToolsRibbonPageCategory1.Visible = False
        '
        'EditOccurrenceUICommandItem1
        '
        Me.EditOccurrenceUICommandItem1.Id = 63
        Me.EditOccurrenceUICommandItem1.Name = "EditOccurrenceUICommandItem1"
        '
        'EditSeriesUICommandItem1
        '
        Me.EditSeriesUICommandItem1.Id = 64
        Me.EditSeriesUICommandItem1.Name = "EditSeriesUICommandItem1"
        '
        'EditAppointmentQueryItem1
        '
        Me.EditAppointmentQueryItem1.Id = 62
        Me.EditAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.EditOccurrenceUICommandItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.EditSeriesUICommandItem1)})
        Me.EditAppointmentQueryItem1.Name = "EditAppointmentQueryItem1"
        Me.EditAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'DeleteOccurrenceItem1
        '
        Me.DeleteOccurrenceItem1.Id = 66
        Me.DeleteOccurrenceItem1.Name = "DeleteOccurrenceItem1"
        '
        'DeleteSeriesItem1
        '
        Me.DeleteSeriesItem1.Id = 67
        Me.DeleteSeriesItem1.Name = "DeleteSeriesItem1"
        '
        'DeleteAppointmentsItem1
        '
        Me.DeleteAppointmentsItem1.Id = 65
        Me.DeleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteOccurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteSeriesItem1)})
        Me.DeleteAppointmentsItem1.Name = "DeleteAppointmentsItem1"
        Me.DeleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'SplitAppointmentItem1
        '
        Me.SplitAppointmentItem1.Id = 68
        Me.SplitAppointmentItem1.Name = "SplitAppointmentItem1"
        '
        'OptionsRibbonPageGroup1
        '
        Me.OptionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentStatusItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentLabelItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ToggleRecurrenceItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentReminderItem1)
        Me.OptionsRibbonPageGroup1.Name = "OptionsRibbonPageGroup1"
        '
        'ChangeAppointmentStatusItem1
        '
        Me.ChangeAppointmentStatusItem1.Id = 69
        Me.ChangeAppointmentStatusItem1.Name = "ChangeAppointmentStatusItem1"
        '
        'ChangeAppointmentLabelItem1
        '
        Me.ChangeAppointmentLabelItem1.Id = 70
        Me.ChangeAppointmentLabelItem1.Name = "ChangeAppointmentLabelItem1"
        '
        'ToggleRecurrenceItem1
        '
        Me.ToggleRecurrenceItem1.Id = 71
        Me.ToggleRecurrenceItem1.Name = "ToggleRecurrenceItem1"
        '
        'ChangeAppointmentReminderItem1
        '
        Me.ChangeAppointmentReminderItem1.Edit = Me.RepositoryItemDuration1
        Me.ChangeAppointmentReminderItem1.Id = 72
        Me.ChangeAppointmentReminderItem1.Name = "ChangeAppointmentReminderItem1"
        '
        'RepositoryItemDuration1
        '
        Me.RepositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDuration1.AutoHeight = False
        Me.RepositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDuration1.DisabledStateText = Nothing
        Me.RepositoryItemDuration1.Name = "RepositoryItemDuration1"
        Me.RepositoryItemDuration1.ShowEmptyItem = True
        Me.RepositoryItemDuration1.ValidateOnEnterKey = True
        '
        'ActiveViewRibbonPageGroup1
        '
        Me.ActiveViewRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToFullWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToAgendaViewItem1)
        Me.ActiveViewRibbonPageGroup1.Name = "ActiveViewRibbonPageGroup1"
        '
        'ViewRibbonPage1
        '
        Me.ViewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActiveViewRibbonPageGroup1, Me.TimeScaleRibbonPageGroup1, Me.LayoutRibbonPageGroup1})
        Me.ViewRibbonPage1.Name = "ViewRibbonPage1"
        '
        'SwitchToWeekViewItem1
        '
        Me.SwitchToWeekViewItem1.Id = 75
        Me.SwitchToWeekViewItem1.Name = "SwitchToWeekViewItem1"
        '
        'SwitchToFullWeekViewItem1
        '
        Me.SwitchToFullWeekViewItem1.Id = 76
        Me.SwitchToFullWeekViewItem1.Name = "SwitchToFullWeekViewItem1"
        '
        'SwitchToAgendaViewItem1
        '
        Me.SwitchToAgendaViewItem1.Id = 80
        Me.SwitchToAgendaViewItem1.Name = "SwitchToAgendaViewItem1"
        '
        'TimeScaleRibbonPageGroup1
        '
        Me.TimeScaleRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.SwitchTimeScalesItem1)
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.ChangeScaleWidthItem1)
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.SwitchTimeScalesCaptionItem1)
        Me.TimeScaleRibbonPageGroup1.Name = "TimeScaleRibbonPageGroup1"
        '
        'SwitchTimeScalesItem1
        '
        Me.SwitchTimeScalesItem1.Id = 81
        Me.SwitchTimeScalesItem1.Name = "SwitchTimeScalesItem1"
        '
        'ChangeScaleWidthItem1
        '
        Me.ChangeScaleWidthItem1.Edit = Me.RepositoryItemSpinEdit1
        Me.ChangeScaleWidthItem1.Id = 82
        Me.ChangeScaleWidthItem1.Name = "ChangeScaleWidthItem1"
        Me.ChangeScaleWidthItem1.UseCommandCaption = True
        '
        'SwitchTimeScalesCaptionItem1
        '
        Me.SwitchTimeScalesCaptionItem1.Id = 83
        Me.SwitchTimeScalesCaptionItem1.Name = "SwitchTimeScalesCaptionItem1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'LayoutRibbonPageGroup1
        '
        Me.LayoutRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchCompressWeekendItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchShowWorkTimeOnlyItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchCellsAutoHeightItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.ChangeSnapToCellsUIItem1)
        Me.LayoutRibbonPageGroup1.Name = "LayoutRibbonPageGroup1"
        '
        'SwitchCompressWeekendItem1
        '
        Me.SwitchCompressWeekendItem1.Id = 84
        Me.SwitchCompressWeekendItem1.Name = "SwitchCompressWeekendItem1"
        '
        'SwitchShowWorkTimeOnlyItem1
        '
        Me.SwitchShowWorkTimeOnlyItem1.Id = 85
        Me.SwitchShowWorkTimeOnlyItem1.Name = "SwitchShowWorkTimeOnlyItem1"
        '
        'SwitchCellsAutoHeightItem1
        '
        Me.SwitchCellsAutoHeightItem1.Id = 86
        Me.SwitchCellsAutoHeightItem1.Name = "SwitchCellsAutoHeightItem1"
        '
        'ChangeSnapToCellsUIItem1
        '
        Me.ChangeSnapToCellsUIItem1.Id = 87
        Me.ChangeSnapToCellsUIItem1.Name = "ChangeSnapToCellsUIItem1"
        '
        'AppointmentRibbonPageGroup1
        '
        Me.AppointmentRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.AppointmentRibbonPageGroup1.ItemLinks.Add(Me.NewAppointmentItem1)
        Me.AppointmentRibbonPageGroup1.ItemLinks.Add(Me.NewRecurringAppointmentItem1)
        Me.AppointmentRibbonPageGroup1.Name = "AppointmentRibbonPageGroup1"
        '
        'HomeRibbonPage1
        '
        Me.HomeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.AppointmentRibbonPageGroup1, Me.NavigatorRibbonPageGroup1, Me.GroupByRibbonPageGroup1})
        Me.HomeRibbonPage1.Name = "HomeRibbonPage1"
        '
        'NewAppointmentItem1
        '
        Me.NewAppointmentItem1.Id = 88
        Me.NewAppointmentItem1.Name = "NewAppointmentItem1"
        '
        'NewRecurringAppointmentItem1
        '
        Me.NewRecurringAppointmentItem1.Id = 89
        Me.NewRecurringAppointmentItem1.Name = "NewRecurringAppointmentItem1"
        '
        'NavigatorRibbonPageGroup1
        '
        Me.NavigatorRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.NavigateViewBackwardItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.NavigateViewForwardItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.GotoTodayItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.ViewZoomInItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.ViewZoomOutItem1)
        Me.NavigatorRibbonPageGroup1.Name = "NavigatorRibbonPageGroup1"
        '
        'NavigateViewBackwardItem1
        '
        Me.NavigateViewBackwardItem1.Id = 90
        Me.NavigateViewBackwardItem1.Name = "NavigateViewBackwardItem1"
        '
        'NavigateViewForwardItem1
        '
        Me.NavigateViewForwardItem1.Id = 91
        Me.NavigateViewForwardItem1.Name = "NavigateViewForwardItem1"
        '
        'GotoTodayItem1
        '
        Me.GotoTodayItem1.Id = 92
        Me.GotoTodayItem1.Name = "GotoTodayItem1"
        '
        'ViewZoomInItem1
        '
        Me.ViewZoomInItem1.Id = 93
        Me.ViewZoomInItem1.Name = "ViewZoomInItem1"
        '
        'ViewZoomOutItem1
        '
        Me.ViewZoomOutItem1.Id = 94
        Me.ViewZoomOutItem1.Name = "ViewZoomOutItem1"
        '
        'GroupByRibbonPageGroup1
        '
        Me.GroupByRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByNoneItem1)
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByDateItem1)
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByResourceItem1)
        Me.GroupByRibbonPageGroup1.Name = "GroupByRibbonPageGroup1"
        '
        'GroupByNoneItem1
        '
        Me.GroupByNoneItem1.Id = 95
        Me.GroupByNoneItem1.Name = "GroupByNoneItem1"
        '
        'GroupByDateItem1
        '
        Me.GroupByDateItem1.Id = 96
        Me.GroupByDateItem1.Name = "GroupByDateItem1"
        '
        'GroupByResourceItem1
        '
        Me.GroupByResourceItem1.Id = 97
        Me.GroupByResourceItem1.Name = "GroupByResourceItem1"
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.OpenScheduleItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SaveScheduleItem1)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        '
        'OpenScheduleItem1
        '
        Me.OpenScheduleItem1.Id = 98
        Me.OpenScheduleItem1.Name = "OpenScheduleItem1"
        '
        'SaveScheduleItem1
        '
        Me.SaveScheduleItem1.Id = 99
        Me.SaveScheduleItem1.Name = "SaveScheduleItem1"
        '
        'PrintPreviewItem1
        '
        Me.PrintPreviewItem1.Id = 100
        Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
        '
        'PrintItem1
        '
        Me.PrintItem1.Id = 101
        Me.PrintItem1.Name = "PrintItem1"
        '
        'PrintPageSetupItem1
        '
        Me.PrintPageSetupItem1.Id = 102
        Me.PrintPageSetupItem1.Name = "PrintPageSetupItem1"
        '
        'Form1
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.splitContainerControl)
        Me.Controls.Add(Me.popupControlContainer1)
        Me.Controls.Add(Me.popupControlContainer2)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Weekly Scheduler by Paul Hankewicz"
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerControl.ResumeLayout(False)
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.schedulerSplitContainerControl.ResumeLayout(False)
        CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNavigator.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer2.ResumeLayout(False)
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer1.ResumeLayout(False)
        Me.popupControlContainer1.PerformLayout()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Private WithEvents siInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents ddbiSkins As DevExpress.XtraBars.SkinDropDownButtonItem
    Private WithEvents rgbiPalettes As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
    Private WithEvents iHelp As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents someLabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents someLabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents popupControlContainer2 As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents buttonEdit As DevExpress.XtraEditors.ButtonEdit
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents schedulerSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
    Private WithEvents dateNavigator As DevExpress.XtraScheduler.DateNavigator
    Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerDataStorage
    Friend WithEvents EditAppointmentQueryItem1 As UI.EditAppointmentQueryItem
    Friend WithEvents EditOccurrenceUICommandItem1 As UI.EditOccurrenceUICommandItem
    Friend WithEvents EditSeriesUICommandItem1 As UI.EditSeriesUICommandItem
    Friend WithEvents DeleteAppointmentsItem1 As UI.DeleteAppointmentsItem
    Friend WithEvents DeleteOccurrenceItem1 As UI.DeleteOccurrenceItem
    Friend WithEvents DeleteSeriesItem1 As UI.DeleteSeriesItem
    Friend WithEvents SplitAppointmentItem1 As UI.SplitAppointmentItem
    Friend WithEvents ChangeAppointmentStatusItem1 As UI.ChangeAppointmentStatusItem
    Friend WithEvents ChangeAppointmentLabelItem1 As UI.ChangeAppointmentLabelItem
    Friend WithEvents ToggleRecurrenceItem1 As UI.ToggleRecurrenceItem
    Friend WithEvents ChangeAppointmentReminderItem1 As UI.ChangeAppointmentReminderItem
    Friend WithEvents RepositoryItemDuration1 As UI.RepositoryItemDuration
    Friend WithEvents SwitchToWeekViewItem1 As UI.SwitchToWeekViewItem
    Friend WithEvents SwitchToFullWeekViewItem1 As UI.SwitchToFullWeekViewItem
    Friend WithEvents SwitchToAgendaViewItem1 As UI.SwitchToAgendaViewItem
    Friend WithEvents SwitchTimeScalesItem1 As UI.SwitchTimeScalesItem
    Friend WithEvents ChangeScaleWidthItem1 As UI.ChangeScaleWidthItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SwitchTimeScalesCaptionItem1 As UI.SwitchTimeScalesCaptionItem
    Friend WithEvents SwitchCompressWeekendItem1 As UI.SwitchCompressWeekendItem
    Friend WithEvents SwitchShowWorkTimeOnlyItem1 As UI.SwitchShowWorkTimeOnlyItem
    Friend WithEvents SwitchCellsAutoHeightItem1 As UI.SwitchCellsAutoHeightItem
    Friend WithEvents ChangeSnapToCellsUIItem1 As UI.ChangeSnapToCellsUIItem
    Friend WithEvents NewAppointmentItem1 As UI.NewAppointmentItem
    Friend WithEvents NewRecurringAppointmentItem1 As UI.NewRecurringAppointmentItem
    Friend WithEvents NavigateViewBackwardItem1 As UI.NavigateViewBackwardItem
    Friend WithEvents NavigateViewForwardItem1 As UI.NavigateViewForwardItem
    Friend WithEvents GotoTodayItem1 As UI.GotoTodayItem
    Friend WithEvents ViewZoomInItem1 As UI.ViewZoomInItem
    Friend WithEvents ViewZoomOutItem1 As UI.ViewZoomOutItem
    Friend WithEvents GroupByNoneItem1 As UI.GroupByNoneItem
    Friend WithEvents GroupByDateItem1 As UI.GroupByDateItem
    Friend WithEvents GroupByResourceItem1 As UI.GroupByResourceItem
    Friend WithEvents OpenScheduleItem1 As UI.OpenScheduleItem
    Friend WithEvents SaveScheduleItem1 As UI.SaveScheduleItem
    Friend WithEvents PrintPreviewItem1 As UI.PrintPreviewItem
    Friend WithEvents PrintItem1 As UI.PrintItem
    Friend WithEvents PrintPageSetupItem1 As UI.PrintPageSetupItem
    Friend WithEvents CalendarToolsRibbonPageCategory1 As UI.CalendarToolsRibbonPageCategory
    Friend WithEvents AppointmentRibbonPage1 As UI.AppointmentRibbonPage
    Friend WithEvents ActionsRibbonPageGroup1 As UI.ActionsRibbonPageGroup
    Friend WithEvents OptionsRibbonPageGroup1 As UI.OptionsRibbonPageGroup
    Friend WithEvents FileRibbonPage1 As UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As UI.CommonRibbonPageGroup
    Friend WithEvents HomeRibbonPage1 As UI.HomeRibbonPage
    Friend WithEvents AppointmentRibbonPageGroup1 As UI.AppointmentRibbonPageGroup
    Friend WithEvents NavigatorRibbonPageGroup1 As UI.NavigatorRibbonPageGroup
    Friend WithEvents GroupByRibbonPageGroup1 As UI.GroupByRibbonPageGroup
    Friend WithEvents ViewRibbonPage1 As UI.ViewRibbonPage
    Friend WithEvents ActiveViewRibbonPageGroup1 As UI.ActiveViewRibbonPageGroup
    Friend WithEvents TimeScaleRibbonPageGroup1 As UI.TimeScaleRibbonPageGroup
    Friend WithEvents LayoutRibbonPageGroup1 As UI.LayoutRibbonPageGroup
    Friend WithEvents SchedulerBarController1 As UI.SchedulerBarController
End Class
