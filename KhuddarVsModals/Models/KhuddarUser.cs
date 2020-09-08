using KhuddarVsModals.Models.Shadi_Mubarak;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KhuddarVsModals.Models
{
    public class KhuddarUser : Base
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string PhoneNumber { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        
        public string Address { get; set; }
        [ForeignKey("Roles")]
        public int? RoleId { get; set; }
      
        public KhuddarRole Roles { get; set; }

        public ICollection<KhuddarQuizCompleted> QuizCompletedRecords { get; set; }
        public ICollection<KhuddarCofinRequest> CoffinRequest{ get; set; }
        public ICollection<KhuddarUserLogRecord> LogReport{ get; set; }



        //Shadhi Mubarak requests by Users
        public KhuddarAlNikkah AlNikkahs { get; set; }
        public KhuddarBarat Barat { get; set; }
        public KhuddarFoodandFood FoodandFoods { get; set; }
        public KhuddarFurniture Furnitures { get; set; }
        public KhuddarGroomSalon GroomSalons { get; set; }
        public KhuddarRentAHappyCar RentAHappyCars { get; set; }
        public KhuddarMarrigeBanquet MarrigeBanquets { get; set; }


    }
}
