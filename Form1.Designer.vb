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
        Dim lblTemperature As System.Windows.Forms.Label
        Dim lblEnthalpy As System.Windows.Forms.Label
        Dim lblPressure As System.Windows.Forms.Label
        Dim lblEnergy As System.Windows.Forms.Label
        Dim lblVolume As System.Windows.Forms.Label
        Dim lblEntropy As System.Windows.Forms.Label
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.cmbInput = New System.Windows.Forms.ComboBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Database_AirPropertyDataSet = New A1L_Olleres_Exercise7.Database_AirPropertyDataSet()
        Me.AirTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirTableTableAdapter = New A1L_Olleres_Exercise7.Database_AirPropertyDataSetTableAdapters.AirTableTableAdapter()
        Me.TableAdapterManager = New A1L_Olleres_Exercise7.Database_AirPropertyDataSetTableAdapters.TableAdapterManager()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.txtEnthalpy = New System.Windows.Forms.TextBox()
        Me.txtPressure = New System.Windows.Forms.TextBox()
        Me.txtEnergy = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.txtEntropy = New System.Windows.Forms.TextBox()
        Me.AirTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        lblTemperature = New System.Windows.Forms.Label()
        lblEnthalpy = New System.Windows.Forms.Label()
        lblPressure = New System.Windows.Forms.Label()
        lblEnergy = New System.Windows.Forms.Label()
        lblVolume = New System.Windows.Forms.Label()
        lblEntropy = New System.Windows.Forms.Label()
        Me.grpInput.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Database_AirPropertyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.txtInput)
        Me.grpInput.Controls.Add(Me.cmbInput)
        Me.grpInput.Location = New System.Drawing.Point(12, 31)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(333, 67)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(198, 21)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(129, 22)
        Me.txtInput.TabIndex = 1
        '
        'cmbInput
        '
        Me.cmbInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInput.FormattingEnabled = True
        Me.cmbInput.Items.AddRange(New Object() {"Temperature, K", "Specific Enthalpy, kJ/kg", "Reduced Pressure", "Specific Internal Energy, kJ/kg", "Reduced Volume", "Specific Entropy, kJ/kg*K"})
        Me.cmbInput.Location = New System.Drawing.Point(6, 21)
        Me.cmbInput.Name = "cmbInput"
        Me.cmbInput.Size = New System.Drawing.Size(186, 24)
        Me.cmbInput.TabIndex = 0
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(12, 104)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(91, 23)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(109, 104)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(91, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(206, 104)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(139, 23)
        Me.btnData.TabIndex = 3
        Me.btnData.Text = "&Show Data >>>"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(lblTemperature)
        Me.grpOutput.Controls.Add(Me.txtTemperature)
        Me.grpOutput.Controls.Add(lblEnthalpy)
        Me.grpOutput.Controls.Add(Me.txtEnthalpy)
        Me.grpOutput.Controls.Add(lblPressure)
        Me.grpOutput.Controls.Add(Me.txtPressure)
        Me.grpOutput.Controls.Add(lblEnergy)
        Me.grpOutput.Controls.Add(Me.txtEnergy)
        Me.grpOutput.Controls.Add(lblVolume)
        Me.grpOutput.Controls.Add(Me.txtVolume)
        Me.grpOutput.Controls.Add(lblEntropy)
        Me.grpOutput.Controls.Add(Me.txtEntropy)
        Me.grpOutput.Enabled = False
        Me.grpOutput.Location = New System.Drawing.Point(12, 133)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(333, 206)
        Me.grpOutput.TabIndex = 4
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(957, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Database_AirPropertyDataSet
        '
        Me.Database_AirPropertyDataSet.DataSetName = "Database_AirPropertyDataSet"
        Me.Database_AirPropertyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AirTableBindingSource
        '
        Me.AirTableBindingSource.DataMember = "AirTable"
        Me.AirTableBindingSource.DataSource = Me.Database_AirPropertyDataSet
        '
        'AirTableTableAdapter
        '
        Me.AirTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AirTableTableAdapter = Me.AirTableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = A1L_Olleres_Exercise7.Database_AirPropertyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblTemperature
        '
        lblTemperature.AutoSize = True
        lblTemperature.Location = New System.Drawing.Point(6, 32)
        lblTemperature.Name = "lblTemperature"
        lblTemperature.Size = New System.Drawing.Size(102, 16)
        lblTemperature.TabIndex = 0
        lblTemperature.Text = "Temperature, K:"
        '
        'txtTemperature
        '
        Me.txtTemperature.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirTableBindingSource, "Temperature, K", True))
        Me.txtTemperature.Location = New System.Drawing.Point(204, 29)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.ReadOnly = True
        Me.txtTemperature.Size = New System.Drawing.Size(123, 22)
        Me.txtTemperature.TabIndex = 1
        '
        'lblEnthalpy
        '
        lblEnthalpy.AutoSize = True
        lblEnthalpy.Location = New System.Drawing.Point(6, 60)
        lblEnthalpy.Name = "lblEnthalpy"
        lblEnthalpy.Size = New System.Drawing.Size(155, 16)
        lblEnthalpy.TabIndex = 2
        lblEnthalpy.Text = "Specific Enthalpy, k J/kg:"
        '
        'txtEnthalpy
        '
        Me.txtEnthalpy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirTableBindingSource, "Specific Enthalpy, kJ/kg", True))
        Me.txtEnthalpy.Location = New System.Drawing.Point(204, 57)
        Me.txtEnthalpy.Name = "txtEnthalpy"
        Me.txtEnthalpy.ReadOnly = True
        Me.txtEnthalpy.Size = New System.Drawing.Size(123, 22)
        Me.txtEnthalpy.TabIndex = 3
        '
        'lblPressure
        '
        lblPressure.AutoSize = True
        lblPressure.Location = New System.Drawing.Point(6, 88)
        lblPressure.Name = "lblPressure"
        lblPressure.Size = New System.Drawing.Size(123, 16)
        lblPressure.TabIndex = 4
        lblPressure.Text = "Reduced Pressure:"
        '
        'txtPressure
        '
        Me.txtPressure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirTableBindingSource, "Reduced Pressure", True))
        Me.txtPressure.Location = New System.Drawing.Point(204, 85)
        Me.txtPressure.Name = "txtPressure"
        Me.txtPressure.ReadOnly = True
        Me.txtPressure.Size = New System.Drawing.Size(123, 22)
        Me.txtPressure.TabIndex = 5
        '
        'lblEnergy
        '
        lblEnergy.AutoSize = True
        lblEnergy.Location = New System.Drawing.Point(6, 116)
        lblEnergy.Name = "lblEnergy"
        lblEnergy.Size = New System.Drawing.Size(192, 16)
        lblEnergy.TabIndex = 6
        lblEnergy.Text = "Specific Internal Energy, k J/kg:"
        '
        'txtEnergy
        '
        Me.txtEnergy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirTableBindingSource, "Specific Internal Energy, kJ/kg", True))
        Me.txtEnergy.Location = New System.Drawing.Point(204, 113)
        Me.txtEnergy.Name = "txtEnergy"
        Me.txtEnergy.ReadOnly = True
        Me.txtEnergy.Size = New System.Drawing.Size(123, 22)
        Me.txtEnergy.TabIndex = 7
        '
        'lblVolume
        '
        lblVolume.AutoSize = True
        lblVolume.Location = New System.Drawing.Point(6, 144)
        lblVolume.Name = "lblVolume"
        lblVolume.Size = New System.Drawing.Size(115, 16)
        lblVolume.TabIndex = 8
        lblVolume.Text = "Reduced Volume:"
        '
        'txtVolume
        '
        Me.txtVolume.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirTableBindingSource, "Reduced Volume", True))
        Me.txtVolume.Location = New System.Drawing.Point(204, 141)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.ReadOnly = True
        Me.txtVolume.Size = New System.Drawing.Size(123, 22)
        Me.txtVolume.TabIndex = 9
        '
        'lblEntropy
        '
        lblEntropy.AutoSize = True
        lblEntropy.Location = New System.Drawing.Point(6, 172)
        lblEntropy.Name = "lblEntropy"
        lblEntropy.Size = New System.Drawing.Size(162, 16)
        lblEntropy.TabIndex = 10
        lblEntropy.Text = "Specific Entropy, k J/kg*K:"
        '
        'txtEntropy
        '
        Me.txtEntropy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AirTableBindingSource, "Specific Entropy, kJ/kg*K", True))
        Me.txtEntropy.Location = New System.Drawing.Point(204, 169)
        Me.txtEntropy.Name = "txtEntropy"
        Me.txtEntropy.ReadOnly = True
        Me.txtEntropy.Size = New System.Drawing.Size(123, 22)
        Me.txtEntropy.TabIndex = 11
        '
        'AirTableDataGridView
        '
        Me.AirTableDataGridView.AutoGenerateColumns = False
        Me.AirTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AirTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AirTableDataGridView.DataSource = Me.AirTableBindingSource
        Me.AirTableDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.AirTableDataGridView.Location = New System.Drawing.Point(657, 28)
        Me.AirTableDataGridView.Name = "AirTableDataGridView"
        Me.AirTableDataGridView.RowHeadersWidth = 51
        Me.AirTableDataGridView.RowTemplate.Height = 24
        Me.AirTableDataGridView.Size = New System.Drawing.Size(300, 325)
        Me.AirTableDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Temperature, K"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Temperature, K"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Specific Enthalpy, kJ/kg"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Specific Enthalpy, kJ/kg"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Reduced Pressure"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Reduced Pressure"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Specific Internal Energy, kJ/kg"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Specific Internal Energy, kJ/kg"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Reduced Volume"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Reduced Volume"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Specific Entropy, kJ/kg*K"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Specific Entropy, kJ/kg*K"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(957, 353)
        Me.Controls.Add(Me.AirTableDataGridView)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Air Property Calculator"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Database_AirPropertyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents cmbInput As ComboBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnData As Button
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Database_AirPropertyDataSet As Database_AirPropertyDataSet
    Friend WithEvents AirTableBindingSource As BindingSource
    Friend WithEvents AirTableTableAdapter As Database_AirPropertyDataSetTableAdapters.AirTableTableAdapter
    Friend WithEvents TableAdapterManager As Database_AirPropertyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents txtEnthalpy As TextBox
    Friend WithEvents txtPressure As TextBox
    Friend WithEvents txtEnergy As TextBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents txtEntropy As TextBox
    Friend WithEvents AirTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
