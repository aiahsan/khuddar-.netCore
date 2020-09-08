using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KhuddarVsModals.Interfaces
{
   public interface IUnitOfWork : IDisposable
    {
            
       public IEarnToPLayVideo EarnToPLayVideo { get; }
       public IQuiz Quiz { get; }
       public IQuizAnswers QuizAnswers { get; }
       public IQuizCategory QuizCategory { get;  }
       public IRoles Roles { get;  }
       public IUser User { get;  }
       public IUserLogRecords UserLogRecords { get; }
       public IUserWallet UserWallet { get;  }
       public IWalletType WalletType { get; }
       public IQuizCompleted QuizCompleted { get; }
        public IShadiMubarakUnlockMode ShadiMubarakUnlockMode { get;}
        public IArticles Articles { get;}
        public ICoffinServices CoffinServices { get;}
        public IAlNikkahServicesItems AlNikkahServicesItems { get;}
        public IBaraatServicesItems BaraatServicesItems { get; }
        public IFoodandFoodServicesItem FoodandFoodServicesItem { get; }
        public IFurnitureServicesItem FurnitureServicesItem { get; }
        public IGroomSalonServicesItem GroomSalonServicesItem { get; }
        public IMarrigeBanquetServicesItem MarrigeBanquetServicesItem { get; }
        public IRentAHappyCarServicesItem RentAHappyCarServicesItem { get; }
        public IValimaServicesItem ValimaServicesItem { get; }
        public IAlNikkah AlNikkah { get; }
        public IBarat Barat { get; }
        public IFoodandFood FoodandFood { get; }
        public IFurniture Furniture { get; }
        public IGroomSalon GroomSalon { get; }
        public IMarrigeBanquet MarrigeBanquet { get; }
        public IRentAHappyCar RentAHappyCar { get; }
        public IValima Valima { get; }

        int Complete();
        Task asyncComplete();
    }
}
