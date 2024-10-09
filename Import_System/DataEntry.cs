using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Import_System
{
    public class DataEntry
    {
        public string ConNo { get; set; }
        public string Month { get; set; }
        public string DeliveryTerms { get; set; }
        public string PaymentTerms { get; set; }
        public int Advance { get; set; }
        public DateTime? ADate { get; set; }
        public int Balance { get; set; }
        public DateTime? BDate { get; set; }
        public string ExpName { get; set; }
        public string ImpLicenseNo { get; set; }
        public string Forwarder { get; set; }
        public string InsurancePolicyNo { get; set; }
        public string Item { get; set; }
        public int Qty { get; set; }
        public string ProformaNo { get; set; }
        public decimal InvoiceValue { get; set; }
        public string InvoiceNo { get; set; }
        public decimal UnitPrice { get; set; }
        public string Bank { get; set; }
        public bool IsApplication { get; set; }
        public bool IsPayment { get; set; }
        public DateTime? FreightDate { get; set; }
        public decimal FreightValue { get; set; }
        public DateTime? DeliveryOrderDate { get; set; }
        public decimal DeliveryOrderValue { get; set; }
        public decimal InsuranceValue { get; set; }
        public string TRCL_no { get; set; }
        public decimal TRCL_value { get; set; }
        public DateTime? TRCL_date { get; set; }
        public string SLSI_no { get; set; }
        public decimal SLSI_value { get; set; }
        public DateTime? SLSI_date { get; set; }
        public string SSEA_no { get; set; }
        public decimal SSEA_value { get; set; }
        public DateTime? SSEA_date { get; set; }
        public decimal ImpLicenseValue { get; set; }
        public DateTime? IMP_date { get; set; }
        public bool IsImp_license { get; set; }
        public bool IsInvoice { get; set; }
        public bool IsPacking { get; set; }
        public bool IsBL { get; set; }
        public bool IsOrigin { get; set; }
        public bool IsAssessment { get; set; }
        public bool IsCusdec { get; set; }
        public string LC_TT_no { get; set; }
        public string BL_no { get; set; }
        public string shipping_line { get; set; }
        public string vessel_flight { get; set; }
        public DateTime? est_load_date { get; set; }
        public DateTime? etd { get; set; }
        public string remark1 { get; set; }
        public DateTime? eta { get; set; }
        public bool IsFcl { get; set; }
        public bool IsLcl { get; set; }
        public string transport_mode { get; set; }
        public DateTime? doc_bank_date { get; set; }
        public DateTime? org_doc_hand_date { get; set; }
        public string remark2 { get; set; }
        public DateTime? cusdec_date { get; set; }
        public DateTime? con_destuff_date { get; set; }
        public DateTime? duty_date { get; set; }
        public DateTime? entry_pass_date { get; set; }
        public string remark3 { get; set; }
        public DateTime? fcl_load_date { get; set; }
        public DateTime? exam_date { get; set; }
        public DateTime? act_clear_date { get; set; }
        public DateTime? warehouse_release_date { get; set; }
        public string remark4 { get; set; }


    }
}