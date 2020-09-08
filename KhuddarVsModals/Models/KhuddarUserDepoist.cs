using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
  public class KhuddarUserDepoist : Base
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Wallet")]
        public int? WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Particluer { get; set; }
        public string payemtnMethode { get; set; }
        public KhuddarUserWallet Wallet { get; set; }


    }
}
