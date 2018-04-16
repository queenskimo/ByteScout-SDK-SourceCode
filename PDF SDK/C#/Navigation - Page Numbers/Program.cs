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


using System.Diagnostics;
using Bytescout.PDF;

namespace PageNumbers
{
	/// <summary>
	/// This example demonstrates how to add page numbers (labels) visible in the page thumbnails panel of PDF viewer.
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Create new document
			Document pdfDocument = new Document();
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";

			// Add twenty pages
			for (int i = 0; i < 20; i++)
				pdfDocument.Pages.Add(new Page(PaperFormat.A4));

			// First five pages will have roman numbers I, II, III, ...
			PageLabel pageLabel = new PageLabel(0, PageNumberingStyle.UppercaseRoman);
			pdfDocument.PageLabels.Add(pageLabel);

			// Next five pages will have arabic numbers 6, 7, 8, ...
			pageLabel.Style = PageNumberingStyle.DecimalArabic;
			pageLabel.StartPortion = 6;
			pageLabel.FirstPageIndex = 5;
			pdfDocument.PageLabels.Add(pageLabel);

			// Next five pages will have complex page numbers with prefix A-11, A-12, A-13, ...
			pageLabel.Style = PageNumberingStyle.DecimalArabic;
			pageLabel.Prefix = "A-";
			pageLabel.StartPortion = 11;
			pageLabel.FirstPageIndex = 10;
			pdfDocument.PageLabels.Add(pageLabel);

			// Next five pages will use letters as page numbers P, Q, R, ...
			pageLabel.Prefix = "";
			pageLabel.Style = PageNumberingStyle.UppercaseLetters;
			pageLabel.StartPortion = 16;
			pageLabel.FirstPageIndex = 15;
			pdfDocument.PageLabels.Add(pageLabel);

			// Force PDF viewer to show page thumbnails panel on start up
			pdfDocument.PageMode = PageMode.Thumbnail;
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
