using System;
using System.Reflection;

// Token: 0x02000619 RID: 1561
internal sealed class Delegate1033 : MulticastDelegate
{
	// Token: 0x060027F8 RID: 10232
	public extern bool Invoke(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1);

	// Token: 0x060027F9 RID: 10233 RVA: 0x0000E804 File Offset: 0x0000CA04
	public static bool smethod_0(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1, Delegate1033 delegate1033_1)
	{
		return delegate1033_1(fieldInfo_0, fieldInfo_1);
	}

	// Token: 0x060027FA RID: 10234
	public extern Delegate1033(object object_0, IntPtr intptr_0);

	// Token: 0x060027FB RID: 10235 RVA: 0x0000E811 File Offset: 0x0000CA11
	static Delegate1033()
	{
		Class15.smethod_14(typeof(Delegate1033).TypeHandle);
	}

	// Token: 0x04000DE9 RID: 3561
	internal static Delegate1033 delegate1033_0;
}
