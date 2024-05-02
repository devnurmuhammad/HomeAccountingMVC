using HomeAccountingMVC.Repositories.Accounts;
using HomeAccountingMVC.Repositories.Categories;
using HomeAccountingMVC.Repositories.Transactions;
using HomeAccountingMVC.Services.Accounts;
using HomeAccountingMVC.Services.Categories;
using HomeAccountingMVC.Services.Transactions;

namespace HomeAccountingMVC.Dependencies
{
    public static class AppDependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services
                .AddScoped<IAccountRepository, AccountRepository>()
                .AddScoped<IAccountService, AccountService>()
                .AddScoped<ITransactionRepository, TransactionRepository>()
                .AddScoped<ITransactionService, TransactionService>()
                .AddScoped<ICategoryRepository, CategoryRepository>()
                .AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
