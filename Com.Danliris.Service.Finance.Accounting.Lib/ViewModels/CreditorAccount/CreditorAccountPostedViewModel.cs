﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.CreditorAccount
{
    public class CreditorAccountPostedViewModel : IValidatableObject
    {
        public int CreditorAccountId { get; set; }

        public string SupplierCode { get; set; }

        public string SupplierName { get; set; }

        public string Code { get; set; }
        
        public string InvoiceNo { get; set; }

        public DateTimeOffset Date { get; set; }
        public decimal MemoDPP { get; set; }
        public decimal MemoDPPCurrency { get; set; }
        public decimal MemoMutation { get; set; }
        public decimal MemoPPN { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(string.IsNullOrEmpty(Code))
                yield return new ValidationResult("Code harus diisi", new List<string> { "Code" });
        }
    }
}
