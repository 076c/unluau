﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unluau
{
    class StatementExpression : Statement
    {
        public Expression Expression { get; set; }

        public StatementExpression(Expression expression)
            => Expression = expression;

        public override void Write(Output output)
        {
            Expression.Write(output);
        }
    }
}
