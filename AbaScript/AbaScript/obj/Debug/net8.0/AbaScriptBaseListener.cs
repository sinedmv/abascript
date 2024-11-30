﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\raybe\abascript\AbaScript\AbaScript\AbaScript.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AbaScript {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IAbaScriptListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class AbaScriptBaseListener : IAbaScriptListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>AndExpr</c>
	/// labeled alternative in <see cref="AbaScriptParser.logicalExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndExpr([NotNull] AbaScriptParser.AndExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AndExpr</c>
	/// labeled alternative in <see cref="AbaScriptParser.logicalExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndExpr([NotNull] AbaScriptParser.AndExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>OrExpr</c>
	/// labeled alternative in <see cref="AbaScriptParser.logicalExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrExpr([NotNull] AbaScriptParser.OrExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OrExpr</c>
	/// labeled alternative in <see cref="AbaScriptParser.logicalExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrExpr([NotNull] AbaScriptParser.OrExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ConditionExpr</c>
	/// labeled alternative in <see cref="AbaScriptParser.logicalExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionExpr([NotNull] AbaScriptParser.ConditionExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ConditionExpr</c>
	/// labeled alternative in <see cref="AbaScriptParser.logicalExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionExpr([NotNull] AbaScriptParser.ConditionExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="AbaScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSub([NotNull] AbaScriptParser.AddSubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="AbaScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSub([NotNull] AbaScriptParser.AddSubContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>TermExpr</c>
	/// labeled alternative in <see cref="AbaScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTermExpr([NotNull] AbaScriptParser.TermExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TermExpr</c>
	/// labeled alternative in <see cref="AbaScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTermExpr([NotNull] AbaScriptParser.TermExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>MulDivMod</c>
	/// labeled alternative in <see cref="AbaScriptParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDivMod([NotNull] AbaScriptParser.MulDivModContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDivMod</c>
	/// labeled alternative in <see cref="AbaScriptParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDivMod([NotNull] AbaScriptParser.MulDivModContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>FactorTerm</c>
	/// labeled alternative in <see cref="AbaScriptParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactorTerm([NotNull] AbaScriptParser.FactorTermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FactorTerm</c>
	/// labeled alternative in <see cref="AbaScriptParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactorTerm([NotNull] AbaScriptParser.FactorTermContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Parens</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParens([NotNull] AbaScriptParser.ParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Parens</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParens([NotNull] AbaScriptParser.ParensContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumber([NotNull] AbaScriptParser.NumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumber([NotNull] AbaScriptParser.NumberContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] AbaScriptParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] AbaScriptParser.StringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>VariableorArrayAccess</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableorArrayAccess([NotNull] AbaScriptParser.VariableorArrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>VariableorArrayAccess</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableorArrayAccess([NotNull] AbaScriptParser.VariableorArrayAccessContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionCall</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] AbaScriptParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionCall</c>
	/// labeled alternative in <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] AbaScriptParser.FunctionCallContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.script"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterScript([NotNull] AbaScriptParser.ScriptContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.script"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitScript([NotNull] AbaScriptParser.ScriptContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] AbaScriptParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] AbaScriptParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaration([NotNull] AbaScriptParser.VariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaration([NotNull] AbaScriptParser.VariableDeclarationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] AbaScriptParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] AbaScriptParser.AssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.inputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInputStatement([NotNull] AbaScriptParser.InputStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.inputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInputStatement([NotNull] AbaScriptParser.InputStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.outputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOutputStatement([NotNull] AbaScriptParser.OutputStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.outputStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOutputStatement([NotNull] AbaScriptParser.OutputStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] AbaScriptParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] AbaScriptParser.ReturnStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] AbaScriptParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] AbaScriptParser.IfStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] AbaScriptParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] AbaScriptParser.WhileStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] AbaScriptParser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] AbaScriptParser.ForStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.functionDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDef([NotNull] AbaScriptParser.FunctionDefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.functionDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDef([NotNull] AbaScriptParser.FunctionDefContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.funcCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFuncCall([NotNull] AbaScriptParser.FuncCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.funcCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFuncCall([NotNull] AbaScriptParser.FuncCallContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] AbaScriptParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] AbaScriptParser.BlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.logicalExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalExpr([NotNull] AbaScriptParser.LogicalExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.logicalExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalExpr([NotNull] AbaScriptParser.LogicalExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] AbaScriptParser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] AbaScriptParser.ConditionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.comparisonOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonOp([NotNull] AbaScriptParser.ComparisonOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.comparisonOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonOp([NotNull] AbaScriptParser.ComparisonOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] AbaScriptParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] AbaScriptParser.ExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTerm([NotNull] AbaScriptParser.TermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTerm([NotNull] AbaScriptParser.TermContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactor([NotNull] AbaScriptParser.FactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactor([NotNull] AbaScriptParser.FactorContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreakStatement([NotNull] AbaScriptParser.BreakStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreakStatement([NotNull] AbaScriptParser.BreakStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AbaScriptParser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinueStatement([NotNull] AbaScriptParser.ContinueStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AbaScriptParser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinueStatement([NotNull] AbaScriptParser.ContinueStatementContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace AbaScript
