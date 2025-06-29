using System;

// Token: 0x02000383 RID: 899
internal sealed class Delegate371 : MulticastDelegate
{
	// Token: 0x06001DA0 RID: 7584
	public extern bool Invoke(object object_0, object object_1);

	// Token: 0x06001DA1 RID: 7585 RVA: 0x0000A61D File Offset: 0x0000881D
	public static bool smethod_0(object object_0, object object_1, Delegate371 delegate371_1)
	{
		return delegate371_1(object_0, object_1);
	}

	// Token: 0x06001DA2 RID: 7586
	public extern Delegate371(object object_0, IntPtr intptr_0);

	// Token: 0x06001DA3 RID: 7587 RVA: 0x0000A62A File Offset: 0x0000882A
	static Delegate371()
	{
		Class15.smethod_14(typeof(Delegate371).TypeHandle);
	}

	// Token: 0x04000B53 RID: 2899
	internal static Delegate371 delegate371_0;
}
