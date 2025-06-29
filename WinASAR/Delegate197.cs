using System;

// Token: 0x020002D5 RID: 725
internal sealed class Delegate197 : MulticastDelegate
{
	// Token: 0x06001AE8 RID: 6888
	public extern int Invoke(object object_0);

	// Token: 0x06001AE9 RID: 6889 RVA: 0x000094AF File Offset: 0x000076AF
	public static int smethod_0(object object_0, Delegate197 delegate197_1)
	{
		return delegate197_1(object_0);
	}

	// Token: 0x06001AEA RID: 6890
	public extern Delegate197(object object_0, IntPtr intptr_0);

	// Token: 0x06001AEB RID: 6891 RVA: 0x000094BA File Offset: 0x000076BA
	static Delegate197()
	{
		Class15.smethod_14(typeof(Delegate197).TypeHandle);
	}

	// Token: 0x04000AA5 RID: 2725
	internal static Delegate197 delegate197_0;
}
