namespace AbaScript.AntlrClasses;

using System;

public class AbaScriptCustomListener : AbaScriptBaseListener
{
    public override void EnterVariableDeclaration(AbaScriptParser.VariableDeclarationContext context)
    {
        var varName = context.ID().GetText();
        Console.WriteLine($"Объявлена переменная: {varName}");
    }

    public override void EnterAssignment(AbaScriptParser.AssignmentContext context)
    {
        var varName = context.ID().GetText();
        Console.WriteLine($"Присваивание переменной: {varName}");
    }

    public override void EnterOutputStatement(AbaScriptParser.OutputStatementContext context)
    {
        Console.WriteLine("Вывод данных:");
    }
}
