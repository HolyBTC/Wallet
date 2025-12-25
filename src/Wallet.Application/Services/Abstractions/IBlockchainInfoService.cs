namespace Wallet.Application.Services.Abstractions;

public interface IBlockchainInfoService
{
    Task GetBlockCountAsync(CancellationToken cancellationToken = default);
}