var client = new GatewayApiClient(apiKey);
var response = await client.Payments.RequestAsync(new PaymentRequest {
    Amount = 6450,
    Currency = "USD",
    Source = "src_3cdac40561494c5aaa8f8c81ef245c10",
    Capture = false
});