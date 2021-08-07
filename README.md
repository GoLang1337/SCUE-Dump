# SCUE-Dump

Check -Module-.cs for most of detections

- Process Detections
```csharp
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
  
 
 - Process strings detections

```csharp
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
