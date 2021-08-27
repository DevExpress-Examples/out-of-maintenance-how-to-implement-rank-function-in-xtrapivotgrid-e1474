<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582153/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1474)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to implement rank function in XtraPivotGrid


<p>This example shows how to implement a rank function in the XtraPivotGrid. In this project a "per-column" summary snapshot is made after the XtraPivotGrid is bound to data. It is stored in the salesPerYear and totalSales Form1 class members. The CustomCellDisplayText event handler searches for the current values in these variables. Its index will be its rank, because the list is sorted.</p>

<br/>


