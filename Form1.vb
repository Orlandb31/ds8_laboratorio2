Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RetirosYDepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetirosYDepositosToolStripMenuItem.Click
        frmretiro.MdiParent = Me
        frmretiro.WindowState = FormWindowState.Maximized
        frmretiro.Show()
    End Sub

    Private Sub RegistrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClientesToolStripMenuItem.Click
        frmregistrar.MdiParent = Me
        frmregistrar.WindowState = FormWindowState.Maximized
        frmregistrar.Show()
    End Sub

    Private Sub MatricesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatricesToolStripMenuItem.Click
        frmmatrices.MdiParent = Me
        frmmatrices.WindowState = FormWindowState.Maximized
        frmmatrices.Show()
    End Sub

    Private Sub ArregloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArregloToolStripMenuItem.Click
        frmarreglo.MdiParent = Me
        frmarreglo.WindowState = FormWindowState.Maximized
        frmarreglo.Show()
    End Sub
End Class
