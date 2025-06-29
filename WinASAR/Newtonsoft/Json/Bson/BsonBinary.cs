using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001C2 RID: 450
	internal class BsonBinary : BsonValue
	{
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00007051 File Offset: 0x00005251
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x0009A338 File Offset: 0x00098538
		public BsonBinaryType BinaryType
		{
			[CompilerGenerated]
			get
			{
				return this.bsonBinaryType_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bsonBinaryType_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
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

		// Token: 0x060013AC RID: 5036 RVA: 0x0009A370 File Offset: 0x00098570
		public BsonBinary(byte[] value, BsonBinaryType binaryType)
			: base(value, BsonType.Binary)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.BinaryType = binaryType;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x04000877 RID: 2167
		[CompilerGenerated]
		private BsonBinaryType bsonBinaryType_0;
	}
}
