<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TeamIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointsGainedFromEvent4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Participant1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Participant2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointsGainedFromEvent5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Participant3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Participant4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Participant5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPointsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PDBDataSet = New PointsSystem.PDBDataSet()
        Me.TeamSTableAdapter = New PointsSystem.PDBDataSetTableAdapters.TeamSTableAdapter()
        Me.School_NameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.School_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.School_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.School_NameToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.School_NameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeamIDDataGridViewTextBoxColumn, Me.SchoolNameDataGridViewTextBoxColumn, Me.PointsGainedFromEvent4DataGridViewTextBoxColumn, Me.Participant1DataGridViewTextBoxColumn, Me.Participant2DataGridViewTextBoxColumn, Me.PointsGainedFromEvent5DataGridViewTextBoxColumn, Me.Participant3DataGridViewTextBoxColumn, Me.Participant4DataGridViewTextBoxColumn, Me.Participant5DataGridViewTextBoxColumn, Me.TotalPointsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TeamSBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1002, 524)
        Me.DataGridView1.TabIndex = 0
        '
        'TeamIDDataGridViewTextBoxColumn
        '
        Me.TeamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID"
        Me.TeamIDDataGridViewTextBoxColumn.HeaderText = "TeamID"
        Me.TeamIDDataGridViewTextBoxColumn.Name = "TeamIDDataGridViewTextBoxColumn"
        '
        'SchoolNameDataGridViewTextBoxColumn
        '
        Me.SchoolNameDataGridViewTextBoxColumn.DataPropertyName = "School Name"
        Me.SchoolNameDataGridViewTextBoxColumn.HeaderText = "School Name"
        Me.SchoolNameDataGridViewTextBoxColumn.Name = "SchoolNameDataGridViewTextBoxColumn"
        '
        'PointsGainedFromEvent4DataGridViewTextBoxColumn
        '
        Me.PointsGainedFromEvent4DataGridViewTextBoxColumn.DataPropertyName = "Points gained from Event #4"
        Me.PointsGainedFromEvent4DataGridViewTextBoxColumn.HeaderText = "Points gained from Event #4"
        Me.PointsGainedFromEvent4DataGridViewTextBoxColumn.Name = "PointsGainedFromEvent4DataGridViewTextBoxColumn"
        '
        'Participant1DataGridViewTextBoxColumn
        '
        Me.Participant1DataGridViewTextBoxColumn.DataPropertyName = "Participant #1"
        Me.Participant1DataGridViewTextBoxColumn.HeaderText = "Participant #1"
        Me.Participant1DataGridViewTextBoxColumn.Name = "Participant1DataGridViewTextBoxColumn"
        '
        'Participant2DataGridViewTextBoxColumn
        '
        Me.Participant2DataGridViewTextBoxColumn.DataPropertyName = "Participant #2"
        Me.Participant2DataGridViewTextBoxColumn.HeaderText = "Participant #2"
        Me.Participant2DataGridViewTextBoxColumn.Name = "Participant2DataGridViewTextBoxColumn"
        '
        'PointsGainedFromEvent5DataGridViewTextBoxColumn
        '
        Me.PointsGainedFromEvent5DataGridViewTextBoxColumn.DataPropertyName = "Points gained from Event #5"
        Me.PointsGainedFromEvent5DataGridViewTextBoxColumn.HeaderText = "Points gained from Event #5"
        Me.PointsGainedFromEvent5DataGridViewTextBoxColumn.Name = "PointsGainedFromEvent5DataGridViewTextBoxColumn"
        '
        'Participant3DataGridViewTextBoxColumn
        '
        Me.Participant3DataGridViewTextBoxColumn.DataPropertyName = "Participant #3"
        Me.Participant3DataGridViewTextBoxColumn.HeaderText = "Participant #3"
        Me.Participant3DataGridViewTextBoxColumn.Name = "Participant3DataGridViewTextBoxColumn"
        '
        'Participant4DataGridViewTextBoxColumn
        '
        Me.Participant4DataGridViewTextBoxColumn.DataPropertyName = "Participant #4"
        Me.Participant4DataGridViewTextBoxColumn.HeaderText = "Participant #4"
        Me.Participant4DataGridViewTextBoxColumn.Name = "Participant4DataGridViewTextBoxColumn"
        '
        'Participant5DataGridViewTextBoxColumn
        '
        Me.Participant5DataGridViewTextBoxColumn.DataPropertyName = "Participant #5"
        Me.Participant5DataGridViewTextBoxColumn.HeaderText = "Participant #5"
        Me.Participant5DataGridViewTextBoxColumn.Name = "Participant5DataGridViewTextBoxColumn"
        '
        'TotalPointsDataGridViewTextBoxColumn
        '
        Me.TotalPointsDataGridViewTextBoxColumn.DataPropertyName = "Total Points"
        Me.TotalPointsDataGridViewTextBoxColumn.HeaderText = "Total Points"
        Me.TotalPointsDataGridViewTextBoxColumn.Name = "TotalPointsDataGridViewTextBoxColumn"
        '
        'TeamSBindingSource
        '
        Me.TeamSBindingSource.DataMember = "TeamS"
        Me.TeamSBindingSource.DataSource = Me.PDBDataSet
        '
        'PDBDataSet
        '
        Me.PDBDataSet.DataSetName = "PDBDataSet"
        Me.PDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeamSTableAdapter
        '
        Me.TeamSTableAdapter.ClearBeforeFill = True
        '
        'School_NameToolStrip
        '
        Me.School_NameToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.School_NameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.School_NameToolStripLabel, Me.School_NameToolStripTextBox, Me.School_NameToolStripButton})
        Me.School_NameToolStrip.Location = New System.Drawing.Point(0, 499)
        Me.School_NameToolStrip.Name = "School_NameToolStrip"
        Me.School_NameToolStrip.Size = New System.Drawing.Size(1002, 25)
        Me.School_NameToolStrip.TabIndex = 1
        Me.School_NameToolStrip.Text = "School_NameToolStrip"
        '
        'School_NameToolStripLabel
        '
        Me.School_NameToolStripLabel.Name = "School_NameToolStripLabel"
        Me.School_NameToolStripLabel.Size = New System.Drawing.Size(83, 22)
        Me.School_NameToolStripLabel.Text = "School_Name:"
        '
        'School_NameToolStripTextBox
        '
        Me.School_NameToolStripTextBox.Name = "School_NameToolStripTextBox"
        Me.School_NameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'School_NameToolStripButton
        '
        Me.School_NameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.School_NameToolStripButton.Name = "School_NameToolStripButton"
        Me.School_NameToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.School_NameToolStripButton.Text = "Search"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 524)
        Me.Controls.Add(Me.School_NameToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.School_NameToolStrip.ResumeLayout(False)
        Me.School_NameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PDBDataSet As PDBDataSet
    Friend WithEvents TeamSBindingSource As BindingSource
    Friend WithEvents TeamSTableAdapter As PDBDataSetTableAdapters.TeamSTableAdapter
    Friend WithEvents TeamIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointsGainedFromEvent4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Participant1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Participant2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PointsGainedFromEvent5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Participant3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Participant4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Participant5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPointsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents School_NameToolStrip As ToolStrip
    Friend WithEvents School_NameToolStripLabel As ToolStripLabel
    Friend WithEvents School_NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents School_NameToolStripButton As ToolStripButton
End Class
