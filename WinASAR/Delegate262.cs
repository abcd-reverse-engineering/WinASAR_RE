using System;
using System.Text;

// Token: 0x02000316 RID: 790
internal sealed class Delegate262 : MulticastDelegate
{
	// Token: 0x06001BEC RID: 7148
	public extern Encoding Invoke();

	// Token: 0x06001BED RID: 7149 RVA: 0x00009B17 File Offset: 0x00007D17
	public static Encoding smethod_0(Delegate262 delegate262_1)
	{
		return delegate262_1();
	}

	// Token: 0x06001BEE RID: 7150
	public extern Delegate262(object object_0, IntPtr intptr_0);

	// Token: 0x06001BEF RID: 7151 RVA: 0x00009B20 File Offset: 0x00007D20
	static Delegate262()
	{
		Class15.smethod_14(typeof(Delegate262).TypeHandle);
	}

	// Token: 0x04000AE6 RID: 2790
	internal static Delegate262 delegate262_0;
}
