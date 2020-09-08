using KhuddarVsModals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KhuddarVSDatabase
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KhuddarContext _context;
        public UnitOfWork(KhuddarContext contex)
        {
            _context = contex;

            EarnToPLayVideo = new EarnToPLayVideoRepository(_context);
            Quiz = new QuizRepository(_context);
            QuizAnswers = new QuizAnswersRepository(_context);
            QuizCategory = new QuizCategoryRepository(_context);
            Roles = new RolesRepository(_context);
            User = new UserRepository(_context);
            UserLogRecords = new UserLogRecordsRepository(_context);
            UserWallet = new UserWalletRepository(_context);
            WalletType = new WalletTypeRepository(_context);
            QuizCompleted = new QuizCompletedRepository(_context);
            ShadiMubarakUnlockMode = new ShadiMubarakUnlockModeRepository(_context);
            Articles = new ArticlesRepository(_context);
            CoffinServices = new CoffinServicesRepository(_context);
            AlNikkahServicesItems = new AlNikkahServicesItemsRepository(_context);
            BaraatServicesItems = new BaraatServicesItemsRepository(_context);
            ValimaServicesItem = new ValimaServicesItemRepository(_context);
            RentAHappyCarServicesItem = new RentAHappyCarServicesItemRepository(_context);
            MarrigeBanquetServicesItem = new MarrigeBanquetServicesItemRepository(_context);
            RentAHappyCarServicesItem = new RentAHappyCarServicesItemRepository(_context);
            ValimaServicesItem = new ValimaServicesItemRepository(_context);
            FoodandFoodServicesItem = new FoodandFoodServicesItemRepository(_context);
            FurnitureServicesItem= new FurnitureServicesItemRepository(_context);
            GroomSalonServicesItem = new GroomSalonServicesItemRepository(_context);
            AlNikkah = new AlNikkahRepository(_context);
            Barat = new BaratRepository(_context);
            FoodandFood = new FoodandFoodRepository(_context);
            Furniture = new FurnitureRepository(_context);
            GroomSalon = new GroomSalonRepository(_context);
            MarrigeBanquet = new MarrigeBanquetRepository(_context);
            Valima = new ValimaRepository(_context);
            RentAHappyCar = new RentAHappyCarRepository(_context);
        }

        public IEarnToPLayVideo EarnToPLayVideo { get; private set; }

        public IQuiz Quiz { get; private set; }

        public IQuizAnswers QuizAnswers { get; private set; }

        public IQuizCategory QuizCategory { get; private set; }
        public IRoles Roles { get; private set; }
        public IUser User { get; private set; }
        public IUserLogRecords UserLogRecords { get; private set; }
        public IUserWallet UserWallet { get; private set; }
        public IWalletType WalletType { get; private set; }
        public IQuizCompleted QuizCompleted { get; private set; }
        public IShadiMubarakUnlockMode ShadiMubarakUnlockMode { get; private set; }
        public IArticles Articles { get; private set; }
        public ICoffinServices CoffinServices { get; private set; }
        public IAlNikkahServicesItems AlNikkahServicesItems { get; private set; }
        public IFoodandFoodServicesItem FoodandFoodServicesItem { get; private set; }
        public IFurnitureServicesItem FurnitureServicesItem { get; private set; }
        public IGroomSalonServicesItem GroomSalonServicesItem { get; private set; }
        public IMarrigeBanquetServicesItem MarrigeBanquetServicesItem { get; private set; }
        public IRentAHappyCarServicesItem RentAHappyCarServicesItem { get; private set; }
        public IValimaServicesItem ValimaServicesItem { get; private set; }
        public IBaraatServicesItems BaraatServicesItems { get; private set; }

        public IAlNikkah AlNikkah { get; private set; }
        public IBarat Barat { get; private set; }
        public IFoodandFood FoodandFood { get; private set; }
        public IFurniture Furniture { get; private set; }
        public IGroomSalon GroomSalon { get; private set; }
        public IMarrigeBanquet MarrigeBanquet { get; private set; }
        public IRentAHappyCar RentAHappyCar { get; private set; }
        public IValima Valima { get; private set; }

        public async Task asyncComplete()
        {
            await _context.SaveChangesAsync();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
