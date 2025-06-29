using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F7 RID: 247
	[NullableContext(1)]
	[Nullable(0)]
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00004A40 File Offset: 0x00002C40
		[Nullable(2)]
		public object CurrentObject
		{
			[NullableContext(2)]
			get;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00004A48 File Offset: 0x00002C48
		public ErrorContext ErrorContext { get; }

		// Token: 0x0600099B RID: 2459 RVA: 0x000581E4 File Offset: 0x000563E4
		public ErrorEventArgs([Nullable(2)] object currentObject, ErrorContext errorContext)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
			{
				goto IL_0037;
			}
			goto IL_0040;
			IL_001C:
			this.ErrorContext = errorContext;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
			{
				return;
			}
			goto IL_0040;
			IL_0037:
			this.CurrentObject = currentObject;
			goto IL_001C;
			IL_0040:
			switch (num)
			{
			case 1:
				goto IL_0037;
			case 2:
				goto IL_001C;
			}
		}

		// Token: 0x040004F6 RID: 1270
		[Nullable(2)]
		[CompilerGenerated]
		private readonly object object_0;

		// Token: 0x040004F7 RID: 1271
		[CompilerGenerated]
		private readonly ErrorContext errorContext_0;
	}
}
