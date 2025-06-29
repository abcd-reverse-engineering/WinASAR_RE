using System;

// Token: 0x020002A0 RID: 672
internal sealed class Delegate144 : MulticastDelegate
{
	// Token: 0x06001A14 RID: 6676
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001A15 RID: 6677 RVA: 0x00008F6F File Offset: 0x0000716F
	public static void smethod_0(object object_0, bool bool_0, Delegate144 delegate144_1)
	{
		delegate144_1(object_0, bool_0);
	}

	// Token: 0x06001A16 RID: 6678
	public extern Delegate144(object object_0, IntPtr intptr_0);

	// Token: 0x06001A17 RID: 6679 RVA: 0x00008F7C File Offset: 0x0000717C
	static Delegate144()
	{
		Class15.smethod_14(typeof(Delegate144).TypeHandle);
	}

	// Token: 0x04000A70 RID: 2672
	internal static Delegate144 delegate144_0;
}
