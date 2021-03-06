//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2020 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

{

 IMPORTANT NOTICE for DELPHI 2007, Delphi 2006 or earlier versions:
 -----------------------------------------------------------------------
 Usual approach with type library import (so called "early binding") will crash with "stackoverflow" or "floating point error" due to issues in this versions of Delphi. 
 SOLUTION: Please use so called "late binding" that requires NO type library import and works by creating objects at the runtime like this:  
 // -----------------
 program Project1;
 uses
   SysUtils,
   ComObj,
   ActiveX;
 var
 extractor: Variant;
 begin
 CoInitialize(nil);
 // Create and initialize 
 extractor := CreateOleObject('Bytescout.PDFExtractor.CSVExtractor') ;
 // as usual 
 extractor.LoadDocumentFromFile ('../../sample3.pdf');
 // …
 // destroy the object by setting to varEmpty
 extractor := varEmpty;  
 end.
 // -----------------  

}

program Project1;

{$APPTYPE CONSOLE}

{
 IMPORTANT:
  To work with Bytescout PDF Extractor SDK you may also use Late Binding

}

uses
  SysUtils,
  ComObj,
  ActiveX;

var
 extractor: Variant;
begin
 CoInitialize(nil);

 // Create and initialize Bytescout.PDFExtractor.CSVExtractor object using CoCSVExtractor class
 extractor := CreateOleObject('Bytescout.PDFExtractor.CSVExtractor') ; 
 extractor.RegistrationName := 'demo';
 extractor.RegistrationKey := 'demo';

 // Load sample PDF document
 extractor.LoadDocumentFromFile ('../../sample3.pdf');

// extractor.CSVSeparatorSymbol = ','; // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales

 extractor.SaveCSVToFile ('output.csv');

 // destroy the extractor object
 extractor := varEmpty;

end.
