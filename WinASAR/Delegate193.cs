using System;

// Token: 0x020002D1 RID: 721
internal sealed class Delegate193 : MulticastDelegate
{
	// Token: 0x06001AD8 RID: 6872
	public extern int Invoke(object object_0);

	// Token: 0x06001AD9 RID: 6873 RVA: 0x0000944B File Offset: 0x0000764B
	public static int smethod_0(object object_0, Delegate193 delegate193_1)
	{
		return delegate193_1(object_0);
	}

	// Token: 0x06001ADA RID: 6874
	public extern Delegate193(object object_0, IntPtr intptr_0);

	// Token: 0x06001ADB RID: 6875 RVA: 0x00009456 File Offset: 0x00007656
	static Delegate193()
	{
		Class15.smethod_14(typeof(Delegate193).TypeHandle);
	}

	// Token: 0x04000AA1 RID: 2721
	internal static Delegate193 delegate193_0;
}
