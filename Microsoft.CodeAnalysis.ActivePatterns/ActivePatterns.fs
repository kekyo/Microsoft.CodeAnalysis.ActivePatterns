// This is auto-generated source code by Microsoft.CodeAnalysis.ActivePatterns, DO NOT EDIT!

namespace Microsoft.CodeAnalysis

[<AutoOpen>]
module ActivePatterns =

  let (|CommandLineAnalyzerReference|) (value:Microsoft.CodeAnalysis.CommandLineAnalyzerReference) =
    CommandLineAnalyzerReference (value.FilePath)

  let (|CommandLineReference|) (value:Microsoft.CodeAnalysis.CommandLineReference) =
    CommandLineReference (value.Reference)

  let (|CommandLineSourceFile|) (value:Microsoft.CodeAnalysis.CommandLineSourceFile) =
    CommandLineSourceFile (value.Path, value.IsScript)

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

  let (|SymbolDisplayPart|) (value:Microsoft.CodeAnalysis.SymbolDisplayPart) =
    SymbolDisplayPart (value.Kind)

  let (|TypedConstant|) (value:Microsoft.CodeAnalysis.TypedConstant) =
    TypedConstant (value.Kind, value.IsNull)

  let (|ChildSyntaxList|) (value:Microsoft.CodeAnalysis.ChildSyntaxList) =
    ChildSyntaxList (value.Count)

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

  let (|CodeBlockAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext) =
    CodeBlockAnalysisContext (value.CodeBlock)

  let (|SyntaxNodeAnalysisContext|) (value:Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext) =
    SyntaxNodeAnalysisContext (value.Node)

  let (|CommonConversion|) (value:Microsoft.CodeAnalysis.Operations.CommonConversion) =
    CommonConversion (value.Exists, value.IsIdentity, value.IsNumeric, value.IsReference, value.IsUserDefined)

  let (|SemanticEdit|) (value:Microsoft.CodeAnalysis.Emit.SemanticEdit) =
    SemanticEdit (value.Kind, value.PreserveLocalVariables)

