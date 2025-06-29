using System;
using System.Reflection.Emit;

// Token: 0x02000445 RID: 1093
internal sealed class Delegate565 : MulticastDelegate
{
	// Token: 0x060020A8 RID: 8360
	public extern LocalBuilder Invoke(object object_0, Type type_0);

	// Token: 0x060020A9 RID: 8361 RVA: 0x0000B9A5 File Offset: 0x00009BA5
	public static LocalBuilder smethod_0(object object_0, Type type_0, Delegate565 delegate565_0)
	{
		return delegate565_0(object_0, type_0);
	}

	// Token: 0x060020AA RID: 8362
	public extern Delegate565(object object_0, IntPtr intptr_0);

	// Token: 0x060020AB RID: 8363 RVA: 0x0000B9B2 File Offset: 0x00009BB2
	static Delegate565()
	{
		Class15.smethod_14(typeof(Delegate565).TypeHandle);
	}

	// Token: 0x04000C15 RID: 3093
	internal static Delegate565 XbfKdfyhbZ;
}
