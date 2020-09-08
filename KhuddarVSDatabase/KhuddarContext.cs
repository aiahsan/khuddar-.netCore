using KhuddarVsModals.Models;
using KhuddarVsModals.Models.Shadi_Mubarak;
using KhuddarVsModals.Models.ShadiMubarakServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KhuddarVSDatabase
{
   public class KhuddarContext:DbContext
    {
        public KhuddarContext(DbContextOptions<KhuddarContext> options): base(options)
        {
        }
        public virtual DbSet<KhuddarArticle> KhuddarArticles { get; set; }
        public virtual DbSet<KhuddarCofinRequest> KhuddarCofinRequests { get; set; }
        public virtual DbSet<KhuddarCofinGrantedServicesItems> KhuddarCofinGrantedServicesItems { get; set; }
        public virtual DbSet<KhuddarCofinGrantServices> KhuddarCofinGrantServices { get; set; }
        public virtual DbSet<KhuddarCofinRequest> KhuddarCofinRequest { get; set; }
        public virtual DbSet<KhuddarEarnToPLayVideo> KhuddarEarnToPLayVideos { get; set; }
        public virtual DbSet<KhuddarQuiz> KhuddarQuizs { get; set; }
        public virtual DbSet<KhuddarQuizAnswer> KhuddarQuizAnswers { get; set; }
        public virtual DbSet<KhuddarQuizCategory> KhuddarQuizCategorys { get; set; }
        public virtual DbSet<KhuddarQuizCompleted> KhuddarQuizCompleteds { get; set; }
        public virtual DbSet<KhuddarRole> KhuddarRoles { get; set; }
        public virtual DbSet<KhuddarServices> KhuddarServices { get; set; }
        public virtual DbSet<KhuddarShadiMubarakUnlockMode> KhuddarShadiMubarakUnlockModes{ get; set; }
        public virtual DbSet<KhuddarUser> KhuddarUsers{ get; set; }
        public virtual DbSet<KhuddarUserDepoist> KhuddarUserDepoists{ get; set; }
        public virtual DbSet<KhuddarUserGrant> KhuddarUserGrants { get; set; }
        public virtual DbSet<KhuddarUserLogRecord> KhuddarUserLogRecords { get; set; }
        public virtual DbSet<KhuddarUserWallet> KhuddarUserWallet { get; set; }
        public virtual DbSet<KhuddarWalletType> KhuddarWalletType { get; set; }
        public virtual DbSet<KhuddarAlNikkahServicesItems> KhuddarAlNikkahServicesItems { get; set; }
        public virtual DbSet<KhuddarBaraatServicesItems> KhuddarBaraatServicesItems { get; set; }
        public virtual DbSet<KhuddarFoodandFoodServicesItem> KhuddarFoodandFoodServicesItem { get; set; }
        public virtual DbSet<KhuddarFurnitureServicesItem> KhuddarFurnitureServicesItem { get; set; }
        public virtual DbSet<KhuddarGroomSalonServicesItem> KhuddarGroomSalonServicesItem { get; set; }
        public virtual DbSet<KhuddarMarrigeBanquetServicesItem> KhuddarMarrigeBanquetServicesItem { get; set; }
        public virtual DbSet<KhuddarRentAHappyCarServicesItem> KhuddarRentAHappyCarServicesItem { get; set; }
        public virtual DbSet<KhuddarValimaServicesItem> KhuddarValimaServicesItem { get; set; }


        //Shadhi Request Tables
        public virtual DbSet<KhuddarAlNikkah> KhuddarAlNikkah { get; set; }
        public virtual DbSet<KhuddarBarat> KhuddarBarat { get; set; }
        public virtual DbSet<KhuddarFoodandFood> KhuddarFoodandFood { get; set; }
        public virtual DbSet<KhuddarFurniture> KhuddarFurniture { get; set; }
        public virtual DbSet<KhuddarGroomSalon> KhuddarGroomSalon { get; set; }
        public virtual DbSet<KhuddarRentAHappyCar> KhuddarRentAHappyCar { get; set; }
        public virtual DbSet<KhuddarValima> KhuddarValima { get; set; }
        public virtual DbSet<KhuddarMarrigeBanquet> KhuddarMarrigeBanquet { get; set; }





    }
}
