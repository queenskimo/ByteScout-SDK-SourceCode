//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.Spreadsheet;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("Hello_world.xlsx");

            // Get worksheet
            Worksheet worksheet = document.Workbook.Worksheets.ByName("Sheet1");

            // Read cell value
            Console.WriteLine("Cell (0,0) value: {0}", worksheet.Cell(0, 0).ValueAsString);

            // Write message
            Console.Write("Press any key to continue...");

            // Wait user input
            Console.ReadKey();
        }
    }
}
