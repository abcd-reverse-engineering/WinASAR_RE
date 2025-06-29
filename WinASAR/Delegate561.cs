using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000441 RID: 1089
internal sealed class Delegate561 : MulticastDelegate
{
	// Token: 0x06002098 RID: 8344
	public extern void Invoke(object object_0, OpCode opCode_0, ConstructorInfo constructorInfo_0);

	// Token: 0x06002099 RID: 8345 RVA: 0x0000B93F File Offset: 0x00009B3F
	public static void smethod_0(object object_0, OpCode opCode_0, ConstructorInfo constructorInfo_0, Delegate561 delegate561_1)
	{
		delegate561_1(object_0, opCode_0, constructorInfo_0);
	}

	// Token: 0x0600209A RID: 8346
	public extern Delegate561(object object_0, IntPtr intptr_0);

	// Token: 0x0600209B RID: 8347 RVA: 0x0000B94E File Offset: 0x00009B4E
	static Delegate561()
	{
		Class15.smethod_14(typeof(Delegate561).TypeHandle);
	}

	// Token: 0x04000C11 RID: 3089
	internal static Delegate561 delegate561_0;
}
