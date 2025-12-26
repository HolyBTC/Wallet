using Microsoft.AspNetCore.Mvc;

namespace Wallet.Api.Controllers.Abstractions;

[Route("api/[controller]")]
[ApiController]
public abstract class WalletBaseController : ControllerBase;