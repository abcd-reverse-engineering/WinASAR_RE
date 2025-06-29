using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000625 RID: 1573
internal sealed class Delegate1045 : MulticastDelegate
{
	// Token: 0x06002828 RID: 10280
	public extern void Invoke(object object_0, OpCode opCode_0, MethodInfo methodInfo_0, Type[] type_0);

	// Token: 0x06002829 RID: 10281 RVA: 0x0000E930 File Offset: 0x0000CB30
	public static void smethod_0(object object_0, OpCode opCode_0, MethodInfo methodInfo_0, Type[] type_0, Delegate1045 delegate1045_1)
	{
		delegate1045_1(object_0, opCode_0, methodInfo_0, type_0);
	}

	// Token: 0x0600282A RID: 10282
	public extern Delegate1045(object object_0, IntPtr intptr_0);

	// Token: 0x0600282B RID: 10283 RVA: 0x0000E941 File Offset: 0x0000CB41
	static Delegate1045()
	{
		Class15.smethod_14(typeof(Delegate1045).TypeHandle);
	}

	// Token: 0x04000DF5 RID: 3573
	internal static Delegate1045 delegate1045_0;
}
