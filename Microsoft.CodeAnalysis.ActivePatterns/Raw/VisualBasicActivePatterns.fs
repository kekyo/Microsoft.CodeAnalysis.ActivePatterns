namespace Microsoft.CodeAnalysis.VisualBasic.Raw

[<AutoOpen>]
module VisualBasicActivePatterns =

  let (|EmptyStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax as node ->
      Some (node.Empty)
    | _ -> None

  let (|EndBlockStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EndBlockStatementSyntax as node ->
      Some (node.EndKeyword, node.BlockKeyword)
    | _ -> None

  let (|CompilationUnitSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CompilationUnitSyntax as node ->
      Some (node.Options |> Seq.toList, node.Imports |> Seq.toList, node.Attributes |> Seq.toList, node.Members |> Seq.toList, node.EndOfFileToken)
    | _ -> None

  let (|OptionStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OptionStatementSyntax as node ->
      Some (node.OptionKeyword, node.NameKeyword, node.ValueKeyword)
    | _ -> None

  let (|ImportsStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ImportsStatementSyntax as node ->
      Some (node.ImportsKeyword)
    | _ -> None

  let (|SimpleImportsClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleImportsClauseSyntax as node ->
      Some (node.Alias, node.Name)
    | _ -> None

  let (|ImportAliasClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ImportAliasClauseSyntax as node ->
      Some (node.Identifier, node.EqualsToken)
    | _ -> None

  let (|XmlNamespaceImportsClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlNamespaceImportsClauseSyntax as node ->
      Some (node.LessThanToken, node.XmlNamespace, node.GreaterThanToken)
    | _ -> None

  let (|NamespaceBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NamespaceBlockSyntax as node ->
      Some (node.NamespaceStatement, node.Members |> Seq.toList, node.EndNamespaceStatement)
    | _ -> None

  let (|NamespaceStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NamespaceStatementSyntax as node ->
      Some (node.NamespaceKeyword, node.Name)
    | _ -> None

  let (|ModuleBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ModuleBlockSyntax as node ->
      Some (node.ModuleStatement, node.Inherits |> Seq.toList, node.Implements |> Seq.toList, node.Members |> Seq.toList, node.EndModuleStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|StructureBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.StructureBlockSyntax as node ->
      Some (node.StructureStatement, node.Inherits |> Seq.toList, node.Implements |> Seq.toList, node.Members |> Seq.toList, node.EndStructureStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|InterfaceBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterfaceBlockSyntax as node ->
      Some (node.InterfaceStatement, node.Inherits |> Seq.toList, node.Implements |> Seq.toList, node.Members |> Seq.toList, node.EndInterfaceStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|ClassBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ClassBlockSyntax as node ->
      Some (node.ClassStatement, node.Inherits |> Seq.toList, node.Implements |> Seq.toList, node.Members |> Seq.toList, node.EndClassStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|EnumBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EnumBlockSyntax as node ->
      Some (node.EnumStatement, node.Members |> Seq.toList, node.EndEnumStatement)
    | _ -> None

  let (|InheritsStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InheritsStatementSyntax as node ->
      Some (node.InheritsKeyword)
    | _ -> None

  let (|ImplementsStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ImplementsStatementSyntax as node ->
      Some (node.ImplementsKeyword)
    | _ -> None

  let (|ModuleStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ModuleStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ModuleKeyword, node.Identifier, node.TypeParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|StructureStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.StructureStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.StructureKeyword, node.Identifier, node.TypeParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|InterfaceStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterfaceStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.InterfaceKeyword, node.Identifier, node.TypeParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|ClassStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ClassStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ClassKeyword, node.Identifier, node.TypeParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|EnumStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EnumStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.EnumKeyword, node.Identifier, node.UnderlyingType)
    | _ -> None

  let (|TypeParameterListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeParameterListSyntax as node ->
      Some (node.OpenParenToken, node.OfKeyword, node.CloseParenToken)
    | _ -> None

  let (|TypeParameterSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeParameterSyntax as node ->
      Some (node.VarianceKeyword, node.Identifier, node.TypeParameterConstraintClause)
    | _ -> None

  let (|TypeParameterSingleConstraintClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeParameterSingleConstraintClauseSyntax as node ->
      Some (node.AsKeyword, node.Constraint)
    | _ -> None

  let (|TypeParameterMultipleConstraintClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeParameterMultipleConstraintClauseSyntax as node ->
      Some (node.AsKeyword, node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|SpecialConstraintSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SpecialConstraintSyntax as node ->
      Some (node.ConstraintKeyword)
    | _ -> None

  let (|TypeConstraintSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeConstraintSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|EnumMemberDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EnumMemberDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Identifier, node.Initializer)
    | _ -> None

  let (|MethodBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MethodBlockSyntax as node ->
      Some (node.SubOrFunctionStatement, node.Statements |> Seq.toList, node.EndSubOrFunctionStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|ConstructorBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ConstructorBlockSyntax as node ->
      Some (node.SubNewStatement, node.Statements |> Seq.toList, node.EndSubStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|OperatorBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OperatorBlockSyntax as node ->
      Some (node.OperatorStatement, node.Statements |> Seq.toList, node.EndOperatorStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|AccessorBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AccessorBlockSyntax as node ->
      Some (node.AccessorStatement, node.Statements |> Seq.toList, node.EndAccessorStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|PropertyBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PropertyBlockSyntax as node ->
      Some (node.PropertyStatement, node.Accessors |> Seq.toList, node.EndPropertyStatement)
    | _ -> None

  let (|EventBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EventBlockSyntax as node ->
      Some (node.EventStatement, node.Accessors |> Seq.toList, node.EndEventStatement)
    | _ -> None

  let (|ParameterListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ParameterListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|MethodStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MethodStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.SubOrFunctionKeyword, node.Identifier, node.TypeParameterList, node.ParameterList, node.AsClause, node.HandlesClause, node.ImplementsClause, node.DeclarationKeyword)
    | _ -> None

  let (|SubNewStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SubNewStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.SubKeyword, node.NewKeyword, node.ParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|DeclareStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DeclareStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.DeclareKeyword, node.CharsetKeyword, node.SubOrFunctionKeyword, node.Identifier, node.LibKeyword, node.LibraryName, node.AliasKeyword, node.AliasName, node.ParameterList, node.AsClause, node.DeclarationKeyword)
    | _ -> None

  let (|DelegateStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DelegateStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.DelegateKeyword, node.SubOrFunctionKeyword, node.Identifier, node.TypeParameterList, node.ParameterList, node.AsClause, node.DeclarationKeyword)
    | _ -> None

  let (|EventStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EventStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.CustomKeyword, node.EventKeyword, node.Identifier, node.ParameterList, node.AsClause, node.ImplementsClause, node.DeclarationKeyword)
    | _ -> None

  let (|OperatorStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OperatorStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.OperatorKeyword, node.OperatorToken, node.ParameterList, node.AsClause, node.DeclarationKeyword)
    | _ -> None

  let (|PropertyStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PropertyStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.PropertyKeyword, node.Identifier, node.ParameterList, node.AsClause, node.Initializer, node.ImplementsClause, node.DeclarationKeyword)
    | _ -> None

  let (|AccessorStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AccessorStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.AccessorKeyword, node.ParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|ImplementsClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ImplementsClauseSyntax as node ->
      Some (node.ImplementsKeyword)
    | _ -> None

  let (|HandlesClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.HandlesClauseSyntax as node ->
      Some (node.HandlesKeyword)
    | _ -> None

  let (|KeywordEventContainerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.KeywordEventContainerSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|WithEventsEventContainerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WithEventsEventContainerSyntax as node ->
      Some (node.Identifier)
    | _ -> None

  let (|WithEventsPropertyEventContainerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WithEventsPropertyEventContainerSyntax as node ->
      Some (node.WithEventsContainer, node.DotToken, node.Property)
    | _ -> None

  let (|HandlesClauseItemSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.HandlesClauseItemSyntax as node ->
      Some (node.EventContainer, node.DotToken, node.EventMember)
    | _ -> None

  let (|IncompleteMemberSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.IncompleteMemberSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.MissingIdentifier)
    | _ -> None

  let (|FieldDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FieldDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList)
    | _ -> None

  let (|VariableDeclaratorSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.VariableDeclaratorSyntax as node ->
      Some (node.AsClause, node.Initializer)
    | _ -> None

  let (|SimpleAsClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleAsClauseSyntax as node ->
      Some (node.AsKeyword, node.AttributeLists |> Seq.toList, node.Type)
    | _ -> None

  let (|AsNewClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AsNewClauseSyntax as node ->
      Some (node.AsKeyword, node.NewExpression)
    | _ -> None

  let (|ObjectMemberInitializerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectMemberInitializerSyntax as node ->
      Some (node.WithKeyword, node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|ObjectCollectionInitializerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCollectionInitializerSyntax as node ->
      Some (node.FromKeyword, node.Initializer)
    | _ -> None

  let (|InferredFieldInitializerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InferredFieldInitializerSyntax as node ->
      Some (node.KeyKeyword, node.Expression)
    | _ -> None

  let (|NamedFieldInitializerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NamedFieldInitializerSyntax as node ->
      Some (node.KeyKeyword, node.DotToken, node.Name, node.EqualsToken, node.Expression)
    | _ -> None

  let (|EqualsValueSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EqualsValueSyntax as node ->
      Some (node.EqualsToken, node.Value)
    | _ -> None

  let (|ParameterSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ParameterSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Identifier, node.AsClause, node.Default)
    | _ -> None

  let (|ModifiedIdentifierSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ModifiedIdentifierSyntax as node ->
      Some (node.Identifier, node.Nullable, node.ArrayBounds, node.ArrayRankSpecifiers |> Seq.toList)
    | _ -> None

  let (|ArrayRankSpecifierSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ArrayRankSpecifierSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken, node.Rank)
    | _ -> None

  let (|AttributeListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax as node ->
      Some (node.LessThanToken, node.GreaterThanToken)
    | _ -> None

  let (|AttributeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeSyntax as node ->
      Some (node.Target, node.Name, node.ArgumentList)
    | _ -> None

  let (|AttributeTargetSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeTargetSyntax as node ->
      Some (node.AttributeModifier, node.ColonToken)
    | _ -> None

  let (|AttributesStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributesStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList)
    | _ -> None

  let (|ExpressionStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionStatementSyntax as node ->
      Some (node.Expression)
    | _ -> None

  let (|PrintStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PrintStatementSyntax as node ->
      Some (node.QuestionToken, node.Expression)
    | _ -> None

  let (|WhileBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WhileBlockSyntax as node ->
      Some (node.WhileStatement, node.Statements |> Seq.toList, node.EndWhileStatement)
    | _ -> None

  let (|UsingBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.UsingBlockSyntax as node ->
      Some (node.UsingStatement, node.Statements |> Seq.toList, node.EndUsingStatement)
    | _ -> None

  let (|SyncLockBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SyncLockBlockSyntax as node ->
      Some (node.SyncLockStatement, node.Statements |> Seq.toList, node.EndSyncLockStatement)
    | _ -> None

  let (|WithBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WithBlockSyntax as node ->
      Some (node.WithStatement, node.Statements |> Seq.toList, node.EndWithStatement)
    | _ -> None

  let (|LabelStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LabelStatementSyntax as node ->
      Some (node.LabelToken, node.ColonToken)
    | _ -> None

  let (|GoToStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GoToStatementSyntax as node ->
      Some (node.GoToKeyword, node.Label)
    | _ -> None

  let (|LabelSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LabelSyntax as node ->
      Some (node.LabelToken)
    | _ -> None

  let (|StopOrEndStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.StopOrEndStatementSyntax as node ->
      Some (node.StopOrEndKeyword)
    | _ -> None

  let (|ExitStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExitStatementSyntax as node ->
      Some (node.ExitKeyword, node.BlockKeyword)
    | _ -> None

  let (|ContinueStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ContinueStatementSyntax as node ->
      Some (node.ContinueKeyword, node.BlockKeyword)
    | _ -> None

  let (|ReturnStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ReturnStatementSyntax as node ->
      Some (node.ReturnKeyword, node.Expression)
    | _ -> None

  let (|SingleLineIfStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SingleLineIfStatementSyntax as node ->
      Some (node.IfKeyword, node.Condition, node.ThenKeyword, node.Statements |> Seq.toList, node.ElseClause)
    | _ -> None

  let (|SingleLineElseClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SingleLineElseClauseSyntax as node ->
      Some (node.ElseKeyword, node.Statements |> Seq.toList)
    | _ -> None

  let (|MultiLineIfBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MultiLineIfBlockSyntax as node ->
      Some (node.IfStatement, node.Statements |> Seq.toList, node.ElseIfBlocks |> Seq.toList, node.ElseBlock, node.EndIfStatement)
    | _ -> None

  let (|IfStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.IfStatementSyntax as node ->
      Some (node.IfKeyword, node.Condition, node.ThenKeyword)
    | _ -> None

  let (|ElseIfBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseIfBlockSyntax as node ->
      Some (node.ElseIfStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|ElseIfStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseIfStatementSyntax as node ->
      Some (node.ElseIfKeyword, node.Condition, node.ThenKeyword)
    | _ -> None

  let (|ElseBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseBlockSyntax as node ->
      Some (node.ElseStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|ElseStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseStatementSyntax as node ->
      Some (node.ElseKeyword)
    | _ -> None

  let (|TryBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TryBlockSyntax as node ->
      Some (node.TryStatement, node.Statements |> Seq.toList, node.CatchBlocks |> Seq.toList, node.FinallyBlock, node.EndTryStatement)
    | _ -> None

  let (|TryStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TryStatementSyntax as node ->
      Some (node.TryKeyword)
    | _ -> None

  let (|CatchBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CatchBlockSyntax as node ->
      Some (node.CatchStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|CatchStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CatchStatementSyntax as node ->
      Some (node.CatchKeyword, node.IdentifierName, node.AsClause, node.WhenClause)
    | _ -> None

  let (|CatchFilterClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CatchFilterClauseSyntax as node ->
      Some (node.WhenKeyword, node.Filter)
    | _ -> None

  let (|FinallyBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FinallyBlockSyntax as node ->
      Some (node.FinallyStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|FinallyStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FinallyStatementSyntax as node ->
      Some (node.FinallyKeyword)
    | _ -> None

  let (|ErrorStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ErrorStatementSyntax as node ->
      Some (node.ErrorKeyword, node.ErrorNumber)
    | _ -> None

  let (|OnErrorGoToStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OnErrorGoToStatementSyntax as node ->
      Some (node.OnKeyword, node.ErrorKeyword, node.GoToKeyword, node.Minus, node.Label)
    | _ -> None

  let (|OnErrorResumeNextStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OnErrorResumeNextStatementSyntax as node ->
      Some (node.OnKeyword, node.ErrorKeyword, node.ResumeKeyword, node.NextKeyword)
    | _ -> None

  let (|ResumeStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ResumeStatementSyntax as node ->
      Some (node.ResumeKeyword, node.Label)
    | _ -> None

  let (|SelectBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SelectBlockSyntax as node ->
      Some (node.SelectStatement, node.CaseBlocks |> Seq.toList, node.EndSelectStatement)
    | _ -> None

  let (|SelectStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SelectStatementSyntax as node ->
      Some (node.SelectKeyword, node.CaseKeyword, node.Expression)
    | _ -> None

  let (|CaseBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CaseBlockSyntax as node ->
      Some (node.CaseStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|CaseStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CaseStatementSyntax as node ->
      Some (node.CaseKeyword)
    | _ -> None

  let (|ElseCaseClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseCaseClauseSyntax as node ->
      Some (node.ElseKeyword)
    | _ -> None

  let (|SimpleCaseClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleCaseClauseSyntax as node ->
      Some (node.Value)
    | _ -> None

  let (|RangeCaseClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RangeCaseClauseSyntax as node ->
      Some (node.LowerBound, node.ToKeyword, node.UpperBound)
    | _ -> None

  let (|RelationalCaseClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RelationalCaseClauseSyntax as node ->
      Some (node.IsKeyword, node.OperatorToken, node.Value)
    | _ -> None

  let (|SyncLockStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SyncLockStatementSyntax as node ->
      Some (node.SyncLockKeyword, node.Expression)
    | _ -> None

  let (|DoLoopBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DoLoopBlockSyntax as node ->
      Some (node.DoStatement, node.Statements |> Seq.toList, node.LoopStatement)
    | _ -> None

  let (|DoStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DoStatementSyntax as node ->
      Some (node.DoKeyword, node.WhileOrUntilClause)
    | _ -> None

  let (|LoopStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LoopStatementSyntax as node ->
      Some (node.LoopKeyword, node.WhileOrUntilClause)
    | _ -> None

  let (|WhileOrUntilClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WhileOrUntilClauseSyntax as node ->
      Some (node.WhileOrUntilKeyword, node.Condition)
    | _ -> None

  let (|WhileStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WhileStatementSyntax as node ->
      Some (node.WhileKeyword, node.Condition)
    | _ -> None

  let (|ForBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForBlockSyntax as node ->
      Some (node.ForStatement, node.Statements |> Seq.toList, node.NextStatement, node.ForOrForEachStatement)
    | _ -> None

  let (|ForEachBlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForEachBlockSyntax as node ->
      Some (node.ForEachStatement, node.Statements |> Seq.toList, node.NextStatement, node.ForOrForEachStatement)
    | _ -> None

  let (|ForStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStatementSyntax as node ->
      Some (node.ForKeyword, node.ControlVariable, node.EqualsToken, node.FromValue, node.ToKeyword, node.ToValue, node.StepClause)
    | _ -> None

  let (|ForStepClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStepClauseSyntax as node ->
      Some (node.StepKeyword, node.StepValue)
    | _ -> None

  let (|ForEachStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForEachStatementSyntax as node ->
      Some (node.ForKeyword, node.EachKeyword, node.ControlVariable, node.InKeyword, node.Expression)
    | _ -> None

  let (|NextStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NextStatementSyntax as node ->
      Some (node.NextKeyword)
    | _ -> None

  let (|UsingStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.UsingStatementSyntax as node ->
      Some (node.UsingKeyword, node.Expression)
    | _ -> None

  let (|ThrowStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ThrowStatementSyntax as node ->
      Some (node.ThrowKeyword, node.Expression)
    | _ -> None

  let (|AssignmentStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax as node ->
      Some (node.Left, node.OperatorToken, node.Right)
    | _ -> None

  let (|MidExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax as node ->
      Some (node.Mid, node.ArgumentList)
    | _ -> None

  let (|CallStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CallStatementSyntax as node ->
      Some (node.CallKeyword, node.Invocation)
    | _ -> None

  let (|AddRemoveHandlerStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AddRemoveHandlerStatementSyntax as node ->
      Some (node.AddHandlerOrRemoveHandlerKeyword, node.EventExpression, node.CommaToken, node.DelegateExpression)
    | _ -> None

  let (|RaiseEventStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RaiseEventStatementSyntax as node ->
      Some (node.RaiseEventKeyword, node.Name, node.ArgumentList)
    | _ -> None

  let (|WithStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WithStatementSyntax as node ->
      Some (node.WithKeyword, node.Expression)
    | _ -> None

  let (|ReDimStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ReDimStatementSyntax as node ->
      Some (node.ReDimKeyword, node.PreserveKeyword)
    | _ -> None

  let (|RedimClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RedimClauseSyntax as node ->
      Some (node.Expression, node.ArrayBounds)
    | _ -> None

  let (|EraseStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EraseStatementSyntax as node ->
      Some (node.EraseKeyword)
    | _ -> None

  let (|LiteralExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LiteralExpressionSyntax as node ->
      Some (node.Token)
    | _ -> None

  let (|ParenthesizedExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ParenthesizedExpressionSyntax as node ->
      Some (node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|TupleExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TupleExpressionSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|TupleTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TupleTypeSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|TypedTupleElementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypedTupleElementSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|NamedTupleElementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NamedTupleElementSyntax as node ->
      Some (node.Identifier, node.AsClause)
    | _ -> None

  let (|MeExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MeExpressionSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|MyBaseExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MyBaseExpressionSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|MyClassExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MyClassExpressionSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|GetTypeExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GetTypeExpressionSyntax as node ->
      Some (node.GetTypeKeyword, node.OpenParenToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|TypeOfExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeOfExpressionSyntax as node ->
      Some (node.TypeOfKeyword, node.Expression, node.OperatorToken, node.Type)
    | _ -> None

  let (|GetXmlNamespaceExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GetXmlNamespaceExpressionSyntax as node ->
      Some (node.GetXmlNamespaceKeyword, node.OpenParenToken, node.Name, node.CloseParenToken)
    | _ -> None

  let (|MemberAccessExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax as node ->
      Some (node.Expression, node.OperatorToken, node.Name)
    | _ -> None

  let (|XmlMemberAccessExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlMemberAccessExpressionSyntax as node ->
      Some (node.Base, node.Token1, node.Token2, node.Token3, node.Name)
    | _ -> None

  let (|InvocationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax as node ->
      Some (node.Expression, node.ArgumentList)
    | _ -> None

  let (|ObjectCreationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.AttributeLists |> Seq.toList, node.Type, node.ArgumentList, node.Initializer)
    | _ -> None

  let (|AnonymousObjectCreationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AnonymousObjectCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.AttributeLists |> Seq.toList, node.Initializer)
    | _ -> None

  let (|ArrayCreationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ArrayCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.AttributeLists |> Seq.toList, node.Type, node.ArrayBounds, node.RankSpecifiers |> Seq.toList, node.Initializer)
    | _ -> None

  let (|CollectionInitializerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CollectionInitializerSyntax as node ->
      Some (node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|CTypeExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CTypeExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CommaToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|DirectCastExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DirectCastExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CommaToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|TryCastExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TryCastExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CommaToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|PredefinedCastExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PredefinedCastExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|BinaryExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax as node ->
      Some (node.Left, node.OperatorToken, node.Right)
    | _ -> None

  let (|UnaryExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.UnaryExpressionSyntax as node ->
      Some (node.OperatorToken, node.Operand)
    | _ -> None

  let (|BinaryConditionalExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryConditionalExpressionSyntax as node ->
      Some (node.IfKeyword, node.OpenParenToken, node.FirstExpression, node.CommaToken, node.SecondExpression, node.CloseParenToken)
    | _ -> None

  let (|TernaryConditionalExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TernaryConditionalExpressionSyntax as node ->
      Some (node.IfKeyword, node.OpenParenToken, node.Condition, node.FirstCommaToken, node.WhenTrue, node.SecondCommaToken, node.WhenFalse, node.CloseParenToken)
    | _ -> None

  let (|SingleLineLambdaExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SingleLineLambdaExpressionSyntax as node ->
      Some (node.SubOrFunctionHeader, node.Body)
    | _ -> None

  let (|MultiLineLambdaExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MultiLineLambdaExpressionSyntax as node ->
      Some (node.SubOrFunctionHeader, node.Statements |> Seq.toList, node.EndSubOrFunctionStatement)
    | _ -> None

  let (|LambdaHeaderSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LambdaHeaderSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.SubOrFunctionKeyword, node.ParameterList, node.AsClause, node.DeclarationKeyword)
    | _ -> None

  let (|ArgumentListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|OmittedArgumentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OmittedArgumentSyntax as node ->
      Some (node.Empty, node.IsNamed)
    | _ -> None

  let (|SimpleArgumentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleArgumentSyntax as node ->
      Some (node.NameColonEquals, node.Expression, node.IsNamed)
    | _ -> None

  let (|NameColonEqualsSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NameColonEqualsSyntax as node ->
      Some (node.Name, node.ColonEqualsToken)
    | _ -> None

  let (|RangeArgumentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RangeArgumentSyntax as node ->
      Some (node.LowerBound, node.ToKeyword, node.UpperBound, node.IsNamed)
    | _ -> None

  let (|QueryExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.QueryExpressionSyntax as node ->
      Some (node.Clauses |> Seq.toList)
    | _ -> None

  let (|CollectionRangeVariableSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CollectionRangeVariableSyntax as node ->
      Some (node.Identifier, node.AsClause, node.InKeyword, node.Expression)
    | _ -> None

  let (|ExpressionRangeVariableSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionRangeVariableSyntax as node ->
      Some (node.NameEquals, node.Expression)
    | _ -> None

  let (|AggregationRangeVariableSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AggregationRangeVariableSyntax as node ->
      Some (node.NameEquals, node.Aggregation)
    | _ -> None

  let (|VariableNameEqualsSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.VariableNameEqualsSyntax as node ->
      Some (node.Identifier, node.AsClause, node.EqualsToken)
    | _ -> None

  let (|FunctionAggregationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FunctionAggregationSyntax as node ->
      Some (node.FunctionName, node.OpenParenToken, node.Argument, node.CloseParenToken)
    | _ -> None

  let (|GroupAggregationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GroupAggregationSyntax as node ->
      Some (node.GroupKeyword)
    | _ -> None

  let (|FromClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FromClauseSyntax as node ->
      Some (node.FromKeyword)
    | _ -> None

  let (|LetClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LetClauseSyntax as node ->
      Some (node.LetKeyword)
    | _ -> None

  let (|AggregateClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AggregateClauseSyntax as node ->
      Some (node.AggregateKeyword, node.AdditionalQueryOperators |> Seq.toList, node.IntoKeyword)
    | _ -> None

  let (|DistinctClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DistinctClauseSyntax as node ->
      Some (node.DistinctKeyword)
    | _ -> None

  let (|WhereClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WhereClauseSyntax as node ->
      Some (node.WhereKeyword, node.Condition)
    | _ -> None

  let (|PartitionWhileClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PartitionWhileClauseSyntax as node ->
      Some (node.SkipOrTakeKeyword, node.WhileKeyword, node.Condition)
    | _ -> None

  let (|PartitionClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PartitionClauseSyntax as node ->
      Some (node.SkipOrTakeKeyword, node.Count)
    | _ -> None

  let (|GroupByClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GroupByClauseSyntax as node ->
      Some (node.GroupKeyword, node.ByKeyword, node.IntoKeyword)
    | _ -> None

  let (|JoinConditionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.JoinConditionSyntax as node ->
      Some (node.Left, node.EqualsKeyword, node.Right)
    | _ -> None

  let (|SimpleJoinClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleJoinClauseSyntax as node ->
      Some (node.JoinKeyword, node.AdditionalJoins |> Seq.toList, node.OnKeyword)
    | _ -> None

  let (|GroupJoinClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GroupJoinClauseSyntax as node ->
      Some (node.GroupKeyword, node.JoinKeyword, node.AdditionalJoins |> Seq.toList, node.OnKeyword, node.IntoKeyword)
    | _ -> None

  let (|OrderByClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OrderByClauseSyntax as node ->
      Some (node.OrderKeyword, node.ByKeyword)
    | _ -> None

  let (|OrderingSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OrderingSyntax as node ->
      Some (node.Expression, node.AscendingOrDescendingKeyword)
    | _ -> None

  let (|SelectClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SelectClauseSyntax as node ->
      Some (node.SelectKeyword)
    | _ -> None

  let (|XmlDocumentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlDocumentSyntax as node ->
      Some (node.Declaration, node.PrecedingMisc |> Seq.toList, node.Root, node.FollowingMisc |> Seq.toList)
    | _ -> None

  let (|XmlDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlDeclarationSyntax as node ->
      Some (node.LessThanQuestionToken, node.XmlKeyword, node.Version, node.Encoding, node.Standalone, node.QuestionGreaterThanToken)
    | _ -> None

  let (|XmlDeclarationOptionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlDeclarationOptionSyntax as node ->
      Some (node.Name, node.Equals, node.Value)
    | _ -> None

  let (|XmlElementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlElementSyntax as node ->
      Some (node.StartTag, node.Content |> Seq.toList, node.EndTag)
    | _ -> None

  let (|XmlElementStartTagSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlElementStartTagSyntax as node ->
      Some (node.LessThanToken, node.Name, node.Attributes |> Seq.toList, node.GreaterThanToken)
    | _ -> None

  let (|XmlElementEndTagSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlElementEndTagSyntax as node ->
      Some (node.LessThanSlashToken, node.Name, node.GreaterThanToken)
    | _ -> None

  let (|XmlEmptyElementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlEmptyElementSyntax as node ->
      Some (node.LessThanToken, node.Name, node.Attributes |> Seq.toList, node.SlashGreaterThanToken)
    | _ -> None

  let (|XmlAttributeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.Value)
    | _ -> None

  let (|XmlStringSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlStringSyntax as node ->
      Some (node.StartQuoteToken, node.EndQuoteToken)
    | _ -> None

  let (|XmlPrefixNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlPrefixNameSyntax as node ->
      Some (node.Name)
    | _ -> None

  let (|XmlNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlNameSyntax as node ->
      Some (node.Prefix, node.LocalName)
    | _ -> None

  let (|XmlBracketedNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlBracketedNameSyntax as node ->
      Some (node.LessThanToken, node.Name, node.GreaterThanToken)
    | _ -> None

  let (|XmlPrefixSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlPrefixSyntax as node ->
      Some (node.Name, node.ColonToken)
    | _ -> None

  let (|XmlCommentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlCommentSyntax as node ->
      Some (node.LessThanExclamationMinusMinusToken, node.MinusMinusGreaterThanToken)
    | _ -> None

  let (|XmlProcessingInstructionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlProcessingInstructionSyntax as node ->
      Some (node.LessThanQuestionToken, node.Name, node.QuestionGreaterThanToken)
    | _ -> None

  let (|XmlCDataSectionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlCDataSectionSyntax as node ->
      Some (node.BeginCDataToken, node.EndCDataToken)
    | _ -> None

  let (|XmlEmbeddedExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlEmbeddedExpressionSyntax as node ->
      Some (node.LessThanPercentEqualsToken, node.Expression, node.PercentGreaterThanToken)
    | _ -> None

  let (|ArrayTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ArrayTypeSyntax as node ->
      Some (node.ElementType, node.RankSpecifiers |> Seq.toList)
    | _ -> None

  let (|NullableTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NullableTypeSyntax as node ->
      Some (node.ElementType, node.QuestionMarkToken)
    | _ -> None

  let (|PredefinedTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PredefinedTypeSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|IdentifierNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.IdentifierNameSyntax as node ->
      Some (node.Identifier)
    | _ -> None

  let (|GenericNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GenericNameSyntax as node ->
      Some (node.Identifier, node.TypeArgumentList)
    | _ -> None

  let (|QualifiedNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.QualifiedNameSyntax as node ->
      Some (node.Left, node.DotToken, node.Right)
    | _ -> None

  let (|GlobalNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GlobalNameSyntax as node ->
      Some (node.GlobalKeyword)
    | _ -> None

  let (|TypeArgumentListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeArgumentListSyntax as node ->
      Some (node.OpenParenToken, node.OfKeyword, node.CloseParenToken)
    | _ -> None

  let (|CrefReferenceSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CrefReferenceSyntax as node ->
      Some (node.Name, node.Signature, node.AsClause)
    | _ -> None

  let (|CrefSignatureSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CrefSignatureSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|CrefSignaturePartSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CrefSignaturePartSyntax as node ->
      Some (node.Modifier, node.Type)
    | _ -> None

  let (|CrefOperatorReferenceSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CrefOperatorReferenceSyntax as node ->
      Some (node.OperatorKeyword, node.OperatorToken)
    | _ -> None

  let (|QualifiedCrefOperatorReferenceSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.QualifiedCrefOperatorReferenceSyntax as node ->
      Some (node.Left, node.DotToken, node.Right)
    | _ -> None

  let (|YieldStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.YieldStatementSyntax as node ->
      Some (node.YieldKeyword, node.Expression)
    | _ -> None

  let (|AwaitExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AwaitExpressionSyntax as node ->
      Some (node.AwaitKeyword, node.Expression)
    | _ -> None

  let (|DocumentationCommentTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DocumentationCommentTriviaSyntax as node ->
      Some (node.Content |> Seq.toList)
    | _ -> None

  let (|XmlCrefAttributeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlCrefAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.Reference, node.EndQuoteToken)
    | _ -> None

  let (|XmlNameAttributeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlNameAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.Reference, node.EndQuoteToken)
    | _ -> None

  let (|ConditionalAccessExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ConditionalAccessExpressionSyntax as node ->
      Some (node.Expression, node.QuestionMarkToken, node.WhenNotNull)
    | _ -> None

  let (|NameOfExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NameOfExpressionSyntax as node ->
      Some (node.NameOfKeyword, node.OpenParenToken, node.Argument, node.CloseParenToken)
    | _ -> None

  let (|InterpolatedStringExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolatedStringExpressionSyntax as node ->
      Some (node.DollarSignDoubleQuoteToken, node.Contents |> Seq.toList, node.DoubleQuoteToken)
    | _ -> None

  let (|InterpolatedStringTextSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolatedStringTextSyntax as node ->
      Some (node.TextToken)
    | _ -> None

  let (|InterpolationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolationSyntax as node ->
      Some (node.OpenBraceToken, node.Expression, node.AlignmentClause, node.FormatClause, node.CloseBraceToken)
    | _ -> None

  let (|InterpolationAlignmentClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolationAlignmentClauseSyntax as node ->
      Some (node.CommaToken, node.Value)
    | _ -> None

  let (|InterpolationFormatClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolationFormatClauseSyntax as node ->
      Some (node.ColonToken, node.FormatStringToken)
    | _ -> None

  let (|ConstDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ConstDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ConstKeyword, node.Name, node.EqualsToken, node.Value)
    | _ -> None

  let (|IfDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.IfDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ElseKeyword, node.IfOrElseIfKeyword, node.Condition, node.ThenKeyword)
    | _ -> None

  let (|ElseDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ElseKeyword)
    | _ -> None

  let (|EndIfDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EndIfDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndKeyword, node.IfKeyword)
    | _ -> None

  let (|RegionDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RegionDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.RegionKeyword, node.Name)
    | _ -> None

  let (|EndRegionDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EndRegionDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndKeyword, node.RegionKeyword)
    | _ -> None

  let (|ExternalSourceDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExternalSourceDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ExternalSourceKeyword, node.OpenParenToken, node.ExternalSource, node.CommaToken, node.LineStart, node.CloseParenToken)
    | _ -> None

  let (|EndExternalSourceDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EndExternalSourceDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndKeyword, node.ExternalSourceKeyword)
    | _ -> None

  let (|ExternalChecksumDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExternalChecksumDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ExternalChecksumKeyword, node.OpenParenToken, node.ExternalSource, node.FirstCommaToken, node.Guid, node.SecondCommaToken, node.Checksum, node.CloseParenToken)
    | _ -> None

  let (|EnableWarningDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EnableWarningDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EnableKeyword, node.WarningKeyword)
    | _ -> None

  let (|DisableWarningDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DisableWarningDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.DisableKeyword, node.WarningKeyword)
    | _ -> None

  let (|ReferenceDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ReferenceDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ReferenceKeyword, node.File)
    | _ -> None

  let (|BadDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.BadDirectiveTriviaSyntax as node ->
      Some (node.HashToken)
    | _ -> None

