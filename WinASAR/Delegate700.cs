using System;

// Token: 0x020004CC RID: 1228
internal sealed class Delegate700 : MulticastDelegate
{
	// Token: 0x060022C4 RID: 8900
	public extern bool Invoke(object object_0);

	// Token: 0x060022C5 RID: 8901 RVA: 0x0000C71E File Offset: 0x0000A91E
	public static bool smethod_0(object object_0, Delegate700 delegate700_1)
	{
		return delegate700_1(object_0);
	}

	// Token: 0x060022C6 RID: 8902
	public extern Delegate700(object object_0, IntPtr intptr_0);

	// Token: 0x060022C7 RID: 8903 RVA: 0x0000C729 File Offset: 0x0000A929
	static Delegate700()
	{
		Class15.smethod_14(typeof(Delegate700).TypeHandle);
	}

	// Token: 0x04000C9C RID: 3228
	internal static Delegate700 delegate700_0;
}
