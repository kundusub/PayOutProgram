using System;
using System.Collections.Generic;

namespace PayOutProgram
{
    public interface IPayOut
    {
        void CalculatePayOut(List<int> notes, List<int> amounts, int highest, int sum, int goal);
    }
}