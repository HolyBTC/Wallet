using BitcoinLib;
using Microsoft.Extensions.DependencyInjection;
using Wallet.Application.Services.Abstractions;
using Wallet.Infrastructure.Services.BlockchainInfoService;

namespace Wallet.Infrastructure;

public static class InfrastructureExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddInfrastructure()
        {
            services.AddBitcoinLibClient("BitcoinLibClient", config =>
            {
                config.BatchSendIntervalMilliseconds = TimeSpan.FromMilliseconds(50);
            });
            services.AddScoped<IBlockchainInfoService, BlockchainInfoService>();
            return services;
        }
    }
}