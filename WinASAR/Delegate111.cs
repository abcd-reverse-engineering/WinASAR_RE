using System;

// Token: 0x0200027F RID: 639
internal sealed class Delegate111 : MulticastDelegate
{
	// Token: 0x06001990 RID: 6544
	public extern bool Invoke(object object_0);

	// Token: 0x06001991 RID: 6545 RVA: 0x00008C41 File Offset: 0x00006E41
	public static bool smethod_0(object object_0, Delegate111 delegate111_1)
	{
		return delegate111_1(object_0);
	}

	// Token: 0x06001992 RID: 6546
	public extern Delegate111(object object_0, IntPtr intptr_0);

	// Token: 0x06001993 RID: 6547 RVA: 0x00008C4C File Offset: 0x00006E4C
	static Delegate111()
	{
		Class15.smethod_14(typeof(Delegate111).TypeHandle);
	}

	// Token: 0x04000A4F RID: 2639
	internal static Delegate111 delegate111_0;
}
