﻿using DevExpress.Xpo;
using System;

namespace WebApiClient
{
    public class Order :XPObject {
        public Order(Session session) : base(session) { }
        private string fProductName;
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue(nameof(ProductName), ref fProductName, value); }
        }
        private DateTime fOrderDate;
        public DateTime OrderDate {
            get { return fOrderDate; }
            set { SetPropertyValue(nameof(OrderDate), ref fOrderDate, value); }
        }
        private decimal fFreight;
        public decimal Freight {
            get { return fFreight; }
            set { SetPropertyValue(nameof(Freight), ref fFreight, value); }
        }
        private Customer fCustomer;
        [Association("CustomerOrders")]
        public Customer Customer {
            get { return fCustomer; }
            set { SetPropertyValue(nameof(Customer), ref fCustomer, value); }
        }
        public override void AfterConstruction() {
            OrderDate = DateTime.Today;
        }
    }
}