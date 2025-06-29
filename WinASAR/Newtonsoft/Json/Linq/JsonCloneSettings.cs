using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200015E RID: 350
	public class JsonCloneSettings
	{
		// Token: 0x06000F39 RID: 3897 RVA: 0x0007B1EC File Offset: 0x000793EC
		public JsonCloneSettings()
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
			{
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.CopyAnnotations = true;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
						{
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000061F6 File Offset: 0x000043F6
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x0007B240 File Offset: 0x00079440
		public bool CopyAnnotations
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
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
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

		// Token: 0x06000F3C RID: 3900 RVA: 0x0007B278 File Offset: 0x00079478
		static JsonCloneSettings()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					goto IL_0028;
				}
				goto IL_003D;
				do
				{
					IL_0003:
					JsonCloneSettings.SkipCopyAnnotations = new JsonCloneSettings
					{
						CopyAnnotations = false
					};
					num = 3;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0);
				IL_003D:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0003;
				case 3:
					return;
				}
				IL_0028:
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_0003;
				}
				goto IL_003D;
			}
		}

		// Token: 0x040006DD RID: 1757
		[Nullable(1)]
		internal static readonly JsonCloneSettings SkipCopyAnnotations;

		// Token: 0x040006DE RID: 1758
		[CompilerGenerated]
		private bool bool_0;
	}
}
