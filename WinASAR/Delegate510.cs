using System;
using System.Collections;

// Token: 0x0200040E RID: 1038
internal sealed class Delegate510 : MulticastDelegate
{
	// Token: 0x06001FCC RID: 8140
	public extern DictionaryEntry Invoke(object object_0);

	// Token: 0x06001FCD RID: 8141 RVA: 0x0000B41F File Offset: 0x0000961F
	public static DictionaryEntry smethod_0(object object_0, Delegate510 delegate510_0)
	{
		return delegate510_0(object_0);
	}

	// Token: 0x06001FCE RID: 8142
	public extern Delegate510(object object_0, IntPtr intptr_0);

	// Token: 0x06001FCF RID: 8143 RVA: 0x0000B42A File Offset: 0x0000962A
	static Delegate510()
	{
		Class15.smethod_14(typeof(Delegate510).TypeHandle);
	}

	// Token: 0x04000BDE RID: 3038
	internal static Delegate510 IrkmxtZyIc;
}
