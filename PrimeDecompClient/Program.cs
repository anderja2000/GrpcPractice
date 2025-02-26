using Grpc.Net.Client;
using Grpc.Core;
using PrimeDecomp;
using System.Runtime.InteropServices;
// channel for establishing secured connection 
using var channel = GrpcChannel.ForAddress("https://localhost:7051");

// my prime decomposition client 
// receives the channel to establish the connection based on my Client configuraiton 
var client = new PrimeCalculatorService.PrimeCalculatorServiceClient(channel);

// prime request receiving a number for decomposition 

// var number = new PrimeRequest 
// {
//     Number = 120
// }; 


// server streaming using multiple prime request 
// var response = client.DecomposeIntoPrimes(request); 
// var factors = new List<long>(); 

// await foreach( var factor in response.ResponseStream.ReadAllAsync()) { 
//     Console.WriteLine("{0}", response.ResponseStream.Current.Factor); 
//     factors.Add(factor.Factor); 
//     await Task.Delay(200); 
// }

// Console.WriteLine($"{request.Number} = {String.Join(" x ", factors)}");

// client streaming with I/O capabilities 🐧
// Console.Write("Enter a number: ");  // Prompt message
// long number = long.Parse(Console.ReadLine() ?? "0");

//  request based on the object of my Method 


var numberList = new List<int>(); 

var stream = client.ComputeAverage();
Console.Write("Enter a number to sum up to: "); 
int highBound = int.Parse(Console.ReadLine() ?? "0"); 

foreach (int number in Enumerable.Range(1, highBound))
{
    var request = new LongNumberRequest() { Number = number };
    await stream.RequestStream.WriteAsync(request);
    numberList.Add(number); 

}

await stream.RequestStream.CompleteAsync();

var response = await stream.ResponseAsync;

Console.WriteLine($"({String.Join("+", numberList)})/ {numberList.Count} = {response.Average}");



Console.WriteLine("Press any key to exit...");
Console.ReadKey();



// client streaming computing average 


Console.WriteLine("Press any key to exit...");
Console.ReadKey();