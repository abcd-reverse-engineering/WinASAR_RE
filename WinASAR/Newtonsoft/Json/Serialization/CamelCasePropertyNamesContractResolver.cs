using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000E4 RID: 228
	[Nullable(0)]
	[NullableContext(1)]
	public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x00052B34 File Offset: 0x00050D34
		public CamelCasePropertyNamesContractResolver()
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
			{
				goto IL_0044;
			}
			IL_001A:
			base.NamingStrategy = new CamelCaseNamingStrategy
			{
				ProcessDictionaryKeys = true,
				OverrideSpecifiedNames = true
			};
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
			{
				return;
			}
			IL_0044:
			switch (num)
			{
			case 1:
				goto IL_001A;
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00052B98 File Offset: 0x00050D98
		public override JsonContract ResolveContract(Type type)
		{
			IL_00CA:
			while (!(type == null))
			{
				StructMultiKey<Type, Type> structMultiKey;
				JsonContract jsonContract;
				object obj;
				bool flag;
				for (;;)
				{
					structMultiKey = new StructMultiKey<Type, Type>(base.GetType(), type);
					int num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto IL_0016;
					}
					IL_0071:
					Dictionary<StructMultiKey<Type, Type>, JsonContract> dictionary;
					switch (num)
					{
					case 0:
						goto IL_004A;
					case 1:
						goto IL_0031;
					case 2:
						goto IL_00DA;
					case 3:
						continue;
					case 4:
						goto IL_00CA;
					case 5:
						goto IL_0016;
					case 6:
						dictionary = CamelCasePropertyNamesContractResolver.dictionary_0;
						goto IL_0061;
					case 7:
						return jsonContract;
					case 8:
						goto IL_0061;
					case 9:
						goto IL_0192;
					case 10:
						break;
					default:
						goto IL_004A;
					}
					IL_0006:
					if (!dictionary.TryGetValue(structMultiKey, out jsonContract))
					{
						goto IL_0016;
					}
					return jsonContract;
					IL_0061:
					if (dictionary != null)
					{
						goto IL_0006;
					}
					IL_0016:
					jsonContract = this.CreateContract(type);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto IL_0071;
					}
					IL_0031:
					obj = CamelCasePropertyNamesContractResolver.object_0;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
					{
						goto IL_0071;
					}
					IL_004A:
					flag = false;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
					{
						break;
					}
					goto IL_0071;
				}
				IL_00DA:
				try
				{
					Monitor.Enter(obj, ref flag);
					for (;;)
					{
						IL_0147:
						Dictionary<StructMultiKey<Type, Type>, JsonContract> dictionary = CamelCasePropertyNamesContractResolver.dictionary_0;
						for (;;)
						{
							object obj2;
							if (dictionary != null)
							{
								obj2 = new Dictionary<StructMultiKey<Type, Type>, JsonContract>(dictionary);
								goto IL_00ED;
							}
							int num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
							{
								goto IL_0122;
							}
							IL_010D:
							switch (num2)
							{
							default:
								IL_0122:
								obj2 = new Dictionary<StructMultiKey<Type, Type>, JsonContract>();
								break;
							case 1:
								goto IL_0150;
							case 2:
								continue;
							case 3:
								goto IL_0147;
							}
							IL_00ED:
							object obj3 = obj2;
							obj3[structMultiKey] = jsonContract;
							CamelCasePropertyNamesContractResolver.dictionary_0 = obj3;
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
							{
								goto IL_010D;
							}
							goto IL_0122;
						}
					}
					IL_0150:
					return jsonContract;
				}
				finally
				{
					if (flag)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
						{
							goto IL_0180;
						}
						IL_0168:
						Monitor.Exit(obj);
						num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
						{
							break;
						}
						IL_0180:
						switch (num3)
						{
						case 0:
							goto IL_0168;
						case 1:
							break;
						default:
							goto IL_0168;
						}
					}
				}
				break;
			}
			IL_0192:
			throw new ArgumentNullException(Class15.smethod_17(1396540620 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00004831 File Offset: 0x00002A31
		internal override DefaultJsonNameTable GetNameTable()
		{
			return CamelCasePropertyNamesContractResolver.defaultJsonNameTable_1;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00052D64 File Offset: 0x00050F64
		static CamelCasePropertyNamesContractResolver()
		{
			for (;;)
			{
				for (;;)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
					{
						goto IL_0021;
					}
					IL_003F:
					switch (num)
					{
					case 0:
						goto IL_0021;
					case 1:
						return;
					case 2:
						continue;
					case 3:
						continue;
					case 4:
						break;
					default:
						goto IL_0021;
					}
					IL_0003:
					CamelCasePropertyNamesContractResolver.defaultJsonNameTable_1 = new DefaultJsonNameTable();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						return;
					}
					goto IL_003F;
					IL_0021:
					CamelCasePropertyNamesContractResolver.object_0 = new object();
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						goto IL_0003;
					}
					goto IL_003F;
				}
			}
		}

		// Token: 0x040004AF RID: 1199
		private static readonly object object_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly DefaultJsonNameTable defaultJsonNameTable_1;

		// Token: 0x040004B1 RID: 1201
		[Nullable(new byte[] { 2, 0, 1, 1, 1 })]
		private static Dictionary<StructMultiKey<Type, Type>, JsonContract> dictionary_0;
	}
}
