using System;

// Token: 0x020003A9 RID: 937
internal sealed class Delegate409 : MulticastDelegate
{
	// Token: 0x06001E38 RID: 7736
	public extern long Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001E39 RID: 7737 RVA: 0x0000A9ED File Offset: 0x00008BED
	public static long smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate409 delegate409_1)
	{
		return delegate409_1(object_0, iformatProvider_0);
	}

	// Token: 0x06001E3A RID: 7738
	public extern Delegate409(object object_0, IntPtr intptr_0);

	// Token: 0x06001E3B RID: 7739 RVA: 0x0000A9FA File Offset: 0x00008BFA
	static Delegate409()
	{
		Class15.smethod_14(typeof(Delegate409).TypeHandle);
	}

	// Token: 0x04000B79 RID: 2937
	internal static Delegate409 delegate409_0;
}
