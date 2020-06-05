using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerTutorialProject.Client.Helpers
{
    public struct MultipleSelectorModel
    {
        public MultipleSelectorModel( int key, string value )
        {
            Key = key;
            Value = value;
        }

        public int Key { get; set; }

        public string Value { get; set; }
    }
}
