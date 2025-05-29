using System;
using Grpc.Core;

using RPCalculator;

namespace RCPTesting
{
    public class CalculatorService : Calculator.CalculatorBase
    {
        public override Task<AddReply> Add(AddRequest request, ServerCallContext context)
        {
            return Task.FromResult(new AddReply { Result = request.X + request.Y });
        }
    }
}
