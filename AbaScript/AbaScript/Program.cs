using AbaScript;
using AbaScript.AntlrClasses;
using Antlr4.Runtime;

var input = System.IO.File.ReadAllText("C:\\Users\\raybe\\abascript\\AbaScript\\AbaScript\\example.as");
var lexer = new AbaScriptLexer(new AntlrInputStream(input));
var tokens = new CommonTokenStream(lexer);
var parser = new AbaScriptParser(tokens);

var tree = parser.script();
var visitor = new AbaScriptCustomVisitor();
visitor.Visit(tree);
