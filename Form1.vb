Public Class Form1
    Private Sub FormReset(sender As Object, e As EventArgs) Handles Me.Load, btnReset.Click, ResetToolStripMenuItem.Click
        'TODO: This line of code loads data into the 'Database_AirPropertyDataSet.AirTable' table. You can move, or remove it, as needed.
        Me.AirTableTableAdapter.Fill(Me.Database_AirPropertyDataSet.AirTable)
        'This helps to return to default form
        Me.Width = 375
        AirTableDataGridView.Width = 0
        btnData.Text = "&Show Data >>>"
        cmbInput.SelectedIndex = 0
        txtInput.Text = ""

        For Each txtSelected As TextBox In
            Me.grpOutput.Controls.OfType(Of TextBox)()
            txtSelected.Text = ""
        Next

        If cmbInput.SelectedIndex < 1 Then cmbInput.SelectedIndex = 0

        cmbInput.Focus()
    End Sub
    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        'allows digits only
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = "-"c) Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso (txtInput.SelectionStart = 0 OrElse
            txtInput.Text.Contains(".")) Then
            e.Handled = True
        End If

        If e.KeyChar = "-"c AndAlso (txtInput.SelectionStart <> 0 OrElse
            txtInput.Text.Contains("-")) Then

            e.Handled = True
        End If
    End Sub
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            Dim sngInput() As Single = {0, 0, 0, 0, 0, 0}
            Dim intSelectedIndex As Byte = cmbInput.SelectedIndex
            Dim sngCurrentInput As Single = txtInput.Text

            For intRow As Integer = 0 To AirTableDataGridView.RowCount - 2
                If intSelectedIndex = 4 Then
                    If AirTableDataGridView.Rows.Item(intRow + 1).Cells(intSelectedIndex).Value <= sngCurrentInput Then
                        For intColumn As Integer = 0 To AirTableDataGridView.ColumnCount - 1
                            Dim UpperPropertyX As Single = AirTableDataGridView.Rows.Item(intRow + 1).Cells(intSelectedIndex).Value
                            Dim LowerPropertyX As Single = AirTableDataGridView.Rows.Item(intRow).Cells(intSelectedIndex).Value
                            Dim UpperPropertyY As Single = AirTableDataGridView.Rows.Item(intRow + 1).Cells(intColumn).Value
                            Dim LowerPropertyY As Single = AirTableDataGridView.Rows.Item(intRow).Cells(intColumn).Value

                            sngInput(intColumn) = LinearRegression(sngCurrentInput, UpperPropertyX, LowerPropertyX, UpperPropertyY, LowerPropertyY)
                        Next

                        Exit For
                    End If
                End If
            Next

            grpOutput.Enabled = True

            txtTemperature.Text = sngInput(0)
            txtEnthalpy.Text = sngInput(1)
            txtPressure.Text = sngInput(2)
            txtEnergy.Text = sngInput(3)
            txtVolume.Text = sngInput(4)
            txtEntropy.Text = sngInput(5)
        Catch NoInput As System.InvalidCastException
            MsgBox("Please enter a value!", "Error")
            FormReset(Nothing, Nothing)
        Catch Overflow As System.OverflowException
            MsgBox(Overflow.Message, "Error")
            txtInput.Focus()
            txtInput.SelectAll()
        Catch Other As System.Exception
            MsgBox(Other.Message, "Error")
            FormReset(Nothing, Nothing)
        End Try
    End Sub
    Function LinearRegression(ByVal CP As Single, ByVal UX As Single, ByVal LX As Single, ByVal UY As Single, ByVal LY As Single) As Single
        Dim NInput As Single = 0

        NInput = LY + (((UY - LY) / (UX - LX)) * (CP - LX))
        NInput = Math.Round(NInput, 5)

        Return NInput
    End Function
    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        'Shows the datasheet
        If btnData.Text = "&Show Data >>>" Then
            Me.Width = 975
            AirTableDataGridView.Width = 600
            btnData.Text = "<<< &Hide Data"
        Else
            Me.Width = 375
            AirTableDataGridView.Width = 0
            btnData.Text = "Show Data >>>"
        End If
    End Sub
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'To show a messagebox that ask if the user wants to exit or not
        Dim ExitYNC = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "Exit?")

        If ExitYNC = MsgBoxResult.No Then e.Cancel = True
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Specific code to exit for exit menu item
        Me.Close()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Show another form that shows "About"
        Dim frmAbout As New Form2()

        frmAbout.ShowDialog()
    End Sub
    Private Sub AirTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'AirTable
        Me.Validate()
        Me.AirTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database_AirPropertyDataSet)
    End Sub
End Class