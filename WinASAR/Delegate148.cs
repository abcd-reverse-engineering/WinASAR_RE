using System;

// Token: 0x020002A4 RID: 676
internal sealed class Delegate148 : MulticastDelegate
{
	// Token: 0x06001A24 RID: 6692
	public extern string Invoke(string string_0);

	// Token: 0x06001A25 RID: 6693 RVA: 0x00008FD3 File Offset: 0x000071D3
	public static string smethod_0(string string_0, Delegate148 delegate148_1)
	{
		return delegate148_1(string_0);
	}

	// Token: 0x06001A26 RID: 6694
	public extern Delegate148(object object_0, IntPtr intptr_0);

	// Token: 0x06001A27 RID: 6695 RVA: 0x00008FDE File Offset: 0x000071DE
	static Delegate148()
	{
		Class15.smethod_14(typeof(Delegate148).TypeHandle);
	}

	// Token: 0x04000A74 RID: 2676
	internal static Delegate148 delegate148_0;
}
