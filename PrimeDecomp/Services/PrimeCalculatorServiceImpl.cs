// PrimeDecomp/Services/PrimeCalculatorService.cs
using Grpc.Core;
using PrimeDecomp;

namespace PrimeDecomp.Services;

public class PrimeCalculatorServiceImpl : PrimeCalculatorService.PrimeCalculatorServiceBase
{
    public override async Task DecomposeIntoPrimes(
        PrimeRequest request,
        IServerStreamWriter<PrimeResponse> responseStream,
        ServerCallContext context)
    {

        long number = request.Number;
        long k = 2;
        while (number > 1)
        {
            if (number % k == 0)
            {
                await responseStream.WriteAsync(new PrimeResponse { Factor = k });
                number /= k;
            }
            else
            {
                k++;
            }

        }


    }
    public override async Task<LongNumberResponse> ComputeAverage(IAsyncStreamReader<LongNumberRequest> requestStream, ServerCallContext context)
    {
        // var receivedNumbers = new List<long>();

        // while (await requestStream.MoveNext())
        // {
        //     // append each individual number to result and format num , mum ,...
        //     receivedNumbers.Add(requestStream.Current.Number);
        //     Console.WriteLine($"Received numbers: {String.Join(", " , receivedNumbers )}"); 
        // }

        // if (receivedNumbers.Count == 0)
        // {
        //     return new LongNumberResponse { Average = 0 };
        // }

        // double average = receivedNumbers.Average();

        // string numberList = string.Join(", ", receivedNumbers);
        // Console.WriteLine($"Received numbers: {numberList}");

        // return new LongNumberResponse { Average = average };

        int count = 0; 
        double result = 0.0; 

        while (await requestStream.MoveNext()) { 
            result += requestStream.Current.Number; 
            count++;
            Console.WriteLine($"Received Numbers: {String.Join(", ", count)}"); 
        }
        double average = result / count; 

        return new LongNumberResponse() { Average= average};
    }
}
