using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001BB RID: 443
	internal abstract class BsonToken
	{
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600137B RID: 4987
		public abstract BsonType Type { get; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x00006FE5 File Offset: 0x000051E5
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x00099E94 File Offset: 0x00098094
		public BsonToken Parent
		{
			[CompilerGenerated]
			get
			{
				return this.bsonToken_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bsonToken_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x00006FED File Offset: 0x000051ED
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x00099ECC File Offset: 0x000980CC
		public int CalculatedSize
		{
			[CompilerGenerated]
			get
			{
				return this.int_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.int_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00099F04 File Offset: 0x00098104
		protected BsonToken()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000863 RID: 2147
		[CompilerGenerated]
		private BsonToken bsonToken_0;

		// Token: 0x04000864 RID: 2148
		[CompilerGenerated]
		private int int_0;
	}
}
