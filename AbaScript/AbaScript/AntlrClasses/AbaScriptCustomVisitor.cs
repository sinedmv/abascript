namespace AbaScript.AntlrClasses;

public class AbaScriptCustomVisitor : AbaScriptBaseVisitor<object>
{
    private readonly Dictionary<string, object> variables = new();
    private readonly Dictionary<string, (List<string> Parameters, AbaScriptParser.BlockContext Body)> functions = new();

    public override object VisitVariableDeclaration(AbaScriptParser.VariableDeclarationContext context)
    {
        var varName = context.ID().GetText();
        object value = null;

        if (context.expr() != null)
        {
            value = Visit(context.expr());
        }

        variables[varName] = value;
        Log($"Переменная {varName} объявлена со значением: {value} (тип: {GetType(value)})");
        return null;
    }

    
    public override object VisitVariable(AbaScriptParser.VariableContext context)
    {
        string variableName = context.GetText();

        if (!variables.TryGetValue(variableName, out var value))
            throw new InvalidOperationException($"Переменная '{variableName}' не объявлена.");

        return value;
    }
    public override object VisitAssignment(AbaScriptParser.AssignmentContext context)
    {
        var varName = context.ID().GetText();
        var value = Visit(context.expr());
        variables[varName] = value;

        Console.WriteLine($"Переменная {varName} обновлена: {value} (тип: {GetType(value)})");
        return null;
    }

    public override object VisitAddSub(AbaScriptParser.AddSubContext context)
    {
        var left = Visit(context.expr());
        var right = Visit(context.term());

        // Determine the operator by checking the text of the middle child
        var operatorText = context.GetChild(1).GetText();

        Console.WriteLine($"DEBUG: left={left}, right={right}, leftType={left?.GetType()}, rightType={right?.GetType()}");

        return operatorText switch
        {
            "+" => Add(left, right),
            "-" => Subtract(left, right),
            _ => throw new InvalidOperationException("Unsupported operation")
        };
    }

    private object Add(object left, object right)
    {
        return left switch
        {
            string leftStr when right is string rightStr => leftStr + rightStr,
            int leftInt when right is int rightInt => leftInt + rightInt,
            _ => throw new InvalidOperationException($"Несовместимые типы для операции '+': {left}, {right}")
        };
    }

    private object Subtract(object left, object right)
    {
        if (left is int leftInt && right is int rightInt)
        {
            return leftInt - rightInt;
        }
        throw new InvalidOperationException($"Несовместимые типы для операции '-': {left}, {right}");
    }
    
    public override object VisitMulDivMod(AbaScriptParser.MulDivModContext context)
    {
        var left = Visit(context.term());
        var right = Visit(context.factor());

        // Determine the operator by checking the text of the middle child
        var operatorText = context.GetChild(1).GetText();

        Console.WriteLine($"DEBUG: left={left}, right={right}, leftType={left?.GetType()}, rightType={right?.GetType()}");

        return operatorText switch
        {
            "*" => Multiply(left, right),
            "/" => Divide(left, right),
            "%" => Modulus(left, right),
            _ => throw new InvalidOperationException("Unsupported operation")
        };
    }

    private object Multiply(object left, object right)
    {
        if (left is int leftInt && right is int rightInt)
        {
            return leftInt * rightInt;
        }
        throw new InvalidOperationException($"Несовместимые типы для операции '*': {left}, {right}");
    }

    private object Divide(object left, object right)
    {
        if (left is int leftInt && right is int rightInt)
        {
            if (rightInt == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            return leftInt / rightInt;
        }
        throw new InvalidOperationException($"Несовместимые типы для операции '/': {left}, {right}");
    }

    private object Modulus(object left, object right)
    {
        if (left is int leftInt && right is int rightInt)
        {
            if (rightInt == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            return leftInt % rightInt;
        }
        throw new InvalidOperationException($"Несовместимые типы для операции '%': {left}, {right}");
    }
    
    public override object VisitIfStatement(AbaScriptParser.IfStatementContext context)
    {
        for (int i = 0; i < context.logicalExpr().Length; i++)
        {
            var conditionResult = (bool)Visit(context.logicalExpr(i));
            if (conditionResult)
            {
                Visit(context.block(i));
                return null;
            }
        }

        if (context.block().Length > context.logicalExpr().Length)
        {
            Visit(context.block(context.logicalExpr().Length)); // Блок else
        }

        return null;
    }
    
    public override object VisitLogicalExpr(AbaScriptParser.LogicalExprContext context)
    {
        switch (context)
        {
            case AbaScriptParser.AndExprContext andExpr:
            {
                var left = (bool)Visit(andExpr.logicalExpr());
                var right = (bool)Visit(andExpr.condition());
                return left && right;
            }
            case AbaScriptParser.OrExprContext orExpr:
            {
                var left = (bool)Visit(orExpr.logicalExpr());
                var right = (bool)Visit(orExpr.condition());
                return left || right;
            }
            case AbaScriptParser.ConditionExprContext conditionExpr:
                return Visit(conditionExpr.condition());
            default:
                throw new InvalidOperationException("Unsupported logical expression");
        }
    }
    
    public override object VisitCondition(AbaScriptParser.ConditionContext context)
    {
        var left = Visit(context.expr(0));
        var right = Visit(context.expr(1));
        var operatorText = context.comparisonOp().GetText();

        return operatorText switch
        {
            "==" => Equals(left, right),
            "!=" => !Equals(left, right),
            "<" => (int)left < (int)right,
            "<=" => (int)left <= (int)right,
            ">" => (int)left > (int)right,
            ">=" => (int)left >= (int)right,
            _ => throw new InvalidOperationException("Unsupported comparison operation")
        };
    }

    public override object VisitNumber(AbaScriptParser.NumberContext context)
    {
        if (int.TryParse(context.GetText(), out var number))
        {
            return number;
        }
        throw new InvalidOperationException($"Невозможно преобразовать в число: {context.GetText()}");
    }

    public override object VisitString(AbaScriptParser.StringContext context)
    {
        return context.GetText().Trim('"'); // Убираем кавычки
    }

    public override object VisitOutputStatement(AbaScriptParser.OutputStatementContext context)
    {
        var value = Visit(context.expr());
        Console.WriteLine(value);
        return null;
    }
    
    public override object VisitForStatement(AbaScriptParser.ForStatementContext context)
    {
        // Initialize the loop variable
        Visit(context.assignment(0));

        while (true)
        {
            // Evaluate the loop condition
            var conditionResult = Visit(context.logicalExpr());
            if (conditionResult is not true)
            {
                break;
            }

            // Execute the loop body
            Visit(context.block());

            // Perform the increment step
            Visit(context.assignment(1));
        }
        return null;
    }

    public override object VisitWhileStatement(AbaScriptParser.WhileStatementContext context)
    {
        while (true)
        {
            var conditionResult = Visit(context.logicalExpr());
            if (conditionResult is not bool boolResult)
            {
                throw new InvalidOperationException("The condition must evaluate to a boolean value.");
            }
            if (!boolResult)
            {
                break;
            }

            try
            {
                Visit(context.block());
            }
            catch (BreakException)
            {
                break;
            }
            catch (ContinueException)
            {
                continue;
            }
        }
        return null;
    }
    public override object VisitBreakStatement(AbaScriptParser.BreakStatementContext context)
    {
        throw new BreakException();
    }

    public override object VisitContinueStatement(AbaScriptParser.ContinueStatementContext context)
    {
        throw new ContinueException();
    }
    public override object VisitFunctionDef(AbaScriptParser.FunctionDefContext context)
    {
        var funcName = context.ID(0).GetText();
        var parameters = context.ID().Skip(1).Select(p => p.GetText()).ToList(); // Параметры функции
        functions[funcName] = (parameters, context.block());
        Console.WriteLine($"Функция {funcName} определена с параметрами: {string.Join(", ", parameters)}");
        return null;
    }
    
    public override object VisitFuncCall(AbaScriptParser.FuncCallContext context)
    {
        var funcName = context.ID().GetText();

        if (!functions.TryGetValue(funcName, out var functionInfo))
            throw new InvalidOperationException($"Функция '{funcName}' не определена.");

        var arguments = context.expr().Select(expr => Visit(expr)).ToList();

        if (arguments.Count != functionInfo.Parameters.Count)
            throw new InvalidOperationException($"Количество аргументов не совпадает для функции '{funcName}'.");

        // Сохраняем текущие переменные
        var oldVariables = new Dictionary<string, object>(variables);

        // Создаём локальный контекст переменных
        variables.Clear();
        for (int i = 0; i < arguments.Count; i++)
            variables[functionInfo.Parameters[i]] = arguments[i];

        try
        {
            Visit(functionInfo.Body);
        }
        catch (ReturnException ex)
        {
            return ex.ReturnValue; // Возвращаем значение из функции
        }
        finally
        {
            // Восстанавливаем глобальные переменные
            variables.Clear();
            foreach (var kvp in oldVariables)
                variables[kvp.Key] = kvp.Value;
        }

        return null; // Если return не вызван
    }
    
    public override object VisitReturnStatement(AbaScriptParser.ReturnStatementContext context)
    {
        var returnValue = Visit(context.expr());
        throw new ReturnException(returnValue);
    }

    
    private string GetType(object value)
    {
        return value switch
        {
            int => "INT",
            string => "STRING",
            _ => "UNKNOWN"
        };
    }
    
    private static void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
