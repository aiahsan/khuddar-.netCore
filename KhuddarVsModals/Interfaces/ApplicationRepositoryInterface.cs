using KhuddarVsModals.Models;
using KhuddarVsModals.Models.Shadi_Mubarak;
using KhuddarVsModals.Models.ShadiMubarakServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KhuddarVsModals.Interfaces
{
    public interface IEarnToPLayVideo : IRepositoryInterface<KhuddarEarnToPLayVideo>
    {
    }
    public interface IBaraatServicesItems : IRepositoryInterface<KhuddarBaraatServicesItems>
    {
    }
    public interface IFoodandFoodServicesItem : IRepositoryInterface<KhuddarFoodandFoodServicesItem>
    {
    }
    public interface IFurnitureServicesItem : IRepositoryInterface<KhuddarFurnitureServicesItem>
    {
    }
    public interface IGroomSalonServicesItem : IRepositoryInterface<KhuddarGroomSalonServicesItem>
    {
    }
    public interface IMarrigeBanquetServicesItem : IRepositoryInterface<KhuddarMarrigeBanquetServicesItem>
    {
    }public interface IRentAHappyCarServicesItem : IRepositoryInterface<KhuddarRentAHappyCarServicesItem>
    {
    }
    public interface IValimaServicesItem : IRepositoryInterface<KhuddarValimaServicesItem>
    {
    }
    public interface IAlNikkahServicesItems : IRepositoryInterface<KhuddarAlNikkahServicesItems>
    {
    }
    public interface ICoffinServices : IRepositoryInterface<KhuddarServices>
    {
    }public interface IArticles : IRepositoryInterface<KhuddarArticle>
    {
    } public interface IShadiMubarakUnlockMode : IRepositoryInterface<KhuddarShadiMubarakUnlockMode>
    {
    }
    public interface IQuiz : IRepositoryInterface<KhuddarQuiz>
    {
       Task<IEnumerable<KhuddarQuiz>> getCompleteQuizOftheDay();
       Task<IEnumerable<KhuddarQuiz>> getCompleteQuiz();
       Task<KhuddarQuiz> getCompleteQuizObject(int id);
       
    }
    public interface IQuizCompleted : IRepositoryInterface<KhuddarQuizCompleted>
    {
        
    }
    public interface IQuizAnswers : IRepositoryInterface<KhuddarQuizAnswer>
    {
    }
    public interface IQuizCategory : IRepositoryInterface<KhuddarQuizCategory>
    {
    }
    public interface IRoles : IRepositoryInterface<KhuddarRole>
    {
    }
    public interface IUser : IRepositoryInterface<KhuddarUser>
    {
        Task<IEnumerable<KhuddarUser>> getShadhiRequests();
    }
  
    public interface IUserLogRecords : IRepositoryInterface<KhuddarUserLogRecord>
    {
    }
    public interface IUserWallet : IRepositoryInterface<KhuddarUserWallet>
    {
    }
    
    public interface IWalletType : IRepositoryInterface<KhuddarWalletType>
    {
    }
    
    public interface IAlNikkah : IRepositoryInterface<KhuddarAlNikkah>, KhuddarShadiMubarakInterFace<KhuddarAlNikkah>
    {
    }
    public interface IBarat : IRepositoryInterface<KhuddarBarat>, KhuddarShadiMubarakInterFace<KhuddarBarat>
    {
    }
    public interface IFoodandFood : IRepositoryInterface<KhuddarFoodandFood>, KhuddarShadiMubarakInterFace<KhuddarFoodandFood>
    {
    }
    public interface IFurniture : IRepositoryInterface<KhuddarFurniture>, KhuddarShadiMubarakInterFace<KhuddarFurniture>
    {
    }
    public interface IGroomSalon : IRepositoryInterface<KhuddarGroomSalon>, KhuddarShadiMubarakInterFace<KhuddarGroomSalon>
    {
    }
    public interface IMarrigeBanquet : IRepositoryInterface<KhuddarMarrigeBanquet>, KhuddarShadiMubarakInterFace<KhuddarMarrigeBanquet>
    {
    }
    public interface IRentAHappyCar : IRepositoryInterface<KhuddarRentAHappyCar>, KhuddarShadiMubarakInterFace<KhuddarRentAHappyCar>
    {
    }
    public interface IValima : IRepositoryInterface<KhuddarValima>,KhuddarShadiMubarakInterFace<KhuddarValima>
    {

    }
}
