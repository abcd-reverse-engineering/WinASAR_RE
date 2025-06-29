using System;
using System.Text;

// Token: 0x02000310 RID: 784
internal sealed class Delegate256 : MulticastDelegate
{
	// Token: 0x06001BD4 RID: 7124
	public extern Encoding Invoke();

	// Token: 0x06001BD5 RID: 7125 RVA: 0x00009A8D File Offset: 0x00007C8D
	public static Encoding smethod_0(Delegate256 delegate256_1)
	{
		return delegate256_1();
	}

	// Token: 0x06001BD6 RID: 7126
	public extern Delegate256(object object_0, IntPtr intptr_0);

	// Token: 0x06001BD7 RID: 7127 RVA: 0x00009A96 File Offset: 0x00007C96
	static Delegate256()
	{
		Class15.smethod_14(typeof(Delegate256).TypeHandle);
	}

	// Token: 0x04000AE0 RID: 2784
	internal static Delegate256 delegate256_0;
}
