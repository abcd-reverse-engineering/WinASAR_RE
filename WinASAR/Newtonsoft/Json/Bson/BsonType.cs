using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001C5 RID: 453
	internal enum BsonType : sbyte
	{
		// Token: 0x04000880 RID: 2176
		Number = 1,
		// Token: 0x04000881 RID: 2177
		String,
		// Token: 0x04000882 RID: 2178
		Object,
		// Token: 0x04000883 RID: 2179
		Array,
		// Token: 0x04000884 RID: 2180
		Binary,
		// Token: 0x04000885 RID: 2181
		Undefined,
		// Token: 0x04000886 RID: 2182
		Oid,
		// Token: 0x04000887 RID: 2183
		Boolean,
		// Token: 0x04000888 RID: 2184
		Date,
		// Token: 0x04000889 RID: 2185
		Null,
		// Token: 0x0400088A RID: 2186
		Regex,
		// Token: 0x0400088B RID: 2187
		Reference,
		// Token: 0x0400088C RID: 2188
		Code,
		// Token: 0x0400088D RID: 2189
		Symbol,
		// Token: 0x0400088E RID: 2190
		const_14,
		// Token: 0x0400088F RID: 2191
		Integer,
		// Token: 0x04000890 RID: 2192
		TimeStamp,
		// Token: 0x04000891 RID: 2193
		Long,
		// Token: 0x04000892 RID: 2194
		MinKey = -1,
		// Token: 0x04000893 RID: 2195
		MaxKey = 127
	}
}
