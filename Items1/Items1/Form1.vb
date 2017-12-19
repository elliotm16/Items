Public Class Form1

    Private Sub btnTshirt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTshirt.Click

        AddItem("T shirt")

    End Sub

    Private Sub btnHat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHat.Click

        AddItem("Hat")

    End Sub

    Private Sub btnShoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShoes.Click

        AddItem("Shoes")

    End Sub

    Private Sub btnShorts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShorts.Click

        AddItem("Shorts")

    End Sub

    Public Sub AddItem(ByVal ItemName As String)

        Dim NumItems As Integer = 1

        For Each Item In lstItems.Items

            If Item.Contains(ItemName) Then

                NumItems = CInt(Item.Substring(Len(ItemName) + 2, Len(Item) - Len(ItemName) - 3))

                NumItems = NumItems + 1

            End If

        Next

        lstItems.Items.Add(ItemName & " [" & NumItems & "]")

        If NumItems <> 1 Then

            lstItems.Items.Remove(ItemName & " [" & NumItems - 1 & "]")

        End If

        lstItems.Sorted = True

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        lstItems.Items.Remove(lstItems.SelectedItem)

    End Sub

End Class