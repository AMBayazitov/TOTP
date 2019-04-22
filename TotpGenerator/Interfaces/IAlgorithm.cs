using System;
using System.Collections.Generic;
using System.Text;

namespace TotpGenerator.Interfaces
{
    public interface IAlgorithm
    {
        string Generate(string timeCounter, string key);
    }
}
