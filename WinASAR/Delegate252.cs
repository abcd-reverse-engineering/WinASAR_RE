using System;

// Token: 0x0200030C RID: 780
internal sealed class Delegate252 : MulticastDelegate
{
	// Token: 0x06001BC4 RID: 7108
	public extern Delegate Invoke(Delegate delegate_0, Delegate delegate_1);

	// Token: 0x06001BC5 RID: 7109 RVA: 0x00009A27 File Offset: 0x00007C27
	public static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1, Delegate252 delegate252_1)
	{
		return delegate252_1(delegate_0, delegate_1);
	}

	// Token: 0x06001BC6 RID: 7110
	public extern Delegate252(object object_0, IntPtr intptr_0);

	// Token: 0x06001BC7 RID: 7111 RVA: 0x00009A34 File Offset: 0x00007C34
	static Delegate252()
	{
		Class15.smethod_14(typeof(Delegate252).TypeHandle);
	}

	// Token: 0x04000ADC RID: 2780
	internal static Delegate252 delegate252_0;
}
