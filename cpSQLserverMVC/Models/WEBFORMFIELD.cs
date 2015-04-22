using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileHelpers;


namespace cpSQLserverMVC.Models
{
    [IgnoreFirst(1)]
    [IgnoreEmptyLines()]
    [DelimitedRecord(",")]
    public sealed class WEBFORMFIELD
    {

        private System.String mPO_Number;

        public System.String PO_Number
        {
            get { return mPO_Number; }
            set { mPO_Number = value; }
        }


        [FieldOptional()]
        private System.String mRelease_Number;

        public System.String Release_Number
        {
            get { return mRelease_Number; }
            set { mRelease_Number = value; }
        }


        [FieldOptional()]
        private System.String mPO_Date;

        public System.String PO_Date
        {
            get { return mPO_Date; }
            set { mPO_Date = value; }
        }


        [FieldOptional()]
        private System.String mDept;

        public System.String Dept
        {
            get { return mDept; }
            set { mDept = value; }
        }


        [FieldOptional()]
        private System.String mRetailers_PO;

        public System.String Retailers_PO
        {
            get { return mRetailers_PO; }
            set { mRetailers_PO = value; }
        }


        [FieldOptional()]
        private System.String mRequested_Ship_Delivery_Date;

        public System.String Requested_Ship_Delivery_Date
        {
            get { return mRequested_Ship_Delivery_Date; }
            set { mRequested_Ship_Delivery_Date = value; }
        }


        [FieldOptional()]
        private System.String mShip_No_Later;

        public System.String Ship_No_Later
        {
            get { return mShip_No_Later; }
            set { mShip_No_Later = value; }
        }


        [FieldOptional()]
        private System.String mCancel_Date;

        public System.String Cancel_Date
        {
            get { return mCancel_Date; }
            set { mCancel_Date = value; }
        }


        [FieldOptional()]
        private System.String mCarrier;

        public System.String Carrier
        {
            get { return mCarrier; }
            set { mCarrier = value; }
        }


        [FieldOptional()]
        private System.String mCarrier_Details;

        public System.String Carrier_Details
        {
            get { return mCarrier_Details; }
            set { mCarrier_Details = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_Location;

        public System.String Ship_To_Location
        {
            get { return mShip_To_Location; }
            set { mShip_To_Location = value; }
        }


        [FieldOptional()]
        private System.String mPO_Line;

        public System.String PO_Line
        {
            get { return mPO_Line; }
            set { mPO_Line = value; }
        }


        [FieldOptional()]
        private System.String mQty_Ordered;

        public System.String Qty_Ordered
        {
            get { return mQty_Ordered; }
            set { mQty_Ordered = value; }
        }


        [FieldOptional()]
        private System.String mUnit_of_Measure;

        public System.String Unit_of_Measure
        {
            get { return mUnit_of_Measure; }
            set { mUnit_of_Measure = value; }
        }


        [FieldOptional()]
        private System.String mUnit_Price;

        public System.String Unit_Price
        {
            get { return mUnit_Price; }
            set { mUnit_Price = value; }
        }


        [FieldOptional()]
        private System.String mBuyers_Catalog_or_Stock_Keeping;

        public System.String Buyers_Catalog_or_Stock_Keeping
        {
            get { return mBuyers_Catalog_or_Stock_Keeping; }
            set { mBuyers_Catalog_or_Stock_Keeping = value; }
        }


        [FieldOptional()]
        private System.String mUPC_EAN;

        public System.String UPC_EAN
        {
            get { return mUPC_EAN; }
            set { mUPC_EAN = value; }
        }


        [FieldOptional()]
        private System.String mVendor_Style;

        public System.String Vendor_Style
        {
            get { return mVendor_Style; }
            set { mVendor_Style = value; }
        }


        [FieldOptional()]
        private System.String mRetail_Price;

        public System.String Retail_Price
        {
            get { return mRetail_Price; }
            set { mRetail_Price = value; }
        }


        [FieldOptional()]
        private System.String mProduct_Item_Description;

        public System.String Product_Item_Description
        {
            get { return mProduct_Item_Description; }
            set { mProduct_Item_Description = value; }
        }


        [FieldOptional()]
        private System.String mColor;

        public System.String Color
        {
            get { return mColor; }
            set { mColor = value; }
        }


        [FieldOptional()]
        private System.String mSize;

        public System.String Size
        {
            get { return mSize; }
            set { mSize = value; }
        }


        [FieldOptional()]
        private System.String mPack_Size;

        public System.String Pack_Size
        {
            get { return mPack_Size; }
            set { mPack_Size = value; }
        }


        [FieldOptional()]
        private System.String mPack_Size_UOM;

        public System.String Pack_Size_UOM
        {
            get { return mPack_Size_UOM; }
            set { mPack_Size_UOM = value; }
        }


        [FieldOptional()]
        private System.String mNumber_of_Inner_Packs;

        public System.String Number_of_Inner_Packs
        {
            get { return mNumber_of_Inner_Packs; }
            set { mNumber_of_Inner_Packs = value; }
        }


        [FieldOptional()]
        private System.String mNumber_of_Pcs_per_Inner_Pack;

        public System.String Number_of_Pcs_per_Inner_Pack
        {
            get { return mNumber_of_Pcs_per_Inner_Pack; }
            set { mNumber_of_Pcs_per_Inner_Pack = value; }
        }


        [FieldOptional()]
        private System.String mStore;

        public System.String Store
        {
            get { return mStore; }
            set { mStore = value; }
        }


        [FieldOptional()]
        private System.String mQty_per_Store;

        public System.String Qty_per_Store
        {
            get { return mQty_per_Store; }
            set { mQty_per_Store = value; }
        }


        [FieldOptional()]
        private System.String mRecord_Type;

        public System.String Record_Type
        {
            get { return mRecord_Type; }
            set { mRecord_Type = value; }
        }


        [FieldOptional()]
        private System.String mPO_purpose;

        public System.String PO_purpose
        {
            get { return mPO_purpose; }
            set { mPO_purpose = value; }
        }


        [FieldOptional()]
        private System.String mPO_Type;

        public System.String PO_Type
        {
            get { return mPO_Type; }
            set { mPO_Type = value; }
        }


        [FieldOptional()]
        private System.String mContract_Number;

        public System.String Contract_Number
        {
            get { return mContract_Number; }
            set { mContract_Number = value; }
        }


        [FieldOptional()]
        private System.String mCurrency;

        public System.String Currency
        {
            get { return mCurrency; }
            set { mCurrency = value; }
        }


        [FieldOptional()]
        private System.String mShip_Status;

        public System.String Ship_Status
        {
            get { return mShip_Status; }
            set { mShip_Status = value; }
        }


        [FieldOptional()]
        private System.String mLetter_of_Credit;

        public System.String Letter_of_Credit
        {
            get { return mLetter_of_Credit; }
            set { mLetter_of_Credit = value; }
        }


        [FieldOptional()]
        private System.String mVendor;

        public System.String Vendor
        {
            get { return mVendor; }
            set { mVendor = value; }
        }


        [FieldOptional()]
        private System.String mDivision;

        public System.String Division
        {
            get { return mDivision; }
            set { mDivision = value; }
        }


        [FieldOptional()]
        private System.String mCust_Acct;

        public System.String Cust_Acct
        {
            get { return mCust_Acct; }
            set { mCust_Acct = value; }
        }


        [FieldOptional()]
        private System.String mCustomer_Order;

        public System.String Customer_Order
        {
            get { return mCustomer_Order; }
            set { mCustomer_Order = value; }
        }


        [FieldOptional()]
        private System.String mPromo;

        public System.String Promo
        {
            get { return mPromo; }
            set { mPromo = value; }
        }


        [FieldOptional()]
        private System.String mTicket_Description;

        public System.String Ticket_Description
        {
            get { return mTicket_Description; }
            set { mTicket_Description = value; }
        }


        [FieldOptional()]
        private System.String mOther_Info_s;

        public System.String Other_Info_s
        {
            get { return mOther_Info_s; }
            set { mOther_Info_s = value; }
        }


        [FieldOptional()]
        private System.String mFrt_Terms;

        public System.String Frt_Terms
        {
            get { return mFrt_Terms; }
            set { mFrt_Terms = value; }
        }


        [FieldOptional()]
        private System.String mCarrier_Service_Level;

        public System.String Carrier_Service_Level
        {
            get { return mCarrier_Service_Level; }
            set { mCarrier_Service_Level = value; }
        }


        [FieldOptional()]
        private System.String mPayment_Terms;

        public System.String Payment_Terms
        {
            get { return mPayment_Terms; }
            set { mPayment_Terms = value; }
        }


        [FieldOptional()]
        private System.String mPayment_Terms_Disc_Due_Date;

        public System.String Payment_Terms_Disc_Due_Date
        {
            get { return mPayment_Terms_Disc_Due_Date; }
            set { mPayment_Terms_Disc_Due_Date = value; }
        }


        [FieldOptional()]
        private System.String mPayment_Terms_Disc_Days_Due;

        public System.String Payment_Terms_Disc_Days_Due
        {
            get { return mPayment_Terms_Disc_Days_Due; }
            set { mPayment_Terms_Disc_Days_Due = value; }
        }


        [FieldOptional()]
        private System.String mPayment_Terms_Net_Due_Date;

        public System.String Payment_Terms_Net_Due_Date
        {
            get { return mPayment_Terms_Net_Due_Date; }
            set { mPayment_Terms_Net_Due_Date = value; }
        }


        [FieldOptional()]
        private System.String mPayment_Terms_Net_Days;

        public System.String Payment_Terms_Net_Days
        {
            get { return mPayment_Terms_Net_Days; }
            set { mPayment_Terms_Net_Days = value; }
        }


        [FieldOptional()]
        private System.String mPayment_Terms_Disc_Amt;

        public System.String Payment_Terms_Disc_Amt
        {
            get { return mPayment_Terms_Disc_Amt; }
            set { mPayment_Terms_Disc_Amt = value; }
        }


        [FieldOptional()]
        private System.String mPayment_Terms_Desc;

        public System.String Payment_Terms_Desc
        {
            get { return mPayment_Terms_Desc; }
            set { mPayment_Terms_Desc = value; }
        }


        [FieldOptional()]
        private System.String mContact_Phone;

        public System.String Contact_Phone
        {
            get { return mContact_Phone; }
            set { mContact_Phone = value; }
        }


        [FieldOptional()]
        private System.String mContact_Fax;

        public System.String Contact_Fax
        {
            get { return mContact_Fax; }
            set { mContact_Fax = value; }
        }


        [FieldOptional()]
        private System.String mContact_Email;

        public System.String Contact_Email
        {
            get { return mContact_Email; }
            set { mContact_Email = value; }
        }


        [FieldOptional()]
        private System.String mAllow_Charge_Type;

        public System.String Allow_Charge_Type
        {
            get { return mAllow_Charge_Type; }
            set { mAllow_Charge_Type = value; }
        }


        [FieldOptional()]
        private System.String mAllow_Charge_Service;

        public System.String Allow_Charge_Service
        {
            get { return mAllow_Charge_Service; }
            set { mAllow_Charge_Service = value; }
        }


        [FieldOptional()]
        private System.String mAllow_Charge_Amt;

        public System.String Allow_Charge_Amt
        {
            get { return mAllow_Charge_Amt; }
            set { mAllow_Charge_Amt = value; }
        }


        [FieldOptional()]
        private System.String mAllow_Charge;

        public System.String Allow_Charge
        {
            get { return mAllow_Charge; }
            set { mAllow_Charge = value; }
        }


        [FieldOptional()]
        private System.String mAllow_Charge_Rate;

        public System.String Allow_Charge_Rate
        {
            get { return mAllow_Charge_Rate; }
            set { mAllow_Charge_Rate = value; }
        }


        [FieldOptional()]
        private System.String mAllow_Charge_Qty;

        public System.String Allow_Charge_Qty
        {
            get { return mAllow_Charge_Qty; }
            set { mAllow_Charge_Qty = value; }
        }


        [FieldOptional()]
        private System.String mAllow_Charge_Desc;

        public System.String Allow_Charge_Desc
        {
            get { return mAllow_Charge_Desc; }
            set { mAllow_Charge_Desc = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_Name;

        public System.String Ship_To_Name
        {
            get { return mShip_To_Name; }
            set { mShip_To_Name = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_Address_1;

        public System.String Ship_To_Address_1
        {
            get { return mShip_To_Address_1; }
            set { mShip_To_Address_1 = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_Address_2;

        public System.String Ship_To_Address_2
        {
            get { return mShip_To_Address_2; }
            set { mShip_To_Address_2 = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_City;

        public System.String Ship_To_City
        {
            get { return mShip_To_City; }
            set { mShip_To_City = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_State;

        public System.String Ship_To_State
        {
            get { return mShip_To_State; }
            set { mShip_To_State = value; }
        }


        [FieldOptional()]
        private System.String mShip_to_Zip;

        public System.String Ship_to_Zip
        {
            get { return mShip_to_Zip; }
            set { mShip_to_Zip = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_Country;

        public System.String Ship_To_Country
        {
            get { return mShip_To_Country; }
            set { mShip_To_Country = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_Contact;

        public System.String Ship_To_Contact
        {
            get { return mShip_To_Contact; }
            set { mShip_To_Contact = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_Name;

        public System.String Bill_To_Name
        {
            get { return mBill_To_Name; }
            set { mBill_To_Name = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_Address_1;

        public System.String Bill_To_Address_1
        {
            get { return mBill_To_Address_1; }
            set { mBill_To_Address_1 = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_Address_2;

        public System.String Bill_To_Address_2
        {
            get { return mBill_To_Address_2; }
            set { mBill_To_Address_2 = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_City;

        public System.String Bill_To_City
        {
            get { return mBill_To_City; }
            set { mBill_To_City = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_State;

        public System.String Bill_To_State
        {
            get { return mBill_To_State; }
            set { mBill_To_State = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_Zip;

        public System.String Bill_To_Zip
        {
            get { return mBill_To_Zip; }
            set { mBill_To_Zip = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_Country;

        public System.String Bill_To_Country
        {
            get { return mBill_To_Country; }
            set { mBill_To_Country = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_Contact;

        public System.String Bill_To_Contact
        {
            get { return mBill_To_Contact; }
            set { mBill_To_Contact = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_Name;

        public System.String Buying_Party_Name
        {
            get { return mBuying_Party_Name; }
            set { mBuying_Party_Name = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_Location;

        public System.String Buying_Party_Location
        {
            get { return mBuying_Party_Location; }
            set { mBuying_Party_Location = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_Address_1;

        public System.String Buying_Party_Address_1
        {
            get { return mBuying_Party_Address_1; }
            set { mBuying_Party_Address_1 = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_Address_2;

        public System.String Buying_Party_Address_2
        {
            get { return mBuying_Party_Address_2; }
            set { mBuying_Party_Address_2 = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_City;

        public System.String Buying_Party_City
        {
            get { return mBuying_Party_City; }
            set { mBuying_Party_City = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_State;

        public System.String Buying_Party_State
        {
            get { return mBuying_Party_State; }
            set { mBuying_Party_State = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_Zip;

        public System.String Buying_Party_Zip
        {
            get { return mBuying_Party_Zip; }
            set { mBuying_Party_Zip = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_Country;

        public System.String Buying_Party_Country
        {
            get { return mBuying_Party_Country; }
            set { mBuying_Party_Country = value; }
        }


        [FieldOptional()]
        private System.String mBuying_Party_Contact;

        public System.String Buying_Party_Contact
        {
            get { return mBuying_Party_Contact; }
            set { mBuying_Party_Contact = value; }
        }


        [FieldOptional()]
        private System.String mUltimate_Location;

        public System.String Ultimate_Location
        {
            get { return mUltimate_Location; }
            set { mUltimate_Location = value; }
        }


        [FieldOptional()]
        private System.String mNotes_Comments;

        public System.String Notes_Comments
        {
            get { return mNotes_Comments; }
            set { mNotes_Comments = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_Additional_Name;

        public System.String Ship_To_Additional_Name
        {
            get { return mShip_To_Additional_Name; }
            set { mShip_To_Additional_Name = value; }
        }


        [FieldOptional()]
        private System.String mShip_To_Additional_Name_2;

        public System.String Ship_To_Additional_Name_2
        {
            get { return mShip_To_Additional_Name_2; }
            set { mShip_To_Additional_Name_2 = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_Additional_Name;

        public System.String Bill_To_Additional_Name
        {
            get { return mBill_To_Additional_Name; }
            set { mBill_To_Additional_Name = value; }
        }


        [FieldOptional()]
        private System.String mBill_To_Additional_Name_2;

        public System.String Bill_To_Additional_Name_2
        {
            get { return mBill_To_Additional_Name_2; }
            set { mBill_To_Additional_Name_2 = value; }
        }


        [FieldOptional()]
        private System.String mBuyer_Additional_Name;

        public System.String Buyer_Additional_Name
        {
            get { return mBuyer_Additional_Name; }
            set { mBuyer_Additional_Name = value; }
        }


        [FieldOptional()]
        private System.String mBuyer_Additional_Name_2;

        public System.String Buyer_Additional_Name_2
        {
            get { return mBuyer_Additional_Name_2; }
            set { mBuyer_Additional_Name_2 = value; }
        }


        [FieldOptional()]
        private System.String mGTIN;

        public System.String GTIN
        {
            get { return mGTIN; }
            set { mGTIN = value; }
        }


        [FieldOptional()]
        private System.String mPO_Total_Amount;

        public System.String PO_Total_Amount
        {
            get { return mPO_Total_Amount; }
            set { mPO_Total_Amount = value; }
        }

        [FieldOptional()]
        private System.String mEmptyField;

        public System.String EmptyField
        {
            get { return mEmptyField; }
            set { mEmptyField = value; }
        }



    }
}