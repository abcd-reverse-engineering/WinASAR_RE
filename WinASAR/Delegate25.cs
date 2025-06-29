using System;

// Token: 0x02000229 RID: 553
internal sealed class Delegate25 : MulticastDelegate
{
	// Token: 0x06001838 RID: 6200
	public extern string Invoke();

	// Token: 0x06001839 RID: 6201 RVA: 0x000083C5 File Offset: 0x000065C5
	public static string smethod_0(Delegate25 delegate25_1)
	{
		return delegate25_1();
	}

	// Token: 0x0600183A RID: 6202
	public extern Delegate25(object object_0, IntPtr intptr_0);

	// Token: 0x0600183B RID: 6203 RVA: 0x000083CE File Offset: 0x000065CE
	static Delegate25()
	{
		Class15.smethod_14(typeof(Delegate25).TypeHandle);
	}

	// Token: 0x040009F9 RID: 2553
	internal static Delegate25 delegate25_0;
}
