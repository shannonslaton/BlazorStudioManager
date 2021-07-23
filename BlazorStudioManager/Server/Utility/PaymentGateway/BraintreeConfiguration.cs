using Braintree;

namespace BlazorStudioManager.Server.Utility.PaymentGateway
{
    public class BraintreeConfiguration : IBraintreeConfiguration
    {
        public string Environment { get; set; }
        public string MerchantId { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        private IBraintreeGateway BraintreeGateway { get; set; }

        public IBraintreeGateway CreateGateway(string environment, string merchantId, string publicKey, string privateKey)
        {
            if (MerchantId == null || PublicKey == null || PrivateKey == null)
            {
                Environment = environment;
                MerchantId = merchantId;
                PublicKey = publicKey;
                PrivateKey = privateKey;
            }

            return new BraintreeGateway(Environment, MerchantId, PublicKey, PrivateKey);
        }

        public IBraintreeGateway GetGateway(string environment, string merchantId, string publicKey, string privateKey)
        {
            if (BraintreeGateway == null)
            {
                BraintreeGateway = CreateGateway(environment, merchantId, publicKey, privateKey);
            }

            return BraintreeGateway;
        }
    }
}
