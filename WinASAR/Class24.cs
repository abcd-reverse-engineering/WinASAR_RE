using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x020001E6 RID: 486
internal class Class24
{
	// Token: 0x06001500 RID: 5376 RVA: 0x00007867 File Offset: 0x00005A67
	internal static object[] smethod_0()
	{
		return new object[1];
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x000A03EC File Offset: 0x0009E5EC
	internal static object[] ouGrKjinJr<T>(int int_1, object[] object_1, object object_2, ref T gparam_0)
	{
		Class24.Class30 @class = null;
		object obj = Class24.object_0;
		lock (obj)
		{
			if (!Class24.bool_0)
			{
				Class24.bool_0 = true;
				Class24.smethod_3();
			}
			if (Class24.class30_0[int_1] != null)
			{
				@class = Class24.class30_0[int_1];
			}
			else
			{
				Class24.binaryReader_0.BaseStream.Position = (long)Class24.int_0[int_1];
				@class = new Class24.Class30();
				Module module = typeof(Class24).Module;
				int num = Class24.smethod_5(Class24.binaryReader_0);
				int num2 = Class24.smethod_5(Class24.binaryReader_0);
				int num3 = Class24.smethod_5(Class24.binaryReader_0);
				int num4 = Class24.smethod_5(Class24.binaryReader_0);
				@class.methodBase_0 = module.ResolveMethod(num);
				ParameterInfo[] parameters = @class.methodBase_0.GetParameters();
				@class.class26_0 = new Class24.Class26[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					Class24.Class26 class2 = new Class24.Class26();
					class2.bool_0 = type.IsByRef;
					class2.int_0 = i;
					@class.class26_0[i] = class2;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					Class24.Enum4 @enum;
					if (type == typeof(string))
					{
						@enum = (Class24.Enum4)14;
					}
					else if (type == typeof(byte))
					{
						@enum = (Class24.Enum4)2;
					}
					else if (type == typeof(sbyte))
					{
						@enum = (Class24.Enum4)1;
					}
					else if (type == typeof(short))
					{
						@enum = (Class24.Enum4)3;
					}
					else if (type == typeof(ushort))
					{
						@enum = (Class24.Enum4)4;
					}
					else if (type == typeof(int))
					{
						@enum = (Class24.Enum4)5;
					}
					else if (type == typeof(uint))
					{
						@enum = (Class24.Enum4)6;
					}
					else if (type == typeof(long))
					{
						@enum = (Class24.Enum4)7;
					}
					else if (type == typeof(ulong))
					{
						@enum = (Class24.Enum4)8;
					}
					else if (type == typeof(float))
					{
						@enum = (Class24.Enum4)9;
					}
					else if (type == typeof(double))
					{
						@enum = (Class24.Enum4)10;
					}
					else if (type == typeof(bool))
					{
						@enum = (Class24.Enum4)11;
					}
					else if (type == typeof(IntPtr))
					{
						@enum = (Class24.Enum4)12;
					}
					else if (type == typeof(UIntPtr))
					{
						@enum = (Class24.Enum4)13;
					}
					else if (type == typeof(char))
					{
						@enum = (Class24.Enum4)15;
					}
					else
					{
						@enum = (Class24.Enum4)0;
					}
					class2.enum4_0 = @enum;
				}
				@class.list_1 = new List<Class24.Class27>(num2);
				for (int j = 0; j < num2; j++)
				{
					int num5 = Class24.smethod_5(Class24.binaryReader_0);
					Class24.Class27 class3 = new Class24.Class27();
					class3.type_0 = null;
					if (num5 >= 0 && num5 < 50)
					{
						class3.enum4_0 = (Class24.Enum4)(num5 & 31);
						class3.bool_0 = (num5 & 32) > 0;
					}
					class3.int_0 = j;
					@class.list_1.Add(class3);
				}
				@class.list_2 = new List<Class24.Class28>(num3);
				for (int k = 0; k < num3; k++)
				{
					int num6 = Class24.smethod_5(Class24.binaryReader_0);
					int num7 = Class24.smethod_5(Class24.binaryReader_0);
					Class24.Class28 class4 = new Class24.Class28();
					class4.int_0 = num6;
					class4.int_1 = num7;
					Class24.Class29 class5 = new Class24.Class29();
					class4.class29_0 = class5;
					num6 = Class24.smethod_5(Class24.binaryReader_0);
					num7 = Class24.smethod_5(Class24.binaryReader_0);
					int num8 = Class24.smethod_5(Class24.binaryReader_0);
					class5.int_0 = num6;
					class5.int_1 = num7;
					class5.int_3 = num8;
					if (num8 == 0)
					{
						class5.type_0 = module.ResolveType(Class24.smethod_5(Class24.binaryReader_0));
					}
					else if (num8 == 1)
					{
						class5.int_2 = Class24.smethod_5(Class24.binaryReader_0);
					}
					else
					{
						Class24.smethod_5(Class24.binaryReader_0);
					}
					@class.list_2.Add(class4);
				}
				@class.list_2.Sort(new Comparison<Class24.Class28>(Class24.Class53<T>.<>9.method_0));
				@class.list_0 = new List<Class24.Class25>(num4);
				for (int l = 0; l < num4; l++)
				{
					Class24.Class25 class6 = new Class24.Class25();
					byte b = Class24.binaryReader_0.ReadByte();
					class6.enum6_0 = (Class24.Enum6)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num9 = (int)Class24.byte_0[(int)b];
					if (num9 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj2;
						switch (num9)
						{
						case 1:
							obj2 = Class24.smethod_5(Class24.binaryReader_0);
							break;
						case 2:
							obj2 = Class24.binaryReader_0.ReadInt64();
							break;
						case 3:
							obj2 = Class24.binaryReader_0.ReadSingle();
							break;
						case 4:
							obj2 = Class24.binaryReader_0.ReadDouble();
							break;
						case 5:
						{
							int num10 = Class24.smethod_5(Class24.binaryReader_0);
							int[] array = new int[num10];
							for (int m = 0; m < num10; m++)
							{
								array[m] = Class24.smethod_5(Class24.binaryReader_0);
							}
							obj2 = array;
							break;
						}
						default:
							throw new Exception();
						}
						class6.object_0 = obj2;
					}
					@class.list_0.Add(class6);
				}
				Class24.class30_0[int_1] = @class;
			}
		}
		Class24.Class33 class7 = new Class24.Class33();
		class7.class30_0 = @class;
		ParameterInfo[] parameters2 = @class.methodBase_0.GetParameters();
		bool flag2 = false;
		int num11 = 0;
		if (@class.methodBase_0 is MethodInfo && ((MethodInfo)@class.methodBase_0).ReturnType != typeof(void))
		{
			flag2 = true;
		}
		if (@class.methodBase_0.IsStatic)
		{
			class7.class35_0 = new Class24.Class35[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class35_0[n] = Class24.Class35.smethod_1(parameterType, object_1[n]);
				if (parameterType.IsByRef)
				{
					num11++;
				}
			}
		}
		else
		{
			class7.class35_0 = new Class24.Class35[parameters2.Length + 1];
			if (@class.methodBase_0.DeclaringType.IsValueType)
			{
				class7.class35_0[0] = new Class24.Class46(new Class24.Class47(object_2), @class.methodBase_0.DeclaringType);
			}
			else
			{
				class7.class35_0[0] = new Class24.Class47(object_2);
			}
			for (int num12 = 0; num12 < parameters2.Length; num12++)
			{
				Type parameterType2 = parameters2[num12].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class35_0[num12 + 1] = Class24.Class35.smethod_1(parameterType2, object_1[num12]);
					num11++;
				}
				else
				{
					class7.class35_0[num12 + 1] = Class24.Class35.smethod_1(parameterType2, object_1[num12]);
				}
			}
		}
		class7.class35_1 = new Class24.Class35[@class.list_1.Count];
		for (int num13 = 0; num13 < @class.list_1.Count; num13++)
		{
			Class24.Class27 class8 = @class.list_1[num13];
			switch (class8.enum4_0)
			{
			case (Class24.Enum4)0:
				class7.class35_1[num13] = null;
				break;
			case (Class24.Enum4)1:
			case (Class24.Enum4)2:
			case (Class24.Enum4)3:
			case (Class24.Enum4)4:
			case (Class24.Enum4)5:
			case (Class24.Enum4)6:
			case (Class24.Enum4)11:
			case (Class24.Enum4)15:
				class7.class35_1[num13] = new Class24.Class37(0, class8.enum4_0);
				break;
			case (Class24.Enum4)7:
			case (Class24.Enum4)8:
				class7.class35_1[num13] = new Class24.Class38(0L, class8.enum4_0);
				break;
			case (Class24.Enum4)9:
			case (Class24.Enum4)10:
				class7.class35_1[num13] = new Class24.Class40(0.0, class8.enum4_0);
				break;
			case (Class24.Enum4)12:
				class7.class35_1[num13] = new Class24.Class39(IntPtr.Zero);
				break;
			case (Class24.Enum4)13:
				class7.class35_1[num13] = new Class24.Class39(UIntPtr.Zero);
				break;
			case (Class24.Enum4)14:
				class7.class35_1[num13] = null;
				break;
			case (Class24.Enum4)16:
				class7.class35_1[num13] = new Class24.Class47(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.yqDbiTnaSC();
		}
		int num14 = 0;
		if (flag2)
		{
			num14 = 1;
		}
		num14 += num11;
		object[] array2 = new object[num14];
		if (flag2)
		{
			array2[0] = null;
		}
		if (@class.methodBase_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.methodBase_0;
			if (methodInfo.ReturnType != typeof(void) && class7.class35_2 != null)
			{
				array2[0] = class7.class35_2.vmethod_4(methodInfo.ReturnType);
			}
		}
		if (num11 > 0)
		{
			int num15 = 0;
			if (flag2)
			{
				num15++;
			}
			for (int num16 = 0; num16 < parameters2.Length; num16++)
			{
				Type type2 = parameters2[num16].ParameterType;
				if (type2.IsByRef)
				{
					type2 = type2.GetElementType();
					if (class7.class35_0[num16] != null)
					{
						if (@class.methodBase_0.IsStatic)
						{
							array2[num15] = class7.class35_0[num16].vmethod_4(type2);
						}
						else
						{
							array2[num15] = class7.class35_0[num16 + 1].vmethod_4(type2);
						}
					}
					else
					{
						array2[num15] = null;
					}
					num15++;
				}
			}
		}
		if (!@class.methodBase_0.IsStatic && @class.methodBase_0.DeclaringType.IsValueType)
		{
			gparam_0 = (T)((object)class7.class35_0[0].vmethod_4(@class.methodBase_0.DeclaringType));
		}
		return array2;
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x000A0DD0 File Offset: 0x0009EFD0
	internal static object[] smethod_1(int int_1, object[] object_1, object object_2)
	{
		int num = 0;
		return Class24.ouGrKjinJr<int>(int_1, object_1, object_2, ref num);
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x0000786F File Offset: 0x00005A6F
	internal static object[] smethod_2<T>(int int_1, object[] object_1, ref T gparam_0)
	{
		return Class24.ouGrKjinJr<T>(int_1, object_1, gparam_0, ref gparam_0);
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x000A0DEC File Offset: 0x0009EFEC
	internal static void smethod_3()
	{
		if (Class24.int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class24).Assembly.GetManifestResourceStream("M7rjDhbcmVyoySbe1J.5heLO0lFfPcYx6McvT"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			Class24.smethod_4(array);
		}
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x000A0E54 File Offset: 0x0009F054
	internal static void smethod_4(byte[] byte_1)
	{
		Class24.binaryReader_0 = new BinaryReader(new MemoryStream(byte_1));
		Class24.byte_0 = new byte[255];
		int num = Class24.smethod_5(Class24.binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = (int)Class24.binaryReader_0.ReadByte();
			Class24.byte_0[num2] = Class24.binaryReader_0.ReadByte();
		}
		num = Class24.smethod_5(Class24.binaryReader_0);
		Class24.OgDrYbhOg7 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			Class24.OgDrYbhOg7.Add(Encoding.Unicode.GetString(Class24.binaryReader_0.ReadBytes(Class24.smethod_5(Class24.binaryReader_0))));
		}
		num = Class24.smethod_5(Class24.binaryReader_0);
		Class24.class30_0 = new Class24.Class30[num];
		Class24.int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			Class24.class30_0[k] = null;
			Class24.int_0[k] = Class24.smethod_5(Class24.binaryReader_0);
		}
		int num3 = (int)Class24.binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = Class24.int_0[l];
			Class24.int_0[l] = num3;
			num3 += num4;
		}
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x000A0F9C File Offset: 0x0009F19C
	internal static int smethod_5(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = (uint)binaryReader_1.ReadByte();
		uint num2 = 0U | (num & 63U);
		if ((num & 64U) != 0U)
		{
			flag = true;
		}
		if (num >= 128U)
		{
			int num3 = 0;
			for (;;)
			{
				uint num4 = (uint)binaryReader_1.ReadByte();
				num2 |= (num4 & 127U) << 7 * num3 + 6;
				if (num4 < 128U)
				{
					break;
				}
				num3++;
			}
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
		else
		{
			if (!flag)
			{
				return (int)num2;
			}
			return (int)(~(int)num2);
		}
	}

	// Token: 0x040008D8 RID: 2264
	internal static Class24.Class30[] class30_0 = null;

	// Token: 0x040008D9 RID: 2265
	internal static int[] int_0 = null;

	// Token: 0x040008DA RID: 2266
	internal static List<string> OgDrYbhOg7;

	// Token: 0x040008DB RID: 2267
	private static BinaryReader binaryReader_0;

	// Token: 0x040008DC RID: 2268
	private static byte[] byte_0;

	// Token: 0x040008DD RID: 2269
	private static bool bool_0 = false;

	// Token: 0x040008DE RID: 2270
	private static object object_0 = new object();

	// Token: 0x020001E7 RID: 487
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct7
	{
		// Token: 0x040008E0 RID: 2272
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x040008E1 RID: 2273
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x040008E2 RID: 2274
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x040008E3 RID: 2275
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x040008E4 RID: 2276
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x040008E5 RID: 2277
		[FieldOffset(0)]
		public int int_0;
	}

	// Token: 0x020001E8 RID: 488
	private class Class37 : Class24.Class36
	{
		// Token: 0x0600150B RID: 5387 RVA: 0x000A1044 File Offset: 0x0009F244
		internal override void vmethod_10(Class24.Class35 class35_0)
		{
			this.struct7_0 = ((Class24.Class37)class35_0).struct7_0;
			this.enum4_0 = ((Class24.Class37)class35_0).enum4_0;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000A1074 File Offset: 0x0009F274
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_10(class35_0);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000A1088 File Offset: 0x0009F288
		public Class37(bool bool_0)
		{
			this.enum7_0 = (Class24.Enum7)1;
			if (bool_0)
			{
				this.struct7_0.int_0 = 1;
			}
			else
			{
				this.struct7_0.int_0 = 0;
			}
			this.enum4_0 = (Class24.Enum4)11;
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000A10CC File Offset: 0x0009F2CC
		public Class37(Class24.Class37 class37_0)
		{
			this.enum7_0 = class37_0.enum7_0;
			this.struct7_0.int_0 = class37_0.struct7_0.int_0;
			this.enum4_0 = class37_0.enum4_0;
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00007884 File Offset: 0x00005A84
		public override Class24.Class36 vmethod_71()
		{
			return new Class24.Class37(this);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000A1110 File Offset: 0x0009F310
		public Class37(int int_0)
		{
			this.enum7_0 = (Class24.Enum7)1;
			this.struct7_0.int_0 = int_0;
			this.enum4_0 = (Class24.Enum4)5;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000A1140 File Offset: 0x0009F340
		public Class37(uint uint_0)
		{
			this.enum7_0 = (Class24.Enum7)1;
			this.struct7_0.uint_0 = uint_0;
			this.enum4_0 = (Class24.Enum4)6;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000A1170 File Offset: 0x0009F370
		public Class37(int int_0, Class24.Enum4 enum4_1)
		{
			this.enum7_0 = (Class24.Enum7)1;
			this.struct7_0.int_0 = int_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000A11A0 File Offset: 0x0009F3A0
		public Class37(uint uint_0, Class24.Enum4 enum4_1)
		{
			this.enum7_0 = (Class24.Enum7)1;
			this.struct7_0.uint_0 = uint_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000A11D0 File Offset: 0x0009F3D0
		public override bool vmethod_11()
		{
			Class24.Enum4 @enum = this.enum4_0;
			switch (@enum)
			{
			case (Class24.Enum4)1:
			case (Class24.Enum4)3:
			case (Class24.Enum4)5:
			case (Class24.Enum4)7:
				goto IL_004B;
			case (Class24.Enum4)2:
			case (Class24.Enum4)4:
			case (Class24.Enum4)6:
				break;
			default:
				if (@enum == (Class24.Enum4)11)
				{
					goto IL_004B;
				}
				if (@enum == (Class24.Enum4)15)
				{
					goto IL_004B;
				}
				break;
			}
			return this.struct7_0.uint_0 == 0U;
			IL_004B:
			return this.struct7_0.int_0 == 0;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0000788C File Offset: 0x00005A8C
		public override bool vmethod_12()
		{
			return !this.vmethod_11();
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000A1238 File Offset: 0x0009F438
		public override Class24.Class35 vmethod_13(Class24.Enum4 enum4_1)
		{
			switch (enum4_1)
			{
			case (Class24.Enum4)1:
				return this.vmethod_15();
			case (Class24.Enum4)2:
				return this.vmethod_16();
			case (Class24.Enum4)3:
				return this.vmethod_17();
			case (Class24.Enum4)4:
				return this.vmethod_18();
			case (Class24.Enum4)5:
				return this.vmethod_19();
			case (Class24.Enum4)6:
				return this.vmethod_20();
			case (Class24.Enum4)11:
				return this.vmethod_14();
			case (Class24.Enum4)15:
				return this.method_6();
			case (Class24.Enum4)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class24.Enum8)4).ToString());
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000A12E4 File Offset: 0x0009F4E4
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 != null && Nullable.GetUnderlyingType(type_0) != null)
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum4_0)
				{
				case (Class24.Enum4)1:
					return this.struct7_0.sbyte_0;
				case (Class24.Enum4)2:
					return this.struct7_0.byte_0;
				case (Class24.Enum4)3:
					return this.struct7_0.short_0;
				case (Class24.Enum4)4:
					return this.struct7_0.ushort_0;
				case (Class24.Enum4)5:
					return this.struct7_0.int_0;
				case (Class24.Enum4)6:
					return this.struct7_0.uint_0;
				case (Class24.Enum4)7:
					return (long)this.struct7_0.int_0;
				case (Class24.Enum4)8:
					return (ulong)this.struct7_0.uint_0;
				case (Class24.Enum4)11:
					return this.vmethod_12();
				case (Class24.Enum4)15:
					return (char)this.struct7_0.int_0;
				}
				return this.struct7_0.int_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct7_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct7_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct7_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct7_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct7_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct7_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_11();
			}
			if (type_0 == typeof(long))
			{
				return (long)this.struct7_0.int_0;
			}
			if (type_0 == typeof(ulong))
			{
				return (ulong)this.struct7_0.uint_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct7_0.int_0;
			}
			if (type_0 == typeof(IntPtr))
			{
				return new IntPtr(this.struct7_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(this.struct7_0.uint_0);
			}
			if (!type_0.IsEnum)
			{
				throw new Class24.Exception1();
			}
			return this.method_5(type_0);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000A162C File Offset: 0x0009F82C
		internal object method_5(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct7_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct7_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct7_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct7_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct7_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct7_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, (long)this.struct7_0.int_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, (ulong)this.struct7_0.uint_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct7_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct7_0.int_0);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00007897 File Offset: 0x00005A97
		public override Class24.Class37 vmethod_14()
		{
			return new Class24.Class37((!this.vmethod_11()) ? 1 : 0);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000078A7 File Offset: 0x00005AA7
		internal override bool vmethod_7()
		{
			return this.vmethod_12();
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000078AF File Offset: 0x00005AAF
		public override Class24.Class37 vmethod_15()
		{
			return new Class24.Class37((int)this.struct7_0.sbyte_0, (Class24.Enum4)1);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x000078C2 File Offset: 0x00005AC2
		public Class24.Class37 method_6()
		{
			return new Class24.Class37(this.struct7_0.int_0, (Class24.Enum4)15);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000078D6 File Offset: 0x00005AD6
		public override Class24.Class37 vmethod_16()
		{
			return new Class24.Class37((uint)this.struct7_0.byte_0, (Class24.Enum4)2);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x000078E9 File Offset: 0x00005AE9
		public override Class24.Class37 vmethod_17()
		{
			return new Class24.Class37((int)this.struct7_0.short_0, (Class24.Enum4)3);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000078FC File Offset: 0x00005AFC
		public override Class24.Class37 vmethod_18()
		{
			return new Class24.Class37((uint)this.struct7_0.ushort_0, (Class24.Enum4)4);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0000790F File Offset: 0x00005B0F
		public override Class24.Class37 vmethod_19()
		{
			return new Class24.Class37(this.struct7_0.int_0, (Class24.Enum4)5);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00007922 File Offset: 0x00005B22
		public override Class24.Class37 vmethod_20()
		{
			return new Class24.Class37(this.struct7_0.uint_0, (Class24.Enum4)6);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00007935 File Offset: 0x00005B35
		public override Class24.Class38 vmethod_21()
		{
			return new Class24.Class38((long)this.struct7_0.int_0, (Class24.Enum4)7);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00007949 File Offset: 0x00005B49
		public override Class24.Class38 vmethod_22()
		{
			return new Class24.Class38((ulong)this.struct7_0.uint_0, (Class24.Enum4)8);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0000795D File Offset: 0x00005B5D
		public override Class24.Class37 vmethod_23()
		{
			return this.vmethod_15();
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00007965 File Offset: 0x00005B65
		public override Class24.Class37 vmethod_24()
		{
			return this.vmethod_17();
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0000796D File Offset: 0x00005B6D
		public override Class24.Class37 vmethod_25()
		{
			return this.vmethod_19();
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00007975 File Offset: 0x00005B75
		public override Class24.Class38 vmethod_26()
		{
			return this.vmethod_21();
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0000797D File Offset: 0x00005B7D
		public override Class24.Class37 vmethod_27()
		{
			return this.vmethod_16();
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00007985 File Offset: 0x00005B85
		public override Class24.Class37 vmethod_28()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0000798D File Offset: 0x00005B8D
		public override Class24.Class37 vmethod_29()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00007995 File Offset: 0x00005B95
		public override Class24.Class38 vmethod_30()
		{
			return this.vmethod_22();
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0000799D File Offset: 0x00005B9D
		public override Class24.Class37 vmethod_31()
		{
			return new Class24.Class37((int)(checked((sbyte)this.struct7_0.int_0)), (Class24.Enum4)1);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x000079B1 File Offset: 0x00005BB1
		public override Class24.Class37 vmethod_32()
		{
			return new Class24.Class37((int)(checked((sbyte)this.struct7_0.uint_0)), (Class24.Enum4)1);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000079C5 File Offset: 0x00005BC5
		public override Class24.Class37 vmethod_33()
		{
			return new Class24.Class37((int)(checked((short)this.struct7_0.int_0)), (Class24.Enum4)3);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000079D9 File Offset: 0x00005BD9
		public override Class24.Class37 vmethod_34()
		{
			return new Class24.Class37((int)(checked((short)this.struct7_0.uint_0)), (Class24.Enum4)3);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0000790F File Offset: 0x00005B0F
		public override Class24.Class37 vmethod_35()
		{
			return new Class24.Class37(this.struct7_0.int_0, (Class24.Enum4)5);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000079ED File Offset: 0x00005BED
		public override Class24.Class37 vmethod_36()
		{
			return new Class24.Class37(checked((int)this.struct7_0.uint_0), (Class24.Enum4)5);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00007935 File Offset: 0x00005B35
		public override Class24.Class38 vmethod_37()
		{
			return new Class24.Class38((long)this.struct7_0.int_0, (Class24.Enum4)7);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00007A01 File Offset: 0x00005C01
		public override Class24.Class38 vmethod_38()
		{
			return new Class24.Class38((long)((ulong)this.struct7_0.uint_0), (Class24.Enum4)7);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00007A15 File Offset: 0x00005C15
		public override Class24.Class37 vmethod_39()
		{
			return new Class24.Class37((int)(checked((byte)this.struct7_0.int_0)), (Class24.Enum4)2);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00007A29 File Offset: 0x00005C29
		public override Class24.Class37 vmethod_40()
		{
			return new Class24.Class37((int)(checked((byte)this.struct7_0.uint_0)), (Class24.Enum4)2);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00007A3D File Offset: 0x00005C3D
		public override Class24.Class37 vmethod_41()
		{
			return new Class24.Class37((int)(checked((ushort)this.struct7_0.int_0)), (Class24.Enum4)4);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00007A51 File Offset: 0x00005C51
		public override Class24.Class37 vmethod_42()
		{
			return new Class24.Class37((int)(checked((ushort)this.struct7_0.uint_0)), (Class24.Enum4)4);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00007A65 File Offset: 0x00005C65
		public override Class24.Class37 vmethod_43()
		{
			return new Class24.Class37(checked((uint)this.struct7_0.int_0), (Class24.Enum4)6);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00007922 File Offset: 0x00005B22
		public override Class24.Class37 vmethod_44()
		{
			return new Class24.Class37(this.struct7_0.uint_0, (Class24.Enum4)6);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00007A79 File Offset: 0x00005C79
		public override Class24.Class38 vmethod_45()
		{
			return new Class24.Class38(checked((ulong)this.struct7_0.int_0), (Class24.Enum4)8);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00007949 File Offset: 0x00005B49
		public override Class24.Class38 vmethod_46()
		{
			return new Class24.Class38((ulong)this.struct7_0.uint_0, (Class24.Enum4)8);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00007A8D File Offset: 0x00005C8D
		public override Class24.Class40 vmethod_47()
		{
			return new Class24.Class40((float)this.struct7_0.int_0);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00007AA0 File Offset: 0x00005CA0
		public override Class24.Class40 vmethod_48()
		{
			return new Class24.Class40((double)this.struct7_0.int_0);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00007AB3 File Offset: 0x00005CB3
		public override Class24.Class40 vmethod_49()
		{
			return new Class24.Class40(this.struct7_0.uint_0);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x000A17A8 File Offset: 0x0009F9A8
		public override Class24.Class39 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_26().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_25().struct7_0.int_0);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x000A17EC File Offset: 0x0009F9EC
		public override Class24.Class39 skgckirNpg()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_30().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_29().struct7_0.uint_0);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x000A1830 File Offset: 0x0009FA30
		public override Class24.Class39 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_37().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_35().struct7_0.int_0);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x000A1874 File Offset: 0x0009FA74
		public override Class24.Class39 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_45().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_43().struct7_0.uint_0);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000A18B8 File Offset: 0x0009FAB8
		public override Class24.Class39 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_38().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_36().struct7_0.int_0);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000A18FC File Offset: 0x0009FAFC
		public override Class24.Class39 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_46().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_44().struct7_0.uint_0);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000A1940 File Offset: 0x0009FB40
		public override Class24.Class35 vmethod_55()
		{
			Class24.Enum4 @enum = this.enum4_0;
			switch (@enum)
			{
			case (Class24.Enum4)1:
			case (Class24.Enum4)3:
			case (Class24.Enum4)5:
				goto IL_0048;
			case (Class24.Enum4)2:
			case (Class24.Enum4)4:
				break;
			default:
				if (@enum == (Class24.Enum4)11)
				{
					goto IL_0048;
				}
				if (@enum == (Class24.Enum4)15)
				{
					goto IL_0048;
				}
				break;
			}
			return new Class24.Class37((int)(-(int)((ulong)this.struct7_0.uint_0)));
			IL_0048:
			return new Class24.Class37(-this.struct7_0.int_0);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000A19A8 File Offset: 0x0009FBA8
		public override Class24.Class35 Add(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 + ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).Add(this);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000A1A0C File Offset: 0x0009FC0C
		public override Class24.Class35 vmethod_56(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(checked(this.struct7_0.int_0 + ((Class24.Class37)class35_0).struct7_0.int_0));
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_56(this);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x000A1A70 File Offset: 0x0009FC70
		public override Class24.Class35 vmethod_57(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(checked(this.struct7_0.uint_0 + ((Class24.Class37)class35_0).struct7_0.uint_0));
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_57(this);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000A1AD4 File Offset: 0x0009FCD4
		public override Class24.Class35 vmethod_58(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 - ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).method_7(this);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000A1B38 File Offset: 0x0009FD38
		public override Class24.Class35 vmethod_59(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(checked(this.struct7_0.int_0 - ((Class24.Class37)class35_0).struct7_0.int_0));
			}
			if (class35_0.method_1())
			{
				return ((Class24.Class39)class35_0).method_8(this);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000A1B9C File Offset: 0x0009FD9C
		public override Class24.Class35 mvdcByduPo(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(checked(this.struct7_0.uint_0 - ((Class24.Class37)class35_0).struct7_0.uint_0));
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).method_9(this);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000A1C00 File Offset: 0x0009FE00
		public override Class24.Class35 vmethod_60(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 * ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_60(this);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x000A1C64 File Offset: 0x0009FE64
		public override Class24.Class35 vmethod_61(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(checked(this.struct7_0.int_0 * ((Class24.Class37)class35_0).struct7_0.int_0));
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_61(this);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x000A1CC8 File Offset: 0x0009FEC8
		public override Class24.Class35 vmethod_62(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(checked(this.struct7_0.uint_0 * ((Class24.Class37)class35_0).struct7_0.uint_0));
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_62(this);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000A1D2C File Offset: 0x0009FF2C
		public override Class24.Class35 vmethod_63(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 / ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (class35_0.method_1())
			{
				return ((Class24.Class39)class35_0).method_10(this);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000A1D90 File Offset: 0x0009FF90
		public override Class24.Class35 vmethod_64(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.uint_0 / ((Class24.Class37)class35_0).struct7_0.uint_0);
			}
			if (class35_0.method_1())
			{
				return ((Class24.Class39)class35_0).method_11(this);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000A1DF4 File Offset: 0x0009FFF4
		public override Class24.Class35 vmethod_65(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 % ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).method_12(this);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000A1E58 File Offset: 0x000A0058
		public override Class24.Class35 vmethod_66(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.uint_0 % ((Class24.Class37)class35_0).struct7_0.uint_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).method_13(this);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000A1EBC File Offset: 0x000A00BC
		public override Class24.Class35 vmethod_67(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 & ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_67(this);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x000A1F20 File Offset: 0x000A0120
		public override Class24.Class35 vmethod_68(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 | ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (class35_0.method_1())
			{
				return ((Class24.Class39)class35_0).vmethod_68(this);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00007AC7 File Offset: 0x00005CC7
		public override Class24.Class35 vmethod_69()
		{
			return new Class24.Class37(~this.struct7_0.int_0);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000A1F84 File Offset: 0x000A0184
		public override Class24.Class35 vmethod_70(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 ^ ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_70(this);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000A1FE8 File Offset: 0x000A01E8
		public override Class24.Class35 vmethod_72(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 << ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (class35_0.method_1())
			{
				return ((Class24.Class39)class35_0).method_16(this);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000A204C File Offset: 0x000A024C
		public override Class24.Class35 vmethod_73(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.int_0 >> ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).method_15(this);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000A20B0 File Offset: 0x000A02B0
		public override Class24.Class35 vmethod_74(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return new Class24.Class37(this.struct7_0.uint_0 >> ((Class24.Class37)class35_0).struct7_0.int_0);
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).method_14(this);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x000A2114 File Offset: 0x000A0314
		public override string ToString()
		{
			Class24.Enum4 @enum = this.enum4_0;
			switch (@enum)
			{
			case (Class24.Enum4)1:
			case (Class24.Enum4)3:
			case (Class24.Enum4)5:
				goto IL_003F;
			case (Class24.Enum4)2:
			case (Class24.Enum4)4:
				break;
			default:
				if (@enum == (Class24.Enum4)11)
				{
					goto IL_003F;
				}
				break;
			}
			return this.struct7_0.uint_0.ToString();
			IL_003F:
			return this.struct7_0.int_0.ToString();
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00007ADA File Offset: 0x00005CDA
		internal override Class24.Class35 vmethod_8()
		{
			return this;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002C18 File Offset: 0x00000E18
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000A2170 File Offset: 0x000A0370
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			if (class35_0.anLwXoVydS())
			{
				return ((Class24.Class47)class35_0).vmethod_5(this);
			}
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_5(this);
			}
			Class24.Class35 @class = class35_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_2())
			{
				return false;
			}
			if (!@class.method_0())
			{
				return ((Class24.Class39)@class).vmethod_5(this);
			}
			return this.struct7_0.int_0 == ((Class24.Class37)@class).struct7_0.int_0;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000A21FC File Offset: 0x000A03FC
		private static Class24.Class36 smethod_4(Class24.Class35 class35_0)
		{
			Class24.Class36 @class = class35_0 as Class24.Class36;
			if (@class == null && class35_0.vmethod_0())
			{
				@class = class35_0.vmethod_8() as Class24.Class36;
			}
			return @class;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x000A222C File Offset: 0x000A042C
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			if (class35_0.anLwXoVydS())
			{
				return false;
			}
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_6(this);
			}
			Class24.Class35 @class = class35_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_2())
			{
				return false;
			}
			if (@class.method_0())
			{
				return this.struct7_0.uint_0 != ((Class24.Class37)@class).struct7_0.uint_0;
			}
			return ((Class24.Class39)@class).vmethod_6(this);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000A22B0 File Offset: 0x000A04B0
		public override bool vmethod_75(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return this.struct7_0.int_0 >= ((Class24.Class37)class35_0).struct7_0.int_0;
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_79(this);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000A2310 File Offset: 0x000A0510
		public override bool vmethod_76(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return this.struct7_0.uint_0 >= ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_80(this);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000A2370 File Offset: 0x000A0570
		public override bool vmethod_77(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return this.struct7_0.int_0 > ((Class24.Class37)class35_0).struct7_0.int_0;
			}
			if (class35_0.method_1())
			{
				return ((Class24.Class39)class35_0).vmethod_81(this);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x000A23D0 File Offset: 0x000A05D0
		public override bool vmethod_78(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return this.struct7_0.uint_0 > ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_82(this);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000A2430 File Offset: 0x000A0630
		public override bool vmethod_79(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return this.struct7_0.int_0 <= ((Class24.Class37)class35_0).struct7_0.int_0;
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_75(this);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000A2490 File Offset: 0x000A0690
		public override bool vmethod_80(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return this.struct7_0.uint_0 <= ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
			if (!class35_0.method_1())
			{
				throw new Class24.Exception1();
			}
			return ((Class24.Class39)class35_0).vmethod_76(this);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x000A24F0 File Offset: 0x000A06F0
		public override bool vmethod_81(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return this.struct7_0.int_0 < ((Class24.Class37)class35_0).struct7_0.int_0;
			}
			if (class35_0.method_1())
			{
				return ((Class24.Class39)class35_0).vmethod_77(this);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000A2550 File Offset: 0x000A0750
		public override bool vmethod_82(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				return this.struct7_0.uint_0 < ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
			if (class35_0.method_1())
			{
				return ((Class24.Class39)class35_0).vmethod_78(this);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x040008E6 RID: 2278
		public Class24.Struct7 struct7_0;

		// Token: 0x040008E7 RID: 2279
		public Class24.Enum4 enum4_0;
	}

	// Token: 0x020001E9 RID: 489
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct8
	{
		// Token: 0x040008E9 RID: 2281
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x040008EA RID: 2282
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x040008EB RID: 2283
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x040008EC RID: 2284
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x040008ED RID: 2285
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x040008EE RID: 2286
		[FieldOffset(0)]
		public int int_0;

		// Token: 0x040008EF RID: 2287
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x040008F0 RID: 2288
		[FieldOffset(0)]
		public long long_0;
	}

	// Token: 0x020001EA RID: 490
	private class Class38 : Class24.Class36
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x000A25B0 File Offset: 0x000A07B0
		internal override void vmethod_10(Class24.Class35 class35_0)
		{
			this.struct8_0 = ((Class24.Class38)class35_0).struct8_0;
			this.enum4_0 = ((Class24.Class38)class35_0).enum4_0;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000A1074 File Offset: 0x0009F274
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_10(class35_0);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000A25E0 File Offset: 0x000A07E0
		public Class38(long long_0)
		{
			this.enum7_0 = (Class24.Enum7)2;
			this.struct8_0.long_0 = long_0;
			this.enum4_0 = (Class24.Enum4)7;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000A2610 File Offset: 0x000A0810
		public Class38(Class24.Class38 class38_0)
		{
			this.enum7_0 = class38_0.enum7_0;
			this.struct8_0.long_0 = class38_0.struct8_0.long_0;
			this.enum4_0 = class38_0.enum4_0;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00007ADD File Offset: 0x00005CDD
		public override Class24.Class36 vmethod_71()
		{
			return new Class24.Class38(this);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000A2654 File Offset: 0x000A0854
		public Class38(long long_0, Class24.Enum4 enum4_1)
		{
			this.enum7_0 = (Class24.Enum7)2;
			this.struct8_0.long_0 = long_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000A2684 File Offset: 0x000A0884
		public Class38(ulong ulong_0)
		{
			this.enum7_0 = (Class24.Enum7)2;
			this.struct8_0.ulong_0 = ulong_0;
			this.enum4_0 = (Class24.Enum4)8;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x000A26B4 File Offset: 0x000A08B4
		public Class38(ulong ulong_0, Class24.Enum4 enum4_1)
		{
			this.enum7_0 = (Class24.Enum7)2;
			this.struct8_0.ulong_0 = ulong_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000A26E4 File Offset: 0x000A08E4
		public override bool vmethod_11()
		{
			if (this.enum4_0 == (Class24.Enum4)7)
			{
				return this.struct8_0.long_0 == 0L;
			}
			return this.struct8_0.ulong_0 == 0UL;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0000788C File Offset: 0x00005A8C
		public override bool vmethod_12()
		{
			return !this.vmethod_11();
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000A2728 File Offset: 0x000A0928
		public override Class24.Class35 vmethod_13(Class24.Enum4 enum4_1)
		{
			switch (enum4_1)
			{
			case (Class24.Enum4)1:
				return this.vmethod_15();
			case (Class24.Enum4)2:
				return this.vmethod_16();
			case (Class24.Enum4)3:
				return this.vmethod_17();
			case (Class24.Enum4)4:
				return this.vmethod_18();
			case (Class24.Enum4)5:
				return this.vmethod_19();
			case (Class24.Enum4)6:
				return this.vmethod_20();
			case (Class24.Enum4)7:
				return this.vmethod_21();
			case (Class24.Enum4)8:
				return this.vmethod_22();
			case (Class24.Enum4)11:
				return this.vmethod_14();
			case (Class24.Enum4)15:
				return this.method_6();
			case (Class24.Enum4)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class24.Enum8)4).ToString());
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000A27E4 File Offset: 0x000A09E4
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum4_0)
				{
				case (Class24.Enum4)1:
					return this.struct8_0.sbyte_0;
				case (Class24.Enum4)2:
					return this.struct8_0.byte_0;
				case (Class24.Enum4)3:
					return this.struct8_0.short_0;
				case (Class24.Enum4)4:
					return this.struct8_0.ushort_0;
				case (Class24.Enum4)5:
					return this.struct8_0.int_0;
				case (Class24.Enum4)6:
					return this.struct8_0.uint_0;
				case (Class24.Enum4)7:
					return this.struct8_0.long_0;
				case (Class24.Enum4)8:
					return this.struct8_0.ulong_0;
				case (Class24.Enum4)11:
					return this.vmethod_12();
				case (Class24.Enum4)15:
					return (char)this.struct8_0.int_0;
				}
				return this.struct8_0.long_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct8_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct8_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct8_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct8_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct8_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct8_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_11();
			}
			if (type_0 == typeof(long))
			{
				return this.struct8_0.long_0;
			}
			if (type_0 == typeof(ulong))
			{
				return this.struct8_0.ulong_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct8_0.long_0;
			}
			if (type_0.IsEnum)
			{
				return this.method_5(type_0);
			}
			throw new Class24.Exception1();
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x000A2AB4 File Offset: 0x000A0CB4
		internal object method_5(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct8_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct8_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct8_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct8_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct8_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct8_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, this.struct8_0.long_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, this.struct8_0.ulong_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct8_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct8_0.long_0);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00007897 File Offset: 0x00005A97
		public override Class24.Class37 vmethod_14()
		{
			return new Class24.Class37((!this.vmethod_11()) ? 1 : 0);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000078A7 File Offset: 0x00005AA7
		internal override bool vmethod_7()
		{
			return this.vmethod_12();
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00007AE5 File Offset: 0x00005CE5
		public Class24.Class37 method_6()
		{
			return new Class24.Class37((int)this.struct8_0.sbyte_0, (Class24.Enum4)15);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00007AF9 File Offset: 0x00005CF9
		public override Class24.Class37 vmethod_15()
		{
			return new Class24.Class37((int)this.struct8_0.sbyte_0, (Class24.Enum4)1);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00007B0C File Offset: 0x00005D0C
		public override Class24.Class37 vmethod_16()
		{
			return new Class24.Class37((uint)this.struct8_0.byte_0, (Class24.Enum4)2);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00007B1F File Offset: 0x00005D1F
		public override Class24.Class37 vmethod_17()
		{
			return new Class24.Class37((int)this.struct8_0.short_0, (Class24.Enum4)3);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00007B32 File Offset: 0x00005D32
		public override Class24.Class37 vmethod_18()
		{
			return new Class24.Class37((uint)this.struct8_0.ushort_0, (Class24.Enum4)4);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00007B45 File Offset: 0x00005D45
		public override Class24.Class37 vmethod_19()
		{
			return new Class24.Class37(this.struct8_0.int_0, (Class24.Enum4)5);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00007B58 File Offset: 0x00005D58
		public override Class24.Class37 vmethod_20()
		{
			return new Class24.Class37(this.struct8_0.uint_0, (Class24.Enum4)6);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00007B6B File Offset: 0x00005D6B
		public override Class24.Class38 vmethod_21()
		{
			return new Class24.Class38(this.struct8_0.long_0, (Class24.Enum4)7);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00007B7E File Offset: 0x00005D7E
		public override Class24.Class38 vmethod_22()
		{
			return new Class24.Class38(this.struct8_0.ulong_0, (Class24.Enum4)8);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0000795D File Offset: 0x00005B5D
		public override Class24.Class37 vmethod_23()
		{
			return this.vmethod_15();
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00007965 File Offset: 0x00005B65
		public override Class24.Class37 vmethod_24()
		{
			return this.vmethod_17();
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0000796D File Offset: 0x00005B6D
		public override Class24.Class37 vmethod_25()
		{
			return this.vmethod_19();
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00007975 File Offset: 0x00005B75
		public override Class24.Class38 vmethod_26()
		{
			return this.vmethod_21();
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0000797D File Offset: 0x00005B7D
		public override Class24.Class37 vmethod_27()
		{
			return this.vmethod_16();
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00007985 File Offset: 0x00005B85
		public override Class24.Class37 vmethod_28()
		{
			return this.vmethod_18();
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0000798D File Offset: 0x00005B8D
		public override Class24.Class37 vmethod_29()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00007995 File Offset: 0x00005B95
		public override Class24.Class38 vmethod_30()
		{
			return this.vmethod_22();
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00007B91 File Offset: 0x00005D91
		public override Class24.Class37 vmethod_31()
		{
			return new Class24.Class37((int)(checked((sbyte)this.struct8_0.long_0)), (Class24.Enum4)1);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00007BA5 File Offset: 0x00005DA5
		public override Class24.Class37 vmethod_32()
		{
			return new Class24.Class37((int)(checked((sbyte)this.struct8_0.ulong_0)), (Class24.Enum4)1);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00007BB9 File Offset: 0x00005DB9
		public override Class24.Class37 vmethod_33()
		{
			return new Class24.Class37((int)(checked((short)this.struct8_0.long_0)), (Class24.Enum4)3);
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00007BCD File Offset: 0x00005DCD
		public override Class24.Class37 vmethod_34()
		{
			return new Class24.Class37((int)(checked((short)this.struct8_0.ulong_0)), (Class24.Enum4)3);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00007BE1 File Offset: 0x00005DE1
		public override Class24.Class37 vmethod_35()
		{
			return new Class24.Class37(checked((int)this.struct8_0.long_0), (Class24.Enum4)5);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00007BF5 File Offset: 0x00005DF5
		public override Class24.Class37 vmethod_36()
		{
			return new Class24.Class37(checked((int)this.struct8_0.ulong_0), (Class24.Enum4)5);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00007B6B File Offset: 0x00005D6B
		public override Class24.Class38 vmethod_37()
		{
			return new Class24.Class38(this.struct8_0.long_0, (Class24.Enum4)7);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00007C09 File Offset: 0x00005E09
		public override Class24.Class38 vmethod_38()
		{
			return new Class24.Class38(checked((long)this.struct8_0.ulong_0), (Class24.Enum4)7);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00007C1D File Offset: 0x00005E1D
		public override Class24.Class37 vmethod_39()
		{
			return new Class24.Class37((int)(checked((byte)this.struct8_0.long_0)), (Class24.Enum4)2);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00007C31 File Offset: 0x00005E31
		public override Class24.Class37 vmethod_40()
		{
			return new Class24.Class37((int)(checked((byte)this.struct8_0.ulong_0)), (Class24.Enum4)2);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00007C45 File Offset: 0x00005E45
		public override Class24.Class37 vmethod_41()
		{
			return new Class24.Class37((int)(checked((ushort)this.struct8_0.long_0)), (Class24.Enum4)4);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00007C59 File Offset: 0x00005E59
		public override Class24.Class37 vmethod_42()
		{
			return new Class24.Class37((int)(checked((ushort)this.struct8_0.ulong_0)), (Class24.Enum4)4);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00007C6D File Offset: 0x00005E6D
		public override Class24.Class37 vmethod_43()
		{
			return new Class24.Class37(checked((uint)this.struct8_0.long_0), (Class24.Enum4)6);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00007C81 File Offset: 0x00005E81
		public override Class24.Class37 vmethod_44()
		{
			return new Class24.Class37(checked((uint)this.struct8_0.ulong_0), (Class24.Enum4)6);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00007C95 File Offset: 0x00005E95
		public override Class24.Class38 vmethod_45()
		{
			return new Class24.Class38(checked((ulong)this.struct8_0.long_0), (Class24.Enum4)8);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00007B7E File Offset: 0x00005D7E
		public override Class24.Class38 vmethod_46()
		{
			return new Class24.Class38(this.struct8_0.ulong_0, (Class24.Enum4)8);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00007CA9 File Offset: 0x00005EA9
		public override Class24.Class40 vmethod_47()
		{
			return new Class24.Class40((float)this.struct8_0.long_0);
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00007CBC File Offset: 0x00005EBC
		public override Class24.Class40 vmethod_48()
		{
			return new Class24.Class40((double)this.struct8_0.long_0);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00007CCF File Offset: 0x00005ECF
		public override Class24.Class40 vmethod_49()
		{
			return new Class24.Class40(this.struct8_0.ulong_0);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000A17A8 File Offset: 0x0009F9A8
		public override Class24.Class39 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_26().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_25().struct7_0.int_0);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000A17EC File Offset: 0x0009F9EC
		public override Class24.Class39 skgckirNpg()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_30().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_29().struct7_0.uint_0);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000A1830 File Offset: 0x0009FA30
		public override Class24.Class39 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_37().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_35().struct7_0.int_0);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x000A1874 File Offset: 0x0009FA74
		public override Class24.Class39 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_45().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_43().struct7_0.uint_0);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x000A18B8 File Offset: 0x0009FAB8
		public override Class24.Class39 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_38().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_36().struct7_0.int_0);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000A2C38 File Offset: 0x000A0E38
		public override Class24.Class39 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)(checked((uint)this.struct8_0.ulong_0)));
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00007CE3 File Offset: 0x00005EE3
		public override Class24.Class35 vmethod_55()
		{
			return new Class24.Class38(-this.struct8_0.long_0);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x000A2C70 File Offset: 0x000A0E70
		public override Class24.Class35 Add(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 + ((Class24.Class38)class35_0).struct8_0.long_0);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000A2CBC File Offset: 0x000A0EBC
		public override Class24.Class35 vmethod_56(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(checked(this.struct8_0.long_0 + ((Class24.Class38)class35_0).struct8_0.long_0));
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x000A2D08 File Offset: 0x000A0F08
		public override Class24.Class35 vmethod_57(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(checked(this.struct8_0.ulong_0 + ((Class24.Class38)class35_0).struct8_0.ulong_0));
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000A2D54 File Offset: 0x000A0F54
		public override Class24.Class35 vmethod_58(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 - ((Class24.Class38)class35_0).struct8_0.long_0);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000A2DA0 File Offset: 0x000A0FA0
		public override Class24.Class35 vmethod_59(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(checked(this.struct8_0.long_0 - ((Class24.Class38)class35_0).struct8_0.long_0));
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000A2DEC File Offset: 0x000A0FEC
		public override Class24.Class35 mvdcByduPo(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(checked(this.struct8_0.ulong_0 - ((Class24.Class38)class35_0).struct8_0.ulong_0));
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000A2E38 File Offset: 0x000A1038
		public override Class24.Class35 vmethod_60(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 * ((Class24.Class38)class35_0).struct8_0.long_0);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000A2E84 File Offset: 0x000A1084
		public override Class24.Class35 vmethod_61(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(checked(this.struct8_0.long_0 * ((Class24.Class38)class35_0).struct8_0.long_0));
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		public override Class24.Class35 vmethod_62(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(checked(this.struct8_0.ulong_0 * ((Class24.Class38)class35_0).struct8_0.ulong_0));
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000A2F1C File Offset: 0x000A111C
		public override Class24.Class35 vmethod_63(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 / ((Class24.Class38)class35_0).struct8_0.long_0);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000A2F68 File Offset: 0x000A1168
		public override Class24.Class35 vmethod_64(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.ulong_0 / ((Class24.Class38)class35_0).struct8_0.ulong_0);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000A2FB4 File Offset: 0x000A11B4
		public override Class24.Class35 vmethod_65(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 % ((Class24.Class38)class35_0).struct8_0.long_0);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000A3000 File Offset: 0x000A1200
		public override Class24.Class35 vmethod_66(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.ulong_0 % ((Class24.Class38)class35_0).struct8_0.ulong_0);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000A304C File Offset: 0x000A124C
		public override Class24.Class35 vmethod_67(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 & ((Class24.Class38)class35_0).struct8_0.long_0);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000A3098 File Offset: 0x000A1298
		public override Class24.Class35 vmethod_68(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 | ((Class24.Class38)class35_0).struct8_0.long_0);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00007CF6 File Offset: 0x00005EF6
		public override Class24.Class35 vmethod_69()
		{
			return new Class24.Class38(~this.struct8_0.long_0);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000A30E4 File Offset: 0x000A12E4
		public override Class24.Class35 vmethod_70(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 ^ ((Class24.Class38)class35_0).struct8_0.long_0);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000A3130 File Offset: 0x000A1330
		public override Class24.Class35 vmethod_72(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_2())
			{
				return new Class24.Class38(this.struct8_0.long_0 << ((Class24.Class38)class35_0).struct8_0.int_0);
			}
			if (!class35_0.vmethod_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 << ((Class24.Class36)class35_0).vmethod_19().struct7_0.int_0);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000A31B4 File Offset: 0x000A13B4
		public override Class24.Class35 vmethod_73(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_2())
			{
				return new Class24.Class38(this.struct8_0.long_0 >> ((Class24.Class38)class35_0).struct8_0.int_0);
			}
			if (!class35_0.vmethod_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.long_0 >> ((Class24.Class36)class35_0).vmethod_19().struct7_0.int_0);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000A3238 File Offset: 0x000A1438
		public override Class24.Class35 vmethod_74(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_2())
			{
				return new Class24.Class38(this.struct8_0.ulong_0 >> ((Class24.Class38)class35_0).struct8_0.int_0);
			}
			if (!class35_0.vmethod_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class38(this.struct8_0.ulong_0 >> ((Class24.Class36)class35_0).vmethod_19().struct7_0.int_0);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000A32BC File Offset: 0x000A14BC
		public override string ToString()
		{
			if (this.enum4_0 == (Class24.Enum4)7)
			{
				return this.struct8_0.long_0.ToString();
			}
			return this.struct8_0.ulong_0.ToString();
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00007ADA File Offset: 0x00005CDA
		internal override Class24.Class35 vmethod_8()
		{
			return this;
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002C18 File Offset: 0x00000E18
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000A32F4 File Offset: 0x000A14F4
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			if (class35_0.anLwXoVydS())
			{
				return ((Class24.Class47)class35_0).vmethod_5(this);
			}
			if (!class35_0.vmethod_0())
			{
				Class24.Class35 @class = class35_0.vmethod_8();
				return @class.method_2() && this.struct8_0.long_0 == ((Class24.Class38)@class).struct8_0.long_0;
			}
			return ((Class24.Class41)class35_0).vmethod_5(this);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x000A21FC File Offset: 0x000A03FC
		private static Class24.Class36 smethod_4(Class24.Class35 class35_0)
		{
			Class24.Class36 @class = class35_0 as Class24.Class36;
			if (@class == null && class35_0.vmethod_0())
			{
				@class = class35_0.vmethod_8() as Class24.Class36;
			}
			return @class;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000A335C File Offset: 0x000A155C
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			if (class35_0.anLwXoVydS())
			{
				return false;
			}
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_6(this);
			}
			Class24.Class35 @class = class35_0.vmethod_8();
			return @class.method_2() && this.struct8_0.ulong_0 != ((Class24.Class38)@class).struct8_0.ulong_0;
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000A33BC File Offset: 0x000A15BC
		public override bool vmethod_75(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return this.struct8_0.long_0 >= ((Class24.Class38)class35_0).struct8_0.long_0;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000A3408 File Offset: 0x000A1608
		public override bool vmethod_76(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return this.struct8_0.ulong_0 >= ((Class24.Class38)class35_0).struct8_0.ulong_0;
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000A3454 File Offset: 0x000A1654
		public override bool vmethod_77(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return this.struct8_0.long_0 > ((Class24.Class38)class35_0).struct8_0.long_0;
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000A349C File Offset: 0x000A169C
		public override bool vmethod_78(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return this.struct8_0.ulong_0 > ((Class24.Class38)class35_0).struct8_0.ulong_0;
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000A34E4 File Offset: 0x000A16E4
		public override bool vmethod_79(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return this.struct8_0.long_0 <= ((Class24.Class38)class35_0).struct8_0.long_0;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000A3530 File Offset: 0x000A1730
		public override bool vmethod_80(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return this.struct8_0.ulong_0 <= ((Class24.Class38)class35_0).struct8_0.ulong_0;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x000A357C File Offset: 0x000A177C
		public override bool vmethod_81(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return this.struct8_0.long_0 < ((Class24.Class38)class35_0).struct8_0.long_0;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000A35C4 File Offset: 0x000A17C4
		public override bool vmethod_82(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_2())
			{
				throw new Class24.Exception1();
			}
			return this.struct8_0.ulong_0 < ((Class24.Class38)class35_0).struct8_0.ulong_0;
		}

		// Token: 0x040008F1 RID: 2289
		public Class24.Struct8 struct8_0;

		// Token: 0x040008F2 RID: 2290
		public Class24.Enum4 enum4_0;
	}

	// Token: 0x020001EB RID: 491
	private class Class39 : Class24.Class36
	{
		// Token: 0x060015CA RID: 5578 RVA: 0x000A360C File Offset: 0x000A180C
		internal void method_5(Class24.Class35 class35_0)
		{
			if (!class35_0.method_1())
			{
				this.vmethod_10(class35_0);
				return;
			}
			this.object_0 = ((Class24.Class39)class35_0).object_0;
			this.enum4_0 = ((Class24.Class39)class35_0).enum4_0;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x000A364C File Offset: 0x000A184C
		internal unsafe override void vmethod_10(Class24.Class35 class35_0)
		{
			if (class35_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					IntPtr intPtr = new IntPtr(((Class24.Class38)this.object_0).struct8_0.long_0);
					IntPtr intPtr2 = new IntPtr(((Class24.Class38)((Class24.Class39)class35_0).object_0).struct8_0.long_0);
					*(long*)(void*)intPtr = intPtr2.ToInt64();
					return;
				}
				IntPtr intPtr3 = new IntPtr(((Class24.Class37)this.object_0).struct7_0.int_0);
				IntPtr intPtr4 = new IntPtr(((Class24.Class37)((Class24.Class39)class35_0).object_0).struct7_0.int_0);
				*(int*)(void*)intPtr3 = intPtr4.ToInt32();
				return;
			}
			else
			{
				object obj = class35_0.vmethod_4(null);
				if (obj == null)
				{
					return;
				}
				IntPtr intPtr5;
				if (IntPtr.Size == 8)
				{
					intPtr5 = new IntPtr(((Class24.Class38)this.object_0).struct8_0.long_0);
				}
				else
				{
					intPtr5 = new IntPtr(((Class24.Class37)this.object_0).struct7_0.int_0);
				}
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (type == typeof(byte))
				{
					*(byte*)(void*)intPtr5 = (byte)obj;
					return;
				}
				if (type == typeof(sbyte))
				{
					*(byte*)(void*)intPtr5 = (byte)((sbyte)obj);
					return;
				}
				if (type == typeof(short))
				{
					*(short*)(void*)intPtr5 = (short)obj;
					return;
				}
				if (type == typeof(ushort))
				{
					*(short*)(void*)intPtr5 = (short)((ushort)obj);
					return;
				}
				if (type == typeof(int))
				{
					*(int*)(void*)intPtr5 = (int)obj;
					return;
				}
				if (type == typeof(uint))
				{
					*(int*)(void*)intPtr5 = (int)((uint)obj);
					return;
				}
				if (type == typeof(long))
				{
					*(long*)(void*)intPtr5 = (long)obj;
					return;
				}
				if (type == typeof(ulong))
				{
					*(long*)(void*)intPtr5 = (long)((ulong)obj);
					return;
				}
				if (type == typeof(float))
				{
					*(float*)(void*)intPtr5 = (float)obj;
					return;
				}
				if (type == typeof(double))
				{
					*(double*)(void*)intPtr5 = (double)obj;
					return;
				}
				if (type == typeof(bool))
				{
					*(byte*)(void*)intPtr5 = (((bool)obj) ? 1 : 0);
					return;
				}
				if (type == typeof(IntPtr))
				{
					*(IntPtr*)(void*)intPtr5 = (IntPtr)obj;
					return;
				}
				if (type == typeof(UIntPtr))
				{
					*(IntPtr*)(void*)intPtr5 = (IntPtr)((UIntPtr)obj);
					return;
				}
				if (type == typeof(char))
				{
					*(short*)(void*)intPtr5 = (short)((char)obj);
					return;
				}
				throw new Class24.Exception1();
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x000A1074 File Offset: 0x0009F274
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_10(class35_0);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000A3970 File Offset: 0x000A1B70
		public Class39(IntPtr intptr_0)
		{
			this.enum7_0 = (Class24.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class24.Class38(intptr_0.ToInt64());
				this.enum4_0 = (Class24.Enum4)12;
				return;
			}
			this.object_0 = new Class24.Class37(intptr_0.ToInt32());
			this.enum4_0 = (Class24.Enum4)12;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000A39CC File Offset: 0x000A1BCC
		public Class39(UIntPtr uintptr_0)
		{
			this.enum7_0 = (Class24.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class24.Class38(uintptr_0.ToUInt64());
				this.enum4_0 = (Class24.Enum4)12;
				return;
			}
			this.object_0 = new Class24.Class37(uintptr_0.ToUInt32());
			this.enum4_0 = (Class24.Enum4)12;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000A3A28 File Offset: 0x000A1C28
		public Class39()
		{
			this.enum7_0 = (Class24.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class24.Class38(0L);
				this.enum4_0 = (Class24.Enum4)12;
				return;
			}
			this.object_0 = new Class24.Class37(0);
			this.enum4_0 = (Class24.Enum4)12;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00007D09 File Offset: 0x00005F09
		public override Class24.Class36 vmethod_71()
		{
			return new Class24.Class39
			{
				object_0 = this.object_0.vmethod_71(),
				enum4_0 = this.enum4_0
			};
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x000A3A80 File Offset: 0x000A1C80
		public Class39(long long_0)
		{
			this.enum7_0 = (Class24.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class24.Class38(long_0);
				this.enum4_0 = (Class24.Enum4)12;
				return;
			}
			this.object_0 = new Class24.Class37((int)long_0);
			this.enum4_0 = (Class24.Enum4)12;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x000A3AD0 File Offset: 0x000A1CD0
		public Class39(long long_0, Class24.Enum4 enum4_1)
		{
			this.enum7_0 = (Class24.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class24.Class38(long_0);
				this.enum4_0 = enum4_1;
				return;
			}
			this.object_0 = new Class24.Class37((int)long_0);
			this.enum4_0 = enum4_1;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000A3B1C File Offset: 0x000A1D1C
		public Class39(ulong ulong_0)
		{
			this.enum7_0 = (Class24.Enum7)4;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class24.Class38(ulong_0);
				this.enum4_0 = (Class24.Enum4)13;
				return;
			}
			this.object_0 = new Class24.Class37((uint)ulong_0);
			this.enum4_0 = (Class24.Enum4)13;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000A3B6C File Offset: 0x000A1D6C
		public Class39(ulong ulong_0, Class24.Enum4 enum4_1)
		{
			this.enum7_0 = (Class24.Enum7)4;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class24.Class38(ulong_0);
				this.enum4_0 = enum4_1;
				return;
			}
			this.object_0 = new Class24.Class37((uint)ulong_0);
			this.enum4_0 = enum4_1;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00007D2D File Offset: 0x00005F2D
		public override bool vmethod_11()
		{
			return this.object_0.vmethod_11();
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0000788C File Offset: 0x00005A8C
		public override bool vmethod_12()
		{
			return !this.vmethod_11();
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000078A7 File Offset: 0x00005AA7
		internal override bool vmethod_7()
		{
			return this.vmethod_12();
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002C18 File Offset: 0x00000E18
		internal override bool vmethod_1()
		{
			return true;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x000A3BB8 File Offset: 0x000A1DB8
		public override Class24.Class35 vmethod_13(Class24.Enum4 enum4_1)
		{
			switch (enum4_1)
			{
			case (Class24.Enum4)1:
				return this.vmethod_15();
			case (Class24.Enum4)2:
				return this.vmethod_16();
			case (Class24.Enum4)3:
				return this.vmethod_17();
			case (Class24.Enum4)4:
				return this.vmethod_18();
			case (Class24.Enum4)5:
				return this.vmethod_19();
			case (Class24.Enum4)6:
				return this.vmethod_20();
			case (Class24.Enum4)7:
				return this.vmethod_21();
			case (Class24.Enum4)8:
				return this.vmethod_22();
			case (Class24.Enum4)11:
				return this.vmethod_14();
			case (Class24.Enum4)12:
				return this;
			case (Class24.Enum4)13:
				return this;
			case (Class24.Enum4)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class24.Enum8)4).ToString());
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000A3C70 File Offset: 0x000A1E70
		internal IntPtr method_6()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class24.Class38)this.object_0).struct8_0.long_0);
			}
			return new IntPtr(((Class24.Class37)this.object_0).struct7_0.int_0);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x000A3CBC File Offset: 0x000A1EBC
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (!(type_0 == typeof(IntPtr)))
			{
				if (type_0 == typeof(UIntPtr))
				{
					if (IntPtr.Size == 8)
					{
						return new UIntPtr(((Class24.Class38)this.object_0).struct8_0.ulong_0);
					}
					return new UIntPtr(((Class24.Class37)this.object_0).struct7_0.uint_0);
				}
				else
				{
					if (!(type_0 == null) && !(type_0 == typeof(object)))
					{
						throw new Class24.Exception1();
					}
					if (IntPtr.Size == 8)
					{
						if (this.enum4_0 == (Class24.Enum4)12)
						{
							return new IntPtr(((Class24.Class38)this.object_0).struct8_0.long_0);
						}
						return new UIntPtr(((Class24.Class38)this.object_0).struct8_0.ulong_0);
					}
					else
					{
						if (this.enum4_0 == (Class24.Enum4)12)
						{
							return new IntPtr(((Class24.Class38)this.object_0).struct8_0.int_0);
						}
						return new UIntPtr(((Class24.Class37)this.object_0).struct7_0.uint_0);
					}
				}
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class24.Class38)this.object_0).struct8_0.long_0);
				}
				return new IntPtr(((Class24.Class37)this.object_0).struct7_0.int_0);
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00007D3A File Offset: 0x00005F3A
		public override Class24.Class37 vmethod_14()
		{
			return this.object_0.vmethod_14();
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00007D47 File Offset: 0x00005F47
		public override Class24.Class37 vmethod_15()
		{
			return this.object_0.vmethod_15();
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00007D54 File Offset: 0x00005F54
		public override Class24.Class37 vmethod_16()
		{
			return this.object_0.vmethod_16();
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00007D61 File Offset: 0x00005F61
		public override Class24.Class37 vmethod_17()
		{
			return this.object_0.vmethod_17();
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00007D6E File Offset: 0x00005F6E
		public override Class24.Class37 vmethod_18()
		{
			return this.object_0.vmethod_18();
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00007D7B File Offset: 0x00005F7B
		public override Class24.Class37 vmethod_19()
		{
			return this.object_0.vmethod_19();
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00007D88 File Offset: 0x00005F88
		public override Class24.Class37 vmethod_20()
		{
			return this.object_0.vmethod_20();
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00007D95 File Offset: 0x00005F95
		public override Class24.Class38 vmethod_21()
		{
			return this.object_0.vmethod_21();
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00007DA2 File Offset: 0x00005FA2
		public override Class24.Class38 vmethod_22()
		{
			return this.object_0.vmethod_22();
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0000795D File Offset: 0x00005B5D
		public override Class24.Class37 vmethod_23()
		{
			return this.vmethod_15();
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00007965 File Offset: 0x00005B65
		public override Class24.Class37 vmethod_24()
		{
			return this.vmethod_17();
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0000796D File Offset: 0x00005B6D
		public override Class24.Class37 vmethod_25()
		{
			return this.vmethod_19();
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00007975 File Offset: 0x00005B75
		public override Class24.Class38 vmethod_26()
		{
			return this.vmethod_21();
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0000797D File Offset: 0x00005B7D
		public override Class24.Class37 vmethod_27()
		{
			return this.vmethod_16();
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00007985 File Offset: 0x00005B85
		public override Class24.Class37 vmethod_28()
		{
			return this.vmethod_18();
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0000798D File Offset: 0x00005B8D
		public override Class24.Class37 vmethod_29()
		{
			return this.vmethod_20();
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00007995 File Offset: 0x00005B95
		public override Class24.Class38 vmethod_30()
		{
			return this.vmethod_22();
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00007DAF File Offset: 0x00005FAF
		public override Class24.Class37 vmethod_31()
		{
			return this.object_0.vmethod_31();
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00007DBC File Offset: 0x00005FBC
		public override Class24.Class37 vmethod_32()
		{
			return this.object_0.vmethod_32();
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00007DC9 File Offset: 0x00005FC9
		public override Class24.Class37 vmethod_33()
		{
			return this.object_0.vmethod_33();
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00007DD6 File Offset: 0x00005FD6
		public override Class24.Class37 vmethod_34()
		{
			return this.object_0.vmethod_34();
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00007DE3 File Offset: 0x00005FE3
		public override Class24.Class37 vmethod_35()
		{
			return this.object_0.vmethod_35();
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public override Class24.Class37 vmethod_36()
		{
			return this.object_0.vmethod_36();
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00007DFD File Offset: 0x00005FFD
		public override Class24.Class38 vmethod_37()
		{
			return this.object_0.vmethod_37();
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00007E0A File Offset: 0x0000600A
		public override Class24.Class38 vmethod_38()
		{
			return this.object_0.vmethod_38();
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00007E17 File Offset: 0x00006017
		public override Class24.Class37 vmethod_39()
		{
			return this.object_0.vmethod_39();
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00007E24 File Offset: 0x00006024
		public override Class24.Class37 vmethod_40()
		{
			return this.object_0.vmethod_40();
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00007E31 File Offset: 0x00006031
		public override Class24.Class37 vmethod_41()
		{
			return this.object_0.vmethod_41();
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00007E3E File Offset: 0x0000603E
		public override Class24.Class37 vmethod_42()
		{
			return this.object_0.vmethod_42();
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00007E4B File Offset: 0x0000604B
		public override Class24.Class37 vmethod_43()
		{
			return this.object_0.vmethod_43();
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00007E58 File Offset: 0x00006058
		public override Class24.Class37 vmethod_44()
		{
			return this.object_0.vmethod_44();
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00007E65 File Offset: 0x00006065
		public override Class24.Class38 vmethod_45()
		{
			return this.object_0.vmethod_45();
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00007E72 File Offset: 0x00006072
		public override Class24.Class38 vmethod_46()
		{
			return this.object_0.vmethod_46();
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00007E7F File Offset: 0x0000607F
		public override Class24.Class40 vmethod_47()
		{
			return this.object_0.vmethod_47();
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00007E8C File Offset: 0x0000608C
		public override Class24.Class40 vmethod_48()
		{
			return this.object_0.vmethod_48();
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00007E99 File Offset: 0x00006099
		public override Class24.Class40 vmethod_49()
		{
			return this.object_0.vmethod_49();
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000A17A8 File Offset: 0x0009F9A8
		public override Class24.Class39 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_26().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_25().struct7_0.int_0);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x000A17EC File Offset: 0x0009F9EC
		public override Class24.Class39 skgckirNpg()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_30().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_29().struct7_0.uint_0);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000A1830 File Offset: 0x0009FA30
		public override Class24.Class39 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_37().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_35().struct7_0.int_0);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000A1874 File Offset: 0x0009FA74
		public override Class24.Class39 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_45().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_43().struct7_0.uint_0);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000A18B8 File Offset: 0x0009FAB8
		public override Class24.Class39 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_38().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_36().struct7_0.int_0);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000A18FC File Offset: 0x0009FAFC
		public override Class24.Class39 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_46().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_44().struct7_0.uint_0);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x000A3E58 File Offset: 0x000A2058
		public override Class24.Class35 vmethod_55()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(-((Class24.Class38)this.object_0).struct8_0.long_0);
			}
			return new Class24.Class39((long)(-(long)((Class24.Class37)this.object_0).struct7_0.int_0));
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000A3EA8 File Offset: 0x000A20A8
		public override Class24.Class35 Add(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 + ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 + ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 + ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 + ((Class24.Class37)class35_0).struct7_0.int_0));
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000A3F98 File Offset: 0x000A2198
		public override Class24.Class35 vmethod_56(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.long_0 + ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0));
				}
				return new Class24.Class39((long)(checked(this.vmethod_19().struct7_0.int_0 + ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.long_0 + ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0));
				}
				return new Class24.Class39((long)(checked(this.vmethod_19().struct7_0.int_0 + ((Class24.Class37)class35_0).struct7_0.int_0)));
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000A4088 File Offset: 0x000A2288
		public override Class24.Class35 vmethod_57(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.ulong_0 + ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0));
				}
				return new Class24.Class39((ulong)(checked(this.vmethod_19().struct7_0.uint_0 + ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0)));
			}
			else
			{
				checked
				{
					if (IntPtr.Size == 8)
					{
						return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 + unchecked((ulong)((Class24.Class37)class35_0).struct7_0.uint_0));
					}
				}
				return new Class24.Class39((long)((ulong)(checked(this.vmethod_19().struct7_0.uint_0 + ((Class24.Class37)class35_0).struct7_0.uint_0))));
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x000A4174 File Offset: 0x000A2374
		public override Class24.Class35 vmethod_58(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 - ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 - ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 - ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 - ((Class24.Class37)class35_0).struct7_0.int_0));
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000A4264 File Offset: 0x000A2464
		public Class24.Class35 method_7(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0 - this.vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(((Class24.Class37)class35_0).struct7_0.int_0 - this.vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0 - this.vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0 - this.vmethod_19().struct7_0.int_0));
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000A4354 File Offset: 0x000A2554
		public override Class24.Class35 vmethod_59(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.long_0 - ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0));
				}
				return new Class24.Class39((long)(checked(this.vmethod_19().struct7_0.int_0 - ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.long_0 - ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0));
				}
				return new Class24.Class39((long)(checked(this.vmethod_19().struct7_0.int_0 - ((Class24.Class37)class35_0).struct7_0.int_0)));
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x000A4444 File Offset: 0x000A2644
		public Class24.Class35 method_8(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0 - this.vmethod_21().struct8_0.long_0));
				}
				return new Class24.Class39((long)(checked(((Class24.Class37)class35_0).struct7_0.int_0 - this.vmethod_19().struct7_0.int_0)));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0 - this.vmethod_21().struct8_0.long_0));
				}
				return new Class24.Class39((long)(checked(((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0 - this.vmethod_19().struct7_0.int_0)));
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000A4534 File Offset: 0x000A2734
		public override Class24.Class35 mvdcByduPo(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				checked
				{
					if (IntPtr.Size == 8)
					{
						return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 - unchecked((ulong)((Class24.Class37)class35_0).struct7_0.uint_0));
					}
				}
				return new Class24.Class39((long)((ulong)(checked(this.vmethod_19().struct7_0.uint_0 - ((Class24.Class37)class35_0).struct7_0.uint_0))));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.ulong_0 - ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0));
				}
				return new Class24.Class39((ulong)(checked(this.vmethod_19().struct7_0.uint_0 - ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0)));
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000A4620 File Offset: 0x000A2820
		public Class24.Class35 method_9(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				checked
				{
					if (IntPtr.Size == 8)
					{
						return new Class24.Class39(unchecked((ulong)((Class24.Class37)class35_0).struct7_0.uint_0) - this.vmethod_21().struct8_0.ulong_0);
					}
				}
				return new Class24.Class39((long)((ulong)(checked(((Class24.Class37)class35_0).struct7_0.uint_0 - this.vmethod_19().struct7_0.uint_0))));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0 - this.vmethod_21().struct8_0.ulong_0));
				}
				return new Class24.Class39((ulong)(checked(((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0 - this.vmethod_19().struct7_0.uint_0)));
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000A470C File Offset: 0x000A290C
		public override Class24.Class35 vmethod_60(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 * ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 * ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 * ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 * ((Class24.Class37)class35_0).struct7_0.int_0));
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000A47FC File Offset: 0x000A29FC
		public override Class24.Class35 vmethod_61(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.long_0 * ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0));
				}
				return new Class24.Class39((long)(checked(this.vmethod_19().struct7_0.int_0 * ((Class24.Class37)class35_0).struct7_0.int_0)));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.long_0 * ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0));
				}
				return new Class24.Class39((long)(checked(this.vmethod_19().struct7_0.int_0 * ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0)));
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000A48EC File Offset: 0x000A2AEC
		public override Class24.Class35 vmethod_62(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(checked(this.vmethod_21().struct8_0.ulong_0 * ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0));
				}
				return new Class24.Class39((ulong)(checked(this.vmethod_19().struct7_0.uint_0 * ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0)));
			}
			else
			{
				checked
				{
					if (IntPtr.Size == 8)
					{
						return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 * unchecked((ulong)((Class24.Class37)class35_0).struct7_0.uint_0));
					}
				}
				return new Class24.Class39((long)((ulong)(checked(this.vmethod_19().struct7_0.uint_0 * ((Class24.Class37)class35_0).struct7_0.uint_0))));
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000A49D8 File Offset: 0x000A2BD8
		public override Class24.Class35 vmethod_63(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 / ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 / ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 / ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 / ((Class24.Class37)class35_0).struct7_0.int_0));
			}
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000A4AC8 File Offset: 0x000A2CC8
		public Class24.Class35 method_10(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0 / this.vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0 / this.vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0 / this.vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(((Class24.Class37)class35_0).struct7_0.int_0 / this.vmethod_19().struct7_0.int_0));
			}
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000A4BB8 File Offset: 0x000A2DB8
		public override Class24.Class35 vmethod_64(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 / ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0);
				}
				return new Class24.Class39((ulong)(this.vmethod_19().struct7_0.uint_0 / ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 / ((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0);
				}
				return new Class24.Class39((long)((ulong)(this.vmethod_19().struct7_0.uint_0 / ((Class24.Class37)class35_0).struct7_0.uint_0)));
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000A4CA8 File Offset: 0x000A2EA8
		public Class24.Class35 method_11(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0 / this.vmethod_21().struct8_0.ulong_0);
				}
				return new Class24.Class39((long)((ulong)(((Class24.Class37)class35_0).struct7_0.uint_0 / this.vmethod_19().struct7_0.uint_0)));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0 / this.vmethod_21().struct8_0.ulong_0);
				}
				return new Class24.Class39((ulong)(((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0 / this.vmethod_19().struct7_0.uint_0));
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000A4D98 File Offset: 0x000A2F98
		public override Class24.Class35 vmethod_65(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 % ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 % ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 % ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 % ((Class24.Class37)class35_0).struct7_0.int_0));
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000A4E88 File Offset: 0x000A3088
		public Class24.Class35 method_12(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0 % this.vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0 % this.vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0 % this.vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(((Class24.Class37)class35_0).struct7_0.int_0 % this.vmethod_19().struct7_0.int_0));
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000A4F78 File Offset: 0x000A3178
		public override Class24.Class35 vmethod_66(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 % ((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0);
				}
				return new Class24.Class39((long)((ulong)(this.vmethod_19().struct7_0.uint_0 % ((Class24.Class37)class35_0).struct7_0.uint_0)));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 % ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0);
				}
				return new Class24.Class39((ulong)(this.vmethod_19().struct7_0.uint_0 % ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0));
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x000A5068 File Offset: 0x000A3268
		public Class24.Class35 method_13(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0 % this.vmethod_21().struct8_0.ulong_0);
				}
				return new Class24.Class39((ulong)(((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0 % this.vmethod_19().struct7_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0 % this.vmethod_21().struct8_0.ulong_0);
				}
				return new Class24.Class39((long)((ulong)(((Class24.Class37)class35_0).struct7_0.uint_0 % this.vmethod_19().struct7_0.uint_0)));
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000A5158 File Offset: 0x000A3358
		public override Class24.Class35 vmethod_67(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 & ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 & ((Class24.Class37)class35_0).struct7_0.int_0));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 & ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 & ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000A5248 File Offset: 0x000A3448
		public override Class24.Class35 vmethod_68(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 | ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 | ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 | ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 | ((Class24.Class37)class35_0).struct7_0.int_0));
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000A5338 File Offset: 0x000A3538
		public override Class24.Class35 vmethod_69()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(~this.vmethod_21().struct8_0.long_0);
			}
			return new Class24.Class39((long)(~(long)this.vmethod_19().struct7_0.int_0));
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000A537C File Offset: 0x000A357C
		public override Class24.Class35 vmethod_70(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 ^ ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 ^ ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 ^ ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 ^ ((Class24.Class37)class35_0).struct7_0.int_0));
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000A546C File Offset: 0x000A366C
		public override Class24.Class35 vmethod_72(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 << ((Class24.Class39)class35_0).vmethod_21().struct8_0.int_0);
				}
				return new Class24.Class39((long)((long)this.vmethod_19().struct7_0.int_0 << ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 << ((Class24.Class37)class35_0).struct7_0.int_0);
				}
				return new Class24.Class39((long)((long)this.vmethod_19().struct7_0.int_0 << ((Class24.Class37)class35_0).struct7_0.int_0));
			}
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000A5564 File Offset: 0x000A3764
		public override Class24.Class35 vmethod_73(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 >> ((Class24.Class37)class35_0).struct7_0.int_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 >> ((Class24.Class37)class35_0).struct7_0.int_0));
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.long_0 >> ((Class24.Class39)class35_0).vmethod_21().struct8_0.int_0);
				}
				return new Class24.Class39((long)(this.vmethod_19().struct7_0.int_0 >> ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0));
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000A565C File Offset: 0x000A385C
		public override Class24.Class35 vmethod_74(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 >> ((Class24.Class39)class35_0).vmethod_21().struct8_0.int_0);
				}
				return new Class24.Class39((long)((ulong)(this.vmethod_19().struct7_0.uint_0 >> ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class24.Class39(this.vmethod_21().struct8_0.ulong_0 >> ((Class24.Class37)class35_0).struct7_0.int_0);
				}
				return new Class24.Class39((long)((ulong)(this.vmethod_19().struct7_0.uint_0 >> ((Class24.Class37)class35_0).struct7_0.int_0)));
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00007EA6 File Offset: 0x000060A6
		public Class24.Class35 method_14(Class24.Class37 class37_0)
		{
			return new Class24.Class39((long)((ulong)(class37_0.struct7_0.uint_0 >> this.vmethod_19().struct7_0.int_0)));
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00007ECD File Offset: 0x000060CD
		public Class24.Class35 method_15(Class24.Class37 class37_0)
		{
			return new Class24.Class39((long)(class37_0.struct7_0.int_0 >> this.vmethod_21().struct8_0.int_0));
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00007EF4 File Offset: 0x000060F4
		public Class24.Class35 method_16(Class24.Class37 class37_0)
		{
			return new Class24.Class39((long)((long)class37_0.struct7_0.int_0 << this.vmethod_21().struct8_0.int_0));
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00007F1B File Offset: 0x0000611B
		public override string ToString()
		{
			return this.object_0.ToString();
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00007ADA File Offset: 0x00005CDA
		internal override Class24.Class35 vmethod_8()
		{
			return this;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002C18 File Offset: 0x00000E18
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000A5754 File Offset: 0x000A3954
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			if (class35_0.anLwXoVydS())
			{
				return false;
			}
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_5(this);
			}
			Class24.Class35 @class = class35_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 == ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 == ((Class24.Class37)class35_0).struct7_0.int_0;
			}
			else
			{
				if (!@class.method_1())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_21().struct8_0.long_0 == ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0;
			}
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000A582C File Offset: 0x000A3A2C
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			if (class35_0.anLwXoVydS())
			{
				return false;
			}
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_6(this);
			}
			Class24.Class35 @class = class35_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (!@class.method_0())
			{
				if (!@class.method_1())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_21().struct8_0.ulong_0 != ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 != ((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 != ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000A5908 File Offset: 0x000A3B08
		public override bool vmethod_75(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 >= ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 >= ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 >= ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 >= ((Class24.Class37)class35_0).struct7_0.int_0;
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000A59F4 File Offset: 0x000A3BF4
		public override bool vmethod_76(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 >= ((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 >= ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 >= ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 >= ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0;
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000A5AE0 File Offset: 0x000A3CE0
		public override bool vmethod_77(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 > ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 > ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 > ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 > ((Class24.Class37)class35_0).struct7_0.int_0;
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000A5BC0 File Offset: 0x000A3DC0
		public override bool vmethod_78(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 > ((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 > ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 > ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 > ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0;
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000A5CA0 File Offset: 0x000A3EA0
		public override bool vmethod_79(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 <= ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 <= ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 <= ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 <= ((Class24.Class37)class35_0).struct7_0.int_0;
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000A5D8C File Offset: 0x000A3F8C
		public override bool vmethod_80(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 <= ((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 <= ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 <= ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 <= ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0;
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000A5E78 File Offset: 0x000A4078
		public override bool vmethod_81(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (class35_0.method_0())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 < ((Class24.Class37)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 < ((Class24.Class37)class35_0).struct7_0.int_0;
			}
			else
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.long_0 < ((Class24.Class39)class35_0).vmethod_21().struct8_0.long_0;
				}
				return this.vmethod_19().struct7_0.int_0 < ((Class24.Class39)class35_0).vmethod_19().struct7_0.int_0;
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000A5F58 File Offset: 0x000A4158
		public override bool vmethod_82(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_0())
			{
				if (!class35_0.method_1())
				{
					throw new Class24.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 < ((Class24.Class39)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 < ((Class24.Class39)class35_0).vmethod_19().struct7_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_21().struct8_0.ulong_0 < ((Class24.Class37)class35_0).vmethod_21().struct8_0.ulong_0;
				}
				return this.vmethod_19().struct7_0.uint_0 < ((Class24.Class37)class35_0).struct7_0.uint_0;
			}
		}

		// Token: 0x040008F4 RID: 2292
		public object object_0;

		// Token: 0x040008F5 RID: 2293
		public Class24.Enum4 enum4_0;
	}

	// Token: 0x020001EC RID: 492
	private abstract class Class36 : Class24.Class35
	{
		// Token: 0x06001635 RID: 5685
		public abstract bool vmethod_11();

		// Token: 0x06001636 RID: 5686
		public abstract bool vmethod_12();

		// Token: 0x06001637 RID: 5687
		public abstract Class24.Class35 vmethod_13(Class24.Enum4 enum4_0);

		// Token: 0x06001638 RID: 5688
		public abstract Class24.Class37 vmethod_14();

		// Token: 0x06001639 RID: 5689
		public abstract Class24.Class37 vmethod_15();

		// Token: 0x0600163A RID: 5690
		public abstract Class24.Class37 vmethod_16();

		// Token: 0x0600163B RID: 5691
		public abstract Class24.Class37 vmethod_17();

		// Token: 0x0600163C RID: 5692
		public abstract Class24.Class37 vmethod_18();

		// Token: 0x0600163D RID: 5693
		public abstract Class24.Class37 vmethod_19();

		// Token: 0x0600163E RID: 5694
		public abstract Class24.Class37 vmethod_20();

		// Token: 0x0600163F RID: 5695
		public abstract Class24.Class38 vmethod_21();

		// Token: 0x06001640 RID: 5696
		public abstract Class24.Class38 vmethod_22();

		// Token: 0x06001641 RID: 5697
		public abstract Class24.Class37 vmethod_23();

		// Token: 0x06001642 RID: 5698
		public abstract Class24.Class37 vmethod_24();

		// Token: 0x06001643 RID: 5699
		public abstract Class24.Class37 vmethod_25();

		// Token: 0x06001644 RID: 5700
		public abstract Class24.Class38 vmethod_26();

		// Token: 0x06001645 RID: 5701
		public abstract Class24.Class37 vmethod_27();

		// Token: 0x06001646 RID: 5702
		public abstract Class24.Class37 vmethod_28();

		// Token: 0x06001647 RID: 5703
		public abstract Class24.Class37 vmethod_29();

		// Token: 0x06001648 RID: 5704
		public abstract Class24.Class38 vmethod_30();

		// Token: 0x06001649 RID: 5705
		public abstract Class24.Class37 vmethod_31();

		// Token: 0x0600164A RID: 5706
		public abstract Class24.Class37 vmethod_32();

		// Token: 0x0600164B RID: 5707
		public abstract Class24.Class37 vmethod_33();

		// Token: 0x0600164C RID: 5708
		public abstract Class24.Class37 vmethod_34();

		// Token: 0x0600164D RID: 5709
		public abstract Class24.Class37 vmethod_35();

		// Token: 0x0600164E RID: 5710
		public abstract Class24.Class37 vmethod_36();

		// Token: 0x0600164F RID: 5711
		public abstract Class24.Class38 vmethod_37();

		// Token: 0x06001650 RID: 5712
		public abstract Class24.Class38 vmethod_38();

		// Token: 0x06001651 RID: 5713
		public abstract Class24.Class37 vmethod_39();

		// Token: 0x06001652 RID: 5714
		public abstract Class24.Class37 vmethod_40();

		// Token: 0x06001653 RID: 5715
		public abstract Class24.Class37 vmethod_41();

		// Token: 0x06001654 RID: 5716
		public abstract Class24.Class37 vmethod_42();

		// Token: 0x06001655 RID: 5717
		public abstract Class24.Class37 vmethod_43();

		// Token: 0x06001656 RID: 5718
		public abstract Class24.Class37 vmethod_44();

		// Token: 0x06001657 RID: 5719
		public abstract Class24.Class38 vmethod_45();

		// Token: 0x06001658 RID: 5720
		public abstract Class24.Class38 vmethod_46();

		// Token: 0x06001659 RID: 5721
		public abstract Class24.Class40 vmethod_47();

		// Token: 0x0600165A RID: 5722
		public abstract Class24.Class40 vmethod_48();

		// Token: 0x0600165B RID: 5723
		public abstract Class24.Class40 vmethod_49();

		// Token: 0x0600165C RID: 5724
		public abstract Class24.Class39 vmethod_50();

		// Token: 0x0600165D RID: 5725
		public abstract Class24.Class39 skgckirNpg();

		// Token: 0x0600165E RID: 5726
		public abstract Class24.Class39 vmethod_51();

		// Token: 0x0600165F RID: 5727
		public abstract Class24.Class39 vmethod_52();

		// Token: 0x06001660 RID: 5728
		public abstract Class24.Class39 vmethod_53();

		// Token: 0x06001661 RID: 5729
		public abstract Class24.Class39 vmethod_54();

		// Token: 0x06001662 RID: 5730
		public abstract Class24.Class35 vmethod_55();

		// Token: 0x06001663 RID: 5731
		public abstract Class24.Class35 Add(Class24.Class35 class35_0);

		// Token: 0x06001664 RID: 5732
		public abstract Class24.Class35 vmethod_56(Class24.Class35 class35_0);

		// Token: 0x06001665 RID: 5733
		public abstract Class24.Class35 vmethod_57(Class24.Class35 class35_0);

		// Token: 0x06001666 RID: 5734
		public abstract Class24.Class35 vmethod_58(Class24.Class35 class35_0);

		// Token: 0x06001667 RID: 5735
		public abstract Class24.Class35 vmethod_59(Class24.Class35 class35_0);

		// Token: 0x06001668 RID: 5736
		public abstract Class24.Class35 mvdcByduPo(Class24.Class35 class35_0);

		// Token: 0x06001669 RID: 5737
		public abstract Class24.Class35 vmethod_60(Class24.Class35 class35_0);

		// Token: 0x0600166A RID: 5738
		public abstract Class24.Class35 vmethod_61(Class24.Class35 class35_0);

		// Token: 0x0600166B RID: 5739
		public abstract Class24.Class35 vmethod_62(Class24.Class35 class35_0);

		// Token: 0x0600166C RID: 5740
		public abstract Class24.Class35 vmethod_63(Class24.Class35 class35_0);

		// Token: 0x0600166D RID: 5741
		public abstract Class24.Class35 vmethod_64(Class24.Class35 class35_0);

		// Token: 0x0600166E RID: 5742
		public abstract Class24.Class35 vmethod_65(Class24.Class35 class35_0);

		// Token: 0x0600166F RID: 5743
		public abstract Class24.Class35 vmethod_66(Class24.Class35 class35_0);

		// Token: 0x06001670 RID: 5744
		public abstract Class24.Class35 vmethod_67(Class24.Class35 class35_0);

		// Token: 0x06001671 RID: 5745
		public abstract Class24.Class35 vmethod_68(Class24.Class35 class35_0);

		// Token: 0x06001672 RID: 5746
		public abstract Class24.Class35 vmethod_69();

		// Token: 0x06001673 RID: 5747
		public abstract Class24.Class35 vmethod_70(Class24.Class35 class35_0);

		// Token: 0x06001674 RID: 5748
		public abstract Class24.Class36 vmethod_71();

		// Token: 0x06001675 RID: 5749
		public abstract Class24.Class35 vmethod_72(Class24.Class35 class35_0);

		// Token: 0x06001676 RID: 5750
		public abstract Class24.Class35 vmethod_73(Class24.Class35 class35_0);

		// Token: 0x06001677 RID: 5751
		public abstract Class24.Class35 vmethod_74(Class24.Class35 class35_0);

		// Token: 0x06001678 RID: 5752
		public abstract bool vmethod_75(Class24.Class35 class35_0);

		// Token: 0x06001679 RID: 5753
		public abstract bool vmethod_76(Class24.Class35 class35_0);

		// Token: 0x0600167A RID: 5754
		public abstract bool vmethod_77(Class24.Class35 class35_0);

		// Token: 0x0600167B RID: 5755
		public abstract bool vmethod_78(Class24.Class35 class35_0);

		// Token: 0x0600167C RID: 5756
		public abstract bool vmethod_79(Class24.Class35 class35_0);

		// Token: 0x0600167D RID: 5757
		public abstract bool vmethod_80(Class24.Class35 class35_0);

		// Token: 0x0600167E RID: 5758
		public abstract bool vmethod_81(Class24.Class35 class35_0);

		// Token: 0x0600167F RID: 5759
		public abstract bool vmethod_82(Class24.Class35 class35_0);

		// Token: 0x06001680 RID: 5760 RVA: 0x00002C18 File Offset: 0x00000E18
		internal override bool vmethod_3()
		{
			return true;
		}
	}

	// Token: 0x020001ED RID: 493
	private class Class40 : Class24.Class36
	{
		// Token: 0x06001685 RID: 5765 RVA: 0x000A6050 File Offset: 0x000A4250
		internal override void vmethod_10(Class24.Class35 class35_0)
		{
			this.double_0 = ((Class24.Class40)class35_0).double_0;
			this.OQJDTERRSN = ((Class24.Class40)class35_0).OQJDTERRSN;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x000A1074 File Offset: 0x0009F274
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_10(class35_0);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000A6080 File Offset: 0x000A4280
		public Class40(double double_1)
		{
			this.enum7_0 = (Class24.Enum7)5;
			this.OQJDTERRSN = (Class24.Enum4)10;
			this.double_0 = double_1;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000A60AC File Offset: 0x000A42AC
		public Class40(Class24.Class40 class40_0)
		{
			this.enum7_0 = class40_0.enum7_0;
			this.OQJDTERRSN = class40_0.OQJDTERRSN;
			this.double_0 = class40_0.double_0;
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00007F28 File Offset: 0x00006128
		public override Class24.Class36 vmethod_71()
		{
			return new Class24.Class40(this);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000A60E8 File Offset: 0x000A42E8
		public Class40(double double_1, Class24.Enum4 enum4_0)
		{
			this.enum7_0 = (Class24.Enum7)5;
			this.double_0 = double_1;
			this.OQJDTERRSN = enum4_0;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000A6114 File Offset: 0x000A4314
		public Class40(float float_0)
		{
			this.enum7_0 = (Class24.Enum7)5;
			this.double_0 = (double)float_0;
			this.OQJDTERRSN = (Class24.Enum4)9;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000A6140 File Offset: 0x000A4340
		public Class40(float float_0, Class24.Enum4 enum4_0)
		{
			this.enum7_0 = (Class24.Enum7)5;
			this.double_0 = (double)float_0;
			this.OQJDTERRSN = enum4_0;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00007F30 File Offset: 0x00006130
		public override bool vmethod_11()
		{
			return this.double_0 == 0.0;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0000788C File Offset: 0x00005A8C
		public override bool vmethod_12()
		{
			return !this.vmethod_11();
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00007F43 File Offset: 0x00006143
		public override string ToString()
		{
			return this.double_0.ToString();
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000A616C File Offset: 0x000A436C
		public override Class24.Class35 vmethod_13(Class24.Enum4 enum4_0)
		{
			switch (enum4_0)
			{
			case (Class24.Enum4)1:
				return this.vmethod_15();
			case (Class24.Enum4)2:
				return this.vmethod_16();
			case (Class24.Enum4)3:
				return this.vmethod_17();
			case (Class24.Enum4)4:
				return this.vmethod_18();
			case (Class24.Enum4)5:
				return this.vmethod_19();
			case (Class24.Enum4)6:
				return this.vmethod_20();
			case (Class24.Enum4)7:
				return this.vmethod_21();
			case (Class24.Enum4)8:
				return this.vmethod_22();
			case (Class24.Enum4)9:
				return this.vmethod_47();
			case (Class24.Enum4)10:
				return this.vmethod_48();
			case (Class24.Enum4)11:
				return this.vmethod_14();
			default:
				throw new Exception(((Class24.Enum8)4).ToString());
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000A6210 File Offset: 0x000A4410
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)this.double_0;
			}
			if (type_0 == typeof(double))
			{
				return this.double_0;
			}
			if ((type_0 == null || type_0 == typeof(object)) && this.OQJDTERRSN == (Class24.Enum4)9)
			{
				return (float)this.double_0;
			}
			return this.double_0;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00007F50 File Offset: 0x00006150
		public override Class24.Class37 vmethod_14()
		{
			return new Class24.Class37((this.vmethod_11() > false) ? 1 : 0);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x000078A7 File Offset: 0x00005AA7
		internal override bool vmethod_7()
		{
			return this.vmethod_12();
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00007F60 File Offset: 0x00006160
		public override Class24.Class37 vmethod_15()
		{
			return new Class24.Class37((int)((sbyte)this.double_0), (Class24.Enum4)1);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00007F6F File Offset: 0x0000616F
		public override Class24.Class37 vmethod_16()
		{
			return new Class24.Class37((uint)((byte)this.double_0), (Class24.Enum4)2);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00007F7E File Offset: 0x0000617E
		public override Class24.Class37 vmethod_17()
		{
			return new Class24.Class37((int)((short)this.double_0), (Class24.Enum4)3);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00007F8D File Offset: 0x0000618D
		public override Class24.Class37 vmethod_18()
		{
			return new Class24.Class37((uint)((ushort)this.double_0), (Class24.Enum4)4);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00007F9C File Offset: 0x0000619C
		public override Class24.Class37 vmethod_19()
		{
			return new Class24.Class37((int)this.double_0, (Class24.Enum4)5);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00007FAB File Offset: 0x000061AB
		public override Class24.Class37 vmethod_20()
		{
			return new Class24.Class37((uint)this.double_0, (Class24.Enum4)6);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00007FBA File Offset: 0x000061BA
		public override Class24.Class38 vmethod_21()
		{
			return new Class24.Class38((long)this.double_0, (Class24.Enum4)7);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00007FC9 File Offset: 0x000061C9
		public override Class24.Class38 vmethod_22()
		{
			return new Class24.Class38((ulong)this.double_0, (Class24.Enum4)8);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0000795D File Offset: 0x00005B5D
		public override Class24.Class37 vmethod_23()
		{
			return this.vmethod_15();
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00007965 File Offset: 0x00005B65
		public override Class24.Class37 vmethod_24()
		{
			return this.vmethod_17();
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0000796D File Offset: 0x00005B6D
		public override Class24.Class37 vmethod_25()
		{
			return this.vmethod_19();
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00007975 File Offset: 0x00005B75
		public override Class24.Class38 vmethod_26()
		{
			return this.vmethod_21();
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0000797D File Offset: 0x00005B7D
		public override Class24.Class37 vmethod_27()
		{
			return this.vmethod_16();
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00007985 File Offset: 0x00005B85
		public override Class24.Class37 vmethod_28()
		{
			return this.vmethod_18();
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0000798D File Offset: 0x00005B8D
		public override Class24.Class37 vmethod_29()
		{
			return this.vmethod_20();
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00007995 File Offset: 0x00005B95
		public override Class24.Class38 vmethod_30()
		{
			return this.vmethod_22();
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00007FD8 File Offset: 0x000061D8
		public override Class24.Class37 vmethod_31()
		{
			return new Class24.Class37((int)(checked((sbyte)this.double_0)), (Class24.Enum4)1);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00007FD8 File Offset: 0x000061D8
		public override Class24.Class37 vmethod_32()
		{
			return new Class24.Class37((int)(checked((sbyte)this.double_0)), (Class24.Enum4)1);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00007FE7 File Offset: 0x000061E7
		public override Class24.Class37 vmethod_33()
		{
			return new Class24.Class37((int)(checked((short)this.double_0)), (Class24.Enum4)3);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00007FE7 File Offset: 0x000061E7
		public override Class24.Class37 vmethod_34()
		{
			return new Class24.Class37((int)(checked((short)this.double_0)), (Class24.Enum4)3);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00007FF6 File Offset: 0x000061F6
		public override Class24.Class37 vmethod_35()
		{
			return new Class24.Class37(checked((int)this.double_0), (Class24.Enum4)5);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00007FF6 File Offset: 0x000061F6
		public override Class24.Class37 vmethod_36()
		{
			return new Class24.Class37(checked((int)this.double_0), (Class24.Enum4)5);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00008005 File Offset: 0x00006205
		public override Class24.Class38 vmethod_37()
		{
			return new Class24.Class38(checked((long)this.double_0), (Class24.Enum4)7);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00008005 File Offset: 0x00006205
		public override Class24.Class38 vmethod_38()
		{
			return new Class24.Class38(checked((long)this.double_0), (Class24.Enum4)7);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00008014 File Offset: 0x00006214
		public override Class24.Class37 vmethod_39()
		{
			return new Class24.Class37((int)(checked((byte)this.double_0)), (Class24.Enum4)2);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00008014 File Offset: 0x00006214
		public override Class24.Class37 vmethod_40()
		{
			return new Class24.Class37((int)(checked((byte)this.double_0)), (Class24.Enum4)2);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00008023 File Offset: 0x00006223
		public override Class24.Class37 vmethod_41()
		{
			return new Class24.Class37((int)(checked((ushort)this.double_0)), (Class24.Enum4)4);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00008023 File Offset: 0x00006223
		public override Class24.Class37 vmethod_42()
		{
			return new Class24.Class37((int)(checked((ushort)this.double_0)), (Class24.Enum4)4);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00008032 File Offset: 0x00006232
		public override Class24.Class37 vmethod_43()
		{
			return new Class24.Class37(checked((uint)this.double_0), (Class24.Enum4)6);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00008032 File Offset: 0x00006232
		public override Class24.Class37 vmethod_44()
		{
			return new Class24.Class37(checked((uint)this.double_0), (Class24.Enum4)6);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00008041 File Offset: 0x00006241
		public override Class24.Class38 vmethod_45()
		{
			return new Class24.Class38(checked((ulong)this.double_0), (Class24.Enum4)8);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00008041 File Offset: 0x00006241
		public override Class24.Class38 vmethod_46()
		{
			return new Class24.Class38(checked((ulong)this.double_0), (Class24.Enum4)8);
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00008050 File Offset: 0x00006250
		public override Class24.Class40 vmethod_47()
		{
			return new Class24.Class40((float)this.double_0, (Class24.Enum4)9);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00008060 File Offset: 0x00006260
		public override Class24.Class40 vmethod_48()
		{
			return new Class24.Class40(this.double_0, (Class24.Enum4)10);
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00008070 File Offset: 0x00006270
		public override Class24.Class40 vmethod_49()
		{
			return new Class24.Class40(this.double_0);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x000A17A8 File Offset: 0x0009F9A8
		public override Class24.Class39 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_26().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_25().struct7_0.int_0);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000A17EC File Offset: 0x0009F9EC
		public override Class24.Class39 skgckirNpg()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_30().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_29().struct7_0.uint_0);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x000A1830 File Offset: 0x0009FA30
		public override Class24.Class39 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_37().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_35().struct7_0.int_0);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000A1874 File Offset: 0x0009FA74
		public override Class24.Class39 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_45().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_43().struct7_0.uint_0);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x000A18B8 File Offset: 0x0009FAB8
		public override Class24.Class39 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_38().struct8_0.long_0);
			}
			return new Class24.Class39((long)this.vmethod_36().struct7_0.int_0);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000A18FC File Offset: 0x0009FAFC
		public override Class24.Class39 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class24.Class39(this.vmethod_46().struct8_0.ulong_0);
			}
			return new Class24.Class39((ulong)this.vmethod_44().struct7_0.uint_0);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000A62B0 File Offset: 0x000A44B0
		public override Class24.Class35 vmethod_55()
		{
			if (this.OQJDTERRSN == (Class24.Enum4)9)
			{
				return new Class24.Class40((float)(-(float)this.double_0));
			}
			return new Class24.Class40(-this.double_0);
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000A62E4 File Offset: 0x000A44E4
		public override Class24.Class35 Add(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 + ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000A62E4 File Offset: 0x000A44E4
		public override Class24.Class35 vmethod_56(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 + ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000A62E4 File Offset: 0x000A44E4
		public override Class24.Class35 vmethod_57(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 + ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000A6328 File Offset: 0x000A4528
		public override Class24.Class35 vmethod_58(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 - ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000A6328 File Offset: 0x000A4528
		public override Class24.Class35 vmethod_59(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 - ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x000A6328 File Offset: 0x000A4528
		public override Class24.Class35 mvdcByduPo(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 - ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000A636C File Offset: 0x000A456C
		public override Class24.Class35 vmethod_60(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3() || !class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 * ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000A63B8 File Offset: 0x000A45B8
		public override Class24.Class35 vmethod_61(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 * ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000A63B8 File Offset: 0x000A45B8
		public override Class24.Class35 vmethod_62(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 * ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000A63FC File Offset: 0x000A45FC
		public override Class24.Class35 vmethod_63(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 / ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000A63FC File Offset: 0x000A45FC
		public override Class24.Class35 vmethod_64(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 / ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x000A6440 File Offset: 0x000A4640
		public override Class24.Class35 vmethod_65(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 % ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000A6440 File Offset: 0x000A4640
		public override Class24.Class35 vmethod_66(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return new Class24.Class40(this.double_0 % ((Class24.Class40)class35_0).double_0);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x0000807E File Offset: 0x0000627E
		public override Class24.Class35 vmethod_67(Class24.Class35 class35_0)
		{
			throw new Class24.Exception1();
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0000807E File Offset: 0x0000627E
		public override Class24.Class35 vmethod_68(Class24.Class35 class35_0)
		{
			throw new Class24.Exception1();
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0000807E File Offset: 0x0000627E
		public override Class24.Class35 vmethod_69()
		{
			throw new Class24.Exception1();
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0000807E File Offset: 0x0000627E
		public override Class24.Class35 vmethod_70(Class24.Class35 class35_0)
		{
			throw new Class24.Exception1();
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0000807E File Offset: 0x0000627E
		public override Class24.Class35 vmethod_72(Class24.Class35 class35_0)
		{
			throw new Class24.Exception1();
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0000807E File Offset: 0x0000627E
		public override Class24.Class35 vmethod_73(Class24.Class35 class35_0)
		{
			throw new Class24.Exception1();
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0000807E File Offset: 0x0000627E
		public override Class24.Class35 vmethod_74(Class24.Class35 class35_0)
		{
			throw new Class24.Exception1();
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00007ADA File Offset: 0x00005CDA
		internal override Class24.Class35 vmethod_8()
		{
			return this;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000A6484 File Offset: 0x000A4684
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			if (class35_0.anLwXoVydS())
			{
				return false;
			}
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_5(this);
			}
			Class24.Class35 @class = class35_0.vmethod_8();
			return @class.method_3() && this.double_0 == ((Class24.Class40)@class).double_0;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x000A64D8 File Offset: 0x000A46D8
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			if (class35_0.anLwXoVydS())
			{
				return false;
			}
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_6(this);
			}
			Class24.Class35 @class = class35_0.vmethod_8();
			return @class.method_3() && this.double_0 != ((Class24.Class40)@class).double_0;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x000A6530 File Offset: 0x000A4730
		public override bool vmethod_75(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return this.double_0 >= ((Class24.Class40)class35_0).double_0;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x000A6530 File Offset: 0x000A4730
		public override bool vmethod_76(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return this.double_0 >= ((Class24.Class40)class35_0).double_0;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000A6574 File Offset: 0x000A4774
		public override bool vmethod_77(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return this.double_0 > ((Class24.Class40)class35_0).double_0;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000A6574 File Offset: 0x000A4774
		public override bool vmethod_78(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return this.double_0 > ((Class24.Class40)class35_0).double_0;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x000A65B4 File Offset: 0x000A47B4
		public override bool vmethod_79(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return this.double_0 <= ((Class24.Class40)class35_0).double_0;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x000A65B4 File Offset: 0x000A47B4
		public override bool vmethod_80(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return this.double_0 <= ((Class24.Class40)class35_0).double_0;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x000A65F8 File Offset: 0x000A47F8
		public override bool vmethod_81(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return this.double_0 < ((Class24.Class40)class35_0).double_0;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x000A65F8 File Offset: 0x000A47F8
		public override bool vmethod_82(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				class35_0 = class35_0.vmethod_8();
			}
			if (!class35_0.method_3())
			{
				throw new Class24.Exception1();
			}
			return this.double_0 < ((Class24.Class40)class35_0).double_0;
		}

		// Token: 0x040008F8 RID: 2296
		public double double_0;

		// Token: 0x040008F9 RID: 2297
		public Class24.Enum4 OQJDTERRSN;
	}

	// Token: 0x020001EE RID: 494
	internal enum Enum4 : byte
	{

	}

	// Token: 0x020001EF RID: 495
	internal enum Enum5 : byte
	{

	}

	// Token: 0x020001F0 RID: 496
	private class Exception0 : Exception
	{
		// Token: 0x060016E0 RID: 5856 RVA: 0x000A6638 File Offset: 0x000A4838
		public Exception0(string string_0)
			: base(string_0)
		{
		}
	}

	// Token: 0x020001F1 RID: 497
	private class Exception1 : Exception
	{
		// Token: 0x060016E4 RID: 5860 RVA: 0x000A6650 File Offset: 0x000A4850
		public Exception1()
		{
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x000A6638 File Offset: 0x000A4838
		public Exception1(string string_0)
			: base(string_0)
		{
		}
	}

	// Token: 0x020001F2 RID: 498
	internal class Class25
	{
		// Token: 0x060016E9 RID: 5865 RVA: 0x000A6668 File Offset: 0x000A4868
		public override string ToString()
		{
			object obj = this.enum6_0;
			if (this.object_0 != null)
			{
				return obj.ToString() + Class15.smethod_17(543192466 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89) + this.object_0.ToString();
			}
			return obj.ToString();
		}

		// Token: 0x040008FF RID: 2303
		internal Class24.Enum6 enum6_0 = (Class24.Enum6)126;

		// Token: 0x04000900 RID: 2304
		internal object object_0;
	}

	// Token: 0x020001F3 RID: 499
	internal abstract class Class41 : Class24.Class35
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x000A6038 File Offset: 0x000A4238
		public Class41()
		{
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00002C18 File Offset: 0x00000E18
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x060016F0 RID: 5872
		internal abstract IntPtr vmethod_11();

		// Token: 0x060016F1 RID: 5873
		internal abstract void vmethod_12(Class24.Class35 class35_0);

		// Token: 0x060016F2 RID: 5874 RVA: 0x00002C18 File Offset: 0x00000E18
		internal override bool vmethod_1()
		{
			return true;
		}
	}

	// Token: 0x020001F4 RID: 500
	internal class Class42 : Class24.Class41
	{
		// Token: 0x060016F6 RID: 5878 RVA: 0x000A66E0 File Offset: 0x000A48E0
		public Class42(int int_1, Class24.Class33 class33_1)
		{
			this.class33_0 = class33_1;
			this.int_0 = int_1;
			this.enum7_0 = (Class24.Enum7)7;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x000A670C File Offset: 0x000A490C
		internal override void vmethod_10(Class24.Class35 class35_0)
		{
			if (class35_0 is Class24.Class42)
			{
				this.class33_0 = ((Class24.Class42)class35_0).class33_0;
				this.int_0 = ((Class24.Class42)class35_0).int_0;
				return;
			}
			Class24.Class27 @class = this.class33_0.class30_0.list_1[this.int_0];
			if (class35_0 is Class24.Class41 && (@class.enum4_0 & (Class24.Enum4)226) > (Class24.Enum4)0)
			{
				Class24.Class35 class2 = (class35_0 as Class24.Class41).vmethod_8();
				this.vmethod_12(class2);
				return;
			}
			this.vmethod_12(class35_0);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x000A6798 File Offset: 0x000A4998
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_12(class35_0);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00005F96 File Offset: 0x00004196
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000A67AC File Offset: 0x000A49AC
		internal override void vmethod_12(Class24.Class35 class35_0)
		{
			this.class33_0.class35_1[this.int_0] = class35_0;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000A67CC File Offset: 0x000A49CC
		internal override object vmethod_4(Type type_0)
		{
			if (this.class33_0.class35_1[this.int_0] != null)
			{
				return this.vmethod_8().vmethod_4(type_0);
			}
			return null;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x000A67FC File Offset: 0x000A49FC
		internal override Class24.Class35 vmethod_8()
		{
			if (this.class33_0.class35_1[this.int_0] == null)
			{
				return new Class24.Class47(null);
			}
			return this.class33_0.class35_1[this.int_0].vmethod_8();
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00008085 File Offset: 0x00006285
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x000A683C File Offset: 0x000A4A3C
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			return class35_0.vmethod_0() && class35_0 is Class24.Class42 && ((Class24.Class42)class35_0).int_0 == this.int_0;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x000A6874 File Offset: 0x000A4A74
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			return !class35_0.vmethod_0() || !(class35_0 is Class24.Class42) || ((Class24.Class42)class35_0).int_0 != this.int_0;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00008092 File Offset: 0x00006292
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x04000903 RID: 2307
		private Class24.Class33 class33_0;

		// Token: 0x04000904 RID: 2308
		internal int int_0;
	}

	// Token: 0x020001F5 RID: 501
	internal class Class43 : Class24.Class41
	{
		// Token: 0x06001704 RID: 5892 RVA: 0x000A68AC File Offset: 0x000A4AAC
		public Class43(int int_1, Array array_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
			this.enum7_0 = (Class24.Enum7)7;
			if (array_1 != null)
			{
				this.array_0.GetType().GetElementType();
			}
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00005F96 File Offset: 0x00004196
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000A68EC File Offset: 0x000A4AEC
		internal override void vmethod_10(Class24.Class35 class35_0)
		{
			if (!(class35_0 is Class24.Class43))
			{
				this.vmethod_12(class35_0);
				return;
			}
			this.array_0 = ((Class24.Class43)class35_0).array_0;
			this.int_0 = ((Class24.Class43)class35_0).int_0;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000A6798 File Offset: 0x000A4998
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_12(class35_0);
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000A692C File Offset: 0x000A4B2C
		internal override void vmethod_12(Class24.Class35 class35_0)
		{
			object obj = class35_0.vmethod_4(null);
			this.array_0.SetValue(obj, this.int_0);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0000809F File Offset: 0x0000629F
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_8().vmethod_4(type_0);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000080AD File Offset: 0x000062AD
		internal override Class24.Class35 vmethod_8()
		{
			return Class24.Class35.smethod_1(this.array_0.GetType().GetElementType(), this.array_0.GetValue(this.int_0));
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00008085 File Offset: 0x00006285
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000A6958 File Offset: 0x000A4B58
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			if (!class35_0.vmethod_0())
			{
				return false;
			}
			if (class35_0 is Class24.Class43)
			{
				Class24.Class43 @class = (Class24.Class43)class35_0;
				return @class.int_0 == this.int_0 && @class.array_0 == this.array_0;
			}
			return false;
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x000A69A4 File Offset: 0x000A4BA4
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			if (!class35_0.vmethod_0())
			{
				return true;
			}
			if (!(class35_0 is Class24.Class43))
			{
				return true;
			}
			Class24.Class43 @class = (Class24.Class43)class35_0;
			return @class.int_0 != this.int_0 || @class.array_0 != this.array_0;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00008092 File Offset: 0x00006292
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x04000906 RID: 2310
		private Array array_0;

		// Token: 0x04000907 RID: 2311
		internal int int_0;
	}

	// Token: 0x020001F6 RID: 502
	internal class Class44 : Class24.Class41
	{
		// Token: 0x06001712 RID: 5906 RVA: 0x000A69F0 File Offset: 0x000A4BF0
		public Class44(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
			this.enum7_0 = (Class24.Enum7)7;
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00005F96 File Offset: 0x00004196
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000A6A1C File Offset: 0x000A4C1C
		internal override void vmethod_12(Class24.Class35 class35_0)
		{
			if (this.object_0 != null && this.object_0 is Class24.Class35)
			{
				this.fieldInfo_0.SetValue(((Class24.Class35)this.object_0).vmethod_4(null), class35_0.vmethod_4(null));
				return;
			}
			this.fieldInfo_0.SetValue(this.object_0, class35_0.vmethod_4(null));
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000A6A7C File Offset: 0x000A4C7C
		internal override void vmethod_10(Class24.Class35 class35_0)
		{
			if (!(class35_0 is Class24.Class44))
			{
				this.vmethod_12(class35_0);
				return;
			}
			this.fieldInfo_0 = ((Class24.Class44)class35_0).fieldInfo_0;
			this.object_0 = ((Class24.Class44)class35_0).object_0;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000A6798 File Offset: 0x000A4998
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_12(class35_0);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0000809F File Offset: 0x0000629F
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_8().vmethod_4(type_0);
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000A6ABC File Offset: 0x000A4CBC
		internal override Class24.Class35 vmethod_8()
		{
			if (this.object_0 != null && this.object_0 is Class24.Class35)
			{
				return Class24.Class35.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(((Class24.Class35)this.object_0).vmethod_4(null)));
			}
			return Class24.Class35.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(this.object_0));
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00008085 File Offset: 0x00006285
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000A6B2C File Offset: 0x000A4D2C
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			if (!class35_0.vmethod_0())
			{
				return false;
			}
			if (class35_0 is Class24.Class44)
			{
				Class24.Class44 @class = (Class24.Class44)class35_0;
				return !(@class.fieldInfo_0 != this.fieldInfo_0) && @class.object_0 == this.object_0;
			}
			return false;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000A6B80 File Offset: 0x000A4D80
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			if (!class35_0.vmethod_0())
			{
				return true;
			}
			if (class35_0 is Class24.Class44)
			{
				Class24.Class44 @class = (Class24.Class44)class35_0;
				return @class.fieldInfo_0 != this.fieldInfo_0 || @class.object_0 != this.object_0;
			}
			return true;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00008092 File Offset: 0x00006292
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x04000909 RID: 2313
		internal FieldInfo fieldInfo_0;

		// Token: 0x0400090A RID: 2314
		internal object object_0;
	}

	// Token: 0x020001F7 RID: 503
	internal class Class45 : Class24.Class41
	{
		// Token: 0x06001720 RID: 5920 RVA: 0x000A6BD4 File Offset: 0x000A4DD4
		public Class45(int int_1, Class24.Class33 class33_1)
		{
			this.class33_0 = class33_1;
			this.int_0 = int_1;
			this.enum7_0 = (Class24.Enum7)7;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00005F96 File Offset: 0x00004196
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000A6C00 File Offset: 0x000A4E00
		internal override void vmethod_10(Class24.Class35 class35_0)
		{
			if (class35_0 is Class24.Class45)
			{
				this.class33_0 = ((Class24.Class45)class35_0).class33_0;
				this.int_0 = ((Class24.Class45)class35_0).int_0;
				return;
			}
			this.vmethod_12(class35_0);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x000A6798 File Offset: 0x000A4998
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_12(class35_0);
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000A6C40 File Offset: 0x000A4E40
		internal override void vmethod_12(Class24.Class35 class35_0)
		{
			this.class33_0.class35_0[this.int_0] = class35_0;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x000A6C60 File Offset: 0x000A4E60
		internal override object vmethod_4(Type type_0)
		{
			if (this.class33_0.class35_0[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_8().vmethod_4(type_0);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x000A6C90 File Offset: 0x000A4E90
		internal override Class24.Class35 vmethod_8()
		{
			if (this.class33_0.class35_0[this.int_0] != null)
			{
				return this.class33_0.class35_0[this.int_0].vmethod_8();
			}
			return new Class24.Class47(null);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00008085 File Offset: 0x00006285
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000A6CD0 File Offset: 0x000A4ED0
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			return class35_0.vmethod_0() && class35_0 is Class24.Class45 && ((Class24.Class45)class35_0).int_0 == this.int_0;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x000A6D04 File Offset: 0x000A4F04
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			return !class35_0.vmethod_0() || !(class35_0 is Class24.Class45) || ((Class24.Class45)class35_0).int_0 != this.int_0;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00008092 File Offset: 0x00006292
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x0400090C RID: 2316
		private Class24.Class33 class33_0;

		// Token: 0x0400090D RID: 2317
		internal int int_0;
	}

	// Token: 0x020001F8 RID: 504
	internal class Class46 : Class24.Class41
	{
		// Token: 0x0600172E RID: 5934 RVA: 0x000A6D3C File Offset: 0x000A4F3C
		public Class46(Class24.Class35 class35_1, Type type_1)
		{
			this.class35_0 = class35_1;
			this.type_0 = type_1;
			this.enum7_0 = (Class24.Enum7)7;
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00005F96 File Offset: 0x00004196
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000A6D68 File Offset: 0x000A4F68
		internal override void vmethod_10(Class24.Class35 class35_1)
		{
			if (class35_1 is Class24.Class46)
			{
				this.type_0 = ((Class24.Class46)class35_1).type_0;
				this.class35_0 = ((Class24.Class46)class35_1).class35_0;
				return;
			}
			this.class35_0.vmethod_10(class35_1);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000A6798 File Offset: 0x000A4998
		internal override void vmethod_2(Class24.Class35 class35_1)
		{
			this.vmethod_12(class35_1);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x000A6DAC File Offset: 0x000A4FAC
		internal override void vmethod_12(Class24.Class35 class35_1)
		{
			this.class35_0 = class35_1;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000A6DC0 File Offset: 0x000A4FC0
		internal override object vmethod_4(Type type_1)
		{
			if (this.class35_0 == null)
			{
				return new Class24.Class47(null);
			}
			if (!(type_1 == null) && !(type_1 == typeof(object)))
			{
				return this.class35_0.vmethod_4(type_1);
			}
			return this.class35_0.vmethod_4(this.type_0);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000A6E18 File Offset: 0x000A5018
		internal override Class24.Class35 vmethod_8()
		{
			if (this.class35_0 != null)
			{
				return this.class35_0.vmethod_8();
			}
			return new Class24.Class47(null);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00008085 File Offset: 0x00006285
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x000A6E40 File Offset: 0x000A5040
		internal override bool vmethod_5(Class24.Class35 class35_1)
		{
			if (!class35_1.vmethod_0())
			{
				return false;
			}
			if (!(class35_1 is Class24.Class46))
			{
				return false;
			}
			Class24.Class46 @class = (Class24.Class46)class35_1;
			if (@class.type_0 != this.type_0)
			{
				return false;
			}
			if (this.class35_0 == null)
			{
				return @class.class35_0 == null;
			}
			return this.class35_0.vmethod_5(@class.class35_0);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000A6EA8 File Offset: 0x000A50A8
		internal override bool vmethod_6(Class24.Class35 class35_1)
		{
			if (!class35_1.vmethod_0())
			{
				return true;
			}
			if (!(class35_1 is Class24.Class46))
			{
				return true;
			}
			Class24.Class46 @class = (Class24.Class46)class35_1;
			if (@class.type_0 != this.type_0)
			{
				return true;
			}
			if (this.class35_0 != null)
			{
				return this.class35_0.vmethod_6(@class.class35_0);
			}
			return @class.class35_0 != null;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00008092 File Offset: 0x00006292
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x0400090F RID: 2319
		private Class24.Class35 class35_0;

		// Token: 0x04000910 RID: 2320
		private Type type_0;
	}

	// Token: 0x020001F9 RID: 505
	internal class Class26
	{
		// Token: 0x04000912 RID: 2322
		public int int_0;

		// Token: 0x04000913 RID: 2323
		public bool bool_0;

		// Token: 0x04000914 RID: 2324
		public Class24.Enum4 enum4_0;
	}

	// Token: 0x020001FA RID: 506
	internal class Class27
	{
		// Token: 0x04000916 RID: 2326
		public int int_0;

		// Token: 0x04000917 RID: 2327
		public Class24.Enum4 enum4_0;

		// Token: 0x04000918 RID: 2328
		public bool bool_0;

		// Token: 0x04000919 RID: 2329
		public Type type_0 = typeof(object);
	}

	// Token: 0x020001FB RID: 507
	internal class Class28
	{
		// Token: 0x0400091B RID: 2331
		public int int_0;

		// Token: 0x0400091C RID: 2332
		public int int_1;

		// Token: 0x0400091D RID: 2333
		public Class24.Class29 class29_0;
	}

	// Token: 0x020001FC RID: 508
	internal class Class29
	{
		// Token: 0x0400091F RID: 2335
		public int int_0;

		// Token: 0x04000920 RID: 2336
		public int int_1;

		// Token: 0x04000921 RID: 2337
		public byte byte_0;

		// Token: 0x04000922 RID: 2338
		public Type type_0;

		// Token: 0x04000923 RID: 2339
		public int int_2;

		// Token: 0x04000924 RID: 2340
		public int int_3;
	}

	// Token: 0x020001FD RID: 509
	internal class Class30
	{
		// Token: 0x04000926 RID: 2342
		internal MethodBase methodBase_0;

		// Token: 0x04000927 RID: 2343
		internal List<Class24.Class25> list_0;

		// Token: 0x04000928 RID: 2344
		internal Class24.Class26[] class26_0;

		// Token: 0x04000929 RID: 2345
		internal List<Class24.Class27> list_1;

		// Token: 0x0400092A RID: 2346
		internal List<Class24.Class28> list_2;
	}

	// Token: 0x020001FE RID: 510
	private class Class31
	{
		// Token: 0x06001750 RID: 5968 RVA: 0x000A6F38 File Offset: 0x000A5138
		public Class31(FieldInfo fieldInfo_0, int int_1)
		{
			this.object_0 = fieldInfo_0;
			this.int_0 = int_1;
		}

		// Token: 0x0400092C RID: 2348
		internal object object_0;

		// Token: 0x0400092D RID: 2349
		internal int int_0;
	}

	// Token: 0x020001FF RID: 511
	private class Class32
	{
		// Token: 0x06001754 RID: 5972 RVA: 0x000080D5 File Offset: 0x000062D5
		public Class32(MethodBase methodBase_1, List<Class24.Class31> list_1)
		{
			this.list_0 = list_1;
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x000A6F5C File Offset: 0x000A515C
		public Class32(MethodBase methodBase_1, Class24.Class31[] class31_0)
		{
			this.list_0.AddRange(class31_0);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x000A6F88 File Offset: 0x000A5188
		public override bool Equals(object obj)
		{
			Class24.Class32 @class = obj as Class24.Class32;
			if (obj == null)
			{
				return false;
			}
			if (this.methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (this.list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].object_0 != @class.list_0[i].object_0)
				{
					return false;
				}
				if (this.list_0[i].int_0 != @class.list_0[i].int_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000A7050 File Offset: 0x000A5250
		public override int GetHashCode()
		{
			int num = this.methodBase_0.GetHashCode();
			foreach (Class24.Class31 @class in this.list_0)
			{
				int num2 = @class.object_0.GetHashCode() + @class.int_0;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000A70D0 File Offset: 0x000A52D0
		public Class24.Class31 method_0(int int_0)
		{
			foreach (Class24.Class31 @class in this.list_0)
			{
				if (@class.int_0 == int_0)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000A7138 File Offset: 0x000A5338
		public bool method_1(int int_0)
		{
			using (List<Class24.Class31>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.int_0 == int_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0400092F RID: 2351
		private List<Class24.Class31> list_0 = new List<Class24.Class31>();

		// Token: 0x04000930 RID: 2352
		private MethodBase methodBase_0;
	}

	// Token: 0x02000200 RID: 512
	// (Invoke) Token: 0x0600175E RID: 5982
	private delegate object Delegate11(object target, object[] paramters);

	// Token: 0x02000201 RID: 513
	// (Invoke) Token: 0x06001763 RID: 5987
	private delegate object Delegate12(ref object target, object[] paramters);

	// Token: 0x02000202 RID: 514
	// (Invoke) Token: 0x06001768 RID: 5992
	private delegate object Delegate13(object target);

	// Token: 0x02000203 RID: 515
	// (Invoke) Token: 0x0600176D RID: 5997
	private delegate void Delegate14(IntPtr a, byte b, int c);

	// Token: 0x02000204 RID: 516
	// (Invoke) Token: 0x06001772 RID: 6002
	private delegate void Delegate15(IntPtr s, IntPtr t, uint c);

	// Token: 0x02000205 RID: 517
	internal class Class33
	{
		// Token: 0x06001776 RID: 6006 RVA: 0x000A719C File Offset: 0x000A539C
		internal void method_0()
		{
			bool flag = false;
			this.method_1(ref flag);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000A71B4 File Offset: 0x000A53B4
		internal void yqDbiTnaSC()
		{
			this.class52_0.method_1();
			this.class35_1 = null;
			if (this.list_0 != null)
			{
				foreach (IntPtr intPtr in this.list_0)
				{
					try
					{
						Marshal.FreeHGlobal(intPtr);
					}
					catch
					{
					}
				}
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x000A7248 File Offset: 0x000A5448
		internal void method_1(ref bool bool_4)
		{
			while (this.int_0 > -2)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					int num = this.int_1;
					int num2 = this.int_0;
					this.method_3(this.int_1, this.int_0);
					this.int_0 = num2;
					this.int_1 = num;
				}
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
				if (!this.bool_1)
				{
					this.int_1 = this.int_0;
					Class24.Class25 @class = this.class30_0.list_0[this.int_0];
					this.object_0 = @class.object_0;
					try
					{
						this.method_6(@class);
					}
					catch (Exception innerException)
					{
						if (innerException is TargetInvocationException)
						{
							TargetInvocationException ex = (TargetInvocationException)innerException;
							if (ex.InnerException != null)
							{
								innerException = ex.InnerException;
							}
						}
						this.exception_0 = innerException;
						bool_4 = true;
						this.class52_0.method_1();
						int num3 = this.int_1;
						Class24.Class28 class2 = this.method_4(num3, innerException);
						List<Class24.Class28> list = this.method_5(num3, false);
						List<Class24.Class28> list2 = new List<Class24.Class28>();
						if (class2 != null)
						{
							list2.Add(class2);
						}
						if (list != null && list.Count > 0)
						{
							list2.AddRange(list);
						}
						list2.Sort(new Comparison<Class24.Class28>(Class24.Class33.Class34.<>9.method_0));
						Class24.Class28 class3 = null;
						foreach (Class24.Class28 class4 in list2)
						{
							if (class4.class29_0.int_3 != 0)
							{
								this.class52_0.method_2(new Class24.Class47(innerException));
								this.int_1 = class4.class29_0.int_2;
								this.int_0 = this.int_1;
								this.method_0();
								if (!this.bool_3)
								{
									continue;
								}
								this.bool_3 = false;
								class3 = class4;
							}
							else
							{
								class3 = class4;
							}
							break;
						}
						if (class3 == null)
						{
							throw innerException;
						}
						this.int_2 = class3.class29_0.int_0;
						this.method_2(num3, class3.class29_0.int_0);
						if (this.int_2 >= 0)
						{
							this.class52_0.method_2(new Class24.Class47(innerException));
							this.int_1 = this.int_2;
							this.int_0 = this.int_1;
							this.int_2 = -1;
							this.method_0();
						}
						return;
					}
					this.int_0++;
					continue;
				}
				this.bool_1 = false;
				return;
			}
			this.class52_0.method_1();
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000A7508 File Offset: 0x000A5708
		internal void method_2(int int_3, int int_4)
		{
			if (this.class30_0.list_2 != null)
			{
				foreach (Class24.Class28 @class in this.class30_0.list_2)
				{
					if ((@class.class29_0.int_3 == 4 || @class.class29_0.int_3 == 2) && @class.class29_0.int_0 >= int_3 && @class.class29_0.int_1 <= int_4)
					{
						this.int_1 = @class.class29_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_1(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000A75DC File Offset: 0x000A57DC
		internal void method_3(int int_3, int int_4)
		{
			if (this.class30_0.list_2 != null)
			{
				foreach (Class24.Class28 @class in this.class30_0.list_2)
				{
					if (@class.class29_0.int_3 == 2 && @class.class29_0.int_0 >= int_3 && @class.class29_0.int_1 <= int_4)
					{
						this.int_1 = @class.class29_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_1(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000A769C File Offset: 0x000A589C
		internal Class24.Class28 method_4(int int_3, Exception exception_1)
		{
			Class24.Class28 @class = null;
			if (this.class30_0.list_2 != null)
			{
				foreach (Class24.Class28 class2 in this.class30_0.list_2)
				{
					if (class2.class29_0 != null && class2.class29_0.int_3 == 0 && (class2.class29_0.type_0 == exception_1.GetType() || (class2.class29_0.type_0 != null && (class2.class29_0.type_0.FullName == exception_1.GetType().FullName || class2.class29_0.type_0.FullName == typeof(object).FullName || class2.class29_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= class2.int_0 && int_3 <= class2.int_1)
					{
						if (@class != null)
						{
							if (class2.class29_0.int_0 < @class.class29_0.int_0)
							{
								@class = class2;
							}
						}
						else
						{
							@class = class2;
						}
					}
				}
			}
			return @class;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x000A7814 File Offset: 0x000A5A14
		internal List<Class24.Class28> method_5(int int_3, bool bool_4)
		{
			if (this.class30_0.list_2 == null)
			{
				return null;
			}
			List<Class24.Class28> list = new List<Class24.Class28>();
			foreach (Class24.Class28 @class in this.class30_0.list_2)
			{
				if ((@class.class29_0.int_3 & 1) == 1 && int_3 >= @class.int_0 && int_3 <= @class.int_1)
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x000A78B0 File Offset: 0x000A5AB0
		private unsafe void method_6(Class24.Class25 class25_0)
		{
			switch (class25_0.enum6_0)
			{
			case (Class24.Enum6)0:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_81(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)1:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				this.class52_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class24.Enum6)2:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_54());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)3:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_65(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)4:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_74(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)5:
				this.bool_2 = true;
				return;
			case (Class24.Enum6)6:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_79(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)7:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_28());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class37((int)(*(ushort*)(void*)intPtr), (Class24.Enum4)4));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)8:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class24).Module.ResolveType(num);
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				((Array)this.class52_0.method_4().vmethod_4(null)).SetValue(@class.vmethod_4(type), class2.vmethod_19().struct7_0.int_0);
				return;
			}
			case (Class24.Enum6)9:
				this.class52_0.method_2(new Class24.Class47(null));
				return;
			case (Class24.Enum6)10:
				this.method_11(true);
				return;
			case (Class24.Enum6)11:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_31());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)12:
				this.class52_0.method_2(new Class24.Class38((long)this.object_0));
				return;
			case (Class24.Enum6)13:
				if (this.class52_0.method_4().vmethod_6(this.class52_0.method_4()))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			case (Class24.Enum6)14:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_34());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)15:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_24());
				return;
			}
			case (Class24.Enum6)16:
			{
				int num = (int)this.object_0;
				this.class35_1[num] = this.method_7(this.class52_0.method_4(), this.class30_0.list_1[num].enum4_0, this.class30_0.list_1[num].bool_0);
				return;
			}
			case (Class24.Enum6)17:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_57(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)18:
				this.class52_0.method_2(new Class24.Class42((int)this.object_0, this));
				return;
			case (Class24.Enum6)19:
			{
				Class24.Class36 class2 = this.class52_0.method_4() as Class24.Class36;
				IntPtr intPtr = Class24.Class33.smethod_8(this.class52_0.method_4());
				IntPtr intPtr2 = Class24.Class33.smethod_8(this.class52_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint num2 = class2.vmethod_20().struct7_0.uint_0;
					Class24.Class33.smethod_11(intPtr2, intPtr, num2);
				}
				return;
			}
			case (Class24.Enum6)20:
			{
				int num = (int)this.object_0;
				uint num2 = (uint)Class24.Class33.smethod_0(typeof(Class24).Module.ResolveType(num));
				this.class52_0.method_2(new Class24.Class37(num2, (Class24.Enum4)6));
				return;
			}
			case (Class24.Enum6)21:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class24).Module.ResolveType(num);
				Class24.Class41 class4 = this.class52_0.method_4() as Class24.Class41;
				if (class4 != null)
				{
					object obj = class4.vmethod_4(type);
					Class24.Class35 @class;
					if (obj != null)
					{
						if (type.IsValueType)
						{
							obj = Class24.Class33.smethod_9(obj);
						}
						@class = Class24.Class35.smethod_1(type, obj);
					}
					else if (type.IsValueType)
					{
						obj = Activator.CreateInstance(type);
						@class = Class24.Class35.smethod_1(type, obj);
					}
					else
					{
						@class = new Class24.Class47(null);
					}
					this.class52_0.method_2(@class);
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)22:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Array array = (Array)this.class52_0.method_4().vmethod_4(null);
				object obj = array.GetValue(class2.vmethod_19().struct7_0.int_0);
				Type type = array.GetType().GetElementType();
				this.class52_0.method_2(Class24.Class35.smethod_1(type, obj));
				return;
			}
			case (Class24.Enum6)23:
			{
				int num = (int)this.object_0;
				this.class52_0.method_2(new Class24.Class45(num, this));
				return;
			}
			case (Class24.Enum6)24:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_51());
				return;
			}
			case (Class24.Enum6)25:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_47());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)26:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(float), obj));
				return;
			}
			case (Class24.Enum6)27:
			{
				Type type = typeof(Class24).Module.ResolveType((int)this.object_0);
				object obj = this.class52_0.method_4().vmethod_4(type);
				if (obj == null)
				{
					obj = Activator.CreateInstance(type);
				}
				Class24.Class47 class5 = new Class24.Class47(Class24.Class35.smethod_1(type, Class24.Class33.smethod_9(obj)));
				this.class52_0.method_2(class5);
				return;
			}
			case (Class24.Enum6)28:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_48());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class40(*(double*)(void*)intPtr, (Class24.Enum4)10));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)29:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_80(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)30:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class24).Module.ResolveType(num);
				Class24.Class35 @class = this.class52_0.method_4();
				object obj = @class.vmethod_4(null);
				if (obj == null)
				{
					this.class52_0.method_2(new Class24.Class47(null));
					return;
				}
				if (type.IsAssignableFrom(obj.GetType()))
				{
					this.class52_0.method_2(@class);
					return;
				}
				this.class52_0.method_2(new Class24.Class47(null));
				return;
			}
			case (Class24.Enum6)31:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_26());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)32:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class24).Module.ResolveType(num);
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(type, obj));
				return;
			}
			case (Class24.Enum6)33:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.skgckirNpg());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)34:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_49());
				return;
			}
			case (Class24.Enum6)35:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_38());
				return;
			}
			case (Class24.Enum6)36:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (@class != null && @class.vmethod_7())
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)37:
				throw this.exception_0;
			case (Class24.Enum6)38:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_61(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)39:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class52_0.method_2(class2.vmethod_68(class3));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)40:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_60(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)41:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				Class24.Class35 class6 = this.class52_0.method_4();
				Class24.Class36 class3 = Class24.Class33.smethod_1(class6);
				if (class3 != null && class2 != null)
				{
					if (class3.vmethod_78(@class))
					{
						this.int_0 = (int)this.object_0 - 1;
					}
					return;
				}
				if (@class.vmethod_6(class6))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)42:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(byte), obj));
				return;
			}
			case (Class24.Enum6)43:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_75(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)44:
				this.int_0 = -3;
				if (this.class52_0.method_0() > 0)
				{
					this.class35_2 = this.class52_0.method_4();
				}
				return;
			case (Class24.Enum6)45:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_47());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class40(*(float*)(void*)intPtr, (Class24.Enum4)9));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)46:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_76(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)47:
			case (Class24.Enum6)94:
			case (Class24.Enum6)104:
			case (Class24.Enum6)116:
			case (Class24.Enum6)123:
			case (Class24.Enum6)127:
			case (Class24.Enum6)161:
			case (Class24.Enum6)169:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Array array2 = (Array)this.class52_0.method_4().vmethod_4(null);
				Type type = array2.GetType().GetElementType();
				array2.SetValue(@class.vmethod_4(type), class2.vmethod_19().struct7_0.int_0);
				return;
			}
			case (Class24.Enum6)48:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class24).Module.ResolveField(num);
				Class24.Class35 class7 = this.class52_0.method_4();
				class7.vmethod_8();
				object obj = class7.vmethod_4(null);
				this.class52_0.method_2(new Class24.Class44(fieldInfo, obj));
				return;
			}
			case (Class24.Enum6)49:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_48());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)50:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				this.class52_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class24.Enum6)51:
			{
				int num = (int)this.object_0;
				this.class52_0.method_2(this.class35_0[num]);
				return;
			}
			case (Class24.Enum6)52:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_39());
				return;
			}
			case (Class24.Enum6)53:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class24).Module.ResolveType(num);
				Class24.Class41 class8 = this.class52_0.method_4() as Class24.Class41;
				if (class8 == null)
				{
					throw new Class24.Exception1();
				}
				if (!type.IsValueType)
				{
					class8.vmethod_12(new Class24.Class47(null));
					return;
				}
				if (!(Nullable.GetUnderlyingType(type) != null))
				{
					object obj = Activator.CreateInstance(type);
					Class24.Class35 @class = Class24.Class35.smethod_1(type, obj);
					class8.vmethod_12(@class);
					return;
				}
				class8.vmethod_12(new Class24.Class49(null, Nullable.GetUnderlyingType(type)));
				return;
			}
			case (Class24.Enum6)54:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				Class24.Class35 class6 = this.class52_0.method_4();
				Class24.Class36 class3 = Class24.Class33.smethod_1(class6);
				if (class3 != null && class2 != null)
				{
					if (class3.vmethod_78(@class))
					{
						this.class52_0.method_2(new Class24.Class37(1));
						return;
					}
					this.class52_0.method_2(new Class24.Class37(0));
					return;
				}
				else
				{
					if (@class.vmethod_6(class6))
					{
						this.class52_0.method_2(new Class24.Class37(1));
						return;
					}
					this.class52_0.method_2(new Class24.Class37(0));
					return;
				}
				break;
			}
			case (Class24.Enum6)55:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_77(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)56:
			case (Class24.Enum6)64:
			case (Class24.Enum6)129:
			case (Class24.Enum6)144:
			case (Class24.Enum6)160:
			case (Class24.Enum6)174:
				throw new Class24.Exception1();
			case (Class24.Enum6)57:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(long), obj));
				return;
			}
			case (Class24.Enum6)58:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_73(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)59:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_53());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)60:
			{
				object obj = Class24.Class33.object_2;
				lock (obj)
				{
					object obj2 = this.class52_0.method_4().vmethod_4(null);
					Class24.Class35 @class = null;
					if (!Class24.Class33.dictionary_1.TryGetValue(obj2, out @class))
					{
						this.class52_0.method_2(new Class24.Class47(null));
					}
					else
					{
						this.class52_0.method_2(@class);
					}
				}
				return;
			}
			case (Class24.Enum6)61:
			{
				Class24.Class36 class9 = Class24.Class33.smethod_1(this.class52_0.method_3());
				if (class9 != null)
				{
					Class24.Class40 class10 = class9 as Class24.Class40;
					if (class10 != null)
					{
						if (double.IsNaN(class10.double_0))
						{
							throw new OverflowException(((Class24.Enum8)2).ToString());
						}
						if (double.IsInfinity(class10.double_0))
						{
							throw new OverflowException(((Class24.Enum8)1).ToString());
						}
					}
					return;
				}
				throw new ArithmeticException(((Class24.Enum8)0).ToString());
			}
			case (Class24.Enum6)62:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				this.class52_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class24.Enum6)63:
			case (Class24.Enum6)72:
			case (Class24.Enum6)84:
			case (Class24.Enum6)87:
			case (Class24.Enum6)96:
			case (Class24.Enum6)102:
				return;
			case (Class24.Enum6)65:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(double), obj));
				return;
			}
			case (Class24.Enum6)66:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_28());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)67:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_23());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class37((int)(*(sbyte*)(void*)intPtr), (Class24.Enum4)1));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)68:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.mvdcByduPo(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)69:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_62(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)70:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class24).Module.ResolveField(num);
				this.class52_0.method_2(new Class24.Class44(fieldInfo, null));
				return;
			}
			case (Class24.Enum6)71:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class24).Module.ResolveField(num);
				object obj = this.class52_0.method_4().vmethod_4(fieldInfo.FieldType);
				Class24.Class35 @class = this.class52_0.method_4();
				object obj2 = @class.vmethod_4(null);
				if (obj2 == null)
				{
					Type type = fieldInfo.DeclaringType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!type.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type);
					if (@class is Class24.Class42)
					{
						((Class24.Class41)@class).vmethod_12(Class24.Class35.smethod_1(type, obj2));
					}
				}
				fieldInfo.SetValue(obj2, obj);
				return;
			}
			case (Class24.Enum6)73:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_81(@class))
				{
					this.class52_0.method_2(new Class24.Class37(1));
					return;
				}
				this.class52_0.method_2(new Class24.Class37(0));
				return;
			}
			case (Class24.Enum6)74:
				this.int_0 = (int)this.object_0 - 1;
				return;
			case (Class24.Enum6)75:
				this.class52_0.method_4();
				return;
			case (Class24.Enum6)76:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_56(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)77:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_52());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)78:
				return;
			case (Class24.Enum6)79:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_30());
				return;
			}
			case (Class24.Enum6)80:
			case (Class24.Enum6)111:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class24).Module.ResolveType(num);
				Class24.Class35 @class = this.class52_0.method_4();
				object obj = @class.vmethod_4(type);
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class24.Class33.smethod_9(obj);
					}
					@class = Class24.Class35.smethod_1(type, obj);
				}
				else if (type.IsValueType)
				{
					obj = Activator.CreateInstance(type);
					@class = Class24.Class35.smethod_1(type, obj);
				}
				else
				{
					@class = new Class24.Class47(null);
				}
				Class24.Class41 class11 = this.class52_0.method_4() as Class24.Class41;
				if (class11 == null)
				{
					throw new Class24.Exception1();
				}
				class11.vmethod_10(@class);
				return;
			}
			case (Class24.Enum6)81:
				throw (Exception)this.class52_0.method_4().vmethod_4(null);
			case (Class24.Enum6)82:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_37());
				return;
			}
			case (Class24.Enum6)83:
				this.method_11(false);
				return;
			case (Class24.Enum6)85:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(sbyte), obj));
				return;
			}
			case (Class24.Enum6)86:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class24.Class36)@class).vmethod_47();
				}
				this.class52_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class24.Enum6)88:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(uint), obj));
				return;
			}
			case (Class24.Enum6)89:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_35());
				return;
			}
			case (Class24.Enum6)90:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class24.Class36)@class).vmethod_48();
				}
				this.class52_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class24.Enum6)91:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_63(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)92:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class24).Module.ResolveField(num);
				this.class52_0.method_2(Class24.Class35.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				return;
			}
			case (Class24.Enum6)93:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class52_0.method_2(class2.vmethod_67(class3));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)95:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_50());
					return;
				}
				if (class2 == null || !class2.method_1())
				{
					throw new Class24.Exception1();
				}
				IntPtr intPtr = ((Class24.Class39)class2).method_6();
				if (IntPtr.Size == 8)
				{
					long num3 = *(long*)(void*)intPtr;
					this.class52_0.method_2(new Class24.Class39(num3, (Class24.Enum4)12));
					return;
				}
				int num = *(int*)(void*)intPtr;
				this.class52_0.method_2(new Class24.Class39((long)num, (Class24.Enum4)12));
				return;
			}
			case (Class24.Enum6)97:
			{
				int num = (int)this.object_0;
				Class24.Class35 @class = this.class35_1[num];
				this.class52_0.method_2(@class);
				return;
			}
			case (Class24.Enum6)98:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_25());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class37(*(int*)(void*)intPtr, (Class24.Enum4)5));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)99:
			{
				int num = (int)this.object_0;
				typeof(Class24).Module.ResolveType(num);
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Array array3 = (Array)this.class52_0.method_4().vmethod_4(null);
				this.class52_0.method_2(new Class24.Class43(class2.vmethod_19().struct7_0.int_0, array3));
				return;
			}
			case (Class24.Enum6)100:
			{
				int num = (int)this.object_0;
				ConstructorInfo constructorInfo = (ConstructorInfo)typeof(Class24).Module.ResolveMethod(num);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array4 = new object[parameters.Length];
				Class24.Class35[] array5 = new Class24.Class35[parameters.Length];
				List<Class24.Class31> list = null;
				Class24.Class32 class12 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class24.Class35 @class = this.class52_0.method_4();
					Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj2 = null;
					bool flag = false;
					if (type.IsByRef)
					{
						Class24.Class44 class13 = @class as Class24.Class44;
						if (class13 != null)
						{
							if (list == null)
							{
								list = new List<Class24.Class31>();
							}
							list.Add(new Class24.Class31(class13.fieldInfo_0, parameters.Length - 1 - i));
							obj2 = class13.object_0;
							if (obj2 is Class24.Class35)
							{
								@class = obj2 as Class24.Class35;
							}
							else
							{
								flag = true;
							}
						}
					}
					if (!flag)
					{
						if (@class != null)
						{
							obj2 = @class.vmethod_4(type);
						}
						if (obj2 == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj2 = Activator.CreateInstance(type);
								if (@class is Class24.Class42)
								{
									((Class24.Class41)@class).vmethod_12(Class24.Class35.smethod_1(type, obj2));
								}
							}
						}
					}
					array5[array4.Length - 1 - i] = @class;
					array4[array4.Length - 1 - i] = obj2;
				}
				Class24.Delegate11 @delegate = null;
				if (list != null)
				{
					class12 = new Class24.Class32(constructorInfo, list);
					@delegate = Class24.Class33.smethod_4(constructorInfo, true, class12);
				}
				object obj = null;
				if (@delegate == null)
				{
					obj = constructorInfo.Invoke(array4);
				}
				else
				{
					obj = @delegate(null, array4);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (class12 == null || !class12.method_1(j)))
					{
						if (!array5[j].method_1())
						{
							if (array5[j] is Class24.Class42)
							{
								array5[j].vmethod_10(Class24.Class35.smethod_1(parameters[j].ParameterType.GetElementType(), array4[j]));
							}
							else
							{
								array5[j].vmethod_10(Class24.Class35.smethod_1(parameters[j].ParameterType, array4[j]));
							}
						}
						else
						{
							((Class24.Class39)array5[j]).method_5(Class24.Class35.smethod_1(parameters[j].ParameterType, array4[j]));
						}
					}
				}
				this.class52_0.method_2(Class24.Class35.smethod_1(constructorInfo.DeclaringType, obj));
				return;
			}
			case (Class24.Enum6)101:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_43());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)103:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_25());
				return;
			}
			case (Class24.Enum6)105:
				this.class52_0.method_2(this.class52_0.method_3());
				return;
			case (Class24.Enum6)106:
				this.class52_0.method_2(((Class24.Class36)this.class52_0.method_4()).vmethod_55());
				return;
			case (Class24.Enum6)107:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class24).Module.ResolveType(num);
				object obj = this.class52_0.method_4().vmethod_8().vmethod_4(type);
				Class24.Class35 @class = Class24.Class35.smethod_1(type, obj);
				this.class52_0.method_2(@class);
				return;
			}
			case (Class24.Enum6)108:
				this.class52_0.method_2(this.class52_0.method_4().vmethod_8());
				return;
			case (Class24.Enum6)109:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class24).Module.ResolveField(num);
				object obj = this.class52_0.method_4().vmethod_4(fieldInfo.FieldType);
				fieldInfo.SetValue(null, obj);
				return;
			}
			case (Class24.Enum6)110:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_40());
				return;
			}
			case (Class24.Enum6)112:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (!@class.vmethod_0())
				{
					throw new Class24.Exception1();
				}
				object obj = @class.vmethod_4(null);
				if (obj != null)
				{
					@class = Class24.Class35.smethod_1(obj.GetType(), obj);
				}
				else
				{
					@class = new Class24.Class47(null);
				}
				this.class52_0.method_2(@class);
				return;
			}
			case (Class24.Enum6)113:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_23());
				return;
			}
			case (Class24.Enum6)114:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_29());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)115:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_33());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)117:
			{
				bool flag = false;
				Class24.Class35 @class = this.class52_0.method_4();
				flag = @class == null || !@class.vmethod_7();
				if (flag)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)118:
			{
				IntPtr intPtr = Marshal.AllocHGlobal((this.class52_0.method_4() as Class24.Class36).vmethod_19().struct7_0.int_0);
				if (this.list_0 == null)
				{
					this.list_0 = new List<IntPtr>();
				}
				this.list_0.Add(intPtr);
				this.class52_0.method_2(new Class24.Class39(intPtr));
				return;
			}
			case (Class24.Enum6)119:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class24).Module.ResolveField(num);
				object obj = this.class52_0.method_4().vmethod_4(null);
				this.class52_0.method_2(Class24.Class35.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
				return;
			}
			case (Class24.Enum6)120:
			{
				int num = (int)this.object_0;
				Type type2 = typeof(Class24).Module.ResolveType(num);
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Array array3 = Array.CreateInstance(type2, class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(new Class24.Class47(array3));
				return;
			}
			case (Class24.Enum6)121:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_27());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class37((int)(*(byte*)(void*)intPtr), (Class24.Enum4)2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)122:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				this.class52_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class24.Enum6)124:
				this.bool_3 = (bool)this.class52_0.method_4().vmethod_4(typeof(bool));
				this.bool_1 = true;
				return;
			case (Class24.Enum6)125:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				this.class52_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class24.Enum6)126:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_36());
				return;
			}
			case (Class24.Enum6)128:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(short), obj));
				return;
			}
			case (Class24.Enum6)130:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_27());
				return;
			}
			case (Class24.Enum6)131:
				this.class52_0.method_2(new Class24.Class40((float)this.object_0));
				return;
			case (Class24.Enum6)132:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.Add(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)133:
			{
				Array array3 = (Array)this.class52_0.method_4().vmethod_4(null);
				this.class52_0.method_2(new Class24.Class37(array3.Length, (Class24.Enum4)5));
				return;
			}
			case (Class24.Enum6)134:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_46());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)135:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_41());
				return;
			}
			case (Class24.Enum6)136:
			{
				Class24.Class35 class14 = this.class52_0.method_4();
				Class24.Class35 @class = this.class52_0.method_4();
				if (class14.vmethod_5(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)137:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class24).Module;
				object obj = null;
				try
				{
					obj = module.ResolveType(num);
				}
				catch
				{
					try
					{
						obj = module.ResolveMethod(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveField(num);
						}
						catch
						{
							obj = module.ResolveMember(num);
						}
					}
				}
				this.class52_0.method_2(new Class24.Class47(obj));
				return;
			}
			case (Class24.Enum6)138:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_29());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class37(*(uint*)(void*)intPtr, (Class24.Enum4)6));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)139:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class24).Module;
				this.class52_0.method_2(new Class24.Class39(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class24.Enum6)140:
			{
				object obj = Class24.Class33.object_2;
				lock (obj)
				{
					Class24.Class35 @class = this.class52_0.method_4();
					object obj2 = this.class52_0.method_4().vmethod_4(null);
					Class24.Class33.dictionary_1[obj2] = @class;
				}
				return;
			}
			case (Class24.Enum6)141:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class52_0.method_2(class2.vmethod_70(class3));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)142:
			{
				Class24.Class35 class15 = Class24.Class33.smethod_6(this.class52_0.method_4());
				Class24.Class35 @class = Class24.Class33.smethod_6(this.class52_0.method_4());
				if (!class15.vmethod_5(@class))
				{
					this.class52_0.method_2(new Class24.Class37(0));
					return;
				}
				this.class52_0.method_2(new Class24.Class37(1));
				return;
			}
			case (Class24.Enum6)143:
			{
				int num = (int)this.object_0;
				MethodBase methodBase = typeof(Class24).Module.ResolveMethod(num);
				Type type = this.class52_0.method_4().vmethod_4(null).GetType();
				List<Type> list2 = new List<Type>();
				do
				{
					list2.Add(type);
					type = type.BaseType;
				}
				while (type != null && type != methodBase.DeclaringType);
				list2.Reverse();
				MethodBase methodBase2 = methodBase;
				foreach (Type type3 in list2)
				{
					foreach (MethodInfo methodInfo in type3.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						if (methodInfo.GetBaseDefinition() == methodBase2)
						{
							methodBase2 = methodInfo;
							break;
						}
					}
				}
				this.class52_0.method_2(new Class24.Class39(methodBase2.MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class24.Enum6)145:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(IntPtr), obj));
				return;
			}
			case (Class24.Enum6)146:
				this.int_0 = (int)this.object_0 - 1;
				this.bool_0 = true;
				return;
			case (Class24.Enum6)147:
				if (Class24.OgDrYbhOg7.Count == 0)
				{
					Module module = typeof(Class24).Module;
					this.class52_0.method_2(new Class24.Class48(module.ResolveString((int)this.object_0 | 1879048192)));
					return;
				}
				this.class52_0.method_2(new Class24.Class48(Class24.OgDrYbhOg7[(int)this.object_0]));
				return;
			case (Class24.Enum6)148:
				this.class52_0.method_2(new Class24.Class37((int)this.object_0));
				return;
			case (Class24.Enum6)149:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_69());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)150:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_72(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)151:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_32());
				return;
			}
			case (Class24.Enum6)152:
			{
				int[] array6 = (int[])this.object_0;
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				long num3 = class2.vmethod_21().struct8_0.long_0;
				if ((num3 < 0L || class2.method_3()) && IntPtr.Size == 4)
				{
					num3 = (long)((int)num3);
				}
				if (class2.method_0())
				{
					Class24.Class37 class16 = (Class24.Class37)class2;
					if (class16.enum4_0 == (Class24.Enum4)6)
					{
						num3 = (long)((ulong)class16.struct7_0.uint_0);
					}
				}
				if (num3 < (long)array6.Length && num3 >= 0L)
				{
					this.int_0 = array6[(int)(checked((IntPtr)num3))] - 1;
				}
				return;
			}
			case (Class24.Enum6)153:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_66(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)154:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_42());
				return;
			}
			case (Class24.Enum6)155:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				bool flag2 = Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_82(@class);
				if (!flag2)
				{
					this.class52_0.method_2(new Class24.Class37(0));
				}
				else
				{
					this.class52_0.method_2(new Class24.Class37(1));
				}
				if (flag2)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class24.Enum6)156:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_58(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)157:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_77(@class))
				{
					this.class52_0.method_2(new Class24.Class37(1));
					return;
				}
				this.class52_0.method_2(new Class24.Class37(0));
				return;
			}
			case (Class24.Enum6)158:
			{
				int num = (int)this.object_0;
				if (!this.class30_0.methodBase_0.IsStatic)
				{
					this.class35_0[num] = this.method_7(this.class52_0.method_4(), this.class30_0.class26_0[num - 1].enum4_0, false);
					return;
				}
				this.class35_0[num] = this.method_7(this.class52_0.method_4(), this.class30_0.class26_0[num].enum4_0, false);
				return;
			}
			case (Class24.Enum6)159:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class24.Class36)@class).vmethod_50();
				}
				this.class52_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class24.Enum6)162:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = (Class24.Class36)this.class52_0.method_4();
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_59(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)163:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 == null)
				{
					throw new Class24.Exception1();
				}
				this.class52_0.method_2(class2.vmethod_50());
				return;
			}
			case (Class24.Enum6)164:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				Class24.Class36 class3 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class52_0.method_2(class3.vmethod_64(class2));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)165:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(ushort), obj));
				return;
			}
			case (Class24.Enum6)166:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				object obj = ((Array)this.class52_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_19().struct7_0.int_0);
				this.class52_0.method_2(Class24.Class35.smethod_1(typeof(int), obj));
				return;
			}
			case (Class24.Enum6)167:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_24());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class37((int)(*(short*)(void*)intPtr), (Class24.Enum4)3));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)168:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_44());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)170:
			{
				Class24.Class36 class2 = Class24.Class33.smethod_1(this.class52_0.method_4());
				if (class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_45());
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)171:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				Class24.Class36 class2 = Class24.Class33.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class52_0.method_2(class2.vmethod_26());
					return;
				}
				if (class2 != null && class2.method_1())
				{
					IntPtr intPtr = ((Class24.Class39)class2).method_6();
					this.class52_0.method_2(new Class24.Class38(*(long*)(void*)intPtr, (Class24.Enum4)7));
					return;
				}
				throw new Class24.Exception1();
			}
			case (Class24.Enum6)172:
			{
				Class24.Class36 class2 = this.class52_0.method_4() as Class24.Class36;
				Class24.Class36 class3 = this.class52_0.method_4() as Class24.Class36;
				IntPtr intPtr = Class24.Class33.smethod_8(this.class52_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class3.vmethod_16().struct7_0.byte_0;
					uint num2 = class2.vmethod_20().struct7_0.uint_0;
					Class24.Class33.smethod_10(intPtr, byte_, (int)num2);
				}
				return;
			}
			case (Class24.Enum6)173:
			{
				Class24.Class35 @class = this.class52_0.method_4();
				if (!Class24.Class33.smethod_1(this.class52_0.method_4()).vmethod_82(@class))
				{
					this.class52_0.method_2(new Class24.Class37(0));
					return;
				}
				this.class52_0.method_2(new Class24.Class37(1));
				return;
			}
			case (Class24.Enum6)175:
				this.class52_0.method_2(new Class24.Class40((double)this.object_0));
				return;
			default:
				return;
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x000AA910 File Offset: 0x000A8B10
		private Class24.Class35 method_7(Class24.Class35 class35_3, Class24.Enum4 enum4_0, bool bool_4 = false)
		{
			if (!bool_4 && class35_3.vmethod_0())
			{
				class35_3 = class35_3.vmethod_8();
			}
			if (class35_3.method_0())
			{
				return ((Class24.Class37)class35_3).vmethod_13(enum4_0);
			}
			if (class35_3.method_2())
			{
				return ((Class24.Class38)class35_3).vmethod_13(enum4_0);
			}
			if (class35_3.method_3())
			{
				return ((Class24.Class40)class35_3).vmethod_13(enum4_0);
			}
			if (class35_3.method_1())
			{
				return ((Class24.Class39)class35_3).vmethod_13(enum4_0);
			}
			return class35_3;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x000080F8 File Offset: 0x000062F8
		private Class24.Class35 method_8(int int_3)
		{
			return this.class35_1[int_3];
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000AA988 File Offset: 0x000A8B88
		private void method_9(int int_3)
		{
			this.method_10(int_3, this.class52_0.method_4());
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000AA9A8 File Offset: 0x000A8BA8
		private static int smethod_0(Type type_0)
		{
			object obj = Class24.Class33.object_1;
			int num2;
			lock (obj)
			{
				if (Class24.Class33.dictionary_0 == null)
				{
					Class24.Class33.dictionary_0 = new Dictionary<Type, int>();
				}
				try
				{
					int num = 0;
					if (Class24.Class33.dictionary_0.TryGetValue(type_0, out num))
					{
						num2 = num;
					}
					else
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, type_0);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						Class24.Class33.dictionary_0[type_0] = num;
						num2 = num;
					}
				}
				catch
				{
					num2 = 0;
				}
			}
			return num2;
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000AAA7C File Offset: 0x000A8C7C
		private void method_10(int int_3, Class24.Class35 class35_3)
		{
			this.class35_1[int_3] = this.method_7(class35_3, this.class30_0.list_1[int_3].enum4_0, this.class30_0.list_1[int_3].bool_0);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000A21FC File Offset: 0x000A03FC
		private static Class24.Class36 smethod_1(Class24.Class35 class35_3)
		{
			Class24.Class36 @class = class35_3 as Class24.Class36;
			if (@class == null && class35_3.vmethod_0())
			{
				@class = class35_3.vmethod_8() as Class24.Class36;
			}
			return @class;
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000AAAC4 File Offset: 0x000A8CC4
		private void method_11(bool bool_4)
		{
			int num = (int)this.object_0;
			MethodBase methodBase = typeof(Class24).Module.ResolveMethod(num);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class24.Class35[] array2 = new Class24.Class35[parameters.Length];
			List<Class24.Class31> list = null;
			Class24.Class32 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class24.Class35 class2 = this.class52_0.method_4();
				Type type = parameters[parameters.Length - 1 - i].ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef)
				{
					Class24.Class44 class3 = class2 as Class24.Class44;
					if (class3 != null)
					{
						if (list == null)
						{
							list = new List<Class24.Class31>();
						}
						list.Add(new Class24.Class31(class3.fieldInfo_0, parameters.Length - 1 - i));
						obj = class3.object_0;
						if (obj is Class24.Class35)
						{
							class2 = obj as Class24.Class35;
						}
						else
						{
							flag = true;
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									if (class3.fieldInfo_0.IsStatic)
									{
										obj = class3.fieldInfo_0.GetValue(null);
									}
									else
									{
										obj = Activator.CreateInstance(type);
									}
									if (class2 is Class24.Class42)
									{
										((Class24.Class41)class2).vmethod_12(Class24.Class35.smethod_1(type, obj));
									}
								}
							}
						}
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_4(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class24.Class42)
							{
								((Class24.Class41)class2).vmethod_12(Class24.Class35.smethod_1(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Class24.Delegate11 @delegate = null;
			Class24.Class33.Delegate16 delegate2 = null;
			if (list == null)
			{
				if (methodInfo != null && methodInfo.ReturnType.IsByRef)
				{
					@delegate = Class24.Class33.smethod_2(methodBase, bool_4);
				}
				else if (bool_4 && methodInfo != null && methodBase.IsVirtual)
				{
					delegate2 = Class24.Class33.smethod_5(methodBase, bool_4);
				}
			}
			else
			{
				@class = new Class24.Class32(methodBase, list);
				@delegate = Class24.Class33.smethod_3(methodBase, bool_4, @class);
			}
			object obj2 = null;
			Class24.Class35 class4 = null;
			bool flag2 = Nullable.GetUnderlyingType(methodBase.DeclaringType) != null;
			if (!methodBase.IsStatic)
			{
				class4 = this.class52_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_4(methodBase.DeclaringType);
				}
				if (obj2 == null && !flag2)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (obj2 == null && Nullable.GetUnderlyingType(type2) != null)
					{
						obj2 = FormatterServices.GetUninitializedObject(type2);
					}
					if (class4 is Class24.Class42)
					{
						((Class24.Class41)class4).vmethod_12(Class24.Class35.smethod_1(type2, obj2));
					}
				}
			}
			object obj3 = null;
			if (obj2 != null || !flag2)
			{
				if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
				{
					obj3 = array[0];
					if (class4 != null && class4 is Class24.Class42)
					{
						((Class24.Class41)class4).vmethod_12(Class24.Class35.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
					}
				}
				else if (@delegate != null)
				{
					obj3 = @delegate(obj2, array);
				}
				else if (delegate2 == null)
				{
					obj3 = methodBase.Invoke(obj2, array);
				}
				else
				{
					obj3 = delegate2(ref obj2, array);
					if (!methodBase.DeclaringType.IsClass && !methodBase.DeclaringType.IsInterface && class4 != null && class4 is Class24.Class41)
					{
						Type type3 = Nullable.GetUnderlyingType(methodBase.DeclaringType);
						if (type3 == null)
						{
							type3 = methodBase.DeclaringType;
						}
						((Class24.Class41)class4).vmethod_12(Class24.Class35.smethod_1(type3, obj2));
					}
				}
			}
			else if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
			{
				obj3 = array[0];
				if (class4 != null && class4 is Class24.Class42)
				{
					((Class24.Class41)class4).vmethod_12(Class24.Class35.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
				}
			}
			else if (methodBase.Name == Class24.Class33.string_0)
			{
				obj3 = false;
			}
			else if (!(methodBase.Name == Class24.Class33.string_1))
			{
				if (methodBase.Name == Class24.Class33.string_4)
				{
					if (array[0] == null)
					{
						obj3 = true;
					}
					else
					{
						obj3 = false;
					}
				}
				else if (!(methodBase.Name == Class24.Class33.string_3))
				{
					if (!(methodBase.Name == Class24.Class33.string_2))
					{
						if (methodBase.Name == Class24.Class33.string_5)
						{
							obj3 = "";
						}
					}
					else
					{
						Class24.Class50 class5 = Class24.Class50.smethod_0(Nullable.GetUnderlyingType(methodBase.DeclaringType));
						if (array != null && array.Length != 0)
						{
							obj3 = class5.vmethod_3(array[0]);
						}
						else
						{
							obj3 = class5.vmethod_2();
						}
					}
				}
				else
				{
					obj3 = 0;
				}
			}
			else
			{
				obj3 = null;
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (array2[j].method_1())
					{
						((Class24.Class39)array2[j]).method_5(Class24.Class35.smethod_1(parameters[j].ParameterType, array[j]));
					}
					else if (array2[j] is Class24.Class42)
					{
						array2[j].vmethod_10(Class24.Class35.smethod_1(parameters[j].ParameterType.GetElementType(), array[j]));
					}
					else
					{
						array2[j].vmethod_10(Class24.Class35.smethod_1(parameters[j].ParameterType, array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class52_0.method_2(Class24.Class35.smethod_1(methodInfo.ReturnType, obj3));
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x000AB118 File Offset: 0x000A9318
		private static Class24.Delegate11 smethod_2(object object_8, bool bool_4)
		{
			object obj = Class24.Class33.object_3;
			Class24.Delegate11 delegate3;
			lock (obj)
			{
				Class24.Delegate11 @delegate = null;
				if (!bool_4)
				{
					if (Class24.Class33.dictionary_3.TryGetValue(object_8, out @delegate))
					{
						return @delegate;
					}
				}
				else if (Class24.Class33.dictionary_2.TryGetValue(object_8, out @delegate))
				{
					return @delegate;
				}
				MethodInfo methodInfo = object_8 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_8.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				int num = array.Length;
				if (object_8.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (object_8.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_8.DeclaringType);
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class24.Class33.GhfArhuwhQ(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!array[k].IsValueType)
					{
						if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_8.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (object_8.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, object_8.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, object_8.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
				}
				if (bool_4)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Call, object_8 as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, object_8 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class24.Class33.GhfArhuwhQ(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class24.Delegate11 delegate2 = (Class24.Delegate11)dynamicMethod.CreateDelegate(typeof(Class24.Delegate11));
				if (bool_4)
				{
					Class24.Class33.dictionary_2.Add(object_8, delegate2);
				}
				else
				{
					Class24.Class33.dictionary_3.Add(object_8, delegate2);
				}
				delegate3 = delegate2;
			}
			return delegate3;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x000AB5C4 File Offset: 0x000A97C4
		private static Class24.Delegate11 smethod_3(object object_8, bool bool_4, Class24.Class32 class32_0)
		{
			object obj = Class24.Class33.object_4;
			Class24.Delegate11 delegate3;
			lock (obj)
			{
				Class24.Delegate11 @delegate = null;
				if (!bool_4)
				{
					if (Class24.Class33.dictionary_5.TryGetValue(class32_0, out @delegate))
					{
						return @delegate;
					}
				}
				else if (Class24.Class33.dictionary_4.TryGetValue(class32_0, out @delegate))
				{
					return @delegate;
				}
				MethodInfo methodInfo = object_8 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class24), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_8.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				int num = array.Length;
				if (object_8.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (!class32_0.method_1(j))
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
				}
				if (object_8.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_8.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class24.Class33.GhfArhuwhQ(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class32_0.method_1(k))
					{
						if (!array[k].IsValueType)
						{
							if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_8.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (!object_8.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, object_8.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox, object_8.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!class32_0.method_1(l))
					{
						if (parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
					}
					else
					{
						Class24.Class31 @class = class32_0.method_0(l);
						if (!@class.object_0.IsStatic)
						{
							if (!@class.object_0.DeclaringType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Castclass, @class.object_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Unbox, @class.object_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldsflda, @class.object_0);
						}
					}
				}
				if (!bool_4)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Callvirt, object_8 as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
					}
				}
				else if (!(methodInfo != null))
				{
					ilgenerator.Emit(OpCodes.Call, object_8 as ConstructorInfo);
				}
				else
				{
					ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (!class32_0.method_1(m))
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							Class24.Class33.GhfArhuwhQ(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
						else
						{
							Class24.Class31 class2 = class32_0.method_0(m);
							if (!class2.object_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class24.Class33.GhfArhuwhQ(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.object_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class24.Class33.GhfArhuwhQ(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, class2.object_0);
								if (class2.object_0.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.object_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class24.Delegate11 delegate2 = (Class24.Delegate11)dynamicMethod.CreateDelegate(typeof(Class24.Delegate11));
				if (!bool_4)
				{
					Class24.Class33.dictionary_5.Add(class32_0, delegate2);
				}
				else
				{
					Class24.Class33.dictionary_4.Add(class32_0, delegate2);
				}
				delegate3 = delegate2;
			}
			return delegate3;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x000ABC6C File Offset: 0x000A9E6C
		private static Class24.Delegate11 smethod_4(object object_8, bool bool_4, Class24.Class32 class32_0)
		{
			object obj = Class24.Class33.object_5;
			Class24.Delegate11 delegate3;
			lock (obj)
			{
				Class24.Delegate11 @delegate = null;
				if (!Class24.Class33.dictionary_6.TryGetValue(class32_0, out @delegate))
				{
					ConstructorInfo constructorInfo = object_8 as ConstructorInfo;
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
					{
						typeof(object),
						typeof(object[])
					}, typeof(Class24), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ParameterInfo[] parameters = object_8.GetParameters();
					Type[] array = new Type[parameters.Length];
					for (int i = 0; i < array.Length; i++)
					{
						if (!parameters[i].ParameterType.IsByRef)
						{
							array[i] = parameters[i].ParameterType;
						}
						else
						{
							array[i] = parameters[i].ParameterType.GetElementType();
						}
					}
					int num = array.Length;
					if (object_8.DeclaringType.IsValueType)
					{
						num++;
					}
					LocalBuilder[] array2 = new LocalBuilder[num];
					for (int j = 0; j < array.Length; j++)
					{
						if (!class32_0.method_1(j))
						{
							array2[j] = ilgenerator.DeclareLocal(array[j]);
						}
						else
						{
							array2[j] = ilgenerator.DeclareLocal(typeof(object));
						}
					}
					if (object_8.DeclaringType.IsValueType)
					{
						array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_8.DeclaringType.MakeByRefType());
					}
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class24.Class33.GhfArhuwhQ(ilgenerator, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						if (!class32_0.method_1(k))
						{
							if (array[k].IsValueType)
							{
								ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
							}
							else if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						ilgenerator.Emit(OpCodes.Stloc, array2[k]);
					}
					for (int l = 0; l < array.Length; l++)
					{
						if (!class32_0.method_1(l))
						{
							if (parameters[l].ParameterType.IsByRef)
							{
								ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							}
						}
						else
						{
							Class24.Class31 @class = class32_0.method_0(l);
							if (@class.object_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldsflda, @class.object_0);
							}
							else if (!@class.object_0.DeclaringType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Castclass, @class.object_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Unbox, @class.object_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
							}
						}
					}
					ilgenerator.Emit(OpCodes.Newobj, object_8 as ConstructorInfo);
					if (constructorInfo.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
					}
					for (int m = 0; m < array.Length; m++)
					{
						if (parameters[m].ParameterType.IsByRef)
						{
							if (!class32_0.method_1(m))
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class24.Class33.GhfArhuwhQ(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								Class24.Class31 class2 = class32_0.method_0(m);
								if (!class2.object_0.IsStatic)
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class24.Class33.GhfArhuwhQ(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
									if (array2[m].LocalType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class24.Class33.GhfArhuwhQ(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldsfld, class2.object_0);
									if (class2.object_0.FieldType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class24.Delegate11 delegate2 = (Class24.Delegate11)dynamicMethod.CreateDelegate(typeof(Class24.Delegate11));
					Class24.Class33.dictionary_6.Add(class32_0, delegate2);
					delegate3 = delegate2;
				}
				else
				{
					delegate3 = @delegate;
				}
			}
			return delegate3;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x000AC198 File Offset: 0x000AA398
		private static void GhfArhuwhQ(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (int_3 > -129 && int_3 < 128)
				{
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
					return;
				}
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
				return;
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x000AC278 File Offset: 0x000AA478
		private static Class24.Class33.Delegate16 smethod_5(object object_8, bool bool_4)
		{
			object obj = Class24.Class33.object_6;
			Class24.Class33.Delegate16 delegate3;
			lock (obj)
			{
				Class24.Class33.Delegate16 @delegate = null;
				if (!bool_4)
				{
					if (Class24.Class33.dictionary_8.TryGetValue(object_8, out @delegate))
					{
						return @delegate;
					}
				}
				else if (Class24.Class33.dictionary_7.TryGetValue(object_8, out @delegate))
				{
					return @delegate;
				}
				MethodInfo methodInfo = object_8 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object).MakeByRefType(),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_8.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				LocalBuilder[] array2 = new LocalBuilder[array.Length + 1];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_8.DeclaringType);
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class24.Class33.GhfArhuwhQ(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (array[k].IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					else if (array[k] != typeof(object))
					{
						ilgenerator.Emit(OpCodes.Castclass, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_8.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldind_Ref);
					if (object_8.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, object_8.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, object_8.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (!bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Callvirt, object_8 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Call, object_8 as ConstructorInfo);
				}
				if (!object_8.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldloc, array2[array2.Length - 1]);
					if (object_8.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, object_8.DeclaringType);
					}
					ilgenerator.Emit(OpCodes.Stind_Ref);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class24.Class33.GhfArhuwhQ(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class24.Class33.Delegate16 delegate2 = (Class24.Class33.Delegate16)dynamicMethod.CreateDelegate(typeof(Class24.Class33.Delegate16));
				if (bool_4)
				{
					Class24.Class33.dictionary_7.Add(object_8, delegate2);
				}
				else
				{
					Class24.Class33.dictionary_8.Add(object_8, delegate2);
				}
				delegate3 = delegate2;
			}
			return delegate3;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000AC794 File Offset: 0x000AA994
		private static Class24.Class35 smethod_6(Class24.Class35 class35_3)
		{
			if (class35_3.vmethod_8().anLwXoVydS())
			{
				object obj = class35_3.vmethod_4(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object obj2 = Convert.ChangeType(obj, underlyingType);
					Class24.Class35 @class = Class24.Class33.smethod_7(Class24.Class35.smethod_1(underlyingType, obj2));
					if (@class != null)
					{
						return @class as Class24.Class36;
					}
				}
			}
			return class35_3;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000AC800 File Offset: 0x000AAA00
		private static Class24.Class36 smethod_7(Class24.Class35 class35_3)
		{
			Class24.Class36 @class = class35_3 as Class24.Class36;
			if (@class == null && class35_3.vmethod_0())
			{
				@class = class35_3.vmethod_8() as Class24.Class36;
			}
			return @class;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x000AC830 File Offset: 0x000AAA30
		private static IntPtr smethod_8(object object_8)
		{
			if (object_8 == null)
			{
				return IntPtr.Zero;
			}
			if (object_8.method_1())
			{
				return ((Class24.Class39)object_8).method_6();
			}
			if (object_8.vmethod_0())
			{
				Class24.Class41 @class = (Class24.Class41)object_8;
				IntPtr intPtr;
				try
				{
					intPtr = @class.vmethod_11();
				}
				catch
				{
					goto IL_003E;
				}
				return intPtr;
			}
			IL_003E:
			object obj = object_8.vmethod_4(typeof(IntPtr));
			if (obj == null || !(obj.GetType() == typeof(IntPtr)))
			{
				throw new Class24.Exception1();
			}
			return (IntPtr)obj;
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000AC8C8 File Offset: 0x000AAAC8
		private static object smethod_9(object object_8)
		{
			object obj = Class24.Class33.object_7;
			object obj2;
			lock (obj)
			{
				if (Class24.Class33.dictionary_9 == null)
				{
					Class24.Class33.dictionary_9 = new Dictionary<Type, Class24.Delegate13>();
				}
				if (object_8 != null)
				{
					try
					{
						Type type = object_8.GetType();
						Class24.Delegate13 @delegate;
						if (!Class24.Class33.dictionary_9.TryGetValue(type, out @delegate))
						{
							DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[] { typeof(object) }, true);
							ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
							ilgenerator.Emit(OpCodes.Ldarg_0);
							ilgenerator.Emit(OpCodes.Unbox_Any, type);
							ilgenerator.Emit(OpCodes.Box, type);
							ilgenerator.Emit(OpCodes.Ret);
							Class24.Delegate13 delegate2 = (Class24.Delegate13)dynamicMethod.CreateDelegate(typeof(Class24.Delegate13));
							Class24.Class33.dictionary_9.Add(type, delegate2);
							return delegate2(object_8);
						}
						return @delegate(object_8);
					}
					catch
					{
						return null;
					}
				}
				obj2 = null;
			}
			return obj2;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x000AC9EC File Offset: 0x000AABEC
		private static void smethod_10(IntPtr intptr_0, byte byte_0, int int_3)
		{
			object obj = Class24.Class33.object_7;
			lock (obj)
			{
				if (Class24.Class33.delegate14_0 == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(Class24), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					Class24.Class33.delegate14_0 = (Class24.Delegate14)dynamicMethod.CreateDelegate(typeof(Class24.Delegate14));
				}
				Class24.Class33.delegate14_0(intptr_0, byte_0, int_3);
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x000ACAE4 File Offset: 0x000AACE4
		private static void smethod_11(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (Class24.Class33.delegate15_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class24), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldarg_1);
				ilgenerator.Emit(OpCodes.Ldarg_2);
				ilgenerator.Emit(OpCodes.Cpblk);
				ilgenerator.Emit(OpCodes.Ret);
				Class24.Class33.delegate15_0 = (Class24.Delegate15)dynamicMethod.CreateDelegate(typeof(Class24.Delegate15));
			}
			Class24.Class33.delegate15_0(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x04000932 RID: 2354
		internal Class24.Class30 class30_0;

		// Token: 0x04000933 RID: 2355
		internal Class24.Class35[] class35_0 = new Class24.Class35[0];

		// Token: 0x04000934 RID: 2356
		internal Class24.Class35[] class35_1 = new Class24.Class35[0];

		// Token: 0x04000935 RID: 2357
		internal Class24.Class52 class52_0 = new Class24.Class52();

		// Token: 0x04000936 RID: 2358
		internal Class24.Class35 class35_2;

		// Token: 0x04000937 RID: 2359
		internal Exception exception_0;

		// Token: 0x04000938 RID: 2360
		internal List<IntPtr> list_0;

		// Token: 0x04000939 RID: 2361
		private int int_0;

		// Token: 0x0400093A RID: 2362
		private int int_1;

		// Token: 0x0400093B RID: 2363
		private int int_2 = -1;

		// Token: 0x0400093C RID: 2364
		private object object_0;

		// Token: 0x0400093D RID: 2365
		private bool bool_0;

		// Token: 0x0400093E RID: 2366
		private bool bool_1;

		// Token: 0x0400093F RID: 2367
		private bool bool_2;

		// Token: 0x04000940 RID: 2368
		private bool bool_3;

		// Token: 0x04000941 RID: 2369
		private static Dictionary<Type, int> dictionary_0;

		// Token: 0x04000942 RID: 2370
		private static object object_1 = new object();

		// Token: 0x04000943 RID: 2371
		private static Dictionary<object, Class24.Class35> dictionary_1 = new Dictionary<object, Class24.Class35>();

		// Token: 0x04000944 RID: 2372
		private static object object_2 = new object();

		// Token: 0x04000945 RID: 2373
		private static string string_0 = Encoding.Unicode.GetString(new byte[]
		{
			103, 0, 101, 0, 116, 0, 95, 0, 72, 0,
			97, 0, 115, 0, 86, 0, 97, 0, 108, 0,
			117, 0, 101, 0
		});

		// Token: 0x04000946 RID: 2374
		private static string string_1 = Encoding.Unicode.GetString(new byte[]
		{
			103, 0, 101, 0, 116, 0, 95, 0, 86, 0,
			97, 0, 108, 0, 117, 0, 101, 0
		});

		// Token: 0x04000947 RID: 2375
		private static string string_2 = Encoding.Unicode.GetString(new byte[]
		{
			71, 0, 101, 0, 116, 0, 86, 0, 97, 0,
			108, 0, 117, 0, 101, 0, 79, 0, 114, 0,
			68, 0, 101, 0, 102, 0, 97, 0, 117, 0,
			108, 0, 116, 0
		});

		// Token: 0x04000948 RID: 2376
		private static string string_3 = Encoding.Unicode.GetString(new byte[]
		{
			71, 0, 101, 0, 116, 0, 72, 0, 97, 0,
			115, 0, 104, 0, 67, 0, 111, 0, 100, 0,
			101, 0
		});

		// Token: 0x04000949 RID: 2377
		private static string string_4 = Encoding.Unicode.GetString(new byte[]
		{
			69, 0, 113, 0, 117, 0, 97, 0, 108, 0,
			115, 0
		});

		// Token: 0x0400094A RID: 2378
		private static string string_5 = Encoding.Unicode.GetString(new byte[]
		{
			84, 0, 111, 0, 83, 0, 116, 0, 114, 0,
			105, 0, 110, 0, 103, 0
		});

		// Token: 0x0400094B RID: 2379
		private static Dictionary<MethodBase, Class24.Delegate11> dictionary_2 = new Dictionary<MethodBase, Class24.Delegate11>();

		// Token: 0x0400094C RID: 2380
		private static Dictionary<MethodBase, Class24.Delegate11> dictionary_3 = new Dictionary<MethodBase, Class24.Delegate11>();

		// Token: 0x0400094D RID: 2381
		private static object object_3 = new object();

		// Token: 0x0400094E RID: 2382
		private static Dictionary<Class24.Class32, Class24.Delegate11> dictionary_4 = new Dictionary<Class24.Class32, Class24.Delegate11>();

		// Token: 0x0400094F RID: 2383
		private static Dictionary<Class24.Class32, Class24.Delegate11> dictionary_5 = new Dictionary<Class24.Class32, Class24.Delegate11>();

		// Token: 0x04000950 RID: 2384
		private static object object_4 = new object();

		// Token: 0x04000951 RID: 2385
		private static Dictionary<Class24.Class32, Class24.Delegate11> dictionary_6 = new Dictionary<Class24.Class32, Class24.Delegate11>();

		// Token: 0x04000952 RID: 2386
		private static object object_5 = new object();

		// Token: 0x04000953 RID: 2387
		private static object object_6 = new object();

		// Token: 0x04000954 RID: 2388
		private static Dictionary<MethodBase, Class24.Class33.Delegate16> dictionary_7 = new Dictionary<MethodBase, Class24.Class33.Delegate16>();

		// Token: 0x04000955 RID: 2389
		private static Dictionary<MethodBase, Class24.Class33.Delegate16> dictionary_8 = new Dictionary<MethodBase, Class24.Class33.Delegate16>();

		// Token: 0x04000956 RID: 2390
		private static Dictionary<Type, Class24.Delegate13> dictionary_9;

		// Token: 0x04000957 RID: 2391
		private static object object_7 = new object();

		// Token: 0x04000958 RID: 2392
		private static Class24.Delegate14 delegate14_0;

		// Token: 0x04000959 RID: 2393
		private static Class24.Delegate15 delegate15_0;

		// Token: 0x02000206 RID: 518
		// (Invoke) Token: 0x06001795 RID: 6037
		private delegate object Delegate16(ref object target, object[] paramters);

		// Token: 0x02000207 RID: 519
		[CompilerGenerated]
		[Serializable]
		private sealed class Class34
		{
			// Token: 0x0600179B RID: 6043 RVA: 0x00008102 File Offset: 0x00006302
			internal int method_0(Class24.Class28 x, Class24.Class28 y)
			{
				return x.class29_0.int_0.CompareTo(y.class29_0.int_0);
			}

			// Token: 0x0400095B RID: 2395
			public static readonly Class24.Class33.Class34 <>9 = new Class24.Class33.Class34();

			// Token: 0x0400095C RID: 2396
			public static Comparison<Class24.Class28> <>9__12_0;
		}
	}

	// Token: 0x02000208 RID: 520
	internal enum Enum6 : byte
	{

	}

	// Token: 0x02000209 RID: 521
	internal enum Enum7 : byte
	{

	}

	// Token: 0x0200020A RID: 522
	internal abstract class Class35
	{
		// Token: 0x0600179E RID: 6046 RVA: 0x0009B798 File Offset: 0x00099998
		public Class35()
		{
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0000811F File Offset: 0x0000631F
		internal bool anLwXoVydS()
		{
			return this.enum7_0 == (Class24.Enum7)0;
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0000812A File Offset: 0x0000632A
		internal bool method_0()
		{
			return this.enum7_0 == (Class24.Enum7)1;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00008135 File Offset: 0x00006335
		internal bool fybwgewtxN()
		{
			return this.enum7_0 == (Class24.Enum7)8;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000ACD74 File Offset: 0x000AAF74
		internal bool method_1()
		{
			return this.enum7_0 == (Class24.Enum7)3 || this.enum7_0 == (Class24.Enum7)4;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00008140 File Offset: 0x00006340
		internal bool method_2()
		{
			return this.enum7_0 == (Class24.Enum7)2;
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0000814B File Offset: 0x0000634B
		internal bool method_3()
		{
			return this.enum7_0 == (Class24.Enum7)5;
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00008156 File Offset: 0x00006356
		internal bool method_4()
		{
			return this.enum7_0 == (Class24.Enum7)6;
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00003453 File Offset: 0x00001653
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00003453 File Offset: 0x00001653
		internal virtual bool vmethod_1()
		{
			return false;
		}

		// Token: 0x060017A8 RID: 6056
		internal abstract void vmethod_2(Class24.Class35 class35_0);

		// Token: 0x060017A9 RID: 6057 RVA: 0x00003453 File Offset: 0x00001653
		internal virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000ACD98 File Offset: 0x000AAF98
		internal Class35(Class24.Enum7 enum7_1)
		{
			this.enum7_0 = enum7_1;
		}

		// Token: 0x060017AB RID: 6059
		internal abstract object vmethod_4(Type type_0);

		// Token: 0x060017AC RID: 6060
		internal abstract bool vmethod_5(Class24.Class35 class35_0);

		// Token: 0x060017AD RID: 6061
		internal abstract bool vmethod_6(Class24.Class35 class35_0);

		// Token: 0x060017AE RID: 6062
		internal abstract bool vmethod_7();

		// Token: 0x060017AF RID: 6063
		internal abstract Class24.Class35 vmethod_8();

		// Token: 0x060017B0 RID: 6064 RVA: 0x00003453 File Offset: 0x00001653
		internal virtual bool vmethod_9()
		{
			return false;
		}

		// Token: 0x060017B1 RID: 6065
		internal abstract void vmethod_10(Class24.Class35 class35_0);

		// Token: 0x060017B2 RID: 6066 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
		internal static Class24.Enum5 smethod_0(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Class24.Enum5)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type != null && Nullable.GetUnderlyingType(type) != null)
			{
				type = Nullable.GetUnderlyingType(type);
			}
			if (type == typeof(string))
			{
				return (Class24.Enum5)14;
			}
			if (type == typeof(byte))
			{
				return (Class24.Enum5)2;
			}
			if (type == typeof(sbyte))
			{
				return (Class24.Enum5)1;
			}
			if (type == typeof(short))
			{
				return (Class24.Enum5)3;
			}
			if (type == typeof(ushort))
			{
				return (Class24.Enum5)4;
			}
			if (type == typeof(int))
			{
				return (Class24.Enum5)5;
			}
			if (type == typeof(uint))
			{
				return (Class24.Enum5)6;
			}
			if (type == typeof(long))
			{
				return (Class24.Enum5)7;
			}
			if (type == typeof(ulong))
			{
				return (Class24.Enum5)8;
			}
			if (type == typeof(float))
			{
				return (Class24.Enum5)9;
			}
			if (type == typeof(double))
			{
				return (Class24.Enum5)10;
			}
			if (type == typeof(bool))
			{
				return (Class24.Enum5)11;
			}
			if (type == typeof(IntPtr))
			{
				return (Class24.Enum5)12;
			}
			if (type == typeof(UIntPtr))
			{
				return (Class24.Enum5)13;
			}
			if (type == typeof(char))
			{
				return (Class24.Enum5)15;
			}
			if (type == typeof(object))
			{
				return (Class24.Enum5)0;
			}
			if (!type.IsEnum)
			{
				return (Class24.Enum5)17;
			}
			return (Class24.Enum5)16;
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x000ACF7C File Offset: 0x000AB17C
		internal static Class24.Class35 smethod_1(Type type_0, object object_0)
		{
			Type underlyingType = Nullable.GetUnderlyingType(type_0);
			if (!(underlyingType != null))
			{
				Class24.Enum5 @enum = Class24.Class35.smethod_0(type_0);
				Class24.Enum5 enum2 = (Class24.Enum5)18;
				if (object_0 != null)
				{
					enum2 = Class24.Class35.smethod_0(object_0.GetType());
				}
				Class24.Class35 @class = null;
				switch (@enum)
				{
				case (Class24.Enum5)0:
					if (enum2 == (Class24.Enum5)15)
					{
						@class = new Class24.Class47(object_0);
					}
					else
					{
						@class = Class24.Class35.smethod_2(object_0);
					}
					break;
				case (Class24.Enum5)1:
					if (enum2 <= (Class24.Enum5)2)
					{
						if (enum2 == (Class24.Enum5)1)
						{
							@class = new Class24.Class37((int)((sbyte)object_0), (Class24.Enum4)1);
							break;
						}
						if (enum2 == (Class24.Enum5)2)
						{
							@class = new Class24.Class37((int)((sbyte)((byte)object_0)), (Class24.Enum4)1);
							break;
						}
					}
					else if (enum2 != (Class24.Enum5)11)
					{
						if (enum2 == (Class24.Enum5)15)
						{
							@class = new Class24.Class37((int)((sbyte)((char)object_0)), (Class24.Enum4)1);
							break;
						}
					}
					else
					{
						if (!(bool)object_0)
						{
							@class = new Class24.Class37(0, (Class24.Enum4)1);
							break;
						}
						@class = new Class24.Class37(1, (Class24.Enum4)1);
						break;
					}
					throw new InvalidCastException();
				case (Class24.Enum5)2:
					if (enum2 <= (Class24.Enum5)2)
					{
						if (enum2 == (Class24.Enum5)1)
						{
							@class = new Class24.Class37((int)((byte)((sbyte)object_0)), (Class24.Enum4)2);
							break;
						}
						if (enum2 == (Class24.Enum5)2)
						{
							@class = new Class24.Class37((int)((byte)object_0), (Class24.Enum4)2);
							break;
						}
					}
					else if (enum2 != (Class24.Enum5)11)
					{
						if (enum2 == (Class24.Enum5)15)
						{
							@class = new Class24.Class37((int)((byte)((char)object_0)), (Class24.Enum4)2);
							break;
						}
					}
					else
					{
						if ((bool)object_0)
						{
							@class = new Class24.Class37(1, (Class24.Enum4)2);
							break;
						}
						@class = new Class24.Class37(0, (Class24.Enum4)2);
						break;
					}
					throw new InvalidCastException();
				case (Class24.Enum5)3:
					if (enum2 != (Class24.Enum5)3)
					{
						if (enum2 != (Class24.Enum5)11)
						{
							if (enum2 != (Class24.Enum5)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class24.Class37((int)((short)((char)object_0)), (Class24.Enum4)3);
						}
						else if ((bool)object_0)
						{
							@class = new Class24.Class37(1, (Class24.Enum4)3);
						}
						else
						{
							@class = new Class24.Class37(0, (Class24.Enum4)3);
						}
					}
					else
					{
						@class = new Class24.Class37((int)((short)object_0), (Class24.Enum4)3);
					}
					break;
				case (Class24.Enum5)4:
					if (enum2 != (Class24.Enum5)4)
					{
						if (enum2 != (Class24.Enum5)11)
						{
							if (enum2 != (Class24.Enum5)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class24.Class37((int)((char)object_0), (Class24.Enum4)4);
						}
						else if ((bool)object_0)
						{
							@class = new Class24.Class37(1, (Class24.Enum4)4);
						}
						else
						{
							@class = new Class24.Class37(0, (Class24.Enum4)4);
						}
					}
					else
					{
						@class = new Class24.Class37((int)((ushort)object_0), (Class24.Enum4)4);
					}
					break;
				case (Class24.Enum5)5:
					if (enum2 != (Class24.Enum5)5)
					{
						if (enum2 != (Class24.Enum5)11)
						{
							if (enum2 != (Class24.Enum5)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class24.Class37((int)((char)object_0), (Class24.Enum4)5);
						}
						else if (!(bool)object_0)
						{
							@class = new Class24.Class37(0, (Class24.Enum4)5);
						}
						else
						{
							@class = new Class24.Class37(1, (Class24.Enum4)5);
						}
					}
					else
					{
						@class = new Class24.Class37((int)object_0, (Class24.Enum4)5);
					}
					break;
				case (Class24.Enum5)6:
					if (enum2 != (Class24.Enum5)6)
					{
						if (enum2 != (Class24.Enum5)11)
						{
							if (enum2 != (Class24.Enum5)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class24.Class37((uint)((char)object_0), (Class24.Enum4)6);
						}
						else if (!(bool)object_0)
						{
							@class = new Class24.Class37(0U, (Class24.Enum4)6);
						}
						else
						{
							@class = new Class24.Class37(1U, (Class24.Enum4)6);
						}
					}
					else
					{
						@class = new Class24.Class37((uint)object_0, (Class24.Enum4)6);
					}
					break;
				case (Class24.Enum5)7:
					if (enum2 != (Class24.Enum5)7)
					{
						if (enum2 != (Class24.Enum5)11)
						{
							if (enum2 != (Class24.Enum5)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class24.Class38((long)((ulong)((char)object_0)), (Class24.Enum4)7);
						}
						else if (!(bool)object_0)
						{
							@class = new Class24.Class38(0L, (Class24.Enum4)7);
						}
						else
						{
							@class = new Class24.Class38(1L, (Class24.Enum4)7);
						}
					}
					else
					{
						@class = new Class24.Class38((long)object_0, (Class24.Enum4)7);
					}
					break;
				case (Class24.Enum5)8:
					if (enum2 != (Class24.Enum5)8)
					{
						if (enum2 != (Class24.Enum5)11)
						{
							if (enum2 != (Class24.Enum5)15)
							{
								throw new InvalidCastException();
							}
							@class = new Class24.Class38((ulong)((char)object_0), (Class24.Enum4)8);
						}
						else if (!(bool)object_0)
						{
							@class = new Class24.Class38(0UL, (Class24.Enum4)8);
						}
						else
						{
							@class = new Class24.Class38(1UL, (Class24.Enum4)8);
						}
					}
					else
					{
						@class = new Class24.Class38((ulong)object_0, (Class24.Enum4)8);
					}
					break;
				case (Class24.Enum5)9:
					if (enum2 != (Class24.Enum5)9)
					{
						throw new InvalidCastException();
					}
					@class = new Class24.Class40((float)object_0);
					break;
				case (Class24.Enum5)10:
					if (enum2 != (Class24.Enum5)10)
					{
						throw new InvalidCastException();
					}
					@class = new Class24.Class40((double)object_0);
					break;
				case (Class24.Enum5)11:
					switch (enum2)
					{
					case (Class24.Enum5)1:
						@class = new Class24.Class37((sbyte)object_0 != 0);
						goto IL_0696;
					case (Class24.Enum5)2:
						@class = new Class24.Class37((byte)object_0 > 0);
						goto IL_0696;
					case (Class24.Enum5)3:
						@class = new Class24.Class37((short)object_0 != 0);
						goto IL_0696;
					case (Class24.Enum5)4:
						@class = new Class24.Class37((ushort)object_0 > 0);
						goto IL_0696;
					case (Class24.Enum5)5:
						@class = new Class24.Class37((int)object_0 != 0);
						goto IL_0696;
					case (Class24.Enum5)6:
						@class = new Class24.Class37((uint)object_0 > 0U);
						goto IL_0696;
					case (Class24.Enum5)7:
						@class = new Class24.Class37((long)object_0 != 0L);
						goto IL_0696;
					case (Class24.Enum5)8:
						@class = new Class24.Class37((ulong)object_0 > 0UL);
						goto IL_0696;
					case (Class24.Enum5)9:
					case (Class24.Enum5)10:
					case (Class24.Enum5)12:
					case (Class24.Enum5)13:
					case (Class24.Enum5)14:
					case (Class24.Enum5)15:
					case (Class24.Enum5)16:
						throw new InvalidCastException();
					case (Class24.Enum5)11:
						@class = new Class24.Class37((bool)object_0);
						goto IL_0696;
					case (Class24.Enum5)18:
						@class = new Class24.Class37(false);
						goto IL_0696;
					}
					@class = new Class24.Class37(object_0 != null);
					break;
				case (Class24.Enum5)12:
					if (enum2 != (Class24.Enum5)12)
					{
						throw new InvalidCastException();
					}
					@class = new Class24.Class39((IntPtr)object_0);
					break;
				case (Class24.Enum5)13:
					if (enum2 != (Class24.Enum5)13)
					{
						throw new InvalidCastException();
					}
					@class = new Class24.Class39((UIntPtr)object_0);
					break;
				case (Class24.Enum5)14:
					@class = new Class24.Class48(object_0 as string);
					break;
				case (Class24.Enum5)15:
					switch (enum2)
					{
					case (Class24.Enum5)1:
						@class = new Class24.Class37((int)((sbyte)object_0), (Class24.Enum4)15);
						break;
					case (Class24.Enum5)2:
						@class = new Class24.Class37((int)((byte)object_0), (Class24.Enum4)15);
						break;
					case (Class24.Enum5)3:
						@class = new Class24.Class37((int)((short)object_0), (Class24.Enum4)15);
						break;
					case (Class24.Enum5)4:
						@class = new Class24.Class37((int)((ushort)object_0), (Class24.Enum4)15);
						break;
					case (Class24.Enum5)5:
						@class = new Class24.Class37((int)object_0, (Class24.Enum4)15);
						break;
					case (Class24.Enum5)6:
						@class = new Class24.Class37((int)((uint)object_0), (Class24.Enum4)15);
						break;
					default:
						if (enum2 != (Class24.Enum5)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class24.Class37((int)((char)object_0), (Class24.Enum4)15);
						break;
					}
					break;
				case (Class24.Enum5)16:
				case (Class24.Enum5)17:
					@class = Class24.Class35.smethod_2(object_0);
					break;
				case (Class24.Enum5)18:
					throw new InvalidCastException();
				}
				IL_0696:
				if (type_0.IsByRef)
				{
					@class = new Class24.Class46(@class, type_0.GetElementType());
				}
				return @class;
			}
			return new Class24.Class49(object_0, underlyingType);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000AD648 File Offset: 0x000AB848
		private static Class24.Class35 smethod_2(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object obj = Convert.ChangeType(object_0, underlyingType);
				Class24.Class35 @class = Class24.Class35.smethod_3(Class24.Class35.smethod_1(underlyingType, obj));
				if (@class != null)
				{
					return @class as Class24.Class36;
				}
			}
			return new Class24.Class47(object_0);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000A21FC File Offset: 0x000A03FC
		private static Class24.Class36 smethod_3(Class24.Class35 class35_0)
		{
			Class24.Class36 @class = class35_0 as Class24.Class36;
			if (@class == null && class35_0.vmethod_0())
			{
				@class = class35_0.vmethod_8() as Class24.Class36;
			}
			return @class;
		}

		// Token: 0x04000960 RID: 2400
		internal Class24.Enum7 enum7_0;
	}

	// Token: 0x0200020B RID: 523
	private class Class47 : Class24.Class35
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x000AD6A0 File Offset: 0x000AB8A0
		public Class47()
			: this(null)
		{
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000AD6B8 File Offset: 0x000AB8B8
		internal override void vmethod_10(Class24.Class35 class35_1)
		{
			if (class35_1 is Class24.Class47)
			{
				this.class35_0 = ((Class24.Class47)class35_1).class35_0;
				this.type_0 = ((Class24.Class47)class35_1).type_0;
				return;
			}
			this.class35_0 = class35_1.vmethod_8();
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000A1074 File Offset: 0x0009F274
		internal override void vmethod_2(Class24.Class35 class35_1)
		{
			this.vmethod_10(class35_1);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000AD6FC File Offset: 0x000AB8FC
		public Class47(object object_0)
			: base((Class24.Enum7)0)
		{
			this.class35_0 = object_0;
			this.type_0 = null;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000AD720 File Offset: 0x000AB920
		public Class47(object object_0, Type type_1)
			: base((Class24.Enum7)0)
		{
			this.class35_0 = object_0;
			this.type_0 = type_1;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000AD744 File Offset: 0x000AB944
		public override string ToString()
		{
			if (this.class35_0 != null)
			{
				return this.class35_0.ToString();
			}
			return ((Class24.Enum8)5).ToString();
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x000AD778 File Offset: 0x000AB978
		internal override object vmethod_4(Type type_1)
		{
			if (this.class35_0 == null)
			{
				return null;
			}
			if (type_1 != null && type_1.IsByRef)
			{
				type_1 = type_1.GetElementType();
			}
			if (!(this.class35_0 is Class24.Class35))
			{
				object obj = this.class35_0;
				if (obj != null && type_1 != null && obj.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (!(this.type_0 != null))
			{
				object obj2 = ((Class24.Class35)this.class35_0).vmethod_4(type_1);
				if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return ((Class24.Class35)this.class35_0).vmethod_4(this.type_0);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000AD968 File Offset: 0x000ABB68
		internal override bool vmethod_5(Class24.Class35 class35_1)
		{
			if (class35_1.vmethod_0())
			{
				return ((Class24.Class41)class35_1).vmethod_5(this);
			}
			object obj = this.vmethod_4(null);
			object obj2 = class35_1.vmethod_4(null);
			return obj == obj2;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000AD9A0 File Offset: 0x000ABBA0
		internal override bool vmethod_6(Class24.Class35 class35_1)
		{
			if (!class35_1.vmethod_0())
			{
				object obj = this.vmethod_4(null);
				object obj2 = class35_1.vmethod_4(null);
				return obj != obj2;
			}
			return ((Class24.Class41)class35_1).vmethod_6(this);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000AD9DC File Offset: 0x000ABBDC
		internal override Class24.Class35 vmethod_8()
		{
			Class24.Class35 @class = this.class35_0 as Class24.Class35;
			if (@class == null)
			{
				return this;
			}
			return @class.vmethod_8();
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000ADA04 File Offset: 0x000ABC04
		internal override bool vmethod_7()
		{
			if (this.class35_0 == null)
			{
				return false;
			}
			if (this.class35_0 is bool)
			{
				return (bool)this.class35_0;
			}
			Class24.Class35 @class = this.class35_0 as Class24.Class35;
			if (@class == null)
			{
				return true;
			}
			object obj = @class.vmethod_4(null);
			return obj != null && (!(obj is bool) || (bool)obj);
		}

		// Token: 0x04000962 RID: 2402
		public Class24.Class35 class35_0;

		// Token: 0x04000963 RID: 2403
		public Type type_0;
	}

	// Token: 0x0200020C RID: 524
	private class Class48 : Class24.Class35
	{
		// Token: 0x060017C7 RID: 6087 RVA: 0x000ADA6C File Offset: 0x000ABC6C
		public Class48(string string_1)
			: base((Class24.Enum7)6)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x000ADA8C File Offset: 0x000ABC8C
		internal override void vmethod_10(Class24.Class35 class35_0)
		{
			this.string_0 = ((Class24.Class48)class35_0).string_0;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000A1074 File Offset: 0x0009F274
		internal override void vmethod_2(Class24.Class35 class35_0)
		{
			this.vmethod_10(class35_0);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x000ADAAC File Offset: 0x000ABCAC
		public override string ToString()
		{
			if (this.string_0 == null)
			{
				return ((Class24.Enum8)5).ToString();
			}
			string text = Class15.smethod_17(1387519980 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923);
			string text2 = this.string_0;
			return text + ((text2 != null) ? text2.ToString() : null) + Class15.smethod_17(1471409857 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00008161 File Offset: 0x00006361
		internal override bool vmethod_7()
		{
			return this.string_0 != null;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0000816C File Offset: 0x0000636C
		internal override object vmethod_4(Type type_0)
		{
			return this.string_0;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000ADB14 File Offset: 0x000ABD14
		internal override bool vmethod_5(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_5(this);
			}
			object obj = this.string_0;
			object obj2 = class35_0.vmethod_4(null);
			return obj == obj2;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000ADB4C File Offset: 0x000ABD4C
		internal override bool vmethod_6(Class24.Class35 class35_0)
		{
			if (class35_0.vmethod_0())
			{
				return ((Class24.Class41)class35_0).vmethod_6(this);
			}
			object obj = this.string_0;
			object obj2 = class35_0.vmethod_4(null);
			return obj != obj2;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00007ADA File Offset: 0x00005CDA
		internal override Class24.Class35 vmethod_8()
		{
			return this;
		}

		// Token: 0x04000965 RID: 2405
		public string string_0;
	}

	// Token: 0x0200020D RID: 525
	private class Class49 : Class24.Class35
	{
		// Token: 0x060017D3 RID: 6099 RVA: 0x000ADB84 File Offset: 0x000ABD84
		public Class49(object object_0, Type type_1)
			: base((Class24.Enum7)8)
		{
			this.class35_0 = object_0;
			this.type_0 = type_1;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x000ADBA8 File Offset: 0x000ABDA8
		internal override void vmethod_10(Class24.Class35 class35_1)
		{
			if (!(class35_1 is Class24.Class49))
			{
				this.class35_0 = class35_1.vmethod_8();
				return;
			}
			this.class35_0 = ((Class24.Class49)class35_1).class35_0;
			this.type_0 = ((Class24.Class49)class35_1).type_0;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000A1074 File Offset: 0x0009F274
		internal override void vmethod_2(Class24.Class35 class35_1)
		{
			this.vmethod_10(class35_1);
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x000ADBEC File Offset: 0x000ABDEC
		public override string ToString()
		{
			if (this.class35_0 != null)
			{
				string text = Class15.smethod_17(768763208 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7);
				Class24.Class35 @class = this.class35_0;
				return text + ((@class == null) ? null : @class.ToString()) + Class15.smethod_17(974403109 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f);
			}
			return ((Class24.Enum8)5).ToString();
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x000ADC54 File Offset: 0x000ABE54
		internal override bool vmethod_7()
		{
			if (this.class35_0 == null)
			{
				return false;
			}
			if (this.class35_0 is bool)
			{
				return (bool)this.class35_0;
			}
			Class24.Class35 @class = this.class35_0 as Class24.Class35;
			if (@class != null)
			{
				object obj = @class.vmethod_4(null);
				return obj != null && (!(obj is bool) || (bool)obj);
			}
			return true;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x000ADCBC File Offset: 0x000ABEBC
		internal override object vmethod_4(Type type_1)
		{
			if (this.class35_0 == null)
			{
				return null;
			}
			if (type_1 != null && type_1.IsByRef)
			{
				type_1 = type_1.GetElementType();
			}
			if (!(this.class35_0 is Class24.Class35))
			{
				object obj = this.class35_0;
				if (obj != null && type_1 != null && obj.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (!(this.type_0 != null))
			{
				object obj2 = ((Class24.Class35)this.class35_0).vmethod_4(type_1);
				if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return ((Class24.Class35)this.class35_0).vmethod_4(this.type_0);
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x000ADEB0 File Offset: 0x000AC0B0
		internal override bool vmethod_5(Class24.Class35 class35_1)
		{
			if (!class35_1.vmethod_0())
			{
				object obj = this.vmethod_4(null);
				object obj2 = class35_1.vmethod_4(null);
				return obj == obj2;
			}
			return ((Class24.Class41)class35_1).vmethod_5(this);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x000ADEE8 File Offset: 0x000AC0E8
		internal override bool vmethod_6(Class24.Class35 class35_1)
		{
			if (class35_1.vmethod_0())
			{
				return ((Class24.Class41)class35_1).vmethod_6(this);
			}
			object obj = this.vmethod_4(null);
			object obj2 = class35_1.vmethod_4(null);
			return obj != obj2;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x000ADF24 File Offset: 0x000AC124
		internal override Class24.Class35 vmethod_8()
		{
			Class24.Class35 @class = this.class35_0 as Class24.Class35;
			if (@class == null)
			{
				return this;
			}
			return @class.vmethod_8();
		}

		// Token: 0x04000967 RID: 2407
		public Class24.Class35 class35_0;

		// Token: 0x04000968 RID: 2408
		public Type type_0;
	}

	// Token: 0x0200020E RID: 526
	private abstract class Class50
	{
		// Token: 0x060017DF RID: 6111
		public abstract bool vmethod_0();

		// Token: 0x060017E0 RID: 6112
		public abstract object vmethod_1();

		// Token: 0x060017E1 RID: 6113
		public abstract object vmethod_2();

		// Token: 0x060017E2 RID: 6114
		public abstract object vmethod_3(object object_0);

		// Token: 0x060017E3 RID: 6115
		public abstract int vmethod_4();

		// Token: 0x060017E4 RID: 6116
		public abstract void vmethod_5();

		// Token: 0x060017E5 RID: 6117
		public abstract void vmethod_6(object object_0);

		// Token: 0x060017E6 RID: 6118 RVA: 0x00008174 File Offset: 0x00006374
		internal static Class24.Class50 smethod_0(Type type_0)
		{
			Class24.Class50 @class = (Class24.Class50)Activator.CreateInstance(typeof(Class24.Class51<>).MakeGenericType(new Type[] { type_0 }));
			@class.vmethod_5();
			return @class;
		}
	}

	// Token: 0x0200020F RID: 527
	private class Class51<T> : Class24.Class50 where T : struct
	{
		// Token: 0x060017EB RID: 6123 RVA: 0x0000819F File Offset: 0x0000639F
		public override bool vmethod_0()
		{
			return this.nullable_0 != null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x000081AC File Offset: 0x000063AC
		public override object vmethod_1()
		{
			return this.nullable_0.Value;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000081BE File Offset: 0x000063BE
		public override object vmethod_2()
		{
			return this.nullable_0.GetValueOrDefault();
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x000081D0 File Offset: 0x000063D0
		public override object vmethod_3(object object_1)
		{
			return this.nullable_0.GetValueOrDefault((T)((object)object_1));
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x000081E8 File Offset: 0x000063E8
		public override int vmethod_4()
		{
			return this.nullable_0.GetHashCode();
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000ADF4C File Offset: 0x000AC14C
		public override void vmethod_5()
		{
			for (;;)
			{
				this.nullable_0 = null;
				int num = 0;
				if (!Class24.Class51<T>.smethod_1())
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x000ADF84 File Offset: 0x000AC184
		public override void vmethod_6(object object_1)
		{
			IL_003C:
			while (object_1 != null)
			{
				for (;;)
				{
					this.nullable_0 = new T?((T)((object)object_1));
					int num = 1;
					if (Class24.Class51<T>.smethod_2() == null)
					{
						switch (num)
						{
						case 1:
							return;
						case 2:
							return;
						case 3:
							continue;
						case 4:
							goto IL_003C;
						}
						break;
					}
					break;
				}
				break;
				break;
			}
			this.vmethod_5();
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000081FB File Offset: 0x000063FB
		internal static bool smethod_1()
		{
			return Class24.Class51<T>.object_0 == null;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00008205 File Offset: 0x00006405
		internal static object smethod_2()
		{
			return Class24.Class51<T>.object_0;
		}

		// Token: 0x0400096B RID: 2411
		public T? nullable_0;

		// Token: 0x0400096C RID: 2412
		internal static object object_0;
	}

	// Token: 0x02000210 RID: 528
	internal class Class52
	{
		// Token: 0x060017F6 RID: 6134 RVA: 0x0000820C File Offset: 0x0000640C
		public int method_0()
		{
			return this.list_0.Count;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x000ADFF4 File Offset: 0x000AC1F4
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000AE00C File Offset: 0x000AC20C
		public void method_2(Class24.Class35 class35_0)
		{
			this.list_0.Add(class35_0);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00008219 File Offset: 0x00006419
		public Class24.Class35 method_3()
		{
			return this.list_0[this.list_0.Count - 1];
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00008233 File Offset: 0x00006433
		public Class24.Class35 method_4()
		{
			Class24.Class35 @class = this.method_3();
			if (this.list_0.Count != 0)
			{
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			return @class;
		}

		// Token: 0x0400096D RID: 2413
		private List<Class24.Class35> list_0 = new List<Class24.Class35>();
	}

	// Token: 0x02000211 RID: 529
	private struct Struct9
	{
		// Token: 0x060017FF RID: 6143 RVA: 0x000AE048 File Offset: 0x000AC248
		public Struct9(int int_0, int int_1)
		{
			this.stringBuilder_0 = new StringBuilder();
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000AE048 File Offset: 0x000AC248
		public Struct9(int int_0, int int_1, IFormatProvider iformatProvider_0)
		{
			this.stringBuilder_0 = new StringBuilder();
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000AE064 File Offset: 0x000AC264
		public void method_0(string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.Append(string_0);
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00008260 File Offset: 0x00006460
		public void method_1<T>(T gparam_0)
		{
			if (gparam_0 != null)
			{
				this.stringBuilder_0.Append(gparam_0);
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x0000827C File Offset: 0x0000647C
		public void method_2<T>(T gparam_0, string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.AppendFormat(string_0, gparam_0);
				return;
			}
			this.stringBuilder_0.Append(gparam_0);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00008260 File Offset: 0x00006460
		public void HeetfLvYhO<T>(T gparam_0, int int_0)
		{
			if (gparam_0 != null)
			{
				this.stringBuilder_0.Append(gparam_0);
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000082A7 File Offset: 0x000064A7
		public void method_3<T>(T gparam_0, int int_0, string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.AppendFormat(string_0, gparam_0);
				return;
			}
			this.stringBuilder_0.Append(gparam_0);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000AE064 File Offset: 0x000AC264
		public void method_4(string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.Append(string_0);
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000AE084 File Offset: 0x000AC284
		public void method_5(string string_0, int int_0 = 0, string string_1 = null)
		{
			if (string_1 != null)
			{
				this.stringBuilder_0.AppendFormat(string_1, string_0);
				return;
			}
			this.stringBuilder_0.Append(string_0);
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000AE0B0 File Offset: 0x000AC2B0
		public void method_6(object object_0, int int_0 = 0, string string_0 = null)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.AppendFormat(string_0, object_0);
				return;
			}
			this.stringBuilder_0.Append(object_0);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000082D2 File Offset: 0x000064D2
		public string method_7()
		{
			string text = this.stringBuilder_0.ToString();
			this.stringBuilder_0.Clear();
			return text;
		}

		// Token: 0x0400096F RID: 2415
		private StringBuilder stringBuilder_0;
	}

	// Token: 0x02000212 RID: 530
	internal enum Enum8
	{

	}

	// Token: 0x02000213 RID: 531
	[CompilerGenerated]
	[Serializable]
	private sealed class Class53<T>
	{
		// Token: 0x0600180F RID: 6159 RVA: 0x00008102 File Offset: 0x00006302
		internal int method_0(Class24.Class28 x, Class24.Class28 y)
		{
			return x.class29_0.int_0.CompareTo(y.class29_0.int_0);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000082EB File Offset: 0x000064EB
		internal static bool smethod_0()
		{
			return Class24.Class53<T>.object_0 == null;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000082F5 File Offset: 0x000064F5
		internal static object smethod_1()
		{
			return Class24.Class53<T>.object_0;
		}

		// Token: 0x04000972 RID: 2418
		public static readonly Class24.Class53<T> <>9 = new Class24.Class53<T>();

		// Token: 0x04000973 RID: 2419
		public static Comparison<Class24.Class28> <>9__50_0;

		// Token: 0x04000974 RID: 2420
		private static object object_0;
	}
}
