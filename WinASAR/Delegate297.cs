using System;
using System.Reflection;

// Token: 0x02000339 RID: 825
internal sealed class Delegate297 : MulticastDelegate
{
	// Token: 0x06001C78 RID: 7288
	public extern bool Invoke(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1);

	// Token: 0x06001C79 RID: 7289 RVA: 0x00009E8F File Offset: 0x0000808F
	public static bool smethod_0(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1, Delegate297 delegate297_1)
	{
		return delegate297_1(fieldInfo_0, fieldInfo_1);
	}

	// Token: 0x06001C7A RID: 7290
	public extern Delegate297(object object_0, IntPtr intptr_0);

	// Token: 0x06001C7B RID: 7291 RVA: 0x00009E9C File Offset: 0x0000809C
	static Delegate297()
	{
		Class15.smethod_14(typeof(Delegate297).TypeHandle);
	}

	// Token: 0x04000B09 RID: 2825
	internal static Delegate297 delegate297_0;
}
