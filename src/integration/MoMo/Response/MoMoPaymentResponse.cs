﻿namespace MoMo.Response;
public class MoMoPaymentResponse
{
    public string PartnerCode { get; set; } = string.Empty;
    public string RequestId { get; set; } = string.Empty;
    public string OrderId { get; set; } = string.Empty; 
    public long Amount { get; set; }
    public long ResponseTime { get; set; }
    public string Message { get; set; } = string.Empty;
    public int ResultCode { get; set; }
    public string PayUrl { get; set; } = string.Empty;
    public string DeepLink { get; set; } = string.Empty;
    public string QRCodeUrl { get; set; } = string.Empty;
    public string DeepLinkMiniApp { get; set; } = string.Empty;
}
