using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using <CppImplementationDetails>;
using <CrtImplementationDetails>;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00001090 File Offset: 0x00000490
	internal unsafe static int main(int ArGC, sbyte** ArGV)
	{
		long num = (long)stackalloc byte[<Module>.__CxxQueryExceptionSize()];
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@ECMAOMMM@?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@KLHKMFNP@?1?1?5?5SCUE4?5Plugin?5for?5Unreal?5Engi@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@HPDDPAIA@?1?1?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@CMBFEEKM@?1?1?5?5?$CIC?$CJ?5Bruno?4Xavier?4Leite?52016?5@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@FLDPGIOG@?1?1?5?5bruno_xavier_?$EAmsn?4com?5?5?5?5?5?5?5@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@KIPPIFBD@?1?1?5?5http?3?1?1brunoxavierleite?4com?5@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@ECMAOMMM@?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_01EEMJAFIK@?6?$AA@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@ECMAOMMM@?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1@));
		Process currentProcess = Process.GetCurrentProcess();
		<Module>.LOG(<Module>.MStoCC(<Module>.CCtoMS(<Module>.?A0x83443b5b.CtoS1) + currentProcess.ProcessName + <Module>.CCtoMS(<Module>.?A0x83443b5b.CtoS2) + currentProcess.Id));
		if (ArGC > 1)
		{
			<Module>.LOG(<Module>.MStoCC(<Module>.CCtoMS(<Module>.?A0x83443b5b.CtoS3) + new string(*(ArGV + 8L))));
		}
		else
		{
			currentProcess.Kill();
		}
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@ECMAOMMM@?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_00CNPNBAHC@?$AA@));
		Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
		if (processesByName.GetLength(0) > 1)
		{
			int num2 = 0;
			if (0 < processesByName.Length)
			{
				do
				{
					Process process = processesByName[num2];
					if (process.MainModule.FileName == currentProcess.MainModule.FileName && process.Id != currentProcess.Id)
					{
						process.Kill();
						<Module>.LOG(<Module>.MStoCC(<Module>.CCtoMS(<Module>.?A0x83443b5b.CtoS1) + "Re-instantiating Process >>> From: " + process.Id + " To: " + currentProcess.Id));
						<Module>.LOG((sbyte*)(&<Module>.??_C@_00CNPNBAHC@?$AA@));
					}
					num2++;
				}
				while (num2 < processesByName.Length);
			}
		}
		<Module>.LOG((sbyte*)(&<Module>.??_C@_0FA@ECMAOMMM@?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1@));
		<Module>.LOG((sbyte*)(&<Module>.??_C@_00CNPNBAHC@?$AA@));
		<Module>.?A0x83443b5b.LOOP = 1;
		while (<Module>.?A0x83443b5b.LOOP != 0)
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.GetLength(0) - 1; i++)
			{
				uint exceptionCode;
				try
				{
					bool flag = false;
					int num3 = 0;
					while ((long)num3 < 4L)
					{
						string value = new string(*((long)num3 * 8L + ref <Module>.?A0x83443b5b.TrustedProcesses));
						if (processes[i].ProcessName.ToLower().Contains(value))
						{
							goto IL_342;
						}
						num3++;
					}
					if (!flag)
					{
						int num4 = 0;
						while ((long)num4 < 154L)
						{
							string value = new string(*((long)num4 * 8L + ref <Module>.?A0x83443b5b.Keyword));
							if (processes[i].ProcessName.ToLower().Contains(value))
							{
								<Module>.LOG(<Module>.?A0x83443b5b.HAX);
								<Module>.LOG(<Module>.MStoCC(processes[i].ProcessName));
								processes[i].CloseMainWindow();
								processes[i].Kill();
								break;
							}
							if (processes[i].MainWindowTitle.ToLower().Contains(value))
							{
								<Module>.LOG(<Module>.?A0x83443b5b.HAX);
								<Module>.LOG(<Module>.MStoCC(processes[i].ProcessName));
								processes[i].CloseMainWindow();
								processes[i].Kill();
								break;
							}
							num4++;
						}
					}
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					exceptionCode = (uint)Marshal.GetExceptionCode();
					endfilter(<Module>.__CxxExceptionFilter(Marshal.GetExceptionPointers(), null, 0, null) != null);
				})
				{
					uint num5 = 0U;
					<Module>.__CxxRegisterExceptionObject(Marshal.GetExceptionPointers(), num);
					try
					{
						try
						{
							goto IL_342;
						}
						catch when (delegate
						{
							// Failed to create a 'catch-when' expression
							num5 = <Module>.__CxxDetectRethrow(Marshal.GetExceptionPointers());
							endfilter(num5 != 0U);
						})
						{
						}
						if (num5 != 0U)
						{
							throw;
						}
					}
					finally
					{
						<Module>.__CxxUnregisterExceptionObject(num, (int)num5);
					}
				}
				IL_342:;
			}
			<Module>.Sleep(2000);
		}
		return 0;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00001444 File Offset: 0x00000844
	internal unsafe static void LOG(sbyte* Text)
	{
		<Module>.printf(Text);
		<Module>.printf(ref <Module>.??_C@_01EEMJAFIK@?6?$AA@);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00001464 File Offset: 0x00000864
	internal unsafe static sbyte* MStoCC(string Input)
	{
		return (sbyte*)((void*)Marshal.StringToHGlobalAnsi(Input));
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000147C File Offset: 0x0000087C
	internal unsafe static string CCtoMS(sbyte* Input)
	{
		return new string((sbyte*)Input);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002960 File Offset: 0x00001D60
	internal static void <CrtImplementationDetails>.ThrowNestedModuleLoadException(Exception innerException, Exception nestedException)
	{
		throw new ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002348 File Offset: 0x00001748
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage)
	{
		throw new ModuleLoadException(errorMessage);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000235C File Offset: 0x0000175C
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage, Exception innerException)
	{
		throw new ModuleLoadException(errorMessage, innerException);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002478 File Offset: 0x00001878
	internal static void <CrtImplementationDetails>.RegisterModuleUninitializer(EventHandler handler)
	{
		ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002490 File Offset: 0x00001890
	[SecuritySafeCritical]
	internal unsafe static Guid <CrtImplementationDetails>.FromGUID(_GUID* guid)
	{
		Guid result = new Guid((uint)(*guid), *(guid + 4L), *(guid + 6L), *(guid + 8L), *(guid + 9L), *(guid + 10L), *(guid + 11L), *(guid + 12L), *(guid + 13L), *(guid + 14L), *(guid + 15L));
		return result;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000024E0 File Offset: 0x000018E0
	[SecurityCritical]
	internal unsafe static int __get_default_appdomain(IUnknown** ppUnk)
	{
		ICorRuntimeHost* ptr = null;
		int num;
		try
		{
			Guid riid = <Module>.<CrtImplementationDetails>.FromGUID(ref <Module>._GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e);
			ptr = (ICorRuntimeHost*)RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(<Module>.<CrtImplementationDetails>.FromGUID(ref <Module>._GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e), riid).ToPointer();
			goto IL_35;
		}
		catch (Exception e)
		{
			num = Marshal.GetHRForException(e);
		}
		if (num < 0)
		{
			return num;
		}
		IL_35:
		num = calli(System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.IntPtr,IUnknown**), ptr, ppUnk, *(*(long*)ptr + 104L));
		ICorRuntimeHost* ptr2 = ptr;
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.IntPtr), ptr2, *(*(long*)ptr2 + 16L));
		return num;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000255C File Offset: 0x0000195C
	internal unsafe static void __release_appdomain(IUnknown* ppUnk)
	{
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.IntPtr), ppUnk, *(*(long*)ppUnk + 16L));
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002578 File Offset: 0x00001978
	[SecurityCritical]
	internal unsafe static AppDomain <CrtImplementationDetails>.GetDefaultDomain()
	{
		IUnknown* ptr = null;
		int num = <Module>.__get_default_appdomain(&ptr);
		if (num >= 0)
		{
			try
			{
				IntPtr pUnk = new IntPtr((void*)ptr);
				return (AppDomain)Marshal.GetObjectForIUnknown(pUnk);
			}
			finally
			{
				<Module>.__release_appdomain(ptr);
			}
		}
		Marshal.ThrowExceptionForHR(num);
		return null;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000025D8 File Offset: 0x000019D8
	[SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.DoCallBackInDefaultDomain(method function, void* cookie)
	{
		Guid riid = <Module>.<CrtImplementationDetails>.FromGUID(ref <Module>._GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02);
		ICLRRuntimeHost* ptr = (ICLRRuntimeHost*)RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(<Module>.<CrtImplementationDetails>.FromGUID(ref <Module>._GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02), riid).ToPointer();
		try
		{
			AppDomain appDomain = <Module>.<CrtImplementationDetails>.GetDefaultDomain();
			int num = calli(System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.IntPtr,System.UInt32 modopt(System.Runtime.CompilerServices.IsLong),System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvCdecl) (System.Void*),System.Void*), ptr, appDomain.Id, function, cookie, *(*(long*)ptr + 64L));
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
		}
		finally
		{
			ICLRRuntimeHost* ptr2 = ptr;
			object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvCdecl)(System.IntPtr), ptr2, *(*(long*)ptr2 + 16L));
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002660 File Offset: 0x00001A60
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool __scrt_is_safe_for_managed_code()
	{
		return (<Module>.__scrt_native_dllmain_reason <= 1U) ? 0 : 1;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002690 File Offset: 0x00001A90
	[SecuritySafeCritical]
	internal unsafe static int <CrtImplementationDetails>.DefaultDomain.DoNothing(void* cookie)
	{
		GC.KeepAlive(int.MaxValue);
		return 0;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000026B0 File Offset: 0x00001AB0
	[SecuritySafeCritical]
	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool <CrtImplementationDetails>.DefaultDomain.HasPerProcess()
	{
		if (<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A == (TriBool)2)
		{
			void** ptr = (void**)(&<Module>.__xc_mp_a);
			if (ref <Module>.__xc_mp_a < ref <Module>.__xc_mp_z)
			{
				while (*(long*)ptr == 0L)
				{
					ptr += 8L / (long)sizeof(void*);
					if (ptr >= (void**)(&<Module>.__xc_mp_z))
					{
						goto IL_35;
					}
				}
				<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A = (TriBool)(-1);
				return 1;
			}
			IL_35:
			<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A = (TriBool)0;
			return 0;
		}
		return (<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A == (TriBool)(-1)) ? 1 : 0;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002704 File Offset: 0x00001B04
	[SecuritySafeCritical]
	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool <CrtImplementationDetails>.DefaultDomain.HasNative()
	{
		if (<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A == (TriBool)2)
		{
			void** ptr = (void**)(&<Module>.__xi_a);
			if (ref <Module>.__xi_a < ref <Module>.__xi_z)
			{
				while (*(long*)ptr == 0L)
				{
					ptr += 8L / (long)sizeof(void*);
					if (ptr >= (void**)(&<Module>.__xi_z))
					{
						goto IL_35;
					}
				}
				<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A = (TriBool)(-1);
				return 1;
			}
			IL_35:
			void** ptr2 = (void**)(&<Module>.__xc_a);
			if (ref <Module>.__xc_a < ref <Module>.__xc_z)
			{
				while (*(long*)ptr2 == 0L)
				{
					ptr2 += 8L / (long)sizeof(void*);
					if (ptr2 >= (void**)(&<Module>.__xc_z))
					{
						goto IL_62;
					}
				}
				<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A = (TriBool)(-1);
				return 1;
			}
			IL_62:
			<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A = (TriBool)0;
			return 0;
		}
		return (<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A == (TriBool)(-1)) ? 1 : 0;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002784 File Offset: 0x00001B84
	[SecuritySafeCritical]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsInitialization()
	{
		int num;
		if ((<Module>.<CrtImplementationDetails>.DefaultDomain.HasPerProcess() != null && !<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA) || (<Module>.<CrtImplementationDetails>.DefaultDomain.HasNative() != null && !<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA && <Module>.__scrt_current_native_startup_state == (__scrt_native_startup_state)0))
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000027BC File Offset: 0x00001BBC
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsUninitialization()
	{
		return <Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000027D0 File Offset: 0x00001BD0
	[SecurityCritical]
	internal static void <CrtImplementationDetails>.DefaultDomain.Initialize()
	{
		<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(<Module>.__unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCAJPEAX@Z, null);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00001000 File Offset: 0x00000400
	internal static void ??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00001014 File Offset: 0x00000414
	internal static void ??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00001028 File Offset: 0x00000428
	internal static void ??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
	{
		<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000103C File Offset: 0x0000043C
	internal static void ??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A@@YMXXZ()
	{
		<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)0;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00001050 File Offset: 0x00000450
	internal static void ??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A@@YMXXZ()
	{
		<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)0;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00001064 File Offset: 0x00000464
	internal static void ??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A@@YMXXZ()
	{
		<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)0;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00001078 File Offset: 0x00000478
	internal static void ??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A@@YMXXZ()
	{
		<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)0;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000029B4 File Offset: 0x00001DB4
	[DebuggerStepThrough]
	[SecuritySafeCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeVtables(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during vtable initialization.\n");
		<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)1;
		<Module>._initterm_m((method*)(&<Module>.__xi_vt_a), (method*)(&<Module>.__xi_vt_z));
		<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)2;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000029E8 File Offset: 0x00001DE8
	[SecuritySafeCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
		<Module>.<CrtImplementationDetails>.DefaultDomain.Initialize();
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002A08 File Offset: 0x00001E08
	[DebuggerStepThrough]
	[SecuritySafeCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeNative(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during native initialization.\n");
		<Module>.__security_init_cookie();
		<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
		if (<Module>.__scrt_is_safe_for_managed_code() == null)
		{
			<Module>.abort();
		}
		if (<Module>.__scrt_current_native_startup_state == (__scrt_native_startup_state)1)
		{
			<Module>.abort();
		}
		if (<Module>.__scrt_current_native_startup_state == (__scrt_native_startup_state)0)
		{
			<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)1;
			<Module>.__scrt_current_native_startup_state = (__scrt_native_startup_state)1;
			if (<Module>._initterm_e((method*)(&<Module>.__xi_a), (method*)(&<Module>.__xi_z)) != 0)
			{
				<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(<Module>.gcroot<System::String\u0020^>..PE$AAVString@System@@(A_0));
			}
			<Module>._initterm((method*)(&<Module>.__xc_a), (method*)(&<Module>.__xc_z));
			<Module>.__scrt_current_native_startup_state = (__scrt_native_startup_state)2;
			<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
			<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)2;
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002A98 File Offset: 0x00001E98
	[SecurityCritical]
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerProcess(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during process initialization.\n");
		<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)1;
		<Module>._initatexit_m();
		<Module>._initterm_m((method*)(&<Module>.__xc_mp_a), (method*)(&<Module>.__xc_mp_z));
		<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)2;
		<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002AD8 File Offset: 0x00001ED8
	[DebuggerStepThrough]
	[SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during appdomain initialization.\n");
		<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)1;
		<Module>._initatexit_app_domain();
		<Module>._initterm_m((method*)(&<Module>.__xc_ma_a), (method*)(&<Module>.__xc_ma_z));
		<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A = (Progress)2;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002B14 File Offset: 0x00001F14
	[SecurityCritical]
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during registration for the unload events.\n");
		<Module>.<CrtImplementationDetails>.RegisterModuleUninitializer(new EventHandler(<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload));
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002B40 File Offset: 0x00001F40
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityCritical]
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport._Initialize(LanguageSupport* A_0)
	{
		<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = AppDomain.CurrentDomain.IsDefaultAppDomain();
		<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA = (<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA || <Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA);
		void* ptr = <Module>._getFiberPtrId();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			while (num2 == 0)
			{
				try
				{
				}
				finally
				{
					void* ptr2 = Interlocked.CompareExchange(ref <Module>.__scrt_native_startup_lock, ptr, 0L);
					if (ptr2 == null)
					{
						num2 = 1;
					}
					else if (ptr2 == ptr)
					{
						num = 1;
						num2 = 1;
					}
				}
				if (num2 == 0)
				{
					<Module>.Sleep(1000);
				}
			}
			<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeVtables(A_0);
			if (<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA)
			{
				<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeNative(A_0);
				<Module>.<CrtImplementationDetails>.LanguageSupport.InitializePerProcess(A_0);
			}
			else
			{
				num3 = ((<Module>.<CrtImplementationDetails>.DefaultDomain.NeedsInitialization() != 0) ? 1 : num3);
			}
		}
		finally
		{
			if (num == 0)
			{
				Interlocked.Exchange(ref <Module>.__scrt_native_startup_lock, 0L);
			}
		}
		if (num3 != 0)
		{
			<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(A_0);
		}
		<Module>.<CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(A_0);
		<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 1;
		<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(A_0);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000027EC File Offset: 0x00001BEC
	[SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
	{
		<Module>._app_exit_callback();
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002800 File Offset: 0x00001C00
	[SecurityCritical]
	internal unsafe static int <CrtImplementationDetails>.LanguageSupport._UninitializeDefaultDomain(void* cookie)
	{
		<Module>._exit_callback();
		<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		if (<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA)
		{
			<Module>._cexit();
			<Module>.__scrt_current_native_startup_state = (__scrt_native_startup_state)0;
			<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		}
		<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		return 0;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002838 File Offset: 0x00001C38
	[SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain()
	{
		if (<Module>.<CrtImplementationDetails>.DefaultDomain.NeedsUninitialization() != null)
		{
			if (AppDomain.CurrentDomain.IsDefaultAppDomain())
			{
				<Module>.<CrtImplementationDetails>.LanguageSupport._UninitializeDefaultDomain(null);
			}
			else
			{
				<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(<Module>.__unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCAJPEAX@Z, null);
			}
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002870 File Offset: 0x00001C70
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityCritical]
	[PrePrepareMethod]
	internal static void <CrtImplementationDetails>.LanguageSupport.DomainUnload(object A_0, EventArgs A_1)
	{
		if (<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA != 0 && Interlocked.Exchange(ref <Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA, 1) == 0)
		{
			byte b = (Interlocked.Decrement(ref <Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA) == 0) ? 1 : 0;
			<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain();
			if (b != 0)
			{
				<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain();
			}
		}
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002C44 File Offset: 0x00002044
	[DebuggerStepThrough]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.Cleanup(LanguageSupport* A_0, Exception innerException)
	{
		try
		{
			bool flag = ((Interlocked.Decrement(ref <Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA) == 0) ? 1 : 0) != 0;
			<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain();
			if (flag)
			{
				<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain();
			}
		}
		catch (Exception nestedException)
		{
			<Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, nestedException);
		}
		catch (object obj)
		{
			<Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, null);
		}
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002CB8 File Offset: 0x000020B8
	[SecurityCritical]
	internal unsafe static LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002CD0 File Offset: 0x000020D0
	[SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.{dtor}(LanguageSupport* A_0)
	{
		<Module>.gcroot<System::String\u0020^>.{dtor}(A_0);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002CE4 File Offset: 0x000020E4
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.Initialize(LanguageSupport* A_0)
	{
		bool flag = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load.\n");
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				Interlocked.Increment(ref <Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA);
				flag = true;
			}
			<Module>.<CrtImplementationDetails>.LanguageSupport._Initialize(A_0);
		}
		catch (Exception innerException)
		{
			if (flag)
			{
				<Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(A_0, innerException);
			}
			<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(<Module>.gcroot<System::String\u0020^>..PE$AAVString@System@@(A_0), innerException);
		}
		catch (object obj)
		{
			if (flag)
			{
				<Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(A_0, null);
			}
			<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(<Module>.gcroot<System::String\u0020^>..PE$AAVString@System@@(A_0), null);
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002DA0 File Offset: 0x000021A0
	[SecurityCritical]
	[DebuggerStepThrough]
	static unsafe <Module>()
	{
		LanguageSupport languageSupport;
		<Module>.<CrtImplementationDetails>.LanguageSupport.{ctor}(ref languageSupport);
		try
		{
			<Module>.<CrtImplementationDetails>.LanguageSupport.Initialize(ref languageSupport);
		}
		catch
		{
			<Module>.___CxxCallUnwindDtor(ldftn(<CrtImplementationDetails>.LanguageSupport.{dtor}), (void*)(&languageSupport));
			throw;
		}
		<Module>.<CrtImplementationDetails>.LanguageSupport.{dtor}(ref languageSupport);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000028AC File Offset: 0x00001CAC
	[SecuritySafeCritical]
	internal unsafe static string PE$AAVString@System@@(gcroot<System::String\u0020^>* A_0)
	{
		IntPtr value = new IntPtr(*A_0);
		return ((GCHandle)value).Target;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000028D0 File Offset: 0x00001CD0
	[SecurityCritical]
	[DebuggerStepThrough]
	internal unsafe static gcroot<System::String\u0020^>* =(gcroot<System::String\u0020^>* A_0, string t)
	{
		IntPtr value = new IntPtr(*A_0);
		((GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000028F8 File Offset: 0x00001CF8
	[SecurityCritical]
	[DebuggerStepThrough]
	internal unsafe static void {dtor}(gcroot<System::String\u0020^>* A_0)
	{
		IntPtr value = new IntPtr(*A_0);
		((GCHandle)value).Free();
		*A_0 = 0L;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002920 File Offset: 0x00001D20
	[SecuritySafeCritical]
	[DebuggerStepThrough]
	internal unsafe static gcroot<System::String\u0020^>* {ctor}(gcroot<System::String\u0020^>* A_0)
	{
		*A_0 = ((IntPtr)GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002E14 File Offset: 0x00002214
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[HandleProcessCorruptedStateExceptions]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void ___CxxCallUnwindDtor(method pDtor, void* pThis)
	{
		try
		{
			calli(System.Void(System.Void*), pThis, pDtor);
		}
		catch when (endfilter(<Module>.__FrameUnwindFilter(Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002E58 File Offset: 0x00002258
	[SecurityCritical]
	[DebuggerStepThrough]
	internal static ValueType <CrtImplementationDetails>.AtExitLock._handle()
	{
		if (<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PEAXEA != null)
		{
			IntPtr value = new IntPtr(<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PEAXEA);
			return GCHandle.FromIntPtr(value);
		}
		return null;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00003118 File Offset: 0x00002518
	[DebuggerStepThrough]
	[SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
	{
		<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PEAXEA = null;
		<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002E88 File Offset: 0x00002288
	[DebuggerStepThrough]
	[SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Set(object value)
	{
		ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType == null)
		{
			valueType = GCHandle.Alloc(value);
			<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PEAXEA = GCHandle.ToIntPtr((GCHandle)valueType).ToPointer();
		}
		else
		{
			((GCHandle)valueType).Target = value;
		}
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002ED8 File Offset: 0x000022D8
	[DebuggerStepThrough]
	[SecurityCritical]
	internal static object <CrtImplementationDetails>.AtExitLock._lock_Get()
	{
		ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			return ((GCHandle)valueType).Target;
		}
		return null;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002EFC File Offset: 0x000022FC
	[DebuggerStepThrough]
	[SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Destruct()
	{
		ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			((GCHandle)valueType).Free();
			<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PEAXEA = null;
		}
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002F24 File Offset: 0x00002324
	[SecurityCritical]
	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
	{
		return (<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null) ? 1 : 0;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003134 File Offset: 0x00002534
	[SecurityCritical]
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.AddRef()
	{
		if (<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized() == null)
		{
			<Module>.<CrtImplementationDetails>.AtExitLock._lock_Construct(new object());
			<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA = 0;
		}
		<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA++;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002F40 File Offset: 0x00002340
	[SecurityCritical]
	[DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.RemoveRef()
	{
		<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA += -1;
		if (<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA == 0)
		{
			<Module>.<CrtImplementationDetails>.AtExitLock._lock_Destruct();
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003164 File Offset: 0x00002564
	[DebuggerStepThrough]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool __alloc_global_lock()
	{
		<Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
		return <Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002F68 File Offset: 0x00002368
	[DebuggerStepThrough]
	[SecurityCritical]
	internal static void __dealloc_global_lock()
	{
		<Module>.<CrtImplementationDetails>.AtExitLock.RemoveRef();
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002F7C File Offset: 0x0000237C
	[SecurityCritical]
	internal unsafe static void _exit_callback()
	{
		if (<Module>.?A0xc2538164.__exit_list_size != 0UL)
		{
			method* ptr = (method*)<Module>.DecodePointer((void*)<Module>.?A0xc2538164.__onexitbegin_m);
			method* ptr2 = (method*)<Module>.DecodePointer((void*)<Module>.?A0xc2538164.__onexitend_m);
			if (ptr != -1L && ptr != null && ptr2 != null)
			{
				method* ptr3 = ptr;
				method* ptr4 = ptr2;
				for (;;)
				{
					ptr2 -= 8L / (long)sizeof(method);
					if (ptr2 < ptr)
					{
						break;
					}
					if (*(long*)ptr2 != <Module>.EncodePointer(null))
					{
						void* ptr5 = <Module>.DecodePointer(*(long*)ptr2);
						*(long*)ptr2 = <Module>.EncodePointer(null);
						calli(System.Void(), ptr5);
						method* ptr6 = (method*)<Module>.DecodePointer((void*)<Module>.?A0xc2538164.__onexitbegin_m);
						method* ptr7 = (method*)<Module>.DecodePointer((void*)<Module>.?A0xc2538164.__onexitend_m);
						if (ptr3 != ptr6 || ptr4 != ptr7)
						{
							ptr3 = ptr6;
							ptr = ptr6;
							ptr4 = ptr7;
							ptr2 = ptr7;
						}
					}
				}
				IntPtr hglobal = new IntPtr((void*)ptr);
				Marshal.FreeHGlobal(hglobal);
			}
			<Module>.?A0xc2538164.__dealloc_global_lock();
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x0000317C File Offset: 0x0000257C
	[DebuggerStepThrough]
	[SecurityCritical]
	internal unsafe static int _initatexit_m()
	{
		int result = 0;
		if (<Module>.?A0xc2538164.__alloc_global_lock() == 1)
		{
			<Module>.?A0xc2538164.__onexitbegin_m = (method*)<Module>.EncodePointer(Marshal.AllocHGlobal(256).ToPointer());
			<Module>.?A0xc2538164.__onexitend_m = <Module>.?A0xc2538164.__onexitbegin_m;
			<Module>.?A0xc2538164.__exit_list_size = 32UL;
			result = 1;
		}
		return result;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000031C4 File Offset: 0x000025C4
	[SecurityCritical]
	[DebuggerStepThrough]
	internal unsafe static int _initatexit_app_domain()
	{
		if (<Module>.?A0xc2538164.__alloc_global_lock() == 1)
		{
			<Module>.__onexitbegin_app_domain = (method*)<Module>.EncodePointer(Marshal.AllocHGlobal(256).ToPointer());
			<Module>.__onexitend_app_domain = <Module>.__onexitbegin_app_domain;
			<Module>.__exit_list_size_app_domain = 32UL;
		}
		return 1;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000302C File Offset: 0x0000242C
	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal unsafe static void _app_exit_callback()
	{
		if (<Module>.__exit_list_size_app_domain != 0UL)
		{
			method* ptr = (method*)<Module>.DecodePointer((void*)<Module>.__onexitbegin_app_domain);
			method* ptr2 = (method*)<Module>.DecodePointer((void*)<Module>.__onexitend_app_domain);
			try
			{
				if (ptr != -1L && ptr != null && ptr2 != null)
				{
					method* ptr3 = ptr;
					method* ptr4 = ptr2;
					for (;;)
					{
						do
						{
							ptr2 -= 8L / (long)sizeof(method);
						}
						while (ptr2 >= ptr && *(long*)ptr2 == <Module>.EncodePointer(null));
						if (ptr2 < ptr)
						{
							break;
						}
						method system.Void_u0020() = <Module>.DecodePointer(*(long*)ptr2);
						*(long*)ptr2 = <Module>.EncodePointer(null);
						calli(System.Void(), system.Void_u0020());
						method* ptr5 = (method*)<Module>.DecodePointer((void*)<Module>.__onexitbegin_app_domain);
						method* ptr6 = (method*)<Module>.DecodePointer((void*)<Module>.__onexitend_app_domain);
						if (ptr3 != ptr5 || ptr4 != ptr6)
						{
							ptr3 = ptr5;
							ptr = ptr5;
							ptr4 = ptr6;
							ptr2 = ptr6;
						}
					}
				}
			}
			finally
			{
				IntPtr hglobal = new IntPtr((void*)ptr);
				Marshal.FreeHGlobal(hglobal);
				<Module>.?A0xc2538164.__dealloc_global_lock();
			}
		}
	}

	// Token: 0x0600003F RID: 63
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	[DllImport("KERNEL32.dll")]
	public unsafe static extern void* DecodePointer(void* _Ptr);

	// Token: 0x06000040 RID: 64
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityCritical]
	[DllImport("KERNEL32.dll")]
	public unsafe static extern void* EncodePointer(void* _Ptr);

	// Token: 0x06000041 RID: 65 RVA: 0x00003208 File Offset: 0x00002608
	[DebuggerStepThrough]
	[SecurityCritical]
	internal unsafe static int _initterm_e(method* pfbegin, method* pfend)
	{
		int num = 0;
		if (pfbegin < pfend)
		{
			while (num == 0)
			{
				ulong num2 = (ulong)(*(long*)pfbegin);
				if (num2 != 0UL)
				{
					num = calli(System.Int32 modopt(System.Runtime.CompilerServices.CallConvCdecl)(), num2);
				}
				pfbegin += 8L / (long)sizeof(method);
				if (pfbegin >= pfend)
				{
					break;
				}
			}
		}
		return num;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00003238 File Offset: 0x00002638
	[DebuggerStepThrough]
	[SecurityCritical]
	internal unsafe static void _initterm(method* pfbegin, method* pfend)
	{
		if (pfbegin < pfend)
		{
			do
			{
				ulong num = (ulong)(*(long*)pfbegin);
				if (num != 0UL)
				{
					calli(System.Void modopt(System.Runtime.CompilerServices.CallConvCdecl)(), num);
				}
				pfbegin += 8L / (long)sizeof(method);
			}
			while (pfbegin < pfend);
		}
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00003260 File Offset: 0x00002660
	[DebuggerStepThrough]
	internal static ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
	{
		return typeof(ThisModule).Module.ModuleHandle;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000032B0 File Offset: 0x000026B0
	[SecurityCritical]
	[DebuggerStepThrough]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void _initterm_m(method* pfbegin, method* pfend)
	{
		if (pfbegin < pfend)
		{
			do
			{
				ulong num = (ulong)(*(long*)pfbegin);
				if (num != 0UL)
				{
					object obj = calli(System.Void modopt(System.Runtime.CompilerServices.IsConst)*(), <Module>.<CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(num));
				}
				pfbegin += 8L / (long)sizeof(method);
			}
			while (pfbegin < pfend);
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00003284 File Offset: 0x00002684
	[DebuggerStepThrough]
	[SecurityCritical]
	internal static method <CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(method methodToken)
	{
		return <Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle(methodToken).GetFunctionPointer().ToPointer();
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00001828 File Offset: 0x00000C28
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern uint mainCRTStartup();

	// Token: 0x06000047 RID: 71 RVA: 0x00003392 File Offset: 0x00002792
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal static extern int __CxxQueryExceptionSize();

	// Token: 0x06000048 RID: 72 RVA: 0x000033A4 File Offset: 0x000027A4
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxDetectRethrow(void*);

	// Token: 0x06000049 RID: 73 RVA: 0x000033AA File Offset: 0x000027AA
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal unsafe static extern void __CxxUnregisterExceptionObject(void*, int);

	// Token: 0x0600004A RID: 74 RVA: 0x00003398 File Offset: 0x00002798
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxExceptionFilter(void*, void*, int, void*);

	// Token: 0x0600004B RID: 75 RVA: 0x0000338C File Offset: 0x0000278C
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal static extern void Sleep(uint);

	// Token: 0x0600004C RID: 76 RVA: 0x0000339E File Offset: 0x0000279E
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __CxxRegisterExceptionObject(void*, void*);

	// Token: 0x0600004D RID: 77 RVA: 0x00001490 File Offset: 0x00000890
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal unsafe static extern int printf(sbyte*, __arglist);

	// Token: 0x0600004E RID: 78 RVA: 0x00002680 File Offset: 0x00001A80
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal unsafe static extern void* _getFiberPtrId();

	// Token: 0x0600004F RID: 79 RVA: 0x00003344 File Offset: 0x00002744
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal static extern void _cexit();

	// Token: 0x06000050 RID: 80 RVA: 0x000033B6 File Offset: 0x000027B6
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal static extern void abort();

	// Token: 0x06000051 RID: 81 RVA: 0x00001C68 File Offset: 0x00001068
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	internal static extern void __security_init_cookie();

	// Token: 0x06000052 RID: 82 RVA: 0x000033B0 File Offset: 0x000027B0
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __FrameUnwindFilter(_EXCEPTION_POINTERS*);

	// Token: 0x06000053 RID: 83 RVA: 0x0000337A File Offset: 0x0000277A
	[SuppressUnmanagedCodeSecurity]
	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged)]
	internal static extern void terminate();

	// Token: 0x04000001 RID: 1 RVA: 0x000059E0 File Offset: 0x000035E0
	internal static $ArrayType$$$BY0BB@$$CBD ??_C@_0BB@MGJNBIHF@HAX?5Shutdown?5?$DO?$DO?$DO?$AA@;

	// Token: 0x04000002 RID: 2 RVA: 0x000059F8 File Offset: 0x000035F8
	internal static $ArrayType$$$BY08$$CBD ??_C@_08JDGEANKE@GUARD?3?3?5?$AA@;

	// Token: 0x04000003 RID: 3 RVA: 0x000052B0 File Offset: 0x00002EB0
	internal static $ArrayType$$$BY06$$CBD ??_C@_06FHGPKNJN@?5?5ID?3?5?$AA@;

	// Token: 0x04000004 RID: 4 RVA: 0x000052B8 File Offset: 0x00002EB8
	internal static $ArrayType$$$BY08$$CBD ??_C@_08GNKCIICJ@OWNER?3?3?5?$AA@;

	// Token: 0x04000005 RID: 5 RVA: 0x000052C4 File Offset: 0x00002EC4
	internal static $ArrayType$$$BY06$$CBD ??_C@_06CKOGFMD@EDITOR?$AA@;

	// Token: 0x04000006 RID: 6 RVA: 0x000052D0 File Offset: 0x00002ED0
	internal static $ArrayType$$$BY07$$CBD ??_C@_07DPGPADFH@firefox?$AA@;

	// Token: 0x04000007 RID: 7 RVA: 0x000052D8 File Offset: 0x00002ED8
	internal static $ArrayType$$$BY06$$CBD ??_C@_06IELIGIKF@chrome?$AA@;

	// Token: 0x04000008 RID: 8 RVA: 0x000052E0 File Offset: 0x00002EE0
	internal static $ArrayType$$$BY0O@$$CBD ??_C@_0O@ENNPACOK@microsoftedge?$AA@;

	// Token: 0x04000009 RID: 9 RVA: 0x000052F0 File Offset: 0x00002EF0
	internal static $ArrayType$$$BY08$$CBD ??_C@_08NFOALPDJ@iexplore?$AA@;

	// Token: 0x0400000A RID: 10 RVA: 0x00005300 File Offset: 0x00002F00
	internal static $ArrayType$$$BY07$$CBD ??_C@_07MIJNKPCC@allinea?$AA@;

	// Token: 0x0400000B RID: 11 RVA: 0x00005308 File Offset: 0x00002F08
	internal static $ArrayType$$$BY06$$CBD ??_C@_06JNNFIAKD@aqtime?$AA@;

	// Token: 0x0400000C RID: 12 RVA: 0x00005310 File Offset: 0x00002F10
	internal static $ArrayType$$$BY05$$CBD ??_C@_05GHKBAFPA@cheat?$AA@;

	// Token: 0x0400000D RID: 13 RVA: 0x00005318 File Offset: 0x00002F18
	internal static $ArrayType$$$BY08$$CBD ??_C@_08EMMNFJCE@codeview?$AA@;

	// Token: 0x0400000E RID: 14 RVA: 0x00005324 File Offset: 0x00002F24
	internal static $ArrayType$$$BY05$$CBD ??_C@_05MENMHHE@crack?$AA@;

	// Token: 0x0400000F RID: 15 RVA: 0x00005330 File Offset: 0x00002F30
	internal static $ArrayType$$$BY09$$CBD ??_C@_09CGHBFIHO@automaded?$AA@;

	// Token: 0x04000010 RID: 16 RVA: 0x0000533C File Offset: 0x00002F3C
	internal static $ArrayType$$$BY03$$CBD ??_C@_03LBAKCJJ@dbg?$AA@;

	// Token: 0x04000011 RID: 17 RVA: 0x00005340 File Offset: 0x00002F40
	internal static $ArrayType$$$BY08$$CBD ??_C@_08BJECCCMA@debugger?$AA@;

	// Token: 0x04000012 RID: 18 RVA: 0x00005350 File Offset: 0x00002F50
	internal static $ArrayType$$$BY09$$CBD ??_C@_09KDMGIFFI@decompile?$AA@;

	// Token: 0x04000013 RID: 19 RVA: 0x00005360 File Offset: 0x00002F60
	internal static $ArrayType$$$BY07$$CBD ??_C@_07BOAOKBFF@dotpeek?$AA@;

	// Token: 0x04000014 RID: 20 RVA: 0x00005368 File Offset: 0x00002F68
	internal static $ArrayType$$$BY03$$CBD ??_C@_03MKFGENAL@edb?$AA@;

	// Token: 0x04000015 RID: 21 RVA: 0x00005370 File Offset: 0x00002F70
	internal static $ArrayType$$$BY07$$CBD ??_C@_07HGJOOLFL@eclipse?$AA@;

	// Token: 0x04000016 RID: 22 RVA: 0x00005378 File Offset: 0x00002F78
	internal static $ArrayType$$$BY06$$CBD ??_C@_06MOKEGKB@eztest?$AA@;

	// Token: 0x04000017 RID: 23 RVA: 0x00005380 File Offset: 0x00002F80
	internal static $ArrayType$$$BY06$$CBD ??_C@_06JBLDCNIO@fusion?$AA@;

	// Token: 0x04000018 RID: 24 RVA: 0x00005388 File Offset: 0x00002F88
	internal static $ArrayType$$$BY04$$CBD ??_C@_04NPJNGDBN@hack?$AA@;

	// Token: 0x04000019 RID: 25 RVA: 0x00005390 File Offset: 0x00002F90
	internal static $ArrayType$$$BY09$$CBD ??_C@_09PAPHEJPB@haxplorer?$AA@;

	// Token: 0x0400001A RID: 26 RVA: 0x000053A0 File Offset: 0x00002FA0
	internal static $ArrayType$$$BY08$$CBD ??_C@_08DPOFEOFK@injector?$AA@;

	// Token: 0x0400001B RID: 27 RVA: 0x000053B0 File Offset: 0x00002FB0
	internal static $ArrayType$$$BY07$$CBD ??_C@_07DMACCPDN@insight?$AA@;

	// Token: 0x0400001C RID: 28 RVA: 0x000053B8 File Offset: 0x00002FB8
	internal static $ArrayType$$$BY06$$CBD ??_C@_06ODCPKOPA@insure?$AA@;

	// Token: 0x0400001D RID: 29 RVA: 0x000053C0 File Offset: 0x00002FC0
	internal static $ArrayType$$$BY08$$CBD ??_C@_08LOKMNJMF@medicine?$AA@;

	// Token: 0x0400001E RID: 30 RVA: 0x000053D0 File Offset: 0x00002FD0
	internal static $ArrayType$$$BY0M@$$CBD ??_C@_0M@KBMNCKIM@monodevelop?$AA@;

	// Token: 0x0400001F RID: 31 RVA: 0x000053E0 File Offset: 0x00002FE0
	internal static $ArrayType$$$BY07$$CBD ??_C@_07MJDGOAGO@puncher?$AA@;

	// Token: 0x04000020 RID: 32 RVA: 0x000053E8 File Offset: 0x00002FE8
	internal static $ArrayType$$$BY09$$CBD ??_C@_09JONLLKLM@reflector?$AA@;

	// Token: 0x04000021 RID: 33 RVA: 0x000053F4 File Offset: 0x00002FF4
	internal static $ArrayType$$$BY03$$CBD ??_C@_03NDNIFHO@spy?$AA@;

	// Token: 0x04000022 RID: 34 RVA: 0x000053F8 File Offset: 0x00002FF8
	internal static $ArrayType$$$BY07$$CBD ??_C@_07BGFGCFLC@trainer?$AA@;

	// Token: 0x04000023 RID: 35 RVA: 0x00005400 File Offset: 0x00003000
	internal static $ArrayType$$$BY08$$CBD ??_C@_08JHFMAFEK@xpediter?$AA@;

	// Token: 0x04000024 RID: 36 RVA: 0x00005410 File Offset: 0x00003010
	internal static $ArrayType$$$BY07$$CBD ??_C@_07GALELMEM@isystem?$AA@;

	// Token: 0x04000025 RID: 37 RVA: 0x00005418 File Offset: 0x00003018
	internal static $ArrayType$$$BY07$$CBD ??_C@_07PGMGGLMB@ida?5pro?$AA@;

	// Token: 0x04000026 RID: 38 RVA: 0x00005420 File Offset: 0x00003020
	internal static $ArrayType$$$BY04$$CBD ??_C@_04JNOMKFD@jinx?$AA@;

	// Token: 0x04000027 RID: 39 RVA: 0x00005428 File Offset: 0x00003028
	internal static $ArrayType$$$BY05$$CBD ??_C@_05KNIOGNLP@jswat?$AA@;

	// Token: 0x04000028 RID: 40 RVA: 0x00005430 File Offset: 0x00003030
	internal static $ArrayType$$$BY04$$CBD ??_C@_04MPKLAMM@lldb?$AA@;

	// Token: 0x04000029 RID: 41 RVA: 0x00005438 File Offset: 0x00003038
	internal static $ArrayType$$$BY0BB@$$CBD ??_C@_0BB@IIHHIPPK@modular?5debugger?$AA@;

	// Token: 0x0400002A RID: 42 RVA: 0x0000544C File Offset: 0x0000304C
	internal static $ArrayType$$$BY06$$CBD ??_C@_06OJDICLGP@oliver?$AA@;

	// Token: 0x0400002B RID: 43 RVA: 0x00005458 File Offset: 0x00003058
	internal static $ArrayType$$$BY07$$CBD ??_C@_07IBFPHLPF@ollydbg?$AA@;

	// Token: 0x0400002C RID: 44 RVA: 0x00005460 File Offset: 0x00003060
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@OKGILNBM@omniscient?$AA@;

	// Token: 0x0400002D RID: 45 RVA: 0x00005470 File Offset: 0x00003070
	internal static $ArrayType$$$BY07$$CBD ??_C@_07GIDMKIBG@openpat?$AA@;

	// Token: 0x0400002E RID: 46 RVA: 0x00005478 File Offset: 0x00003078
	internal static $ArrayType$$$BY05$$CBD ??_C@_05LLKGHKLK@pgdbg?$AA@;

	// Token: 0x0400002F RID: 47 RVA: 0x00005480 File Offset: 0x00003080
	internal static $ArrayType$$$BY0BA@$$CBD ??_C@_0BA@CPJOFDIO@rational?5purify?$AA@;

	// Token: 0x04000030 RID: 48 RVA: 0x00005490 File Offset: 0x00003090
	internal static $ArrayType$$$BY03$$CBD ??_C@_03LPCEEFEI@sdb?$AA@;

	// Token: 0x04000031 RID: 49 RVA: 0x00005494 File Offset: 0x00003094
	internal static $ArrayType$$$BY05$$CBD ??_C@_05CGBANBOF@simon?$AA@;

	// Token: 0x04000032 RID: 50 RVA: 0x0000549C File Offset: 0x0000309C
	internal static $ArrayType$$$BY06$$CBD ??_C@_06IAPDOCLD@simmon?$AA@;

	// Token: 0x04000033 RID: 51 RVA: 0x000054A8 File Offset: 0x000030A8
	internal static $ArrayType$$$BY07$$CBD ??_C@_07DDGHCLD@softice?$AA@;

	// Token: 0x04000034 RID: 52 RVA: 0x000054B0 File Offset: 0x000030B0
	internal static $ArrayType$$$BY03$$CBD ??_C@_03EDNAKOHA@tcf?$AA@;

	// Token: 0x04000035 RID: 53 RVA: 0x000054B8 File Offset: 0x000030B8
	internal static $ArrayType$$$BY0M@$$CBD ??_C@_0M@OHPCBCIP@timemachine?$AA@;

	// Token: 0x04000036 RID: 54 RVA: 0x000054C8 File Offset: 0x000030C8
	internal static $ArrayType$$$BY09$$CBD ??_C@_09EDOKABI@totalview?$AA@;

	// Token: 0x04000037 RID: 55 RVA: 0x000054D8 File Offset: 0x000030D8
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@HKAENDEH@lauterbach?$AA@;

	// Token: 0x04000038 RID: 56 RVA: 0x000054E8 File Offset: 0x000030E8
	internal static $ArrayType$$$BY0P@$$CBD ??_C@_0P@FIMEANBI@turbo?5debugger?$AA@;

	// Token: 0x04000039 RID: 57 RVA: 0x000054F8 File Offset: 0x000030F8
	internal static $ArrayType$$$BY03$$CBD ??_C@_03NCLJDCCI@ups?$AA@;

	// Token: 0x0400003A RID: 58 RVA: 0x000054FC File Offset: 0x000030FC
	internal static $ArrayType$$$BY06$$CBD ??_C@_06PJNPONCG@undodb?$AA@;

	// Token: 0x0400003B RID: 59 RVA: 0x00005508 File Offset: 0x00003108
	internal static $ArrayType$$$BY08$$CBD ??_C@_08FJANKLPH@valgrind?$AA@;

	// Token: 0x0400003C RID: 60 RVA: 0x00005518 File Offset: 0x00003118
	internal static $ArrayType$$$BY08$$CBD ??_C@_08HGKBAPMN@vb?5watch?$AA@;

	// Token: 0x0400003D RID: 61 RVA: 0x00005528 File Offset: 0x00003128
	internal static $ArrayType$$$BY0BH@$$CBD ??_C@_0BH@LHCAAIMG@visual?5studio?5debugger?$AA@;

	// Token: 0x0400003E RID: 62 RVA: 0x00005540 File Offset: 0x00003140
	internal static $ArrayType$$$BY06$$CBD ??_C@_06JHAONLOA@windbg?$AA@;

	// Token: 0x0400003F RID: 63 RVA: 0x00005548 File Offset: 0x00003148
	internal static $ArrayType$$$BY06$$CBD ??_C@_06OODNMGEB@x64dbg?$AA@;

	// Token: 0x04000040 RID: 64 RVA: 0x00005550 File Offset: 0x00003150
	internal static $ArrayType$$$BY06$$CBD ??_C@_06JGAKGDOP@xdebug?$AA@;

	// Token: 0x04000041 RID: 65 RVA: 0x00005558 File Offset: 0x00003158
	internal static $ArrayType$$$BY08$$CBD ??_C@_08JALMPDFL@zerobugs?$AA@;

	// Token: 0x04000042 RID: 66 RVA: 0x00005564 File Offset: 0x00003164
	internal static $ArrayType$$$BY03$$CBD ??_C@_03HBDOPDAI@xdc?$AA@;

	// Token: 0x04000043 RID: 67 RVA: 0x00005568 File Offset: 0x00003168
	internal static $ArrayType$$$BY03$$CBD ??_C@_03CELAINOI@ddd?$AA@;

	// Token: 0x04000044 RID: 68 RVA: 0x0000556C File Offset: 0x0000316C
	internal static $ArrayType$$$BY03$$CBD ??_C@_03GAFPIFIA@gdb?$AA@;

	// Token: 0x04000045 RID: 69 RVA: 0x00005570 File Offset: 0x00003170
	internal static $ArrayType$$$BY07$$CBD ??_C@_07PGFKEIOM@affinic?$AA@;

	// Token: 0x04000046 RID: 70 RVA: 0x00005578 File Offset: 0x00003178
	internal static $ArrayType$$$BY05$$CBD ??_C@_05LKLPLMGD@emacs?$AA@;

	// Token: 0x04000047 RID: 71 RVA: 0x00005580 File Offset: 0x00003180
	internal static $ArrayType$$$BY04$$CBD ??_C@_04CJEMMME@kdbg?$AA@;

	// Token: 0x04000048 RID: 72 RVA: 0x00005588 File Offset: 0x00003188
	internal static $ArrayType$$$BY07$$CBD ??_C@_07LLDLBFBK@nemiver?$AA@;

	// Token: 0x04000049 RID: 73 RVA: 0x00005590 File Offset: 0x00003190
	internal static $ArrayType$$$BY05$$CBD ??_C@_05NOAKNPJN@xxgdb?$AA@;

	// Token: 0x0400004A RID: 74 RVA: 0x00005598 File Offset: 0x00003198
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@LFKAGCIN@qt?5creator?$AA@;

	// Token: 0x0400004B RID: 75 RVA: 0x000055A4 File Offset: 0x000031A4
	internal static $ArrayType$$$BY04$$CBD ??_C@_04FJKLKABM@cgdb?$AA@;

	// Token: 0x0400004C RID: 76 RVA: 0x000055B0 File Offset: 0x000031B0
	internal static $ArrayType$$$BY07$$CBD ??_C@_07FFPJAMJE@ccdebug?$AA@;

	// Token: 0x0400004D RID: 77 RVA: 0x000055B8 File Offset: 0x000031B8
	internal static $ArrayType$$$BY04$$CBD ??_C@_04FLIABCJC@padb?$AA@;

	// Token: 0x0400004E RID: 78 RVA: 0x000055C0 File Offset: 0x000031C0
	internal static $ArrayType$$$BY09$$CBD ??_C@_09EFFGBNOH@slickedit?$AA@;

	// Token: 0x0400004F RID: 79 RVA: 0x000055D0 File Offset: 0x000031D0
	internal static $ArrayType$$$BY08$$CBD ??_C@_08DINGPJD@codelite?$AA@;

	// Token: 0x04000050 RID: 80 RVA: 0x000055E0 File Offset: 0x000031E0
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@PFFILLMI@codeblocks?$AA@;

	// Token: 0x04000051 RID: 81 RVA: 0x000055F0 File Offset: 0x000031F0
	internal static $ArrayType$$$BY0P@$$CBD ??_C@_0P@OJJFOFOO@android?5studio?$AA@;

	// Token: 0x04000052 RID: 82 RVA: 0x00005600 File Offset: 0x00003200
	internal static $ArrayType$$$BY08$$CBD ??_C@_08GAKMKLDP@artmoney?$AA@;

	// Token: 0x04000053 RID: 83 RVA: 0x00005610 File Offset: 0x00003210
	internal static $ArrayType$$$BY0O@$$CBD ??_C@_0O@EALCMGPC@memory?5editor?$AA@;

	// Token: 0x04000054 RID: 84 RVA: 0x00005620 File Offset: 0x00003220
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@KCHHACNL@innerspace?$AA@;

	// Token: 0x04000055 RID: 85 RVA: 0x00005630 File Offset: 0x00003230
	internal static $ArrayType$$$BY09$$CBD ??_C@_09EMIHLPHB@crysearch?$AA@;

	// Token: 0x04000056 RID: 86 RVA: 0x00005640 File Offset: 0x00003240
	internal static $ArrayType$$$BY09$$CBD ??_C@_09KLPHOKKH@hookshark?$AA@;

	// Token: 0x04000057 RID: 87 RVA: 0x00005650 File Offset: 0x00003250
	internal static $ArrayType$$$BY09$$CBD ??_C@_09LJMJBGOP@wireshark?$AA@;

	// Token: 0x04000058 RID: 88 RVA: 0x00005660 File Offset: 0x00003260
	internal static $ArrayType$$$BY07$$CBD ??_C@_07FMNIEEOD@tcpdump?$AA@;

	// Token: 0x04000059 RID: 89 RVA: 0x00005668 File Offset: 0x00003268
	internal static $ArrayType$$$BY06$$CBD ??_C@_06MGKEIKNH@netcat?$AA@;

	// Token: 0x0400005A RID: 90 RVA: 0x00005670 File Offset: 0x00003270
	internal static $ArrayType$$$BY0BA@$$CBD ??_C@_0BA@DCBHEFNB@network?5monitor?$AA@;

	// Token: 0x0400005B RID: 91 RVA: 0x00005680 File Offset: 0x00003280
	internal static $ArrayType$$$BY08$$CBD ??_C@_08KLKNOJKC@ettercap?$AA@;

	// Token: 0x0400005C RID: 92 RVA: 0x00005690 File Offset: 0x00003290
	internal static $ArrayType$$$BY07$$CBD ??_C@_07JFAMJCMD@nethogs?$AA@;

	// Token: 0x0400005D RID: 93 RVA: 0x00005698 File Offset: 0x00003298
	internal static $ArrayType$$$BY05$$CBD ??_C@_05DEIPBGCH@scapy?$AA@;

	// Token: 0x0400005E RID: 94 RVA: 0x000056A0 File Offset: 0x000032A0
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@PIBEDOHE@cloudshark?$AA@;

	// Token: 0x0400005F RID: 95 RVA: 0x000056B0 File Offset: 0x000032B0
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@PIIMHHGK@smartsniff?$AA@;

	// Token: 0x04000060 RID: 96 RVA: 0x000056C0 File Offset: 0x000032C0
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@FGHIIOEO@packetyzer?$AA@;

	// Token: 0x04000061 RID: 97 RVA: 0x000056D0 File Offset: 0x000032D0
	internal static $ArrayType$$$BY09$$CBD ??_C@_09FAICFBHI@iwscanner?$AA@;

	// Token: 0x04000062 RID: 98 RVA: 0x000056E0 File Offset: 0x000032E0
	internal static $ArrayType$$$BY0M@$$CBD ??_C@_0M@JIKNKIPJ@intercepter?$AA@;

	// Token: 0x04000063 RID: 99 RVA: 0x000056F0 File Offset: 0x000032F0
	internal static $ArrayType$$$BY07$$CBD ??_C@_07CJNKALBI@apptalk?$AA@;

	// Token: 0x04000064 RID: 100 RVA: 0x000056F8 File Offset: 0x000032F8
	internal static $ArrayType$$$BY06$$CBD ??_C@_06PELCEBLK@sysdig?$AA@;

	// Token: 0x04000065 RID: 101 RVA: 0x00005700 File Offset: 0x00003300
	internal static $ArrayType$$$BY07$$CBD ??_C@_07EHMMENDP@tcpflow?$AA@;

	// Token: 0x04000066 RID: 102 RVA: 0x00005708 File Offset: 0x00003308
	internal static $ArrayType$$$BY08$$CBD ??_C@_08JLCKHHFD@ostinato?$AA@;

	// Token: 0x04000067 RID: 103 RVA: 0x00005718 File Offset: 0x00003318
	internal static $ArrayType$$$BY08$$CBD ??_C@_08MIMPBNJJ@ethereal?$AA@;

	// Token: 0x04000068 RID: 104 RVA: 0x00005728 File Offset: 0x00003328
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@OBGFOOMC@tcplogview?$AA@;

	// Token: 0x04000069 RID: 105 RVA: 0x00005738 File Offset: 0x00003338
	internal static $ArrayType$$$BY0M@$$CBD ??_C@_0M@NIGIHDBK@languardian?$AA@;

	// Token: 0x0400006A RID: 106 RVA: 0x00005748 File Offset: 0x00003348
	internal static $ArrayType$$$BY0BD@$$CBD ??_C@_0BD@CNLDOHKD@network?5diagnostic?$AA@;

	// Token: 0x0400006B RID: 107 RVA: 0x0000575C File Offset: 0x0000335C
	internal static $ArrayType$$$BY06$$CBD ??_C@_06NEEEMMMJ@psping?$AA@;

	// Token: 0x0400006C RID: 108 RVA: 0x00005768 File Offset: 0x00003368
	internal static $ArrayType$$$BY0BB@$$CBD ??_C@_0BB@LNGEMJF@message?5analyzer?$AA@;

	// Token: 0x0400006D RID: 109 RVA: 0x00005780 File Offset: 0x00003380
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@MDAFGAAM@microoplap?$AA@;

	// Token: 0x0400006E RID: 110 RVA: 0x00005790 File Offset: 0x00003390
	internal static $ArrayType$$$BY08$$CBD ??_C@_08GOMMFNBI@appscope?$AA@;

	// Token: 0x0400006F RID: 111 RVA: 0x000057A0 File Offset: 0x000033A0
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@COBIEBOF@url?5helper?$AA@;

	// Token: 0x04000070 RID: 112 RVA: 0x000057B0 File Offset: 0x000033B0
	internal static $ArrayType$$$BY0O@$$CBD ??_C@_0O@IFCJKCEF@packet?5peeper?$AA@;

	// Token: 0x04000071 RID: 113 RVA: 0x000057C0 File Offset: 0x000033C0
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@IIHCNFBN@010?5editor?$AA@;

	// Token: 0x04000072 RID: 114 RVA: 0x000057CC File Offset: 0x000033CC
	internal static $ArrayType$$$BY03$$CBD ??_C@_03HHFCOJBK@1fh?$AA@;

	// Token: 0x04000073 RID: 115 RVA: 0x000057D0 File Offset: 0x000033D0
	internal static $ArrayType$$$BY03$$CBD ??_C@_03HLFKGIEE@hxd?$AA@;

	// Token: 0x04000074 RID: 116 RVA: 0x000057D8 File Offset: 0x000033D8
	internal static $ArrayType$$$BY07$$CBD ??_C@_07BDIEMLHL@aptedit?$AA@;

	// Token: 0x04000075 RID: 117 RVA: 0x000057E0 File Offset: 0x000033E0
	internal static $ArrayType$$$BY03$$CBD ??_C@_03BPEJBGIP@axe?$AA@;

	// Token: 0x04000076 RID: 118 RVA: 0x000057E4 File Offset: 0x000033E4
	internal static $ArrayType$$$BY06$$CBD ??_C@_06FBGDLJOJ@avihex?$AA@;

	// Token: 0x04000077 RID: 119 RVA: 0x000057F0 File Offset: 0x000033F0
	internal static $ArrayType$$$BY09$$CBD ??_C@_09NDBCAGFD@hexeditor?$AA@;

	// Token: 0x04000078 RID: 120 RVA: 0x000057FC File Offset: 0x000033FC
	internal static $ArrayType$$$BY04$$CBD ??_C@_04OGKHFEJJ@beav?$AA@;

	// Token: 0x04000079 RID: 121 RVA: 0x00005804 File Offset: 0x00003404
	internal static $ArrayType$$$BY04$$CBD ??_C@_04JFHNOHMD@beye?$AA@;

	// Token: 0x0400007A RID: 122 RVA: 0x00005810 File Offset: 0x00003410
	internal static $ArrayType$$$BY0O@$$CBD ??_C@_0O@JJAOGALN@binary?5viewer?$AA@;

	// Token: 0x0400007B RID: 123 RVA: 0x00005820 File Offset: 0x00003420
	internal static $ArrayType$$$BY03$$CBD ??_C@_03KLNHNLGH@bvi?$AA@;

	// Token: 0x0400007C RID: 124 RVA: 0x00005828 File Offset: 0x00003428
	internal static $ArrayType$$$BY0N@$$CBD ??_C@_0N@PKPMNHNE@cheat?5engine?$AA@;

	// Token: 0x0400007D RID: 125 RVA: 0x00005838 File Offset: 0x00003438
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@KPMADMOF@hex?5viewer?$AA@;

	// Token: 0x0400007E RID: 126 RVA: 0x00005848 File Offset: 0x00003448
	internal static $ArrayType$$$BY0L@$$CBD ??_C@_0L@CIJAEFEK@cignus?5hex?$AA@;

	// Token: 0x0400007F RID: 127 RVA: 0x00005854 File Offset: 0x00003454
	internal static $ArrayType$$$BY04$$CBD ??_C@_04CAHPMLG@dhex?$AA@;

	// Token: 0x04000080 RID: 128 RVA: 0x00005860 File Offset: 0x00003460
	internal static $ArrayType$$$BY07$$CBD ??_C@_07HNDNFBAK@editpad?$AA@;

	// Token: 0x04000081 RID: 129 RVA: 0x00005868 File Offset: 0x00003468
	internal static $ArrayType$$$BY07$$CBD ??_C@_07IPALFDBC@febooti?$AA@;

	// Token: 0x04000082 RID: 130 RVA: 0x00005870 File Offset: 0x00003470
	internal static $ArrayType$$$BY07$$CBD ??_C@_07GLMLPAF@flexhex?$AA@;

	// Token: 0x04000083 RID: 131 RVA: 0x00005878 File Offset: 0x00003478
	internal static $ArrayType$$$BY05$$CBD ??_C@_05KCJNHJDA@frhed?$AA@;

	// Token: 0x04000084 RID: 132 RVA: 0x00005880 File Offset: 0x00003480
	internal static $ArrayType$$$BY04$$CBD ??_C@_04EFKHIGGG@ghex?$AA@;

	// Token: 0x04000085 RID: 133 RVA: 0x00005888 File Offset: 0x00003488
	internal static $ArrayType$$$BY05$$CBD ??_C@_05EDFJAHFP@hedit?$AA@;

	// Token: 0x04000086 RID: 134 RVA: 0x00005890 File Offset: 0x00003490
	internal static $ArrayType$$$BY09$$CBD ??_C@_09JFINHOJJ@hex?9works?$AA@;

	// Token: 0x04000087 RID: 135 RVA: 0x000058A0 File Offset: 0x000034A0
	internal static $ArrayType$$$BY08$$CBD ??_C@_08IJJIMLMJ@hexcurse?$AA@;

	// Token: 0x04000088 RID: 136 RVA: 0x000058B0 File Offset: 0x000034B0
	internal static $ArrayType$$$BY08$$CBD ??_C@_08EFJAAKM@hexditor?$AA@;

	// Token: 0x04000089 RID: 137 RVA: 0x000058BC File Offset: 0x000034BC
	internal static $ArrayType$$$BY06$$CBD ??_C@_06PDEADLON@hexdit?$AA@;

	// Token: 0x0400008A RID: 138 RVA: 0x000058C4 File Offset: 0x000034C4
	internal static $ArrayType$$$BY05$$CBD ??_C@_05BKEOAEEN@hexed?$AA@;

	// Token: 0x0400008B RID: 139 RVA: 0x000058D0 File Offset: 0x000034D0
	internal static $ArrayType$$$BY08$$CBD ??_C@_08FHKOCJHM@hex?5edit?$AA@;

	// Token: 0x0400008C RID: 140 RVA: 0x000058E0 File Offset: 0x000034E0
	internal static $ArrayType$$$BY09$$CBD ??_C@_09HNBGBCJM@hex?5fiend?$AA@;

	// Token: 0x0400008D RID: 141 RVA: 0x000058F0 File Offset: 0x000034F0
	internal static $ArrayType$$$BY09$$CBD ??_C@_09IFFJAEIA@hexinator?$AA@;

	// Token: 0x0400008E RID: 142 RVA: 0x000058FC File Offset: 0x000034FC
	internal static $ArrayType$$$BY05$$CBD ??_C@_05FJJGOPHI@hexit?$AA@;

	// Token: 0x0400008F RID: 143 RVA: 0x00005908 File Offset: 0x00003508
	internal static $ArrayType$$$BY09$$CBD ??_C@_09KNBLBIPN@hexplorer?$AA@;

	// Token: 0x04000090 RID: 144 RVA: 0x00005918 File Offset: 0x00003518
	internal static $ArrayType$$$BY08$$CBD ??_C@_08BGNCBOJ@hexprobe?$AA@;

	// Token: 0x04000091 RID: 145 RVA: 0x00005928 File Offset: 0x00003528
	internal static $ArrayType$$$BY0N@$$CBD ??_C@_0N@LHKPIJLI@hex?5workshop?$AA@;

	// Token: 0x04000092 RID: 146 RVA: 0x00005938 File Offset: 0x00003538
	internal static $ArrayType$$$BY04$$CBD ??_C@_04PINDGKBN@hiew?$AA@;

	// Token: 0x04000093 RID: 147 RVA: 0x00005940 File Offset: 0x00003540
	internal static $ArrayType$$$BY09$$CBD ??_C@_09OOGKLIBC@ht?5editor?$AA@;

	// Token: 0x04000094 RID: 148 RVA: 0x0000594C File Offset: 0x0000354C
	internal static $ArrayType$$$BY06$$CBD ??_C@_06FCOKDIEA@okteta?$AA@;

	// Token: 0x04000095 RID: 149 RVA: 0x00005954 File Offset: 0x00003554
	internal static $ArrayType$$$BY04$$CBD ??_C@_04DGLAOKHJ@shed?$AA@;

	// Token: 0x04000096 RID: 150 RVA: 0x00005960 File Offset: 0x00003560
	internal static $ArrayType$$$BY08$$CBD ??_C@_08HAPPHCID@synalyze?$AA@;

	// Token: 0x04000097 RID: 151 RVA: 0x0000596C File Offset: 0x0000356C
	internal static $ArrayType$$$BY05$$CBD ??_C@_05GNGLBJK@hexer?$AA@;

	// Token: 0x04000098 RID: 152 RVA: 0x00005978 File Offset: 0x00003578
	internal static $ArrayType$$$BY08$$CBD ??_C@_08CCMIEMGK@turbohex?$AA@;

	// Token: 0x04000099 RID: 153 RVA: 0x00005984 File Offset: 0x00003584
	internal static $ArrayType$$$BY05$$CBD ??_C@_05HKIFGELE@vedit?$AA@;

	// Token: 0x0400009A RID: 154 RVA: 0x00005990 File Offset: 0x00003590
	internal static $ArrayType$$$BY09$$CBD ??_C@_09MPMEPNEG@ultraedit?$AA@;

	// Token: 0x0400009B RID: 155 RVA: 0x0000599C File Offset: 0x0000359C
	internal static $ArrayType$$$BY06$$CBD ??_C@_06KHPPFBDJ@webhex?$AA@;

	// Token: 0x0400009C RID: 156 RVA: 0x000059A4 File Offset: 0x000035A4
	internal static $ArrayType$$$BY06$$CBD ??_C@_06BFMNHMED@winhex?$AA@;

	// Token: 0x0400009D RID: 157 RVA: 0x000059AC File Offset: 0x000035AC
	internal static $ArrayType$$$BY05$$CBD ??_C@_05FCKNHDKO@xvi32?$AA@;

	// Token: 0x0400009E RID: 158 RVA: 0x000059B4 File Offset: 0x000035B4
	internal static $ArrayType$$$BY04$$CBD ??_C@_04JFCDJPOO@qiew?$AA@;

	// Token: 0x0400009F RID: 159 RVA: 0x000059C0 File Offset: 0x000035C0
	internal static $ArrayType$$$BY0N@$$CBD ??_C@_0N@LPFCFO@cff?5explorer?$AA@;

	// Token: 0x040000A0 RID: 160 RVA: 0x000059D0 File Offset: 0x000035D0
	internal static $ArrayType$$$BY0O@$$CBD ??_C@_0O@HAMIJEEG@memory?5viewer?$AA@;

	// Token: 0x040000A1 RID: 161 RVA: 0x00005BF2 File Offset: 0x000037F2
	internal static $ArrayType$$$BY00$$CBD ??_C@_00CNPNBAHC@?$AA@;

	// Token: 0x040000A2 RID: 162 RVA: 0x00005A10 File Offset: 0x00003610
	internal static $ArrayType$$$BY0FA@$$CBD ??_C@_0FA@ECMAOMMM@?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1@;

	// Token: 0x040000A3 RID: 163 RVA: 0x00005A60 File Offset: 0x00003660
	internal static $ArrayType$$$BY0FA@$$CBD ??_C@_0FA@KLHKMFNP@?1?1?5?5SCUE4?5Plugin?5for?5Unreal?5Engi@;

	// Token: 0x040000A4 RID: 164 RVA: 0x00005AB0 File Offset: 0x000036B0
	internal static $ArrayType$$$BY0FA@$$CBD ??_C@_0FA@HPDDPAIA@?1?1?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5?5@;

	// Token: 0x040000A5 RID: 165 RVA: 0x00005B00 File Offset: 0x00003700
	internal static $ArrayType$$$BY0FA@$$CBD ??_C@_0FA@CMBFEEKM@?1?1?5?5?$CIC?$CJ?5Bruno?4Xavier?4Leite?52016?5@;

	// Token: 0x040000A6 RID: 166 RVA: 0x00005B50 File Offset: 0x00003750
	internal static $ArrayType$$$BY0FA@$$CBD ??_C@_0FA@FLDPGIOG@?1?1?5?5bruno_xavier_?$EAmsn?4com?5?5?5?5?5?5?5@;

	// Token: 0x040000A7 RID: 167 RVA: 0x00005BA0 File Offset: 0x000037A0
	internal static $ArrayType$$$BY0FA@$$CBD ??_C@_0FA@KIPPIFBD@?1?1?5?5http?3?1?1brunoxavierleite?4com?5@;

	// Token: 0x040000A8 RID: 168 RVA: 0x00005BF0 File Offset: 0x000037F0
	internal static $ArrayType$$$BY01$$CBD ??_C@_01EEMJAFIK@?6?$AA@;

	// Token: 0x040000A9 RID: 169 RVA: 0x0000E018 File Offset: 0x0000B618
	internal static $ArrayType$$$BY03PEBD TrustedProcesses;

	// Token: 0x040000AA RID: 170 RVA: 0x0000E000 File Offset: 0x0000B600
	internal unsafe static sbyte* CtoS2;

	// Token: 0x040000AB RID: 171 RVA: 0x0000E040 File Offset: 0x0000B640
	internal static $ArrayType$$$BY0JK@PEBD Keyword;

	// Token: 0x040000AC RID: 172 RVA: 0x0000E038 File Offset: 0x0000B638
	internal static int LOOP;

	// Token: 0x040000AD RID: 173 RVA: 0x0000E518 File Offset: 0x0000BB18
	internal unsafe static sbyte* CtoS1;

	// Token: 0x040000AE RID: 174 RVA: 0x0000E510 File Offset: 0x0000BB10
	internal unsafe static sbyte* HAX;

	// Token: 0x040000AF RID: 175 RVA: 0x0000E010 File Offset: 0x0000B610
	internal unsafe static sbyte* CtoS4;

	// Token: 0x040000B0 RID: 176 RVA: 0x0000E008 File Offset: 0x0000B608
	internal unsafe static sbyte* CtoS3;

	// Token: 0x040000B1 RID: 177 RVA: 0x0000E520 File Offset: 0x0000BB20
	public static method __m2mep@?main@@$$HYAHHQEAPEAD@Z;

	// Token: 0x040000B2 RID: 178 RVA: 0x00006098 File Offset: 0x00003C98
	internal static __s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x040000B3 RID: 179 RVA: 0x00006088 File Offset: 0x00003C88
	internal static __s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x040000B4 RID: 180
	[FixedAddressValueType]
	internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x040000B5 RID: 181 RVA: 0x00005250 File Offset: 0x00002E50
	internal static method ?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZEA;

	// Token: 0x040000B6 RID: 182
	[FixedAddressValueType]
	internal static Progress ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A;

	// Token: 0x040000B7 RID: 183 RVA: 0x00005268 File Offset: 0x00002E68
	internal static method ?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZEA;

	// Token: 0x040000B8 RID: 184 RVA: 0x000060A8 File Offset: 0x00003CA8
	internal static __s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x040000B9 RID: 185 RVA: 0x000060B8 File Offset: 0x00003CB8
	internal static __s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x040000BA RID: 186
	[FixedAddressValueType]
	internal static Progress ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A;

	// Token: 0x040000BB RID: 187 RVA: 0x0000EBA4 File Offset: 0x0000C1A4
	internal static bool ?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x040000BC RID: 188 RVA: 0x0000E574 File Offset: 0x0000BB74
	internal static TriBool ?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A;

	// Token: 0x040000BD RID: 189 RVA: 0x0000EBA7 File Offset: 0x0000C1A7
	internal static bool ?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x040000BE RID: 190 RVA: 0x0000EBA0 File Offset: 0x0000C1A0
	internal static int ?Count@AllDomains@<CrtImplementationDetails>@@2HA;

	// Token: 0x040000BF RID: 191
	[FixedAddressValueType]
	internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x040000C0 RID: 192 RVA: 0x0000EBA6 File Offset: 0x0000C1A6
	internal static bool ?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x040000C1 RID: 193
	[FixedAddressValueType]
	internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;

	// Token: 0x040000C2 RID: 194
	[FixedAddressValueType]
	internal static Progress ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A;

	// Token: 0x040000C3 RID: 195 RVA: 0x0000EBA5 File Offset: 0x0000C1A5
	internal static bool ?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x040000C4 RID: 196
	[FixedAddressValueType]
	internal static Progress ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4Progress@2@A;

	// Token: 0x040000C5 RID: 197 RVA: 0x0000E570 File Offset: 0x0000BB70
	internal static TriBool ?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4TriBool@2@A;

	// Token: 0x040000C6 RID: 198 RVA: 0x00005290 File Offset: 0x00002E90
	internal static $ArrayType$$$BY00Q6MPEBXXZ __xc_mp_z;

	// Token: 0x040000C7 RID: 199 RVA: 0x000052A0 File Offset: 0x00002EA0
	internal static $ArrayType$$$BY00Q6MPEBXXZ __xi_vt_z;

	// Token: 0x040000C8 RID: 200 RVA: 0x00005270 File Offset: 0x00002E70
	internal static method ?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZEA;

	// Token: 0x040000C9 RID: 201 RVA: 0x00005240 File Offset: 0x00002E40
	internal static $ArrayType$$$BY00Q6MPEBXXZ __xc_ma_a;

	// Token: 0x040000CA RID: 202 RVA: 0x00005280 File Offset: 0x00002E80
	internal static $ArrayType$$$BY00Q6MPEBXXZ __xc_ma_z;

	// Token: 0x040000CB RID: 203 RVA: 0x00005278 File Offset: 0x00002E78
	internal static method ?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZEA;

	// Token: 0x040000CC RID: 204 RVA: 0x00005298 File Offset: 0x00002E98
	internal static $ArrayType$$$BY00Q6MPEBXXZ __xi_vt_a;

	// Token: 0x040000CD RID: 205 RVA: 0x00005248 File Offset: 0x00002E48
	internal static method ?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZEA;

	// Token: 0x040000CE RID: 206 RVA: 0x00005288 File Offset: 0x00002E88
	internal static $ArrayType$$$BY00Q6MPEBXXZ __xc_mp_a;

	// Token: 0x040000CF RID: 207 RVA: 0x00005260 File Offset: 0x00002E60
	internal static method ?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZEA;

	// Token: 0x040000D0 RID: 208 RVA: 0x00005258 File Offset: 0x00002E58
	internal static method ?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZEA;

	// Token: 0x040000D1 RID: 209 RVA: 0x0000E578 File Offset: 0x0000BB78
	public static method __m2mep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCAJPEAX@Z;

	// Token: 0x040000D2 RID: 210 RVA: 0x0000E588 File Offset: 0x0000BB88
	public static method __m2mep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCAJPEAX@Z;

	// Token: 0x040000D3 RID: 211 RVA: 0x000060C8 File Offset: 0x00003CC8
	public unsafe static int** __unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCAJPEAX@Z;

	// Token: 0x040000D4 RID: 212 RVA: 0x000060D0 File Offset: 0x00003CD0
	public unsafe static int** __unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCAJPEAX@Z;

	// Token: 0x040000D5 RID: 213 RVA: 0x0000ECE0 File Offset: 0x0000C2E0
	internal unsafe static method* __onexitbegin_m;

	// Token: 0x040000D6 RID: 214 RVA: 0x0000ECF0 File Offset: 0x0000C2F0
	internal static ulong __exit_list_size;

	// Token: 0x040000D7 RID: 215
	[FixedAddressValueType]
	internal unsafe static method* __onexitend_app_domain;

	// Token: 0x040000D8 RID: 216
	[FixedAddressValueType]
	internal unsafe static void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PEAXEA;

	// Token: 0x040000D9 RID: 217
	[FixedAddressValueType]
	internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;

	// Token: 0x040000DA RID: 218 RVA: 0x0000ECE8 File Offset: 0x0000C2E8
	internal unsafe static method* __onexitend_m;

	// Token: 0x040000DB RID: 219
	[FixedAddressValueType]
	internal static ulong __exit_list_size_app_domain;

	// Token: 0x040000DC RID: 220
	[FixedAddressValueType]
	internal unsafe static method* __onexitbegin_app_domain;

	// Token: 0x040000DD RID: 221 RVA: 0x00005218 File Offset: 0x00002E18
	internal static $ArrayType$$$BY0A@P6AHXZ __xi_z;

	// Token: 0x040000DE RID: 222 RVA: 0x0000EB38 File Offset: 0x0000C138
	internal static __scrt_native_startup_state __scrt_current_native_startup_state;

	// Token: 0x040000DF RID: 223 RVA: 0x0000EB40 File Offset: 0x0000C140
	internal unsafe static void* __scrt_native_startup_lock;

	// Token: 0x040000E0 RID: 224 RVA: 0x000051E8 File Offset: 0x00002DE8
	internal static $ArrayType$$$BY0A@P6AXXZ __xc_a;

	// Token: 0x040000E1 RID: 225 RVA: 0x00005200 File Offset: 0x00002E00
	internal static $ArrayType$$$BY0A@P6AHXZ __xi_a;

	// Token: 0x040000E2 RID: 226 RVA: 0x0000E554 File Offset: 0x0000BB54
	internal static uint __scrt_native_dllmain_reason;

	// Token: 0x040000E3 RID: 227 RVA: 0x000051F8 File Offset: 0x00002DF8
	internal static $ArrayType$$$BY0A@P6AXXZ __xc_z;
}
