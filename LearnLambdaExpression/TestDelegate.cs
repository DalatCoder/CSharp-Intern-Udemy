using System;

namespace LearnLambdaExpression
{
    public class TestDelegate
    {
        public int Test(Func<int, int, int> handler, int num1, int num2)
        {
            return handler(num1, num2);
        }
    }
}
