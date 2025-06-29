using System;

// Token: 0x020002F7 RID: 759
internal sealed class Delegate231 : MulticastDelegate
{
	// Token: 0x06001B70 RID: 7024
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001B71 RID: 7025 RVA: 0x00009809 File Offset: 0x00007A09
	public static void smethod_0(object object_0, bool bool_0, Delegate231 delegate231_1)
	{
		delegate231_1(object_0, bool_0);
	}

	// Token: 0x06001B72 RID: 7026
	public extern Delegate231(object object_0, IntPtr intptr_0);

	// Token: 0x06001B73 RID: 7027 RVA: 0x00009816 File Offset: 0x00007A16
	static Delegate231()
	{
		Class15.smethod_14(typeof(Delegate231).TypeHandle);
	}

	// Token: 0x04000AC7 RID: 2759
	internal static Delegate231 delegate231_0;
}
