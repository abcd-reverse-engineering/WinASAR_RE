using System;

// Token: 0x0200031C RID: 796
internal sealed class Delegate268 : MulticastDelegate
{
	// Token: 0x06001C04 RID: 7172
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001C05 RID: 7173 RVA: 0x00009BA7 File Offset: 0x00007DA7
	public static void smethod_0(object object_0, int int_0, Delegate268 delegate268_1)
	{
		delegate268_1(object_0, int_0);
	}

	// Token: 0x06001C06 RID: 7174
	public extern Delegate268(object object_0, IntPtr intptr_0);

	// Token: 0x06001C07 RID: 7175 RVA: 0x00009BB4 File Offset: 0x00007DB4
	static Delegate268()
	{
		Class15.smethod_14(typeof(Delegate268).TypeHandle);
	}

	// Token: 0x04000AEC RID: 2796
	internal static Delegate268 delegate268_0;
}
