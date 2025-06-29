using System;

// Token: 0x020002D9 RID: 729
internal sealed class Delegate201 : MulticastDelegate
{
	// Token: 0x06001AF8 RID: 6904
	public extern void Invoke(string string_0, string string_1);

	// Token: 0x06001AF9 RID: 6905 RVA: 0x00009513 File Offset: 0x00007713
	public static void smethod_0(string string_0, string string_1, Delegate201 delegate201_1)
	{
		delegate201_1(string_0, string_1);
	}

	// Token: 0x06001AFA RID: 6906
	public extern Delegate201(object object_0, IntPtr intptr_0);

	// Token: 0x06001AFB RID: 6907 RVA: 0x00009520 File Offset: 0x00007720
	static Delegate201()
	{
		Class15.smethod_14(typeof(Delegate201).TypeHandle);
	}

	// Token: 0x04000AA9 RID: 2729
	internal static Delegate201 delegate201_0;
}
