using System;

// Token: 0x02000600 RID: 1536
internal sealed class Delegate1008 : MulticastDelegate
{
	// Token: 0x06002794 RID: 10132
	public extern void Invoke(object object_0, long long_0);

	// Token: 0x06002795 RID: 10133 RVA: 0x0000E598 File Offset: 0x0000C798
	public static void smethod_0(object object_0, long long_0, Delegate1008 delegate1008_1)
	{
		delegate1008_1(object_0, long_0);
	}

	// Token: 0x06002796 RID: 10134
	public extern Delegate1008(object object_0, IntPtr intptr_0);

	// Token: 0x06002797 RID: 10135 RVA: 0x0000E5A5 File Offset: 0x0000C7A5
	static Delegate1008()
	{
		Class15.smethod_14(typeof(Delegate1008).TypeHandle);
	}

	// Token: 0x04000DD0 RID: 3536
	internal static Delegate1008 delegate1008_0;
}
