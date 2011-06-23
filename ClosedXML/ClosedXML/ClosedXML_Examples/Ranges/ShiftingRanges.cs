﻿using ClosedXML.Excel;

namespace ClosedXML_Examples
{
    public class ShiftingRanges
    {
        public void Create()
        {
            var workbook = new XLWorkbook(@"C:\Excel Files\Created\BasicTable.xlsx");
            var ws = workbook.Worksheet(1);

            // Get a range object
            var rngHeaders = ws.Range("B3:F3");

            // Insert some rows/columns before the range
            ws.Row(1).InsertRowsAbove(2);
            ws.Column(1).InsertColumnsBefore(2);

            // Change the background color of the headers
            rngHeaders.Style.Fill.BackgroundColor = XLColor.LightSalmon;

            ws.Columns().AdjustToContents();
            
            workbook.SaveAs(@"C:\Excel Files\Created\ShiftingRanges.xlsx");
        }
    }
}