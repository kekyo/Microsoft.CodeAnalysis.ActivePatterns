namespace Microsoft.CodeAnalysis.CSharp

[<AutoOpen>]
module ActivePatterns =

  let (|AliasQualifiedNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax as node ->
      Some (node.Alias, node.ColonColonToken, node.Name)
    | _ -> None

  let (|ArrayRankSpecifierSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax as node ->
      Some (node.Rank, node.OpenBracketToken, node.CloseBracketToken)
    | _ -> None

  let (|AttributeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax as node ->
      Some (node.Name, node.ArgumentList)
    | _ -> None

  let (|AttributeTargetSpecifierSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax as node ->
      Some (node.Identifier, node.ColonToken)
    | _ -> None

  let (|CompilationUnitSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax as node ->
      Some (node.Externs |> Seq.toList, node.Usings |> Seq.toList, node.AttributeLists |> Seq.toList, node.Members |> Seq.toList, node.EndOfFileToken)
    | _ -> None

  let (|LocalDeclarationStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax as node ->
      Some (node.IsConst, node.Declaration, node.SemicolonToken)
    | _ -> None

  let (|DelegateDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax as node ->
      Some (node.Arity, node.AttributeLists |> Seq.toList, node.DelegateKeyword, node.ReturnType, node.Identifier, node.TypeParameterList, node.ParameterList, node.ConstraintClauses |> Seq.toList, node.SemicolonToken)
    | _ -> None

  let (|ExpressionStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax as node ->
      Some (node.AllowsAnyExpression, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|GenericNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax as node ->
      Some (node.IsUnboundGenericName, node.Identifier, node.TypeArgumentList)
    | _ -> None

  let (|IdentifierNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax as node ->
      Some (node.Identifier)
    | _ -> None

  let (|PropertyDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Type, node.ExplicitInterfaceSpecifier, node.Identifier, node.AccessorList, node.ExpressionBody, node.Initializer, node.SemicolonToken)
    | _ -> None

  let (|AnonymousMethodExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax as node ->
      Some (node.Block, node.AsyncKeyword, node.DelegateKeyword, node.ParameterList, node.Body)
    | _ -> None

  let (|IndexerDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Type, node.ExplicitInterfaceSpecifier, node.ThisKeyword, node.ParameterList, node.AccessorList, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|MethodDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax as node ->
      Some (node.Arity, node.AttributeLists |> Seq.toList, node.ReturnType, node.ExplicitInterfaceSpecifier, node.Identifier, node.TypeParameterList, node.ParameterList, node.ConstraintClauses |> Seq.toList, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|NamespaceDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax as node ->
      Some (node.NamespaceKeyword, node.Name, node.OpenBraceToken, node.Externs |> Seq.toList, node.Usings |> Seq.toList, node.Members |> Seq.toList, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|ParameterListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|ParameterSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Type, node.Identifier, node.Default)
    | _ -> None

  let (|QualifiedNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax as node ->
      Some (node.Left, node.DotToken, node.Right)
    | _ -> None

  let (|SkippedTokensTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax as node ->
      Some ()
    | _ -> None

  let (|TypeArgumentListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax as node ->
      Some (node.LessThanToken, node.GreaterThanToken)
    | _ -> None

  let (|PredefinedTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|ArrayTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax as node ->
      Some (node.ElementType, node.RankSpecifiers |> Seq.toList)
    | _ -> None

  let (|PointerTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax as node ->
      Some (node.ElementType, node.AsteriskToken)
    | _ -> None

  let (|NullableTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax as node ->
      Some (node.ElementType, node.QuestionToken)
    | _ -> None

  let (|OmittedTypeArgumentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax as node ->
      Some (node.OmittedTypeArgumentToken)
    | _ -> None

  let (|ParenthesizedExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax as node ->
      Some (node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|PrefixUnaryExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax as node ->
      Some (node.OperatorToken, node.Operand)
    | _ -> None

  let (|AwaitExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax as node ->
      Some (node.AwaitKeyword, node.Expression)
    | _ -> None

  let (|PostfixUnaryExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax as node ->
      Some (node.Operand, node.OperatorToken)
    | _ -> None

  let (|MemberAccessExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax as node ->
      Some (node.Expression, node.OperatorToken, node.Name)
    | _ -> None

  let (|ConditionalAccessExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax as node ->
      Some (node.Expression, node.OperatorToken, node.WhenNotNull)
    | _ -> None

  let (|MemberBindingExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax as node ->
      Some (node.OperatorToken, node.Name)
    | _ -> None

  let (|ElementBindingExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax as node ->
      Some (node.ArgumentList)
    | _ -> None

  let (|ImplicitElementAccessSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax as node ->
      Some (node.ArgumentList)
    | _ -> None

  let (|BinaryExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax as node ->
      Some (node.Left, node.OperatorToken, node.Right)
    | _ -> None

  let (|AssignmentExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax as node ->
      Some (node.Left, node.OperatorToken, node.Right)
    | _ -> None

  let (|ConditionalExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax as node ->
      Some (node.Condition, node.QuestionToken, node.WhenTrue, node.ColonToken, node.WhenFalse)
    | _ -> None

  let (|ThisExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax as node ->
      Some (node.Token)
    | _ -> None

  let (|BaseExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax as node ->
      Some (node.Token)
    | _ -> None

  let (|LiteralExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax as node ->
      Some (node.Token)
    | _ -> None

  let (|MakeRefExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|RefTypeExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|RefValueExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.Comma, node.Type, node.CloseParenToken)
    | _ -> None

  let (|CheckedExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|DefaultExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|TypeOfExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|SizeOfExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|InvocationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax as node ->
      Some (node.Expression, node.ArgumentList)
    | _ -> None

  let (|ElementAccessExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax as node ->
      Some (node.Expression, node.ArgumentList)
    | _ -> None

  let (|ArgumentListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|BracketedArgumentListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax as node ->
      Some (node.OpenBracketToken, node.CloseBracketToken)
    | _ -> None

  let (|ArgumentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax as node ->
      Some (node.NameColon, node.RefOrOutKeyword, node.Expression)
    | _ -> None

  let (|NameColonSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax as node ->
      Some (node.Name, node.ColonToken)
    | _ -> None

  let (|CastExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax as node ->
      Some (node.OpenParenToken, node.Type, node.CloseParenToken, node.Expression)
    | _ -> None

  let (|SimpleLambdaExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax as node ->
      Some (node.AsyncKeyword, node.Parameter, node.ArrowToken, node.Body)
    | _ -> None

  let (|ParenthesizedLambdaExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax as node ->
      Some (node.AsyncKeyword, node.ParameterList, node.ArrowToken, node.Body)
    | _ -> None

  let (|InitializerExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax as node ->
      Some (node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|ObjectCreationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.Type, node.ArgumentList, node.Initializer)
    | _ -> None

  let (|AnonymousObjectMemberDeclaratorSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax as node ->
      Some (node.NameEquals, node.Expression)
    | _ -> None

  let (|AnonymousObjectCreationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|ArrayCreationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.Type, node.Initializer)
    | _ -> None

  let (|ImplicitArrayCreationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.OpenBracketToken, node.CloseBracketToken, node.Initializer)
    | _ -> None

  let (|StackAllocArrayCreationExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax as node ->
      Some (node.StackAllocKeyword, node.Type)
    | _ -> None

  let (|QueryExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax as node ->
      Some (node.FromClause, node.Body)
    | _ -> None

  let (|QueryBodySyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax as node ->
      Some (node.Clauses |> Seq.toList, node.SelectOrGroup, node.Continuation)
    | _ -> None

  let (|FromClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax as node ->
      Some (node.FromKeyword, node.Type, node.Identifier, node.InKeyword, node.Expression)
    | _ -> None

  let (|LetClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax as node ->
      Some (node.LetKeyword, node.Identifier, node.EqualsToken, node.Expression)
    | _ -> None

  let (|JoinClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax as node ->
      Some (node.JoinKeyword, node.Type, node.Identifier, node.InKeyword, node.InExpression, node.OnKeyword, node.LeftExpression, node.EqualsKeyword, node.RightExpression, node.Into)
    | _ -> None

  let (|JoinIntoClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax as node ->
      Some (node.IntoKeyword, node.Identifier)
    | _ -> None

  let (|WhereClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax as node ->
      Some (node.WhereKeyword, node.Condition)
    | _ -> None

  let (|OrderByClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax as node ->
      Some (node.OrderByKeyword)
    | _ -> None

  let (|OrderingSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax as node ->
      Some (node.Expression, node.AscendingOrDescendingKeyword)
    | _ -> None

  let (|SelectClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax as node ->
      Some (node.SelectKeyword, node.Expression)
    | _ -> None

  let (|GroupClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax as node ->
      Some (node.GroupKeyword, node.GroupExpression, node.ByKeyword, node.ByExpression)
    | _ -> None

  let (|QueryContinuationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax as node ->
      Some (node.IntoKeyword, node.Identifier, node.Body)
    | _ -> None

  let (|OmittedArraySizeExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax as node ->
      Some (node.OmittedArraySizeExpressionToken)
    | _ -> None

  let (|InterpolatedStringExpressionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax as node ->
      Some (node.StringStartToken, node.Contents |> Seq.toList, node.StringEndToken)
    | _ -> None

  let (|InterpolatedStringTextSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringTextSyntax as node ->
      Some (node.TextToken)
    | _ -> None

  let (|InterpolationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax as node ->
      Some (node.OpenBraceToken, node.Expression, node.AlignmentClause, node.FormatClause, node.CloseBraceToken)
    | _ -> None

  let (|InterpolationAlignmentClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax as node ->
      Some (node.CommaToken, node.Value)
    | _ -> None

  let (|InterpolationFormatClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax as node ->
      Some (node.ColonToken, node.FormatStringToken)
    | _ -> None

  let (|GlobalStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax as node ->
      Some (node.Statement)
    | _ -> None

  let (|BlockSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax as node ->
      Some (node.OpenBraceToken, node.Statements |> Seq.toList, node.CloseBraceToken)
    | _ -> None

  let (|VariableDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|VariableDeclaratorSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax as node ->
      Some (node.Identifier, node.ArgumentList, node.Initializer)
    | _ -> None

  let (|EqualsValueClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax as node ->
      Some (node.EqualsToken, node.Value)
    | _ -> None

  let (|EmptyStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax as node ->
      Some (node.SemicolonToken)
    | _ -> None

  let (|LabeledStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax as node ->
      Some (node.Identifier, node.ColonToken, node.Statement)
    | _ -> None

  let (|GotoStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax as node ->
      Some (node.GotoKeyword, node.CaseOrDefaultKeyword, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|BreakStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax as node ->
      Some (node.BreakKeyword, node.SemicolonToken)
    | _ -> None

  let (|ContinueStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax as node ->
      Some (node.ContinueKeyword, node.SemicolonToken)
    | _ -> None

  let (|ReturnStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax as node ->
      Some (node.ReturnKeyword, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|ThrowStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax as node ->
      Some (node.ThrowKeyword, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|YieldStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax as node ->
      Some (node.YieldKeyword, node.ReturnOrBreakKeyword, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|WhileStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax as node ->
      Some (node.WhileKeyword, node.OpenParenToken, node.Condition, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|DoStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax as node ->
      Some (node.DoKeyword, node.Statement, node.WhileKeyword, node.OpenParenToken, node.Condition, node.CloseParenToken, node.SemicolonToken)
    | _ -> None

  let (|ForStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax as node ->
      Some (node.ForKeyword, node.OpenParenToken, node.Declaration, node.FirstSemicolonToken, node.Condition, node.SecondSemicolonToken, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|ForEachStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax as node ->
      Some (node.ForEachKeyword, node.OpenParenToken, node.Type, node.Identifier, node.InKeyword, node.Expression, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|UsingStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax as node ->
      Some (node.UsingKeyword, node.OpenParenToken, node.Declaration, node.Expression, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|FixedStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax as node ->
      Some (node.FixedKeyword, node.OpenParenToken, node.Declaration, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|CheckedStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax as node ->
      Some (node.Keyword, node.Block)
    | _ -> None

  let (|UnsafeStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax as node ->
      Some (node.UnsafeKeyword, node.Block)
    | _ -> None

  let (|LockStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax as node ->
      Some (node.LockKeyword, node.OpenParenToken, node.Expression, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|IfStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax as node ->
      Some (node.IfKeyword, node.OpenParenToken, node.Condition, node.CloseParenToken, node.Statement, node.Else)
    | _ -> None

  let (|ElseClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax as node ->
      Some (node.ElseKeyword, node.Statement)
    | _ -> None

  let (|SwitchStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax as node ->
      Some (node.SwitchKeyword, node.OpenParenToken, node.Expression, node.CloseParenToken, node.OpenBraceToken, node.Sections |> Seq.toList, node.CloseBraceToken)
    | _ -> None

  let (|SwitchSectionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax as node ->
      Some (node.Labels |> Seq.toList, node.Statements |> Seq.toList)
    | _ -> None

  let (|CaseSwitchLabelSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax as node ->
      Some (node.Keyword, node.Value, node.ColonToken)
    | _ -> None

  let (|DefaultSwitchLabelSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax as node ->
      Some (node.Keyword, node.ColonToken)
    | _ -> None

  let (|TryStatementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax as node ->
      Some (node.TryKeyword, node.Block, node.Catches |> Seq.toList, node.Finally)
    | _ -> None

  let (|CatchClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax as node ->
      Some (node.CatchKeyword, node.Declaration, node.Filter, node.Block)
    | _ -> None

  let (|CatchDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax as node ->
      Some (node.OpenParenToken, node.Type, node.Identifier, node.CloseParenToken)
    | _ -> None

  let (|CatchFilterClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax as node ->
      Some (node.WhenKeyword, node.OpenParenToken, node.FilterExpression, node.CloseParenToken)
    | _ -> None

  let (|FinallyClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax as node ->
      Some (node.FinallyKeyword, node.Block)
    | _ -> None

  let (|ExternAliasDirectiveSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax as node ->
      Some (node.ExternKeyword, node.AliasKeyword, node.Identifier, node.SemicolonToken)
    | _ -> None

  let (|UsingDirectiveSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax as node ->
      Some (node.UsingKeyword, node.StaticKeyword, node.Alias, node.Name, node.SemicolonToken)
    | _ -> None

  let (|AttributeListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax as node ->
      Some (node.OpenBracketToken, node.Target, node.CloseBracketToken)
    | _ -> None

  let (|AttributeArgumentListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|AttributeArgumentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax as node ->
      Some (node.NameEquals, node.NameColon, node.Expression)
    | _ -> None

  let (|NameEqualsSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax as node ->
      Some (node.Name, node.EqualsToken)
    | _ -> None

  let (|TypeParameterListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax as node ->
      Some (node.LessThanToken, node.GreaterThanToken)
    | _ -> None

  let (|TypeParameterSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.VarianceKeyword, node.Identifier)
    | _ -> None

  let (|ClassDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Keyword, node.Identifier, node.TypeParameterList, node.BaseList, node.ConstraintClauses |> Seq.toList, node.OpenBraceToken, node.Members |> Seq.toList, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|StructDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Keyword, node.Identifier, node.TypeParameterList, node.BaseList, node.ConstraintClauses |> Seq.toList, node.OpenBraceToken, node.Members |> Seq.toList, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|InterfaceDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Keyword, node.Identifier, node.TypeParameterList, node.BaseList, node.ConstraintClauses |> Seq.toList, node.OpenBraceToken, node.Members |> Seq.toList, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|EnumDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.EnumKeyword, node.Identifier, node.BaseList, node.OpenBraceToken, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|EnumMemberDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Identifier, node.EqualsValue)
    | _ -> None

  let (|BaseListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax as node ->
      Some (node.ColonToken)
    | _ -> None

  let (|SimpleBaseTypeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|TypeParameterConstraintClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax as node ->
      Some (node.WhereKeyword, node.Name, node.ColonToken)
    | _ -> None

  let (|ConstructorConstraintSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax as node ->
      Some (node.NewKeyword, node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|ClassOrStructConstraintSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax as node ->
      Some (node.ClassOrStructKeyword)
    | _ -> None

  let (|TypeConstraintSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|FieldDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Declaration, node.SemicolonToken)
    | _ -> None

  let (|EventFieldDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.EventKeyword, node.Declaration, node.SemicolonToken)
    | _ -> None

  let (|ExplicitInterfaceSpecifierSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax as node ->
      Some (node.Name, node.DotToken)
    | _ -> None

  let (|OperatorDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ReturnType, node.OperatorKeyword, node.OperatorToken, node.ParameterList, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|ConversionOperatorDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ImplicitOrExplicitKeyword, node.OperatorKeyword, node.Type, node.ParameterList, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|ConstructorDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Identifier, node.ParameterList, node.Initializer, node.Body, node.SemicolonToken)
    | _ -> None

  let (|ConstructorInitializerSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax as node ->
      Some (node.ColonToken, node.ThisOrBaseKeyword, node.ArgumentList)
    | _ -> None

  let (|DestructorDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.TildeToken, node.Identifier, node.ParameterList, node.Body, node.SemicolonToken)
    | _ -> None

  let (|ArrowExpressionClauseSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax as node ->
      Some (node.ArrowToken, node.Expression)
    | _ -> None

  let (|EventDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.EventKeyword, node.Type, node.ExplicitInterfaceSpecifier, node.Identifier, node.AccessorList)
    | _ -> None

  let (|AccessorListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax as node ->
      Some (node.OpenBraceToken, node.Accessors |> Seq.toList, node.CloseBraceToken)
    | _ -> None

  let (|AccessorDeclarationSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Keyword, node.Body, node.SemicolonToken)
    | _ -> None

  let (|BracketedParameterListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax as node ->
      Some (node.OpenBracketToken, node.CloseBracketToken)
    | _ -> None

  let (|IncompleteMemberSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Type)
    | _ -> None

  let (|DocumentationCommentTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax as node ->
      Some (node.Content |> Seq.toList, node.EndOfComment)
    | _ -> None

  let (|TypeCrefSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|QualifiedCrefSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax as node ->
      Some (node.Container, node.DotToken, node.Member)
    | _ -> None

  let (|NameMemberCrefSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax as node ->
      Some (node.Name, node.Parameters)
    | _ -> None

  let (|IndexerMemberCrefSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax as node ->
      Some (node.ThisKeyword, node.Parameters)
    | _ -> None

  let (|OperatorMemberCrefSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax as node ->
      Some (node.OperatorKeyword, node.OperatorToken, node.Parameters)
    | _ -> None

  let (|ConversionOperatorMemberCrefSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax as node ->
      Some (node.ImplicitOrExplicitKeyword, node.OperatorKeyword, node.Type, node.Parameters)
    | _ -> None

  let (|CrefParameterListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|CrefBracketedParameterListSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax as node ->
      Some (node.OpenBracketToken, node.CloseBracketToken)
    | _ -> None

  let (|CrefParameterSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax as node ->
      Some (node.RefOrOutKeyword, node.Type)
    | _ -> None

  let (|XmlElementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax as node ->
      Some (node.StartTag, node.Content |> Seq.toList, node.EndTag)
    | _ -> None

  let (|XmlElementStartTagSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax as node ->
      Some (node.LessThanToken, node.Name, node.Attributes |> Seq.toList, node.GreaterThanToken)
    | _ -> None

  let (|XmlElementEndTagSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax as node ->
      Some (node.LessThanSlashToken, node.Name, node.GreaterThanToken)
    | _ -> None

  let (|XmlEmptyElementSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax as node ->
      Some (node.LessThanToken, node.Name, node.Attributes |> Seq.toList, node.SlashGreaterThanToken)
    | _ -> None

  let (|XmlNameSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax as node ->
      Some (node.Prefix, node.LocalName)
    | _ -> None

  let (|XmlPrefixSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax as node ->
      Some (node.Prefix, node.ColonToken)
    | _ -> None

  let (|XmlTextAttributeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.EndQuoteToken)
    | _ -> None

  let (|XmlCrefAttributeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.Cref, node.EndQuoteToken)
    | _ -> None

  let (|XmlNameAttributeSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.Identifier, node.EndQuoteToken)
    | _ -> None

  let (|XmlTextSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax as node ->
      Some ()
    | _ -> None

  let (|XmlCDataSectionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax as node ->
      Some (node.StartCDataToken, node.EndCDataToken)
    | _ -> None

  let (|XmlProcessingInstructionSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax as node ->
      Some (node.StartProcessingInstructionToken, node.Name, node.EndProcessingInstructionToken)
    | _ -> None

  let (|XmlCommentSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax as node ->
      Some (node.LessThanExclamationMinusMinusToken, node.MinusMinusGreaterThanToken)
    | _ -> None

  let (|IfDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.IfKeyword, node.Condition, node.EndOfDirectiveToken, node.IsActive, node.BranchTaken, node.ConditionValue)
    | _ -> None

  let (|ElifDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ElifKeyword, node.Condition, node.EndOfDirectiveToken, node.IsActive, node.BranchTaken, node.ConditionValue)
    | _ -> None

  let (|ElseDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ElseKeyword, node.EndOfDirectiveToken, node.IsActive, node.BranchTaken)
    | _ -> None

  let (|EndIfDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndIfKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|RegionDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.RegionKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|EndRegionDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndRegionKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|ErrorDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ErrorKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|WarningDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.WarningKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|BadDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.Identifier, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|DefineDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.DefineKeyword, node.Name, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|UndefDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.UndefKeyword, node.Name, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|LineDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.LineKeyword, node.Line, node.File, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|PragmaWarningDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.PragmaKeyword, node.WarningKeyword, node.DisableOrRestoreKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|PragmaChecksumDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.PragmaKeyword, node.ChecksumKeyword, node.File, node.Guid, node.Bytes, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|ReferenceDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ReferenceKeyword, node.File, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|LoadDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.LoadKeyword, node.File, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|ShebangDirectiveTriviaSyntax|_|) (node:Microsoft.CodeAnalysis.SyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ExclamationToken, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

