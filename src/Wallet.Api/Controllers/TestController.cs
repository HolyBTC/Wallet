using Microsoft.AspNetCore.Mvc;
using Wallet.Api.Controllers.Abstractions;
namespace Wallet.Api.Controllers;


public class TestController : WalletBaseController
{
    public async Task<IActionResult> Get()
    {
        return Ok(new {Name = "Hello world!"});
    }
}