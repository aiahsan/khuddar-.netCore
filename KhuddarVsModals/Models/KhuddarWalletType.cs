using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
    public class KhuddarWalletType : Base
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "money")]
        public decimal WalletWithdrawMinimumAmmount { get; set; }
        public int MinimumWithDrawDate { get; set; }
    }
}
