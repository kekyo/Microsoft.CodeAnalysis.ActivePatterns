// This is auto-generated source code by Microsoft.CodeAnalysis.ActivePatterns, DO NOT EDIT!

namespace Microsoft.CodeAnalysis

[<AutoOpen>]
module ActivePatterns =

  let (|CommandLineAnalyzerReference|) (value:Microsoft.CodeAnalysis.CommandLineAnalyzerReference) =
    CommandLineAnalyzerReference (value.FilePath)

  let (|CommandLineReference|) (value:Microsoft.CodeAnalysis.CommandLineReference) =
    CommandLineReference (value.Reference)

  let (|CommandLineSourceFile|) (value:Microsoft.CodeAnalysis.CommandLineSourceFile) =
    CommandLineSourceFile (value.Path, value.IsInputRedirected, value.IsScript)

  let (|ImportedXmlNamespace|) (value:Microsoft.CodeAnalysis.ImportedXmlNamespace) =
    ImportedXmlNamespace (value.XmlNamespace)

  let (|PreprocessingSymbolInfo|) (value:Microsoft.CodeAnalysis.PreprocessingSymbolInfo) =
    PreprocessingSymbolInfo (value.IsDefined)

  let (|SubsystemVersion|) (value:Microsoft.CodeAnalysis.SubsystemVersion) =
    SubsystemVersion (value.Major, value.Minor, value.IsValid)

  let (|SymbolInfo|) (value:Microsoft.CodeAnalysis.SymbolInfo) =
    SymbolInfo (value.CandidateReason)

  let (|FileLinePositionSpan|) (value:Microsoft.CodeAnalysis.FileLinePositionSpan) =
    FileLinePositionSpan (value.Path, value.HasMappedPath, value.IsValid)

  let (|MetadataReferenceProperties|) (value:Microsoft.CodeAnalysis.MetadataReferenceProperties) =
    MetadataReferenceProperties (value.Kind, value.EmbedInteropTypes)

  let (|GeneratorSyntaxContext|) (value:Microsoft.CodeAnalysis.GeneratorSyntaxContext) =
    GeneratorSyntaxContext (value.Node)

  let (|GeneratorAttributeSyntaxContext|) (value:Microsoft.CodeAnalysis.GeneratorAttributeSyntaxContext) =
    GeneratorAttributeSyntaxContext (value.TargetNode)

  let (|GeneratedSourceResult|) (value:Microsoft.CodeAnalysis.GeneratedSourceResult) =
    GeneratedSourceResult (value.HintName)

  let (|SymbolDisplayPart|) (value:Microsoft.CodeAnalysis.SymbolDisplayPart) =
    SymbolDisplayPart (value.Kind)

  let (|NullabilityInfo|) (value:Microsoft.CodeAnalysis.NullabilityInfo) =
    NullabilityInfo (value.Annotation, value.FlowState)

  let (|TypedConstant|) (value:Microsoft.CodeAnalysis.TypedConstant) =
    TypedConstant (value.Kind, value.IsNull)

  let (|ChildSyntaxList|) (value:Microsoft.CodeAnalysis.ChildSyntaxList) =
    ChildSyntaxList (value.Count)

  let (|LineMapping|) (value:Microsoft.CodeAnalysis.LineMapping) =
    LineMapping (value.IsHidden)

  let (|SyntaxNodeOrToken|) (value:Microsoft.CodeAnalysis.SyntaxNodeOrToken) =
    SyntaxNodeOrToken (value.RawKind, value.Language, value.IsMissing, value.Parent, value.IsToken, value.IsNode, value.SpanStart, value.HasLeadingTrivia, value.HasTrailingTrivia, value.ContainsDiagnostics, value.ContainsDirectives, value.ContainsAnnotations)

  let (|SyntaxNodeOrTokenList|) (value:Microsoft.CodeAnalysis.SyntaxNodeOrTokenList) =
    SyntaxNodeOrTokenList (value.Count)

  let (|SyntaxToken|) (value:Microsoft.CodeAnalysis.SyntaxToken) =
    SyntaxToken (value.RawKind, value.Language, value.Parent, value.SpanStart, value.IsMissing, value.ValueText, value.Text, value.HasLeadingTrivia, value.HasTrailingTrivia, value.ContainsDiagnostics, value.ContainsDirectives, value.HasStructuredTrivia, value.ContainsAnnotations)

  let (|SyntaxTokenList|) (value:Microsoft.CodeAnalysis.SyntaxTokenList) =
    SyntaxTokenList (value.Count)

  let (|SyntaxTrivia|) (value:Microsoft.CodeAnalysis.SyntaxTrivia) =
    SyntaxTrivia (value.RawKind, value.Language, value.Token, value.SpanStart, value.ContainsDiagnostics, value.HasStructure, value.IsDirective)

  let (|SyntaxTriviaList|) (value:Microsoft.CodeAnalysis.SyntaxTriviaList) =
    SyntaxTriviaList (value.Count)

  let (|LinePosition|) (value:Microsoft.CodeAnalysis.Text.LinePosition) =
    LinePosition (value.Line, value.Character)

  let (|TextChange|) (value:Microsoft.CodeAnalysis.Text.TextChange) =
    TextChange (value.NewText)

  let (|TextChangeRange|) (value:Microsoft.CodeAnalysis.Text.TextChangeRange) =
    TextChangeRange (value.NewLength)

  let (|TextLine|) (value:Microsoft.CodeAnalysis.Text.TextLine) =
    TextLine (value.LineNumber, value.Start, value.End, value.EndIncludingLineBreak)

  let (|TextSpan|) (value:Microsoft.CodeAnalysis.Text.TextSpan) =
    TextSpan (value.Start, value.End, value.Length, value.IsEmpty)

  let (|SemanticModelAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext) =
    SemanticModelAnalysisContext (value.IsGeneratedCode)

  let (|SymbolAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext) =
    SymbolAnalysisContext (value.IsGeneratedCode)

  let (|CodeBlockAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext) =
    CodeBlockAnalysisContext (value.CodeBlock, value.IsGeneratedCode)

  let (|OperationBlockAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext) =
    OperationBlockAnalysisContext (value.IsGeneratedCode)

  let (|SyntaxTreeAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext) =
    SyntaxTreeAnalysisContext (value.IsGeneratedCode)

  let (|SyntaxNodeAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext) =
    SyntaxNodeAnalysisContext (value.Node, value.IsGeneratedCode)

  let (|OperationAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext) =
    OperationAnalysisContext (value.IsGeneratedCode)

  let (|CommonConversion|) (value:Microsoft.CodeAnalysis.Operations.CommonConversion) =
    CommonConversion (value.Exists, value.IsIdentity, value.IsNullable, value.IsNumeric, value.IsReference, value.IsImplicit, value.IsUserDefined)

  let (|SemanticEdit|) (value:Microsoft.CodeAnalysis.Emit.SemanticEdit) =
    SemanticEdit (value.Kind, value.PreserveLocalVariables)

