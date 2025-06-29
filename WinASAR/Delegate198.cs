using System;

// Token: 0x020002D6 RID: 726
internal sealed class Delegate198 : MulticastDelegate
{
	// Token: 0x06001AEC RID: 6892
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001AED RID: 6893 RVA: 0x000094C7 File Offset: 0x000076C7
	public static void smethod_0(object object_0, bool bool_0, Delegate198 delegate198_1)
	{
		delegate198_1(object_0, bool_0);
	}

	// Token: 0x06001AEE RID: 6894
	public extern Delegate198(object object_0, IntPtr intptr_0);

	// Token: 0x06001AEF RID: 6895 RVA: 0x000094D4 File Offset: 0x000076D4
	static Delegate198()
	{
		Class15.smethod_14(typeof(Delegate198).TypeHandle);
	}

	// Token: 0x04000AA6 RID: 2726
	internal static Delegate198 delegate198_0;
}
