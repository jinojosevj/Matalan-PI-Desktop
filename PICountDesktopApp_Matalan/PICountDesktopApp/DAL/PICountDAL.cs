#region NameSpace
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;
#endregion NameSpace
namespace PICountDesktopApp.DAL
{
    class PICountDAL
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
        /// FilterType
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
        /// CompanyName
        /// </summary>
        public String CompanyName
        {
            get;
            set;
        }
        
        /// <summary>
        /// JournalTemplateName
        /// </summary>
        public String JournalTemplateName
        {
            get;
            set;
        }

        /// <summary>
        /// JournalBatchName
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
        /// ManualCount
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
        ///Import Barcode Data
        /// </summary>
        /// <param name="dtSource"></param>
        public bool ImportBarcodeData()
        {
            bool Result = false;
            try
            {
                DatabaseConnection dbPI = new DatabaseConnection();

                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
                //    ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

                string dbCntStr = dbPI.dbCntStr;

                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

                bcp.DestinationTableName = "TempBarcode";

                bcp.ColumnMappings.Add("Location", "Location");
                bcp.ColumnMappings.Add("Barcode", "Barcode");
                bcp.ColumnMappings.Add("CreatedDate", "CreatedDate");
                bcp.ColumnMappings.Add("CreatedBy", "CreatedBy");

                bcp.ColumnMappings.Add("DocNo", "DocNo");
                bcp.ColumnMappings.Add("FileName", "FileName");

                if (DtSource.Rows.Count > 0)
                {
                    bcp.WriteToServer(DtSource);
                    Result = true;
                    dbPI.CloseDbConnection();
                }
            }
            catch (SqlException ex)
            {
                ExceptionMessage = ex.Message;
            }

            return Result;

        }
        #endregion ImportBarcodeData

         #region Delete Temp Barcode
        /// <summary>
        /// Delete Temp Barcode
        /// </summary>
        /// <returns></returns>
        public bool DeleteTempBarcode()
        {
            bool Result = false;

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("TruncateTempBarcode", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                //cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }


        #endregion Delete Temp Barcode

         #region Get Document No
         /// <summary>
         ///  Get Document No
         /// </summary>
         /// <returns>Datatable Containing All GetDocumentNo</returns>
        public DataTable GetDocumentNo()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetDocumentNo", cnHrms);
                cmdHrms.Parameters.Add(new SqlParameter("@Type", SqlDbType.VarChar)).Value = Type;
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetDocumentNo


        #region Update Item Master
        /// <summary>
        /// Update Item Master
        /// </summary>
        /// <returns></returns>
        public bool UpdateItemMaster()
        {
            bool Result = false;

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("UpdateItemMaster", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                //cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }

        #endregion Update Item Master


        #region Get PI Variance Report
        /// <summary>
        ///  Get PI Variance Report 
        /// </summary>
        /// <returns>Datatable Containing All Get PI Variance Report </returns>
        public DataTable GetPIVarianceReport()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetPIVarianceReport", cnHrms);
                
                cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.Parameters.Add(new SqlParameter("@CategoryCode", SqlDbType.NVarChar)).Value = CategoryCode;
                cmdPI.Parameters.Add(new SqlParameter("@DivisionCode", SqlDbType.NVarChar)).Value = DivisionCode;
                cmdPI.Parameters.Add(new SqlParameter("@FamilyCode", SqlDbType.NVarChar)).Value = FamilyCode;
                
                cmdPI.Parameters.Add(new SqlParameter("@LineCode12", SqlDbType.NVarChar)).Value = LineCode12;
                cmdPI.Parameters.Add(new SqlParameter("@BarCode", SqlDbType.NVarChar)).Value = Barcode;
                cmdPI.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int)).Value = Quantity;
                cmdPI.Parameters.Add(new SqlParameter("@ReciptDate", SqlDbType.Date)).Value = ReciptDate.Date;

                cmdPI.Parameters.Add(new SqlParameter("@FilterType", SqlDbType.VarChar)).Value = FilterType;

                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion Get PI Variance Report

        #region ExportPIVarianceReport
        /// <summary>
        ///  ExportPIVarianceReport
        /// </summary>
        /// <returns>Datatable Containing All ExportPIVarianceReport </returns>
        public DataTable ExportPIVarianceReport()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("ExportPIVarianceReport", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.Parameters.Add(new SqlParameter("@Type", SqlDbType.VarChar)).Value = Type;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion ExportPIVarianceReport


        #region InsertVarianceReportHeader
        /// <summary>
        /// InsertVarianceReportHeader
        /// </summary>
        /// <returns></returns>
        public bool InsertVarianceReportHeader()
        {
            bool Result = false;

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("InsertVarianceReportHeader", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdHrms.Parameters.Add(new SqlParameter("@PdtName", SqlDbType.VarChar)).Value = PdtName;
                cmdHrms.Parameters.Add(new SqlParameter("@ScanningDoneBy", SqlDbType.VarChar)).Value = ScanningDoneBy;
                cmdHrms.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar)).Value = Description;

                cmdHrms.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.VarChar)).Value = CreatedBy;
                cmdHrms.Parameters.Add(new SqlParameter("@Type", SqlDbType.VarChar)).Value = Type;

                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }
       
        #endregion Insert Variance Report Header


        #region Check Login
        /// <summary>
        /// Check Login
        /// </summary>
        /// <returns>Datatable Containing All Check Login </returns>
        public DataTable CheckLogin()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("CheckLogin", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar)).Value =Username ;
                cmdPI.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar)).Value = Password;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion Check Login

        #region Change Password
        /// <summary>
        /// Change Password
        /// </summary>
        /// <returns></returns>
        public bool ChangePassword()
        {
            bool Result = false;

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("ChangePassword", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar)).Value = Username;
                cmdHrms.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar)).Value = Password;
                cmdHrms.Parameters.Add(new SqlParameter("@NewPassword", SqlDbType.VarChar)).Value = NewPassword;

                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }

        #endregion Change Password

        #region Get Variance Report Header ById
        /// <summary>
        ///  GetVarianceReportHeaderById
        /// </summary>
        /// <returns>Datatable Containing GetVarianceReportHeaderById </returns>
        public DataTable GetVarianceReportHeaderById()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetVarianceReportHeaderById", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetVarianceReportHeaderById

        #region Get Variance Report Header
        /// <summary>
        ///  GetVarianceReportHeader
        /// </summary>
        /// <returns>Datatable Containing GetVarianceReportHeader</returns>
        public DataTable GetVarianceReportHeader()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetVarianceReportHeader", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@Type", SqlDbType.VarChar)).Value =Type;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetVarianceReportHeader

        #region Get Item Category Code
        /// <summary>
        ///  Get Item Category Code
        /// </summary>
        /// <returns>Datatable Containing All Get Item Category Code </returns>
        public DataTable GetItemCategoryCode()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetItemCategoryCode", cnHrms);
                //cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion Get Item Category Code

        #region Get Division 
        /// <summary>
        ///  Get Division Code
        /// </summary>
        /// <returns>Datatable Containing All Get Division Code</returns>
        public DataTable GetDivision()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetDivision", cnHrms);
                //cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion Get Division

        #region GetVarianceReportHeaderByDate
        /// <summary>
        ///  GetVarianceReportHeaderByDate
        /// </summary>
        /// <returns>Datatable Containing All Get Variance Report Header By Date</returns>
        public DataTable GetVarianceReportHeaderByDate()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetVarianceReportHeaderByDate", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar)).Value = Username;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
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

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("UpdateVarianceReport", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt)).Value = Id;
                cmdHrms.Parameters.Add(new SqlParameter("@Remarks", SqlDbType.VarChar)).Value = Remarks;
                cmdHrms.Parameters.Add(new SqlParameter("@VarianceAdjustment", SqlDbType.Int)).Value = VarianceAdjustment;
                cmdHrms.Parameters.Add(new SqlParameter("@ManualCount", SqlDbType.Int)).Value = ManualCount;

                cmdHrms.Parameters.Add(new SqlParameter("@UnitCost", SqlDbType.Decimal)).Value = UnitCost;
                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
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

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("InsertInventoryToNav", cnHrms);
                //SqlCommand cmdHrms = new SqlCommand("TATIInsertInventoryToNav", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar)).Value = CompanyName;
                cmdHrms.Parameters.Add(new SqlParameter("@JournalTemplateName", SqlDbType.VarChar)).Value = JournalTemplateName;
                cmdHrms.Parameters.Add(new SqlParameter("@JournalBatchName", SqlDbType.VarChar)).Value = JournalBatchName;
                cmdHrms.Parameters.Add(new SqlParameter("@ItemNo_", SqlDbType.VarChar)).Value = ItemNo;

                cmdHrms.Parameters.Add(new SqlParameter("@PostingDate", SqlDbType.DateTime)).Value = PostingDate.Date;
                cmdHrms.Parameters.Add(new SqlParameter("@EntryType", SqlDbType.Int)).Value = EntryType;
                cmdHrms.Parameters.Add(new SqlParameter("@DocumentNo_", SqlDbType.VarChar)).Value = DocumentNo;
                cmdHrms.Parameters.Add(new SqlParameter("@LocationCode", SqlDbType.VarChar)).Value = LocationCode;

                cmdHrms.Parameters.Add(new SqlParameter("@StoreCode", SqlDbType.VarChar)).Value = StoreCode;
                cmdHrms.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Decimal)).Value = QuantityD;
                cmdHrms.Parameters.Add(new SqlParameter("@UnitAmount", SqlDbType.Decimal)).Value = UnitAmount;
                cmdHrms.Parameters.Add(new SqlParameter("@UnitCost", SqlDbType.Decimal)).Value = UnitCost;

                cmdHrms.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal)).Value = Amount;
                cmdHrms.Parameters.Add(new SqlParameter("@Qty_Calculated", SqlDbType.Decimal)).Value = Qty_Calculated;
                cmdHrms.Parameters.Add(new SqlParameter("@Qty_Phys_Inventory", SqlDbType.Decimal)).Value = Qty_Phys_Inventory;
                cmdHrms.Parameters.Add(new SqlParameter("@DocumentDate", SqlDbType.DateTime)).Value = DocumentDate.Date;

               // cmdHrms.Parameters.Add(new SqlParameter("@ExternalDocNo", SqlDbType.VarChar)).Value = ExternalDocNo;

                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }

        #endregion InsertInventoryToNav

        #region GetBatchName
        /// <summary>
        ///  GetBatchName
        /// </summary>
        /// <returns>Datatable Containing All Get BatchName</returns>
        public DataTable GetBatchName()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetBatchName", cnHrms);
                //cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetBatchName



        #region Get Write Off Report
        /// <summary>
        ///  Get Write Off Report
        /// </summary>
        /// <returns>Datatable Containing All Get PI Variance Report </returns>
        public DataTable GetWriteOffReport()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetWriteOffReport", cnHrms);

                cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
              
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetWriteOffReport


        #region ExportBarcodesForPdt
        /// <summary>
        ///  ExportBarcodesForPdt
        /// </summary>
        /// <returns>Datatable Containing All Get PI Variance Report </returns>
        public DataTable ExportBarcodesForPdt()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("ExportBarcodesForPdt", cnHrms);
                //cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;
                cmdPI.CommandTimeout = 0;
                
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion ExportBarcodesForPdt


        #region Get Negative Report
        /// <summary>
        /// Get Negative Report
        /// </summary>
        /// <returns>Datatable Containing All Get Negative Report</returns>
        public DataTable GetNegativeReport()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetNegativeReport", cnHrms);

                cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;

                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetNegativeReport


        #region ImportVarianceReportData
        /// <summary>
        ///ImportVarianceReportData
        /// </summary>
        /// <returns></returns>
        public bool ImportVarianceReportData()
        {
            bool Result = false;

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("InsertVarianceReport", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = LocationCode;
                cmdHrms.Parameters.Add(new SqlParameter("@Barcode", SqlDbType.VarChar)).Value = Barcode;
                cmdHrms.Parameters.Add(new SqlParameter("@ItemNo", SqlDbType.VarChar)).Value = ItemNo;

                cmdHrms.Parameters.Add(new SqlParameter("@CategoryCode", SqlDbType.VarChar)).Value = CategoryCode;
                cmdHrms.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar)).Value = Description;
                cmdHrms.Parameters.Add(new SqlParameter("@SystemQty", SqlDbType.Int)).Value = SystemQty;
                cmdHrms.Parameters.Add(new SqlParameter("@CountQty", SqlDbType.Int)).Value = CountQty;

                cmdHrms.Parameters.Add(new SqlParameter("@Variance", SqlDbType.Int)).Value = Variance;
                cmdHrms.Parameters.Add(new SqlParameter("@Remarks", SqlDbType.VarChar)).Value = Remarks;
                //cmdHrms.Parameters.Add(new SqlParameter("@Status", SqlDbType.Int)).Value = VarianceAdjustment;
                cmdHrms.Parameters.Add(new SqlParameter("@VarianceAdjustment", SqlDbType.Int)).Value = VarianceAdjustment;

                cmdHrms.Parameters.Add(new SqlParameter("@ManualCount", SqlDbType.Int)).Value = ManualCount;


                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }

        #endregion ImportVarianceReportData

        #region DeleteVarianceReport
        /// <summary>
        ///DeleteVarianceReport
        /// </summary>
        /// <returns></returns>
        public bool DeleteVarianceReport()
        {
            bool Result = false;

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("DeleteVarianceReport", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                
                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }

        #endregion DeleteVarianceReport

        #region ImportPOData
        /// <summary>
        ///Import PO Data
        /// </summary>
        /// <param name="dtSource"></param>
        public bool ImportPOData()
        {
            bool Result = false;
            try
            {
                DatabaseConnection dbPI = new DatabaseConnection();

                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
                //    ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

                string dbCntStr = dbPI.dbCntStr;

                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

                bcp.DestinationTableName = "POData";

                bcp.ColumnMappings.Add("DocNo", "DocNo");
                bcp.ColumnMappings.Add("PACKBARCODE", "Barcode");
                bcp.ColumnMappings.Add("SONUMBER", "SONumber");
                bcp.ColumnMappings.Add("LINECODE7", "Linecode");
                bcp.ColumnMappings.Add("PACKID", "PackId");

                bcp.ColumnMappings.Add("PACKTYPE", "PackType");
                bcp.ColumnMappings.Add("PAISSUEQTY", "Quantity");
                bcp.ColumnMappings.Add("FileName", "FileName");

                if (DtSource.Rows.Count > 0)
                {
                    bcp.WriteToServer(DtSource);
                    Result = true;
                    dbPI.CloseDbConnection();
                }
            }
            catch (SqlException ex)
            {
                ExceptionMessage = ex.Message;
            }

            return Result;

        }
        #endregion ImportPOData


        #region ImportLabelData
        /// <summary>
        ///ImportLabelData
        /// </summary>
        /// <param name="dtSource"></param>
        public bool ImportLabelData()
        {
            bool Result = false;
            try
            {
                DatabaseConnection dbPI = new DatabaseConnection();

                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
                //    ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

                string dbCntStr = dbPI.dbCntStr;

                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

                bcp.DestinationTableName = "ItemBarcodePrint";
                bcp.ColumnMappings.Add("Barcode", "Barcode");
                bcp.ColumnMappings.Add("Quantity", "Quantity");
                bcp.ColumnMappings.Add("FileName", "FileName");
                bcp.ColumnMappings.Add("DocNo", "DocNo");

                if (DtSource.Rows.Count > 0)
                {
                    bcp.WriteToServer(DtSource);
                    Result = true;
                    dbPI.CloseDbConnection();
                }
            }
            catch (SqlException ex)
            {
                ExceptionMessage = ex.Message;
            }

            return Result;

        }
        #endregion ImportLabelData

        #region GetPOReport
        /// <summary>
        ///  GetPOReport
        /// </summary>
        /// <returns>Datatable Containing All GetPOReport</returns>
        public DataTable GetPOReport()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetPOVarianceReport", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetPOReport

        #region Update Item Barcode Print
        /// <summary>
        ///  Update Item Barcode Print
        /// </summary>
        /// <returns></returns>
        public bool UpdateItemBarcodePrint()
        {
            bool Result = false;

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("UpdateItemBarcodePrint", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
               
                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }

        #endregion Update Item Barcode Print

        #region GetTransferFile
        /// <summary>
        ///  GetTransferFile
        /// </summary>
        /// <returns>Datatable Containing All GetTransferFile</returns>
        public DataTable GetTransferFile()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetTranferFile", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetTransferFile

        #region ImportTransferData
        /// <summary>
        ///ImportTransferData
        /// </summary>
        /// <param name="dtSource"></param>
        public bool ImportTransferData()
        {
            bool Result = false;
            try
            {
                DatabaseConnection dbPI = new DatabaseConnection();

                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
                //    ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

                string dbCntStr = dbPI.dbCntStr;

                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

                bcp.DestinationTableName = "POData";

                bcp.ColumnMappings.Add("DocNo", "DocNo");
                bcp.ColumnMappings.Add("Barcode", "Barcode");
                //bcp.ColumnMappings.Add("Description", "Description");
                //bcp.ColumnMappings.Add("Size", "Size");

                //bcp.ColumnMappings.Add("Color", "Color");
                bcp.ColumnMappings.Add("Quantity", "Quantity");
                bcp.ColumnMappings.Add("FileName", "FileName");

                if (DtSource.Rows.Count > 0)
                {
                    bcp.WriteToServer(DtSource);
                    Result = true;
                    dbPI.CloseDbConnection();
                }
            }
            catch (SqlException ex)
            {
                ExceptionMessage = ex.Message;
            }

            return Result;

        }
        #endregion ImportTransferData


        #region GetTranferFileForChecking
        /// <summary>
        ///  GetTranferFileForChecking
        /// </summary>
        /// <returns>Datatable Containing All GetTranferFileForChecking</returns>
        public DataTable GetTranferFileForChecking()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetTranferFileForChecking", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetTranferFileForChecking

        #region GetBatchNameById
        /// <summary>
        ///  GetBatchNameById
        /// </summary>
        /// <returns>Datatable Containing All GetBatchNameById</returns>
        public DataTable GetBatchNameById()
        {
            DataTable dtPI = new DataTable();

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;

                SqlCommand cmdPI = new SqlCommand("GetBatchNameById", cnHrms);
                cmdPI.Parameters.Add(new SqlParameter("@Batch", SqlDbType.VarChar)).Value = DocNo;
                cmdPI.CommandType = CommandType.StoredProcedure;

                cmdPI.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdPI);

                try
                {
                    daStock.Fill(dtPI);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return dtPI;
        }
        #endregion GetBatchNameById


        #region Insert Item Barcode Print
        /// <summary>
        ///  Insert Item Barcode Print
        /// </summary>
        /// <returns></returns>
        public bool InsertItemBarcodePrint()
        {
            bool Result = false;

            DatabaseConnection dbPI = new DatabaseConnection();

            if (dbPI.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbPI.CnDbConnection;


                SqlCommand cmdHrms = new SqlCommand("InsertItemBarcodePrint", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@DocNo", SqlDbType.VarChar)).Value = DocNo;

                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbPI.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbPI.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }

        #endregion Insert Item Barcode Print


        #endregion Methods
    }
}
