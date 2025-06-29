using System;

// Token: 0x020002CE RID: 718
internal sealed class Delegate190 : MulticastDelegate
{
	// Token: 0x06001ACC RID: 6860
	public extern string Invoke(object object_0);

	// Token: 0x06001ACD RID: 6861 RVA: 0x000093FD File Offset: 0x000075FD
	public static string smethod_0(object object_0, Delegate190 delegate190_1)
	{
		return delegate190_1(object_0);
	}

	// Token: 0x06001ACE RID: 6862
	public extern Delegate190(object object_0, IntPtr intptr_0);

	// Token: 0x06001ACF RID: 6863 RVA: 0x00009408 File Offset: 0x00007608
	static Delegate190()
	{
		Class15.smethod_14(typeof(Delegate190).TypeHandle);
	}

	// Token: 0x04000A9E RID: 2718
	internal static Delegate190 delegate190_0;
}
