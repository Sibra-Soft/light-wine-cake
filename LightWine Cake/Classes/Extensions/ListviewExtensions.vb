Imports System.Runtime.CompilerServices
Imports System.Text
Module ListviewExtensions
    <Extension()>
    Public Function ListviewContentToCSV(targetListview As ListView) As String
        Dim output As New StringBuilder
        Dim item As ListViewItem
        Dim I As Integer

        ' Loop trough listview items
        For Each item In targetListview.Items
            Dim line As String = ""

            line = line & item.Text

            ' Loop trough listview subitems
            For I = 1 To item.SubItems.Count - 1
                line = line & ";" & item.SubItems(I).Text
            Next

            output.Append(line & vbNewLine)
        Next

        Return output.ToString()
    End Function
    <Extension()>
    Public Sub ConfigureListview(targetListview As ListView, Optional ShowCheckboxes As Boolean = False, Optional FullRowSelection As Boolean = True)
        targetListview.HeaderStyle = ColumnHeaderStyle.Nonclickable
        targetListview.View = View.Details
        targetListview.FullRowSelect = FullRowSelection
        targetListview.CheckBoxes = ShowCheckboxes

        targetListview.Items.Clear()
        targetListview.Columns.Clear()
    End Sub
    <Extension()>
    Public Sub AutoResizeListviewColumns(targetListview As ListView)
        Dim column As ColumnHeader
        Dim listviewWidth As Integer
        Dim listviewColumnCount As Integer
        Dim widthPerColumn As Integer
        Dim currentColumnWidth As Integer
        Dim listviewCompWidth As Integer
        Dim columnCompWidth As Integer
        Dim posibleVisibleItems As Integer

        If targetListview.Items.Count > 1 Then
            posibleVisibleItems = Convert.ToInt64(targetListview.ClientSize.Height / targetListview.GetItemRect(0).Height - 2)
        End If

        If targetListview.BorderStyle = BorderStyle.None Then
            columnCompWidth = 1
        ElseIf targetListview.CheckBoxes Then
            columnCompWidth = 30
        Else
            columnCompWidth = 5
        End If

        If targetListview.Items.Count > posibleVisibleItems Then
            columnCompWidth += 18
        End If

        For Each column In targetListview.Columns
            If column.Width = 60 Then
                listviewColumnCount += 1
            Else
                listviewCompWidth += column.Width
            End If
        Next

        If Not listviewColumnCount > 0 Then Exit Sub

        ' Get the de listview data
        listviewWidth = (targetListview.Width - columnCompWidth) - listviewCompWidth
        widthPerColumn = listviewWidth / listviewColumnCount

        ' Set the width of the non-default columns
        For Each column In targetListview.Columns
            currentColumnWidth = column.Width

            If currentColumnWidth = 60 Then column.Width = widthPerColumn
        Next
    End Sub
End Module