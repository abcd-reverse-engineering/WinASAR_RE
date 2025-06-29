using System;
using System.Xml;

// Token: 0x020005C6 RID: 1478
internal sealed class Delegate950 : MulticastDelegate
{
	// Token: 0x060026AC RID: 9900
	public extern string Invoke(DateTime dateTime_0, XmlDateTimeSerializationMode xmlDateTimeSerializationMode_0);

	// Token: 0x060026AD RID: 9901 RVA: 0x0000DF9C File Offset: 0x0000C19C
	public static string smethod_0(DateTime dateTime_0, XmlDateTimeSerializationMode xmlDateTimeSerializationMode_0, Delegate950 delegate950_1)
	{
		return delegate950_1(dateTime_0, xmlDateTimeSerializationMode_0);
	}

	// Token: 0x060026AE RID: 9902
	public extern Delegate950(object object_0, IntPtr intptr_0);

	// Token: 0x060026AF RID: 9903 RVA: 0x0000DFA9 File Offset: 0x0000C1A9
	static Delegate950()
	{
		Class15.smethod_14(typeof(Delegate950).TypeHandle);
	}

	// Token: 0x04000D96 RID: 3478
	internal static Delegate950 delegate950_0;
}
