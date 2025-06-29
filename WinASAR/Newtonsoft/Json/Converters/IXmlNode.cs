using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A9 RID: 425
	[NullableContext(2)]
	internal interface IXmlNode
	{
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001299 RID: 4761
		XmlNodeType NodeType { get; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600129A RID: 4762
		string LocalName { get; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600129B RID: 4763
		[Nullable(1)]
		List<IXmlNode> ChildNodes
		{
			[NullableContext(1)]
			get;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600129C RID: 4764
		[Nullable(1)]
		List<IXmlNode> Attributes
		{
			[NullableContext(1)]
			get;
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600129D RID: 4765
		IXmlNode ParentNode { get; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600129E RID: 4766
		// (set) Token: 0x0600129F RID: 4767
		string Value { get; set; }

		// Token: 0x060012A0 RID: 4768
		[NullableContext(1)]
		IXmlNode AppendChild(IXmlNode newChild);

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060012A1 RID: 4769
		string NamespaceUri { get; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060012A2 RID: 4770
		object WrappedNode { get; }
	}
}
