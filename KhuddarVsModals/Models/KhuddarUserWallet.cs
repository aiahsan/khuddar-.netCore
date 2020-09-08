using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
  public class KhuddarUserWallet : Base
    {
        [Key]
        public int Id { get; set; }
        public decimal ammount { get; set; }
        public DateTime lastWithdraw { get; set; }
        [ForeignKey("WalletType")]
        public int? walletId { get; set; }
        public KhuddarWalletType WalletType { get; set; }
        public ICollection<KhuddarUserGrant> GrantedMoney { get; set; }
        public ICollection<KhuddarUserDepoist> DepositMoney { get; set; }

    }
}
