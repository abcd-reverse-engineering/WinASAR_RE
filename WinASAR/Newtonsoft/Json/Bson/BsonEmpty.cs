using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001BE RID: 446
	internal class BsonEmpty : BsonToken
	{
		// Token: 0x06001394 RID: 5012 RVA: 0x0009A090 File Offset: 0x00098290
		private BsonEmpty(BsonType type)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
			{
				goto IL_0035;
			}
			do
			{
				IL_001A:
				this.Type = type;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0);
			IL_0035:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				return;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00007029 File Offset: 0x00005229
		public override BsonType Type { get; }

		// Token: 0x06001396 RID: 5014 RVA: 0x0009A0E4 File Offset: 0x000982E4
		static BsonEmpty()
		{
			for (;;)
			{
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
				{
					goto IL_0003;
				}
				IL_0050:
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_0034;
				case 3:
					IL_0003:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
					{
						goto IL_0050;
					}
					break;
				case 4:
					continue;
				}
				BsonEmpty.Null = new BsonEmpty(BsonType.Null);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto IL_0050;
				}
				IL_0034:
				BsonEmpty.Undefined = new BsonEmpty(BsonType.Undefined);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_0050;
				}
				break;
			}
		}

		// Token: 0x0400086A RID: 2154
		public static readonly BsonToken Null;

		// Token: 0x0400086B RID: 2155
		public static readonly BsonToken Undefined;

		// Token: 0x0400086C RID: 2156
		[CompilerGenerated]
		private readonly BsonType BwnjpifoGN;
	}
}
