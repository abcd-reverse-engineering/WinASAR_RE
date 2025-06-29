using System;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200013F RID: 319
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public enum UndefinedSchemaIdHandling
	{
		// Token: 0x04000679 RID: 1657
		None,
		// Token: 0x0400067A RID: 1658
		UseTypeName,
		// Token: 0x0400067B RID: 1659
		UseAssemblyQualifiedName
	}
}
