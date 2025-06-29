using System;

// Token: 0x020004C2 RID: 1218
internal sealed class Delegate690 : MulticastDelegate
{
	// Token: 0x0600229C RID: 8860
	public extern int Invoke(object object_0, char char_0);

	// Token: 0x0600229D RID: 8861 RVA: 0x0000C628 File Offset: 0x0000A828
	public static int smethod_0(object object_0, char char_0, Delegate690 delegate690_1)
	{
		return delegate690_1(object_0, char_0);
	}

	// Token: 0x0600229E RID: 8862
	public extern Delegate690(object object_0, IntPtr intptr_0);

	// Token: 0x0600229F RID: 8863 RVA: 0x0000C635 File Offset: 0x0000A835
	static Delegate690()
	{
		Class15.smethod_14(typeof(Delegate690).TypeHandle);
	}

	// Token: 0x04000C92 RID: 3218
	internal static Delegate690 delegate690_0;
}
