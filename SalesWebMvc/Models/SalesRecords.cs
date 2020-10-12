﻿using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecords
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecords()
        {
        }

        public SalesRecords(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = Status;
            Seller = seller;
        }
    }
}
