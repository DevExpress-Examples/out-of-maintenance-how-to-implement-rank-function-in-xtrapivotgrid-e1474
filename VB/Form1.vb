Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.PivotGrid
Imports System.Collections

Namespace RankFunctionSample
	Partial Public Class Form1
		Inherits Form
		Private salesPerYear As Dictionary(Of Integer, List(Of Decimal))
		Private totalSales As List(Of Decimal)

		Public Sub New()
			InitializeComponent()

			Dim data As New DataTable()
			data.Columns.Add("Product", GetType(String))
			data.Columns.Add("Year", GetType(Integer))
			data.Columns.Add("Sales", GetType(Decimal))

			Dim r As New Random(0)
			For i As Integer = 0 To 99
				data.Rows.Add("Product " & r.Next(12).ToString(), 2006 + r.Next(3), r.Next(30))
			Next i

			pivotGridControl1.DataSource = data

			CalculateSalesPerYear()
			CalculateSalesPerProduct()
		End Sub
		Private Sub CalculateSalesPerYear()
			salesPerYear = New Dictionary(Of Integer, List(Of Decimal))()
			Dim ds As PivotSummaryDataSource = pivotGridControl1.CreateSummaryDataSource()
			For i As Integer = 0 To ds.RowCount - 1
				Dim year As Integer = CInt(Fix(ds.GetValue(i, fieldYear)))
				Dim list As List(Of Decimal)
				If (Not salesPerYear.TryGetValue(year, list)) Then
					list = New List(Of Decimal)()
					salesPerYear.Add(year, list)
				End If
				list.Add(CDec(ds.GetValue(i, fieldRank)))
			Next i
			For Each list As List(Of Decimal) In salesPerYear.Values
				list.Sort(AddressOf ReverseDecimalSort)
			Next list
		End Sub
		Private Sub CalculateSalesPerProduct()
			Dim sales As New Dictionary(Of String, Decimal)()
			Dim ds As PivotSummaryDataSource = pivotGridControl1.CreateSummaryDataSource()
			For i As Integer = 0 To ds.RowCount - 1
				Dim product As String = CStr(ds.GetValue(i, fieldProduct))
				Dim sale As Decimal = CDec(ds.GetValue(i, fieldRank))
				If sales.ContainsKey(product) Then
					sales(product) += sale
				Else
					sales.Add(product, sale)
				End If
			Next i
			totalSales = New List(Of Decimal)(sales.Count)
			For Each value As Decimal In sales.Values
				totalSales.Add(value)
			Next value
			totalSales.Sort(AddressOf ReverseDecimalSort)
		End Sub
		Private Sub pivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As PivotCellDisplayTextEventArgs) Handles pivotGridControl1.CustomCellDisplayText
			If e.DataField IsNot fieldRank Then
				Return
			End If
			e.DisplayText = ""
			If e.RowValueType = PivotGridValueType.GrandTotal OrElse e.Value Is Nothing Then
				Return
			End If
			If e.ColumnValueType = PivotGridValueType.GrandTotal Then
				e.DisplayText = (totalSales.IndexOf(Convert.ToDecimal(e.Value)) + 1).ToString()
				Return
			Else
				Dim sales As List(Of Decimal)
				If salesPerYear.TryGetValue(CInt(Fix(e.GetFieldValue(fieldYear))), sales) Then
					e.DisplayText = (sales.IndexOf(Convert.ToDecimal(e.Value)) + 1).ToString()
				End If
			End If
		End Sub
		Private Function ReverseDecimalSort(ByVal a As Decimal, ByVal b As Decimal) As Integer
			Return -Comparer(Of Decimal).Default.Compare(a, b)
		End Function
	End Class
End Namespace