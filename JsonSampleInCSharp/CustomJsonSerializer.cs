using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonSampleInCSharp
{
    public class CustomJsonSerializer<T>
    {
        public T Deserialize(string content)
        {
            return JsonSerializer.Deserialize<T>(content);
        }
    }
}
