using System.Collections.Generic;
using Vakacoin.Network.Base;
using Vakacoin.Network.Models;

namespace Vakacoin.Network
{
    public class PeerManager : IPeerManager
    {
        public bool ValidatePeer(string peerString)
        {
            throw new System.NotImplementedException();
        }

        public List<Peer> GetListPeers()
        {
            throw new System.NotImplementedException();
        }

        public bool RemovePeer(Peer peer)
        {
            throw new System.NotImplementedException();
        }

        public bool AddPeer(Peer peer)
        {
            throw new System.NotImplementedException();
        }

        public Peer RecheckPeer(Peer peer)
        {
            throw new System.NotImplementedException();
        }

        public List<Peer> GetPeersFromBootNeed(Peer bootNode)
        {
            throw new System.NotImplementedException();
        }

        public List<Peer> GetListBootNode()
        {
            throw new System.NotImplementedException();
        }
        
        public Peer GetConnectedPeer()
        {
            throw new System.NotImplementedException();
        }

        public bool IsConnectedPeer(Peer peer)
        {
            throw new System.NotImplementedException();
        }
    }
}