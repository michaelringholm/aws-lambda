
using Amazon.Lambda.Core;

namespace OM.AWS.Lambda
{
    internal class LocalLambdaLogger : ILambdaLogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }

        public void LogLine(string message)
        {
            System.Console.WriteLine($"{message}\n");
        }
    }
}