<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim SongNumLabel As System.Windows.Forms.Label
        Dim SongNameLabel As System.Windows.Forms.Label
        Dim SongCompleteLabel As System.Windows.Forms.Label
        Dim ContentLabel As System.Windows.Forms.Label
        Me.SongsDataSet = New Database_Application.songsDataSet()
        Me.SongsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SongsTableAdapter = New Database_Application.songsDataSetTableAdapters.SongsTableAdapter()
        Me.TableAdapterManager = New Database_Application.songsDataSetTableAdapters.TableAdapterManager()
        Me.SongContentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SongContentsTableAdapter = New Database_Application.songsDataSetTableAdapters.SongContentsTableAdapter()
        Me.SongNumTextBox = New System.Windows.Forms.TextBox()
        Me.SongNameTextBox = New System.Windows.Forms.TextBox()
        Me.SongCompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.ContentTextBox = New System.Windows.Forms.TextBox()
        Me.SongsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        SongNumLabel = New System.Windows.Forms.Label()
        SongNameLabel = New System.Windows.Forms.Label()
        SongCompleteLabel = New System.Windows.Forms.Label()
        ContentLabel = New System.Windows.Forms.Label()
        CType(Me.SongsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SongsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SongContentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SongsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SongsDataSet
        '
        Me.SongsDataSet.DataSetName = "songsDataSet"
        Me.SongsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SongsBindingSource
        '
        Me.SongsBindingSource.DataMember = "Songs"
        Me.SongsBindingSource.DataSource = Me.SongsDataSet
        '
        'SongsTableAdapter
        '
        Me.SongsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SongContentsTableAdapter = Me.SongContentsTableAdapter
        Me.TableAdapterManager.SongsTableAdapter = Me.SongsTableAdapter
        Me.TableAdapterManager.tempTableAdapter = Nothing
        Me.TableAdapterManager.todaytempTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Database_Application.songsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SongContentsBindingSource
        '
        Me.SongContentsBindingSource.DataMember = "SongContents"
        Me.SongContentsBindingSource.DataSource = Me.SongsDataSet
        '
        'SongContentsTableAdapter
        '
        Me.SongContentsTableAdapter.ClearBeforeFill = True
        '
        'SongNumLabel
        '
        SongNumLabel.AutoSize = True
        SongNumLabel.Location = New System.Drawing.Point(291, 104)
        SongNumLabel.Name = "SongNumLabel"
        SongNumLabel.Size = New System.Drawing.Size(60, 13)
        SongNumLabel.TabIndex = 0
        SongNumLabel.Text = "Song Num:"
        '
        'SongNumTextBox
        '
        Me.SongNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SongsBindingSource, "SongNum", True))
        Me.SongNumTextBox.Location = New System.Drawing.Point(379, 101)
        Me.SongNumTextBox.Name = "SongNumTextBox"
        Me.SongNumTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SongNumTextBox.TabIndex = 1
        '
        'SongNameLabel
        '
        SongNameLabel.AutoSize = True
        SongNameLabel.Location = New System.Drawing.Point(291, 130)
        SongNameLabel.Name = "SongNameLabel"
        SongNameLabel.Size = New System.Drawing.Size(66, 13)
        SongNameLabel.TabIndex = 2
        SongNameLabel.Text = "Song Name:"
        '
        'SongNameTextBox
        '
        Me.SongNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SongsBindingSource, "SongName", True))
        Me.SongNameTextBox.Location = New System.Drawing.Point(379, 127)
        Me.SongNameTextBox.Name = "SongNameTextBox"
        Me.SongNameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SongNameTextBox.TabIndex = 3
        '
        'SongCompleteLabel
        '
        SongCompleteLabel.AutoSize = True
        SongCompleteLabel.Location = New System.Drawing.Point(291, 158)
        SongCompleteLabel.Name = "SongCompleteLabel"
        SongCompleteLabel.Size = New System.Drawing.Size(82, 13)
        SongCompleteLabel.TabIndex = 4
        SongCompleteLabel.Text = "Song Complete:"
        '
        'SongCompleteCheckBox
        '
        Me.SongCompleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SongsBindingSource, "SongComplete", True))
        Me.SongCompleteCheckBox.Location = New System.Drawing.Point(379, 153)
        Me.SongCompleteCheckBox.Name = "SongCompleteCheckBox"
        Me.SongCompleteCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SongCompleteCheckBox.TabIndex = 5
        Me.SongCompleteCheckBox.Text = "CheckBox1"
        Me.SongCompleteCheckBox.UseVisualStyleBackColor = True
        '
        'ContentLabel
        '
        ContentLabel.AutoSize = True
        ContentLabel.Location = New System.Drawing.Point(291, 186)
        ContentLabel.Name = "ContentLabel"
        ContentLabel.Size = New System.Drawing.Size(46, 13)
        ContentLabel.TabIndex = 6
        ContentLabel.Text = "content:"
        '
        'ContentTextBox
        '
        Me.ContentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SongsBindingSource, "content", True))
        Me.ContentTextBox.Location = New System.Drawing.Point(379, 183)
        Me.ContentTextBox.Name = "ContentTextBox"
        Me.ContentTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ContentTextBox.TabIndex = 7
        '
        'SongsDataGridView
        '
        Me.SongsDataGridView.AutoGenerateColumns = False
        Me.SongsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SongsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.SongsDataGridView.DataSource = Me.SongsBindingSource
        Me.SongsDataGridView.Location = New System.Drawing.Point(204, 293)
        Me.SongsDataGridView.Name = "SongsDataGridView"
        Me.SongsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SongsDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SongNum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SongNum"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SongName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SongName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "SongComplete"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "SongComplete"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "content"
        Me.DataGridViewTextBoxColumn3.HeaderText = "content"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 538)
        Me.Controls.Add(Me.SongsDataGridView)
        Me.Controls.Add(SongNumLabel)
        Me.Controls.Add(Me.SongNumTextBox)
        Me.Controls.Add(SongNameLabel)
        Me.Controls.Add(Me.SongNameTextBox)
        Me.Controls.Add(SongCompleteLabel)
        Me.Controls.Add(Me.SongCompleteCheckBox)
        Me.Controls.Add(ContentLabel)
        Me.Controls.Add(Me.ContentTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SongsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SongsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SongContentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SongsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SongsDataSet As songsDataSet
    Friend WithEvents SongsBindingSource As BindingSource
    Friend WithEvents SongsTableAdapter As songsDataSetTableAdapters.SongsTableAdapter
    Friend WithEvents TableAdapterManager As songsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SongContentsTableAdapter As songsDataSetTableAdapters.SongContentsTableAdapter
    Friend WithEvents SongContentsBindingSource As BindingSource
    Friend WithEvents SongNumTextBox As TextBox
    Friend WithEvents SongNameTextBox As TextBox
    Friend WithEvents SongCompleteCheckBox As CheckBox
    Friend WithEvents ContentTextBox As TextBox
    Friend WithEvents SongsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
