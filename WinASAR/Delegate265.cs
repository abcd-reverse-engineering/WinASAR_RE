using System;

// Token: 0x02000319 RID: 793
internal sealed class Delegate265 : MulticastDelegate
{
	// Token: 0x06001BF8 RID: 7160
	public extern void Invoke(object object_0);

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00009B5B File Offset: 0x00007D5B
	public static void smethod_0(object object_0, Delegate265 delegate265_1)
	{
		delegate265_1(object_0);
	}

	// Token: 0x06001BFA RID: 7162
	public extern Delegate265(object object_0, IntPtr intptr_0);

	// Token: 0x06001BFB RID: 7163 RVA: 0x00009B66 File Offset: 0x00007D66
	static Delegate265()
	{
		Class15.smethod_14(typeof(Delegate265).TypeHandle);
	}

	// Token: 0x04000AE9 RID: 2793
	internal static Delegate265 delegate265_0;
}
