//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NO2A_H08_SuFaturasi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fatura
    {
        public int ID { get; set; }
        public int MusteriID { get; set; }
        public System.DateTime Tarih { get; set; }
        public System.DateTime SonOdemeTarihi { get; set; }
        public int IlkEndeks { get; set; }
        public int SonEndeks { get; set; }
        public decimal Tutar { get; set; }
    }
}
