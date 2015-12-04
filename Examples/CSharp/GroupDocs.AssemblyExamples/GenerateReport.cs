﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDocs.Assembly;
using GroupDocs.AssemblyExamples.BusinessLayer;
using GroupDocs.AssemblyExamples.ProjectEntities;

namespace GroupDocs.AssemblyExamples
{
    public static class GenerateReport
    {

        public static void GenerateBubbleChart(string strDocumentFormat, bool isDatabase)
        {

            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateBubbleChartFromDatabaseinDocumentProcessingFormat
                        //setting up source document template
                        const String strDocumentTemplate = "Word Templates/Bubble Chart_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Bubble Chart_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();//initialize object of DocumentAssembler class 
                            //Call AssembleDocument to generate Bubble Chart Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBubbleChartFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateBubbleChartinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Bubble Chart.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Bubble Chart Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bubble Chart Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBubbleChartinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateBubbleChartFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Bubble Chart_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Bubble Chart_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bubble Chart Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBubbleChartFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateBubbleChartinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Bubble Chart.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Bubble Chart Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bubble Chart Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBubbleChartinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateBubbleChartFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Bubble Chart_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Bubble Chart_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bubble Chart Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBubbleChartFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateBubbleChartinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Bubble Chart.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Bubble Chart Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bubble Chart Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBubbleChartinPresentationFormat
                    }
                    break;
            }
        }
        public static void GenerateBulletedList(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateBulletedListFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Bulleted List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Bulleted List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bulleted List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBulletedListFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateBulletedListinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Bulleted List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Bulleted List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bulleted List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBulletedListinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateBulletedListFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Bulleted List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Bulleted List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bulleted List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBulletedListFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateBulletedListinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Bulleted List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Bulleted List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bulleted List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBulletedListinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateBulletedListFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Bulleted List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Bulleted List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bulleted List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBulletedListFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateBulletedListinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Bulleted List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Bulleted List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Bulleted List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateBulletedListinPresentationFormat
                    }
                    break;
            }
        }


        public static void GenerateChartWithFilteringGroupingAndOrdering(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateChartWithFilteringGroupingAndOrderingFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Chart with Filtering, Grouping, and Ordering_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Chart with Filtering, Grouping, and Ordering_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Chart report with Filtering, Grouping, and Ordering in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateChartWithFilteringGroupingAndOrderingFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateChartWithFilteringGroupingAndOrderinginDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Chart with Filtering, Grouping, and Ordering.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Chart with Filtering, Grouping, and Ordering Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Chart report with Filtering, Grouping, and Ordering in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateChartWithFilteringGroupingAndOrderinginDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateChartWithFilteringGroupingAndOrderingFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Chart with Filtering, Grouping, and Ordering_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Chart with Filtering, Grouping, and Ordering_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Chart report with Filtering, Grouping, and Ordering in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateChartWithFilteringGroupingAndOrderingFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateChartWithFilteringGroupingAndOrderinginSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Chart with Filtering, Grouping, and Ordering.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Chart with Filtering, Grouping, and Ordering Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Chart report with Filtering, Grouping, and Ordering in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateChartWithFilteringGroupingAndOrderinginSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateChartWithFilteringGroupingAndOrderingFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Chart with Filtering, Grouping, and Ordering_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Chart with Filtering, Grouping, and Ordering_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Chart report with Filtering, Grouping, and Ordering in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateChartWithFilteringGroupingAndOrderingFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateChartWithFilteringGroupingAndOrderinginPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Chart with Filtering, Grouping, and Ordering.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Chart with Filtering, Grouping, and Ordering Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Chart report with Filtering, Grouping, and Ordering in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateChartWithFilteringGroupingAndOrderinginPresentationFormat
                    }
                    break;
            }
        }
        public static void GenerateCommonList(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateCommonListFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Common List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Common List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonListFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateCommonListinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Common List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Common List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonListinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateCommonListFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Common List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Common List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonListFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateCommonListinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Common List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Common List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonListinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateCommonListFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Common List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Common List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonListFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateCommonListinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Common List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Common List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonListinPresentationFormat
                    }
                    break;
            }
        }
        public static void GenerateCommonMasterDetail(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateCommonMasterDetailFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Common Master-Detail_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Common Master-Detail_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common Master-Detail Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonMasterDetailFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateCommonMasterDetailinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Common Master-Detail.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Common Master-Detail Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common Master-Detail Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonMasterDetailinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateCommonMasterDetailFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Common Master-Detail_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Common Master-Detail_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonMasterDetailFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateCommonMasterDetailinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Common Master-Detail.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Common Master-Detail Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonMasterDetailinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateCommonMasterDetailFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Common Master-Detail_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Common Master-Detail_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonMasterDetailFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateCommonMasterDetailinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Common Master-Detail.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Common Master-Detail Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Common List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateCommonMasterDetailinPresentationFormat
                    }
                    break;
            }
        }

        public static void GenerateInParagraphList(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInParagraphListFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Paragraph List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Paragraph List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Paragraph List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInParagraphListFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateInParagraphListinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Paragraph List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Paragraph List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Paragraph List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInParagraphListinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInParagraphListFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Paragraph List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Paragraph List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Paragraph List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInParagraphListFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateInParagraphListinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Paragraph List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Paragraph List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Paragraph List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInParagraphListinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInParagraphListFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Paragraph List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Paragraph List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Paragraph List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInParagraphListFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateInParagraphListinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Paragraph List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Paragraph List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Paragraph List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInParagraphListinPresentationFormat
                    }
                    break;
            }
        }
        public static void GenerateInTableListWithAlternateContent(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithAlternateContentFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table List with Alternate Content_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table List with Alternate Content_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Alternate Content Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithAlternateContentFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithAlternateContentinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table List with Alternate Content.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table List with Alternate Content Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Alternate Content Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithAlternateContentinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithAlternateContentFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table List with Alternate Content_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table List with Alternate Content_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Alternate Content Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithAlternateContentFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithAlternateContentinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table List with Alternate Content.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table List with Alternate Content Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Alternate Content Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithAlternateContentinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithAlternateContentFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table List with Alternate Content_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table List with Alternate Content_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Alternate Content Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithAlternateContentFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithAlternateContentinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table List with Alternate Content.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table List with Alternate Content Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Alternate Content Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithAlternateContentinPresentationFormat
                    }
                    break;
            }
        }
        public static void GenerateInTableListWithFilteringGroupingAndOrdering(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithFilteringGroupingAndOrderingFromDatabaseinDocumentProcessingDocument
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table List with Filtering, Grouping, and Ordering_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table List with Filtering, Grouping, and Ordering_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Filtering, Grouping, and Ordering Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithFilteringGroupingAndOrderingFromDatabaseinDocumentProcessingDocument
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithFilteringGroupingAndOrderinginDocumentProcessingDocument
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table List with Filtering, Grouping, and Ordering.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table List with Filtering, Grouping, and Ordering Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Filtering, Grouping, and Ordering Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithFilteringGroupingAndOrderinginDocumentProcessingDocument
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithFilteringGroupingAndOrderingFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table List with Filtering, Grouping, and Ordering_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table List with Filtering, Grouping, and Ordering_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Filtering, Grouping, and Ordering Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithFilteringGroupingAndOrderingFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithFilteringGroupingAndOrderinginSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table List with Filtering, Grouping, and Ordering.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table List with Filtering, Grouping, and Ordering Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Filtering, Grouping, and Ordering Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithFilteringGroupingAndOrderinginSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithFilteringGroupingAndOrderingFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table List with Filtering, Grouping, and Ordering_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table List with Filtering, Grouping, and Ordering_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Filtering, Grouping, and Ordering Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithFilteringGroupingAndOrderingFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithFilteringGroupingAndOrderinginPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table List with Filtering, Grouping, and Ordering.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table List with Filtering, Grouping, and Ordering Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Filtering, Grouping, and Ordering Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithFilteringGroupingAndOrderinginPresentationFormat
                    }
                    break;
            }
        }

        public static void GenerateInTableListWithHighlightedRows(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithHighlightedRowsFromDatabaseinDocumentProcessingDocument
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table List with Highlighted Rows_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table List with Highlighted Rows_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Highlighted Rows Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithHighlightedRowsFromDatabaseinDocumentProcessingDocument
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithHighlightedRowsinDocumentProcessingDocument
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table List with Highlighted Rows.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table List with Highlighted Rows Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Highlighted Rows Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithHighlightedRowsinDocumentProcessingDocument
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithHighlightedRowsFromDatabaseinSpreadsheetDocument
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table List with Highlighted Rows_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table List with Highlighted Rows_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Highlighted Rows Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithHighlightedRowsFromDatabaseinSpreadsheetDocument
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithHighlightedRowsinSpreadsheetDocument
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table List with Highlighted Rows.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table List with Highlighted Rows Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Highlighted Rows Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithHighlightedRowsinSpreadsheetDocument
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListWithHighlightedRowsFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table List with Highlighted Rows_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table List with Highlighted Rows_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Highlighted Rows Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithHighlightedRowsFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableListWithHighlightedRowsinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table List with Highlighted Rows.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table List with Highlighted Rows Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List with Highlighted Rows Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListWithHighlightedRowsinPresentationFormat
                    }
                    break;
            }
        }

        public static void GenerateInTableList(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (true)
                    {
                        //ExStart:GenerateInTableListFromDatabaseinDocumentProcessingDocument
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table List_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table List_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListFromDatabaseinDocumentProcessingDocument
                    }
                    else
                    {
                        //ExStart:GenerateInTableListinDocumentProcessingDocument
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListinDocumentProcessingDocument
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table List_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table List_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableListinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableListFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table List_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table List_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableListinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableListinPresentationFormat
                    }
                    break;
            }
        }
        public static void GenerateInTableMasterDetail(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableMasterDetailFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table Master-Detail_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table Master-Detail_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table Master-Detail Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableMasterDetailFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableMasterDetailinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/In-Table Master-Detail.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/In-Table Master-Detail Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table Master-Detail Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableMasterDetailinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableMasterDetailFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table Master-Detail_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table Master-Detail_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table Master-Detail Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableMasterDetailFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableMasterDetailinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/In-Table Master-Detail.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/In-Table Master-Detail Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table Master-Detail Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableMasterDetailinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateInTableMasterDetailFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table Master-Detail_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table Master-Detail_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table Master-Detail Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableMasterDetailFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateInTableMasterDetailinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/In-Table Master-Detail.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/In-Table Master-Detail Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate In-Table Master-Detail Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateInTableMasterDetailinPresentationFormat
                    }
                    break;
            }
        }

        public static void GenerateMulticoloredNumberedList(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateMulticoloredNumberedListFromDatabaseinDocumentProcessingDocument
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Multicolored Numbered List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Multicolored Numbered List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Multicolored Numbered List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateMulticoloredNumberedListFromDatabaseinDocumentProcessingDocument
                    }
                    else
                    {
                        //ExStart:GenerateMulticoloredNumberedListinDocumentProcessingDocument
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Multicolored Numbered List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Multicolored Numbered List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Multicolored Numbered List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateMulticoloredNumberedListinDocumentProcessingDocument
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateMulticoloredNumberedListFromDatabaseinSpreadsheetDocument
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Multicolored Numbered List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Multicolored Numbered List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Multicolored Numbered List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateMulticoloredNumberedListFromDatabaseinSpreadsheetDocument
                    }
                    else
                    {
                        //ExStart:GenerateMulticoloredNumberedListinSpreadsheetDocument
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Multicolored Numbered List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Multicolored Numbered List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Multicolored Numbered List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateMulticoloredNumberedListinSpreadsheetDocument
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateMulticoloredNumberedListFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Multicolored Numbered List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Multicolored Numbered List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Multicolored Numbered List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateMulticoloredNumberedListFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateMulticoloredNumberedListinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Multicolored Numbered List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Multicolored Numbered List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Multicolored Numbered List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateMulticoloredNumberedListinPresentationFormat
                    }
                    break;
            }
        }

        public static void GenerateNumberedList(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateNumberedListFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Numbered List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Numbered List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Numbered List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateNumberedListFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateNumberedListinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Numbered List.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Numbered List Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Numbered List Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateNumberedListinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateNumberedListFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Numbered List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Numbered List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Numbered List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateNumberedListFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateNumberedListinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Numbered List.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Numbered List Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Numbered List Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateNumberedListinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateNumberedListFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Numbered List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Numbered List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Numbered List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsDataDB(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateNumberedListFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateNumberedListinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Numbered List.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Numbered List Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Numbered List Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetProductsData(), "products");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateNumberedListinPresentationFormat
                    }
                    break;
            }
        }

        public static void GeneratePieChart(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GeneratePieChartFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Pie Chart_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Pie Chart_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Pie Chart Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GeneratePieChartFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GeneratePieChartinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Pie Chart.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Pie Chart Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Pie Chart Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GeneratePieChartinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GeneratePieChartFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Pie Chart_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Pie Chart_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Pie Chart Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GeneratePieChartFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GeneratePieChartinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Pie Chart.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Pie Chart Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Pie Chart Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GeneratePieChartinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GeneratePieChartFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Pie Chart_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Pie Chart_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Pie Chart Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetCustomersDataDB(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GeneratePieChartFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GeneratePieChartinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Pie Chart.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Pie Chart Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Pie Chart Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.PopulateData(), "customers");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GeneratePieChartinPresentationFormat
                    }
                    break;
            }
        }

        public static void GenerateScatterChart(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateScatterChartFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Scatter Chart_DB.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Scatter Chart_DB Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Scatter Chart Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateScatterChartFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateScatterChartinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Scatter Chart.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Scatter Chart Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Scatter Chart Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateScatterChartinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateScatterChartFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Scatter Chart_DB.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Scatter Chart_DB Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Scatter Chart Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateScatterChartFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateScatterChartinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Scatter Chart.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Scatter Chart Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Scatter Chart Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateScatterChartinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateScatterChartFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Scatter Chart_DB.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Scatter Chart_DB Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Scatter Chart Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersDataDB(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateScatterChartFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateScatterChartinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Scatter Chart.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Scatter Chart Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Scatter Chart Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetOrdersData(), "orders");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateScatterChartinPresentationFormat
                    }
                    break;
            }
        }

        public static void GenerateSingleRow(string strDocumentFormat, bool isDatabase)
        {
            switch (strDocumentFormat)
            {
                case "document":
                    if (isDatabase)
                    {
                        //ExStart:GenerateSingleRowFromDatabaseinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Single Row.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Single Row Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Single Row Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetSingleCustomerDataDB(), "customer");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateSingleRowFromDatabaseinDocumentProcessingFormat
                    }
                    else
                    {
                        //ExStart:GenerateSingleRowinDocumentProcessingFormat
                        //Setting up source document template
                        const String strDocumentTemplate = "Word Templates/Single Row.docx";
                        //Setting up destination document report 
                        const String strDocumentReport = "Word Reports/Single Row Report.docx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Single Row Report in document format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strDocumentTemplate), CommonUtilities.SetDestinationDocument(strDocumentReport), DataLayer.GetCustomerData(), "customer");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateSingleRowinDocumentProcessingFormat
                    }
                    break;

                case "spreadsheet":
                    if (isDatabase)
                    {
                        //ExStart:GenerateSingleRowFromDatabaseinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Single Row.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Single Row Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Single Row Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetSingleCustomerDataDB(), "customer");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateSingleRowFromDatabaseinSpreadsheetFormat
                    }
                    else
                    {
                        //ExStart:GenerateSingleRowinSpreadsheetFormat
                        //Setting up source spreadsheet template
                        const String strSpreadsheetTemplate = "Spreadsheet Templates/Single Row.xlsx";
                        //Setting up destination document report 
                        const String strSpreadsheetReport = "Spreadsheet Reports/Single Row Report.xlsx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Single Row Report in spreadsheet format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strSpreadsheetTemplate), CommonUtilities.SetDestinationDocument(strSpreadsheetReport), DataLayer.GetCustomerData(), "customer");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateSingleRowinSpreadsheetFormat
                    }
                    break;

                case "presentation":
                    if (isDatabase)
                    {
                        //ExStart:GenerateSingleRowFromDatabaseinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Single Row.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Single Row Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Single Row Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetSingleCustomerDataDB(), "customer");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateSingleRowFromDatabaseinPresentationFormat
                    }
                    else
                    {
                        //ExStart:GenerateSingleRowinPresentationFormat
                        //Setting up source spreadsheet template
                        const String strPresentationTemplate = "Presentation Templates/Single Row.pptx";
                        //Setting up destination document report 
                        const String strPresentationReport = "Presentation Reports/Single Row Report.pptx";
                        try
                        {
                            //Instantiate DocumentAssembler class
                            DocumentAssembler assembler = new DocumentAssembler();
                            //Call AssembleDocument to generate Single Row Report in presentation format
                            assembler.AssembleDocument(CommonUtilities.GetSourceDocument(strPresentationTemplate), CommonUtilities.SetDestinationDocument(strPresentationReport), DataLayer.GetCustomerData(), "customer");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //ExEnd:GenerateSingleRowinPresentationFormat
                    }
                    break;
            }
        }
    }
}
