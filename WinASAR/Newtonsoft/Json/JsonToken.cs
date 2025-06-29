using System;

namespace Newtonsoft.Json
{
	// Token: 0x0200006B RID: 107
	public enum JsonToken
	{
		// Token: 0x040002B8 RID: 696
		None,
		// Token: 0x040002B9 RID: 697
		StartObject,
		// Token: 0x040002BA RID: 698
		StartArray,
		// Token: 0x040002BB RID: 699
		StartConstructor,
		// Token: 0x040002BC RID: 700
		PropertyName,
		// Token: 0x040002BD RID: 701
		Comment,
		// Token: 0x040002BE RID: 702
		Raw,
		// Token: 0x040002BF RID: 703
		Integer,
		// Token: 0x040002C0 RID: 704
		Float,
		// Token: 0x040002C1 RID: 705
		String,
		// Token: 0x040002C2 RID: 706
		Boolean,
		// Token: 0x040002C3 RID: 707
		Null,
		// Token: 0x040002C4 RID: 708
		Undefined,
		// Token: 0x040002C5 RID: 709
		EndObject,
		// Token: 0x040002C6 RID: 710
		EndArray,
		// Token: 0x040002C7 RID: 711
		EndConstructor,
		// Token: 0x040002C8 RID: 712
		Date,
		// Token: 0x040002C9 RID: 713
		Bytes
	}
}
