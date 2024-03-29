﻿using System;
using System.Collections.Generic;

namespace OratorChan.Bot.Data
{

	[Serializable]
	public class GuildData 
    {
        public ulong Guild { get; set; }
		public ulong BaseChannel { get; set; } = 0;
		public ulong[] ReplyChannels { get; set; } = { };

        public Dictionary<ulong, ChannelData> Channels { get; private set; } = new Dictionary<ulong, ChannelData>();

		public void Save()
		{
			Program.SaveResource(this);
		}
    }
}
