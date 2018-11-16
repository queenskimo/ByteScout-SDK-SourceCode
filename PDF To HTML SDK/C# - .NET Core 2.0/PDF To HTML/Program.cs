//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDF2HTML;

namespace PdfToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDF2HTML.HTMLExtractor instance
            HTMLExtractor extractor = new HTMLExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Set HTML with CSS extraction mode
            extractor.ExtractionMode = HTMLExtractionMode.HTMLWithCSS;

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\sample2.pdf");

            // Save extracted HTML to file
            extractor.SaveHtmlToFile(@".\output.html");

            // Cleanup
            extractor.Dispose();

            // Open output file in default associated application
            Process.Start(new ProcessStartInfo("output.html") { UseShellExecute = true });
        }
    }
}
