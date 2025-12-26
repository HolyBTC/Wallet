using System.Text.Json;
using BitcoinLib.Abstractions;
using Wallet.Application.Services.Abstractions;
using Wallet.Infrastructure.Services.BlockchainInfoService.Constants;

namespace Wallet.Infrastructure.Services.BlockchainInfoService;

public class BlockchainInfoService(
    IBitcoinRpcService bitcoinRpcService) : IBlockchainInfoService
{
    public async Task<ulong> GetBlockCountAsync(CancellationToken cancellationToken = default)
    {
        JsonElement result = await bitcoinRpcService.MakeRpcCall(MethodConstants.GetBlockCount, [], cancellationToken);
        return ulong.Parse(result.GetRawText());
    }
}