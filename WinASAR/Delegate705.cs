using System;

// Token: 0x020004D1 RID: 1233
internal sealed class Delegate705 : MulticastDelegate
{
	// Token: 0x060022D8 RID: 8920
	public extern bool Invoke(object object_0);

	// Token: 0x060022D9 RID: 8921 RVA: 0x0000C796 File Offset: 0x0000A996
	public static bool smethod_0(object object_0, Delegate705 delegate705_1)
	{
		return delegate705_1(object_0);
	}

	// Token: 0x060022DA RID: 8922
	public extern Delegate705(object object_0, IntPtr intptr_0);

	// Token: 0x060022DB RID: 8923 RVA: 0x0000C7A1 File Offset: 0x0000A9A1
	static Delegate705()
	{
		Class15.smethod_14(typeof(Delegate705).TypeHandle);
	}

	// Token: 0x04000CA1 RID: 3233
	internal static Delegate705 delegate705_0;
}
