using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020001D0 RID: 464
internal class Class15
{
	// Token: 0x060013FE RID: 5118 RVA: 0x0009B7DC File Offset: 0x000999DC
	static Class15()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x00002420 File Offset: 0x00000620
	private void method_0()
	{
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x0009B958 File Offset: 0x00099B58
	internal static byte[] smethod_0(byte[] byte_2)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_2.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)byte_2.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)byte_2.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_2.Length; i++)
		{
			array2[i] = byte_2[i];
		}
		byte[] array3 = array2;
		int num4 = byte_2.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)((num3 >> (8 - j) * 8) & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)(((int)array2[(int)(num11 + (num12 + 3U))] << 24) | ((int)array2[(int)(num11 + (num12 + 2U))] << 16) | ((int)array2[(int)(num11 + (num12 + 1U))] << 8) | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class15.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class15.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class15.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class15.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class15.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class15.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class15.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class15.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class15.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class15.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class15.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class15.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class15.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class15.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class15.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class15.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class15.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class15.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class15.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class15.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class15.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class15.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class15.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class15.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class15.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class15.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class15.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class15.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class15.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class15.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class15.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class15.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class15.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class15.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class15.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class15.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class15.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class15.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class15.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class15.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class15.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class15.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class15.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class15.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class15.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class15.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class15.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class15.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class15.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class15.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class15.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class15.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class15.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class15.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class15.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class15.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class15.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class15.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class15.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class15.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class15.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class15.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class15.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class15.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x00007102 File Offset: 0x00005302
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
	{
		uint_1 = uint_2 + Class15.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + object_2[(int)uint_5] + Class15.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x0000712B File Offset: 0x0000532B
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
	{
		uint_1 = uint_2 + Class15.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + object_2[(int)uint_5] + Class15.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x00007154 File Offset: 0x00005354
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
	{
		uint_1 = uint_2 + Class15.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + object_2[(int)uint_5] + Class15.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x0000717A File Offset: 0x0000537A
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
	{
		uint_1 = uint_2 + Class15.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + object_2[(int)uint_5] + Class15.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x000071A1 File Offset: 0x000053A1
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return (uint_1 >> (int)(32 - ushort_0)) | (uint_1 << (int)ushort_0);
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x000071B3 File Offset: 0x000053B3
	internal static bool smethod_6()
	{
		if (!Class15.bool_5)
		{
			Class15.smethod_8();
			Class15.bool_5 = true;
		}
		return Class15.bool_3;
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x000071CC File Offset: 0x000053CC
	internal Class15()
	{
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x0009BFB8 File Offset: 0x0009A1B8
	private void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)(((int)byte_2[(int)(num7 + 3U)] << 24) | ((int)byte_2[(int)(num7 + 2U)] << 16) | ((int)byte_2[(int)(num7 + 1U)] << 8) | (int)byte_2[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)(((int)byte_4[(int)(num7 + 3U)] << 24) | ((int)byte_4[(int)(num7 + 2U)] << 16) | ((int)byte_4[(int)(num7 + 1U)] << 8) | (int)byte_4[(int)num7]);
			}
			uint num13;
			uint num12 = (num13 = num4);
			num13 = 33286278U * (num13 & 127U) + (num13 >> 7);
			num13 ^= num13 << 21;
			num13 += num13;
			num13 ^= num13 >> 5;
			num13 += 107820208U;
			num13 ^= num13 << 2;
			num13 += 3427350551U;
			num13 = (((num13 << 6) - 1958373253U) ^ num13) - num13;
			num4 = num12 + (uint)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num14 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num14 & num9) >> num10);
				}
			}
			else
			{
				uint num15 = num4 ^ num11;
				array[num6] = (byte)(num15 & 255U);
				array[num6 + 1] = (byte)((num15 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
			}
		}
		Class15.byte_1 = array;
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x0009C204 File Offset: 0x0009A404
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Class15.smethod_6())
		{
			symmetricAlgorithm = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				symmetricAlgorithm = new RijndaelManaged();
			}
			catch
			{
				try
				{
					symmetricAlgorithm = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					symmetricAlgorithm = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}
		return symmetricAlgorithm;
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x0009C284 File Offset: 0x0009A484
	internal static void smethod_8()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class15.bool_3 = true;
			return;
		}
		try
		{
			Class15.bool_3 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x000071D4 File Offset: 0x000053D4
	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!Class15.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class15.smethod_0(byte_2);
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x0009C2D0 File Offset: 0x0009A4D0
	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = ((uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1));
			stream_0.Read(byte_2, 0, num);
			Class15.smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x000071EF File Offset: 0x000053EF
	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x0009C30C File Offset: 0x0009A50C
	internal static uint smethod_12(uint uint_1, int int_6, long long_1, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_6; i++)
		{
			binaryReader_0.BaseStream.Position = long_1 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x00002420 File Offset: 0x00000620
	internal static void smethod_13()
	{
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x0009C368 File Offset: 0x0009A568
	public static void smethod_14(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Class15.dictionary_0 == null)
			{
				object obj = Class15.object_0;
				lock (obj)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Class15).Assembly.GetManifestResourceStream("jV76foE4FKJpmdjA3m.PdVpLtkAiAoLv1hs4d"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0U;
						if (num > 0)
						{
							num2++;
						}
						for (int i = 0; i < num2; i++)
						{
							int num4 = i * 4;
							uint num5 = 255U;
							int num6 = 0;
							uint num7;
							if (i == num2 - 1 && num > 0)
							{
								num7 = 0U;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num7 <<= 8;
									}
									num7 |= (uint)array[array.Length - (1 + j)];
								}
							}
							else
							{
								uint num8 = (uint)num4;
								num7 = (uint)(((int)array[(int)(num8 + 3U)] << 24) | ((int)array[(int)(num8 + 2U)] << 16) | ((int)array[(int)(num8 + 1U)] << 8) | (int)array[(int)num8]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							num10 = 33286278U * (num10 & 127U) + (num10 >> 7);
							num10 ^= num10 << 21;
							num10 += num10;
							num10 ^= num10 >> 5;
							num10 += 107820208U;
							num10 ^= num10 << 2;
							num10 += 3427350551U;
							num10 = (((num10 << 6) - 1958373253U) ^ num10) - num10;
							num3 = num9 + (uint)num10;
							if (i == num2 - 1 && num > 0)
							{
								uint num11 = num3 ^ num7;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num5 <<= 8;
										num6 += 8;
									}
									array2[num4 + k] = (byte)((num11 & num5) >> num6);
								}
							}
							else
							{
								uint num12 = num3 ^ num7;
								array2[num4] = (byte)(num12 & 255U);
								array2[num4 + 1] = (byte)((num12 & 65280U) >> 8);
								array2[num4 + 2] = (byte)((num12 & 16711680U) >> 16);
								array2[num4 + 3] = (byte)((num12 & 4278190080U) >> 24);
							}
						}
						array = array2;
						int num13 = array.Length / 8;
						Class15.Class18 @class = new Class15.Class18(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int num14 = @class.method_3();
							int num15 = @class.method_3();
							dictionary.Add(num14, num15);
						}
						@class.method_4();
					}
					Class15.dictionary_0 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num16 = Class15.dictionary_0[metadataToken];
					bool flag2 = (num16 & 1073741824) > 0;
					num16 &= 1073741823;
					MethodInfo methodInfo = (MethodInfo)typeof(Class15).Module.ResolveMethod(num16, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num17 = parameters.Length + 1;
						Type[] array3 = new Type[num17];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = typeof(object);
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						for (int num18 = 0; num18 < num17; num18++)
						{
							switch (num18)
							{
							case 0:
								ilgenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								ilgenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								ilgenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								ilgenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								ilgenerator.Emit(OpCodes.Ldarg_S, num18);
								break;
							}
						}
						ilgenerator.Emit(OpCodes.Tailcall);
						ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00002420 File Offset: 0x00000620
	internal static void smethod_15()
	{
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x0009C8A0 File Offset: 0x0009AAA0
	private static void smethod_16(object object_2, int int_6)
	{
		Class24.smethod_1(74, new object[] { object_2, int_6 }, null);
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x0009C8E0 File Offset: 0x0009AAE0
	internal static string smethod_17(int int_6)
	{
		if (Class15.byte_1.Length == 0)
		{
			Class15.uckeXpnhtP = new List<string>();
			Class15.list_0 = new List<int>();
			Class15.smethod_16(Class15.assembly_0.GetManifestResourceStream("ayHaueWUllyI6Z8uL5.W8NxhISx80J8ZcMCkD"), int_6);
		}
		if (Class15.int_4 < 75)
		{
			MethodBase method = new StackFrame(1).GetMethod();
			if (Class15.assembly_0 != method.DeclaringType.Assembly)
			{
				bool flag = false;
				string name = method.DeclaringType.Assembly.GetName().Name;
				AssemblyName[] referencedAssemblies = Class15.assembly_0.GetReferencedAssemblies();
				int i = 0;
				while (i < referencedAssemblies.Length)
				{
					AssemblyName assemblyName = referencedAssemblies[i];
					if (!(name == assemblyName.Name))
					{
						i++;
					}
					else
					{
						flag = true;
						IL_00AF:
						if (!flag)
						{
							throw new Exception();
						}
						goto IL_00B8;
					}
				}
				goto IL_00AF;
			}
			IL_00B8:
			Class15.int_4++;
		}
		object obj = Class15.object_1;
		lock (obj)
		{
			int num = BitConverter.ToInt32(Class15.byte_1, int_6);
			if (num >= Class15.list_0.Count || Class15.list_0[num] != int_6)
			{
				try
				{
					byte[] array = new byte[num];
					Array.Copy(Class15.byte_1, int_6 + 4, array, 0, num);
					string @string = Encoding.Unicode.GetString(array, 0, array.Length);
					Class15.uckeXpnhtP.Add(@string);
					Class15.list_0.Add(int_6);
					Array.Copy(BitConverter.GetBytes(Class15.uckeXpnhtP.Count - 1), 0, Class15.byte_1, int_6, 4);
					return @string;
				}
				catch
				{
					goto IL_018E;
				}
			}
			return Class15.uckeXpnhtP[num];
		}
		IL_018E:
		return "";
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x0009CAA0 File Offset: 0x0009ACA0
	internal static string smethod_18(string string_1)
	{
		"8qxv8hH4MHsVvKazTn".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x0009CAD0 File Offset: 0x0009ACD0
	internal static uint smethod_19(IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, [MarshalAs(UnmanagedType.U4)] uint uint_1, IntPtr intptr_7, ref uint uint_2)
	{
		IntPtr intPtr = intptr_6;
		if (Class15.bool_2)
		{
			intPtr = intptr_5;
		}
		long num;
		if (IntPtr.Size == 4)
		{
			num = (long)Marshal.ReadInt32(intPtr, IntPtr.Size * 2);
		}
		else
		{
			num = Marshal.ReadInt64(intPtr, IntPtr.Size * 2);
		}
		object obj = Class15.hashtable_0[num];
		if (obj == null)
		{
			return Class15.GedajKrOnO(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
		}
		Class15.Struct6 @struct = (Class15.Struct6)obj;
		IntPtr intPtr2 = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
		Marshal.Copy(@struct.byte_0, 0, intPtr2, @struct.byte_0.Length);
		if (@struct.bool_0)
		{
			intptr_7 = intPtr2;
			uint_2 = (uint)@struct.byte_0.Length;
			Class15.smethod_28(intptr_7, @struct.byte_0.Length, 64, ref Class15.int_3);
			return 0U;
		}
		Marshal.WriteIntPtr(intPtr, IntPtr.Size * 2, intPtr2);
		Marshal.WriteInt32(intPtr, IntPtr.Size * 3, @struct.byte_0.Length);
		uint num2 = 0U;
		if (uint_1 == 216669565U && !Class15.bool_4)
		{
			Class15.bool_4 = true;
		}
		else
		{
			num2 = Class15.GedajKrOnO(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
			Marshal.WriteIntPtr(intPtr, IntPtr.Size * 2, IntPtr.Zero);
		}
		return num2;
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x000071FD File Offset: 0x000053FD
	private static int smethod_20()
	{
		return 5;
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x0009CC08 File Offset: 0x0009AE08
	private static void smethod_21()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x0009CC30 File Offset: 0x0009AE30
	private static Delegate smethod_22(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[] { intptr_4, type_0 });
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x0009CC94 File Offset: 0x0009AE94
	internal unsafe static void smethod_23()
	{
		if (!Class15.hjxenjSxx7)
		{
			Class15.hjxenjSxx7 = true;
			long num = 0L;
			Marshal.ReadIntPtr(new IntPtr((void*)(&num)), 0);
			Marshal.ReadInt32(new IntPtr((void*)(&num)), 0);
			Marshal.ReadInt64(new IntPtr((void*)(&num)), 0);
			Marshal.WriteIntPtr(new IntPtr((void*)(&num)), 0, IntPtr.Zero);
			Marshal.WriteInt32(new IntPtr((void*)(&num)), 0, 0);
			Marshal.WriteInt64(new IntPtr((void*)(&num)), 0, 0L);
			Marshal.Copy(new byte[1], 0, Marshal.AllocCoTaskMem(8), 1);
			Class15.smethod_21();
			if (!(Class15.smethod_25(Process.GetCurrentProcess().MainModule.BaseAddress, "__", 10U) != IntPtr.Zero))
			{
				return;
			}
			if (IntPtr.Size == 4 && Type.GetType("System.Reflection.ReflectionContext", false) != null)
			{
				foreach (object obj in Process.GetCurrentProcess().Modules)
				{
					ProcessModule processModule = (ProcessModule)obj;
					if (processModule.ModuleName.ToLower() == "clrjit.dll")
					{
						Version version = new Version(processModule.FileVersionInfo.ProductMajorPart, processModule.FileVersionInfo.ProductMinorPart, processModule.FileVersionInfo.ProductBuildPart, processModule.FileVersionInfo.ProductPrivatePart);
						Version version2 = new Version(4, 0, 30319, 17020);
						Version version3 = new Version(4, 0, 30319, 17921);
						if (version >= version2 && version < version3)
						{
							Class15.bool_2 = true;
							break;
						}
					}
				}
			}
			Class15.Class18 @class = new Class15.Class18(Class15.assembly_0.GetManifestResourceStream("d8GUIY3iv7vY5ue0CD.JdCgL81tHs1ijBkyJa"));
			@class.method_0().Position = 0L;
			byte[] array = @class.method_1((int)@class.method_0().Length);
			byte[] array2 = new byte[32];
			array2[0] = 182;
			array2[0] = 170;
			array2[0] = 129;
			array2[0] = 139;
			array2[0] = 135;
			array2[0] = 75;
			array2[1] = 128;
			array2[1] = 54;
			array2[1] = 142;
			array2[1] = 230;
			array2[2] = 100;
			array2[2] = 142;
			array2[2] = 110;
			array2[2] = 96;
			array2[2] = 101;
			array2[2] = 96;
			array2[3] = 98;
			array2[3] = 122;
			array2[3] = 238;
			array2[3] = 103;
			array2[4] = 70;
			array2[4] = 136;
			array2[4] = 138;
			array2[4] = 154;
			array2[4] = 201;
			array2[5] = 106;
			array2[5] = 138;
			array2[5] = 19;
			array2[6] = 95;
			array2[6] = 28;
			array2[6] = 121;
			array2[6] = 101;
			array2[6] = 148;
			array2[6] = 118;
			array2[7] = 126;
			array2[7] = 183;
			array2[7] = 140;
			array2[7] = 86;
			array2[7] = 23;
			array2[8] = 137;
			array2[8] = 89;
			array2[8] = 186;
			array2[8] = 129;
			array2[8] = 107;
			array2[9] = 143;
			array2[9] = 155;
			array2[9] = 160;
			array2[9] = 57;
			array2[10] = 106;
			array2[10] = 103;
			array2[10] = 228;
			array2[11] = 158;
			array2[11] = 122;
			array2[11] = 19;
			array2[11] = 165;
			array2[12] = 152;
			array2[12] = 197;
			array2[12] = 165;
			array2[12] = 134;
			array2[12] = 28;
			array2[13] = 148;
			array2[13] = 132;
			array2[13] = 185;
			array2[14] = 122;
			array2[14] = 158;
			array2[14] = 128;
			array2[14] = 56;
			array2[15] = 140;
			array2[15] = 92;
			array2[15] = 141;
			array2[15] = 136;
			array2[16] = 110;
			array2[16] = 151;
			array2[16] = 53;
			array2[16] = 125;
			array2[16] = 122;
			array2[16] = 185;
			array2[17] = 105;
			array2[17] = 137;
			array2[17] = 106;
			array2[17] = 90;
			array2[17] = 142;
			array2[18] = 73;
			array2[18] = 98;
			array2[18] = 129;
			array2[18] = 120;
			array2[18] = 151;
			array2[19] = 150;
			array2[19] = 142;
			array2[19] = 158;
			array2[19] = 90;
			array2[19] = 136;
			array2[19] = 10;
			array2[20] = 156;
			array2[20] = 148;
			array2[20] = 163;
			array2[20] = 174;
			array2[20] = 223;
			array2[21] = 102;
			array2[21] = 107;
			array2[21] = 244;
			array2[22] = 152;
			array2[22] = 153;
			array2[22] = 49;
			array2[22] = 145;
			array2[22] = 75;
			array2[23] = 122;
			array2[23] = 90;
			array2[23] = 87;
			array2[23] = 120;
			array2[23] = 218;
			array2[23] = 20;
			array2[24] = 175;
			array2[24] = 149;
			array2[24] = 156;
			array2[24] = 122;
			array2[24] = 65;
			array2[25] = 86;
			array2[25] = 102;
			array2[25] = 129;
			array2[25] = 160;
			array2[26] = 112;
			array2[26] = 142;
			array2[26] = 93;
			array2[26] = 105;
			array2[26] = 156;
			array2[26] = 206;
			array2[27] = 159;
			array2[27] = 131;
			array2[27] = 120;
			array2[27] = 93;
			array2[27] = 90;
			array2[27] = 145;
			array2[28] = 136;
			array2[28] = 89;
			array2[28] = 87;
			array2[28] = 130;
			array2[28] = 149;
			array2[28] = 112;
			array2[29] = 86;
			array2[29] = 126;
			array2[29] = 55;
			array2[30] = 96;
			array2[30] = 133;
			array2[30] = 37;
			array2[31] = 104;
			array2[31] = 118;
			array2[31] = 239;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 32;
			array4[0] = 124;
			array4[0] = 38;
			array4[0] = 142;
			array4[1] = 154;
			array4[1] = 148;
			array4[1] = 117;
			array4[1] = 187;
			array4[2] = 102;
			array4[2] = 167;
			array4[2] = 241;
			array4[3] = 107;
			array4[3] = 95;
			array4[3] = 152;
			array4[3] = 105;
			array4[4] = 122;
			array4[4] = 106;
			array4[4] = 99;
			array4[4] = 131;
			array4[4] = 145;
			array4[4] = 80;
			array4[5] = 128;
			array4[5] = 175;
			array4[5] = 30;
			array4[6] = 109;
			array4[6] = 159;
			array4[6] = 126;
			array4[6] = 76;
			array4[7] = 200;
			array4[7] = 64;
			array4[7] = 78;
			array4[8] = 195;
			array4[8] = 126;
			array4[8] = 176;
			array4[9] = 156;
			array4[9] = 123;
			array4[9] = 208;
			array4[10] = 121;
			array4[10] = 87;
			array4[10] = 104;
			array4[10] = 99;
			array4[10] = 198;
			array4[10] = 151;
			array4[11] = 88;
			array4[11] = 14;
			array4[11] = 100;
			array4[11] = 171;
			array4[11] = 91;
			array4[11] = 224;
			array4[12] = 122;
			array4[12] = 152;
			array4[12] = 84;
			array4[12] = 145;
			array4[12] = 65;
			array4[13] = 132;
			array4[13] = 98;
			array4[13] = 116;
			array4[13] = 196;
			array4[13] = 124;
			array4[13] = 219;
			array4[14] = 109;
			array4[14] = 96;
			array4[14] = 126;
			array4[15] = 113;
			array4[15] = 118;
			array4[15] = 77;
			byte[] array5 = array4;
			Array.Reverse(array5);
			byte[] publicKeyToken = Class15.assembly_0.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
				Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
			}
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			byte[] array6 = array;
			int num2 = array6.Length % 4;
			int num3 = array6.Length / 4;
			byte[] array7 = new byte[array6.Length];
			int num4 = array3.Length / 4;
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
				uint num9 = (uint)(((int)array3[(int)(num8 + 3U)] << 24) | ((int)array3[(int)(num8 + 2U)] << 16) | ((int)array3[(int)(num8 + 1U)] << 8) | (int)array3[(int)num8]);
				uint num10 = 255U;
				int num11 = 0;
				uint num12;
				if (j == num3 - 1 && num2 > 0)
				{
					num5 += num9;
					num12 = 0U;
					for (int k = 0; k < num2; k++)
					{
						if (k > 0)
						{
							num12 <<= 8;
						}
						num12 |= (uint)array6[array6.Length - (1 + k)];
					}
				}
				else
				{
					num8 = (uint)num7;
					num5 += num9;
					num12 = (uint)(((int)array6[(int)(num8 + 3U)] << 24) | ((int)array6[(int)(num8 + 2U)] << 16) | ((int)array6[(int)(num8 + 1U)] << 8) | (int)array6[(int)num8]);
				}
				num5 = num5;
				uint num13 = num5;
				uint num14 = num5;
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
						array7[num7 + l] = (byte)((num15 & num10) >> num11);
					}
				}
				else
				{
					uint num16 = num5 ^ num12;
					array7[num7] = (byte)(num16 & 255U);
					array7[num7 + 1] = (byte)((num16 & 65280U) >> 8);
					array7[num7 + 2] = (byte)((num16 & 16711680U) >> 16);
					array7[num7 + 3] = (byte)((num16 & 4278190080U) >> 24);
				}
			}
			byte[] array8 = array7;
			int num17 = array8.Length / 8;
			byte[] array9;
			byte* ptr;
			if ((array9 = array8) != null && array9.Length != 0)
			{
				ptr = &array9[0];
			}
			else
			{
				ptr = null;
			}
			for (int m = 0; m < num17; m++)
			{
				*(long*)(ptr + m * 8) ^= 1211810601L;
			}
			array9 = null;
			@class = new Class15.Class18(new MemoryStream(array8));
			@class.method_0().Position = 0L;
			long num18 = Marshal.GetHINSTANCE(Class15.assembly_0.GetModules()[0]).ToInt64();
			int num19 = 0;
			int num20 = 0;
			if (Class15.assembly_0.Location == null || Class15.assembly_0.Location.Length == 0)
			{
				num20 = 7680;
			}
			@class.method_3();
			@class.method_3();
			@class.method_3();
			@class.method_3();
			int num21 = @class.method_3();
			int num22 = @class.method_3();
			if (num22 == 4)
			{
				SymmetricAlgorithm symmetricAlgorithm = Class15.smethod_7();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				Array.Clear(array3, 0, array3.Length);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				array8 = memoryStream.ToArray();
				Array.Clear(array5, 0, array5.Length);
				memoryStream.Close();
				cryptoStream.Close();
				@class.method_4();
				num21 = @class.method_3();
				num22 = @class.method_3();
			}
			if (num22 == 1)
			{
				IntPtr intPtr = IntPtr.Zero;
				intPtr = Class15.smethod_29(56U, 1, (uint)Process.GetCurrentProcess().Id);
				if (IntPtr.Size == 4)
				{
					Class15.int_2 = Marshal.GetHINSTANCE(Class15.assembly_0.GetModules()[0]).ToInt32();
				}
				Class15.tIuesQsxop = Marshal.GetHINSTANCE(Class15.assembly_0.GetModules()[0]).ToInt64();
				IntPtr zero = IntPtr.Zero;
				for (int n = 0; n < num21; n++)
				{
					IntPtr intPtr2 = new IntPtr(Class15.tIuesQsxop + (long)@class.method_3() - (long)num20);
					if (Class15.smethod_28(intPtr2, 4, 4, ref num19) == 0)
					{
						Class15.smethod_28(intPtr2, 4, 8, ref num19);
					}
					if (IntPtr.Size == 4)
					{
						Class15.smethod_27(intPtr, intPtr2, BitConverter.GetBytes(@class.method_3()), 4U, out zero);
					}
					else
					{
						Class15.smethod_27(intPtr, intPtr2, BitConverter.GetBytes(@class.method_3()), 4U, out zero);
					}
					Class15.smethod_28(intPtr2, 4, num19, ref num19);
				}
				while (@class.method_0().Position < @class.method_0().Length - 1L)
				{
					int num23 = @class.method_3();
					IntPtr intPtr3 = new IntPtr(Class15.tIuesQsxop + (long)num23 - (long)num20);
					int num24 = @class.method_3();
					if (Class15.smethod_28(intPtr3, num24 * 4, 4, ref num19) == 0)
					{
						Class15.smethod_28(intPtr3, num24 * 4, 8, ref num19);
					}
					for (int num25 = 0; num25 < num24; num25++)
					{
						Marshal.WriteInt32(new IntPtr(intPtr3.ToInt64() + (long)(num25 * 4)), @class.method_3());
					}
					Class15.smethod_28(intPtr3, num24 * 4, num19, ref num19);
				}
				Class15.smethod_30(intPtr);
				return;
			}
			for (int num26 = 0; num26 < num21; num26++)
			{
				IntPtr intPtr4 = new IntPtr(num18 + (long)@class.method_3() - (long)num20);
				if (Class15.smethod_28(intPtr4, 4, 4, ref num19) == 0)
				{
					Class15.smethod_28(intPtr4, 4, 8, ref num19);
				}
				Marshal.WriteInt32(intPtr4, @class.method_3());
				Class15.smethod_28(intPtr4, 4, num19, ref num19);
			}
			Class15.hashtable_0 = new Hashtable(@class.method_3() + 1);
			Class15.Struct6 @struct = default(Class15.Struct6);
			@struct.byte_0 = new byte[] { 42 };
			@struct.bool_0 = false;
			Class15.hashtable_0.Add(0L, @struct);
			while (@class.method_0().Position < @class.method_0().Length - 1L)
			{
				int num27 = @class.method_3() - num20;
				int num28 = @class.method_3();
				bool flag = false;
				if (num28 >= 1879048192)
				{
					flag = true;
				}
				int num29 = @class.method_3();
				byte[] array10 = @class.method_1(num29);
				Class15.Struct6 struct2 = default(Class15.Struct6);
				struct2.byte_0 = array10;
				struct2.bool_0 = flag;
				Class15.hashtable_0.Add(num18 + (long)num27, struct2);
			}
			Class15.long_0 = Marshal.GetHINSTANCE(typeof(Class15).Assembly.GetModules()[0]).ToInt64();
			if (IntPtr.Size == 4)
			{
				Class15.int_1 = Convert.ToInt32(Class15.long_0);
			}
			byte[] array11 = new byte[]
			{
				109, 115, 99, 111, 114, 106, 105, 116, 46, 100,
				108, 108
			};
			string text = Encoding.UTF8.GetString(array11);
			IntPtr intPtr5 = IntPtr.Zero;
			if (intPtr5 == IntPtr.Zero)
			{
				array11 = new byte[] { 99, 108, 114, 106, 105, 116, 46, 100, 108, 108 };
				text = Encoding.UTF8.GetString(array11);
				intPtr5 = Class15.LoadLibrary(text);
			}
			byte[] array12 = new byte[] { 103, 101, 116, 74, 105, 116 };
			string @string = Encoding.UTF8.GetString(array12);
			IntPtr intPtr6 = ((Class15.Delegate4)Class15.smethod_22(Class15.GetProcAddress(intPtr5, @string), typeof(Class15.Delegate4)))();
			long num30 = 0L;
			if (IntPtr.Size == 4)
			{
				num30 = (long)Marshal.ReadInt32(intPtr6);
			}
			else
			{
				num30 = Marshal.ReadInt64(intPtr6);
			}
			Marshal.ReadIntPtr(intPtr6, 0);
			Class15.delegate3_0 = new Class15.Delegate3(Class15.smethod_19);
			IntPtr intPtr7 = IntPtr.Zero;
			intPtr7 = Marshal.GetFunctionPointerForDelegate(Class15.delegate3_0);
			long num31 = 0L;
			if (IntPtr.Size == 4)
			{
				num31 = (long)Marshal.ReadInt32(new IntPtr(num30));
			}
			else
			{
				num31 = Marshal.ReadInt64(new IntPtr(num30));
			}
			Process currentProcess = Process.GetCurrentProcess();
			try
			{
				foreach (object obj2 in currentProcess.Modules)
				{
					ProcessModule processModule2 = (ProcessModule)obj2;
					if (processModule2.ModuleName == text && (num31 < processModule2.BaseAddress.ToInt64() || num31 > processModule2.BaseAddress.ToInt64() + (long)processModule2.ModuleMemorySize) && typeof(Class15).Assembly.EntryPoint != null)
					{
						return;
					}
				}
			}
			catch
			{
			}
			try
			{
				using (IEnumerator enumerator = currentProcess.Modules.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((ProcessModule)enumerator.Current).BaseAddress.ToInt64() == Class15.long_0)
						{
							break;
						}
					}
				}
			}
			catch
			{
			}
			Class15.GedajKrOnO = null;
			try
			{
				Class15.GedajKrOnO = (Class15.Delegate3)Class15.smethod_22(new IntPtr(num31), typeof(Class15.Delegate3));
			}
			catch
			{
				try
				{
					Delegate @delegate = Class15.smethod_22(new IntPtr(num31), typeof(Class15.Delegate3));
					Class15.GedajKrOnO = (Class15.Delegate3)Delegate.CreateDelegate(typeof(Class15.Delegate3), @delegate.Method);
				}
				catch
				{
				}
			}
			int num32 = 0;
			if (typeof(Class15).Assembly.EntryPoint != null && typeof(Class15).Assembly.EntryPoint.GetParameters().Length == 2 && typeof(Class15).Assembly.Location != null && typeof(Class15).Assembly.Location.Length > 0)
			{
				return;
			}
			try
			{
				object value = typeof(Class15).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(typeof(Class15).Assembly.ManifestModule.ModuleHandle);
				if (value is IntPtr)
				{
					Class15.intptr_2 = (IntPtr)value;
				}
				if (value.GetType().ToString() == "System.Reflection.RuntimeModule")
				{
					Class15.intptr_2 = (IntPtr)value.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(value);
				}
				MemoryStream memoryStream2 = new MemoryStream();
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				if (IntPtr.Size == 4)
				{
					memoryStream2.Write(BitConverter.GetBytes(Class15.intptr_2.ToInt32()), 0, 4);
				}
				else
				{
					memoryStream2.Write(BitConverter.GetBytes(Class15.intptr_2.ToInt64()), 0, 8);
				}
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream2.Position = 0L;
				byte[] array13 = memoryStream2.ToArray();
				memoryStream2.Close();
				uint num33 = 0U;
				try
				{
					byte* ptr2;
					if ((array9 = array13) != null && array9.Length != 0)
					{
						ptr2 = &array9[0];
					}
					else
					{
						ptr2 = null;
					}
					Class15.delegate3_0(new IntPtr((void*)ptr2), new IntPtr((void*)ptr2), new IntPtr((void*)ptr2), 216669565U, new IntPtr((void*)ptr2), ref num33);
				}
				finally
				{
					array9 = null;
				}
			}
			catch
			{
			}
			RuntimeHelpers.PrepareDelegate(Class15.GedajKrOnO);
			RuntimeHelpers.PrepareMethod(Class15.GedajKrOnO.Method.MethodHandle);
			RuntimeHelpers.PrepareDelegate(Class15.delegate3_0);
			RuntimeHelpers.PrepareMethod(Class15.delegate3_0.Method.MethodHandle);
			byte[] array14;
			if (IntPtr.Size != 4)
			{
				array14 = new byte[]
				{
					72, 184, 0, 0, 0, 0, 0, 0, 0, 0,
					73, 57, 64, 8, 116, 12, 72, 184, 0, 0,
					0, 0, 0, 0, 0, 0, byte.MaxValue, 224, 72, 184,
					0, 0, 0, 0, 0, 0, 0, 0, byte.MaxValue, 224
				};
			}
			else
			{
				array14 = new byte[]
				{
					85, 139, 236, 139, 69, 16, 129, 120, 4, 125,
					29, 234, 12, 116, 7, 184, 182, 177, 74, 6,
					235, 5, 184, 182, 146, 64, 12, 93, byte.MaxValue, 224
				};
			}
			IntPtr intPtr8 = Class15.smethod_26(IntPtr.Zero, (uint)array14.Length, 4096U, 64U);
			byte[] array15 = array14;
			byte[] array16;
			byte[] array17;
			byte[] array18;
			if (IntPtr.Size == 4)
			{
				array16 = BitConverter.GetBytes(Class15.intptr_2.ToInt32());
				array17 = BitConverter.GetBytes(intPtr7.ToInt32());
				array18 = BitConverter.GetBytes(Convert.ToInt32(num31));
			}
			else
			{
				array16 = BitConverter.GetBytes(Class15.intptr_2.ToInt64());
				array17 = BitConverter.GetBytes(intPtr7.ToInt64());
				array18 = BitConverter.GetBytes(num31);
			}
			if (IntPtr.Size == 4)
			{
				array15[9] = array16[0];
				array15[10] = array16[1];
				array15[11] = array16[2];
				array15[12] = array16[3];
				array15[16] = array18[0];
				array15[17] = array18[1];
				array15[18] = array18[2];
				array15[19] = array18[3];
				array15[23] = array17[0];
				array15[24] = array17[1];
				array15[25] = array17[2];
				array15[26] = array17[3];
			}
			else
			{
				array15[2] = array16[0];
				array15[3] = array16[1];
				array15[4] = array16[2];
				array15[5] = array16[3];
				array15[6] = array16[4];
				array15[7] = array16[5];
				array15[8] = array16[6];
				array15[9] = array16[7];
				array15[18] = array18[0];
				array15[19] = array18[1];
				array15[20] = array18[2];
				array15[21] = array18[3];
				array15[22] = array18[4];
				array15[23] = array18[5];
				array15[24] = array18[6];
				array15[25] = array18[7];
				array15[30] = array17[0];
				array15[31] = array17[1];
				array15[32] = array17[2];
				array15[33] = array17[3];
				array15[34] = array17[4];
				array15[35] = array17[5];
				array15[36] = array17[6];
				array15[37] = array17[7];
			}
			Marshal.Copy(array15, 0, intPtr8, array15.Length);
			Class15.bool_1 = false;
			Class15.smethod_28(new IntPtr(num30), IntPtr.Size, 64, ref num32);
			Marshal.WriteIntPtr(new IntPtr(num30), intPtr8);
			Class15.smethod_28(new IntPtr(num30), IntPtr.Size, num32, ref num32);
		}
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x0009EA60 File Offset: 0x0009CC60
	internal static object smethod_24(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_1).Location))
			{
				return ((Assembly)assembly_1).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
				.ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x0600141B RID: 5147
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x0600141C RID: 5148
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x0600141D RID: 5149 RVA: 0x0009EB70 File Offset: 0x0009CD70
	private static IntPtr smethod_25(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class15.delegate5_0 == null)
		{
			Class15.delegate5_0 = (Class15.Delegate5)Marshal.GetDelegateForFunctionPointer(Class15.GetProcAddress(Class15.smethod_31(), "Find ".Trim() + "ResourceA"), typeof(Class15.Delegate5));
		}
		return Class15.delegate5_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x0009EBCC File Offset: 0x0009CDCC
	private static IntPtr smethod_26(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class15.QmVeOwfTjM == null)
		{
			Class15.QmVeOwfTjM = (Class15.Delegate6)Marshal.GetDelegateForFunctionPointer(Class15.GetProcAddress(Class15.smethod_31(), "Virtual ".Trim() + "Alloc"), typeof(Class15.Delegate6));
		}
		return Class15.QmVeOwfTjM(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x0009EC28 File Offset: 0x0009CE28
	private static int smethod_27(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (Class15.delegate7_0 == null)
		{
			Class15.delegate7_0 = (Class15.Delegate7)Marshal.GetDelegateForFunctionPointer(Class15.GetProcAddress(Class15.smethod_31(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class15.Delegate7));
		}
		return Class15.delegate7_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x0009EC90 File Offset: 0x0009CE90
	private static int smethod_28(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (Class15.delegate8_0 == null)
		{
			Class15.delegate8_0 = (Class15.Delegate8)Marshal.GetDelegateForFunctionPointer(Class15.GetProcAddress(Class15.smethod_31(), "Virtual ".Trim() + "Protect"), typeof(Class15.Delegate8));
		}
		return Class15.delegate8_0(intptr_4, int_6, int_7, ref int_8);
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x0009ECEC File Offset: 0x0009CEEC
	private static IntPtr smethod_29(uint uint_1, int int_6, uint uint_2)
	{
		if (Class15.delegate9_0 == null)
		{
			Class15.delegate9_0 = (Class15.Delegate9)Marshal.GetDelegateForFunctionPointer(Class15.GetProcAddress(Class15.smethod_31(), "Open ".Trim() + "Process"), typeof(Class15.Delegate9));
		}
		return Class15.delegate9_0(uint_1, int_6, uint_2);
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0009ED48 File Offset: 0x0009CF48
	private static int smethod_30(IntPtr intptr_4)
	{
		if (Class15.delegate10_0 == null)
		{
			Class15.delegate10_0 = (Class15.Delegate10)Marshal.GetDelegateForFunctionPointer(Class15.GetProcAddress(Class15.smethod_31(), "Close ".Trim() + "Handle"), typeof(Class15.Delegate10));
		}
		return Class15.delegate10_0(intptr_4);
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x00007200 File Offset: 0x00005400
	private static IntPtr smethod_31()
	{
		if (Class15.intptr_1 == IntPtr.Zero)
		{
			Class15.intptr_1 = Class15.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class15.intptr_1;
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x0009EDA0 File Offset: 0x0009CFA0
	private static byte[] smethod_32(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x00007236 File Offset: 0x00005436
	internal static byte[] smethod_33(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x0009EE00 File Offset: 0x0009D000
	private static byte[] smethod_34(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class15.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			61, 119, 254, 60, 149, 98, 139, 176, 31, 56,
			20, 249, 153, 234, 212, 249, 30, 98, 237, 151,
			44, 121, 152, 154, 49, 149, 220, 48, 15, 123,
			174, 169
		};
		symmetricAlgorithm.IV = new byte[]
		{
			199, 115, 79, 225, 183, 67, 4, 140, 120, 18,
			103, 88, 100, 19, 201, 174
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class15.smethod_33(stream);
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x0009EE70 File Offset: 0x0009D070
	private byte[] method_2()
	{
		return null;
	}

	// Token: 0x06001429 RID: 5161 RVA: 0x0009EE80 File Offset: 0x0009D080
	private byte[] method_3()
	{
		return null;
	}

	// Token: 0x0600142A RID: 5162 RVA: 0x00007243 File Offset: 0x00005443
	private byte[] method_4()
	{
		int length = "k8cqwEFEBUAK1XwT".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x0600142B RID: 5163 RVA: 0x0000725E File Offset: 0x0000545E
	private byte[] method_5()
	{
		int length = "dkKxqb5kSIFWfQ9194M1Va".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x0600142C RID: 5164 RVA: 0x0009EE70 File Offset: 0x0009D070
	private byte[] method_6()
	{
		return null;
	}

	// Token: 0x0600142D RID: 5165 RVA: 0x0009EE80 File Offset: 0x0009D080
	private byte[] method_7()
	{
		return null;
	}

	// Token: 0x0600142E RID: 5166 RVA: 0x00007279 File Offset: 0x00005479
	internal byte[] method_8()
	{
		int length = "XeI2f6Qc3JXGS1ans6B".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00007294 File Offset: 0x00005494
	internal byte[] method_9()
	{
		int length = "Lug1KAXcBLMxzKQVJ".Length;
		return new byte[] { 1, 2 };
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x0009EE70 File Offset: 0x0009D070
	internal byte[] method_10()
	{
		return null;
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x0009EE70 File Offset: 0x0009D070
	internal byte[] method_11()
	{
		return null;
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x000072AF File Offset: 0x000054AF
	internal static object smethod_35(Class15.Class18 class18_0)
	{
		return class18_0.method_0();
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x000072BA File Offset: 0x000054BA
	internal static void smethod_36(Stream stream_0, long long_1)
	{
		stream_0.Position = long_1;
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x000072C9 File Offset: 0x000054C9
	internal static long smethod_37(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x000072D4 File Offset: 0x000054D4
	internal static object smethod_38(Class15.Class18 class18_0, int int_6)
	{
		return class18_0.method_1(int_6);
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x000072E3 File Offset: 0x000054E3
	internal static void smethod_39(Class15.Class18 class18_0)
	{
		class18_0.method_4();
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x000072EE File Offset: 0x000054EE
	internal static void smethod_40(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x000072F9 File Offset: 0x000054F9
	internal static object smethod_41(Assembly assembly_1)
	{
		return assembly_1.GetName();
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x00007304 File Offset: 0x00005504
	internal static object smethod_42(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x0000730F File Offset: 0x0000550F
	internal static object smethod_43()
	{
		return Class15.smethod_7();
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x00007316 File Offset: 0x00005516
	internal static void smethod_44(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x00007325 File Offset: 0x00005525
	internal static object smethod_45(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x00007338 File Offset: 0x00005538
	internal static object smethod_46()
	{
		return new MemoryStream();
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x0000733F File Offset: 0x0000553F
	internal static void smethod_47(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x0600143F RID: 5183 RVA: 0x00007356 File Offset: 0x00005556
	internal static void smethod_48(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x00007361 File Offset: 0x00005561
	internal static object smethod_49(Stream stream_0)
	{
		return Class15.smethod_33(stream_0);
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x0000736C File Offset: 0x0000556C
	internal static void smethod_50(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x00007377 File Offset: 0x00005577
	internal static object smethod_51(Assembly assembly_1)
	{
		return assembly_1.EntryPoint;
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x00007382 File Offset: 0x00005582
	internal static bool smethod_52(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 == methodInfo_1;
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00007391 File Offset: 0x00005591
	internal static bool smethod_53()
	{
		return null == null;
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00003C0E File Offset: 0x00001E0E
	internal static object smethod_54()
	{
		return null;
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x00002C18 File Offset: 0x00000E18
	static int smethod_55()
	{
		return 1;
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00007397 File Offset: 0x00005597
	internal static IntPtr smethod_56(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadIntPtr(intptr_4, int_6);
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x000073A6 File Offset: 0x000055A6
	internal static int smethod_57(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt32(intptr_4, int_6);
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x000073B5 File Offset: 0x000055B5
	internal static long smethod_58(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt64(intptr_4, int_6);
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x000073C4 File Offset: 0x000055C4
	internal static void smethod_59(IntPtr intptr_4, int int_6, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, int_6, intptr_5);
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x000073D7 File Offset: 0x000055D7
	internal static void smethod_60(IntPtr intptr_4, int int_6, int int_7)
	{
		Marshal.WriteInt32(intptr_4, int_6, int_7);
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x000073EA File Offset: 0x000055EA
	internal static void smethod_61(IntPtr intptr_4, int int_6, long long_1)
	{
		Marshal.WriteInt64(intptr_4, int_6, long_1);
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x000073FD File Offset: 0x000055FD
	internal static IntPtr smethod_62(int int_6)
	{
		return Marshal.AllocCoTaskMem(int_6);
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00007408 File Offset: 0x00005608
	internal static void smethod_63(byte[] byte_2, int int_6, IntPtr intptr_4, int int_7)
	{
		Marshal.Copy(byte_2, int_6, intptr_4, int_7);
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x0000741F File Offset: 0x0000561F
	internal static void smethod_64()
	{
		Class15.smethod_21();
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x00007426 File Offset: 0x00005626
	internal static object smethod_65()
	{
		return Process.GetCurrentProcess();
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x0000742D File Offset: 0x0000562D
	internal static object smethod_66(Process process_0)
	{
		return process_0.MainModule;
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x00007438 File Offset: 0x00005638
	internal static IntPtr smethod_67(ProcessModule processModule_0)
	{
		return processModule_0.BaseAddress;
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x00007443 File Offset: 0x00005643
	internal static IntPtr smethod_68(IntPtr intptr_4, string string_1, uint uint_1)
	{
		return Class15.smethod_25(intptr_4, string_1, uint_1);
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00007456 File Offset: 0x00005656
	internal static bool smethod_69(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 != intptr_5;
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x00007465 File Offset: 0x00005665
	internal static void smethod_70()
	{
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x00007468 File Offset: 0x00005668
	internal static int smethod_71()
	{
		return IntPtr.Size;
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x0000746F File Offset: 0x0000566F
	internal static Type smethod_72(string string_1, bool bool_6)
	{
		return Type.GetType(string_1, bool_6);
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x0000747E File Offset: 0x0000567E
	internal static bool smethod_73(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x0000748D File Offset: 0x0000568D
	internal static object smethod_74(Process process_0)
	{
		return process_0.Modules;
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x00007498 File Offset: 0x00005698
	internal static object smethod_75(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x000074A3 File Offset: 0x000056A3
	internal static object smethod_76(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x000074AE File Offset: 0x000056AE
	internal static object smethod_77(ProcessModule processModule_0)
	{
		return processModule_0.ModuleName;
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x000074B9 File Offset: 0x000056B9
	internal static object smethod_78(string string_1)
	{
		return string_1.ToLower();
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x000074C4 File Offset: 0x000056C4
	internal static bool smethod_79(string string_1, string string_2)
	{
		return string_1 == string_2;
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x000074D3 File Offset: 0x000056D3
	internal static object smethod_80(ProcessModule processModule_0)
	{
		return processModule_0.FileVersionInfo;
	}

	// Token: 0x06001460 RID: 5216 RVA: 0x000074DE File Offset: 0x000056DE
	internal static int smethod_81(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMajorPart;
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x000074E9 File Offset: 0x000056E9
	internal static int smethod_82(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMinorPart;
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x000074F4 File Offset: 0x000056F4
	internal static int smethod_83(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductBuildPart;
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x000074FF File Offset: 0x000056FF
	internal static int smethod_84(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductPrivatePart;
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x0000750A File Offset: 0x0000570A
	internal static bool smethod_85(Version version_0, Version version_1)
	{
		return version_0 >= version_1;
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x00007519 File Offset: 0x00005719
	internal static bool smethod_86(Version version_0, Version version_1)
	{
		return version_0 < version_1;
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00007528 File Offset: 0x00005728
	internal static bool smethod_87(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00007533 File Offset: 0x00005733
	internal static void smethod_88(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x0000753E File Offset: 0x0000573E
	internal static object smethod_89(Assembly assembly_1, string string_1)
	{
		return assembly_1.GetManifestResourceStream(string_1);
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x000072AF File Offset: 0x000054AF
	internal static object smethod_90(Class15.Class18 class18_0)
	{
		return class18_0.method_0();
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x000072BA File Offset: 0x000054BA
	internal static void smethod_91(Stream stream_0, long long_1)
	{
		stream_0.Position = long_1;
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x000072C9 File Offset: 0x000054C9
	internal static long smethod_92(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x000072D4 File Offset: 0x000054D4
	internal static object smethod_93(Class15.Class18 class18_0, int int_6)
	{
		return class18_0.method_1(int_6);
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x000072EE File Offset: 0x000054EE
	internal static void smethod_94(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x000072F9 File Offset: 0x000054F9
	internal static object smethod_95(Assembly assembly_1)
	{
		return assembly_1.GetName();
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x00007304 File Offset: 0x00005504
	internal static object smethod_96(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x06001470 RID: 5232 RVA: 0x0000754D File Offset: 0x0000574D
	internal static void smethod_97(Array array_0, int int_6, int int_7)
	{
		Array.Clear(array_0, int_6, int_7);
	}

	// Token: 0x06001471 RID: 5233 RVA: 0x00007560 File Offset: 0x00005760
	internal static object smethod_98(Assembly assembly_1)
	{
		return assembly_1.GetModules();
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x0000756B File Offset: 0x0000576B
	internal static IntPtr smethod_99(Module module_0)
	{
		return Marshal.GetHINSTANCE(module_0);
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x00007576 File Offset: 0x00005776
	internal static object smethod_100(Assembly assembly_1)
	{
		return assembly_1.Location;
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00007581 File Offset: 0x00005781
	internal static int smethod_101(string string_1)
	{
		return string_1.Length;
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x0000758C File Offset: 0x0000578C
	internal static int smethod_102(Class15.Class18 class18_0)
	{
		return class18_0.method_3();
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x0000730F File Offset: 0x0000550F
	internal static object smethod_103()
	{
		return Class15.smethod_7();
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00007316 File Offset: 0x00005516
	internal static void smethod_104(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00007325 File Offset: 0x00005525
	internal static object smethod_105(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x0000733F File Offset: 0x0000553F
	internal static void smethod_106(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00007356 File Offset: 0x00005556
	internal static void smethod_107(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00007597 File Offset: 0x00005797
	internal static object smethod_108(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x0000736C File Offset: 0x0000556C
	internal static void smethod_109(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x000072E3 File Offset: 0x000054E3
	internal static void smethod_110(Class15.Class18 class18_0)
	{
		class18_0.method_4();
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x000075A2 File Offset: 0x000057A2
	internal static int smethod_111(Process process_0)
	{
		return process_0.Id;
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x000075AD File Offset: 0x000057AD
	internal static IntPtr smethod_112(uint uint_1, int int_6, uint uint_2)
	{
		return Class15.smethod_29(uint_1, int_6, uint_2);
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x000075C0 File Offset: 0x000057C0
	internal static object smethod_113(int int_6)
	{
		return BitConverter.GetBytes(int_6);
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x000075CB File Offset: 0x000057CB
	internal static long smethod_114(Stream stream_0)
	{
		return stream_0.Position;
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x000075D6 File Offset: 0x000057D6
	internal static void smethod_115(IntPtr intptr_4, int int_6)
	{
		Marshal.WriteInt32(intptr_4, int_6);
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x000075E5 File Offset: 0x000057E5
	internal static int smethod_116(IntPtr intptr_4)
	{
		return Class15.smethod_30(intptr_4);
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x000075F0 File Offset: 0x000057F0
	internal static void smethod_117(Hashtable hashtable_1, object object_2, object object_3)
	{
		hashtable_1.Add(object_2, object_3);
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00007603 File Offset: 0x00005803
	internal static Type smethod_118(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x0000760E File Offset: 0x0000580E
	internal static int smethod_119(long long_1)
	{
		return Convert.ToInt32(long_1);
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x00007619 File Offset: 0x00005819
	internal static object smethod_120()
	{
		return Encoding.UTF8;
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00007620 File Offset: 0x00005820
	internal static object smethod_121(Encoding encoding_0, byte[] byte_2)
	{
		return encoding_0.GetString(byte_2);
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x0000762F File Offset: 0x0000582F
	internal static bool smethod_122(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 == intptr_5;
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x0000763E File Offset: 0x0000583E
	internal static object smethod_123(IntPtr intptr_4, Type type_0)
	{
		return Class15.smethod_22(intptr_4, type_0);
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x0000764D File Offset: 0x0000584D
	internal static IntPtr smethod_124(Class15.Delegate4 delegate4_0)
	{
		return delegate4_0();
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00007658 File Offset: 0x00005858
	internal static int smethod_125(IntPtr intptr_4)
	{
		return Marshal.ReadInt32(intptr_4);
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00007663 File Offset: 0x00005863
	internal static long smethod_126(IntPtr intptr_4)
	{
		return Marshal.ReadInt64(intptr_4);
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x0000766E File Offset: 0x0000586E
	internal static IntPtr smethod_127(Delegate delegate_0)
	{
		return Marshal.GetFunctionPointerForDelegate(delegate_0);
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00007679 File Offset: 0x00005879
	internal static int smethod_128(ProcessModule processModule_0)
	{
		return processModule_0.ModuleMemorySize;
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00007377 File Offset: 0x00005577
	internal static object smethod_129(Assembly assembly_1)
	{
		return assembly_1.EntryPoint;
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00007684 File Offset: 0x00005884
	internal static bool smethod_130(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 != methodInfo_1;
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00007693 File Offset: 0x00005893
	internal static object smethod_131(Delegate delegate_0)
	{
		return delegate_0.Method;
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x0000769E File Offset: 0x0000589E
	internal static object smethod_132(Type type_0, MethodInfo methodInfo_0)
	{
		return Delegate.CreateDelegate(type_0, methodInfo_0);
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x000076AD File Offset: 0x000058AD
	internal static object smethod_133(MethodBase methodBase_0)
	{
		return methodBase_0.GetParameters();
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x000076B8 File Offset: 0x000058B8
	internal static object smethod_134(Assembly assembly_1)
	{
		return assembly_1.ManifestModule;
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x000076C3 File Offset: 0x000058C3
	internal static ModuleHandle smethod_135(Module module_0)
	{
		return module_0.ModuleHandle;
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x000076CE File Offset: 0x000058CE
	internal static Type smethod_136(object object_2)
	{
		return object_2.GetType();
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x000076D9 File Offset: 0x000058D9
	internal static object smethod_137(FieldInfo fieldInfo_0, object object_2)
	{
		return fieldInfo_0.GetValue(object_2);
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x000076E8 File Offset: 0x000058E8
	internal static object smethod_138(long long_1)
	{
		return BitConverter.GetBytes(long_1);
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x000076F3 File Offset: 0x000058F3
	internal static void smethod_139(Delegate delegate_0)
	{
		RuntimeHelpers.PrepareDelegate(delegate_0);
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x000076FE File Offset: 0x000058FE
	internal static RuntimeMethodHandle smethod_140(MethodBase methodBase_0)
	{
		return methodBase_0.MethodHandle;
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x00007709 File Offset: 0x00005909
	internal static void smethod_141(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x00007714 File Offset: 0x00005914
	internal static void smethod_142(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x00007723 File Offset: 0x00005923
	internal static IntPtr smethod_143(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		return Class15.smethod_26(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x0000773A File Offset: 0x0000593A
	internal static void smethod_144(IntPtr intptr_4, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, intptr_5);
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x00007391 File Offset: 0x00005591
	internal static bool smethod_145()
	{
		return null == null;
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x00003C0E File Offset: 0x00001E0E
	internal static object smethod_146()
	{
		return null;
	}

	// Token: 0x040008A2 RID: 2210
	private static string[] string_0 = new string[0];

	// Token: 0x040008A3 RID: 2211
	private static int int_0 = 1;

	// Token: 0x040008A4 RID: 2212
	private static int int_1 = 0;

	// Token: 0x040008A5 RID: 2213
	private static Class15.Delegate9 delegate9_0 = null;

	// Token: 0x040008A6 RID: 2214
	internal static Hashtable hashtable_0 = new Hashtable();

	// Token: 0x040008A7 RID: 2215
	private static long long_0 = 0L;

	// Token: 0x040008A8 RID: 2216
	private static Class15.Delegate5 delegate5_0 = null;

	// Token: 0x040008A9 RID: 2217
	private static byte[] byte_0 = new byte[0];

	// Token: 0x040008AA RID: 2218
	private static object object_0 = new object();

	// Token: 0x040008AB RID: 2219
	private static int int_2 = 0;

	// Token: 0x040008AC RID: 2220
	private static List<string> uckeXpnhtP = null;

	// Token: 0x040008AD RID: 2221
	private static int int_3 = 0;

	// Token: 0x040008AE RID: 2222
	private static byte[] byte_1 = new byte[0];

	// Token: 0x040008AF RID: 2223
	private static Dictionary<int, int> dictionary_0 = null;

	// Token: 0x040008B0 RID: 2224
	private static List<int> list_0 = null;

	// Token: 0x040008B1 RID: 2225
	internal static Class15.Delegate3 GedajKrOnO = null;

	// Token: 0x040008B2 RID: 2226
	private static IntPtr intptr_0 = IntPtr.Zero;

	// Token: 0x040008B3 RID: 2227
	private static Class15.Delegate10 delegate10_0 = null;

	// Token: 0x040008B4 RID: 2228
	private static bool bool_0 = false;

	// Token: 0x040008B5 RID: 2229
	private static int int_4 = 0;

	// Token: 0x040008B6 RID: 2230
	private static SortedList LkPeeFjfVy = new SortedList();

	// Token: 0x040008B7 RID: 2231
	private static bool bool_1 = false;

	// Token: 0x040008B8 RID: 2232
	private static object object_1 = new object();

	// Token: 0x040008B9 RID: 2233
	internal static RSACryptoServiceProvider rsacryptoServiceProvider_0 = null;

	// Token: 0x040008BA RID: 2234
	private static Class15.Delegate6 QmVeOwfTjM = null;

	// Token: 0x040008BB RID: 2235
	private static bool bool_2 = false;

	// Token: 0x040008BC RID: 2236
	private static IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x040008BD RID: 2237
	private static Class15.Delegate8 delegate8_0 = null;

	// Token: 0x040008BE RID: 2238
	private static IntPtr intptr_2 = IntPtr.Zero;

	// Token: 0x040008BF RID: 2239
	private static int[] int_5 = new int[0];

	// Token: 0x040008C0 RID: 2240
	internal static Class15.Delegate3 delegate3_0 = null;

	// Token: 0x040008C1 RID: 2241
	private static bool bool_3 = false;

	// Token: 0x040008C2 RID: 2242
	private static uint[] uint_0 = new uint[]
	{
		3614090360U, 3905402710U, 606105819U, 3250441966U, 4118548399U, 1200080426U, 2821735955U, 4249261313U, 1770035416U, 2336552879U,
		4294925233U, 2304563134U, 1804603682U, 4254626195U, 2792965006U, 1236535329U, 4129170786U, 3225465664U, 643717713U, 3921069994U,
		3593408605U, 38016083U, 3634488961U, 3889429448U, 568446438U, 3275163606U, 4107603335U, 1163531501U, 2850285829U, 4243563512U,
		1735328473U, 2368359562U, 4294588738U, 2272392833U, 1839030562U, 4259657740U, 2763975236U, 1272893353U, 4139469664U, 3200236656U,
		681279174U, 3936430074U, 3572445317U, 76029189U, 3654602809U, 3873151461U, 530742520U, 3299628645U, 4096336452U, 1126891415U,
		2878612391U, 4237533241U, 1700485571U, 2399980690U, 4293915773U, 2240044497U, 1873313359U, 4264355552U, 2734768916U, 1309151649U,
		4149444226U, 3174756917U, 718787259U, 3951481745U
	};

	// Token: 0x040008C3 RID: 2243
	private static bool hjxenjSxx7 = false;

	// Token: 0x040008C4 RID: 2244
	[Class15.Attribute0(typeof(Class15.Attribute0.Class16<object>[]))]
	private static bool bool_4 = false;

	// Token: 0x040008C5 RID: 2245
	private static long tIuesQsxop = 0L;

	// Token: 0x040008C6 RID: 2246
	private static IntPtr intptr_3 = IntPtr.Zero;

	// Token: 0x040008C7 RID: 2247
	private static bool bool_5 = false;

	// Token: 0x040008C8 RID: 2248
	private static Class15.Delegate7 delegate7_0 = null;

	// Token: 0x040008C9 RID: 2249
	internal static Assembly assembly_0 = typeof(Class15).Assembly;

	// Token: 0x020001D1 RID: 465
	// (Invoke) Token: 0x060014A3 RID: 5283
	private delegate void Delegate2(object o);

	// Token: 0x020001D2 RID: 466
	internal class Attribute0 : Attribute
	{
		// Token: 0x060014A6 RID: 5286 RVA: 0x00007749 File Offset: 0x00005949
		public Attribute0(object object_0)
		{
		}

		// Token: 0x020001D3 RID: 467
		internal class Class16<T>
		{
			// Token: 0x060014A8 RID: 5288 RVA: 0x00007751 File Offset: 0x00005951
			internal static bool smethod_0()
			{
				return Class15.Attribute0.Class16<T>.object_0 == null;
			}

			// Token: 0x060014A9 RID: 5289 RVA: 0x0000775B File Offset: 0x0000595B
			internal static object smethod_1()
			{
				return Class15.Attribute0.Class16<T>.object_0;
			}

			// Token: 0x040008CA RID: 2250
			private static object object_0;
		}
	}

	// Token: 0x020001D4 RID: 468
	internal class Class17
	{
		// Token: 0x060014AB RID: 5291 RVA: 0x0009EE90 File Offset: 0x0009D090
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = new byte[]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] array2 = Class15.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class15.smethod_7();
			symmetricAlgorithm.Key = array;
			symmetricAlgorithm.IV = array2;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x020001D5 RID: 469
	// (Invoke) Token: 0x060014AE RID: 5294
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate3(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x020001D6 RID: 470
	// (Invoke) Token: 0x060014B2 RID: 5298
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate4();

	// Token: 0x020001D7 RID: 471
	internal struct Struct6
	{
		// Token: 0x040008CB RID: 2251
		internal bool bool_0;

		// Token: 0x040008CC RID: 2252
		internal byte[] byte_0;
	}

	// Token: 0x020001D8 RID: 472
	internal class Class18
	{
		// Token: 0x060014B5 RID: 5301 RVA: 0x00007762 File Offset: 0x00005962
		public Class18(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00007776 File Offset: 0x00005976
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00007783 File Offset: 0x00005983
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00007791 File Offset: 0x00005991
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000077A1 File Offset: 0x000059A1
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000077AE File Offset: 0x000059AE
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x040008CD RID: 2253
		private BinaryReader binaryReader_0;
	}

	// Token: 0x020001D9 RID: 473
	// (Invoke) Token: 0x060014BC RID: 5308
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate5(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x020001DA RID: 474
	// (Invoke) Token: 0x060014C0 RID: 5312
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate6(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x020001DB RID: 475
	// (Invoke) Token: 0x060014C4 RID: 5316
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x020001DC RID: 476
	// (Invoke) Token: 0x060014C8 RID: 5320
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate8(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x020001DD RID: 477
	// (Invoke) Token: 0x060014CC RID: 5324
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate9(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x020001DE RID: 478
	// (Invoke) Token: 0x060014D0 RID: 5328
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate10(IntPtr ptr);

	// Token: 0x020001DF RID: 479
	[Flags]
	private enum Enum2
	{

	}
}
