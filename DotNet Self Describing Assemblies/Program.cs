using System;

//ref link:https://www.youtube.com/watch?v=BQGvT9-HhDI&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=12
//

/*-----------------------------CMD------------------------------------------------
 * 
C:\Users\sunny\source\repos\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies

24/09/2023  02:06 am    <DIR>          .
24/09/2023  02:06 am    <DIR>          ..
24/09/2023  02:06 am             2,581 .gitattributes
24/09/2023  02:06 am             6,585 .gitignore
24/09/2023  02:08 am    <DIR>          DotNet Self Describing Assemblies
24/09/2023  02:03 am             1,205 DotNet Self Describing Assemblies.sln
               3 File(s)         10,371 bytes
               3 Dir(s)  490,454,515,712 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies>cd DotNet Self Describing Assemblies

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies

24/09/2023  02:08 am    <DIR>          .
24/09/2023  02:08 am    <DIR>          ..
24/09/2023  02:03 am               189 App.config
24/09/2023  02:03 am    <DIR>          bin
24/09/2023  02:03 am             2,416 DotNet Self Describing Assemblies.csproj
24/09/2023  02:03 am    <DIR>          obj
24/09/2023  02:08 am               261 Program.cs
24/09/2023  02:03 am    <DIR>          Properties
               3 File(s)          2,866 bytes
               5 Dir(s)  490,454,515,712 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>erase *.*
C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies\*.*, Are you sure (Y/N)? y

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies

24/09/2023  02:09 am    <DIR>          .
24/09/2023  02:09 am    <DIR>          ..
24/09/2023  02:03 am    <DIR>          bin
24/09/2023  02:03 am    <DIR>          obj
24/09/2023  02:03 am    <DIR>          Properties
               0 File(s)              0 bytes
               5 Dir(s)  490,454,233,088 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies

24/09/2023  02:09 am    <DIR>          .
24/09/2023  02:09 am    <DIR>          ..
24/09/2023  02:03 am    <DIR>          bin
24/09/2023  02:03 am    <DIR>          obj
24/09/2023  02:09 am               261 Program.cs
24/09/2023  02:03 am    <DIR>          Properties
               1 File(s)            261 bytes
               5 Dir(s)  490,453,938,176 bytes free

C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>csc /t:library /out:MeFarm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Self Describing Assemblies\DotNet Self Describing Assemblies

24/09/2023  02:13 am    <DIR>          .
24/09/2023  02:13 am    <DIR>          ..
24/09/2023  02:03 am    <DIR>          bin
24/09/2023  02:13 am             4,096 MeFarm.dll
24/09/2023  02:03 am    <DIR>          obj
24/09/2023  02:10 am             3,438 Program.cs
24/09/2023  02:03 am    <DIR>          Properties
               2 File(s)          7,534 bytes
               5 Dir(s)  490,450,075,648 bytes free




 * 
 */



public class Farm { }
public struct Cow { }
public delegate void Donkey();
public enum Chicken { Eggs }
public class Bacon { }