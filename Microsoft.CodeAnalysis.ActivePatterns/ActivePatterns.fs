namespace Microsoft.CodeAnalysis

[<AutoOpen>]
module ActivePatterns =

  let (|CommandLineAnalyzerReference|_|) (node:Microsoft.CodeAnalysis.CommandLineAnalyzerReference) =
    match node with
    | :? Microsoft.CodeAnalysis.CommandLineAnalyzerReference as node ->
      Some (node.FilePath)
    | _ -> None

  let (|CommandLineReference|_|) (node:Microsoft.CodeAnalysis.CommandLineReference) =
    match node with
    | :? Microsoft.CodeAnalysis.CommandLineReference as node ->
      Some (node.Reference)
    | _ -> None

  let (|CommandLineSourceFile|_|) (node:Microsoft.CodeAnalysis.CommandLineSourceFile) =
    match node with
    | :? Microsoft.CodeAnalysis.CommandLineSourceFile as node ->
      Some (node.Path, node.IsScript)
    | _ -> None

  let (|SymbolFilter|_|) (node:Microsoft.CodeAnalysis.SymbolFilter) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolFilter as node ->
      Some ()
    | _ -> None

  let (|CandidateReason|_|) (node:Microsoft.CodeAnalysis.CandidateReason) =
    match node with
    | :? Microsoft.CodeAnalysis.CandidateReason as node ->
      Some ()
    | _ -> None

  let (|OperationKind|_|) (node:Microsoft.CodeAnalysis.OperationKind) =
    match node with
    | :? Microsoft.CodeAnalysis.OperationKind as node ->
      Some ()
    | _ -> None

  let (|OptimizationLevel|_|) (node:Microsoft.CodeAnalysis.OptimizationLevel) =
    match node with
    | :? Microsoft.CodeAnalysis.OptimizationLevel as node ->
      Some ()
    | _ -> None

  let (|Platform|_|) (node:Microsoft.CodeAnalysis.Platform) =
    match node with
    | :? Microsoft.CodeAnalysis.Platform as node ->
      Some ()
    | _ -> None

  let (|PreprocessingSymbolInfo|_|) (node:Microsoft.CodeAnalysis.PreprocessingSymbolInfo) =
    match node with
    | :? Microsoft.CodeAnalysis.PreprocessingSymbolInfo as node ->
      Some (node.IsDefined)
    | _ -> None

  let (|SpeculativeBindingOption|_|) (node:Microsoft.CodeAnalysis.SpeculativeBindingOption) =
    match node with
    | :? Microsoft.CodeAnalysis.SpeculativeBindingOption as node ->
      Some ()
    | _ -> None

  let (|SubsystemVersion|_|) (node:Microsoft.CodeAnalysis.SubsystemVersion) =
    match node with
    | :? Microsoft.CodeAnalysis.SubsystemVersion as node ->
      Some (node.Major, node.Minor, node.IsValid)
    | _ -> None

  let (|SymbolInfo|_|) (node:Microsoft.CodeAnalysis.SymbolInfo) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolInfo as node ->
      Some (node.CandidateReason)
    | _ -> None

  let (|TypeInfo|_|) (node:Microsoft.CodeAnalysis.TypeInfo) =
    match node with
    | :? Microsoft.CodeAnalysis.TypeInfo as node ->
      Some ()
    | _ -> None

  let (|DiagnosticSeverity|_|) (node:Microsoft.CodeAnalysis.DiagnosticSeverity) =
    match node with
    | :? Microsoft.CodeAnalysis.DiagnosticSeverity as node ->
      Some ()
    | _ -> None

  let (|FileLinePositionSpan|_|) (node:Microsoft.CodeAnalysis.FileLinePositionSpan) =
    match node with
    | :? Microsoft.CodeAnalysis.FileLinePositionSpan as node ->
      Some (node.Path, node.HasMappedPath, node.IsValid)
    | _ -> None

  let (|LocationKind|_|) (node:Microsoft.CodeAnalysis.LocationKind) =
    match node with
    | :? Microsoft.CodeAnalysis.LocationKind as node ->
      Some ()
    | _ -> None

  let (|ReportDiagnostic|_|) (node:Microsoft.CodeAnalysis.ReportDiagnostic) =
    match node with
    | :? Microsoft.CodeAnalysis.ReportDiagnostic as node ->
      Some ()
    | _ -> None

  let (|DocumentationMode|_|) (node:Microsoft.CodeAnalysis.DocumentationMode) =
    match node with
    | :? Microsoft.CodeAnalysis.DocumentationMode as node ->
      Some ()
    | _ -> None

  let (|AssemblyIdentityParts|_|) (node:Microsoft.CodeAnalysis.AssemblyIdentityParts) =
    match node with
    | :? Microsoft.CodeAnalysis.AssemblyIdentityParts as node ->
      Some ()
    | _ -> None

  let (|MetadataImageKind|_|) (node:Microsoft.CodeAnalysis.MetadataImageKind) =
    match node with
    | :? Microsoft.CodeAnalysis.MetadataImageKind as node ->
      Some ()
    | _ -> None

  let (|MetadataReferenceProperties|_|) (node:Microsoft.CodeAnalysis.MetadataReferenceProperties) =
    match node with
    | :? Microsoft.CodeAnalysis.MetadataReferenceProperties as node ->
      Some (node.Kind, node.EmbedInteropTypes)
    | _ -> None

  let (|OutputKind|_|) (node:Microsoft.CodeAnalysis.OutputKind) =
    match node with
    | :? Microsoft.CodeAnalysis.OutputKind as node ->
      Some ()
    | _ -> None

  let (|SourceCodeKind|_|) (node:Microsoft.CodeAnalysis.SourceCodeKind) =
    match node with
    | :? Microsoft.CodeAnalysis.SourceCodeKind as node ->
      Some ()
    | _ -> None

  let (|SpecialType|_|) (node:Microsoft.CodeAnalysis.SpecialType) =
    match node with
    | :? Microsoft.CodeAnalysis.SpecialType as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayDelegateStyle|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayExtensionMethodStyle|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayGenericsOptions|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayGlobalNamespaceStyle|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayKindOptions|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayKindOptions) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayKindOptions as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayLocalOptions|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayLocalOptions) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayLocalOptions as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayMemberOptions|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayMemberOptions) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayMemberOptions as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayMiscellaneousOptions|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayParameterOptions|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayParameterOptions) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayParameterOptions as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayPart|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayPart) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayPart as node ->
      Some (node.Kind)
    | _ -> None

  let (|SymbolDisplayPartKind|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayPartKind) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayPartKind as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayPropertyStyle|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle as node ->
      Some ()
    | _ -> None

  let (|SymbolDisplayTypeQualificationStyle|_|) (node:Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle as node ->
      Some ()
    | _ -> None

  let (|Accessibility|_|) (node:Microsoft.CodeAnalysis.Accessibility) =
    match node with
    | :? Microsoft.CodeAnalysis.Accessibility as node ->
      Some ()
    | _ -> None

  let (|MethodKind|_|) (node:Microsoft.CodeAnalysis.MethodKind) =
    match node with
    | :? Microsoft.CodeAnalysis.MethodKind as node ->
      Some ()
    | _ -> None

  let (|NamespaceKind|_|) (node:Microsoft.CodeAnalysis.NamespaceKind) =
    match node with
    | :? Microsoft.CodeAnalysis.NamespaceKind as node ->
      Some ()
    | _ -> None

  let (|RefKind|_|) (node:Microsoft.CodeAnalysis.RefKind) =
    match node with
    | :? Microsoft.CodeAnalysis.RefKind as node ->
      Some ()
    | _ -> None

  let (|SymbolKind|_|) (node:Microsoft.CodeAnalysis.SymbolKind) =
    match node with
    | :? Microsoft.CodeAnalysis.SymbolKind as node ->
      Some ()
    | _ -> None

  let (|TypedConstant|_|) (node:Microsoft.CodeAnalysis.TypedConstant) =
    match node with
    | :? Microsoft.CodeAnalysis.TypedConstant as node ->
      Some (node.Kind, node.IsNull)
    | _ -> None

  let (|TypedConstantKind|_|) (node:Microsoft.CodeAnalysis.TypedConstantKind) =
    match node with
    | :? Microsoft.CodeAnalysis.TypedConstantKind as node ->
      Some ()
    | _ -> None

  let (|TypeKind|_|) (node:Microsoft.CodeAnalysis.TypeKind) =
    match node with
    | :? Microsoft.CodeAnalysis.TypeKind as node ->
      Some ()
    | _ -> None

  let (|TypeParameterKind|_|) (node:Microsoft.CodeAnalysis.TypeParameterKind) =
    match node with
    | :? Microsoft.CodeAnalysis.TypeParameterKind as node ->
      Some ()
    | _ -> None

  let (|VarianceKind|_|) (node:Microsoft.CodeAnalysis.VarianceKind) =
    match node with
    | :? Microsoft.CodeAnalysis.VarianceKind as node ->
      Some ()
    | _ -> None

  let (|ChildSyntaxList|_|) (node:Microsoft.CodeAnalysis.ChildSyntaxList) =
    match node with
    | :? Microsoft.CodeAnalysis.ChildSyntaxList as node ->
      Some (node.Count)
    | _ -> None

  let (|LineVisibility|_|) (node:Microsoft.CodeAnalysis.LineVisibility) =
    match node with
    | :? Microsoft.CodeAnalysis.LineVisibility as node ->
      Some ()
    | _ -> None

  let (|SyntaxNodeOrToken|_|) (node:Microsoft.CodeAnalysis.SyntaxNodeOrToken) =
    match node with
    | :? Microsoft.CodeAnalysis.SyntaxNodeOrToken as node ->
      Some (node.RawKind, node.Language, node.IsMissing, node.Parent, node.IsToken, node.IsNode, node.SpanStart, node.HasLeadingTrivia, node.HasTrailingTrivia, node.ContainsDiagnostics, node.ContainsDirectives, node.ContainsAnnotations)
    | _ -> None

  let (|SyntaxNodeOrTokenList|_|) (node:Microsoft.CodeAnalysis.SyntaxNodeOrTokenList) =
    match node with
    | :? Microsoft.CodeAnalysis.SyntaxNodeOrTokenList as node ->
      Some (node.Count)
    | _ -> None

  let (|SyntaxRemoveOptions|_|) (node:Microsoft.CodeAnalysis.SyntaxRemoveOptions) =
    match node with
    | :? Microsoft.CodeAnalysis.SyntaxRemoveOptions as node ->
      Some ()
    | _ -> None

  let (|SyntaxToken|_|) (node:Microsoft.CodeAnalysis.SyntaxToken) =
    match node with
    | :? Microsoft.CodeAnalysis.SyntaxToken as node ->
      Some (node.RawKind, node.Language, node.Parent, node.SpanStart, node.IsMissing, node.ValueText, node.Text, node.HasLeadingTrivia, node.HasTrailingTrivia, node.ContainsDiagnostics, node.ContainsDirectives, node.HasStructuredTrivia, node.ContainsAnnotations)
    | _ -> None

  let (|SyntaxTokenList|_|) (node:Microsoft.CodeAnalysis.SyntaxTokenList) =
    match node with
    | :? Microsoft.CodeAnalysis.SyntaxTokenList as node ->
      Some (node.Count)
    | _ -> None

  let (|SyntaxTrivia|_|) (node:Microsoft.CodeAnalysis.SyntaxTrivia) =
    match node with
    | :? Microsoft.CodeAnalysis.SyntaxTrivia as node ->
      Some (node.RawKind, node.Language, node.Token, node.SpanStart, node.ContainsDiagnostics, node.HasStructure, node.IsDirective)
    | _ -> None

  let (|SyntaxTriviaList|_|) (node:Microsoft.CodeAnalysis.SyntaxTriviaList) =
    match node with
    | :? Microsoft.CodeAnalysis.SyntaxTriviaList as node ->
      Some (node.Count)
    | _ -> None

  let (|SyntaxWalkerDepth|_|) (node:Microsoft.CodeAnalysis.SyntaxWalkerDepth) =
    match node with
    | :? Microsoft.CodeAnalysis.SyntaxWalkerDepth as node ->
      Some ()
    | _ -> None

  let (|DebugInformationFormat|_|) (node:Microsoft.CodeAnalysis.Emit.DebugInformationFormat) =
    match node with
    | :? Microsoft.CodeAnalysis.Emit.DebugInformationFormat as node ->
      Some ()
    | _ -> None

  let (|SemanticEditKind|_|) (node:Microsoft.CodeAnalysis.Emit.SemanticEditKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Emit.SemanticEditKind as node ->
      Some ()
    | _ -> None

  let (|EditAndContinueMethodDebugInformation|_|) (node:Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation) =
    match node with
    | :? Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation as node ->
      Some ()
    | _ -> None

  let (|SemanticEdit|_|) (node:Microsoft.CodeAnalysis.Emit.SemanticEdit) =
    match node with
    | :? Microsoft.CodeAnalysis.Emit.SemanticEdit as node ->
      Some (node.Kind, node.PreserveLocalVariables)
    | _ -> None

  let (|LinePosition|_|) (node:Microsoft.CodeAnalysis.Text.LinePosition) =
    match node with
    | :? Microsoft.CodeAnalysis.Text.LinePosition as node ->
      Some (node.Line, node.Character)
    | _ -> None

  let (|LinePositionSpan|_|) (node:Microsoft.CodeAnalysis.Text.LinePositionSpan) =
    match node with
    | :? Microsoft.CodeAnalysis.Text.LinePositionSpan as node ->
      Some ()
    | _ -> None

  let (|SourceHashAlgorithm|_|) (node:Microsoft.CodeAnalysis.Text.SourceHashAlgorithm) =
    match node with
    | :? Microsoft.CodeAnalysis.Text.SourceHashAlgorithm as node ->
      Some ()
    | _ -> None

  let (|TextChange|_|) (node:Microsoft.CodeAnalysis.Text.TextChange) =
    match node with
    | :? Microsoft.CodeAnalysis.Text.TextChange as node ->
      Some (node.NewText)
    | _ -> None

  let (|TextChangeRange|_|) (node:Microsoft.CodeAnalysis.Text.TextChangeRange) =
    match node with
    | :? Microsoft.CodeAnalysis.Text.TextChangeRange as node ->
      Some (node.NewLength)
    | _ -> None

  let (|TextLine|_|) (node:Microsoft.CodeAnalysis.Text.TextLine) =
    match node with
    | :? Microsoft.CodeAnalysis.Text.TextLine as node ->
      Some (node.LineNumber, node.Start, node.End, node.EndIncludingLineBreak)
    | _ -> None

  let (|TextSpan|_|) (node:Microsoft.CodeAnalysis.Text.TextSpan) =
    match node with
    | :? Microsoft.CodeAnalysis.Text.TextSpan as node ->
      Some (node.Start, node.End, node.Length, node.IsEmpty)
    | _ -> None

  let (|ArgumentKind|_|) (node:Microsoft.CodeAnalysis.Semantics.ArgumentKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.ArgumentKind as node ->
      Some ()
    | _ -> None

  let (|SyntheticLocalKind|_|) (node:Microsoft.CodeAnalysis.Semantics.SyntheticLocalKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.SyntheticLocalKind as node ->
      Some ()
    | _ -> None

  let (|InstanceReferenceKind|_|) (node:Microsoft.CodeAnalysis.Semantics.InstanceReferenceKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.InstanceReferenceKind as node ->
      Some ()
    | _ -> None

  let (|SimpleUnaryOperationKind|_|) (node:Microsoft.CodeAnalysis.Semantics.SimpleUnaryOperationKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.SimpleUnaryOperationKind as node ->
      Some ()
    | _ -> None

  let (|UnaryOperandKind|_|) (node:Microsoft.CodeAnalysis.Semantics.UnaryOperandKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.UnaryOperandKind as node ->
      Some ()
    | _ -> None

  let (|UnaryOperationKind|_|) (node:Microsoft.CodeAnalysis.Semantics.UnaryOperationKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.UnaryOperationKind as node ->
      Some ()
    | _ -> None

  let (|SimpleBinaryOperationKind|_|) (node:Microsoft.CodeAnalysis.Semantics.SimpleBinaryOperationKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.SimpleBinaryOperationKind as node ->
      Some ()
    | _ -> None

  let (|BinaryOperandsKind|_|) (node:Microsoft.CodeAnalysis.Semantics.BinaryOperandsKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.BinaryOperandsKind as node ->
      Some ()
    | _ -> None

  let (|BinaryOperationKind|_|) (node:Microsoft.CodeAnalysis.Semantics.BinaryOperationKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.BinaryOperationKind as node ->
      Some ()
    | _ -> None

  let (|ConversionKind|_|) (node:Microsoft.CodeAnalysis.Semantics.ConversionKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.ConversionKind as node ->
      Some ()
    | _ -> None

  let (|CaseKind|_|) (node:Microsoft.CodeAnalysis.Semantics.CaseKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.CaseKind as node ->
      Some ()
    | _ -> None

  let (|LoopKind|_|) (node:Microsoft.CodeAnalysis.Semantics.LoopKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.LoopKind as node ->
      Some ()
    | _ -> None

  let (|BranchKind|_|) (node:Microsoft.CodeAnalysis.Semantics.BranchKind) =
    match node with
    | :? Microsoft.CodeAnalysis.Semantics.BranchKind as node ->
      Some ()
    | _ -> None

  let (|GeneratedCodeAnalysisFlags|_|) (node:Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags as node ->
      Some ()
    | _ -> None

  let (|CompilationAnalysisContext|_|) (node:Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext as node ->
      Some ()
    | _ -> None

  let (|SemanticModelAnalysisContext|_|) (node:Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext as node ->
      Some ()
    | _ -> None

  let (|SymbolAnalysisContext|_|) (node:Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext as node ->
      Some ()
    | _ -> None

  let (|CodeBlockAnalysisContext|_|) (node:Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext as node ->
      Some (node.CodeBlock)
    | _ -> None

  let (|OperationBlockAnalysisContext|_|) (node:Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext as node ->
      Some ()
    | _ -> None

  let (|SyntaxTreeAnalysisContext|_|) (node:Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext as node ->
      Some ()
    | _ -> None

  let (|SyntaxNodeAnalysisContext|_|) (node:Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext as node ->
      Some (node.Node)
    | _ -> None

  let (|OperationAnalysisContext|_|) (node:Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext) =
    match node with
    | :? Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext as node ->
      Some ()
    | _ -> None

