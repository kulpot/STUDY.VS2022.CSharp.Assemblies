﻿using System;

//ref link:https://www.youtube.com/watch?v=axTcf8r2kh8&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt
// Assemblies - like .dll, .exe
// .NET C#  - does not care/know what other languages it generates

// cmd inputs - dir, cd, cls - clear screen, type DIRNAMEHERE, csc - C# Compiler, vbc - visaul basic compiler, ilasm - is Intermediate Language Assembly, dir *.dll - list all dll only,



class MainClass
{
    static void Main()
    {
        MeCSharpClass.MeCSharpMethod();
        MeIlClass.MeIlMethod();
        MeVbClass.MeVbMethod();
    }
}

//public class MeCSharpClass
//{
//    public static void MeCSharpMethod()
//    {
//        Console.WriteLine("Helllllloooooo from C#");
//    }
//}



// ----------- Generate a .NET level of C#, VB, MSIL  ------------------------------

/*  cmd.exe
 *  
C:\Users\sunny\source\repos\Assemblies\Assemblies>type Program.cs
∩╗┐using System;

//ref link:https://www.youtube.com/watch?v=axTcf8r2kh8&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt
// Assemblies - like .dll, .exe
// .NET C# Programmer -

// cmd - dir, cd, cls - clear screen,

//class MainClass
//{
//    static void Main()
//    {
//
//    }
//}

public class MeCSharpClass
{
    public static void MeCSharpMethod()
    {
        Console.WriteLine("Helllllloooooo from C#");
    }
}
C:\Users\sunny\source\repos\Assemblies\Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assemblies\Assemblies

19/09/2023  10:16 pm    <DIR>          .
19/09/2023  10:16 pm    <DIR>          ..
19/09/2023  10:08 pm               189 App.config
19/09/2023  10:08 pm             2,370 Assemblies.csproj
19/09/2023  10:08 pm    <DIR>          bin
19/09/2023  10:08 pm    <DIR>          obj
19/09/2023  10:16 pm               438 Program.cs
19/09/2023  10:08 pm    <DIR>          Properties
               3 File(s)          2,997 bytes
               5 Dir(s)  490,297,114,624 bytes free

C:\Users\sunny\source\repos\Assemblies\Assemblies>csc /target:library /out:MeCSharpAssembly.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\Assemblies\Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assemblies\Assemblies

19/09/2023  10:19 pm    <DIR>          .
19/09/2023  10:19 pm    <DIR>          ..
19/09/2023  10:08 pm               189 App.config
19/09/2023  10:08 pm             2,370 Assemblies.csproj
19/09/2023  10:08 pm    <DIR>          bin
19/09/2023  10:19 pm             3,584 MeCSharpAssembly.dll
19/09/2023  10:08 pm    <DIR>          obj
19/09/2023  10:16 pm               438 Program.cs
19/09/2023  10:08 pm    <DIR>          Properties
               4 File(s)          6,581 bytes
               5 Dir(s)  490,298,810,368 bytes free

---------------------------------VISUAL BASIC------------------------

C:\Users\sunny\source\repos\Assemblies\Assemblies>notepad MeVb.vb
-----------NOTEPAD : VB -------------------------------------------------
Public Class MeVbClass
	Shared Sub MeVbMethod()
		Console.WriteLine("Hello from Visual Basic")
	End Sub
End Class

--------------------------------------------------------------------
C:\Users\sunny\source\repos\Assemblies\Assemblies>type MeVb.vb
Public Class MeVbClass
        Shared Sub MeVbMethod()
                Console.WriteLine("Hello from Visual Basic")
        End Sub
End Class

C:\Users\sunny\source\repos\Assemblies\Assemblies>vbc /t:library /out:MeVbAssembly.dll MeVb.vb
Microsoft (R) Visual Basic Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\Assemblies\Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assemblies\Assemblies

19/09/2023  10:32 pm    <DIR>          .
19/09/2023  10:32 pm    <DIR>          ..
19/09/2023  10:08 pm               189 App.config
19/09/2023  10:08 pm             2,370 Assemblies.csproj
19/09/2023  10:08 pm    <DIR>          bin
19/09/2023  10:19 pm             3,584 MeCSharpAssembly.dll
19/09/2023  10:26 pm               117 MeVb.vb
19/09/2023  10:32 pm             6,144 MeVbAssembly.dll
19/09/2023  10:08 pm    <DIR>          obj
19/09/2023  10:31 pm             3,295 Program.cs
19/09/2023  10:08 pm    <DIR>          Properties
               6 File(s)         15,699 bytes
               5 Dir(s)  490,292,830,208 bytes free

--------------------------------- MSIL ------------------------

C:\Users\sunny\source\repos\Assemblies\Assemblies>notepad MeIl.il

C:\Users\sunny\source\repos\Assemblies\Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assemblies\Assemblies

19/09/2023  10:35 pm    <DIR>          .
19/09/2023  10:35 pm    <DIR>          ..
19/09/2023  10:08 pm               189 App.config
19/09/2023  10:08 pm             2,370 Assemblies.csproj
19/09/2023  10:08 pm    <DIR>          bin
19/09/2023  10:19 pm             3,584 MeCSharpAssembly.dll
19/09/2023  10:38 pm               270 MeIl.il
19/09/2023  10:26 pm               117 MeVb.vb
19/09/2023  10:32 pm             6,144 MeVbAssembly.dll
19/09/2023  10:08 pm    <DIR>          obj
19/09/2023  10:35 pm             4,494 Program.cs
19/09/2023  10:08 pm    <DIR>          Properties
               7 File(s)         17,168 bytes
               5 Dir(s)  490,292,801,536 bytes free

C:\Users\sunny\source\repos\Assemblies\Assemblies>type MeIl.il
.assembly MeILAssembly {}

.assembly extern mscorlib {}

.class public MeIlClass extends [mscorlib]System.Object {
        .method public static void MeIlMethod() cil managed {
                ldstr "howdy from IL"
                call void [mscorlib]System.Console::WriteLine(string)
                ret
        }
}

C:\Users\sunny\source\repos\Assemblies\Assemblies>ilasm /DLL /OUT:MeILAssembly.dll MeIl.il
//---------------------ilasm - is Intermediate Language Assembly ------//

Microsoft (R) .NET Framework IL Assembler.  Version 4.8.9105.0
Copyright (c) Microsoft Corporation.  All rights reserved.
Assembling 'MeIl.il'  to DLL --> 'MeILAssembly.dll'
Source file is ANSI

Assembled method MeIlClass::MeIlMethod
Creating PE file

Emitting classes:
Class 1:        MeIlClass

Emitting fields and methods:
Global
Class 1 Methods: 1;

Emitting events and properties:
Global
Class 1
Writing PE file
Operation completed successfully

C:\Users\sunny\source\repos\Assemblies\Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assemblies\Assemblies

19/09/2023  10:42 pm    <DIR>          .
19/09/2023  10:42 pm    <DIR>          ..
19/09/2023  10:08 pm               189 App.config
19/09/2023  10:08 pm             2,370 Assemblies.csproj
19/09/2023  10:08 pm    <DIR>          bin
19/09/2023  10:19 pm             3,584 MeCSharpAssembly.dll
19/09/2023  10:38 pm               270 MeIl.il
19/09/2023  10:42 pm             2,048 MeILAssembly.dll
19/09/2023  10:26 pm               117 MeVb.vb
19/09/2023  10:32 pm             6,144 MeVbAssembly.dll
19/09/2023  10:08 pm    <DIR>          obj
19/09/2023  10:35 pm             4,494 Program.cs
19/09/2023  10:08 pm    <DIR>          Properties
               8 File(s)         19,216 bytes
               5 Dir(s)  490,288,914,432 bytes free

C:\Users\sunny\source\repos\Assemblies\Assemblies>dir *.dll
//----------------dir *.dll - list all dll only-------------//
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assemblies\Assemblies

19/09/2023  10:19 pm             3,584 MeCSharpAssembly.dll
19/09/2023  10:42 pm             2,048 MeILAssembly.dll
19/09/2023  10:32 pm             6,144 MeVbAssembly.dll
               3 File(s)         11,776 bytes
               0 Dir(s)  490,289,201,152 bytes free

C:\Users\sunny\source\repos\Assemblies\Assemblies>csc /r:MeILAssembly.dll /reference:MeVbAssembly.dll /r:MeCSharpAssembly.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\Assemblies\Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assemblies\Assemblies

19/09/2023  10:57 pm    <DIR>          .
19/09/2023  10:57 pm    <DIR>          ..
19/09/2023  10:08 pm               189 App.config
19/09/2023  10:08 pm             2,370 Assemblies.csproj
19/09/2023  10:08 pm    <DIR>          bin
19/09/2023  10:19 pm             3,584 MeCSharpAssembly.dll
19/09/2023  10:38 pm               270 MeIl.il
19/09/2023  10:42 pm             2,048 MeILAssembly.dll
19/09/2023  10:26 pm               117 MeVb.vb
19/09/2023  10:32 pm             6,144 MeVbAssembly.dll
19/09/2023  10:08 pm    <DIR>          obj
19/09/2023  10:57 pm             8,486 Program.cs
19/09/2023  10:56 pm             4,096 Program.exe
19/09/2023  10:08 pm    <DIR>          Properties
               9 File(s)         27,304 bytes
               5 Dir(s)  490,280,456,192 bytes free

C:\Users\sunny\source\repos\Assemblies\Assemblies>Program.exe
Helllllloooooo from C#
howdy from IL
Hello from Visual Basic


C:\Users\sunny\source\repos\Assemblies\Assemblies>ildasm /out:moo.txt MeVbAssembly.dll

C:\Users\sunny\source\repos\Assemblies\Assemblies>moo.txt

------------------NOTEPAD : IL -moo.txt ----------------------------------

//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern System
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern Microsoft.VisualBasic
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly MeVbAssembly
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module MeVbAssembly.dll
// MVID: {F2B70A7D-ED3C-40DA-A8EB-A097E6C92DE0}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06B60000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi My.MyApplication
       extends [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.ApplicationBase
{
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 08 31 31   // ...MyTemplate.11
                                                                                                  2E 30 2E 30 2E 30 00 00 )                         // .0.0.0..
  .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
  .method public specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.ApplicationBase::.ctor()
    IL_0006:  ret
  } // end of method MyApplication::.ctor

} // end of class My.MyApplication

.class private auto ansi My.MyComputer
       extends [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer
{
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 08 31 31   // ...MyTemplate.11
                                                                                                  2E 30 2E 30 2E 30 00 00 )                         // .0.0.0..
  .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
  .method public specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer::.ctor()
    IL_0007:  nop
    IL_0008:  ret
  } // end of method MyComputer::.ctor

} // end of class My.MyComputer

.class private auto ansi sealed beforefieldinit My.MyProject
       extends [mscorlib]System.Object
{
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.HideModuleNameAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 08 31 31   // ...MyTemplate.11
                                                                                                  2E 30 2E 30 2E 30 00 00 )                         // .0.0.0..
  .class auto ansi sealed nested assembly MyWebServices
         extends [mscorlib]System.Object
  {
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
    .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.MyGroupCollectionAttribute::.ctor(string,
                                                                                                         string,
                                                                                                         string,
                                                                                                         string) = ( 01 00 34 53 79 73 74 65 6D 2E 57 65 62 2E 53 65   // ..4System.Web.Se
                                                                                                                     72 76 69 63 65 73 2E 50 72 6F 74 6F 63 6F 6C 73   // rvices.Protocols
                                                                                                                     2E 53 6F 61 70 48 74 74 70 43 6C 69 65 6E 74 50   // .SoapHttpClientP
                                                                                                                     72 6F 74 6F 63 6F 6C 12 43 72 65 61 74 65 5F 5F   // rotocol.Create__
                                                                                                                     49 6E 73 74 61 6E 63 65 5F 5F 13 44 69 73 70 6F   // Instance__.Dispo
                                                                                                                     73 65 5F 5F 49 6E 73 74 61 6E 63 65 5F 5F 00 00   // se__Instance__..
                                                                                                                     00 ) 
    .method public hidebysig strict virtual 
            instance bool  Equals(object o) cil managed
    {
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       18 (0x12)
      .maxstack  2
      .locals init (bool V_0)
      IL_0000:  nop
      IL_0001:  ldarg.0
      IL_0002:  ldarg.1
      IL_0003:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)
      IL_0008:  call       instance bool [mscorlib]System.Object::Equals(object)
      IL_000d:  stloc.0
      IL_000e:  br.s       IL_0010

      IL_0010:  ldloc.0
      IL_0011:  ret
    } // end of method MyWebServices::Equals

    .method public hidebysig strict virtual 
            instance int32  GetHashCode() cil managed
    {
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       12 (0xc)
      .maxstack  1
      .locals init (int32 V_0)
      IL_0000:  nop
      IL_0001:  ldarg.0
      IL_0002:  call       instance int32 [mscorlib]System.Object::GetHashCode()
      IL_0007:  stloc.0
      IL_0008:  br.s       IL_000a

      IL_000a:  ldloc.0
      IL_000b:  ret
    } // end of method MyWebServices::GetHashCode

    .method assembly hidebysig instance class [mscorlib]System.Type 
            GetType() cil managed
    {
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       16 (0x10)
      .maxstack  1
      .locals init (class [mscorlib]System.Type V_0)
      IL_0000:  nop
      IL_0001:  ldtoken    My.MyProject/MyWebServices
      IL_0006:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
      IL_000b:  stloc.0
      IL_000c:  br.s       IL_000e

      IL_000e:  ldloc.0
      IL_000f:  ret
    } // end of method MyWebServices::GetType

    .method public hidebysig strict virtual 
            instance string  ToString() cil managed
    {
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       12 (0xc)
      .maxstack  1
      .locals init (string V_0)
      IL_0000:  nop
      IL_0001:  ldarg.0
      IL_0002:  call       instance string [mscorlib]System.Object::ToString()
      IL_0007:  stloc.0
      IL_0008:  br.s       IL_000a

      IL_000a:  ldloc.0
      IL_000b:  ret
    } // end of method MyWebServices::ToString

    .method private static !!T  Create__Instance__<.ctor T>(!!T 'instance') cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       29 (0x1d)
      .maxstack  2
      .locals init (!!T V_0,
               bool V_1)
      IL_0000:  nop
      IL_0001:  ldarg.0
      IL_0002:  box        !!T
      IL_0007:  ldnull
      IL_0008:  ceq
      IL_000a:  stloc.1
      IL_000b:  ldloc.1
      IL_000c:  brfalse.s  IL_0016

      IL_000e:  call       !!0 [mscorlib]System.Activator::CreateInstance<!!0>()
      IL_0013:  stloc.0
      IL_0014:  br.s       IL_001b

      IL_0016:  nop
      IL_0017:  ldarg.0
      IL_0018:  stloc.0
      IL_0019:  br.s       IL_001b

      IL_001b:  ldloc.0
      IL_001c:  ret
    } // end of method MyWebServices::Create__Instance__

    .method private instance void  Dispose__Instance__<T>(!!T& 'instance') cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       9 (0x9)
      .maxstack  8
      IL_0000:  nop
      IL_0001:  ldarg.1
      IL_0002:  initobj    !!T
      IL_0008:  ret
    } // end of method MyWebServices::Dispose__Instance__

    .method public specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
      // Code size       9 (0x9)
      .maxstack  8
      IL_0000:  nop
      IL_0001:  ldarg.0
      IL_0002:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0007:  nop
      IL_0008:  ret
    } // end of method MyWebServices::.ctor

  } // end of class MyWebServices

  .class auto ansi sealed nested assembly ThreadSafeObjectProvider`1<.ctor T>
         extends [mscorlib]System.Object
  {
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
    .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
    .field private initonly class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.Internal.ContextValue`1<!T> m_Context
    .method assembly specialname instance !T 
            get_GetInstance() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      // Code size       53 (0x35)
      .maxstack  2
      .locals init (!T V_0,
               !T V_1,
               bool V_2)
      IL_0000:  nop
      IL_0001:  ldarg.0
      IL_0002:  ldfld      class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.Internal.ContextValue`1<!0> class My.MyProject/ThreadSafeObjectProvider`1<!T>::m_Context
      IL_0007:  callvirt   instance !0 class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.Internal.ContextValue`1<!T>::get_Value()
      IL_000c:  stloc.1
      IL_000d:  ldloc.1
      IL_000e:  box        !T
      IL_0013:  ldnull
      IL_0014:  ceq
      IL_0016:  stloc.2
      IL_0017:  ldloc.2
      IL_0018:  brfalse.s  IL_002e

      IL_001a:  call       !!0 [mscorlib]System.Activator::CreateInstance<!T>()
      IL_001f:  stloc.1
      IL_0020:  ldarg.0
      IL_0021:  ldfld      class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.Internal.ContextValue`1<!0> class My.MyProject/ThreadSafeObjectProvider`1<!T>::m_Context
      IL_0026:  ldloc.1
      IL_0027:  callvirt   instance void class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.Internal.ContextValue`1<!T>::set_Value(!0)
      IL_002c:  nop
      IL_002d:  nop
      IL_002e:  nop
      IL_002f:  ldloc.1
      IL_0030:  stloc.0
      IL_0031:  br.s       IL_0033

      IL_0033:  ldloc.0
      IL_0034:  ret
    } // end of method ThreadSafeObjectProvider`1::get_GetInstance

    .method public specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 ) 
      // Code size       20 (0x14)
      .maxstack  8
      IL_0000:  nop
      IL_0001:  ldarg.0
      IL_0002:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0007:  nop
      IL_0008:  ldarg.0
      IL_0009:  newobj     instance void class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.Internal.ContextValue`1<!T>::.ctor()
      IL_000e:  stfld      class [Microsoft.VisualBasic]Microsoft.VisualBasic.MyServices.Internal.ContextValue`1<!0> class My.MyProject/ThreadSafeObjectProvider`1<!T>::m_Context
      IL_0013:  ret
    } // end of method ThreadSafeObjectProvider`1::.ctor

    .property instance !T GetInstance()
    {
      .get instance !T My.MyProject/ThreadSafeObjectProvider`1::get_GetInstance()
    } // end of property ThreadSafeObjectProvider`1::GetInstance
  } // end of class ThreadSafeObjectProvider`1

  .field private static initonly class My.MyProject/ThreadSafeObjectProvider`1<class My.MyComputer> m_ComputerObjectProvider
  .field private static initonly class My.MyProject/ThreadSafeObjectProvider`1<class My.MyApplication> m_AppObjectProvider
  .field private static initonly class My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider
  .field private static initonly class My.MyProject/ThreadSafeObjectProvider`1<class My.MyProject/MyWebServices> m_MyWebServicesObjectProvider
  .method private specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       41 (0x29)
    .maxstack  8
    IL_0000:  newobj     instance void class My.MyProject/ThreadSafeObjectProvider`1<class My.MyComputer>::.ctor()
    IL_0005:  stsfld     class My.MyProject/ThreadSafeObjectProvider`1<class My.MyComputer> My.MyProject::m_ComputerObjectProvider
    IL_000a:  newobj     instance void class My.MyProject/ThreadSafeObjectProvider`1<class My.MyApplication>::.ctor()
    IL_000f:  stsfld     class My.MyProject/ThreadSafeObjectProvider`1<class My.MyApplication> My.MyProject::m_AppObjectProvider
    IL_0014:  newobj     instance void class My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User>::.ctor()
    IL_0019:  stsfld     class My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> My.MyProject::m_UserObjectProvider
    IL_001e:  newobj     instance void class My.MyProject/ThreadSafeObjectProvider`1<class My.MyProject/MyWebServices>::.ctor()
    IL_0023:  stsfld     class My.MyProject/ThreadSafeObjectProvider`1<class My.MyProject/MyWebServices> My.MyProject::m_MyWebServicesObjectProvider
    IL_0028:  ret
  } // end of method MyProject::.cctor

  .method assembly specialname static class My.MyComputer 
          get_Computer() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       16 (0x10)
    .maxstack  1
    .locals init (class My.MyComputer V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     class My.MyProject/ThreadSafeObjectProvider`1<class My.MyComputer> My.MyProject::m_ComputerObjectProvider
    IL_0006:  callvirt   instance !0 class My.MyProject/ThreadSafeObjectProvider`1<class My.MyComputer>::get_GetInstance()
    IL_000b:  stloc.0
    IL_000c:  br.s       IL_000e

    IL_000e:  ldloc.0
    IL_000f:  ret
  } // end of method MyProject::get_Computer

  .method assembly specialname static class My.MyApplication 
          get_Application() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       16 (0x10)
    .maxstack  1
    .locals init (class My.MyApplication V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     class My.MyProject/ThreadSafeObjectProvider`1<class My.MyApplication> My.MyProject::m_AppObjectProvider
    IL_0006:  callvirt   instance !0 class My.MyProject/ThreadSafeObjectProvider`1<class My.MyApplication>::get_GetInstance()
    IL_000b:  stloc.0
    IL_000c:  br.s       IL_000e

    IL_000e:  ldloc.0
    IL_000f:  ret
  } // end of method MyProject::get_Application

  .method assembly specialname static class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User 
          get_User() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       16 (0x10)
    .maxstack  1
    .locals init (class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     class My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> My.MyProject::m_UserObjectProvider
    IL_0006:  callvirt   instance !0 class My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User>::get_GetInstance()
    IL_000b:  stloc.0
    IL_000c:  br.s       IL_000e

    IL_000e:  ldloc.0
    IL_000f:  ret
  } // end of method MyProject::get_User

  .method assembly specialname static class My.MyProject/MyWebServices 
          get_WebServices() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       16 (0x10)
    .maxstack  1
    .locals init (class My.MyProject/MyWebServices V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     class My.MyProject/ThreadSafeObjectProvider`1<class My.MyProject/MyWebServices> My.MyProject::m_MyWebServicesObjectProvider
    IL_0006:  callvirt   instance !0 class My.MyProject/ThreadSafeObjectProvider`1<class My.MyProject/MyWebServices>::get_GetInstance()
    IL_000b:  stloc.0
    IL_000c:  br.s       IL_000e

    IL_000e:  ldloc.0
    IL_000f:  ret
  } // end of method MyProject::get_WebServices

  .property class My.MyComputer Computer()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0B 4D 79 2E 43 6F 6D 70 75 74 65 72 00 00 ) // ...My.Computer..
    .get class My.MyComputer My.MyProject::get_Computer()
  } // end of property MyProject::Computer
  .property class My.MyApplication Application()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0E 4D 79 2E 41 70 70 6C 69 63 61 74 69 6F   // ...My.Applicatio
                                                                                                       6E 00 00 )                                        // n..
    .get class My.MyApplication My.MyProject::get_Application()
  } // end of property MyProject::Application
  .property class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User
          User()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 07 4D 79 2E 55 73 65 72 00 00 )             // ...My.User..
    .get class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User My.MyProject::get_User()
  } // end of property MyProject::User
  .property class My.MyProject/MyWebServices
          WebServices()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0E 4D 79 2E 57 65 62 53 65 72 76 69 63 65   // ...My.WebService
                                                                                                       73 00 00 )                                        // s..
    .get class My.MyProject/MyWebServices My.MyProject::get_WebServices()
  } // end of property MyProject::WebServices
} // end of class My.MyProject

.class public auto ansi MeVbClass
       extends [mscorlib]System.Object
{
  .method public specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method MeVbClass::.ctor

  .method public static void  MeVbMethod() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Hello from Visual Basic"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method MeVbClass::MeVbMethod

} // end of class MeVbClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res

______________________________________________________________________________

 */