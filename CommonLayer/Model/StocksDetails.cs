using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortFolio_Management.Models
{
    public class StocksDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage ="Stoke Name Is Required")]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Stoke Name")]
        public string StockName { get; set; }

        [Required(ErrorMessage = "Stoke Price Is Required")]
        [Display(Name = "Stoke Price")]
        public double StockPrice { get; set; }

        [Required(ErrorMessage = "Broker Name Is Required")]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Broker Name")]
        public string BrokerName { get; set; }

        [Required(ErrorMessage = "Remark Is Required")]
        [Column(TypeName = "varchar(512)")]
        [Display(Name = "User Name")]
        public string Remark { get; set; }
    }

    public class AddStocksRequest
    {
        [Required(ErrorMessage = "Stoke Name Is Required")]
        [Display(Name = "Stoke Name")]
        public string StockName { get; set; }

        [Required(ErrorMessage = "Stoke Price Is Required")]
        [Display(Name = "Stoke Price")]
        public double StockPrice { get; set; }

        [Required(ErrorMessage = "Broker Name Is Required")]
        [Display(Name = "Broker Name")]
        public string BrokerName { get; set; }

        [Required(ErrorMessage = "Remark Is Required")]
        public string Remark { get; set; }
    }

    public class AddStocksResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    public class GetAllStocksRequest
    {
        [Required]
        public int PageNumber { get; set; } = 1;
        [Required]
        public int NumberOfRecordPerPage { get; set; } = 10;
    }

    public class GetStocksResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int CurrentPage { get; set; }
        public double TotalRecords { get; set; }
        public int TotalPage { get; set; }
        public List<StocksDetails> data { get; set; }
    }
}
