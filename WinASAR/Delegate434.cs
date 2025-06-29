using System;

// Token: 0x020003C2 RID: 962
internal sealed class Delegate434 : MulticastDelegate
{
	// Token: 0x06001E9C RID: 7836
	public extern bool Invoke(object object_0);

	// Token: 0x06001E9D RID: 7837 RVA: 0x0000AC77 File Offset: 0x00008E77
	public static bool smethod_0(object object_0, Delegate434 delegate434_1)
	{
		return delegate434_1(object_0);
	}

	// Token: 0x06001E9E RID: 7838
	public extern Delegate434(object object_0, IntPtr intptr_0);

	// Token: 0x06001E9F RID: 7839 RVA: 0x0000AC82 File Offset: 0x00008E82
	static Delegate434()
	{
		Class15.smethod_14(typeof(Delegate434).TypeHandle);
	}

	// Token: 0x04000B92 RID: 2962
	internal static Delegate434 delegate434_0;
}
