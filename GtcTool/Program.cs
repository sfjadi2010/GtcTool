// See https://aka.ms/new-console-template for more information
using GtcTool.Services;

FederalRegisterService registerService = new FederalRegisterService();
var response = registerService.GetFederalRegisterResponse();
Console.WriteLine(response);
