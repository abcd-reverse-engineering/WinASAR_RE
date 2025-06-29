using System;
using System.Text;

// Token: 0x020005DA RID: 1498
internal sealed class Delegate970 : MulticastDelegate
{
	// Token: 0x060026FC RID: 9980
	public extern StringBuilder Invoke(object object_0, char[] char_0, int int_0, int int_1);

	// Token: 0x060026FD RID: 9981 RVA: 0x0000E1AC File Offset: 0x0000C3AC
	public static StringBuilder smethod_0(object object_0, char[] char_0, int int_0, int int_1, Delegate970 delegate970_1)
	{
		return delegate970_1(object_0, char_0, int_0, int_1);
	}

	// Token: 0x060026FE RID: 9982
	public extern Delegate970(object object_0, IntPtr intptr_0);

	// Token: 0x060026FF RID: 9983 RVA: 0x0000E1BD File Offset: 0x0000C3BD
	static Delegate970()
	{
		Class15.smethod_14(typeof(Delegate970).TypeHandle);
	}

	// Token: 0x04000DAA RID: 3498
	internal static Delegate970 delegate970_0;
}
