﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculcator
{
    internal class Division : Operation
    {
        public string Divide(string input)
        {
            var a = new Division();
            Operands = a.ConvertToDec(input);
            return (Operands[0] / Operands[1]).ToString();
        }

        public Division()
        {

        }
    }
}
