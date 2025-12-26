using Microsoft.AspNetCore.Mvc;
using Wallet.Api.Controllers.Abstractions;
using Wallet.Application.Services.Abstractions;

namespace Wallet.Api.Controllers;


public class TestController(
    IBlockchainInfoService blockchainInfoService) : WalletBaseController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await blockchainInfoService.GetBlockCountAsync());
    }
}