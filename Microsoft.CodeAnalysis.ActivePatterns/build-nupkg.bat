@echo off

rem F# Active pattern functions for Roslyn Compiler Platform
rem Copyright (c) 2016 Kouji Matsui (@kekyo2)
rem 
rem Licensed under the Apache License, Version 2.0 (the "License");
rem you may not use this file except in compliance with the License.
rem You may obtain a copy of the License at
rem 
rem http://www.apache.org/licenses/LICENSE-2.0
rem 
rem Unless required by applicable law or agreed to in writing, software
rem distributed under the License is distributed on an "AS IS" BASIS,
rem WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
rem See the License for the specific language governing permissions and
rem limitations under the License.

set nupkg_version=0.5.1

..\.nuget\nuget pack Microsoft.CodeAnalysis.ActivePatterns.nuspec -Prop Version=%nupkg_version% -Prop Configuration=Debug
