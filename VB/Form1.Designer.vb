Imports Microsoft.VisualBasic
Imports System
Namespace RankFunctionSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldProduct = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldRank = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProduct, Me.pivotGridField3, Me.fieldRank, Me.fieldYear})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(830, 504)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomCellDisplayText += New DevExpress.XtraPivotGrid.PivotCellDisplayTextEventHandler(Me.pivotGridControl1_CustomCellDisplayText);
			' 
			' fieldProduct
			' 
			Me.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProduct.AreaIndex = 0
			Me.fieldProduct.FieldName = "Product"
			Me.fieldProduct.Name = "fieldProduct"
			' 
			' pivotGridField3
			' 
			Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField3.AreaIndex = 0
			Me.pivotGridField3.FieldName = "Sales"
			Me.pivotGridField3.Name = "pivotGridField3"
			' 
			' fieldRank
			' 
			Me.fieldRank.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldRank.AreaIndex = 1
			Me.fieldRank.Caption = "Rank"
			Me.fieldRank.FieldName = "Sales"
			Me.fieldRank.Name = "fieldRank"
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.FieldName = "Year"
			Me.fieldYear.Name = "fieldYear"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(854, 528)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldProduct As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldRank As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

