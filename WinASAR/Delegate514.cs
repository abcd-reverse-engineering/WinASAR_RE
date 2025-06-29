using System;

// Token: 0x02000412 RID: 1042
internal sealed class Delegate514 : MulticastDelegate
{
	// Token: 0x06001FDC RID: 8156
	public extern bool Invoke(object object_0, object object_1);

	// Token: 0x06001FDD RID: 8157 RVA: 0x0000B47F File Offset: 0x0000967F
	public static bool smethod_0(object object_0, object object_1, Delegate514 delegate514_1)
	{
		return delegate514_1(object_0, object_1);
	}

	// Token: 0x06001FDE RID: 8158
	public extern Delegate514(object object_0, IntPtr intptr_0);

	// Token: 0x06001FDF RID: 8159 RVA: 0x0000B48C File Offset: 0x0000968C
	static Delegate514()
	{
		Class15.smethod_14(typeof(Delegate514).TypeHandle);
	}

	// Token: 0x04000BE2 RID: 3042
	internal static Delegate514 delegate514_0;
}
