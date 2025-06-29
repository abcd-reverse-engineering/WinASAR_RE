using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A4 RID: 164
	[Nullable(0)]
	[NullableContext(1)]
	internal class DynamicReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00003F27 File Offset: 0x00002127
		internal static DynamicReflectionDelegateFactory Instance { get; }

		// Token: 0x060006D4 RID: 1748 RVA: 0x00047FE0 File Offset: 0x000461E0
		private static DynamicMethod smethod_0(string string_0, [Nullable(2)] Type returnType, Type[] type_0, Type type_1)
		{
			while (type_1.IsInterface())
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return new DynamicMethod(string_0, returnType, type_0, type_1.Module, true);
			}
			return new DynamicMethod(string_0, returnType, type_0, type_1, true);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00048038 File Offset: 0x00046238
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.smethod_0(method.ToString(), typeof(object), new Type[] { typeof(object[]) }, method.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.method_0(method, ilgenerator, 0);
			return (ObjectConstructor<object>)dynamicMethod.CreateDelegate(typeof(ObjectConstructor<object>));
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00048098 File Offset: 0x00046298
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override MethodCall<T, object> CreateMethodCall<[Nullable(2)] T>(MethodBase method)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.smethod_0(method.ToString(), typeof(object), new Type[]
			{
				typeof(object),
				typeof(object[])
			}, method.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.method_0(method, ilgenerator, 1);
			return (MethodCall<T, object>)dynamicMethod.CreateDelegate(typeof(MethodCall<T, object>));
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00048104 File Offset: 0x00046304
		private void method_0(MethodBase methodBase_0, ILGenerator ilgenerator_0, int int_0)
		{
			for (;;)
			{
				IL_08A8:
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				int num = 61;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
				{
					goto IL_010B;
				}
				Type type;
				Label label;
				MethodInfo method;
				int num2;
				Label label2;
				LocalBuilder localBuilder;
				OpCode opCode2;
				LocalBuilder localBuilder2;
				OpCode opCode3;
				Label label4;
				for (;;)
				{
					IL_0711:
					OpCode opCode;
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_017D;
					case 3:
						goto IL_0113;
					case 4:
						goto IL_0646;
					case 5:
						goto IL_0144;
					case 6:
					case 95:
						if (type.IsValueType())
						{
							goto IL_0558;
						}
						num = 74;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
						{
							goto Block_14;
						}
						continue;
					case 7:
						goto IL_03A3;
					case 8:
						goto IL_060C;
					case 9:
						goto IL_0088;
					case 10:
						goto IL_0349;
					case 11:
						goto IL_04F7;
					case 12:
						goto IL_0187;
					case 13:
					case 21:
					case 52:
						goto IL_03F0;
					case 14:
						goto IL_007B;
					case 15:
						goto IL_001E;
					case 16:
						goto IL_0174;
					case 17:
						goto IL_02F3;
					case 18:
						goto IL_00DA;
					case 19:
					case 73:
						goto IL_02C7;
					case 20:
						goto IL_06FF;
					case 22:
						goto IL_050B;
					case 23:
						goto IL_0501;
					case 24:
						goto IL_037C;
					case 25:
					case 90:
						goto IL_011E;
					case 26:
						opCode = OpCodes.Ldloca;
						goto IL_0425;
					case 27:
						goto IL_014B;
					case 28:
						goto IL_01C5;
					case 29:
						goto IL_0216;
					case 30:
						goto IL_04AB;
					case 31:
						goto IL_0518;
					case 32:
						goto IL_02EB;
					case 33:
						ilgenerator_0.UnboxIfNeeded(type);
						num = 20;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
						{
							goto Block_21;
						}
						continue;
					case 34:
						goto IL_0537;
					case 35:
						goto IL_0252;
					case 36:
						goto IL_0334;
					case 37:
						goto IL_028C;
					case 38:
						goto IL_0154;
					case 39:
						goto IL_0296;
					case 40:
						goto IL_044C;
					case 41:
						goto IL_0558;
					case 42:
						ilgenerator_0.MarkLabel(label);
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
						{
							goto Block_20;
						}
						continue;
					case 43:
					case 54:
						goto IL_02B8;
					case 44:
						goto IL_0230;
					case 45:
						IL_0427:
						if (parameters.Length >= 256)
						{
							goto IL_044C;
						}
						num = 70;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto Block_12;
						}
						continue;
					case 46:
						goto IL_0327;
					case 47:
						method = typeof(IConvertible).GetMethod(Class15.smethod_17(1424564168 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf) + type.Name, new Type[] { typeof(IFormatProvider) });
						goto IL_0631;
					case 48:
					case 93:
						goto IL_010B;
					case 49:
						goto IL_063E;
					case 50:
						goto IL_00CF;
					case 51:
					case 75:
						goto IL_003C;
					case 53:
						goto IL_025D;
					case 55:
						goto IL_05EB;
					case 56:
						goto IL_00C7;
					case 57:
						goto IL_0631;
					case 58:
						goto IL_03CF;
					case 59:
					case 74:
						ilgenerator_0.PushArrayInstance(int_0, num2);
						goto IL_0585;
					case 60:
					case 98:
						goto IL_0006;
					case 61:
						label2 = ilgenerator_0.DefineLabel();
						goto IL_05EB;
					case 62:
						goto IL_08A8;
					case 63:
						goto IL_04C8;
					case 64:
						goto IL_027F;
					case 65:
						ilgenerator_0.Emit(OpCodes.Stloc_S, localBuilder);
						num = 41;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto Block_17;
						}
						continue;
					case 66:
						goto IL_0481;
					case 67:
						goto IL_0522;
					case 68:
						goto IL_04A3;
					case 69:
						goto IL_0193;
					case 70:
						goto IL_05B2;
					case 71:
						goto IL_019C;
					case 72:
						goto IL_01D2;
					case 76:
						goto IL_0034;
					case 77:
						goto IL_01A8;
					case 78:
						goto IL_0453;
					case 79:
						goto IL_01DF;
					case 80:
						goto IL_052F;
					case 81:
						goto IL_0308;
					case 82:
						goto IL_00A7;
					case 83:
						goto IL_0223;
					case 84:
						goto IL_0011;
					case 85:
						goto IL_0341;
					case 86:
						goto IL_0585;
					case 87:
						goto IL_02FB;
					case 88:
						goto IL_04D5;
					case 89:
						goto IL_01F4;
					case 91:
						goto IL_0578;
					case 92:
						goto IL_00E5;
					case 94:
						goto IL_0566;
					case 96:
						if (parameters.Length < 256)
						{
							opCode = OpCodes.Ldloca_S;
							goto IL_0425;
						}
						num = 26;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
						{
							goto Block_10;
						}
						continue;
					case 97:
						goto IL_036C;
					}
					break;
					IL_0425:
					opCode2 = opCode;
					goto IL_0427;
					IL_0481:
					ilgenerator_0.Emit(OpCodes.Stloc_S, localBuilder2);
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
					{
						goto IL_04A3;
					}
					continue;
					IL_0558:
					ilgenerator_0.PushArrayInstance(int_0, num2);
					goto IL_0481;
					IL_04AB:
					label = ilgenerator_0.DefineLabel();
					num = 56;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						goto IL_04C8;
					}
					continue;
					IL_04A3:
					Label label3 = ilgenerator_0.DefineLabel();
					goto IL_04AB;
					IL_04D5:
					ilgenerator_0.Emit(OpCodes.Brtrue_S, label3);
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
					{
						goto IL_04F7;
					}
					continue;
					IL_04C8:
					ilgenerator_0.Emit(OpCodes.Ldloc_S, localBuilder2);
					goto IL_04D5;
					IL_0537:
					if (!type.IsPrimitive())
					{
						goto IL_02B8;
					}
					num = 47;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						goto IL_0558;
					}
					continue;
					IL_052F:
					ilgenerator_0.MarkLabel(label3);
					goto IL_0537;
					IL_0522:
					ilgenerator_0.Emit(OpCodes.Br_S, label);
					goto IL_052F;
					IL_0518:
					LocalBuilder localBuilder3;
					ilgenerator_0.Emit(opCode3, localBuilder3);
					goto IL_0522;
					IL_050B:
					ilgenerator_0.Emit(OpCodes.Initobj, type);
					goto IL_0518;
					IL_0501:
					ilgenerator_0.Emit(opCode2, localBuilder3);
					goto IL_050B;
					IL_04F7:
					localBuilder3 = ilgenerator_0.DeclareLocal(type);
					goto IL_0501;
					IL_0585:
					ilgenerator_0.UnboxIfNeeded(type);
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto Block_16;
					}
					continue;
					IL_05EB:
					ilgenerator_0.Emit(OpCodes.Ldarg, int_0);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						continue;
					}
					IL_060C:
					ilgenerator_0.Emit(OpCodes.Ldlen);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						break;
					}
					continue;
					IL_0646:
					ilgenerator_0.Emit(OpCodes.Ldloc_S, localBuilder2);
					num = 48;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
					{
						goto Block_19;
					}
					continue;
					IL_063E:
					label4 = ilgenerator_0.DefineLabel();
					goto IL_0646;
					IL_0631:
					if (method != null)
					{
						goto IL_063E;
					}
					goto IL_02B8;
				}
				goto IL_0057;
				Block_12:
				goto IL_0187;
				IL_0566:
				ilgenerator_0.Emit(OpCodes.Isinst, type);
				goto IL_01C5;
				Block_19:
				goto IL_0566;
				Block_17:
				goto IL_02C7;
				IL_0578:
				Label label5;
				ilgenerator_0.MarkLabel(label5);
				goto IL_02C7;
				IL_06FF:
				ilgenerator_0.Emit(OpCodes.Stloc_S, localBuilder);
				goto IL_0578;
				Block_10:
				goto IL_02F3;
				Block_21:
				goto IL_001E;
				Block_14:
				goto IL_03CF;
				IL_0453:
				num2 = 0;
				goto IL_010B;
				IL_0451:
				OpCode opCode4;
				opCode3 = opCode4;
				goto IL_0453;
				IL_05B2:
				opCode4 = OpCodes.Ldloc_S;
				goto IL_0451;
				IL_044C:
				opCode4 = OpCodes.Ldloc;
				goto IL_0451;
				Block_16:
				Block_20:
				goto IL_03F0;
				goto IL_0057;
				IL_003C:
				ilgenerator_0.Return();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					goto IL_0057;
				}
				goto IL_0711;
				IL_0034:
				Type type2;
				ilgenerator_0.BoxIfNeeded(type2);
				goto IL_003C;
				IL_001E:
				if (type2 != typeof(void))
				{
					goto IL_0034;
				}
				goto IL_036C;
				IL_001C:
				Type type3;
				type2 = type3;
				goto IL_001E;
				IL_0011:
				type3 = ((MethodInfo)methodBase_0).ReturnType;
				goto IL_001C;
				IL_0006:
				if (!methodBase_0.IsConstructor)
				{
					goto IL_0011;
				}
				type3 = methodBase_0.DeclaringType;
				goto IL_001C;
				IL_03CF:
				ilgenerator_0.Emit(OpCodes.Newobj, (ConstructorInfo)methodBase_0);
				goto IL_0006;
				IL_0113:
				if (!methodBase_0.IsConstructor)
				{
					goto IL_011E;
				}
				goto IL_03CF;
				IL_010B:
				if (num2 >= parameters.Length)
				{
					goto IL_0113;
				}
				goto IL_0144;
				IL_03F0:
				num2++;
				goto IL_010B;
				IL_0057:
				ilgenerator_0.Emit(OpCodes.Ldc_I4, parameters.Length);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					goto IL_007B;
				}
				goto IL_0711;
				IL_00A7:
				ilgenerator_0.Emit(OpCodes.Throw);
				num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					goto IL_00C7;
				}
				goto IL_0711;
				IL_0088:
				ilgenerator_0.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(ReflectionUtils.EmptyTypes));
				goto IL_00A7;
				IL_007B:
				ilgenerator_0.Emit(OpCodes.Beq, label2);
				goto IL_0088;
				IL_00E5:
				ilgenerator_0.PushInstance(methodBase_0.DeclaringType);
				num = 24;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_03F0;
				}
				goto IL_0711;
				IL_00DA:
				if (!methodBase_0.IsStatic)
				{
					goto IL_00E5;
				}
				goto IL_037C;
				IL_00CF:
				if (!methodBase_0.IsConstructor)
				{
					goto IL_00DA;
				}
				goto IL_037C;
				IL_00C7:
				ilgenerator_0.MarkLabel(label2);
				goto IL_00CF;
				IL_011E:
				ilgenerator_0.CallMethod((MethodInfo)methodBase_0);
				num = 60;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					goto IL_03F0;
				}
				goto IL_0711;
				IL_0154:
				if (type.IsByRef)
				{
					goto IL_0174;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					goto IL_017D;
				}
				goto IL_0711;
				IL_014B:
				ParameterInfo parameterInfo;
				type = parameterInfo.ParameterType;
				goto IL_0154;
				IL_0144:
				parameterInfo = parameters[num2];
				goto IL_014B;
				IL_01A8:
				ilgenerator_0.UnboxIfNeeded(type);
				num = 65;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto IL_01C5;
				}
				goto IL_0711;
				IL_019C:
				if (!type.IsValueType())
				{
					goto IL_01A8;
				}
				goto IL_02EB;
				IL_0193:
				ilgenerator_0.PushArrayInstance(int_0, num2);
				goto IL_019C;
				IL_0187:
				if (!parameterInfo.IsOut)
				{
					goto IL_0193;
				}
				goto IL_02C7;
				IL_017D:
				localBuilder = ilgenerator_0.DeclareLocal(type);
				goto IL_0187;
				IL_0174:
				type = type.GetElementType();
				goto IL_017D;
				IL_01F4:
				LocalBuilder localBuilder4;
				ilgenerator_0.Emit(OpCodes.Stloc_S, localBuilder4);
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
				{
					goto IL_0216;
				}
				goto IL_0711;
				IL_01DF:
				ilgenerator_0.Emit(OpCodes.Isinst, typeof(IConvertible));
				goto IL_01F4;
				IL_01D2:
				ilgenerator_0.Emit(OpCodes.Ldloc_S, localBuilder2);
				goto IL_01DF;
				IL_01C5:
				ilgenerator_0.Emit(OpCodes.Brtrue_S, label4);
				goto IL_01D2;
				IL_0230:
				ilgenerator_0.Emit(OpCodes.Ldloc_S, localBuilder4);
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
				{
					goto IL_0252;
				}
				goto IL_0711;
				IL_0223:
				ilgenerator_0.Emit(OpCodes.Brfalse_S, label4);
				goto IL_0230;
				IL_0216:
				ilgenerator_0.Emit(OpCodes.Ldloc_S, localBuilder4);
				goto IL_0223;
				IL_025D:
				ilgenerator_0.Emit(OpCodes.Callvirt, method);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
				{
					goto IL_027F;
				}
				goto IL_0711;
				IL_0252:
				ilgenerator_0.Emit(OpCodes.Ldnull);
				goto IL_025D;
				IL_0296:
				ilgenerator_0.UnboxIfNeeded(type);
				num = 42;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_017D;
				}
				goto IL_0711;
				IL_02B8:
				ilgenerator_0.Emit(OpCodes.Ldloc_S, localBuilder2);
				goto IL_0296;
				IL_028C:
				ilgenerator_0.MarkLabel(label4);
				goto IL_02B8;
				IL_027F:
				ilgenerator_0.Emit(OpCodes.Br_S, label);
				goto IL_028C;
				IL_02C7:
				ilgenerator_0.Emit(opCode2, localBuilder);
				num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					goto IL_03F0;
				}
				goto IL_0711;
				IL_0308:
				ilgenerator_0.Emit(opCode2, localBuilder);
				num = 46;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
				{
					goto IL_0327;
				}
				goto IL_0711;
				IL_02FB:
				Label label6;
				ilgenerator_0.Emit(OpCodes.Brtrue_S, label6);
				goto IL_0308;
				IL_02F3:
				label5 = ilgenerator_0.DefineLabel();
				goto IL_02FB;
				IL_02EB:
				label6 = ilgenerator_0.DefineLabel();
				goto IL_02F3;
				IL_0349:
				ilgenerator_0.PushArrayInstance(int_0, num2);
				num = 33;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
				{
					goto IL_001E;
				}
				goto IL_0711;
				IL_0341:
				ilgenerator_0.MarkLabel(label6);
				goto IL_0349;
				IL_0334:
				ilgenerator_0.Emit(OpCodes.Br_S, label5);
				goto IL_0341;
				IL_0327:
				ilgenerator_0.Emit(OpCodes.Initobj, type);
				goto IL_0334;
				IL_037C:
				localBuilder4 = ilgenerator_0.DeclareLocal(typeof(IConvertible));
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
				{
					goto IL_0711;
				}
				IL_03A3:
				localBuilder2 = ilgenerator_0.DeclareLocal(typeof(object));
				num = 96;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					goto IL_0011;
				}
				goto IL_0711;
				IL_036C:
				ilgenerator_0.Emit(OpCodes.Ldnull);
				goto IL_003C;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000489DC File Offset: 0x00046BDC
		public override Func<T> CreateDefaultConstructor<[Nullable(2)] T>(Type type)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.smethod_0(Class15.smethod_17(1788765847 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c) + type.FullName, typeof(T), ReflectionUtils.EmptyTypes, type);
			dynamicMethod.InitLocals = true;
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.method_1(type, ilgenerator, typeof(T));
			return (Func<T>)dynamicMethod.CreateDelegate(typeof(Func<T>));
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00048A54 File Offset: 0x00046C54
		private void method_1(Type type_0, ILGenerator ilgenerator_0, Type type_1)
		{
			IL_0080:
			ConstructorInfo constructor;
			while (type_0.IsValueType())
			{
				for (;;)
				{
					IL_0064:
					ilgenerator_0.DeclareLocal(type_0);
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						goto Block_4;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							ilgenerator_0.Emit(OpCodes.Ldloc_0);
							goto IL_0003;
						case 2:
						case 3:
							goto IL_00EB;
						case 4:
							goto IL_00B8;
						case 5:
							goto IL_0064;
						case 6:
							goto IL_0080;
						case 7:
							goto IL_008F;
						case 8:
							goto IL_00AE;
						case 9:
							goto IL_0003;
						case 10:
							return;
						}
						goto Block_3;
						IL_0003:
						if (!(type_0 != type_1))
						{
							goto IL_00EB;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
						{
							goto Block_2;
						}
					}
				}
				Block_2:
				goto IL_008F;
				Block_3:
				Block_4:
				break;
				IL_008F:
				ilgenerator_0.Emit(OpCodes.Box, type_0);
				goto IL_00EB;
				IL_00AE:
				if (!(constructor == null))
				{
					ilgenerator_0.Emit(OpCodes.Newobj, constructor);
					goto IL_00EB;
				}
				IL_00B8:
				throw new ArgumentException(Class15.smethod_17(1788608964 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1).FormatWith(CultureInfo.InvariantCulture, type_0));
				IL_00EB:
				ilgenerator_0.Return();
				return;
			}
			constructor = type_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, ReflectionUtils.EmptyTypes, null);
			goto IL_00AE;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00048B54 File Offset: 0x00046D54
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Func<T, object> CreateGet<[Nullable(2)] T>(PropertyInfo propertyInfo)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.smethod_0(Class15.smethod_17(2008571013 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb) + propertyInfo.Name, typeof(object), new Type[] { typeof(T) }, propertyInfo.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.method_2(propertyInfo, ilgenerator);
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00048BCC File Offset: 0x00046DCC
		private void method_2(PropertyInfo propertyInfo_0, ILGenerator ilgenerator_0)
		{
			for (;;)
			{
				IL_00AF:
				MethodInfo getMethod = propertyInfo_0.GetGetMethod(true);
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
				{
					goto Block_8;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_0063;
					case 2:
						return;
					case 3:
						goto IL_00CD;
					case 4:
						goto IL_0105;
					case 5:
						if (getMethod == null)
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (!getMethod.IsStatic)
							{
								goto IL_0063;
							}
							num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
							{
								goto IL_0006;
							}
							continue;
						}
						break;
					case 6:
						goto IL_00AF;
					case 7:
					case 8:
						goto IL_0006;
					}
					goto Block_7;
					IL_0006:
					ilgenerator_0.CallMethod(getMethod);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto Block_1;
					}
					continue;
					IL_0063:
					ilgenerator_0.PushInstance(propertyInfo_0.DeclaringType);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0006;
					}
				}
			}
			Block_1:
			goto IL_00F9;
			Block_3:
			goto IL_00CD;
			Block_7:
			goto IL_00F9;
			Block_8:
			return;
			IL_00CD:
			throw new ArgumentException(Class15.smethod_17(768795838 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7).FormatWith(CultureInfo.InvariantCulture, propertyInfo_0.Name));
			IL_00F9:
			ilgenerator_0.BoxIfNeeded(propertyInfo_0.PropertyType);
			IL_0105:
			ilgenerator_0.Return();
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00048CE4 File Offset: 0x00046EE4
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Func<T, object> CreateGet<[Nullable(2)] T>(FieldInfo fieldInfo)
		{
			if (fieldInfo.IsLiteral)
			{
				DynamicReflectionDelegateFactory.<>c__DisplayClass11_0<T> CS$<>8__locals1 = new DynamicReflectionDelegateFactory.<>c__DisplayClass11_0<T>();
				CS$<>8__locals1.object_0 = fieldInfo.GetValue(null);
				return new Func<T, object>(CS$<>8__locals1.method_0);
			}
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.smethod_0(Class15.smethod_17(124829214 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719) + fieldInfo.Name, typeof(T), new Type[] { typeof(object) }, fieldInfo.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.method_3(fieldInfo, ilgenerator);
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00048D84 File Offset: 0x00046F84
		private void method_3(FieldInfo fieldInfo_0, ILGenerator ilgenerator_0)
		{
			for (;;)
			{
				if (!fieldInfo_0.IsStatic)
				{
					goto IL_0003;
				}
				goto IL_0054;
				IL_002C:
				int num;
				switch (num)
				{
				case 2:
					goto IL_008F;
				case 3:
					return;
				case 4:
					goto IL_000F;
				case 5:
					IL_0003:
					ilgenerator_0.PushInstance(fieldInfo_0.DeclaringType);
					goto IL_000F;
				case 6:
					continue;
				case 7:
					IL_0054:
					ilgenerator_0.Emit(OpCodes.Ldsfld, fieldInfo_0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
					{
						goto IL_002C;
					}
					break;
				}
				break;
				IL_000F:
				ilgenerator_0.Emit(OpCodes.Ldfld, fieldInfo_0);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
				{
					goto IL_002C;
				}
				break;
			}
			ilgenerator_0.BoxIfNeeded(fieldInfo_0.FieldType);
			IL_008F:
			ilgenerator_0.Return();
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00048E28 File Offset: 0x00047028
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Action<T, object> CreateSet<[Nullable(2)] T>(FieldInfo fieldInfo)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.smethod_0(Class15.smethod_17(2071417120 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808) + fieldInfo.Name, null, new Type[]
			{
				typeof(T),
				typeof(object)
			}, fieldInfo.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			DynamicReflectionDelegateFactory.GenerateCreateSetFieldIL(fieldInfo, ilgenerator);
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00048EA4 File Offset: 0x000470A4
		internal static void GenerateCreateSetFieldIL(FieldInfo fieldInfo, ILGenerator generator)
		{
			for (;;)
			{
				if (fieldInfo.IsStatic)
				{
					goto IL_00AC;
				}
				goto IL_00BC;
				IL_0023:
				int num;
				switch (num)
				{
				case 0:
					goto IL_0082;
				case 1:
				case 5:
					goto IL_00AC;
				case 2:
					break;
				case 3:
				case 7:
					goto IL_0067;
				case 4:
					goto IL_009E;
				case 6:
					continue;
				case 8:
				case 10:
					goto IL_005B;
				case 9:
					return;
				case 11:
					IL_00BC:
					generator.PushInstance(fieldInfo.DeclaringType);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						goto IL_00AC;
					}
					goto IL_0023;
				default:
					goto IL_0082;
				}
				IL_0006:
				generator.UnboxIfNeeded(fieldInfo.FieldType);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					goto IL_0023;
				}
				goto IL_0082;
				IL_0067:
				generator.Return();
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					continue;
				}
				goto IL_0023;
				IL_009E:
				generator.Emit(OpCodes.Stfld, fieldInfo);
				goto IL_0067;
				IL_0082:
				if (!fieldInfo.IsStatic)
				{
					goto IL_009E;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_0023;
				}
				IL_005B:
				generator.Emit(OpCodes.Stsfld, fieldInfo);
				goto IL_0067;
				IL_00AC:
				generator.Emit(OpCodes.Ldarg_1);
				goto IL_0006;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00048F9C File Offset: 0x0004719C
		[return: Nullable(new byte[] { 1, 1, 2 })]
		public override Action<T, object> CreateSet<[Nullable(2)] T>(PropertyInfo propertyInfo)
		{
			DynamicMethod dynamicMethod = DynamicReflectionDelegateFactory.smethod_0(Class15.smethod_17(552195780 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f) + propertyInfo.Name, null, new Type[]
			{
				typeof(T),
				typeof(object)
			}, propertyInfo.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			DynamicReflectionDelegateFactory.GenerateCreateSetPropertyIL(propertyInfo, ilgenerator);
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00049018 File Offset: 0x00047218
		internal static void GenerateCreateSetPropertyIL(PropertyInfo propertyInfo, ILGenerator generator)
		{
			MethodInfo setMethod;
			for (;;)
			{
				setMethod = propertyInfo.GetSetMethod(true);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_0003;
				}
				IL_003D:
				switch (num)
				{
				case 1:
					IL_0003:
					if (setMethod.IsStatic)
					{
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
						{
							goto Block_2;
						}
						goto IL_003D;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				case 4:
					goto IL_0098;
				case 5:
				case 7:
					goto IL_008D;
				case 6:
					goto IL_00A4;
				case 8:
					goto IL_00AC;
				}
				generator.PushInstance(propertyInfo.DeclaringType);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
				{
					goto IL_003D;
				}
				break;
			}
			Block_2:
			IL_008D:
			generator.Emit(OpCodes.Ldarg_1);
			IL_0098:
			generator.UnboxIfNeeded(propertyInfo.PropertyType);
			IL_00A4:
			generator.CallMethod(setMethod);
			IL_00AC:
			generator.Return();
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000490D8 File Offset: 0x000472D8
		public DynamicReflectionDelegateFactory()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0004910C File Offset: 0x0004730C
		static DynamicReflectionDelegateFactory()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_0003;
				}
				IL_0015:
				switch (num)
				{
				case 1:
					IL_0003:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						goto IL_0015;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
			DynamicReflectionDelegateFactory.Instance = new DynamicReflectionDelegateFactory();
		}

		// Token: 0x04000406 RID: 1030
		[CompilerGenerated]
		private static readonly DynamicReflectionDelegateFactory dynamicReflectionDelegateFactory_0;
	}
}
