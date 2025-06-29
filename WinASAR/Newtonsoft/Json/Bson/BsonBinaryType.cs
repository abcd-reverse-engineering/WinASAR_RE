using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001B5 RID: 437
	internal enum BsonBinaryType : byte
	{
		// Token: 0x04000838 RID: 2104
		Binary,
		// Token: 0x04000839 RID: 2105
		Function,
		// Token: 0x0400083A RID: 2106
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		BinaryOld,
		// Token: 0x0400083B RID: 2107
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		UuidOld,
		// Token: 0x0400083C RID: 2108
		Uuid,
		// Token: 0x0400083D RID: 2109
		Md5,
		// Token: 0x0400083E RID: 2110
		UserDefined = 128
	}
}
