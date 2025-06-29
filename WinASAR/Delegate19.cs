using System;

// Token: 0x02000223 RID: 547
internal sealed class Delegate19 : MulticastDelegate
{
	// Token: 0x06001820 RID: 6176
	public extern string Invoke();

	// Token: 0x06001821 RID: 6177 RVA: 0x00008333 File Offset: 0x00006533
	public static string smethod_0(Delegate19 delegate19_1)
	{
		return delegate19_1();
	}

	// Token: 0x06001822 RID: 6178
	public extern Delegate19(object object_0, IntPtr intptr_0);

	// Token: 0x06001823 RID: 6179 RVA: 0x0000833C File Offset: 0x0000653C
	static Delegate19()
	{
		Class15.smethod_14(typeof(Delegate19).TypeHandle);
	}

	// Token: 0x040009F3 RID: 2547
	internal static Delegate19 delegate19_0;
}
