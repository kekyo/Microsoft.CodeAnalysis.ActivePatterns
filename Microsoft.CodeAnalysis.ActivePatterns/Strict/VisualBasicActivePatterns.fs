// This is auto-generated source code by Microsoft.CodeAnalysis.ActivePatterns, DO NOT EDIT!

namespace Microsoft.CodeAnalysis.VisualBasic.Strict

[<AutoOpen>]
module ActivePatterns =

  let (|EmptyStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax as node ->
      Some (node.Empty)
    | _ -> None

  let (|EndBlockStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EndBlockStatementSyntax as node ->
      Some (node.EndKeyword, node.BlockKeyword)
    | _ -> None

  let (|CompilationUnit|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CompilationUnitSyntax as node ->
      Some (node.Options |> Seq.toList, node.Imports |> Seq.toList, node.Attributes |> Seq.toList, node.Members |> Seq.toList, node.EndOfFileToken)
    | _ -> None

  let (|OptionStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OptionStatementSyntax as node ->
      Some (node.OptionKeyword, node.NameKeyword, node.ValueKeyword)
    | _ -> None

  let (|ImportsStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ImportsStatementSyntax as node ->
      Some (node.ImportsKeyword)
    | _ -> None

  let (|SimpleImportsClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleImportsClauseSyntax as node ->
      Some (node.Alias, node.Name)
    | _ -> None

  let (|ImportAliasClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ImportAliasClauseSyntax as node ->
      Some (node.Identifier, node.EqualsToken)
    | _ -> None

  let (|XmlNamespaceImportsClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlNamespaceImportsClauseSyntax as node ->
      Some (node.LessThanToken, node.XmlNamespace, node.GreaterThanToken)
    | _ -> None

  let (|NamespaceBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NamespaceBlockSyntax as node ->
      Some (node.NamespaceStatement, node.Members |> Seq.toList, node.EndNamespaceStatement)
    | _ -> None

  let (|NamespaceStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NamespaceStatementSyntax as node ->
      Some (node.NamespaceKeyword, node.Name)
    | _ -> None

  let (|ModuleBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ModuleBlockSyntax as node ->
      Some (node.ModuleStatement, node.Inherits |> Seq.toList, node.Implements |> Seq.toList, node.Members |> Seq.toList, node.EndModuleStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|StructureBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.StructureBlockSyntax as node ->
      Some (node.StructureStatement, node.Inherits |> Seq.toList, node.Implements |> Seq.toList, node.Members |> Seq.toList, node.EndStructureStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|InterfaceBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterfaceBlockSyntax as node ->
      Some (node.InterfaceStatement, node.Inherits |> Seq.toList, node.Implements |> Seq.toList, node.Members |> Seq.toList, node.EndInterfaceStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|ClassBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ClassBlockSyntax as node ->
      Some (node.ClassStatement, node.Inherits |> Seq.toList, node.Implements |> Seq.toList, node.Members |> Seq.toList, node.EndClassStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|EnumBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EnumBlockSyntax as node ->
      Some (node.EnumStatement, node.Members |> Seq.toList, node.EndEnumStatement)
    | _ -> None

  let (|InheritsStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InheritsStatementSyntax as node ->
      Some (node.InheritsKeyword)
    | _ -> None

  let (|ImplementsStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ImplementsStatementSyntax as node ->
      Some (node.ImplementsKeyword)
    | _ -> None

  let (|ModuleStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ModuleStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ModuleKeyword, node.Identifier, node.TypeParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|StructureStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.StructureStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.StructureKeyword, node.Identifier, node.TypeParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|InterfaceStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterfaceStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.InterfaceKeyword, node.Identifier, node.TypeParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|ClassStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ClassStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ClassKeyword, node.Identifier, node.TypeParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|EnumStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EnumStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.EnumKeyword, node.Identifier, node.UnderlyingType)
    | _ -> None

  let (|TypeParameterList|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeParameterListSyntax as node ->
      Some (node.OpenParenToken, node.OfKeyword, node.CloseParenToken)
    | _ -> None

  let (|TypeParameter|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeParameterSyntax as node ->
      Some (node.VarianceKeyword, node.Identifier, node.TypeParameterConstraintClause)
    | _ -> None

  let (|TypeParameterSingleConstraintClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeParameterSingleConstraintClauseSyntax as node ->
      Some (node.AsKeyword, node.Constraint)
    | _ -> None

  let (|TypeParameterMultipleConstraintClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeParameterMultipleConstraintClauseSyntax as node ->
      Some (node.AsKeyword, node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|SpecialConstraint|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SpecialConstraintSyntax as node ->
      Some (node.ConstraintKeyword)
    | _ -> None

  let (|TypeConstraint|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeConstraintSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|EnumMemberDeclaration|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EnumMemberDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Identifier, node.Initializer)
    | _ -> None

  let (|MethodBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MethodBlockSyntax as node ->
      Some (node.SubOrFunctionStatement, node.Statements |> Seq.toList, node.EndSubOrFunctionStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|ConstructorBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ConstructorBlockSyntax as node ->
      Some (node.SubNewStatement, node.Statements |> Seq.toList, node.EndSubStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|OperatorBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OperatorBlockSyntax as node ->
      Some (node.OperatorStatement, node.Statements |> Seq.toList, node.EndOperatorStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|AccessorBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AccessorBlockSyntax as node ->
      Some (node.AccessorStatement, node.Statements |> Seq.toList, node.EndAccessorStatement, node.BlockStatement, node.EndBlockStatement)
    | _ -> None

  let (|PropertyBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PropertyBlockSyntax as node ->
      Some (node.PropertyStatement, node.Accessors |> Seq.toList, node.EndPropertyStatement)
    | _ -> None

  let (|EventBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EventBlockSyntax as node ->
      Some (node.EventStatement, node.Accessors |> Seq.toList, node.EndEventStatement)
    | _ -> None

  let (|ParameterList|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ParameterListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|MethodStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MethodStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.SubOrFunctionKeyword, node.Identifier, node.TypeParameterList, node.ParameterList, node.AsClause, node.HandlesClause, node.ImplementsClause, node.DeclarationKeyword)
    | _ -> None

  let (|SubNewStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SubNewStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.SubKeyword, node.NewKeyword, node.ParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|DeclareStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DeclareStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.DeclareKeyword, node.CharsetKeyword, node.SubOrFunctionKeyword, node.Identifier, node.LibKeyword, node.LibraryName, node.AliasKeyword, node.AliasName, node.ParameterList, node.AsClause, node.DeclarationKeyword)
    | _ -> None

  let (|DelegateStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DelegateStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.DelegateKeyword, node.SubOrFunctionKeyword, node.Identifier, node.TypeParameterList, node.ParameterList, node.AsClause, node.DeclarationKeyword)
    | _ -> None

  let (|EventStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EventStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.CustomKeyword, node.EventKeyword, node.Identifier, node.ParameterList, node.AsClause, node.ImplementsClause, node.DeclarationKeyword)
    | _ -> None

  let (|OperatorStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OperatorStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.OperatorKeyword, node.OperatorToken, node.ParameterList, node.AsClause, node.DeclarationKeyword)
    | _ -> None

  let (|PropertyStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PropertyStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.PropertyKeyword, node.Identifier, node.ParameterList, node.AsClause, node.Initializer, node.ImplementsClause, node.DeclarationKeyword)
    | _ -> None

  let (|AccessorStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AccessorStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.AccessorKeyword, node.ParameterList, node.DeclarationKeyword)
    | _ -> None

  let (|ImplementsClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ImplementsClauseSyntax as node ->
      Some (node.ImplementsKeyword)
    | _ -> None

  let (|HandlesClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.HandlesClauseSyntax as node ->
      Some (node.HandlesKeyword)
    | _ -> None

  let (|KeywordEventContainer|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.KeywordEventContainerSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|WithEventsEventContainer|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WithEventsEventContainerSyntax as node ->
      Some (node.Identifier)
    | _ -> None

  let (|WithEventsPropertyEventContainer|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WithEventsPropertyEventContainerSyntax as node ->
      Some (node.WithEventsContainer, node.DotToken, node.Property)
    | _ -> None

  let (|HandlesClauseItem|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.HandlesClauseItemSyntax as node ->
      Some (node.EventContainer, node.DotToken, node.EventMember)
    | _ -> None

  let (|IncompleteMember|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.IncompleteMemberSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.MissingIdentifier)
    | _ -> None

  let (|FieldDeclaration|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FieldDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList)
    | _ -> None

  let (|VariableDeclarator|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.VariableDeclaratorSyntax as node ->
      Some (node.AsClause, node.Initializer)
    | _ -> None

  let (|SimpleAsClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleAsClauseSyntax as node ->
      Some (node.AsKeyword, node.AttributeLists |> Seq.toList, node.Type)
    | _ -> None

  let (|AsNewClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AsNewClauseSyntax as node ->
      Some (node.AsKeyword, node.NewExpression)
    | _ -> None

  let (|ObjectMemberInitializer|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectMemberInitializerSyntax as node ->
      Some (node.WithKeyword, node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|ObjectCollectionInitializer|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCollectionInitializerSyntax as node ->
      Some (node.FromKeyword, node.Initializer)
    | _ -> None

  let (|InferredFieldInitializer|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InferredFieldInitializerSyntax as node ->
      Some (node.KeyKeyword, node.Expression)
    | _ -> None

  let (|NamedFieldInitializer|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NamedFieldInitializerSyntax as node ->
      Some (node.KeyKeyword, node.DotToken, node.Name, node.EqualsToken, node.Expression)
    | _ -> None

  let (|EqualsValue|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EqualsValueSyntax as node ->
      Some (node.EqualsToken, node.Value)
    | _ -> None

  let (|Parameter|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ParameterSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Identifier, node.AsClause, node.Default)
    | _ -> None

  let (|ModifiedIdentifier|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ModifiedIdentifierSyntax as node ->
      Some (node.Identifier, node.Nullable, node.ArrayBounds, node.ArrayRankSpecifiers |> Seq.toList)
    | _ -> None

  let (|ArrayRankSpecifier|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ArrayRankSpecifierSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken, node.Rank)
    | _ -> None

  let (|AttributeList|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax as node ->
      Some (node.LessThanToken, node.GreaterThanToken)
    | _ -> None

  let (|Attribute|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeSyntax as node ->
      Some (node.Target, node.Name, node.ArgumentList)
    | _ -> None

  let (|AttributeTarget|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeTargetSyntax as node ->
      Some (node.AttributeModifier, node.ColonToken)
    | _ -> None

  let (|AttributesStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributesStatementSyntax as node ->
      Some (node.AttributeLists |> Seq.toList)
    | _ -> None

  let (|ExpressionStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionStatementSyntax as node ->
      Some (node.Expression)
    | _ -> None

  let (|PrintStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PrintStatementSyntax as node ->
      Some (node.QuestionToken, node.Expression)
    | _ -> None

  let (|WhileBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WhileBlockSyntax as node ->
      Some (node.WhileStatement, node.Statements |> Seq.toList, node.EndWhileStatement)
    | _ -> None

  let (|UsingBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.UsingBlockSyntax as node ->
      Some (node.UsingStatement, node.Statements |> Seq.toList, node.EndUsingStatement)
    | _ -> None

  let (|SyncLockBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SyncLockBlockSyntax as node ->
      Some (node.SyncLockStatement, node.Statements |> Seq.toList, node.EndSyncLockStatement)
    | _ -> None

  let (|WithBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WithBlockSyntax as node ->
      Some (node.WithStatement, node.Statements |> Seq.toList, node.EndWithStatement)
    | _ -> None

  let (|LabelStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LabelStatementSyntax as node ->
      Some (node.LabelToken, node.ColonToken)
    | _ -> None

  let (|GoToStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GoToStatementSyntax as node ->
      Some (node.GoToKeyword, node.Label)
    | _ -> None

  let (|Label|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LabelSyntax as node ->
      Some (node.LabelToken)
    | _ -> None

  let (|StopOrEndStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.StopOrEndStatementSyntax as node ->
      Some (node.StopOrEndKeyword)
    | _ -> None

  let (|ExitStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExitStatementSyntax as node ->
      Some (node.ExitKeyword, node.BlockKeyword)
    | _ -> None

  let (|ContinueStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ContinueStatementSyntax as node ->
      Some (node.ContinueKeyword, node.BlockKeyword)
    | _ -> None

  let (|ReturnStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ReturnStatementSyntax as node ->
      Some (node.ReturnKeyword, node.Expression)
    | _ -> None

  let (|SingleLineIfStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SingleLineIfStatementSyntax as node ->
      Some (node.IfKeyword, node.Condition, node.ThenKeyword, node.Statements |> Seq.toList, node.ElseClause)
    | _ -> None

  let (|SingleLineElseClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SingleLineElseClauseSyntax as node ->
      Some (node.ElseKeyword, node.Statements |> Seq.toList)
    | _ -> None

  let (|MultiLineIfBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MultiLineIfBlockSyntax as node ->
      Some (node.IfStatement, node.Statements |> Seq.toList, node.ElseIfBlocks |> Seq.toList, node.ElseBlock, node.EndIfStatement)
    | _ -> None

  let (|IfStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.IfStatementSyntax as node ->
      Some (node.IfKeyword, node.Condition, node.ThenKeyword)
    | _ -> None

  let (|ElseIfBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseIfBlockSyntax as node ->
      Some (node.ElseIfStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|ElseIfStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseIfStatementSyntax as node ->
      Some (node.ElseIfKeyword, node.Condition, node.ThenKeyword)
    | _ -> None

  let (|ElseBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseBlockSyntax as node ->
      Some (node.ElseStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|ElseStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseStatementSyntax as node ->
      Some (node.ElseKeyword)
    | _ -> None

  let (|TryBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TryBlockSyntax as node ->
      Some (node.TryStatement, node.Statements |> Seq.toList, node.CatchBlocks |> Seq.toList, node.FinallyBlock, node.EndTryStatement)
    | _ -> None

  let (|TryStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TryStatementSyntax as node ->
      Some (node.TryKeyword)
    | _ -> None

  let (|CatchBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CatchBlockSyntax as node ->
      Some (node.CatchStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|CatchStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CatchStatementSyntax as node ->
      Some (node.CatchKeyword, node.IdentifierName, node.AsClause, node.WhenClause)
    | _ -> None

  let (|CatchFilterClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CatchFilterClauseSyntax as node ->
      Some (node.WhenKeyword, node.Filter)
    | _ -> None

  let (|FinallyBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FinallyBlockSyntax as node ->
      Some (node.FinallyStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|FinallyStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FinallyStatementSyntax as node ->
      Some (node.FinallyKeyword)
    | _ -> None

  let (|ErrorStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ErrorStatementSyntax as node ->
      Some (node.ErrorKeyword, node.ErrorNumber)
    | _ -> None

  let (|OnErrorGoToStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OnErrorGoToStatementSyntax as node ->
      Some (node.OnKeyword, node.ErrorKeyword, node.GoToKeyword, node.Minus, node.Label)
    | _ -> None

  let (|OnErrorResumeNextStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OnErrorResumeNextStatementSyntax as node ->
      Some (node.OnKeyword, node.ErrorKeyword, node.ResumeKeyword, node.NextKeyword)
    | _ -> None

  let (|ResumeStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ResumeStatementSyntax as node ->
      Some (node.ResumeKeyword, node.Label)
    | _ -> None

  let (|SelectBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SelectBlockSyntax as node ->
      Some (node.SelectStatement, node.CaseBlocks |> Seq.toList, node.EndSelectStatement)
    | _ -> None

  let (|SelectStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SelectStatementSyntax as node ->
      Some (node.SelectKeyword, node.CaseKeyword, node.Expression)
    | _ -> None

  let (|CaseBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CaseBlockSyntax as node ->
      Some (node.CaseStatement, node.Statements |> Seq.toList)
    | _ -> None

  let (|CaseStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CaseStatementSyntax as node ->
      Some (node.CaseKeyword)
    | _ -> None

  let (|ElseCaseClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseCaseClauseSyntax as node ->
      Some (node.ElseKeyword)
    | _ -> None

  let (|SimpleCaseClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleCaseClauseSyntax as node ->
      Some (node.Value)
    | _ -> None

  let (|RangeCaseClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RangeCaseClauseSyntax as node ->
      Some (node.LowerBound, node.ToKeyword, node.UpperBound)
    | _ -> None

  let (|RelationalCaseClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RelationalCaseClauseSyntax as node ->
      Some (node.IsKeyword, node.OperatorToken, node.Value)
    | _ -> None

  let (|SyncLockStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SyncLockStatementSyntax as node ->
      Some (node.SyncLockKeyword, node.Expression)
    | _ -> None

  let (|DoLoopBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DoLoopBlockSyntax as node ->
      Some (node.DoStatement, node.Statements |> Seq.toList, node.LoopStatement)
    | _ -> None

  let (|DoStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DoStatementSyntax as node ->
      Some (node.DoKeyword, node.WhileOrUntilClause)
    | _ -> None

  let (|LoopStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LoopStatementSyntax as node ->
      Some (node.LoopKeyword, node.WhileOrUntilClause)
    | _ -> None

  let (|WhileOrUntilClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WhileOrUntilClauseSyntax as node ->
      Some (node.WhileOrUntilKeyword, node.Condition)
    | _ -> None

  let (|WhileStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WhileStatementSyntax as node ->
      Some (node.WhileKeyword, node.Condition)
    | _ -> None

  let (|ForBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForBlockSyntax as node ->
      Some (node.ForStatement, node.Statements |> Seq.toList, node.NextStatement, node.ForOrForEachStatement)
    | _ -> None

  let (|ForEachBlock|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForEachBlockSyntax as node ->
      Some (node.ForEachStatement, node.Statements |> Seq.toList, node.NextStatement, node.ForOrForEachStatement)
    | _ -> None

  let (|ForStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStatementSyntax as node ->
      Some (node.ForKeyword, node.ControlVariable, node.EqualsToken, node.FromValue, node.ToKeyword, node.ToValue, node.StepClause)
    | _ -> None

  let (|ForStepClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForStepClauseSyntax as node ->
      Some (node.StepKeyword, node.StepValue)
    | _ -> None

  let (|ForEachStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ForEachStatementSyntax as node ->
      Some (node.ForKeyword, node.EachKeyword, node.ControlVariable, node.InKeyword, node.Expression)
    | _ -> None

  let (|NextStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NextStatementSyntax as node ->
      Some (node.NextKeyword)
    | _ -> None

  let (|UsingStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.UsingStatementSyntax as node ->
      Some (node.UsingKeyword, node.Expression)
    | _ -> None

  let (|ThrowStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ThrowStatementSyntax as node ->
      Some (node.ThrowKeyword, node.Expression)
    | _ -> None

  let (|AssignmentStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax as node ->
      Some (node.Left, node.OperatorToken, node.Right)
    | _ -> None

  let (|MidExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax as node ->
      Some (node.Mid, node.ArgumentList)
    | _ -> None

  let (|CallStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CallStatementSyntax as node ->
      Some (node.CallKeyword, node.Invocation)
    | _ -> None

  let (|AddRemoveHandlerStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AddRemoveHandlerStatementSyntax as node ->
      Some (node.AddHandlerOrRemoveHandlerKeyword, node.EventExpression, node.CommaToken, node.DelegateExpression)
    | _ -> None

  let (|RaiseEventStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RaiseEventStatementSyntax as node ->
      Some (node.RaiseEventKeyword, node.Name, node.ArgumentList)
    | _ -> None

  let (|WithStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WithStatementSyntax as node ->
      Some (node.WithKeyword, node.Expression)
    | _ -> None

  let (|ReDimStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ReDimStatementSyntax as node ->
      Some (node.ReDimKeyword, node.PreserveKeyword)
    | _ -> None

  let (|RedimClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RedimClauseSyntax as node ->
      Some (node.Expression, node.ArrayBounds)
    | _ -> None

  let (|EraseStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EraseStatementSyntax as node ->
      Some (node.EraseKeyword)
    | _ -> None

  let (|LiteralExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LiteralExpressionSyntax as node ->
      Some (node.Token)
    | _ -> None

  let (|ParenthesizedExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ParenthesizedExpressionSyntax as node ->
      Some (node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|TupleExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TupleExpressionSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|TupleType|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TupleTypeSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|TypedTupleElement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypedTupleElementSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|NamedTupleElement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NamedTupleElementSyntax as node ->
      Some (node.Identifier, node.AsClause)
    | _ -> None

  let (|MeExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MeExpressionSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|MyBaseExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MyBaseExpressionSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|MyClassExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MyClassExpressionSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|GetTypeExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GetTypeExpressionSyntax as node ->
      Some (node.GetTypeKeyword, node.OpenParenToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|TypeOfExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeOfExpressionSyntax as node ->
      Some (node.TypeOfKeyword, node.Expression, node.OperatorToken, node.Type)
    | _ -> None

  let (|GetXmlNamespaceExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GetXmlNamespaceExpressionSyntax as node ->
      Some (node.GetXmlNamespaceKeyword, node.OpenParenToken, node.Name, node.CloseParenToken)
    | _ -> None

  let (|MemberAccessExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MemberAccessExpressionSyntax as node ->
      Some (node.Expression, node.OperatorToken, node.Name)
    | _ -> None

  let (|XmlMemberAccessExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlMemberAccessExpressionSyntax as node ->
      Some (node.Base, node.Token1, node.Token2, node.Token3, node.Name)
    | _ -> None

  let (|InvocationExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InvocationExpressionSyntax as node ->
      Some (node.Expression, node.ArgumentList)
    | _ -> None

  let (|ObjectCreationExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ObjectCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.AttributeLists |> Seq.toList, node.Type, node.ArgumentList, node.Initializer)
    | _ -> None

  let (|AnonymousObjectCreationExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AnonymousObjectCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.AttributeLists |> Seq.toList, node.Initializer)
    | _ -> None

  let (|ArrayCreationExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ArrayCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.AttributeLists |> Seq.toList, node.Type, node.ArrayBounds, node.RankSpecifiers |> Seq.toList, node.Initializer)
    | _ -> None

  let (|CollectionInitializer|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CollectionInitializerSyntax as node ->
      Some (node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|CTypeExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CTypeExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CommaToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|DirectCastExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DirectCastExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CommaToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|TryCastExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TryCastExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CommaToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|PredefinedCastExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PredefinedCastExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|BinaryExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax as node ->
      Some (node.Left, node.OperatorToken, node.Right)
    | _ -> None

  let (|UnaryExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.UnaryExpressionSyntax as node ->
      Some (node.OperatorToken, node.Operand)
    | _ -> None

  let (|BinaryConditionalExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryConditionalExpressionSyntax as node ->
      Some (node.IfKeyword, node.OpenParenToken, node.FirstExpression, node.CommaToken, node.SecondExpression, node.CloseParenToken)
    | _ -> None

  let (|TernaryConditionalExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TernaryConditionalExpressionSyntax as node ->
      Some (node.IfKeyword, node.OpenParenToken, node.Condition, node.FirstCommaToken, node.WhenTrue, node.SecondCommaToken, node.WhenFalse, node.CloseParenToken)
    | _ -> None

  let (|SingleLineLambdaExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SingleLineLambdaExpressionSyntax as node ->
      Some (node.SubOrFunctionHeader, node.Body)
    | _ -> None

  let (|MultiLineLambdaExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.MultiLineLambdaExpressionSyntax as node ->
      Some (node.SubOrFunctionHeader, node.Statements |> Seq.toList, node.EndSubOrFunctionStatement)
    | _ -> None

  let (|LambdaHeader|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LambdaHeaderSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.SubOrFunctionKeyword, node.ParameterList, node.AsClause, node.DeclarationKeyword)
    | _ -> None

  let (|ArgumentList|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ArgumentListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|OmittedArgument|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OmittedArgumentSyntax as node ->
      Some (node.Empty, node.IsNamed)
    | _ -> None

  let (|SimpleArgument|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleArgumentSyntax as node ->
      Some (node.NameColonEquals, node.Expression, node.IsNamed)
    | _ -> None

  let (|NameColonEquals|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NameColonEqualsSyntax as node ->
      Some (node.Name, node.ColonEqualsToken)
    | _ -> None

  let (|RangeArgument|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RangeArgumentSyntax as node ->
      Some (node.LowerBound, node.ToKeyword, node.UpperBound, node.IsNamed)
    | _ -> None

  let (|QueryExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.QueryExpressionSyntax as node ->
      Some (node.Clauses |> Seq.toList)
    | _ -> None

  let (|CollectionRangeVariable|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CollectionRangeVariableSyntax as node ->
      Some (node.Identifier, node.AsClause, node.InKeyword, node.Expression)
    | _ -> None

  let (|ExpressionRangeVariable|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionRangeVariableSyntax as node ->
      Some (node.NameEquals, node.Expression)
    | _ -> None

  let (|AggregationRangeVariable|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AggregationRangeVariableSyntax as node ->
      Some (node.NameEquals, node.Aggregation)
    | _ -> None

  let (|VariableNameEquals|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.VariableNameEqualsSyntax as node ->
      Some (node.Identifier, node.AsClause, node.EqualsToken)
    | _ -> None

  let (|FunctionAggregation|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FunctionAggregationSyntax as node ->
      Some (node.FunctionName, node.OpenParenToken, node.Argument, node.CloseParenToken)
    | _ -> None

  let (|GroupAggregation|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GroupAggregationSyntax as node ->
      Some (node.GroupKeyword)
    | _ -> None

  let (|FromClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.FromClauseSyntax as node ->
      Some (node.FromKeyword)
    | _ -> None

  let (|LetClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.LetClauseSyntax as node ->
      Some (node.LetKeyword)
    | _ -> None

  let (|AggregateClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AggregateClauseSyntax as node ->
      Some (node.AggregateKeyword, node.AdditionalQueryOperators |> Seq.toList, node.IntoKeyword)
    | _ -> None

  let (|DistinctClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DistinctClauseSyntax as node ->
      Some (node.DistinctKeyword)
    | _ -> None

  let (|WhereClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.WhereClauseSyntax as node ->
      Some (node.WhereKeyword, node.Condition)
    | _ -> None

  let (|PartitionWhileClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PartitionWhileClauseSyntax as node ->
      Some (node.SkipOrTakeKeyword, node.WhileKeyword, node.Condition)
    | _ -> None

  let (|PartitionClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PartitionClauseSyntax as node ->
      Some (node.SkipOrTakeKeyword, node.Count)
    | _ -> None

  let (|GroupByClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GroupByClauseSyntax as node ->
      Some (node.GroupKeyword, node.ByKeyword, node.IntoKeyword)
    | _ -> None

  let (|JoinCondition|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.JoinConditionSyntax as node ->
      Some (node.Left, node.EqualsKeyword, node.Right)
    | _ -> None

  let (|SimpleJoinClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SimpleJoinClauseSyntax as node ->
      Some (node.JoinKeyword, node.AdditionalJoins |> Seq.toList, node.OnKeyword)
    | _ -> None

  let (|GroupJoinClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GroupJoinClauseSyntax as node ->
      Some (node.GroupKeyword, node.JoinKeyword, node.AdditionalJoins |> Seq.toList, node.OnKeyword, node.IntoKeyword)
    | _ -> None

  let (|OrderByClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OrderByClauseSyntax as node ->
      Some (node.OrderKeyword, node.ByKeyword)
    | _ -> None

  let (|Ordering|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.OrderingSyntax as node ->
      Some (node.Expression, node.AscendingOrDescendingKeyword)
    | _ -> None

  let (|SelectClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.SelectClauseSyntax as node ->
      Some (node.SelectKeyword)
    | _ -> None

  let (|XmlDocument|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlDocumentSyntax as node ->
      Some (node.Declaration, node.PrecedingMisc |> Seq.toList, node.Root, node.FollowingMisc |> Seq.toList)
    | _ -> None

  let (|XmlDeclaration|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlDeclarationSyntax as node ->
      Some (node.LessThanQuestionToken, node.XmlKeyword, node.Version, node.Encoding, node.Standalone, node.QuestionGreaterThanToken)
    | _ -> None

  let (|XmlDeclarationOption|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlDeclarationOptionSyntax as node ->
      Some (node.Name, node.Equals, node.Value)
    | _ -> None

  let (|XmlElement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlElementSyntax as node ->
      Some (node.StartTag, node.Content |> Seq.toList, node.EndTag)
    | _ -> None

  let (|XmlElementStartTag|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlElementStartTagSyntax as node ->
      Some (node.LessThanToken, node.Name, node.Attributes |> Seq.toList, node.GreaterThanToken)
    | _ -> None

  let (|XmlElementEndTag|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlElementEndTagSyntax as node ->
      Some (node.LessThanSlashToken, node.Name, node.GreaterThanToken)
    | _ -> None

  let (|XmlEmptyElement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlEmptyElementSyntax as node ->
      Some (node.LessThanToken, node.Name, node.Attributes |> Seq.toList, node.SlashGreaterThanToken)
    | _ -> None

  let (|XmlAttribute|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.Value)
    | _ -> None

  let (|XmlString|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlStringSyntax as node ->
      Some (node.StartQuoteToken, node.EndQuoteToken)
    | _ -> None

  let (|XmlPrefixName|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlPrefixNameSyntax as node ->
      Some (node.Name)
    | _ -> None

  let (|XmlName|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlNameSyntax as node ->
      Some (node.Prefix, node.LocalName)
    | _ -> None

  let (|XmlBracketedName|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlBracketedNameSyntax as node ->
      Some (node.LessThanToken, node.Name, node.GreaterThanToken)
    | _ -> None

  let (|XmlPrefix|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlPrefixSyntax as node ->
      Some (node.Name, node.ColonToken)
    | _ -> None

  let (|XmlComment|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlCommentSyntax as node ->
      Some (node.LessThanExclamationMinusMinusToken, node.MinusMinusGreaterThanToken)
    | _ -> None

  let (|XmlProcessingInstruction|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlProcessingInstructionSyntax as node ->
      Some (node.LessThanQuestionToken, node.Name, node.QuestionGreaterThanToken)
    | _ -> None

  let (|XmlCDataSection|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlCDataSectionSyntax as node ->
      Some (node.BeginCDataToken, node.EndCDataToken)
    | _ -> None

  let (|XmlEmbeddedExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlEmbeddedExpressionSyntax as node ->
      Some (node.LessThanPercentEqualsToken, node.Expression, node.PercentGreaterThanToken)
    | _ -> None

  let (|ArrayType|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ArrayTypeSyntax as node ->
      Some (node.ElementType, node.RankSpecifiers |> Seq.toList)
    | _ -> None

  let (|NullableType|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NullableTypeSyntax as node ->
      Some (node.ElementType, node.QuestionMarkToken)
    | _ -> None

  let (|PredefinedType|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.PredefinedTypeSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|IdentifierName|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.IdentifierNameSyntax as node ->
      Some (node.Identifier)
    | _ -> None

  let (|GenericName|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GenericNameSyntax as node ->
      Some (node.Identifier, node.TypeArgumentList)
    | _ -> None

  let (|QualifiedName|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.QualifiedNameSyntax as node ->
      Some (node.Left, node.DotToken, node.Right)
    | _ -> None

  let (|GlobalName|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.GlobalNameSyntax as node ->
      Some (node.GlobalKeyword)
    | _ -> None

  let (|TypeArgumentList|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeArgumentListSyntax as node ->
      Some (node.OpenParenToken, node.OfKeyword, node.CloseParenToken)
    | _ -> None

  let (|CrefReference|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CrefReferenceSyntax as node ->
      Some (node.Name, node.Signature, node.AsClause)
    | _ -> None

  let (|CrefSignature|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CrefSignatureSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|CrefSignaturePart|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CrefSignaturePartSyntax as node ->
      Some (node.Modifier, node.Type)
    | _ -> None

  let (|CrefOperatorReference|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.CrefOperatorReferenceSyntax as node ->
      Some (node.OperatorKeyword, node.OperatorToken)
    | _ -> None

  let (|QualifiedCrefOperatorReference|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.QualifiedCrefOperatorReferenceSyntax as node ->
      Some (node.Left, node.DotToken, node.Right)
    | _ -> None

  let (|YieldStatement|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.YieldStatementSyntax as node ->
      Some (node.YieldKeyword, node.Expression)
    | _ -> None

  let (|AwaitExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.AwaitExpressionSyntax as node ->
      Some (node.AwaitKeyword, node.Expression)
    | _ -> None

  let (|DocumentationCommentTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DocumentationCommentTriviaSyntax as node ->
      Some (node.Content |> Seq.toList)
    | _ -> None

  let (|XmlCrefAttribute|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlCrefAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.Reference, node.EndQuoteToken)
    | _ -> None

  let (|XmlNameAttribute|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.XmlNameAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.Reference, node.EndQuoteToken)
    | _ -> None

  let (|ConditionalAccessExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ConditionalAccessExpressionSyntax as node ->
      Some (node.Expression, node.QuestionMarkToken, node.WhenNotNull)
    | _ -> None

  let (|NameOfExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.NameOfExpressionSyntax as node ->
      Some (node.NameOfKeyword, node.OpenParenToken, node.Argument, node.CloseParenToken)
    | _ -> None

  let (|InterpolatedStringExpression|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolatedStringExpressionSyntax as node ->
      Some (node.DollarSignDoubleQuoteToken, node.Contents |> Seq.toList, node.DoubleQuoteToken)
    | _ -> None

  let (|InterpolatedStringText|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolatedStringTextSyntax as node ->
      Some (node.TextToken)
    | _ -> None

  let (|Interpolation|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolationSyntax as node ->
      Some (node.OpenBraceToken, node.Expression, node.AlignmentClause, node.FormatClause, node.CloseBraceToken)
    | _ -> None

  let (|InterpolationAlignmentClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolationAlignmentClauseSyntax as node ->
      Some (node.CommaToken, node.Value)
    | _ -> None

  let (|InterpolationFormatClause|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.InterpolationFormatClauseSyntax as node ->
      Some (node.ColonToken, node.FormatStringToken)
    | _ -> None

  let (|ConstDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ConstDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ConstKeyword, node.Name, node.EqualsToken, node.Value)
    | _ -> None

  let (|IfDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.IfDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ElseKeyword, node.IfOrElseIfKeyword, node.Condition, node.ThenKeyword)
    | _ -> None

  let (|ElseDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ElseDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ElseKeyword)
    | _ -> None

  let (|EndIfDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EndIfDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndKeyword, node.IfKeyword)
    | _ -> None

  let (|RegionDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.RegionDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.RegionKeyword, node.Name)
    | _ -> None

  let (|EndRegionDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EndRegionDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndKeyword, node.RegionKeyword)
    | _ -> None

  let (|ExternalSourceDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExternalSourceDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ExternalSourceKeyword, node.OpenParenToken, node.ExternalSource, node.CommaToken, node.LineStart, node.CloseParenToken)
    | _ -> None

  let (|EndExternalSourceDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EndExternalSourceDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndKeyword, node.ExternalSourceKeyword)
    | _ -> None

  let (|ExternalChecksumDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ExternalChecksumDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ExternalChecksumKeyword, node.OpenParenToken, node.ExternalSource, node.FirstCommaToken, node.Guid, node.SecondCommaToken, node.Checksum, node.CloseParenToken)
    | _ -> None

  let (|EnableWarningDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.EnableWarningDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EnableKeyword, node.WarningKeyword)
    | _ -> None

  let (|DisableWarningDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.DisableWarningDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.DisableKeyword, node.WarningKeyword)
    | _ -> None

  let (|ReferenceDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.ReferenceDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ReferenceKeyword, node.File)
    | _ -> None

  let (|BadDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.VisualBasic.Syntax.BadDirectiveTriviaSyntax as node ->
      Some (node.HashToken)
    | _ -> None

