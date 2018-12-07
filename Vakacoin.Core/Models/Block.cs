using System.Collections.Generic;

namespace Vakacoin.Core.Models
{
    public class Block
    {
        public BlockHeader Header;
        public List<Transaction> Transactions;
    }
}