using System;

// Token: 0x020002D4 RID: 724
internal sealed class Delegate196 : MulticastDelegate
{
	// Token: 0x06001AE4 RID: 6884
	public extern bool Invoke(object object_0, int int_0, int int_1);

	// Token: 0x06001AE5 RID: 6885 RVA: 0x00009493 File Offset: 0x00007693
	public static bool smethod_0(object object_0, int int_0, int int_1, Delegate196 delegate196_1)
	{
		return delegate196_1(object_0, int_0, int_1);
	}

	// Token: 0x06001AE6 RID: 6886
	public extern Delegate196(object object_0, IntPtr intptr_0);

	// Token: 0x06001AE7 RID: 6887 RVA: 0x000094A2 File Offset: 0x000076A2
	static Delegate196()
	{
		Class15.smethod_14(typeof(Delegate196).TypeHandle);
	}

	// Token: 0x04000AA4 RID: 2724
	internal static Delegate196 delegate196_0;
}
