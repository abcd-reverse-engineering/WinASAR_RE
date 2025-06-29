using System;

// Token: 0x02000332 RID: 818
internal sealed class Delegate290 : MulticastDelegate
{
	// Token: 0x06001C5C RID: 7260
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001C5D RID: 7261 RVA: 0x00009DD9 File Offset: 0x00007FD9
	public static void smethod_0(object object_0, string string_0, Delegate290 delegate290_1)
	{
		delegate290_1(object_0, string_0);
	}

	// Token: 0x06001C5E RID: 7262
	public extern Delegate290(object object_0, IntPtr intptr_0);

	// Token: 0x06001C5F RID: 7263 RVA: 0x00009DE6 File Offset: 0x00007FE6
	static Delegate290()
	{
		Class15.smethod_14(typeof(Delegate290).TypeHandle);
	}

	// Token: 0x04000B02 RID: 2818
	internal static Delegate290 delegate290_0;
}
