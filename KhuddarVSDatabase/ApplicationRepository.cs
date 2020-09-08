using KhuddarVsModals.Interfaces;
using KhuddarVsModals.Models;
using KhuddarVsModals.Models.Shadi_Mubarak;
using KhuddarVsModals.Models.ShadiMubarakServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KhuddarVSDatabase
{
    public class EarnToPLayVideoRepository : Repository<KhuddarEarnToPLayVideo>, IEarnToPLayVideo
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public EarnToPLayVideoRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class AlNikkahRepository : Repository<KhuddarAlNikkah>, IAlNikkah
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public AlNikkahRepository(KhuddarContext Context) :
            base(Context)
        {

        }

       
        public async Task<KhuddarAlNikkah> asynFirstOrdefaultWithUser(Expression<Func<KhuddarAlNikkah, bool>> Predicate)
        {
            return await __context.KhuddarAlNikkah.Include(x => x.KhuddarUser).FirstOrDefaultAsync(Predicate);
        }
    }
    public class BaratRepository : Repository<KhuddarBarat>, IBarat
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public BaratRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<KhuddarBarat> asynFirstOrdefaultWithUser(Expression<Func<KhuddarBarat, bool>> Predicate)
        {
            return await __context.KhuddarBarat.Include(x => x.KhuddarUser).FirstOrDefaultAsync(Predicate);
        }
    }
    public class FoodandFoodRepository : Repository<KhuddarFoodandFood>, IFoodandFood
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public FoodandFoodRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<KhuddarFoodandFood> asynFirstOrdefaultWithUser(Expression<Func<KhuddarFoodandFood, bool>> Predicate)
        {
            return await __context.KhuddarFoodandFood.Include(x => x.KhuddarUser).FirstOrDefaultAsync(Predicate);

        }
    }
    public class FurnitureRepository : Repository<KhuddarFurniture>, IFurniture
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public FurnitureRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<KhuddarFurniture> asynFirstOrdefaultWithUser(Expression<Func<KhuddarFurniture, bool>> Predicate)
        {
            return await __context.KhuddarFurniture.Include(x => x.KhuddarUser).FirstOrDefaultAsync(Predicate);
        }
    }
    public class GroomSalonRepository : Repository<KhuddarGroomSalon>, IGroomSalon
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public GroomSalonRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<KhuddarGroomSalon> asynFirstOrdefaultWithUser(Expression<Func<KhuddarGroomSalon, bool>> Predicate)
        {
            return await __context.KhuddarGroomSalon.Include(x => x.KhuddarUser).FirstOrDefaultAsync(Predicate);

        }
    }
    public class MarrigeBanquetRepository : Repository<KhuddarMarrigeBanquet>, IMarrigeBanquet
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public MarrigeBanquetRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<KhuddarMarrigeBanquet> asynFirstOrdefaultWithUser(Expression<Func<KhuddarMarrigeBanquet, bool>> Predicate)
        {
            return await __context.KhuddarMarrigeBanquet.Include(x => x.KhuddarUser).FirstOrDefaultAsync(Predicate);
        }
    }
    public class RentAHappyCarRepository : Repository<KhuddarRentAHappyCar>, IRentAHappyCar
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public RentAHappyCarRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<KhuddarRentAHappyCar> asynFirstOrdefaultWithUser(Expression<Func<KhuddarRentAHappyCar, bool>> Predicate)
        {
            return await __context.KhuddarRentAHappyCar.Include(x => x.KhuddarUser).FirstOrDefaultAsync(Predicate);
        }
    }
    public class ValimaRepository : Repository<KhuddarValima>, IValima
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public ValimaRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<KhuddarValima> asynFirstOrdefaultWithUser(Expression<Func<KhuddarValima, bool>> Predicate)
        {
            return await __context.KhuddarValima.Include(x => x.KhuddarUser).FirstOrDefaultAsync(Predicate);
        }
    }
    public class BaraatServicesItemsRepository : Repository<KhuddarBaraatServicesItems>, IBaraatServicesItems
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public BaraatServicesItemsRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class FoodandFoodServicesItemRepository : Repository<KhuddarFoodandFoodServicesItem>, IFoodandFoodServicesItem
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public FoodandFoodServicesItemRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class FurnitureServicesItemRepository : Repository<KhuddarFurnitureServicesItem>, IFurnitureServicesItem
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public FurnitureServicesItemRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class GroomSalonServicesItemRepository : Repository<KhuddarGroomSalonServicesItem>, IGroomSalonServicesItem
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public GroomSalonServicesItemRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class MarrigeBanquetServicesItemRepository : Repository<KhuddarMarrigeBanquetServicesItem>, IMarrigeBanquetServicesItem
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public MarrigeBanquetServicesItemRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class RentAHappyCarServicesItemRepository : Repository<KhuddarRentAHappyCarServicesItem>, IRentAHappyCarServicesItem
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public RentAHappyCarServicesItemRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class ValimaServicesItemRepository : Repository<KhuddarValimaServicesItem>, IValimaServicesItem
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public ValimaServicesItemRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class AlNikkahServicesItemsRepository : Repository<KhuddarAlNikkahServicesItems>, IAlNikkahServicesItems
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public AlNikkahServicesItemsRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class ArticlesRepository : Repository<KhuddarArticle>, IArticles
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public ArticlesRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class CoffinServicesRepository : Repository<KhuddarServices>, ICoffinServices
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public CoffinServicesRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class ShadiMubarakUnlockModeRepository : Repository<KhuddarShadiMubarakUnlockMode>, IShadiMubarakUnlockMode
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public ShadiMubarakUnlockModeRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class QuizRepository : Repository<KhuddarQuiz>, IQuiz
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public QuizRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<IEnumerable<KhuddarQuiz>> getCompleteQuizOftheDay()
        {
            return await __context.KhuddarQuizs.Include(x => x.KhuddarQuizAnswers).Include(x=>x.KhuddarQuizCategory).Where(x=>x.date.Date==DateTime.Now.Date ).ToListAsync();
        }

        public async Task<KhuddarQuiz> getCompleteQuizObject(int id)
        {
            return await __context.KhuddarQuizs.Include(x => x.KhuddarQuizAnswers).Include(x => x.KhuddarQuizCategory).FirstOrDefaultAsync(x=>x.Id==id);
        }
        public async Task<IEnumerable<KhuddarQuiz>> getCompleteQuiz()
        {
            return await __context.KhuddarQuizs.Include(x => x.KhuddarQuizAnswers).Include(x => x.KhuddarQuizCategory).ToListAsync();

        }
    }
    public class QuizAnswersRepository : Repository<KhuddarQuizAnswer>, IQuizAnswers
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public QuizAnswersRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class QuizCompletedRepository : Repository<KhuddarQuizCompleted>, IQuizCompleted
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public QuizCompletedRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class QuizCategoryRepository : Repository<KhuddarQuizCategory>, IQuizCategory
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public QuizCategoryRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    } 
    public class RolesRepository : Repository<KhuddarRole>, IRoles
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public RolesRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class UserLogRecordsRepository : Repository<KhuddarUserLogRecord>, IUserLogRecords
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public UserLogRecordsRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class UserWalletRepository : Repository<KhuddarUserWallet>, IUserWallet
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public UserWalletRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    
    public class WalletTypeRepository : Repository<KhuddarWalletType>, IWalletType
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public WalletTypeRepository(KhuddarContext Context) :
            base(Context)
        {

        }
    }
    public class UserRepository : Repository<KhuddarUser>, IUser
    {
        public KhuddarContext __context
        {
            get { return _Context as KhuddarContext; }
        }
        public UserRepository(KhuddarContext Context) :
            base(Context)
        {

        }

        public async Task<IEnumerable<KhuddarUser>> getShadhiRequests()
        {
         return await  __context.KhuddarUsers.Include(x => x.AlNikkahs).ThenInclude(x=>x.KhuddarUser).Include(x => x.Barat).ThenInclude(x => x.KhuddarUser).Include(x => x.FoodandFoods).ThenInclude(x => x.KhuddarUser).Include(x => x.Furnitures).ThenInclude(x => x.KhuddarUser).Include(x => x.GroomSalons).ThenInclude(x => x.KhuddarUser).Include(x => x.MarrigeBanquets).ThenInclude(x => x.KhuddarUser).Include(x => x.RentAHappyCars).ThenInclude(x => x.KhuddarUser).ToListAsync();
        }
    }
}
