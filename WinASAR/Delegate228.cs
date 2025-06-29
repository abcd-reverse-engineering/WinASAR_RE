using System;
using System.Windows.Forms;

// Token: 0x020002F4 RID: 756
internal sealed class Delegate228 : MulticastDelegate
{
	// Token: 0x06001B64 RID: 7012
	public extern void Invoke(object object_0, TextImageRelation textImageRelation_0);

	// Token: 0x06001B65 RID: 7013 RVA: 0x000097BB File Offset: 0x000079BB
	public static void smethod_0(object object_0, TextImageRelation textImageRelation_0, Delegate228 delegate228_1)
	{
		delegate228_1(object_0, textImageRelation_0);
	}

	// Token: 0x06001B66 RID: 7014
	public extern Delegate228(object object_0, IntPtr intptr_0);

	// Token: 0x06001B67 RID: 7015 RVA: 0x000097C8 File Offset: 0x000079C8
	static Delegate228()
	{
		Class15.smethod_14(typeof(Delegate228).TypeHandle);
	}

	// Token: 0x04000AC4 RID: 2756
	internal static Delegate228 delegate228_0;
}
