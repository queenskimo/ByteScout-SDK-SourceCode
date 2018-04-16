//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;

using Bytescout.PDFRenderer;


namespace SilentPrinting
{
	class Program
	{
		static void Main(string[] args)
		{
            const string PrinterName = "Microsoft Print to PDF";

            // Create an instance of Bytescout.PDFRenderer.DocumentPrinter object and register it.
            DocumentPrinter documentPrinter = new DocumentPrinter();
			documentPrinter.RegistrationName = "demo";
			documentPrinter.RegistrationKey = "demo";

			// Load PDF document.
			documentPrinter.LoadDocumentFromFile("multipage.pdf");

			// Change some printing options for demo purposes 
            // (note, some options might be not supported by the printer):

            // Change paper orientation
		    documentPrinter.Landscape = true;
            // Set number of copies
		    documentPrinter.Copies = 2;
            // Set collation
		    documentPrinter.Collate = true;
            // Force black and white printing
		    documentPrinter.Color = false;

            // Print all document pages to the specified printer
		    documentPrinter.PrintDocument(PrinterName);

            // To print specific pages use overridden methods allowing to define pages to print:
            //documentPrinter.PrintDocument(PrinterName, 2, 4); // printer pages from 3 to 5
		    //documentPrinter.PrintDocument(PrinterName, new int[] {0, 2, 3, 4, 6}); // print specific pages
		    //documentPrinter.PrintDocument(PrinterName, "1,3-5,7-");

		    documentPrinter.Dispose();
		}
	}
}
