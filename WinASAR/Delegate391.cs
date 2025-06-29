using System;

// Token: 0x02000397 RID: 919
internal sealed class Delegate391 : MulticastDelegate
{
	// Token: 0x06001DF0 RID: 7664
	public extern void Invoke(object object_0);

	// Token: 0x06001DF1 RID: 7665 RVA: 0x0000A81D File Offset: 0x00008A1D
	public static void smethod_0(object object_0, Delegate391 delegate391_1)
	{
		delegate391_1(object_0);
	}

	// Token: 0x06001DF2 RID: 7666
	public extern Delegate391(object object_0, IntPtr intptr_0);

	// Token: 0x06001DF3 RID: 7667 RVA: 0x0000A828 File Offset: 0x00008A28
	static Delegate391()
	{
		Class15.smethod_14(typeof(Delegate391).TypeHandle);
	}

	// Token: 0x04000B67 RID: 2919
	internal static Delegate391 delegate391_0;
}
