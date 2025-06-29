using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A8 RID: 424
	[NullableContext(1)]
	internal interface IXmlElement : IXmlNode
	{
		// Token: 0x06001296 RID: 4758
		void SetAttributeNode(IXmlNode attribute);

		// Token: 0x06001297 RID: 4759
		[return: Nullable(2)]
		string GetPrefixOfNamespace(string namespaceUri);

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06001298 RID: 4760
		bool IsEmpty { get; }
	}
}
