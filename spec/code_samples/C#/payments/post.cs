var client = new GatewayApiClient(apiKey);

var response = await client.Payments.RequestAsync(
    new PaymentRequest<CardSource> 
    {
        Amount = 6450,
        Currency = "USD",
        Capture = false,
        Source = new CardSource 
        {
            Number = "4543474002249996",
            ExpiryMonth = 6,
            ExpiryYear = 2018,
            Name = "Bruce Wayne",
            Cvv = "956"
        }
    }
);