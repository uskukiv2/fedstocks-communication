using System;
using System.Collections.Generic;

namespace fed.cloud.communication.Country
{
    public class Country
    {
        public Country()
        {
            Counties = new List<County>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<County> Counties { get; set; }
    }

    public class County
    {
        public County()
        {
            Id = Guid.Empty;
            Number = -100;
            Name = string.Empty;
        }

        public Guid Id { get; set; }

        public long Number { get; set; }

        public string Name { get; set; }
    }
}