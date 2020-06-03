<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IndBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PDBDataSet = New PointsSystem.PDBDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointsGainedFromEvent1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointsGainedFromEvent2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointsGainedFromEvent3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPointsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndTableAdapter = New PointsSystem.PDBDataSetTableAdapters.IndTableAdapter()
        Me.SurnameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SurnameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SurnameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SurnameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ForenameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ForenameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ForenameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ForenameToolStrip = New System.Windows.Forms.ToolStrip()
        CType(Me.IndBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SurnameToolStrip.SuspendLayout()
        Me.ForenameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Individual Query"
        '
        'IndBindingSource
        '
        Me.IndBindingSource.DataMember = "Ind"
        Me.IndBindingSource.DataSource = Me.PDBDataSetBindingSource
        '
        'PDBDataSetBindingSource
        '
        Me.PDBDataSetBindingSource.DataSource = Me.PDBDataSet
        Me.PDBDataSetBindingSource.Position = 0
        '
        'PDBDataSet
        '
        Me.PDBDataSet.DataSetName = "PDBDataSet"
        Me.PDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.ForenameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.PointsGainedFromEvent1DataGridViewTextBoxColumn, Me.PointsGainedFromEvent2DataGridViewTextBoxColumn, Me.PointsGainedFromEvent3DataGridViewTextBoxColumn, Me.TotalPointsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IndBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(965, 518)
        Me.DataGridView1.TabIndex = 1
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'ForenameDataGridViewTextBoxColumn
        '
        Me.ForenameDataGridViewTextBoxColumn.DataPropertyName = "Forename"
        Me.ForenameDataGridViewTextBoxColumn.HeaderText = "Forename"
        Me.ForenameDataGridViewTextBoxColumn.Name = "ForenameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'PointsGainedFromEvent1DataGridViewTextBoxColumn
        '
        Me.PointsGainedFromEvent1DataGridViewTextBoxColumn.DataPropertyName = "Points gained from Event #1"
        Me.PointsGainedFromEvent1DataGridViewTextBoxColumn.HeaderText = "Points gained from Event #1"
        Me.PointsGainedFromEvent1DataGridViewTextBoxColumn.Name = "PointsGainedFromEvent1DataGridViewTextBoxColumn"
        '
        'PointsGainedFromEvent2DataGridViewTextBoxColumn
        '
        Me.PointsGainedFromEvent2DataGridViewTextBoxColumn.DataPropertyName = "Points gained from Event #2"
        Me.PointsGainedFromEvent2DataGridViewTextBoxColumn.HeaderText = "Points gained from Event #2"
        Me.PointsGainedFromEvent2DataGridViewTextBoxColumn.Name = "PointsGainedFromEvent2DataGridViewTextBoxColumn"
        '
        'PointsGainedFromEvent3DataGridViewTextBoxColumn
        '
        Me.PointsGainedFromEvent3DataGridViewTextBoxColumn.DataPropertyName = "Points gained from Event #3"
        Me.PointsGainedFromEvent3DataGridViewTextBoxColumn.HeaderText = "Points gained from Event #3"
        Me.PointsGainedFromEvent3DataGridViewTextBoxColumn.Name = "PointsGainedFromEvent3DataGridViewTextBoxColumn"
        '
        'TotalPointsDataGridViewTextBoxColumn
        '
        Me.TotalPointsDataGridViewTextBoxColumn.DataPropertyName = "Total Points"
        Me.TotalPointsDataGridViewTextBoxColumn.HeaderText = "Total Points"
        Me.TotalPointsDataGridViewTextBoxColumn.Name = "TotalPointsDataGridViewTextBoxColumn"
        '
        'IndBindingSource1
        '
        Me.IndBindingSource1.DataMember = "Ind"
        Me.IndBindingSource1.DataSource = Me.PDBDataSetBindingSource
        '
        'IndTableAdapter
        '
        Me.IndTableAdapter.ClearBeforeFill = True
        '
        'SurnameToolStripLabel
        '
        Me.SurnameToolStripLabel.Name = "SurnameToolStripLabel"
        Me.SurnameToolStripLabel.Size = New System.Drawing.Size(57, 22)
        Me.SurnameToolStripLabel.Text = "Surname:"
        '
        'SurnameToolStripTextBox
        '
        Me.SurnameToolStripTextBox.Name = "SurnameToolStripTextBox"
        Me.SurnameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'SurnameToolStripButton
        '
        Me.SurnameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SurnameToolStripButton.Name = "SurnameToolStripButton"
        Me.SurnameToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.SurnameToolStripButton.Text = "Search"
        '
        'SurnameToolStrip
        '
        Me.SurnameToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SurnameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SurnameToolStripLabel, Me.SurnameToolStripTextBox, Me.SurnameToolStripButton})
        Me.SurnameToolStrip.Location = New System.Drawing.Point(0, 468)
        Me.SurnameToolStrip.Name = "SurnameToolStrip"
        Me.SurnameToolStrip.Size = New System.Drawing.Size(965, 25)
        Me.SurnameToolStrip.TabIndex = 3
        Me.SurnameToolStrip.Text = "SurnameToolStrip"
        '
        'ForenameToolStripLabel
        '
        Me.ForenameToolStripLabel.Name = "ForenameToolStripLabel"
        Me.ForenameToolStripLabel.Size = New System.Drawing.Size(63, 22)
        Me.ForenameToolStripLabel.Text = "Forename:"
        '
        'ForenameToolStripTextBox
        '
        Me.ForenameToolStripTextBox.Name = "ForenameToolStripTextBox"
        Me.ForenameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ForenameToolStripButton
        '
        Me.ForenameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ForenameToolStripButton.Name = "ForenameToolStripButton"
        Me.ForenameToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.ForenameToolStripButton.Text = "Search"
        '
        'ForenameToolStrip
        '
        Me.ForenameToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ForenameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForenameToolStripLabel, Me.ForenameToolStripTextBox, Me.ForenameToolStripButton})
        Me.ForenameToolStrip.Location = New System.Drawing.Point(0, 493)
        Me.ForenameToolStrip.Name = "ForenameToolStrip"
        Me.ForenameToolStrip.Size = New System.Drawing.Size(965, 25)
        Me.ForenameToolStrip.TabIndex = 2
        Me.ForenameToolStrip.Text = "ForenameToolStrip"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 518)
        Me.Controls.Add(Me.SurnameToolStrip)
        Me.Controls.Add(Me.ForenameToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.IndBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SurnameToolStrip.ResumeLayout(False)
        Me.SurnameToolStrip.PerformLayout()
        Me.ForenameToolStrip.ResumeLayout(False)
        Me.ForenameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PDBDataSetBindingSource As BindingSource
    Friend WithEvents PDBDataSet As PDBDataSet
    Friend WithEvents IndBindingSource As BindingSource
    Friend WithEvents IndTableAdapter As PDBDataSetTableAdapters.IndTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ForenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointsGainedFromEvent1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointsGainedFromEvent2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointsGainedFromEvent3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPointsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndBindingSource1 As BindingSource
    Friend WithEvents SurnameToolStripLabel As ToolStripLabel
    Friend WithEvents SurnameToolStripTextBox As ToolStripTextBox
    Friend WithEvents SurnameToolStripButton As ToolStripButton
    Friend WithEvents SurnameToolStrip As ToolStrip
    Friend WithEvents ForenameToolStripLabel As ToolStripLabel
    Friend WithEvents ForenameToolStripTextBox As ToolStripTextBox
    Friend WithEvents ForenameToolStripButton As ToolStripButton
    Friend WithEvents ForenameToolStrip As ToolStrip
End Class
