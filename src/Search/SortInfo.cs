﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseNet.Search
{
    [DebuggerDisplay("{ToString()}")]
    public class SortInfo
    {
        //UNDONE: let FieldName mandatory by a parametered constructor
        public string FieldName { get; }
        public bool Reverse { get; }

        public SortInfo(string fieldName, bool reverse = false)
        {
            if (fieldName == null)
                throw new ArgumentNullException(nameof(fieldName));
            if (fieldName.Length == 0)
                throw new ArgumentException($"{nameof(fieldName)} cannot be empty.");
            FieldName = fieldName;
            Reverse = reverse;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FieldName, Reverse ? "DESC" : "ASC");
        }
    }
}