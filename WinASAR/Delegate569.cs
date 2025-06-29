using System;
using System.Reflection.Emit;

// Token: 0x02000449 RID: 1097
internal sealed class Delegate569 : MulticastDelegate
{
	// Token: 0x060020B8 RID: 8376
	public extern void Invoke(object object_0, OpCode opCode_0, LocalBuilder localBuilder_0);

	// Token: 0x060020B9 RID: 8377 RVA: 0x0000BA07 File Offset: 0x00009C07
	public static void smethod_0(object object_0, OpCode opCode_0, LocalBuilder localBuilder_0, Delegate569 delegate569_1)
	{
		delegate569_1(object_0, opCode_0, localBuilder_0);
	}

	// Token: 0x060020BA RID: 8378
	public extern Delegate569(object object_0, IntPtr intptr_0);

	// Token: 0x060020BB RID: 8379 RVA: 0x0000BA16 File Offset: 0x00009C16
	static Delegate569()
	{
		Class15.smethod_14(typeof(Delegate569).TypeHandle);
	}

	// Token: 0x04000C19 RID: 3097
	internal static Delegate569 delegate569_0;
}
