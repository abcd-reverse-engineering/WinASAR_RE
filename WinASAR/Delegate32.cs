using System;

// Token: 0x02000230 RID: 560
internal sealed class Delegate32 : MulticastDelegate
{
	// Token: 0x06001854 RID: 6228
	public extern string Invoke(object object_0);

	// Token: 0x06001855 RID: 6229 RVA: 0x00008471 File Offset: 0x00006671
	public static string smethod_0(object object_0, Delegate32 delegate32_1)
	{
		return delegate32_1(object_0);
	}

	// Token: 0x06001856 RID: 6230
	public extern Delegate32(object object_0, IntPtr intptr_0);

	// Token: 0x06001857 RID: 6231 RVA: 0x0000847C File Offset: 0x0000667C
	static Delegate32()
	{
		Class15.smethod_14(typeof(Delegate32).TypeHandle);
	}

	// Token: 0x04000A00 RID: 2560
	internal static Delegate32 delegate32_0;
}
