using Braintree;
using System;
using System.Linq;

namespace BlazorStudioManager.Server.Utility.PaymentGateway
{
    public interface IBraintreeConfiguration
    {
        IBraintreeGateway CreateGateway(string environment, string merchantId, string publicKey, string privateKey);
        IBraintreeGateway GetGateway(string environment, string merchantId, string publicKey, string privateKey);
    }
}
