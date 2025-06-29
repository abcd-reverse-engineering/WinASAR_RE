using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A5 RID: 421
	[NullableContext(1)]
	internal interface IXmlDocument : IXmlNode
	{
		// Token: 0x06001280 RID: 4736
		IXmlNode CreateComment([Nullable(2)] string text);

		// Token: 0x06001281 RID: 4737
		IXmlNode CreateTextNode([Nullable(2)] string text);

		// Token: 0x06001282 RID: 4738
		IXmlNode imethod_0([Nullable(2)] string data);

		// Token: 0x06001283 RID: 4739
		IXmlNode CreateWhitespace([Nullable(2)] string text);

		// Token: 0x06001284 RID: 4740
		IXmlNode CreateSignificantWhitespace([Nullable(2)] string text);

		// Token: 0x06001285 RID: 4741
		IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone);

		// Token: 0x06001286 RID: 4742
		[NullableContext(2)]
		[return: Nullable(1)]
		IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset);

		// Token: 0x06001287 RID: 4743
		IXmlNode CreateProcessingInstruction(string target, string data);

		// Token: 0x06001288 RID: 4744
		IXmlElement CreateElement(string elementName);

		// Token: 0x06001289 RID: 4745
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x0600128A RID: 4746
		IXmlNode CreateAttribute(string name, string value);

		// Token: 0x0600128B RID: 4747
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600128C RID: 4748
		[Nullable(2)]
		IXmlElement DocumentElement
		{
			[NullableContext(2)]
			get;
		}
	}
}
