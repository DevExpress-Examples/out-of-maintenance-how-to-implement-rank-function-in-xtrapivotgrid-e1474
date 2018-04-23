# How to implement rank function in XtraPivotGrid


<p>This example shows how to implement a rank function in the XtraPivotGrid. In this project a "per-column" summary snapshot is made after the XtraPivotGrid is bound to data. It is stored in the salesPerYear and totalSales Form1 class members. The CustomCellDisplayText event handler searches for the current values in these variables. Its index will be its rank, because the list is sorted.</p>

<br/>


