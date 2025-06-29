using System;

// Token: 0x020004F3 RID: 1267
internal sealed class Delegate739 : MulticastDelegate
{
	// Token: 0x06002360 RID: 9056
	public extern object Invoke(object object_0, TypeCode typeCode_0, IFormatProvider iformatProvider_0);

	// Token: 0x06002361 RID: 9057 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
	public static object smethod_0(object object_0, TypeCode typeCode_0, IFormatProvider iformatProvider_0, Delegate739 delegate739_1)
	{
		return delegate739_1(object_0, typeCode_0, iformatProvider_0);
	}

	// Token: 0x06002362 RID: 9058
	public extern Delegate739(object object_0, IntPtr intptr_0);

	// Token: 0x06002363 RID: 9059 RVA: 0x0000CAE7 File Offset: 0x0000ACE7
	static Delegate739()
	{
		Class15.smethod_14(typeof(Delegate739).TypeHandle);
	}

	// Token: 0x04000CC3 RID: 3267
	internal static Delegate739 delegate739_0;
}
