using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001BC RID: 444
	internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable
	{
		// Token: 0x06001384 RID: 4996 RVA: 0x00099F38 File Offset: 0x00098138
		public void Add(string name, BsonToken token)
		{
			for (;;)
			{
				this.list_0.Add(new BsonProperty
				{
					Name = new BsonString(name, false),
					Value = token
				});
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
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
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					goto IL_001B;
				}
				break;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00005D94 File Offset: 0x00003F94
		public override BsonType Type
		{
			get
			{
				return BsonType.Object;
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00006FF5 File Offset: 0x000051F5
		public IEnumerator<BsonProperty> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00007007 File Offset: 0x00005207
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00099FB0 File Offset: 0x000981B0
		public BsonObject()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000866 RID: 2150
		private readonly List<BsonProperty> list_0 = new List<BsonProperty>();
	}
}
