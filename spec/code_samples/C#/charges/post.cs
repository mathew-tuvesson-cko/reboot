
var client = new GatewayApiClient(apiKey);
var response = await client.Charges.RequestAsync(new ChargeRequest {
    amount = 6450,
    currency = "USD",
    source = "src_3cdac40561494c5aaa8f8c81ef245c10",
    capture = false
});