﻿using System;

namespace GameServer.Networking
{
	
	[PacketInfoAttribute(来源 = PacketSource.Server, 编号 = 578, 长度 = 14, 注释 = "提取附件成功")]
	public sealed class 成功提取附件 : GamePacket
	{
		
		public 成功提取附件()
		{
			
			
		}

		
		[WrappingFieldAttribute(SubScript = 6, Length = 4)]
		public int 邮件编号;
	}
}