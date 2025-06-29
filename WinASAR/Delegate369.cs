using System;

// Token: 0x02000381 RID: 897
internal sealed class Delegate369 : MulticastDelegate
{
	// Token: 0x06001D98 RID: 7576
	public extern bool Invoke(object object_0, string string_0, StringComparison stringComparison_0);

	// Token: 0x06001D99 RID: 7577 RVA: 0x0000A5E9 File Offset: 0x000087E9
	public static bool smethod_0(object object_0, string string_0, StringComparison stringComparison_0, Delegate369 delegate369_1)
	{
		return delegate369_1(object_0, string_0, stringComparison_0);
	}

	// Token: 0x06001D9A RID: 7578
	public extern Delegate369(object object_0, IntPtr intptr_0);

	// Token: 0x06001D9B RID: 7579 RVA: 0x0000A5F8 File Offset: 0x000087F8
	static Delegate369()
	{
		Class15.smethod_14(typeof(Delegate369).TypeHandle);
	}

	// Token: 0x04000B51 RID: 2897
	internal static Delegate369 delegate369_0;
}
