using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactsServer
{
    public class ChuckNorrisFact
    {
        public int Id { get; set; }
        
        [Required]
        public string Text { get; set; }

        public ChuckNorrisFact() //for serialization
        {

        }

        public ChuckNorrisFact(int id, string text)
        {
            this.Id = id;
            this.Text = text;
        }
    }
}
