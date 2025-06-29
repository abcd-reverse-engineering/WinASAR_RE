using System;
using System.Text;

// Token: 0x02000317 RID: 791
internal sealed class Delegate263 : MulticastDelegate
{
	// Token: 0x06001BF0 RID: 7152
	public extern Encoding Invoke();

	// Token: 0x06001BF1 RID: 7153 RVA: 0x00009B2D File Offset: 0x00007D2D
	public static Encoding smethod_0(Delegate263 delegate263_1)
	{
		return delegate263_1();
	}

	// Token: 0x06001BF2 RID: 7154
	public extern Delegate263(object object_0, IntPtr intptr_0);

	// Token: 0x06001BF3 RID: 7155 RVA: 0x00009B36 File Offset: 0x00007D36
	static Delegate263()
	{
		Class15.smethod_14(typeof(Delegate263).TypeHandle);
	}

	// Token: 0x04000AE7 RID: 2791
	internal static Delegate263 delegate263_0;
}
