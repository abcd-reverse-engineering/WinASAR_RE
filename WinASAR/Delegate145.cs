using System;

// Token: 0x020002A1 RID: 673
internal sealed class Delegate145 : MulticastDelegate
{
	// Token: 0x06001A18 RID: 6680
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001A19 RID: 6681 RVA: 0x00008F89 File Offset: 0x00007189
	public static void smethod_0(object object_0, bool bool_0, Delegate145 delegate145_1)
	{
		delegate145_1(object_0, bool_0);
	}

	// Token: 0x06001A1A RID: 6682
	public extern Delegate145(object object_0, IntPtr intptr_0);

	// Token: 0x06001A1B RID: 6683 RVA: 0x00008F96 File Offset: 0x00007196
	static Delegate145()
	{
		Class15.smethod_14(typeof(Delegate145).TypeHandle);
	}

	// Token: 0x04000A71 RID: 2673
	internal static Delegate145 delegate145_0;
}
