﻿/////////////////////////////////////////////////////////////////////////////
//
// Microsoft.CodeAnalysis.ActivePatterns - F# Active pattern matching library for Roslyn
// Copyright (c) 2016 Kouji Matsui (@kekyo2)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/////////////////////////////////////////////////////////////////////////////

namespace global

open System.Reflection
open System.Runtime.InteropServices

[<assembly: AssemblyTitle("Microsoft.CodeAnalysis.ActivePatterns")>]
[<assembly: AssemblyDescription("F# Active pattern matching library for Roslyn")>]
[<assembly: AssemblyCompany("Kouji Matsui")>]
[<assembly: AssemblyProduct("Microsoft.CodeAnalysis.ActivePatterns")>]
[<assembly: AssemblyCopyright("Copyright (c) 2016 Kouji Matsui")>]
[<assembly: AssemblyTrademark("Microsoft.CodeAnalysis.ActivePatterns")>]

[<assembly: ComVisible(false)>]
[<assembly: Guid("158409ad-cb76-4ecb-ad20-2a17882a3ade")>]

#if DEBUG
[<assembly: AssemblyConfiguration("DEBUG")>]
#else
[<assembly: AssemblyConfiguration("RELEASE")>]
#endif

do()
