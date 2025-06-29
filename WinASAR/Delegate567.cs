using System;

// Token: 0x02000447 RID: 1095
internal sealed class Delegate567 : MulticastDelegate
{
	// Token: 0x060020B0 RID: 8368
	public extern Type Invoke(object object_0);

	// Token: 0x060020B1 RID: 8369 RVA: 0x0000B9D7 File Offset: 0x00009BD7
	public static Type smethod_0(object object_0, Delegate567 delegate567_1)
	{
		return delegate567_1(object_0);
	}

	// Token: 0x060020B2 RID: 8370
	public extern Delegate567(object object_0, IntPtr intptr_0);

	// Token: 0x060020B3 RID: 8371 RVA: 0x0000B9E2 File Offset: 0x00009BE2
	static Delegate567()
	{
		Class15.smethod_14(typeof(Delegate567).TypeHandle);
	}

	// Token: 0x04000C17 RID: 3095
	internal static Delegate567 delegate567_0;
}
