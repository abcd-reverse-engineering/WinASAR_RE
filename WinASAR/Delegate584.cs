using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000458 RID: 1112
internal sealed class Delegate584 : MulticastDelegate
{
	// Token: 0x060020F4 RID: 8436
	public extern void Invoke(object object_0, OpCode opCode_0, FieldInfo fieldInfo_0);

	// Token: 0x060020F5 RID: 8437 RVA: 0x0000BB8F File Offset: 0x00009D8F
	public static void smethod_0(object object_0, OpCode opCode_0, FieldInfo fieldInfo_0, Delegate584 delegate584_1)
	{
		delegate584_1(object_0, opCode_0, fieldInfo_0);
	}

	// Token: 0x060020F6 RID: 8438
	public extern Delegate584(object object_0, IntPtr intptr_0);

	// Token: 0x060020F7 RID: 8439 RVA: 0x0000BB9E File Offset: 0x00009D9E
	static Delegate584()
	{
		Class15.smethod_14(typeof(Delegate584).TypeHandle);
	}

	// Token: 0x04000C28 RID: 3112
	internal static Delegate584 delegate584_0;
}
