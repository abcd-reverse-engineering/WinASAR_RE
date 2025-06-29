using System;

// Token: 0x0200049C RID: 1180
internal sealed class Delegate652 : MulticastDelegate
{
	// Token: 0x06002204 RID: 8708
	public extern string Invoke(object object_0);

	// Token: 0x06002205 RID: 8709 RVA: 0x0000C261 File Offset: 0x0000A461
	public static string smethod_0(object object_0, Delegate652 delegate652_1)
	{
		return delegate652_1(object_0);
	}

	// Token: 0x06002206 RID: 8710
	public extern Delegate652(object object_0, IntPtr intptr_0);

	// Token: 0x06002207 RID: 8711 RVA: 0x0000C26C File Offset: 0x0000A46C
	static Delegate652()
	{
		Class15.smethod_14(typeof(Delegate652).TypeHandle);
	}

	// Token: 0x04000C6C RID: 3180
	internal static Delegate652 delegate652_0;
}
