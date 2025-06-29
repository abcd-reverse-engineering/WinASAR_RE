using System;
using System.Reflection.Emit;

// Token: 0x0200043F RID: 1087
internal sealed class Delegate559 : MulticastDelegate
{
	// Token: 0x06002090 RID: 8336
	public extern void Invoke(object object_0, OpCode opCode_0, Label label_0);

	// Token: 0x06002091 RID: 8337 RVA: 0x0000B909 File Offset: 0x00009B09
	public static void smethod_0(object object_0, OpCode opCode_0, Label label_0, Delegate559 delegate559_1)
	{
		delegate559_1(object_0, opCode_0, label_0);
	}

	// Token: 0x06002092 RID: 8338
	public extern Delegate559(object object_0, IntPtr intptr_0);

	// Token: 0x06002093 RID: 8339 RVA: 0x0000B918 File Offset: 0x00009B18
	static Delegate559()
	{
		Class15.smethod_14(typeof(Delegate559).TypeHandle);
	}

	// Token: 0x04000C0F RID: 3087
	internal static Delegate559 delegate559_0;
}
