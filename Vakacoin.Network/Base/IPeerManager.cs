using System.Collections.Generic;
using Vakacoin.Network.Models;

namespace Vakacoin.Network.Base
{
    

    interface IPeerManager
    {
        bool ValidatePeer(string peerString);
        List<Peer> GetListPeers();
        bool RemovePeer(Peer peer);
        bool AddPeer(Peer peer);
        Peer RecheckPeer(Peer peer);
        List<Peer> GetPeersFromBootNeed(Peer bootNode);
        List<Peer> GetListBootNode();
        Peer GetConnectedPeer();
        bool IsConnectedPeer(Peer peer);
    }
}