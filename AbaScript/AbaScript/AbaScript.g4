﻿grammar AbaScript;

// Входная точка программы
script: (statement | functionDef)* EOF;

// Определения инструкций
statement
    : variableDeclaration
    | assignment
    | inputStatement
    | outputStatement
    | ifStatement
    | whileStatement
    | forStatement
    | returnStatement
    | funcCall
    | breakStatement
    | continueStatement
    | ';'                // Пустая строка
    ;

// Объявление переменной
variableDeclaration
    : 'var' ID ('=' expr)? ';'
    ;

// Присваивание значения переменной
assignment
    : ID '=' expr ';'
    ;

// Ввод данных
inputStatement
    : 'input' '(' ID ')' ';'
    ;

// Вывод данных
outputStatement
    : 'print' '(' expr ')' ';'
    ;

// Возврат значения из функции
returnStatement
    : 'return' expr ';'
    ;

// Условная конструкция
ifStatement
    : 'if' '(' condition ')' block
      ('elif' '(' condition ')' block)*
      ('else' block)?
    ;

// Цикл while
whileStatement
    : 'while' '(' condition ')' block
    ;

// Цикл for
forStatement
    : 'for' '(' (variableDeclaration | assignment)? condition? ';' assignment? ')' block
    ;

// Определение функции
functionDef
    : 'func' ID '(' (ID (',' ID)*)? ')' block
    ;

// Вызов функции
funcCall
    : ID '(' (expr (',' expr)*)? ')' ';'
    ;

// Блок инструкций
block
    : '{' (statement | funcCall)* '}'
    ;

// Условие (логическое выражение)
condition
    : expr comparisonOp expr
    ;

// Операции сравнения
comparisonOp
    : '==' | '!=' | '<' | '<=' | '>' | '>='
    ;

// Выражения
expr
    : expr ('+' | '-') term        # AddSub
    | term                        # TermExpr
    ;

term
    : term ('*' | '/' | '%') factor  # MulDivMod
    | factor                        # FactorTerm
    ;

factor
    : '(' expr ')'              # Parens
    | NUMBER                    # Number
    | STRING                    # String
    | ID                        # Variable
    | funcCall                  # FunctionCall
    ;

// Break statement
breakStatement
    : 'break' ';'
    ;

// Continue statement
continueStatement
    : 'continue' ';'
    ;

// Лексеры
ID: [a-zA-Z_][a-zA-Z0-9_]*;       // Идентификаторы (добавлена поддержка _)
NUMBER: [0-9]+;                   // Целые числа
STRING: '"' (~["])* '"';          // Строки
WS: [ \t\r\n]+ -> skip;           // Пробелы
COMMENT: '#' ~[\r\n]* -> skip;    // Комментарии