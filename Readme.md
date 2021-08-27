<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1474)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to implement rank function in XtraPivotGrid


<p>This example shows how to implement a rank function in the XtraPivotGrid. In this project a "per-column" summary snapshot is made after the XtraPivotGrid is bound to data. It is stored in the salesPerYear and totalSales Form1 class members. The CustomCellDisplayText event handler searches for the current values in these variables. Its index will be its rank, because the list is sorted.</p>


<h3>Description</h3>

<p>Please note that in OLAP mode, you can&#39;t bind different PivotGridFields to the same field in the data source. In OLAP mode, bind the Rank field to any unnecessary measure, and use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetCellValuetopic6">PivotCellBaseEventArgs.GetCellValue</a> method to retrieve a value within the CustomCellDisplaytext event handler.</p>

<br/>


