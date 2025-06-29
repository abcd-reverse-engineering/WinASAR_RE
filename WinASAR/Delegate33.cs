using System;

// Token: 0x02000231 RID: 561
internal sealed class Delegate33 : MulticastDelegate
{
	// Token: 0x06001858 RID: 6232
	public extern void Invoke(string string_0);

	// Token: 0x06001859 RID: 6233 RVA: 0x00008489 File Offset: 0x00006689
	public static void smethod_0(string string_0, Delegate33 delegate33_1)
	{
		delegate33_1(string_0);
	}

	// Token: 0x0600185A RID: 6234
	public extern Delegate33(object object_0, IntPtr intptr_0);

	// Token: 0x0600185B RID: 6235 RVA: 0x00008494 File Offset: 0x00006694
	static Delegate33()
	{
		Class15.smethod_14(typeof(Delegate33).TypeHandle);
	}

	// Token: 0x04000A01 RID: 2561
	internal static Delegate33 delegate33_0;
}
