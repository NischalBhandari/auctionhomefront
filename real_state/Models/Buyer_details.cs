using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace real_state.Models
{
	public class Buyer_details
	{

		public int Id { get; set; }
		public string HOUSE_Id { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string STATE { get; set; }
		public int Zip_code { get; set; }
		public string Country { get; set; }
		[DataType(DataType.Currency)]
		public float Estimated_Value { get; set; }
		[DataType(DataType.Currency)]
		public string LastSale_Amount { get; set; }
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime LastSale_Date { get; set; }
		[DataType(DataType.Currency)]
		public float EstAuctionAmt { get; set; }
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime AuctionDate { get; set; }
		[Range(1, 100)]
		[Column(TypeName = "decimal(18, 2)")]
		[DataType(DataType.Currency)]
		public decimal AuctionToValue { get; set; }
		public int Lot { get; set; }
		public int SqFt { get; set; }
		public int Baths { get; set; }
		public int Beds { get; set; }
		public int Fireplaces { get; set; }
		public int Rooms { get; set; }
		public int Stories { get; set; }
		public string YearBuilt { get; set; }

	}
}
