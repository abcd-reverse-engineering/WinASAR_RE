using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001BD RID: 445
	internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable
	{
		// Token: 0x0600138C RID: 5004 RVA: 0x00099FF0 File Offset: 0x000981F0
		public void Add(BsonToken token)
		{
			for (;;)
			{
				this.list_0.Add(token);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_0003;
				}
				IL_001B:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				}
				IL_0003:
				token.Parent = this;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_001B;
				}
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00006129 File Offset: 0x00004329
		public override BsonType Type
		{
			get
			{
				return BsonType.Array;
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0000700F File Offset: 0x0000520F
		public IEnumerator<BsonToken> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00007021 File Offset: 0x00005221
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0009A050 File Offset: 0x00098250
		public BsonArray()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000868 RID: 2152
		private readonly List<BsonToken> list_0 = new List<BsonToken>();
	}
}
