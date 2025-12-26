namespace Wallet.Application.Services.Abstractions;

public interface IBlockchainInfoService
{
    Task<ulong> GetBlockCountAsync(CancellationToken cancellationToken = default);
}