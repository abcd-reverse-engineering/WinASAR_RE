using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x0200004F RID: 79
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000028FB File Offset: 0x00000AFB
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00026D1C File Offset: 0x00024F1C
		public bool AllowNullItems
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
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

		// Token: 0x0600021E RID: 542 RVA: 0x00026D54 File Offset: 0x00024F54
		public JsonArrayAttribute()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00026D88 File Offset: 0x00024F88
		public JsonArrayAttribute(bool allowNullItems)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.bool_0 = allowNullItems;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 1:
				goto IL_001A;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00026DD8 File Offset: 0x00024FD8
		[NullableContext(1)]
		public JsonArrayAttribute(string id)
			: base(id)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x040001CF RID: 463
		private bool bool_0;
	}
}
