using System;

// Token: 0x0200023E RID: 574
internal sealed class Delegate46 : MulticastDelegate
{
	// Token: 0x0600188C RID: 6284
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600188D RID: 6285 RVA: 0x000085CD File Offset: 0x000067CD
	public static void smethod_0(object object_0, string string_0, Delegate46 delegate46_1)
	{
		delegate46_1(object_0, string_0);
	}

	// Token: 0x0600188E RID: 6286
	public extern Delegate46(object object_0, IntPtr intptr_0);

	// Token: 0x0600188F RID: 6287 RVA: 0x000085DA File Offset: 0x000067DA
	static Delegate46()
	{
		Class15.smethod_14(typeof(Delegate46).TypeHandle);
	}

	// Token: 0x04000A0E RID: 2574
	internal static Delegate46 delegate46_0;
}
