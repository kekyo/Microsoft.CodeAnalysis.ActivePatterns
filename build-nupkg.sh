#!/bin/sh

# F# Active pattern functions for Roslyn Compiler Platform
# Copyright (c) Kouji Matsui (@kozy_kekyo, @kekyo@mastodon.cloud)
#
# Licensed under Apache-v2: https://opensource.org/licenses/Apache-2.0

echo
echo "==========================================================="
echo "Build Microsoft.CodeAnalysis.ActivePatterns"
echo

# git clean -xfd

dotnet build -p:Configuration=Release -o artifacts
dotnet pack -p:Configuration=Release -o artifacts
