using System;

// Token: 0x02000266 RID: 614
internal sealed class Delegate86 : MulticastDelegate
{
	// Token: 0x0600192C RID: 6444
	public extern string Invoke(object object_0);

	// Token: 0x0600192D RID: 6445 RVA: 0x000089C9 File Offset: 0x00006BC9
	public static string smethod_0(object object_0, Delegate86 delegate86_1)
	{
		return delegate86_1(object_0);
	}

	// Token: 0x0600192E RID: 6446
	public extern Delegate86(object object_0, IntPtr intptr_0);

	// Token: 0x0600192F RID: 6447 RVA: 0x000089D4 File Offset: 0x00006BD4
	static Delegate86()
	{
		Class15.smethod_14(typeof(Delegate86).TypeHandle);
	}

	// Token: 0x04000A36 RID: 2614
	internal static Delegate86 delegate86_0;
}
