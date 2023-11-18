﻿using AutopartsEntity.Catalog.ViewModels.CurrencyViewModel;

namespace AutopartsEntity.Catalog.ViewModels.CountryViewModel
{
    public class CountryEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int NumericCountryCode { get; set; }
        public string ISOAlpha2 { get; set; } = null!;
        public string ISOAlpha3 { get; set; } = null!;
        public string CountryNameCZ { get; set; } = null!;
        public string CountryNameENG { get; set; } = null!;
        public bool IsActive { get; set; } = false;

        public int CurrencyId { get; set; }
        public CurrencyEditVM Currency { get; set; } = null!;
    }
}