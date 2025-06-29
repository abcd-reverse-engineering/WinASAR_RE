using System;

// Token: 0x02000237 RID: 567
internal sealed class Delegate39 : MulticastDelegate
{
	// Token: 0x06001870 RID: 6256
	public extern void Invoke(object object_0);

	// Token: 0x06001871 RID: 6257 RVA: 0x0000851D File Offset: 0x0000671D
	public static void smethod_0(object object_0, Delegate39 delegate39_1)
	{
		delegate39_1(object_0);
	}

	// Token: 0x06001872 RID: 6258
	public extern Delegate39(object object_0, IntPtr intptr_0);

	// Token: 0x06001873 RID: 6259 RVA: 0x00008528 File Offset: 0x00006728
	static Delegate39()
	{
		Class15.smethod_14(typeof(Delegate39).TypeHandle);
	}

	// Token: 0x04000A07 RID: 2567
	internal static Delegate39 delegate39_0;
}
