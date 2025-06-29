using System;

// Token: 0x020004C6 RID: 1222
internal sealed class Delegate694 : MulticastDelegate
{
	// Token: 0x060022AC RID: 8876
	public extern bool Invoke(object object_0);

	// Token: 0x060022AD RID: 8877 RVA: 0x0000C68E File Offset: 0x0000A88E
	public static bool smethod_0(object object_0, Delegate694 delegate694_1)
	{
		return delegate694_1(object_0);
	}

	// Token: 0x060022AE RID: 8878
	public extern Delegate694(object object_0, IntPtr intptr_0);

	// Token: 0x060022AF RID: 8879 RVA: 0x0000C699 File Offset: 0x0000A899
	static Delegate694()
	{
		Class15.smethod_14(typeof(Delegate694).TypeHandle);
	}

	// Token: 0x04000C96 RID: 3222
	internal static Delegate694 delegate694_0;
}
