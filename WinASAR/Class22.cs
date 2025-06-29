using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;

// Token: 0x020001E3 RID: 483
internal class Class22
{
	// Token: 0x060014DF RID: 5343 RVA: 0x0009EF74 File Offset: 0x0009D174
	private static void smethod_0()
	{
		if (!Class22.bool_0)
		{
			Class15.Class18 @class = new Class15.Class18(typeof(Class15).Assembly.GetManifestResourceStream(Class15.smethod_17(486462240 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c)));
			@class.method_0().Position = 0L;
			byte[] array = new byte[0];
			byte[] array2 = @class.method_1((int)@class.method_0().Length);
			byte[] array3 = new byte[32];
			array3[0] = 13;
			array3[0] = 106;
			array3[0] = 139;
			array3[0] = 96;
			array3[0] = 39;
			array3[0] = 109;
			array3[1] = 108;
			array3[1] = 124;
			array3[1] = 162;
			array3[1] = 88;
			array3[2] = 165;
			array3[2] = 162;
			array3[2] = 112;
			array3[2] = 116;
			array3[2] = 105;
			array3[2] = 214;
			array3[3] = 65;
			array3[3] = 112;
			array3[3] = 172;
			array3[4] = 142;
			array3[4] = 121;
			array3[4] = 170;
			array3[4] = 69;
			array3[4] = 50;
			array3[5] = 117;
			array3[5] = 109;
			array3[5] = 36;
			array3[6] = 95;
			array3[6] = 113;
			array3[6] = 128;
			array3[6] = 139;
			array3[6] = 212;
			array3[7] = 155;
			array3[7] = 152;
			array3[7] = 123;
			array3[7] = 113;
			array3[7] = 130;
			array3[7] = 3;
			array3[8] = 90;
			array3[8] = 118;
			array3[8] = 95;
			array3[8] = 169;
			array3[8] = 105;
			array3[9] = 14;
			array3[9] = 97;
			array3[9] = 190;
			array3[9] = 100;
			array3[10] = 105;
			array3[10] = 151;
			array3[10] = 141;
			array3[10] = 144;
			array3[10] = 90;
			array3[10] = 223;
			array3[11] = 125;
			array3[11] = 88;
			array3[11] = 104;
			array3[11] = 3;
			array3[12] = 171;
			array3[12] = 125;
			array3[12] = 55;
			array3[12] = 166;
			array3[12] = 99;
			array3[12] = 86;
			array3[13] = 163;
			array3[13] = 93;
			array3[13] = 91;
			array3[13] = 176;
			array3[14] = 149;
			array3[14] = 45;
			array3[14] = 91;
			array3[14] = 98;
			array3[14] = 77;
			array3[14] = 5;
			array3[15] = 218;
			array3[15] = 127;
			array3[15] = 224;
			array3[16] = 142;
			array3[16] = 207;
			array3[16] = 146;
			array3[16] = 64;
			array3[16] = 97;
			array3[16] = 208;
			array3[17] = 162;
			array3[17] = 162;
			array3[17] = 94;
			array3[17] = 68;
			array3[17] = 96;
			array3[17] = 75;
			array3[18] = 106;
			array3[18] = 122;
			array3[18] = 87;
			array3[18] = 132;
			array3[18] = 100;
			array3[18] = 20;
			array3[19] = 102;
			array3[19] = 200;
			array3[19] = 241;
			array3[20] = 136;
			array3[20] = 209;
			array3[20] = 139;
			array3[20] = 14;
			array3[20] = 124;
			array3[20] = 18;
			array3[21] = 128;
			array3[21] = 127;
			array3[21] = 104;
			array3[21] = 143;
			array3[22] = 168;
			array3[22] = 168;
			array3[22] = 79;
			array3[23] = 100;
			array3[23] = 88;
			array3[23] = 107;
			array3[23] = 173;
			array3[23] = 236;
			array3[24] = 156;
			array3[24] = 128;
			array3[24] = 76;
			array3[25] = 86;
			array3[25] = 88;
			array3[25] = 55;
			array3[25] = 223;
			array3[26] = 182;
			array3[26] = 132;
			array3[26] = 155;
			array3[27] = 94;
			array3[27] = 127;
			array3[27] = 133;
			array3[27] = 33;
			array3[28] = 118;
			array3[28] = 135;
			array3[28] = 162;
			array3[28] = 152;
			array3[28] = 241;
			array3[29] = 119;
			array3[29] = 185;
			array3[29] = 157;
			array3[29] = 47;
			array3[30] = 139;
			array3[30] = 165;
			array3[30] = 245;
			array3[31] = 243;
			array3[31] = 109;
			array3[31] = 39;
			array3[31] = 93;
			array3[31] = 92;
			array3[31] = 25;
			byte[] array4 = array3;
			byte[] array5 = new byte[16];
			array5[0] = 181;
			array5[0] = 139;
			array5[0] = 97;
			array5[1] = 97;
			array5[1] = 168;
			array5[1] = 227;
			array5[2] = 93;
			array5[2] = 160;
			array5[2] = 195;
			array5[3] = 114;
			array5[3] = 138;
			array5[3] = 154;
			array5[3] = 220;
			array5[4] = 170;
			array5[4] = 193;
			array5[4] = 96;
			array5[5] = 140;
			array5[5] = 55;
			array5[5] = 116;
			array5[6] = 95;
			array5[6] = 86;
			array5[6] = 7;
			array5[7] = 137;
			array5[7] = 128;
			array5[7] = 142;
			array5[7] = 61;
			array5[7] = 162;
			array5[7] = 42;
			array5[8] = 111;
			array5[8] = 141;
			array5[8] = 212;
			array5[8] = 79;
			array5[8] = 91;
			array5[8] = 94;
			array5[9] = 124;
			array5[9] = 102;
			array5[9] = 86;
			array5[9] = 26;
			array5[10] = 33;
			array5[10] = 160;
			array5[10] = 60;
			array5[10] = 132;
			array5[10] = 158;
			array5[11] = 127;
			array5[11] = 134;
			array5[11] = 158;
			array5[11] = 159;
			array5[11] = 123;
			array5[11] = 228;
			array5[12] = 160;
			array5[12] = 94;
			array5[12] = 125;
			array5[13] = 60;
			array5[13] = 15;
			array5[13] = 145;
			array5[13] = 113;
			array5[13] = 128;
			array5[14] = 46;
			array5[14] = 174;
			array5[14] = 14;
			array5[15] = 149;
			array5[15] = 173;
			array5[15] = 153;
			array5[15] = 186;
			byte[] array6 = array5;
			int num = 1;
			for (int i = 0; i < array6.Length; i++)
			{
				array4[i] ^= array6[i];
			}
			byte[] array7 = array2;
			int num2 = array7.Length % 4;
			int num3 = array7.Length / 4;
			byte[] array8 = new byte[array7.Length];
			int num4 = array4.Length / 4;
			uint num5 = 0U;
			if (num2 > 0)
			{
				num3++;
			}
			for (int j = 0; j < num3; j++)
			{
				int num6 = j % num4;
				int num7 = j * 4;
				uint num8 = (uint)(num6 * 4);
				uint num9 = (uint)(((int)array4[(int)(num8 + 3U)] << 24) | ((int)array4[(int)(num8 + 2U)] << 16) | ((int)array4[(int)(num8 + 1U)] << 8) | (int)array4[(int)num8]);
				uint num10 = 255U;
				int num11 = 0;
				uint num12;
				if (j == num3 - 1 && num2 > 0)
				{
					num12 = 0U;
					num5 += num9;
					for (int k = 0; k < num2; k++)
					{
						if (k > 0)
						{
							num12 <<= 8;
						}
						num12 |= (uint)array7[array7.Length - (1 + k)];
					}
				}
				else
				{
					num8 = (uint)num7;
					num5 += num9;
					num12 = (uint)(((int)array7[(int)(num8 + 3U)] << 24) | ((int)array7[(int)(num8 + 2U)] << 16) | ((int)array7[(int)(num8 + 1U)] << 8) | (int)array7[(int)num8]);
				}
				uint num14;
				uint num13 = (num14 = num5);
				num14 = 33286278U * (num14 & 127U) + (num14 >> 7);
				num14 ^= num14 << 21;
				num14 += num14;
				num14 ^= num14 >> 5;
				num14 += 107820208U;
				num14 ^= num14 << 2;
				num14 += 3427350551U;
				num14 = (((num14 << 6) - 1958373253U) ^ num14) - num14;
				num5 = num13 + (uint)num14;
				if (j == num3 - 1 && num2 > 0)
				{
					uint num15 = num5 ^ num12;
					for (int l = 0; l < num2; l++)
					{
						if (l > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array8[num7 + l] = (byte)((num15 & num10) >> num11);
					}
				}
				else
				{
					uint num16 = num5 ^ num12;
					array8[num7] = (byte)(num16 & 255U);
					array8[num7 + 1] = (byte)((num16 & 65280U) >> 8);
					array8[num7 + 2] = (byte)((num16 & 16711680U) >> 16);
					array8[num7 + 3] = (byte)((num16 & 4278190080U) >> 24);
				}
			}
			array = array8;
			if (num != 0)
			{
				if (num != 1)
				{
					Class22.object_0 = Class22.Class23.smethod_7(Class22.Class23.smethod_8(array, 0U));
				}
				else
				{
					MemoryStream memoryStream = new MemoryStream();
					using (DeflateStream deflateStream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress))
					{
						deflateStream.CopyTo(memoryStream);
					}
					Class22.object_0 = Class22.Class23.smethod_7(memoryStream.ToArray());
					memoryStream.Dispose();
				}
			}
			else
			{
				Class22.object_0 = Class22.Class23.smethod_7(array);
			}
			Class22.string_0 = ((Assembly)Class22.object_0).GetManifestResourceNames();
			Class22.bool_0 = true;
		}
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x0009FE40 File Offset: 0x0009E040
	internal static string[] smethod_1(Assembly assembly_0)
	{
		if (assembly_0 == typeof(Class22).Assembly)
		{
			if (!Class22.bool_0)
			{
				Class22.smethod_0();
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)Class22.object_0).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x0009FEA4 File Offset: 0x0009E0A4
	private static Assembly smethod_2(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		if (!Class22.bool_0)
		{
			Class22.smethod_0();
		}
		string name = resolveEventArgs_0.Name;
		for (int i = 0; i < Class22.string_0.Length; i++)
		{
			if (Class22.string_0[i] == name)
			{
				return (Assembly)Class22.object_0;
			}
		}
		return null;
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x000077D5 File Offset: 0x000059D5
	public Class22()
	{
		AppDomain.CurrentDomain.ResourceResolve += Class22.smethod_2;
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x000077F4 File Offset: 0x000059F4
	internal static void smethod_3()
	{
		if (!Class22.bool_1)
		{
			Class22.bool_1 = true;
			new Class22();
		}
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x00007603 File Offset: 0x00005803
	internal static Type smethod_4(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x0000753E File Offset: 0x0000573E
	internal static object smethod_5(Assembly assembly_0, string string_1)
	{
		return assembly_0.GetManifestResourceStream(string_1);
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x000072AF File Offset: 0x000054AF
	internal static object smethod_6(Class15.Class18 class18_0)
	{
		return class18_0.method_0();
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x000072BA File Offset: 0x000054BA
	internal static void smethod_7(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x000072C9 File Offset: 0x000054C9
	internal static long smethod_8(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x000072D4 File Offset: 0x000054D4
	internal static object smethod_9(Class15.Class18 class18_0, int int_0)
	{
		return class18_0.method_1(int_0);
	}

	// Token: 0x060014EB RID: 5355 RVA: 0x00007828 File Offset: 0x00005A28
	internal static object smethod_10(byte[] byte_0)
	{
		return Class22.Class23.smethod_7(byte_0);
	}

	// Token: 0x060014EC RID: 5356 RVA: 0x00007833 File Offset: 0x00005A33
	internal static void smethod_11(Stream stream_0, Stream stream_1)
	{
		stream_0.CopyTo(stream_1);
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x00007533 File Offset: 0x00005733
	internal static void smethod_12(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x00007597 File Offset: 0x00005797
	internal static object smethod_13(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x00007842 File Offset: 0x00005A42
	internal static void smethod_14(Stream stream_0)
	{
		stream_0.Dispose();
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x0000784D File Offset: 0x00005A4D
	internal static object smethod_15(byte[] byte_0, uint uint_0)
	{
		return Class22.Class23.smethod_8(byte_0, uint_0);
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x0000785C File Offset: 0x00005A5C
	internal static object smethod_16(Assembly assembly_0)
	{
		return assembly_0.GetManifestResourceNames();
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00007391 File Offset: 0x00005591
	internal static bool smethod_17()
	{
		return null == null;
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x00003C0E File Offset: 0x00001E0E
	internal static object smethod_18()
	{
		return null;
	}

	// Token: 0x040008D3 RID: 2259
	private static string[] string_0 = new string[0];

	// Token: 0x040008D4 RID: 2260
	private static object object_0 = null;

	// Token: 0x040008D5 RID: 2261
	private static bool bool_0 = false;

	// Token: 0x040008D6 RID: 2262
	private static bool bool_1 = false;

	// Token: 0x020001E4 RID: 484
	private enum Enum3
	{

	}

	// Token: 0x020001E5 RID: 485
	internal class Class23
	{
		// Token: 0x060014F4 RID: 5364 RVA: 0x0009FEF4 File Offset: 0x0009E0F4
		private unsafe static uint smethod_0(void* pVoid_0, uint uint_0)
		{
			uint num = 0U;
			if (BitConverter.IsLittleEndian)
			{
				num = *(uint*)pVoid_0;
			}
			else
			{
				switch (uint_0)
				{
				case 1U:
					num = (uint)(*(byte*)pVoid_0);
					break;
				case 2U:
					num = (uint)((int)(*(byte*)pVoid_0) | ((int)((byte*)pVoid_0)[1] << 8));
					break;
				case 3U:
					num = (uint)((int)(*(byte*)pVoid_0) | ((int)((byte*)pVoid_0)[1] << 8) | ((int)((byte*)pVoid_0)[2] << 16));
					break;
				case 4U:
					num = (uint)((int)(*(byte*)pVoid_0) | ((int)((byte*)pVoid_0)[1] << 8) | ((int)((byte*)pVoid_0)[2] << 16) | ((int)((byte*)pVoid_0)[3] << 24));
					break;
				}
			}
			return num;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0009FF6C File Offset: 0x0009E16C
		private unsafe static bool smethod_1(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			bool flag = true;
			uint num = 0U;
			while (flag && num < uint_0)
			{
				flag = ((byte*)pVoid_0)[num] == ((byte*)pVoid_1)[num];
				num += 1U;
			}
			return flag;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0009FF98 File Offset: 0x0009E198
		private unsafe static void smethod_2(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				((byte*)pVoid_0)[num] = byte_0;
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0009FFB8 File Offset: 0x0009E1B8
		private unsafe static void smethod_3(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				((byte*)pVoid_0)[num] = ((byte*)pVoid_1)[num];
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0009FFDC File Offset: 0x0009E1DC
		private unsafe static void smethod_4(byte* pByte_0, byte* pByte_1, uint uint_0)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (uint_0 < 5U)
				{
					*(int*)pByte_0 = (int)(*(uint*)pByte_1);
					return;
				}
				byte* ptr = pByte_0 + uint_0;
				while (pByte_0 < ptr)
				{
					*(int*)pByte_0 = (int)(*(uint*)pByte_1);
					pByte_0 += 4;
					pByte_1 += 4;
				}
				return;
			}
			else
			{
				if (uint_0 > 8U && pByte_1 + uint_0 < pByte_0)
				{
					Class22.Class23.smethod_3((void*)pByte_0, (void*)pByte_1, uint_0);
					return;
				}
				byte* ptr2 = pByte_0 + uint_0;
				while (pByte_0 < ptr2)
				{
					*pByte_0 = *pByte_1;
					pByte_0++;
					pByte_1++;
				}
				return;
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000A0040 File Offset: 0x0009E240
		private unsafe static uint smethod_5(object object_0, uint uint_0, Class22.Enum3 enum3_0)
		{
			uint num;
			fixed (byte[] array = object_0)
			{
				byte* ptr;
				if (object_0 != null && array.Length != 0)
				{
					ptr = &array[0];
				}
				else
				{
					ptr = null;
				}
				num = *(uint*)(ptr + uint_0 + (IntPtr)enum3_0 * 4);
			}
			return num;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000A0074 File Offset: 0x0009E274
		private unsafe static uint smethod_6(object object_0, uint uint_0, object object_1)
		{
			byte* ptr;
			if (object_0 != null && object_0.Length != 0)
			{
				ptr = ref object_0[0];
			}
			else
			{
				ptr = null;
			}
			byte* ptr2;
			if (object_1 != null && object_1.Length != 0)
			{
				ptr2 = ref object_1[0];
			}
			else
			{
				ptr2 = null;
			}
			byte* ptr3 = ptr + uint_0;
			uint num = 32U;
			byte* ptr4 = ptr3 + 32;
			byte* ptr5 = ptr2;
			uint* ptr6 = (uint*)ptr3;
			byte* ptr7 = ptr2 + Class22.Class23.smethod_0((void*)(ptr6 + 3), 4U);
			uint num2 = 1U;
			uint[] array = new uint[]
			{
				4U, 0U, 1U, 0U, 2U, 0U, 1U, 0U, 3U, 0U,
				1U, 0U, 2U, 0U, 1U, 0U
			};
			byte* ptr8 = ptr7 - 4;
			if (Class22.Class23.smethod_0((void*)(ptr6 + 4), 4U) != 1U)
			{
				Class22.Class23.smethod_3((void*)ptr2, (void*)(ptr3 + num), Class22.Class23.smethod_0((void*)(ptr6 + 3), 4U));
				return Class22.Class23.smethod_0((void*)(ptr6 + 3), 4U);
			}
			if (ptr5 >= ptr8)
			{
				ptr4 += 4;
				while (ptr5 < ptr7)
				{
					*ptr5 = *ptr4;
					ptr5++;
					ptr4++;
				}
				return (uint)((long)(ptr5 - ptr2));
			}
			for (;;)
			{
				if (num2 == 1U)
				{
					num2 = Class22.Class23.smethod_0((void*)ptr4, 4U);
					ptr4 += 4;
				}
				uint num3 = Class22.Class23.smethod_0((void*)ptr4, 4U);
				if ((num2 & 1U) == 1U)
				{
					num2 >>= 1;
					if ((num3 & 3U) == 0U)
					{
						uint num4 = (num3 & 255U) >> 2;
						Class22.Class23.smethod_4(ptr5, ptr5 - num4, 3U);
						ptr5 += 3;
						ptr4++;
					}
					else if ((num3 & 2U) == 0U)
					{
						uint num4 = (num3 & 65535U) >> 2;
						Class22.Class23.smethod_4(ptr5, ptr5 - num4, 3U);
						ptr5 += 3;
						ptr4 += 2;
					}
					else if ((num3 & 1U) == 0U)
					{
						uint num4 = (num3 & 65535U) >> 6;
						uint num5 = ((num3 >> 2) & 15U) + 3U;
						Class22.Class23.smethod_4(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 2;
					}
					else if ((num3 & 4U) == 0U)
					{
						uint num4 = (num3 & 16777215U) >> 8;
						uint num5 = ((num3 >> 3) & 31U) + 3U;
						Class22.Class23.smethod_4(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 3;
					}
					else if ((num3 & 8U) == 0U)
					{
						uint num4 = num3 >> 15;
						uint num5 = ((num3 >> 4) & 2047U) + 3U;
						Class22.Class23.smethod_4(ptr5, ptr5 - num4, num5);
						ptr5 += num5;
						ptr4 += 4;
					}
					else
					{
						byte b = (byte)(num3 >> 16);
						uint num5 = (num3 >> 4) & 4095U;
						Class22.Class23.smethod_2((void*)ptr5, b, num5);
						ptr5 += num5;
						ptr4 += 3;
					}
				}
				else
				{
					Class22.Class23.smethod_4(ptr5, ptr4, 4U);
					ptr5 += array[(int)(num2 & 15U)];
					ptr4 += array[(int)(num2 & 15U)];
					num2 >>= (int)((byte)array[(int)(num2 & 15U)]);
					if (ptr5 >= ptr8)
					{
						break;
					}
				}
			}
			while (ptr5 < ptr7)
			{
				if (num2 == 1U)
				{
					ptr4 += 4;
					num2 = 2147483648U;
				}
				*ptr5 = *ptr4;
				ptr5++;
				ptr4++;
				num2 >>= 1;
			}
			return (uint)((long)(ptr5 - ptr2));
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000A0364 File Offset: 0x0009E564
		internal static object smethod_7(byte[] byte_0)
		{
			return typeof(Assembly).GetMethod(Class15.smethod_17(2071334536 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808).Trim(), new Type[] { typeof(byte[]) }).Invoke(null, new object[] { byte_0 });
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000A03C0 File Offset: 0x0009E5C0
		public static byte[] smethod_8(byte[] byte_0, uint uint_0)
		{
			uint num = Class22.Class23.smethod_5(byte_0, uint_0, (Class22.Enum3)3);
			byte[] array = null;
			if (num != 0U)
			{
				array = new byte[num];
				Class22.Class23.smethod_6(byte_0, uint_0, array);
			}
			return array;
		}
	}
}
