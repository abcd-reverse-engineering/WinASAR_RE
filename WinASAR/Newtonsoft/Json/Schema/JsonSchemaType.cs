using System;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200013C RID: 316
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	[Flags]
	public enum JsonSchemaType
	{
		// Token: 0x04000669 RID: 1641
		None = 0,
		// Token: 0x0400066A RID: 1642
		String = 1,
		// Token: 0x0400066B RID: 1643
		Float = 2,
		// Token: 0x0400066C RID: 1644
		Integer = 4,
		// Token: 0x0400066D RID: 1645
		Boolean = 8,
		// Token: 0x0400066E RID: 1646
		Object = 16,
		// Token: 0x0400066F RID: 1647
		Array = 32,
		// Token: 0x04000670 RID: 1648
		Null = 64,
		// Token: 0x04000671 RID: 1649
		Any = 127
	}
}
