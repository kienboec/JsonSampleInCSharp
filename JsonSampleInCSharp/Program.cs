using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonSampleInCSharp
{
    public class MyMessage
    {
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }

        public override string ToString()
        {
            return $"Contents: {Content1}, {Content2}, {Content3}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SerializeDemo();
            DeserializeDemo();
            DeserializeDemoWithCustomClass();
        }

        private static void SerializeDemo()
        {
            var message = new MyMessage()
            {
                Content1 = "c1",
                Content2 = "c2",
                Content3 = "c3",
            };

            // {"Content1":"c1","Content2":"c2","Content3":"c3"}
            Console.WriteLine(JsonSerializer.Serialize(message));
            // Contents: c1, c2, c3
            Console.WriteLine(message.ToString());
        }

        private static void DeserializeDemo()
        {
            string content = "{\"Content1\":\"c4\",\"Content2\":\"c5\",\"Content3\":\"c6\"}";
            Console.WriteLine(content);

            var message = JsonSerializer.Deserialize<MyMessage>(content);
            Console.WriteLine(message.ToString());
        }

        private static void DeserializeDemoWithCustomClass()
        {
            CustomJsonSerializer<MyMessage> serializer = new CustomJsonSerializer<MyMessage>();

            string content = "{\"Content1\":\"c7\",\"Content2\":\"c8\",\"Content3\":\"c9\"}";
            Console.WriteLine(content);

            var message = serializer.Deserialize(content);
            Console.WriteLine(message.ToString());
        }
    }
}
