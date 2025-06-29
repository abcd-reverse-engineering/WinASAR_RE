using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000106 RID: 262
	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JsonContract
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00004B17 File Offset: 0x00002D17
		public Type UnderlyingType { get; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00004B1F File Offset: 0x00002D1F
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x000591B8 File Offset: 0x000573B8
		public Type CreatedType
		{
			get
			{
				return this.type_0;
			}
			set
			{
				for (;;)
				{
					ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(564896464 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610));
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
					{
						goto IL_004E;
					}
					goto IL_0057;
					IL_0003:
					this.IsInstantiable = !this.type_0.IsInterface() && !this.type_0.IsAbstract();
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
					{
						continue;
					}
					goto IL_0057;
					IL_003B:
					this.IsSealed = this.type_0.IsSealed();
					goto IL_0003;
					IL_004E:
					this.type_0 = value;
					goto IL_003B;
					IL_0057:
					switch (num)
					{
					case 0:
						goto IL_004E;
					case 1:
						break;
					case 2:
						return;
					case 3:
						goto IL_003B;
					case 4:
						goto IL_0003;
					default:
						goto IL_004E;
					}
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00004B27 File Offset: 0x00002D27
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00004B2F File Offset: 0x00002D2F
		public bool? IsReference { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00004B38 File Offset: 0x00002D38
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00059268 File Offset: 0x00057468
		[Nullable(2)]
		public JsonConverter Converter
		{
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return this.jsonConverter_0;
			}
			[NullableContext(2)]
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.jsonConverter_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
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
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00004B40 File Offset: 0x00002D40
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x000592A0 File Offset: 0x000574A0
		[Nullable(2)]
		public JsonConverter InternalConverter
		{
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return this.jsonConverter_1;
			}
			[CompilerGenerated]
			[NullableContext(2)]
			internal set
			{
				for (;;)
				{
					this.jsonConverter_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
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
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00004B48 File Offset: 0x00002D48
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			get
			{
				if (this.list_0 == null)
				{
					this.list_0 = new List<SerializationCallback>();
				}
				return this.list_0;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00004B63 File Offset: 0x00002D63
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			get
			{
				if (this.list_1 == null)
				{
					this.list_1 = new List<SerializationCallback>();
				}
				return this.list_1;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00004B7E File Offset: 0x00002D7E
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			get
			{
				if (this.list_2 == null)
				{
					this.list_2 = new List<SerializationCallback>();
				}
				return this.list_2;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00004B99 File Offset: 0x00002D99
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			get
			{
				if (this.list_3 == null)
				{
					this.list_3 = new List<SerializationCallback>();
				}
				return this.list_3;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			get
			{
				if (this.list_4 == null)
				{
					this.list_4 = new List<SerializationErrorCallback>();
				}
				return this.list_4;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00004BCF File Offset: 0x00002DCF
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00004BD7 File Offset: 0x00002DD7
		[Nullable(new byte[] { 2, 1 })]
		public Func<object> DefaultCreator
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00004BE0 File Offset: 0x00002DE0
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x000592D8 File Offset: 0x000574D8
		public bool DefaultCreatorNonPublic
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
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
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00059310 File Offset: 0x00057510
		internal JsonContract(Type underlyingType)
		{
			int num = 7;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
			{
				goto IL_010A;
			}
			do
			{
				IL_0123:
				switch (num)
				{
				case 1:
					goto IL_010A;
				case 2:
					this.IsNullable = ReflectionUtils.IsNullable(underlyingType);
					goto IL_00A1;
				case 3:
					goto IL_00D4;
				case 4:
					goto IL_0052;
				case 5:
					goto IL_0059;
				case 6:
					goto IL_00A1;
				case 7:
					ValidationUtils.ArgumentNotNull(underlyingType, Class15.smethod_17(124817742 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto IL_0052;
					}
					continue;
				case 8:
					goto IL_0157;
				case 9:
					return;
				}
				break;
				IL_0059:
				underlyingType = ReflectionUtils.EnsureNotByRefType(underlyingType);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					break;
				}
				continue;
				IL_0052:
				this.UnderlyingType = underlyingType;
				goto IL_0059;
				IL_00A1:
				this.NonNullableUnderlyingType = ((!this.IsNullable || !ReflectionUtils.IsNullableType(underlyingType)) ? underlyingType : Nullable.GetUnderlyingType(underlyingType));
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0);
			IL_0076:
			this.IsEnum = this.NonNullableUnderlyingType.IsEnum();
			num = 8;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
			{
				goto IL_0157;
			}
			goto IL_0123;
			IL_00D4:
			this.IsConvertable = ConvertUtils.IsConvertible(this.NonNullableUnderlyingType);
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
			{
				goto IL_0076;
			}
			goto IL_0123;
			IL_010A:
			this.type_0 = (this.CreatedType = this.NonNullableUnderlyingType);
			goto IL_00D4;
			IL_0157:
			this.InternalReadType = ReadType.Read;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0005947C File Offset: 0x0005767C
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
			while (this.list_3 != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_0015;
				}
				IL_0033:
				List<SerializationCallback>.Enumerator enumerator;
				switch (num)
				{
				case 1:
					IL_0015:
					enumerator = this.list_3.GetEnumerator();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
					{
						goto IL_0033;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				try
				{
					for (;;)
					{
						if (!enumerator.MoveNext())
						{
							int num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
							{
								switch (num2)
								{
								case 1:
									goto IL_005B;
								case 2:
									continue;
								}
								break;
							}
							break;
						}
						IL_005B:
						enumerator.Current(o, context);
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
					{
						switch (num3)
						{
						}
					}
				}
				break;
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00059564 File Offset: 0x00057764
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
			List<SerializationCallback>.Enumerator enumerator;
			for (;;)
			{
				if (this.list_2 != null)
				{
					goto IL_0003;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					break;
				}
				IL_0021:
				switch (num)
				{
				case 1:
				case 4:
					return;
				case 2:
					continue;
				case 3:
					IL_0003:
					enumerator = this.list_2.GetEnumerator();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
					{
						goto IL_0021;
					}
					break;
				}
				break;
			}
			try
			{
				for (;;)
				{
					if (enumerator.MoveNext())
					{
						goto IL_0064;
					}
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
					{
						break;
					}
					IL_0083:
					switch (num2)
					{
					case 1:
						continue;
					case 2:
						goto IL_00BB;
					}
					IL_0064:
					enumerator.Current(o, context);
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af != 0)
					{
						goto IL_0083;
					}
				}
				IL_00BB:;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num3 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
				{
					switch (num3)
					{
					}
				}
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0005966C File Offset: 0x0005786C
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
			while (this.list_1 != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_0015;
				}
				IL_0033:
				List<SerializationCallback>.Enumerator enumerator;
				switch (num)
				{
				case 0:
					return;
				case 1:
					break;
				case 2:
					IL_0015:
					enumerator = this.list_1.GetEnumerator();
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
					{
						goto IL_0033;
					}
					break;
				case 3:
					continue;
				default:
					return;
				}
				try
				{
					for (;;)
					{
						if (enumerator.MoveNext())
						{
							goto IL_0061;
						}
						int num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
						{
							break;
						}
						IL_0080:
						switch (num2)
						{
						case 1:
							goto IL_00B8;
						case 2:
							IL_0061:
							enumerator.Current(o, context);
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
							{
								goto IL_0080;
							}
							break;
						}
					}
					IL_00B8:;
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						switch (num3)
						{
						}
					}
				}
				break;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00059770 File Offset: 0x00057970
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
			IL_0039:
			while (this.list_0 != null)
			{
				List<SerializationCallback>.Enumerator enumerator;
				for (;;)
				{
					enumerator = this.list_0.GetEnumerator();
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
					{
						switch (num)
						{
						case 1:
							return;
						case 2:
							continue;
						case 3:
							goto IL_0039;
						}
						break;
					}
					break;
				}
				try
				{
					for (;;)
					{
						if (enumerator.MoveNext())
						{
							goto IL_004C;
						}
						int num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
						{
							break;
						}
						IL_006B:
						switch (num2)
						{
						case 1:
							goto IL_00A3;
						case 2:
							IL_004C:
							enumerator.Current(o, context);
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
							{
								goto IL_006B;
							}
							break;
						}
					}
					IL_00A3:;
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
					{
						switch (num3)
						{
						}
					}
				}
				break;
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00059860 File Offset: 0x00057A60
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
			IL_003D:
			while (this.list_4 != null)
			{
				for (;;)
				{
					List<SerializationErrorCallback>.Enumerator enumerator = this.list_4.GetEnumerator();
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						switch (num)
						{
						case 1:
							goto IL_0049;
						case 3:
							goto IL_003D;
						case 4:
							continue;
						}
						break;
					}
					goto IL_0048;
				}
				break;
				IL_0048:
				IL_0049:
				try
				{
					List<SerializationErrorCallback>.Enumerator enumerator;
					while (enumerator.MoveNext())
					{
						for (;;)
						{
							enumerator.Current(o, context, errorContext);
							int num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
							{
								switch (num2)
								{
								case 1:
									continue;
								case 2:
									goto IL_008B;
								}
								break;
							}
							break;
						}
					}
					IL_008B:;
				}
				finally
				{
					List<SerializationErrorCallback>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						switch (num3)
						{
						}
					}
				}
				return;
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00004BE8 File Offset: 0x00002DE8
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			JsonContract.<>c__DisplayClass57_0 CS$<>8__locals1 = new JsonContract.<>c__DisplayClass57_0();
			CS$<>8__locals1.methodInfo_0 = callbackMethodInfo;
			return new SerializationCallback(CS$<>8__locals1.method_0);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00004C01 File Offset: 0x00002E01
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			JsonContract.<>c__DisplayClass58_0 CS$<>8__locals1 = new JsonContract.<>c__DisplayClass58_0();
			CS$<>8__locals1.methodInfo_0 = callbackMethodInfo;
			return new SerializationErrorCallback(CS$<>8__locals1.method_0);
		}

		// Token: 0x0400051C RID: 1308
		internal bool IsNullable;

		// Token: 0x0400051D RID: 1309
		internal bool IsConvertable;

		// Token: 0x0400051E RID: 1310
		internal bool IsEnum;

		// Token: 0x0400051F RID: 1311
		internal Type NonNullableUnderlyingType;

		// Token: 0x04000520 RID: 1312
		internal ReadType InternalReadType;

		// Token: 0x04000521 RID: 1313
		internal JsonContractType ContractType;

		// Token: 0x04000522 RID: 1314
		internal bool IsReadOnlyOrFixedSize;

		// Token: 0x04000523 RID: 1315
		internal bool IsSealed;

		// Token: 0x04000524 RID: 1316
		internal bool IsInstantiable;

		// Token: 0x04000525 RID: 1317
		[Nullable(new byte[] { 2, 1 })]
		private List<SerializationCallback> list_0;

		// Token: 0x04000526 RID: 1318
		[Nullable(new byte[] { 2, 1 })]
		private List<SerializationCallback> list_1;

		// Token: 0x04000527 RID: 1319
		[Nullable(new byte[] { 2, 1 })]
		private List<SerializationCallback> list_2;

		// Token: 0x04000528 RID: 1320
		[Nullable(new byte[] { 2, 1 })]
		private List<SerializationCallback> list_3;

		// Token: 0x04000529 RID: 1321
		[Nullable(new byte[] { 2, 1 })]
		private List<SerializationErrorCallback> list_4;

		// Token: 0x0400052A RID: 1322
		private Type type_0;

		// Token: 0x0400052B RID: 1323
		[CompilerGenerated]
		private readonly Type type_1;

		// Token: 0x0400052C RID: 1324
		[CompilerGenerated]
		private bool? nullable_0;

		// Token: 0x0400052D RID: 1325
		[Nullable(2)]
		[CompilerGenerated]
		private JsonConverter jsonConverter_0;

		// Token: 0x0400052E RID: 1326
		[CompilerGenerated]
		[Nullable(2)]
		private JsonConverter jsonConverter_1;

		// Token: 0x0400052F RID: 1327
		[Nullable(new byte[] { 2, 1 })]
		[CompilerGenerated]
		private Func<object> func_0;

		// Token: 0x04000530 RID: 1328
		[CompilerGenerated]
		private bool bool_0;
	}
}
