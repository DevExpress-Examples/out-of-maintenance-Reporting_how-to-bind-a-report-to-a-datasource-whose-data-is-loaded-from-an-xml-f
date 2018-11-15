<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraReport_RuntimeDataBinding/Form1.cs) (VB: [Form1.vb](./VB/XtraReport_RuntimeDataBinding/Form1.vb))
<!-- default file list end -->
# How to bind a report to a datasource, whose data is loaded from an XML file


<p>This code sample illustrates how to bind a report to XML data stored in a file (Cars.xml in this case). <br>For a design-time tutorial, see <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument5154">How to: Bind a Report to an XML File</a>.</p>


<h3>Description</h3>

To accomplish this task, create a <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessSqlSqlDataSourcetopic">SqlDataSource</a>. Then, create a <strong>SelectQuery</strong> to access data of the required data table.

<br/>


