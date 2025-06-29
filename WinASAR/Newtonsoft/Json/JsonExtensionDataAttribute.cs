using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x02000059 RID: 89
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class JsonExtensionDataAttribute : Attribute
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00002C4E File Offset: 0x00000E4E
		// (set) Token: 0x060002BA RID: 698 RVA: 0x00028808 File Offset: 0x00026A08
		public bool WriteData
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00002C56 File Offset: 0x00000E56
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00028840 File Offset: 0x00026A40
		public bool ReadData
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
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

		// Token: 0x060002BD RID: 701 RVA: 0x00028878 File Offset: 0x00026A78
		public JsonExtensionDataAttribute()
		{
			for (;;)
			{
				IL_0036:
				this.WriteData = true;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.ReadData = true;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_0036;
					}
					return;
				}
			}
		}

		// Token: 0x040001F0 RID: 496
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040001F1 RID: 497
		[CompilerGenerated]
		private bool bool_1;
	}
}
