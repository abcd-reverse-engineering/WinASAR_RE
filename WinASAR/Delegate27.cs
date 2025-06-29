using System;

// Token: 0x0200022B RID: 555
internal sealed class Delegate27 : MulticastDelegate
{
	// Token: 0x06001840 RID: 6208
	public extern string Invoke();

	// Token: 0x06001841 RID: 6209 RVA: 0x000083F5 File Offset: 0x000065F5
	public static string smethod_0(Delegate27 delegate27_1)
	{
		return delegate27_1();
	}

	// Token: 0x06001842 RID: 6210
	public extern Delegate27(object object_0, IntPtr intptr_0);

	// Token: 0x06001843 RID: 6211 RVA: 0x000083FE File Offset: 0x000065FE
	static Delegate27()
	{
		Class15.smethod_14(typeof(Delegate27).TypeHandle);
	}

	// Token: 0x040009FB RID: 2555
	internal static Delegate27 delegate27_0;
}
