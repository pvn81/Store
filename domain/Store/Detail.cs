using System;

namespace Store
{
    public class Detail
    {
        public int Id { get; set; }
        public string DetName { get; }

        public Detail( int id, string detName)
        {
            this.Id = id;
            this.DetName = detName;
        }
    }
}
