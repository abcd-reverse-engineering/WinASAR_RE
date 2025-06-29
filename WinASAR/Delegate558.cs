using System;
using System.Reflection.Emit;

// Token: 0x0200043E RID: 1086
internal sealed class Delegate558 : MulticastDelegate
{
	// Token: 0x0600208C RID: 8332
	public extern void Invoke(object object_0, OpCode opCode_0);

	// Token: 0x0600208D RID: 8333 RVA: 0x0000B8EF File Offset: 0x00009AEF
	public static void smethod_0(object object_0, OpCode opCode_0, Delegate558 delegate558_1)
	{
		delegate558_1(object_0, opCode_0);
	}

	// Token: 0x0600208E RID: 8334
	public extern Delegate558(object object_0, IntPtr intptr_0);

	// Token: 0x0600208F RID: 8335 RVA: 0x0000B8FC File Offset: 0x00009AFC
	static Delegate558()
	{
		Class15.smethod_14(typeof(Delegate558).TypeHandle);
	}

	// Token: 0x04000C0E RID: 3086
	internal static Delegate558 delegate558_0;
}
