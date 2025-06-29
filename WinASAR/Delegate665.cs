using System;

// Token: 0x020004A9 RID: 1193
internal sealed class Delegate665 : MulticastDelegate
{
	// Token: 0x06002238 RID: 8760
	public extern bool Invoke(object object_0);

	// Token: 0x06002239 RID: 8761 RVA: 0x0000C3A5 File Offset: 0x0000A5A5
	public static bool smethod_0(object object_0, Delegate665 delegate665_1)
	{
		return delegate665_1(object_0);
	}

	// Token: 0x0600223A RID: 8762
	public extern Delegate665(object object_0, IntPtr intptr_0);

	// Token: 0x0600223B RID: 8763 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
	static Delegate665()
	{
		Class15.smethod_14(typeof(Delegate665).TypeHandle);
	}

	// Token: 0x04000C79 RID: 3193
	internal static Delegate665 delegate665_0;
}
