using System;

// Token: 0x0200030D RID: 781
internal sealed class Delegate253 : MulticastDelegate
{
	// Token: 0x06001BC8 RID: 7112
	public extern Delegate Invoke(Delegate delegate_0, Delegate delegate_1);

	// Token: 0x06001BC9 RID: 7113 RVA: 0x00009A41 File Offset: 0x00007C41
	public static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1, Delegate253 delegate253_1)
	{
		return delegate253_1(delegate_0, delegate_1);
	}

	// Token: 0x06001BCA RID: 7114
	public extern Delegate253(object object_0, IntPtr intptr_0);

	// Token: 0x06001BCB RID: 7115 RVA: 0x00009A4E File Offset: 0x00007C4E
	static Delegate253()
	{
		Class15.smethod_14(typeof(Delegate253).TypeHandle);
	}

	// Token: 0x04000ADD RID: 2781
	internal static Delegate253 delegate253_0;
}
