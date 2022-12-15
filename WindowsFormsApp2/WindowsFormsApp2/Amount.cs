using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Amount
    {
        private int id;
        private string name_detail;
        private int count;

        public Amount(int id, string name_detail, int count)
        {
            Id = id;
            Name_detail = name_detail;
            Count = count;
        }

        public int Id { get => id; set => id = value; }
        public string Name_detail { get => name_detail; set => name_detail = value; }
        public int Count { get => count; set => count = value; }
    }
}
