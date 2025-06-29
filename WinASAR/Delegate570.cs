using System;
using System.Reflection.Emit;

// Token: 0x0200044A RID: 1098
internal sealed class Delegate570 : MulticastDelegate
{
	// Token: 0x060020BC RID: 8380
	public extern void Invoke(object object_0, OpCode opCode_0, Type type_0);

	// Token: 0x060020BD RID: 8381 RVA: 0x0000BA23 File Offset: 0x00009C23
	public static void smethod_0(object object_0, OpCode opCode_0, Type type_0, Delegate570 delegate570_1)
	{
		delegate570_1(object_0, opCode_0, type_0);
	}

	// Token: 0x060020BE RID: 8382
	public extern Delegate570(object object_0, IntPtr intptr_0);

	// Token: 0x060020BF RID: 8383 RVA: 0x0000BA32 File Offset: 0x00009C32
	static Delegate570()
	{
		Class15.smethod_14(typeof(Delegate570).TypeHandle);
	}

	// Token: 0x04000C1A RID: 3098
	internal static Delegate570 delegate570_0;
}
