using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A6 RID: 422
	[NullableContext(2)]
	internal interface IXmlDeclaration : IXmlNode
	{
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600128D RID: 4749
		string Version { get; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600128E RID: 4750
		// (set) Token: 0x0600128F RID: 4751
		string Encoding { get; set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06001290 RID: 4752
		// (set) Token: 0x06001291 RID: 4753
		string Standalone { get; set; }
	}
}
