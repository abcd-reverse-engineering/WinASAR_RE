using System;

// Token: 0x020002C8 RID: 712
internal sealed class Delegate184 : MulticastDelegate
{
	// Token: 0x06001AB4 RID: 6836
	public extern string Invoke(object object_0);

	// Token: 0x06001AB5 RID: 6837 RVA: 0x00009365 File Offset: 0x00007565
	public static string smethod_0(object object_0, Delegate184 delegate184_1)
	{
		return delegate184_1(object_0);
	}

	// Token: 0x06001AB6 RID: 6838
	public extern Delegate184(object object_0, IntPtr intptr_0);

	// Token: 0x06001AB7 RID: 6839 RVA: 0x00009370 File Offset: 0x00007570
	static Delegate184()
	{
		Class15.smethod_14(typeof(Delegate184).TypeHandle);
	}

	// Token: 0x04000A98 RID: 2712
	internal static Delegate184 delegate184_0;
}
