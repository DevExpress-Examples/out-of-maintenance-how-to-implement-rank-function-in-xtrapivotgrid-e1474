# How to implement rank function in XtraPivotGrid


<p>This example shows how to implement a rank function in the XtraPivotGrid. In this project a "per-column" summary snapshot is made after the XtraPivotGrid is bound to data. It is stored in the salesPerYear and totalSales Form1 class members. The CustomCellDisplayText event handler searches for the current values in these variables. Its index will be its rank, because the list is sorted.</p>


<h3>Description</h3>

<p>Please note that in OLAP mode, you can&#39;t bind different PivotGridFields to the same field in the data source. In OLAP mode, bind the Rank field to any unnecessary measure, and use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotCellBaseEventArgs_GetCellValuetopic6">PivotCellBaseEventArgs.GetCellValue</a> method to retrieve a value within the CustomCellDisplaytext event handler.</p>

<br/>


