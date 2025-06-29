using System;

// Token: 0x0200049E RID: 1182
internal sealed class Delegate654 : MulticastDelegate
{
	// Token: 0x0600220C RID: 8716
	public extern bool Invoke(object object_0);

	// Token: 0x0600220D RID: 8717 RVA: 0x0000C293 File Offset: 0x0000A493
	public static bool smethod_0(object object_0, Delegate654 delegate654_1)
	{
		return delegate654_1(object_0);
	}

	// Token: 0x0600220E RID: 8718
	public extern Delegate654(object object_0, IntPtr intptr_0);

	// Token: 0x0600220F RID: 8719 RVA: 0x0000C29E File Offset: 0x0000A49E
	static Delegate654()
	{
		Class15.smethod_14(typeof(Delegate654).TypeHandle);
	}

	// Token: 0x04000C6E RID: 3182
	internal static Delegate654 delegate654_0;
}
