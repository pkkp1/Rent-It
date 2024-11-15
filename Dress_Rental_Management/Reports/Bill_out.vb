Imports CrystalDecisions.CrystalReports.Engine
Public Class Bill_out
    Public val(8) As String

    Public Sub ldata()
        Try
            Dim orpt As New ReportDocument
            Dim d As New Bill_Print
            d.Load()
            orpt.Load(d.FileName)
            orpt.Refresh()
            orpt.SetDataSource(dsReprt.Tables(0))
            CrystalReportViewer1.ReportSource = orpt

            orpt.SetParameterValue("BillID", val(0))
            orpt.SetParameterValue("ShopName", val(1))
            orpt.SetParameterValue("ShopAddr", val(2))
            orpt.SetParameterValue("CustName", val(3))
            orpt.SetParameterValue("CustNo", val(4))
            orpt.SetParameterValue("Subtot", val(5))
            orpt.SetParameterValue("disc", val(6))
            orpt.SetParameterValue("gtot", val(7))
            Me.BringToFront()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReportingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ldata()
    End Sub
End Class