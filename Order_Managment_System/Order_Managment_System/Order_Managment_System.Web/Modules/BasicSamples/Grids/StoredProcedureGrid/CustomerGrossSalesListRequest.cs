namespace Order_Managment_System.BasicSamples
{
    using Serenity.Services;
    using System;

    public class CustomerGrossSalesListRequest : ListRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}