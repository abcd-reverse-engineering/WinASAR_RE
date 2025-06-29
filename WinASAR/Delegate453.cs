using System;

// Token: 0x020003D5 RID: 981
internal sealed class Delegate453 : MulticastDelegate
{
	// Token: 0x06001EE8 RID: 7912
	public extern object Invoke(Type type_0, string string_0, bool bool_0);

	// Token: 0x06001EE9 RID: 7913 RVA: 0x0000AE5D File Offset: 0x0000905D
	public static object smethod_0(Type type_0, string string_0, bool bool_0, Delegate453 delegate453_1)
	{
		return delegate453_1(type_0, string_0, bool_0);
	}

	// Token: 0x06001EEA RID: 7914
	public extern Delegate453(object object_0, IntPtr intptr_0);

	// Token: 0x06001EEB RID: 7915 RVA: 0x0000AE6C File Offset: 0x0000906C
	static Delegate453()
	{
		Class15.smethod_14(typeof(Delegate453).TypeHandle);
	}

	// Token: 0x04000BA5 RID: 2981
	internal static Delegate453 delegate453_0;
}
