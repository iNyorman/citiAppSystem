using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace citiAppSystem
{
    class Global
    {

       

        public class process
        {
            public static string updateLCP { get; set; }
            public static string branchCode { get; set; }
            public static string  branchID { get; set; }

            public static string CustomerclickFrom { get; set; }
            public static string ProductViewOpenFrom { get; set; }
            public static string SearchCustomerFromDR { get; set; }
            public static string addCustomerToReceipt { get; set; }
            public static string selectProdFromDR { get; set; }
            public static string drDetailsIDfromProductsView { get; set; }
            public static string accountNo { get; set; }
            public static string productAvailabilty { get; set; }
            public static string accountType { get; set; }

            public static string stepsFROMcustomer { get; set; }
            public static string addOrUpdateBranch { get; set; }
            public static string addOrUpdateUser { get; set; }
            public static string searchBranchNoFromAddUser { get; set; }

            public static string role { get; set; }
            public static string addOrUpdateSupplier { get; set; }

            public static string searchSupplierFromPO { get; set; }
            public static string poFromSupplier { get; set; }

            public static string addPRODorderedORfree { get; set; }
            public static string  dateForCollections { get; set; }
        }

        public class drReceipt
        {
            public static string acountNo     { get; set; }
            public static string collectionNo { get; set; }
            public static string customerID   { get; set; }


        }

        public class customerDetails
        {
            public static string id_Number { get; set; }
            public static string l_Name    { get; set; }
            public static string m_Name    { get; set; }
            public static string f_Name    { get; set; }
            public static string employer  { get; set; }
            public static string contact   { get; set; }
            public static string co_Maker  { get; set; }
            public static string address { get; set; }
            public static string co_maker_address { get; set; }
            public static string civilStatus { get; set; }
            public static string employerAddress { get; set; }

        }

        public class productsDetails
        {
            public static string stockNo    { get; set; }
            public static string serialNo   { get; set; }
            public static string brand      { get; set; }
            public static string model      { get; set; }
            
        }

        public class branch
        {
            public static string branchID { get; set; }
            public static string branchName { get; set; }
            public static string branchCode { get; set; }
            public static string address { get; set; }
            public static string contactNo { get; set; }
        }

        public class user
        {
            public static string userID { get; set; }
            public static string Fname { get; set; }
            public static string Lname { get; set; }
            public static string Role { get; set; }
            public static string Username { get; set; }
            public static string Password { get; set; }
            public static string branchNo { get; set; }
        }

        public class supplier
        {
            public static string supplierID { get; set; }
            public static string supplierName { get; set; }
            public static string supplierAddress { get; set; }
            public static string supplierContact { get; set; }
        }
        public class poDetails
        {
            public static string poDetailsID { get; set; }
            public static string model { get; set; }
            public static string orderedQTY { get; set; }
            public static string freeQTY { get; set; }
            public static string  brand { get; set; }
            public static string purchaseOrderID { get; set; }
            public static string  totalQty { get; set; }
            public static string remainingQty { get; set; }
            public static string holderQty { get; set; }
            public static string supplier { get; set; }
            public static string price { get; set; }

        }


    }
}
