var paymentRequest = new PaymentRequest<TokenSource>
{
    Source = new TokenSource
    {
        Token = "tok_ubfj2q76miwundwlk72vxt2i7q",
        BillingAddress = new Address { },
        Phone = new Phone { }
    }
    Amount = 5600,
    Currency = Currencies.GBP
}

var response = await api.Payments.RequestAsync(request);