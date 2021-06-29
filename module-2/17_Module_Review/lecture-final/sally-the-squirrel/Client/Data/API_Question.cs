using System;
using System.Collections.Generic;
using System.Text;

namespace SallyClient.Data
{
    public class API_Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Text}";
        }
    }
}
