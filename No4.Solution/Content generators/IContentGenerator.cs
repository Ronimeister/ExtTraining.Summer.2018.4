﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Content_generators
{
    public interface IContentGenerator
    {
        byte[] GenerateFileContent(int contentLength);
    }
}
