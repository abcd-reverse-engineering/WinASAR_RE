using System;

// Token: 0x020002BD RID: 701
internal sealed class Delegate173 : MulticastDelegate
{
	// Token: 0x06001A88 RID: 6792
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001A89 RID: 6793 RVA: 0x0000924F File Offset: 0x0000744F
	public static void smethod_0(object object_0, bool bool_0, Delegate173 delegate173_1)
	{
		delegate173_1(object_0, bool_0);
	}

	// Token: 0x06001A8A RID: 6794
	public extern Delegate173(object object_0, IntPtr intptr_0);

	// Token: 0x06001A8B RID: 6795 RVA: 0x0000925C File Offset: 0x0000745C
	static Delegate173()
	{
		Class15.smethod_14(typeof(Delegate173).TypeHandle);
	}

	// Token: 0x04000A8D RID: 2701
	internal static Delegate173 delegate173_0;
}
