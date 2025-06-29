using System;
using System.Reflection.Emit;

// Token: 0x02000628 RID: 1576
internal sealed class Delegate1048 : MulticastDelegate
{
	// Token: 0x06002834 RID: 10292
	public extern void Invoke(object object_0, OpCode opCode_0, sbyte sbyte_0);

	// Token: 0x06002835 RID: 10293 RVA: 0x0000E97E File Offset: 0x0000CB7E
	public static void smethod_0(object object_0, OpCode opCode_0, sbyte sbyte_0, Delegate1048 delegate1048_1)
	{
		delegate1048_1(object_0, opCode_0, sbyte_0);
	}

	// Token: 0x06002836 RID: 10294
	public extern Delegate1048(object object_0, IntPtr intptr_0);

	// Token: 0x06002837 RID: 10295 RVA: 0x0000E98D File Offset: 0x0000CB8D
	static Delegate1048()
	{
		Class15.smethod_14(typeof(Delegate1048).TypeHandle);
	}

	// Token: 0x04000DF8 RID: 3576
	internal static Delegate1048 delegate1048_0;
}
