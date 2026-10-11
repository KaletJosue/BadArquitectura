using System;

// BAD: Mixing minimal APIs with Controllers folder just to confuse structure
namespace WebApi.Controllers
{
    public static class OrdersController
    {
        public const string DoNothingMessage =
            "This controller does nothing. Endpoints are in Program.cs";
    }
}
