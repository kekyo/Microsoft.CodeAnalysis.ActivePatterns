// This is auto-generated source code by Microsoft.CodeAnalysis.ActivePatterns, DO NOT EDIT!

namespace Microsoft.CodeAnalysis.CSharp.Strict

[<AutoOpen>]
module ActivePatterns =

  let (|IdentifierName|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax as node ->
      Some (node.Identifier)
    | _ -> None

  let (|QualifiedName|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax as node ->
      Some (node.Left, node.DotToken, node.Right)
    | _ -> None

  let (|GenericName|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax as node ->
      Some (node.Identifier, node.TypeArgumentList, node.IsUnboundGenericName)
    | _ -> None

  let (|TypeArgumentList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax as node ->
      Some (node.LessThanToken, node.GreaterThanToken)
    | _ -> None

  let (|AliasQualifiedName|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax as node ->
      Some (node.Alias, node.ColonColonToken, node.Name)
    | _ -> None

  let (|PredefinedType|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax as node ->
      Some (node.Keyword)
    | _ -> None

  let (|ArrayType|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax as node ->
      Some (node.ElementType, node.RankSpecifiers |> Seq.toList)
    | _ -> None

  let (|ArrayRankSpecifier|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax as node ->
      Some (node.OpenBracketToken, node.CloseBracketToken, node.Rank)
    | _ -> None

  let (|PointerType|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax as node ->
      Some (node.ElementType, node.AsteriskToken)
    | _ -> None

  let (|NullableType|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax as node ->
      Some (node.ElementType, node.QuestionToken)
    | _ -> None

  let (|TupleType|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|TupleElement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax as node ->
      Some (node.Type, node.Identifier)
    | _ -> None

  let (|OmittedTypeArgument|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax as node ->
      Some (node.OmittedTypeArgumentToken)
    | _ -> None

  let (|RefType|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax as node ->
      Some (node.RefKeyword, node.ReadOnlyKeyword, node.Type)
    | _ -> None

  let (|ParenthesizedExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax as node ->
      Some (node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|TupleExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|PrefixUnaryExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax as node ->
      Some (node.OperatorToken, node.Operand)
    | _ -> None

  let (|AwaitExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax as node ->
      Some (node.AwaitKeyword, node.Expression)
    | _ -> None

  let (|PostfixUnaryExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax as node ->
      Some (node.Operand, node.OperatorToken)
    | _ -> None

  let (|MemberAccessExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax as node ->
      Some (node.Expression, node.OperatorToken, node.Name)
    | _ -> None

  let (|ConditionalAccessExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax as node ->
      Some (node.Expression, node.OperatorToken, node.WhenNotNull)
    | _ -> None

  let (|MemberBindingExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax as node ->
      Some (node.OperatorToken, node.Name)
    | _ -> None

  let (|ElementBindingExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax as node ->
      Some (node.ArgumentList)
    | _ -> None

  let (|ImplicitElementAccess|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax as node ->
      Some (node.ArgumentList)
    | _ -> None

  let (|BinaryExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax as node ->
      Some (node.Left, node.OperatorToken, node.Right)
    | _ -> None

  let (|AssignmentExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax as node ->
      Some (node.Left, node.OperatorToken, node.Right)
    | _ -> None

  let (|ConditionalExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax as node ->
      Some (node.Condition, node.QuestionToken, node.WhenTrue, node.ColonToken, node.WhenFalse)
    | _ -> None

  let (|ThisExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax as node ->
      Some (node.Token)
    | _ -> None

  let (|BaseExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax as node ->
      Some (node.Token)
    | _ -> None

  let (|LiteralExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax as node ->
      Some (node.Token)
    | _ -> None

  let (|MakeRefExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|RefTypeExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|RefValueExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.Comma, node.Type, node.CloseParenToken)
    | _ -> None

  let (|CheckedExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Expression, node.CloseParenToken)
    | _ -> None

  let (|DefaultExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|TypeOfExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|SizeOfExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax as node ->
      Some (node.Keyword, node.OpenParenToken, node.Type, node.CloseParenToken)
    | _ -> None

  let (|InvocationExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax as node ->
      Some (node.Expression, node.ArgumentList)
    | _ -> None

  let (|ElementAccessExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax as node ->
      Some (node.Expression, node.ArgumentList)
    | _ -> None

  let (|ArgumentList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|BracketedArgumentList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax as node ->
      Some (node.OpenBracketToken, node.CloseBracketToken)
    | _ -> None

  let (|Argument|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax as node ->
      Some (node.NameColon, node.RefKindKeyword, node.Expression, node.RefOrOutKeyword)
    | _ -> None

  let (|NameColon|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax as node ->
      Some (node.Name, node.ColonToken)
    | _ -> None

  let (|DeclarationExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax as node ->
      Some (node.Type, node.Designation)
    | _ -> None

  let (|CastExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax as node ->
      Some (node.OpenParenToken, node.Type, node.CloseParenToken, node.Expression)
    | _ -> None

  let (|AnonymousMethodExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax as node ->
      Some (node.AsyncKeyword, node.DelegateKeyword, node.ParameterList, node.Body, node.Block)
    | _ -> None

  let (|SimpleLambdaExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax as node ->
      Some (node.AsyncKeyword, node.Parameter, node.ArrowToken, node.Body)
    | _ -> None

  let (|RefExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.RefExpressionSyntax as node ->
      Some (node.RefKeyword, node.Expression)
    | _ -> None

  let (|ParenthesizedLambdaExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax as node ->
      Some (node.AsyncKeyword, node.ParameterList, node.ArrowToken, node.Body)
    | _ -> None

  let (|InitializerExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax as node ->
      Some (node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|ObjectCreationExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.Type, node.ArgumentList, node.Initializer)
    | _ -> None

  let (|AnonymousObjectMemberDeclarator|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax as node ->
      Some (node.NameEquals, node.Expression)
    | _ -> None

  let (|AnonymousObjectCreationExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.OpenBraceToken, node.CloseBraceToken)
    | _ -> None

  let (|ArrayCreationExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.Type, node.Initializer)
    | _ -> None

  let (|ImplicitArrayCreationExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax as node ->
      Some (node.NewKeyword, node.OpenBracketToken, node.CloseBracketToken, node.Initializer)
    | _ -> None

  let (|StackAllocArrayCreationExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax as node ->
      Some (node.StackAllocKeyword, node.Type, node.Initializer)
    | _ -> None

  let (|ImplicitStackAllocArrayCreationExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitStackAllocArrayCreationExpressionSyntax as node ->
      Some (node.StackAllocKeyword, node.OpenBracketToken, node.CloseBracketToken, node.Initializer)
    | _ -> None

  let (|QueryExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax as node ->
      Some (node.FromClause, node.Body)
    | _ -> None

  let (|QueryBody|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax as node ->
      Some (node.Clauses |> Seq.toList, node.SelectOrGroup, node.Continuation)
    | _ -> None

  let (|FromClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax as node ->
      Some (node.FromKeyword, node.Type, node.Identifier, node.InKeyword, node.Expression)
    | _ -> None

  let (|LetClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax as node ->
      Some (node.LetKeyword, node.Identifier, node.EqualsToken, node.Expression)
    | _ -> None

  let (|JoinClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax as node ->
      Some (node.JoinKeyword, node.Type, node.Identifier, node.InKeyword, node.InExpression, node.OnKeyword, node.LeftExpression, node.EqualsKeyword, node.RightExpression, node.Into)
    | _ -> None

  let (|JoinIntoClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax as node ->
      Some (node.IntoKeyword, node.Identifier)
    | _ -> None

  let (|WhereClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax as node ->
      Some (node.WhereKeyword, node.Condition)
    | _ -> None

  let (|OrderByClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax as node ->
      Some (node.OrderByKeyword)
    | _ -> None

  let (|Ordering|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax as node ->
      Some (node.Expression, node.AscendingOrDescendingKeyword)
    | _ -> None

  let (|SelectClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax as node ->
      Some (node.SelectKeyword, node.Expression)
    | _ -> None

  let (|GroupClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax as node ->
      Some (node.GroupKeyword, node.GroupExpression, node.ByKeyword, node.ByExpression)
    | _ -> None

  let (|QueryContinuation|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax as node ->
      Some (node.IntoKeyword, node.Identifier, node.Body)
    | _ -> None

  let (|OmittedArraySizeExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax as node ->
      Some (node.OmittedArraySizeExpressionToken)
    | _ -> None

  let (|InterpolatedStringExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax as node ->
      Some (node.StringStartToken, node.Contents |> Seq.toList, node.StringEndToken)
    | _ -> None

  let (|IsPatternExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IsPatternExpressionSyntax as node ->
      Some (node.Expression, node.IsKeyword, node.Pattern)
    | _ -> None

  let (|ThrowExpression|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ThrowExpressionSyntax as node ->
      Some (node.ThrowKeyword, node.Expression)
    | _ -> None

  let (|WhenClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax as node ->
      Some (node.WhenKeyword, node.Condition)
    | _ -> None

  let (|DeclarationPattern|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax as node ->
      Some (node.Type, node.Designation)
    | _ -> None

  let (|ConstantPattern|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConstantPatternSyntax as node ->
      Some (node.Expression)
    | _ -> None

  let (|InterpolatedStringText|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringTextSyntax as node ->
      Some (node.TextToken)
    | _ -> None

  let (|Interpolation|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax as node ->
      Some (node.OpenBraceToken, node.Expression, node.AlignmentClause, node.FormatClause, node.CloseBraceToken)
    | _ -> None

  let (|InterpolationAlignmentClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax as node ->
      Some (node.CommaToken, node.Value)
    | _ -> None

  let (|InterpolationFormatClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax as node ->
      Some (node.ColonToken, node.FormatStringToken)
    | _ -> None

  let (|GlobalStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax as node ->
      Some (node.Statement)
    | _ -> None

  let (|Block|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax as node ->
      Some (node.OpenBraceToken, node.Statements |> Seq.toList, node.CloseBraceToken)
    | _ -> None

  let (|LocalFunctionStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax as node ->
      Some (node.ReturnType, node.Identifier, node.TypeParameterList, node.ParameterList, node.ConstraintClauses |> Seq.toList, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|LocalDeclarationStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax as node ->
      Some (node.Declaration, node.SemicolonToken, node.IsConst)
    | _ -> None

  let (|VariableDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|VariableDeclarator|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax as node ->
      Some (node.Identifier, node.ArgumentList, node.Initializer)
    | _ -> None

  let (|EqualsValueClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax as node ->
      Some (node.EqualsToken, node.Value)
    | _ -> None

  let (|SingleVariableDesignation|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax as node ->
      Some (node.Identifier)
    | _ -> None

  let (|DiscardDesignation|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DiscardDesignationSyntax as node ->
      Some (node.UnderscoreToken)
    | _ -> None

  let (|ParenthesizedVariableDesignation|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|ExpressionStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax as node ->
      Some (node.Expression, node.SemicolonToken, node.AllowsAnyExpression)
    | _ -> None

  let (|EmptyStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax as node ->
      Some (node.SemicolonToken)
    | _ -> None

  let (|LabeledStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax as node ->
      Some (node.Identifier, node.ColonToken, node.Statement)
    | _ -> None

  let (|GotoStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax as node ->
      Some (node.GotoKeyword, node.CaseOrDefaultKeyword, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|BreakStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax as node ->
      Some (node.BreakKeyword, node.SemicolonToken)
    | _ -> None

  let (|ContinueStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax as node ->
      Some (node.ContinueKeyword, node.SemicolonToken)
    | _ -> None

  let (|ReturnStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax as node ->
      Some (node.ReturnKeyword, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|ThrowStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax as node ->
      Some (node.ThrowKeyword, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|YieldStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax as node ->
      Some (node.YieldKeyword, node.ReturnOrBreakKeyword, node.Expression, node.SemicolonToken)
    | _ -> None

  let (|WhileStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax as node ->
      Some (node.WhileKeyword, node.OpenParenToken, node.Condition, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|DoStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax as node ->
      Some (node.DoKeyword, node.Statement, node.WhileKeyword, node.OpenParenToken, node.Condition, node.CloseParenToken, node.SemicolonToken)
    | _ -> None

  let (|ForStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax as node ->
      Some (node.ForKeyword, node.OpenParenToken, node.Declaration, node.FirstSemicolonToken, node.Condition, node.SecondSemicolonToken, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|ForEachStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax as node ->
      Some (node.ForEachKeyword, node.OpenParenToken, node.Type, node.Identifier, node.InKeyword, node.Expression, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|ForEachVariableStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax as node ->
      Some (node.ForEachKeyword, node.OpenParenToken, node.Variable, node.InKeyword, node.Expression, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|UsingStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax as node ->
      Some (node.UsingKeyword, node.OpenParenToken, node.Declaration, node.Expression, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|FixedStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax as node ->
      Some (node.FixedKeyword, node.OpenParenToken, node.Declaration, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|CheckedStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax as node ->
      Some (node.Keyword, node.Block)
    | _ -> None

  let (|UnsafeStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax as node ->
      Some (node.UnsafeKeyword, node.Block)
    | _ -> None

  let (|LockStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax as node ->
      Some (node.LockKeyword, node.OpenParenToken, node.Expression, node.CloseParenToken, node.Statement)
    | _ -> None

  let (|IfStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax as node ->
      Some (node.IfKeyword, node.OpenParenToken, node.Condition, node.CloseParenToken, node.Statement, node.Else)
    | _ -> None

  let (|ElseClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax as node ->
      Some (node.ElseKeyword, node.Statement)
    | _ -> None

  let (|SwitchStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax as node ->
      Some (node.SwitchKeyword, node.OpenParenToken, node.Expression, node.CloseParenToken, node.OpenBraceToken, node.Sections |> Seq.toList, node.CloseBraceToken)
    | _ -> None

  let (|SwitchSection|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax as node ->
      Some (node.Labels |> Seq.toList, node.Statements |> Seq.toList)
    | _ -> None

  let (|CasePatternSwitchLabel|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax as node ->
      Some (node.Keyword, node.Pattern, node.WhenClause, node.ColonToken)
    | _ -> None

  let (|CaseSwitchLabel|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax as node ->
      Some (node.Keyword, node.Value, node.ColonToken)
    | _ -> None

  let (|DefaultSwitchLabel|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax as node ->
      Some (node.Keyword, node.ColonToken)
    | _ -> None

  let (|TryStatement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax as node ->
      Some (node.TryKeyword, node.Block, node.Catches |> Seq.toList, node.Finally)
    | _ -> None

  let (|CatchClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax as node ->
      Some (node.CatchKeyword, node.Declaration, node.Filter, node.Block)
    | _ -> None

  let (|CatchDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax as node ->
      Some (node.OpenParenToken, node.Type, node.Identifier, node.CloseParenToken)
    | _ -> None

  let (|CatchFilterClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax as node ->
      Some (node.WhenKeyword, node.OpenParenToken, node.FilterExpression, node.CloseParenToken)
    | _ -> None

  let (|FinallyClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax as node ->
      Some (node.FinallyKeyword, node.Block)
    | _ -> None

  let (|CompilationUnit|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax as node ->
      Some (node.Externs |> Seq.toList, node.Usings |> Seq.toList, node.AttributeLists |> Seq.toList, node.Members |> Seq.toList, node.EndOfFileToken)
    | _ -> None

  let (|ExternAliasDirective|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax as node ->
      Some (node.ExternKeyword, node.AliasKeyword, node.Identifier, node.SemicolonToken)
    | _ -> None

  let (|UsingDirective|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax as node ->
      Some (node.UsingKeyword, node.StaticKeyword, node.Alias, node.Name, node.SemicolonToken)
    | _ -> None

  let (|NamespaceDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax as node ->
      Some (node.NamespaceKeyword, node.Name, node.OpenBraceToken, node.Externs |> Seq.toList, node.Usings |> Seq.toList, node.Members |> Seq.toList, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|AttributeList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax as node ->
      Some (node.OpenBracketToken, node.Target, node.CloseBracketToken)
    | _ -> None

  let (|AttributeTargetSpecifier|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax as node ->
      Some (node.Identifier, node.ColonToken)
    | _ -> None

  let (|Attribute|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax as node ->
      Some (node.Name, node.ArgumentList)
    | _ -> None

  let (|AttributeArgumentList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|AttributeArgument|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax as node ->
      Some (node.NameEquals, node.NameColon, node.Expression)
    | _ -> None

  let (|NameEquals|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax as node ->
      Some (node.Name, node.EqualsToken)
    | _ -> None

  let (|TypeParameterList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax as node ->
      Some (node.LessThanToken, node.GreaterThanToken)
    | _ -> None

  let (|TypeParameter|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.VarianceKeyword, node.Identifier)
    | _ -> None

  let (|ClassDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Keyword, node.Identifier, node.TypeParameterList, node.BaseList, node.ConstraintClauses |> Seq.toList, node.OpenBraceToken, node.Members |> Seq.toList, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|StructDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Keyword, node.Identifier, node.TypeParameterList, node.BaseList, node.ConstraintClauses |> Seq.toList, node.OpenBraceToken, node.Members |> Seq.toList, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|InterfaceDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Keyword, node.Identifier, node.TypeParameterList, node.BaseList, node.ConstraintClauses |> Seq.toList, node.OpenBraceToken, node.Members |> Seq.toList, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|EnumDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.EnumKeyword, node.Identifier, node.BaseList, node.OpenBraceToken, node.CloseBraceToken, node.SemicolonToken)
    | _ -> None

  let (|DelegateDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.DelegateKeyword, node.ReturnType, node.Identifier, node.TypeParameterList, node.ParameterList, node.ConstraintClauses |> Seq.toList, node.SemicolonToken, node.Arity)
    | _ -> None

  let (|EnumMemberDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Identifier, node.EqualsValue)
    | _ -> None

  let (|BaseList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax as node ->
      Some (node.ColonToken)
    | _ -> None

  let (|SimpleBaseType|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|TypeParameterConstraintClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax as node ->
      Some (node.WhereKeyword, node.Name, node.ColonToken)
    | _ -> None

  let (|ConstructorConstraint|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax as node ->
      Some (node.NewKeyword, node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|ClassOrStructConstraint|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax as node ->
      Some (node.ClassOrStructKeyword)
    | _ -> None

  let (|TypeConstraint|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|FieldDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Declaration, node.SemicolonToken)
    | _ -> None

  let (|EventFieldDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.EventKeyword, node.Declaration, node.SemicolonToken)
    | _ -> None

  let (|ExplicitInterfaceSpecifier|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax as node ->
      Some (node.Name, node.DotToken)
    | _ -> None

  let (|MethodDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ReturnType, node.ExplicitInterfaceSpecifier, node.Identifier, node.TypeParameterList, node.ParameterList, node.ConstraintClauses |> Seq.toList, node.Body, node.ExpressionBody, node.SemicolonToken, node.Arity)
    | _ -> None

  let (|OperatorDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ReturnType, node.OperatorKeyword, node.OperatorToken, node.ParameterList, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|ConversionOperatorDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.ImplicitOrExplicitKeyword, node.OperatorKeyword, node.Type, node.ParameterList, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|ConstructorDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Identifier, node.ParameterList, node.Initializer, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|ConstructorInitializer|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax as node ->
      Some (node.ColonToken, node.ThisOrBaseKeyword, node.ArgumentList)
    | _ -> None

  let (|DestructorDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.TildeToken, node.Identifier, node.ParameterList, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|PropertyDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Type, node.ExplicitInterfaceSpecifier, node.Identifier, node.AccessorList, node.ExpressionBody, node.Initializer, node.SemicolonToken)
    | _ -> None

  let (|ArrowExpressionClause|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax as node ->
      Some (node.ArrowToken, node.Expression)
    | _ -> None

  let (|EventDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.EventKeyword, node.Type, node.ExplicitInterfaceSpecifier, node.Identifier, node.AccessorList)
    | _ -> None

  let (|IndexerDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Type, node.ExplicitInterfaceSpecifier, node.ThisKeyword, node.ParameterList, node.AccessorList, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|AccessorList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax as node ->
      Some (node.OpenBraceToken, node.Accessors |> Seq.toList, node.CloseBraceToken)
    | _ -> None

  let (|AccessorDeclaration|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Keyword, node.Body, node.ExpressionBody, node.SemicolonToken)
    | _ -> None

  let (|ParameterList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|BracketedParameterList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax as node ->
      Some (node.OpenBracketToken, node.CloseBracketToken)
    | _ -> None

  let (|Parameter|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Type, node.Identifier, node.Default)
    | _ -> None

  let (|IncompleteMember|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax as node ->
      Some (node.AttributeLists |> Seq.toList, node.Type)
    | _ -> None

  let (|DocumentationCommentTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax as node ->
      Some (node.Content |> Seq.toList, node.EndOfComment)
    | _ -> None

  let (|TypeCref|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax as node ->
      Some (node.Type)
    | _ -> None

  let (|QualifiedCref|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax as node ->
      Some (node.Container, node.DotToken, node.Member)
    | _ -> None

  let (|NameMemberCref|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax as node ->
      Some (node.Name, node.Parameters)
    | _ -> None

  let (|IndexerMemberCref|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax as node ->
      Some (node.ThisKeyword, node.Parameters)
    | _ -> None

  let (|OperatorMemberCref|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax as node ->
      Some (node.OperatorKeyword, node.OperatorToken, node.Parameters)
    | _ -> None

  let (|ConversionOperatorMemberCref|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax as node ->
      Some (node.ImplicitOrExplicitKeyword, node.OperatorKeyword, node.Type, node.Parameters)
    | _ -> None

  let (|CrefParameterList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax as node ->
      Some (node.OpenParenToken, node.CloseParenToken)
    | _ -> None

  let (|CrefBracketedParameterList|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax as node ->
      Some (node.OpenBracketToken, node.CloseBracketToken)
    | _ -> None

  let (|CrefParameter|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax as node ->
      Some (node.RefKindKeyword, node.Type, node.RefOrOutKeyword)
    | _ -> None

  let (|XmlElement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax as node ->
      Some (node.StartTag, node.Content |> Seq.toList, node.EndTag)
    | _ -> None

  let (|XmlElementStartTag|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax as node ->
      Some (node.LessThanToken, node.Name, node.Attributes |> Seq.toList, node.GreaterThanToken)
    | _ -> None

  let (|XmlElementEndTag|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax as node ->
      Some (node.LessThanSlashToken, node.Name, node.GreaterThanToken)
    | _ -> None

  let (|XmlEmptyElement|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax as node ->
      Some (node.LessThanToken, node.Name, node.Attributes |> Seq.toList, node.SlashGreaterThanToken)
    | _ -> None

  let (|XmlName|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax as node ->
      Some (node.Prefix, node.LocalName)
    | _ -> None

  let (|XmlPrefix|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax as node ->
      Some (node.Prefix, node.ColonToken)
    | _ -> None

  let (|XmlTextAttribute|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.EndQuoteToken)
    | _ -> None

  let (|XmlCrefAttribute|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.Cref, node.EndQuoteToken)
    | _ -> None

  let (|XmlNameAttribute|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax as node ->
      Some (node.Name, node.EqualsToken, node.StartQuoteToken, node.Identifier, node.EndQuoteToken)
    | _ -> None

  let (|XmlCDataSection|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax as node ->
      Some (node.StartCDataToken, node.EndCDataToken)
    | _ -> None

  let (|XmlProcessingInstruction|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax as node ->
      Some (node.StartProcessingInstructionToken, node.Name, node.EndProcessingInstructionToken)
    | _ -> None

  let (|XmlComment|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax as node ->
      Some (node.LessThanExclamationMinusMinusToken, node.MinusMinusGreaterThanToken)
    | _ -> None

  let (|IfDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.IfKeyword, node.Condition, node.EndOfDirectiveToken, node.IsActive, node.BranchTaken, node.ConditionValue)
    | _ -> None

  let (|ElifDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ElifKeyword, node.Condition, node.EndOfDirectiveToken, node.IsActive, node.BranchTaken, node.ConditionValue)
    | _ -> None

  let (|ElseDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ElseKeyword, node.EndOfDirectiveToken, node.IsActive, node.BranchTaken)
    | _ -> None

  let (|EndIfDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndIfKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|RegionDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.RegionKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|EndRegionDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.EndRegionKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|ErrorDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ErrorKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|WarningDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.WarningKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|BadDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.Identifier, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|DefineDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.DefineKeyword, node.Name, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|UndefDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.UndefKeyword, node.Name, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|LineDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.LineKeyword, node.Line, node.File, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|PragmaWarningDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.PragmaKeyword, node.WarningKeyword, node.DisableOrRestoreKeyword, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|PragmaChecksumDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.PragmaKeyword, node.ChecksumKeyword, node.File, node.Guid, node.Bytes, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|ReferenceDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ReferenceKeyword, node.File, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|LoadDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.LoadKeyword, node.File, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

  let (|ShebangDirectiveTrivia|_|) (node:Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode) =
    match node with
    | :? Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax as node ->
      Some (node.HashToken, node.ExclamationToken, node.EndOfDirectiveToken, node.IsActive)
    | _ -> None

