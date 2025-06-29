using System;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000139 RID: 313
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaNodeCollection : KeyedCollection<string, JsonSchemaNode>
	{
		// Token: 0x06000D44 RID: 3396 RVA: 0x00005B50 File Offset: 0x00003D50
		protected override string GetKeyForItem(JsonSchemaNode item)
		{
			return item.Id;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00070C94 File Offset: 0x0006EE94
		public JsonSchemaNodeCollection()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
