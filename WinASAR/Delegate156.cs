using System;

// Token: 0x020002AC RID: 684
internal sealed class Delegate156 : MulticastDelegate
{
	// Token: 0x06001A44 RID: 6724
	public extern object Invoke(object object_0);

	// Token: 0x06001A45 RID: 6725 RVA: 0x000090A3 File Offset: 0x000072A3
	public static object smethod_0(object object_0, Delegate156 delegate156_1)
	{
		return delegate156_1(object_0);
	}

	// Token: 0x06001A46 RID: 6726
	public extern Delegate156(object object_0, IntPtr intptr_0);

	// Token: 0x06001A47 RID: 6727 RVA: 0x000090AE File Offset: 0x000072AE
	static Delegate156()
	{
		Class15.smethod_14(typeof(Delegate156).TypeHandle);
	}

	// Token: 0x04000A7C RID: 2684
	internal static Delegate156 delegate156_0;
}
