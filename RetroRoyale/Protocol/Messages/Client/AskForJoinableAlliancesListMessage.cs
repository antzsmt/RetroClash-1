﻿using System.Threading.Tasks;
using RetroRoyale.Logic;
using RetroGames.Helpers;
using RetroRoyale.Protocol.Messages.Server;

namespace RetroRoyale.Protocol.Messages.Client
{
    public class AskForJoinableAlliancesListMessage : PiranhaMessage
    {
        public AskForJoinableAlliancesListMessage(Device device, Reader reader) : base(device, reader)
        {
        }

        public override async Task Process()
        {
            await Resources.Gateway.Send(new JoinableAllianceListMessage(Device));
        }
    }
}