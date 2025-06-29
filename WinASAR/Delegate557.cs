using System;
using System.Reflection.Emit;

// Token: 0x0200043D RID: 1085
internal sealed class Delegate557 : MulticastDelegate
{
	// Token: 0x06002088 RID: 8328
	public extern void Invoke(object object_0, OpCode opCode_0, int int_0);

	// Token: 0x06002089 RID: 8329 RVA: 0x0000B8D3 File Offset: 0x00009AD3
	public static void smethod_0(object object_0, OpCode opCode_0, int int_0, Delegate557 delegate557_1)
	{
		delegate557_1(object_0, opCode_0, int_0);
	}

	// Token: 0x0600208A RID: 8330
	public extern Delegate557(object object_0, IntPtr intptr_0);

	// Token: 0x0600208B RID: 8331 RVA: 0x0000B8E2 File Offset: 0x00009AE2
	static Delegate557()
	{
		Class15.smethod_14(typeof(Delegate557).TypeHandle);
	}

	// Token: 0x04000C0D RID: 3085
	internal static Delegate557 delegate557_0;
}
