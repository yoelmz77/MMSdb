using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMSdb.dbo.Tables
{
    [Table("tbl_HouseHold")]
    public class tbl_HouseHold
    {
        [Key]
        public long hou_ID { get; set; }
        public long dmg_ID { get; set; }
        public int? hou_Type { get; set; }
        public String? hou_AssocName { get; set; }
        public String? hou_AssocAddress { get; set; }
        public String? hou_AssocCity { get; set; }
        public String? hou_AssocState { get; set; }
        public String? hou_AssocZip { get; set; }
        public String? hou_AssocPhone { get; set; }
        public Double? hou_AssocFees { get; set; }
        public String? hou_InsName { get; set; }
        public String? hou_InsAddress { get; set; }
        public String? hou_InsCity { get; set; }
        public String? hou_InsState { get; set; }
        public String? hou_InsZip { get; set; }
        public String? hou_Insphone { get; set; }
        public Double? hou_InsFees { get; set; }
        public String? hou_LandLordName { get; set; }
        public String? hou_LandLordAddress { get; set; }
        public String? hou_LandLordCity { get; set; }
        public String? hou_LandLordState { get; set; }
        public String? hou_LandLordZip { get; set; }
        public String? hou_LandLordPhone { get; set; }
        public String? hou_MtgBankName { get; set; }
        public String? hou_MtgAddress { get; set; }
        public String? hou_MtgCity { get; set; }
        public String? hou_MtgState { get; set; }
        public String? hou_MtgZip { get; set; }
        public String? hou_MtgPhone { get; set; }
        public Double? hou_MtgPropertyTaxes { get; set; }
        public Double? hou_ExpensesElectricity { get; set; }
        public Double? hou_ExpensesWater { get; set; }
        public Double? hou_ExpensesGarbage { get; set; }
        public Double? hou_ExpensesFoodStamps { get; set; }
        public Double? hou_ExpensesChildSupp { get; set; }
        public int? hou_ExpensesChildSuppType { get; set; }
        public Boolean? hou_Childrenunder18 { get; set; }
        public Boolean? hou_Childrenunder22 { get; set; }
        public String? hou_Notes { get; set; }
        public Double? hou_ExpensesRent { get; set; }
        public Boolean? deleted { get; set; }
    }
}
