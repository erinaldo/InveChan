﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCategory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim CategoryList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardCategory))
        Me.CategoryList = New Janus.Windows.GridEX.GridEX
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolSupplier = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.DsInventory1 = New Asia_Garden_Inventory_Management_System.DSInventory
        CType(Me.CategoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolSupplier.SuspendLayout()
        CType(Me.DsInventory1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryList
        '
        Me.CategoryList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.CategoryList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        CategoryList_DesignTimeLayout.LayoutString = resources.GetString("CategoryList_DesignTimeLayout.LayoutString")
        Me.CategoryList.DesignTimeLayout = CategoryList_DesignTimeLayout
        Me.CategoryList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.CategoryList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.CategoryList.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.CategoryList.GroupByBoxVisible = False
        Me.CategoryList.HeaderFormatStyle.FontSize = 10.0!
        Me.CategoryList.Location = New System.Drawing.Point(0, 54)
        Me.CategoryList.Name = "CategoryList"
        Me.CategoryList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.CategoryList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CategoryList.RecordNavigator = True
        Me.CategoryList.Size = New System.Drawing.Size(692, 406)
        Me.CategoryList.TabIndex = 4
        Me.CategoryList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'ToolSupplier
        '
        Me.ToolSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolSupplier.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolSupplier.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.ToolStripButton5})
        Me.ToolSupplier.Location = New System.Drawing.Point(0, 0)
        Me.ToolSupplier.Name = "ToolSupplier"
        Me.ToolSupplier.Size = New System.Drawing.Size(692, 54)
        Me.ToolSupplier.TabIndex = 3
        Me.ToolSupplier.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Supplier_Icon_Transparent_120_x_120
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(86, 51)
        Me.ToolStripButton1.Text = "ប្រភេទទំនិញ ថ្មី"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton3.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.edit_find_replace
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(106, 51)
        Me.ToolStripButton3.Text = "កែប្រែ ប្រភេទទំនិញ"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton4.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(98, 51)
        Me.ToolStripButton4.Text = "លប់ ប្រភេទទំនិញ"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton5.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(86, 51)
        Me.ToolStripButton5.Text = "បង្ហាញទាំងអស់"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DsInventory1
        '
        Me.DsInventory1.DataSetName = "DSInventory"
        Me.DsInventory1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DashboardCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.CategoryList)
        Me.Controls.Add(Me.ToolSupplier)
        Me.Name = "DashboardCategory"
        Me.Size = New System.Drawing.Size(692, 460)
        CType(Me.CategoryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolSupplier.ResumeLayout(False)
        Me.ToolSupplier.PerformLayout()
        CType(Me.DsInventory1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CategoryList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSupplier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DsInventory1 As Asia_Garden_Inventory_Management_System.DSInventory

End Class