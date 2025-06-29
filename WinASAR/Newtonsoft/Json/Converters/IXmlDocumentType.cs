using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A7 RID: 423
	[NullableContext(2)]
	internal interface IXmlDocumentType : IXmlNode
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06001292 RID: 4754
		[Nullable(1)]
		string Name
		{
			[NullableContext(1)]
			get;
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06001293 RID: 4755
		string System { get; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06001294 RID: 4756
		string Public { get; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001295 RID: 4757
		string InternalSubset { get; }
	}
}
