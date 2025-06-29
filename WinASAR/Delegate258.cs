using System;
using System.Text;

// Token: 0x02000312 RID: 786
internal sealed class Delegate258 : MulticastDelegate
{
	// Token: 0x06001BDC RID: 7132
	public extern Encoding Invoke();

	// Token: 0x06001BDD RID: 7133 RVA: 0x00009ABB File Offset: 0x00007CBB
	public static Encoding smethod_0(Delegate258 delegate258_1)
	{
		return delegate258_1();
	}

	// Token: 0x06001BDE RID: 7134
	public extern Delegate258(object object_0, IntPtr intptr_0);

	// Token: 0x06001BDF RID: 7135 RVA: 0x00009AC4 File Offset: 0x00007CC4
	static Delegate258()
	{
		Class15.smethod_14(typeof(Delegate258).TypeHandle);
	}

	// Token: 0x04000AE2 RID: 2786
	internal static Delegate258 delegate258_0;
}
