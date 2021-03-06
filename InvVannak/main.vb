Public Class main
    Dim DAUserRight As New DSItemTableAdapters.USER_RIGHTTableAdapter
    Dim DAUser As New DSItemTableAdapters.USERTableAdapter
    Dim DABroadcast As New DSItemTableAdapters.POST_TEXTTableAdapter
    Dim UItem As New UC_Item
    Dim UCategory As New UC_Category
    Dim UUnit As New UC_Unit
    Dim UUser As New UC_User
    Dim URight As New UC_AccessRight

    Dim URptItem As New UC_RptItem
    Dim URptStore As New UC_RptStore
    Dim URptReceive As New UC_RptReceive
    Dim URptIssue As New UC_RptIssue
    Dim URptAdjust As New UC_RptAdjust
    Dim URptTransaction As New UC_RptTransaction

    Dim UStore As New UC_Store
    Dim UReceive As New UC_Receive
    Dim UIssue As New UC_Issue
    Dim UAdjust As New UC_Adjustment
    Dim ULocation As New UC_Location
    Dim UBroadcast As New UC_Broadcast

    ' User Interface Main Dashboard
    Dim DCustomer As New DashboardCustomers
    Dim DMainInventory As New DashboardMainInventory
    Dim DSupplier As New DashboardSupplier
    Dim DProduct As New DashboardItems
    Dim DMeasurement As New DashboardMeasurement
    Dim DCategory As New DashboardCategory
    Dim DPuchaseOrder As New DashboardPurchaseOrder
    Dim DProductSale As New DashboardProductSale
    Dim DAccountPayable As New DashboradAccoudPayable
    Dim DSRevenues As New DashbordRevenue
    Dim DAccountReceivable As New DashboardAccountReceivable
    Dim DAAdjustment As New DashboardAdjustStock


    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ChangeInputLanguageBar()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub AddUserControlToPanel(ByVal Panel As Panel, ByVal UI As UserControl)
        Panel.Controls.Clear()
        Panel.AutoScroll = True
        UI.Dock = DockStyle.Fill
        Panel.Controls.Add(UI)
    End Sub
    Sub AddUserControl(ByVal PMainContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer, ByVal UI As UserControl, ByVal Info As String)
        Me.Cursor = Cursors.WaitCursor
        PMainContainer.Controls.Clear()
        PMainContainer.AutoScroll = True
        'PMainContainer.AutoScrollMinSize = New Size(UI.Width, UI.Height)
        UI.Dock = DockStyle.Fill
        PMainContainer.Controls.Add(UI)
        Me.Cursor = Cursors.Default
        uiPanel1.Text = Info
    End Sub

    Private Sub ButtonBar1_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Select Case e.Item.Key
            Case "Item"
                UItem.RefreshList()
                AddUserControl(Me.MainContainer, UItem, "ITEM INFORMATION")
            Case "ItemCategory"
                UCategory.RefreshList()
                AddUserControl(Me.MainContainer, UCategory, "ITEM CATEGORY")
            Case "ItemUnit"
                UUnit.RefreshList()
                AddUserControl(Me.MainContainer, UUnit, "ITEM UNIT")
        End Select
    End Sub

    Private Sub ButtonBar2_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar2.ItemClick
        Select Case e.Item.Key
            Case "ItemStore"
                UStore.RefreshList()
                AddUserControl(Me.MainContainer, UStore, "ITEM STORE")
            Case "ReceiveItem"
                UReceive.RefreshList()
                AddUserControl(Me.MainContainer, UReceive, "RECEIVE ITEM")
            Case "IssueItem"
                UIssue.RefreshList()
                AddUserControl(Me.MainContainer, UIssue, "ISSUE ITEM")
            Case "AdjustItem"
                UAdjust.RefreshList()
                AddUserControl(Me.MainContainer, UAdjust, "ADJUST ITEM")
        End Select
    End Sub

    Private Sub ButtonBar3_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar3.ItemClick
        Select Case e.Item.Key
            Case "ItemList"
                URptItem.RefreshList()
                AddUserControl(Me.MainContainer, URptItem, "ITEMS")
            Case "StoreBalance"
                URptStore.RefreshList()
                AddUserControl(Me.MainContainer, URptStore, "STORE BALANCE")
            Case "ReceiveStore"
                URptReceive.RefreshList()
                AddUserControl(Me.MainContainer, URptReceive, "RECEIVED ITEMS")
            Case "IssueStore"
                URptIssue.RefreshList()
                AddUserControl(Me.MainContainer, URptIssue, "ISSUED ITEMS")
            Case "AdjustStore"
                URptAdjust.RefreshList()
                AddUserControl(Me.MainContainer, URptAdjust, "ADJUSTED ITEMS")
            Case "StoreTransaction"
                URptTransaction.RefreshList()
                AddUserControl(Me.MainContainer, URptTransaction, "STORE TRANSACTION")
        End Select
    End Sub

    Private Sub RibboStatusBar_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles RibboStatusBar.CommandClick

    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnExit.Click
        If MessageBox.Show("Do you want to close the application?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ButtonBar4_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar4.ItemClick
        Select Case e.Item.Key
            Case "User"
                URptItem.RefreshList()
                AddUserControl(Me.MainContainer, UUser, "USERS")
            Case "UserRight"
                AddUserControl(Me.MainContainer, URight, "User Privileges")
            Case "Broadcast"
                UBroadcast.RefreshList()
                AddUserControl(Me.MainContainer, UBroadcast, "Broadcast")
            Case "Location"
                Dim ULocation As New UC_Location
                ULocation.RefreshList()
                AddUserControl(Me.MainContainer, ULocation, "Location")
        End Select
    End Sub

    Private Sub main_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        '' Broadcast
        Me.lblBroadcast.Width = Me.MainContainer.Width
    End Sub

    Public Function MarqueeLeft(ByVal Text As String)
        Dim Str1 As String = Text.Remove(0, 1)
        Dim Str2 As String = Text(0)
        Return Str1 & Str2
    End Function
    Private Sub movetext()
        Me.lbltest.Top = Me.lblBroadcast.Top + 4
        Dim MainLeft As Integer = Me.lblBroadcast.Left
        Dim MainWidth As Integer = Me.lblBroadcast.Width
        Dim MyLeft As Integer = Me.lbltest.Left
        Dim i As Integer = 0
        If MyLeft = MainLeft - Me.lbltest.Width Then
            Me.lbltest.Left = Me.lblBroadcast.Left + Me.lblBroadcast.Width
        Else
            Me.lbltest.Left = MyLeft - 1
        End If

    End Sub
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    ''lblBroadcast.Text = MarqueeLeft(lblBroadcast.Text)
    '    movetext()
    '    Dim MaxTextID As Long = 0
    '    MaxTextID = DABroadcast.getMaxID
    '    'Me.lbltest.Text = DABroadcast.SelectByID(MaxTextID).Rows(0).Item("TEXT_DESC").ToString
    'End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChangeInputLanguageBar()
        TreeViewMainInventory.ExpandAll()
        ''Get Broadcast information
        Dim MaxTextID As Long = 0
        MaxTextID = DABroadcast.getMaxID
        Me.lbltest.Text = DABroadcast.SelectByID(MaxTextID).Rows(0).Item("TEXT_DESC").ToString
        Me.lbltest.Left = Me.lblBroadcast.Left + Me.lblBroadcast.Width


        '' User Right Processing
        If DAUser.SelectUserByID(getCurrentUserID).Rows(0).Item("USER_GROUP") <> "Administrator" Then
            ButtonBar7.Groups(0).Items("SaleProduct").Enabled = True
            ButtonBar7.Groups(0).Items("PurchaseOrder").Enabled = True
            TreeViewMainInventory.CollapseAll()
            TreeViewMainInventory.Enabled = False
        Else
            ButtonBar7.Groups(0).Items("SaleProduct").Enabled = False
            ButtonBar7.Groups(0).Items("PurchaseOrder").Enabled = False
            TreeViewMainInventory.ExpandAll()
            TreeViewMainInventory.Enabled = True
        End If

        LblUserNameLog.Text = "User Name: " & GetCurrentUserName()
        '--- Item Store Management ----'
        'If IsRightOffered("Manage Item Store") = False Then
        '    ButtonBar2.Groups(0).Items("ItemStore").Visible = False
        'End if
        'If IsRightOffered("Receive Item") = False Then
        '    ButtonBar2.Groups(0).Items("ReceiveItem").Visible = False
        'End If
        'If IsRightOffered("Issue Item") = False Then
        '    ButtonBar2.Groups(0).Items("IssueItem").Visible = False
        'End If
        'If IsRightOffered("Adjust Item") = False Then
        '    ButtonBar2.Groups(0).Items("AdjustItem").Visible = False
        'End If
        'If IsRightOffered("Manage Item Store") = False And IsRightOffered("Receive Item") = False And IsRightOffered("Issue Item") = False And IsRightOffered("Adjust Item") = False Then
        '    uiPanel0.Panels(0).Enabled = False
        'End If

        ''--- Order Management ----'
        'If IsRightOffered("Order Item") = False Then
        '    ButtonBar5.Groups(0).Items("OrderItem").Visible = False
        'End If
        'If IsRightOffered("Manage Order") = False Then
        '    ButtonBar5.Groups(0).Items("OrderControl").Visible = False
        'End If
        'If IsRightOffered("Order Item") = False And IsRightOffered("Manage Order") = False Then
        '    uiPanel0.Panels(1).Enabled = False
        'End If

        ''--- Item Management ----'
        'If IsRightOffered("Manage Item") = False Then
        '    ButtonBar1.Groups(0).Items("Item").Visible = False
        'End If
        'If IsRightOffered("Manage Category") = False Then
        '    ButtonBar1.Groups(0).Items("ItemCategory").Visible = False
        'End If
        'If IsRightOffered("Manage Unit") = False Then
        '    ButtonBar1.Groups(0).Items("ItemUnit").Visible = False
        'End If
        'If IsRightOffered("Manage Item") = False And IsRightOffered("Manage Category") = False And IsRightOffered("Manage Unit") = False Then
        '    uiPanel0.Panels(2).Enabled = False
        'End If

        ''--- Report Management ----'
        'If IsRightOffered("View Store Report") = False Then
        '    ButtonBar3.Groups(0).Items("StoreBalance").Visible = False
        'End If
        'If IsRightOffered("View Receive Report") = False Then
        '    ButtonBar3.Groups(0).Items("ReceiveStore").Visible = False
        'End If
        'If IsRightOffered("View Issue Report") = False Then
        '    ButtonBar3.Groups(0).Items("IssueStore").Visible = False
        'End If
        'If IsRightOffered("View Adjust Report") = False Then
        '    ButtonBar3.Groups(0).Items("AdjustStore").Visible = False
        'End If
        'If IsRightOffered("View Transaction Report") = False Then
        '    ButtonBar3.Groups(0).Items("StoreTransaction").Visible = False
        'End If
        'If IsRightOffered("View Item Report") = False Then
        '    ButtonBar3.Groups(0).Items("ItemList").Visible = False
        'End If
        'If IsRightOffered("View Store Report") = False And IsRightOffered("View Receive Report") = False And IsRightOffered("View Issue Report") = False And IsRightOffered("View Adjust Report") = False And IsRightOffered("View Transaction Report") = False And IsRightOffered("View Item Report") = False Then
        '    uiPanel0.Panels(3).Enabled = False
        'End If

        ''--- System Setting ----'
        'If IsRightOffered("Manage User") = False Then
        '    ButtonBar4.Groups(0).Items("User").Visible = False
        'End If
        'If IsRightOffered("Manage User Right") = False Then
        '    ButtonBar4.Groups(0).Items("UserRight").Visible = False
        'End If
        'If IsRightOffered("Broadcast") = False Then
        '    ButtonBar4.Groups(0).Items("Broadcast").Visible = False
        'End If
        'If IsRightOffered("Manage Location") = False Then
        '    ButtonBar4.Groups(0).Items("Location").Visible = False
        'End If
        'If IsRightOffered("Manage User") = False And IsRightOffered("Manage User Right") = False And IsRightOffered("Broadcast") = False And IsRightOffered("Manage Location") = False Then
        '    uiPanel0.Panels(4).Enabled = False
        'End If
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnLogout.Click
        Me.Close()
        Dim FrmLogin As New Login
        FrmLogin.txtUserName.Text = ""
        FrmLogin.txtPassword.Text = ""
        Login.Show()
    End Sub

    Private Sub ButtonBar5_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar5.ItemClick
        Dim UOrder As New UC_OrderItem
        Dim UOrderControl As New UC_OrderControl
        Select Case e.Item.Key
            Case "OrderItem"
                UOrder.RefreshList()
                AddUserControl(Me.MainContainer, UOrder, "Order Item")
            Case "OrderControl"
                UOrderControl.RefreshOrder()
                AddUserControl(Me.MainContainer, UOrderControl, "Order Control")
        End Select
    End Sub

    Private Sub ButtonBar6_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar6.ItemClick

    End Sub

    Private Sub BtnChat_Click(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnChat.Click
        Dim UChat As New UC_Chat
        AddUserControl(Me.MainContainer, UChat, "Chat")
    End Sub

    Private Sub TreeViewMainInventory_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewMainInventory.AfterSelect
        Select Case e.Node.Name
            Case "Customer"
                AddUserControl(Me.MainContainer, DCustomer, "Customer List(បញ្ជីអតិថិជន)")
            Case "Supplier"
                AddUserControl(Me.MainContainer, DSupplier, "Supplier List(បញ្ជី អ្នកផ្គត់ផ្គង")
            Case "Inventory"
                AddUserControl(Me.MainContainer, DMainInventory, "")
            Case "Item"
                AddUserControl(Me.MainContainer, DProduct, "Product Information")
            Case "Measurement"
                AddUserControl(Me.MainContainer, DMeasurement, "Measurement(ឯក្តា)")
            Case "Category"
                AddUserControl(Me.MainContainer, DCategory, "Categories (ប្រភេទមុខទំនិញ)")
            Case "ProductSale"
                AddUserControl(Me.MainContainer, DProductSale, "Product Sale (លក់ទំនិញ)")
                DProductSale.MenuAddOrRemoveProduct.Enabled = True
            Case "ProductOrder"
                AddUserControl(Me.MainContainer, DPuchaseOrder, "Purchase Order បញ្ជាទិញ")
                DPuchaseOrder.ContextAddRemoveItem.Enabled = True
            Case "AccountReceivable"
                AddUserControl(Me.MainContainer, DAccountReceivable, "Account Receivable")
            Case "AccountPayable"
                AddUserControl(Me.MainContainer, DAccountPayable, "Account Payable")
            Case "Revenue"
                AddUserControl(Me.MainContainer, DSRevenues, "Revenue")
            Case "Adjustment"
                AddUserControl(Me.MainContainer, DAAdjustment, "")
            Case "Users1"
                AddUserControl(Me.MainContainer, UUser, "")
            Case "AccessRight"
                AddUserControl(Me.MainContainer, URight, "")
        End Select
        e.Node.SelectedImageIndex = e.Node.ImageIndex
    End Sub

    Private Sub ButtonBar7_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar7.ItemClick
        Select Case e.Item.Key
            Case "SaleProduct"
                AddUserControl(Me.MainContainer, DProductSale, "Product Sale (លក់ទំនិញ)")
                DProductSale.MenuAddOrRemoveProduct.Enabled = False
            Case "PurchaseOrder"
                AddUserControl(Me.MainContainer, DPuchaseOrder, "Purchase Order បញ្ជាទិញ")
                DPuchaseOrder.ContextAddRemoveItem.Enabled = False
        End Select
    End Sub

    Private Sub main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
