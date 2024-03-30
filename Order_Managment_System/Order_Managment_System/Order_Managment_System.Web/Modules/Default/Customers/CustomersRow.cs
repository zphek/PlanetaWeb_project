
namespace Order_Managment_System.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Customers]")]
    [DisplayName("Customers"), InstanceName("Customers")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class CustomersRow : Row, IIdRow, INameRow
    {
        [DisplayName("Customer Id"), Column("customer_id"), Identity]
        public Int32? CustomerId
        {
            get { return Fields.CustomerId[this]; }
            set { Fields.CustomerId[this] = value; }
        }

        [DisplayName("First Name"), Column("first_name"), Size(255), NotNull, QuickSearch]
        public String FirstName
        {
            get { return Fields.FirstName[this]; }
            set { Fields.FirstName[this] = value; }
        }

        [DisplayName("Last Name"), Column("last_name"), Size(255), NotNull]
        public String LastName
        {
            get { return Fields.LastName[this]; }
            set { Fields.LastName[this] = value; }
        }

        [DisplayName("Email"), Column("email"), Size(255), NotNull]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Phone Number"), Column("phone_number"), Size(255), NotNull]
        public String PhoneNumber
        {
            get { return Fields.PhoneNumber[this]; }
            set { Fields.PhoneNumber[this] = value; }
        }

        [DisplayName("Address"), Column("address"), Size(255), NotNull]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("City"), Column("city"), Size(255), NotNull]
        public String City
        {
            get { return Fields.City[this]; }
            set { Fields.City[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CustomerId; }
        }

        StringField INameRow.NameField
        {
            get {
                return Fields.Email; 
            }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CustomersRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CustomerId;
            public StringField FirstName;
            public StringField LastName;
            public StringField Email;
            public StringField PhoneNumber;
            public StringField Address;
            public StringField City;
        }
    }
}
