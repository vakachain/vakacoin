using System;

namespace Vakacoin.Core.Models
{
    public class BlockHeader
    {
        public int Height { get; set; }
        public DateTime CreatedAt { get; set; }
        public string  PreviousHash { get; set; }
        public string MerkleTreeHashRoot { get; set; }
        public int TotalTransaction { get; set; }
        public string ProducedBy { get; set; }
    }
}