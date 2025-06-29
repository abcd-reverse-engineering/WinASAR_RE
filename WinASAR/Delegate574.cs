using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x0200044E RID: 1102
internal sealed class Delegate574 : MulticastDelegate
{
	// Token: 0x060020CC RID: 8396
	public extern void Invoke(object object_0, OpCode opCode_0, MethodInfo methodInfo_0);

	// Token: 0x060020CD RID: 8397 RVA: 0x0000BA8D File Offset: 0x00009C8D
	public static void smethod_0(object object_0, OpCode opCode_0, MethodInfo methodInfo_0, Delegate574 delegate574_1)
	{
		delegate574_1(object_0, opCode_0, methodInfo_0);
	}

	// Token: 0x060020CE RID: 8398
	public extern Delegate574(object object_0, IntPtr intptr_0);

	// Token: 0x060020CF RID: 8399 RVA: 0x0000BA9C File Offset: 0x00009C9C
	static Delegate574()
	{
		Class15.smethod_14(typeof(Delegate574).TypeHandle);
	}

	// Token: 0x04000C1E RID: 3102
	internal static Delegate574 delegate574_0;
}
