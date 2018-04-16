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
using Bytescout.PDF.Converters;

namespace ConvertHtmlToDocx
{
	class Program
	{
		static void Main(string[] args)
		{
			using (HtmlToDocxConverter converter = new HtmlToDocxConverter())
			{
				converter.ConvertHtmlToDocx("sample.html", "result.docx");
			}

			// Open result file in default DOCX associated application
			Process.Start("result.docx");
		}
	}
}
