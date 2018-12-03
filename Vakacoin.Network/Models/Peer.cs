namespace Vakacoin.Network.Models
{
    public class Peer
    {
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Key { get; set; }
        public int LastCheck { get; set; }
        public int Status { get; set; }
        public int Speed { get; set; }
        public long LastestBlock { get; set; }
        public bool isBanned { get; set; }
    }
}