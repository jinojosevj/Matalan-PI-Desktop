#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PICountDesktopApp.DAL;
using System.Data;
using System.Data.SqlClient;
#endregion NameSpace
namespace PICountDesktopApp.BAL
{
    class PICountBL
    {
        #region Properties
        /// <summary>
        /// DtSource
        /// </summary>
        public DataTable DtSource
        {
            get;
            set;
        }
        /// <summary>
        /// ExceptionMessage
        /// </summary>
        public String ExceptionMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Type
        /// </summary>
        public String Type
        {
            get;
            set;
        }

        /// <summary>
        /// Doc No
        /// </summary>
        public String DocNo
        {
            get;
            set;
        }


        /// <summary>
        /// Pdt Name
        /// </summary>
        public String PdtName
        {
            get;
            set;
        }

        /// <summary>
        /// Scanning Done By
        /// </summary>
        public String ScanningDoneBy
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// </summary>
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// CreatedBy
        /// </summary>
        public String CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Username
        /// </summary>
        public String Username
        {
            get;
            set;
        }

        /// <summary>
        /// Password
        /// </summary>
        public String Password
        {
            get;
            set;
        }

        /// <summary>
        /// NewPassword
        /// </summary>
        public String NewPassword
        {
            get;
            set;
        }

        /// <summary>
        ///Category Code
        /// </summary>
        public String CategoryCode
        {
            get;
            set;
        }
        /// <summary>
        ///Division Code
        /// </summary>
        public String DivisionCode
        {
            get;
            set;
        }

        /// <summary>
        ///FamilyCode
        /// </summary>
        public String FamilyCode
        {
            get;
            set;
        }

        /// <summary>
        ///Line Code 12
        /// </summary>
        public String LineCode12
        {
            get;
            set;
        }

        /// <summary>
        ///Barcode
        /// </summary>
        public String Barcode
        {
            get;
            set;
        }

        /// <summary>
        ///ReciptDate
        /// </summary>
        public DateTime ReciptDate
        {
            get;
            set;
        }

        /// <summary>
        ///Quantity
        /// </summary>
        public int Quantity
        {
            get;
            set;
        }

        /// <summary>
        /// Filter Type
        /// </summary>
        public string FilterType
        {
            get;
            set;
        }
        /// <summary>
        ///Id
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Remarks
        /// </summary>
        public string Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Variance Adjustments
        /// </summary>
        public int VarianceAdjustment
        {
            get;
            set;
        }

        /// <summary>
        /// Company Name
        /// </summary>
        public String CompanyName
        {
            get;
            set;
        }

        /// <summary>
        /// Journal Template Name
        /// </summary>
        public String JournalTemplateName
        {
            get;
            set;
        }

        /// <summary>
        /// Journal Batch Name
        /// </summary>
        public String JournalBatchName
        {
            get;
            set;
        }
        /// <summary>
        /// ItemNo
        /// </summary>
        public String ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// PostingDate
        /// </summary>
        public DateTime PostingDate
        {
            get;
            set;
        }

        /// <summary>
        /// EntryType
        /// </summary>
        public int EntryType
        {
            get;
            set;
        }

        /// <summary>
        /// DocumentNo
        /// </summary>
        public String DocumentNo
        {
            get;
            set;
        }

        /// <summary>
        /// LocationCode
        /// </summary>
        public String LocationCode
        {
            get;
            set;
        }

        /// <summary>
        /// StoreCode
        /// </summary>
        public String StoreCode
        {
            get;
            set;
        }
        /// <summary>
        /// Quantity
        /// </summary>
        public Decimal QuantityD
        {
            get;
            set;
        }

        /// <summary>
        /// UnitAmount
        /// </summary>
        public Decimal UnitAmount
        {
            get;
            set;
        }

        /// <summary>
        /// UnitCost
        /// </summary>
        public Decimal UnitCost
        {
            get;
            set;
        }

        /// <summary>
        /// Amount
        /// </summary>
        public Decimal Amount
        {
            get;
            set;
        }
        /// <summary>
        /// Qty_Calculated
        /// </summary>
        public Decimal Qty_Calculated
        {
            get;
            set;
        }

        /// <summary>
        /// Qty_Phys_Inventory
        /// </summary>
        public Decimal Qty_Phys_Inventory
        {
            get;
            set;
        }

        /// <summary>
        /// DocumentDate
        /// </summary>
        public DateTime DocumentDate
        {
            get;
            set;
        }

        /// <summary>
        /// ExternalDocNo
        /// </summary>
        public string ExternalDocNo
        {
            get;
            set;
        }
        /// <summary>
        /// Manual Count
        /// </summary>
        public int ManualCount
        {
            get;
            set;
        }

        /// <summary>
        /// SystemQty
        /// </summary>
        public int SystemQty
        {
            get;
            set;
        }
        /// <summary>
        /// CountQty
        /// </summary>
        public int CountQty
        {
            get;
            set;
        }

        /// <summary>
        /// Variance
        /// </summary>
        public int Variance
        {
            get;
            set;
        }


        #endregion Properties


        #region Methods

        #region ImportBarcodeData
        /// <summary>
        /// Import Barcode Data
        /// </summary>
        /// <returns></returns>

        public bool ImportBarcodeData()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.DtSource = DtSource;
                Result = objPI.ImportBarcodeData();

            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion Import Barcode Data

        #region DeleteTempBarcode
        /// <summary>
        /// Delete Temp Barcode
        /// </summary>
        /// <returns></returns>

        public bool DeleteTempBarcode()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();
                Result = objPI.DeleteTempBarcode();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion Delete Temp Barcode

        #region Get Document No
        /// <summary>
        /// Get Document No
        /// </summary>
        /// <returns></returns>
        public DataTable GetDocumentNo()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.Type = Type;
                dtPI = objPI.GetDocumentNo();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion Get Document No

        #region UpdateItemMaster
        /// <summary>
        /// Update Item Master
        /// </summary>
        /// <returns></returns>

        public bool UpdateItemMaster()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();
                Result = objPI.UpdateItemMaster();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion Update Item Master

        #region GetPIVarianceReport
        /// <summary>
        /// GetPIVarianceReport
        /// </summary>
        /// <returns></returns>
        public DataTable GetPIVarianceReport()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                
                objPI.DocNo = DocNo;
                objPI.FilterType = FilterType;
                objPI.CategoryCode = CategoryCode;
                objPI.DivisionCode = DivisionCode;
                
                objPI.FamilyCode = FamilyCode;
                objPI.LineCode12 = LineCode12;
                objPI.Barcode = Barcode;
                objPI.Quantity = Quantity;
                
                objPI.ReciptDate = ReciptDate;

                dtPI = objPI.GetPIVarianceReport();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion GetPIVarianceReport

        #region ExportPIVarianceReport
        /// <summary>
        /// ExportPIVarianceReport
        /// </summary>
        /// <returns></returns>
        public DataTable ExportPIVarianceReport()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                objPI.Type = Type;
                dtPI = objPI.ExportPIVarianceReport();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion ExportPIVarianceOnly

        #region InsertVarianceReportHeader
        /// <summary>
        /// Insert Variance Report Header
        /// </summary>
        /// <returns></returns>

        public bool InsertVarianceReportHeader()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();
                
                objPI.DocNo = DocNo;
                objPI.PdtName = PdtName;
                objPI.ScanningDoneBy = ScanningDoneBy;
                objPI.Description = Description;

                objPI.CreatedBy = CreatedBy;
                objPI.Type = Type;
                Result = objPI.InsertVarianceReportHeader();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion InsertVarianceReportHeader

        #region CheckLogin
        /// <summary>
        /// Check Login
        /// </summary>
        /// <returns></returns>
        public DataTable CheckLogin()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.Username= Username;
                objPI.Password = Password;
                dtPI = objPI.CheckLogin();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion CheckLogin

        #region ChangePassword
        /// <summary>
        /// ChangePassword
        /// </summary>
        /// <returns></returns>

        public bool ChangePassword()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.Username = Username;
                objPI.Password = Password;
                objPI.NewPassword = NewPassword;

                Result = objPI.ChangePassword();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }
        #endregion ChangePassword
        
        #region GetVarianceReportHeaderById
        /// <summary>
        /// Get Variance Report Header ById
        /// </summary>
        /// <returns></returns>
        public DataTable GetVarianceReportHeaderById()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                dtPI = objPI.GetVarianceReportHeaderById();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }
        #endregion GetVarianceReportHeaderById

        #region GetVarianceReportHeader
        /// <summary>
        /// Get Variance Report Header 
        /// </summary>
        /// <returns></returns>
        public DataTable GetVarianceReportHeader()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.Type = Type;
                dtPI = objPI.GetVarianceReportHeader();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }
        #endregion GetVarianceReportHeader

        #region GetItemCategoryCode
        /// <summary>
        /// GetItemCategoryCode
        /// </summary>
        /// <returns></returns>
        public DataTable GetItemCategoryCode()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                dtPI = objPI.GetItemCategoryCode();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }
        #endregion GetItemCategoryCode

        #region GetDivision
        /// <summary>
        /// GetDivision
        /// </summary>
        /// <returns></returns>
        public DataTable GetDivision()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                dtPI = objPI.GetDivision();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }
        #endregion GetDivision

        #region GetVarianceReportHeaderByDate
        /// <summary>
        /// GetVarianceReportHeaderByDate
        /// </summary>
        /// <returns></returns>
        public DataTable GetVarianceReportHeaderByDate()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.Username = Username;
                dtPI = objPI.GetVarianceReportHeaderByDate();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }
        #endregion GetVarianceReportHeaderByDate

        #region Update Variance Report
        /// <summary>
        /// Update Variance Report
        /// </summary>
        /// <returns></returns>

        public bool UpdateVarianceReport()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.Id = Id;
                objPI.Remarks = Remarks;
                objPI.ManualCount = ManualCount;
                objPI.VarianceAdjustment = VarianceAdjustment;
                objPI.UnitCost = UnitCost;
                Result = objPI.UpdateVarianceReport();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion Update Variance Report


        #region InsertInventoryToNav
        /// <summary>
        /// InsertInventoryToNav
        /// </summary>
        /// <returns></returns>

        public bool InsertInventoryToNav()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.CompanyName = CompanyName;
                objPI.JournalTemplateName = JournalTemplateName;
                objPI.JournalBatchName = JournalBatchName;
                objPI.ItemNo = ItemNo;

                objPI.PostingDate = PostingDate;
                objPI.EntryType = EntryType;
                objPI.DocumentNo = DocumentNo;
                objPI.LocationCode = LocationCode;

                objPI.StoreCode = StoreCode;
                objPI.QuantityD = QuantityD;
                objPI.UnitAmount = UnitAmount;
                objPI.UnitCost = UnitCost;

                objPI.Amount = Amount;
                objPI.Qty_Calculated = Qty_Calculated;
                objPI.Qty_Phys_Inventory = Qty_Phys_Inventory;
                objPI.DocumentDate = DocumentDate;

                objPI.ExternalDocNo = ExternalDocNo;
                Result = objPI.InsertInventoryToNav();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion InsertInventoryToNav

        #region Get Batch Name
        /// <summary>
        /// Get Batch Name
        /// </summary>
        /// <returns></returns>
        public DataTable GetBatchName()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                dtPI = objPI.GetBatchName();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }
        #endregion Get Batch Name 

             
        #region GetWriteOffReport
        /// <summary>
        /// GetPIVarianceReport
        /// </summary>
        /// <returns></returns>
        public DataTable GetWriteOffReport()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                dtPI = objPI.GetWriteOffReport();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion GetWriteOffReport


        #region ExportBarcodesForPdt
        /// <summary>
        /// ExportBarcodesForPdt
        /// </summary>
        /// <returns></returns>
        public DataTable ExportBarcodesForPdt()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                dtPI = objPI.ExportBarcodesForPdt();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion ExportBarcodesForPdt

        #region GetNegativeReport
        /// <summary>
        /// GetNegativeReport
        /// </summary>
        /// <returns></returns>
        public DataTable GetNegativeReport()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                dtPI = objPI.GetNegativeReport();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion GetNegativeReport


        #region ImportVarianceReportData
        /// <summary>
        /// ImportVarianceReportData
        /// </summary>
        /// <returns></returns>
        public bool ImportVarianceReportData()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.DocNo = DocNo;
                objPI.LocationCode = LocationCode;
                objPI.Barcode = Barcode;
                objPI.ItemNo = ItemNo;

                objPI.CategoryCode = CategoryCode;
                objPI.Description = Description;
                objPI.SystemQty = SystemQty;
                objPI.CountQty = CountQty;

                objPI.Variance = Variance;
                objPI.Remarks = Remarks;
                objPI.VarianceAdjustment = VarianceAdjustment;
                objPI.ManualCount = ManualCount;

                Result = objPI.ImportVarianceReportData();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion ImportVarianceReportData

        #region DeleteVarianceReport
        /// <summary>
        /// DeleteVarianceReport
        /// </summary>
        /// <returns></returns>
        public bool DeleteVarianceReport()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                Result = objPI.DeleteVarianceReport();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion DeleteVarianceReport


        #region ImportPOData
        /// <summary>
        /// ImportPOData
        /// </summary>
        /// <returns></returns>

        public bool ImportPOData()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.DtSource = DtSource;
                Result = objPI.ImportPOData();

            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion ImportPOData

        #region GetPOReport
        /// <summary>
        /// GetPOReport
        /// </summary>
        /// <returns></returns>
        public DataTable GetPOReport()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                dtPI = objPI.GetPOReport();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion GetPOReport

        #region ImportLabelData
        /// <summary>
        /// ImportLabelData
        /// </summary>
        /// <returns></returns>
        public bool ImportLabelData()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.DtSource = DtSource;
                Result = objPI.ImportLabelData();

            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion ImportLabelData

        #region UpdateItemBarcodePrint
        /// <summary>
        /// UpdateItemBarcodePrint
        /// </summary>
        /// <returns></returns>

        public bool UpdateItemBarcodePrint()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.DocNo = DocNo;
                Result = objPI.UpdateItemBarcodePrint();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }
        #endregion UpdateItemBarcodePrint


        #region GetTransferFile
        /// <summary>
        /// GetTransferFile
        /// </summary>
        /// <returns></returns>
        public DataTable GetTransferFile()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                dtPI = objPI.GetTransferFile();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion GetTransferFile


        #region ImportTransferData
        /// <summary>
        /// ImportTransferData
        /// </summary>
        /// <returns></returns>

        public bool ImportTransferData()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.DtSource = DtSource;
                Result = objPI.ImportTransferData();

            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }

        #endregion ImportTransferData


        #region GetTranferFileForChecking
        /// <summary>
        /// GetTranferFileForChecking
        /// </summary>
        /// <returns></returns>
        public DataTable GetTranferFileForChecking()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                dtPI = objPI.GetTranferFileForChecking();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion GetTranferFileForChecking

        #region GetBatchNameById
        /// <summary>
        /// GetBatchNameById
        /// </summary>
        /// <returns></returns>
        public DataTable GetBatchNameById()
        {
            DataTable dtPI = null;
            try
            {
                PICountDAL objPI = new PICountDAL();
                objPI.DocNo = DocNo;
                dtPI = objPI.GetBatchNameById();
            }
            catch (Exception e)
            {

            }
            return dtPI;
        }

        #endregion GetBatchNameById


        #region InsertItemBarcodePrint
        /// <summary>
        /// InsertItemBarcodePrint
        /// </summary>
        /// <returns></returns>

        public bool InsertItemBarcodePrint()
        {
            bool Result = false;
            try
            {
                PICountDAL objPI = new PICountDAL();

                objPI.DocNo = DocNo;
                Result = objPI.InsertItemBarcodePrint();
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }
        #endregion InsertItemBarcodePrint

        #endregion Methods

    }
}
