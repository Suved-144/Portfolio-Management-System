using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Model
{
    public class UpdateStoke
    {
        [Required]
        public int ID { get; set; }

        public string StockName { get; set; }

        public double StockPrice { get; set; }

        public string BrokerName { get; set; }

        public string Remark { get; set; }
    }

    public class UpdateStokeResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
