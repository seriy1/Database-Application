Public Class Form1
    Private Sub SongsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.SongsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SongsDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SongsDataSet.SongContents' table. You can move, or remove it, as needed.
        Me.SongContentsTableAdapter.Fill(Me.SongsDataSet.SongContents)
        'TODO: This line of code loads data into the 'SongsDataSet.Songs' table. You can move, or remove it, as needed.
        Me.SongsTableAdapter.Fill(Me.SongsDataSet.Songs)

    End Sub
End Class
