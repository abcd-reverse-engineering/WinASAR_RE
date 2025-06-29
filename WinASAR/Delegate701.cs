using System;

// Token: 0x020004CD RID: 1229
internal sealed class Delegate701 : MulticastDelegate
{
	// Token: 0x060022C8 RID: 8904
	public extern bool Invoke(object object_0);

	// Token: 0x060022C9 RID: 8905 RVA: 0x0000C736 File Offset: 0x0000A936
	public static bool smethod_0(object object_0, Delegate701 delegate701_1)
	{
		return delegate701_1(object_0);
	}

	// Token: 0x060022CA RID: 8906
	public extern Delegate701(object object_0, IntPtr intptr_0);

	// Token: 0x060022CB RID: 8907 RVA: 0x0000C741 File Offset: 0x0000A941
	static Delegate701()
	{
		Class15.smethod_14(typeof(Delegate701).TypeHandle);
	}

	// Token: 0x04000C9D RID: 3229
	internal static Delegate701 delegate701_0;
}
